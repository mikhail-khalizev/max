using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Facades;
using HtmlAgilityPack;
using MikhailKhalizev.Processor.x86.InstructionDecode;
using MikhailKhalizev.Processor.x86.InstructionDecode.Dto;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Pdf.Parsing;
using Xunit;
using Path = System.IO.Path;

namespace MikhailKhalizev.Processor.x86.Tests.CodeGenerator
{
    public class CodeGenerator
    {
        public const string mnemonicCodeCsFileName = @"..\..\..\..\MikhailKhalizev.Processor.x86\src\InstructionDecode\MnemonicCode.cs";
        public const string decodeJsonFileName = @"..\..\..\..\MikhailKhalizev.Processor.x86\resources\decode.json";
        
        public const string decodeFelixcloutierJsonFileName = @"decode-felixcloutier.json";
        public const string asposePageJsonFileName = @"Aspose\Json\page-{0}.json";
        public const string bookmarksJsonFileName = @"bookmarks.json";
        
        public const string documentFolder = @"C:\Users\micky\YandexDisk\Документы\Технологии\x86\intel";
        public const string documentName = "325383-sdm-vol-2abcd.pdf";

        public const string AsposeAppSid = "9fa9e638-7858-4022-ba7f-9a99edbdeeac";
        public const string AsposeAppKey = "74b609b2f5238cdf432afdb73e8201d3";

        [Fact(Skip = "For developer")]
        public void ParseFelixcloutier()
        {
            var web = new HtmlWeb();
            web.CachePath = Path.Combine(Directory.GetCurrentDirectory(), "WebCache");
            web.UsingCache = true;
            web.UsingCacheIfExists = true;

            var urlBase = "https://www.felixcloutier.com/x86";
            var urlIndex = urlBase + "/index.html";

            var htmlDocumentIndex = web.Load(urlIndex);

            var headerNode = htmlDocumentIndex.DocumentNode.SelectNodes("//body/h2")
                .Single(x => x.InnerText == "Core Instructions");
            var indexTable = headerNode.NextSibling;
            
            var decodeMeta = new DecodeDto();
            decodeMeta.Instructions = indexTable.ChildNodes
                .Select(
                    indexItem =>
                    {
                        var node = indexItem.ChildNodes[0].FirstChild;
                        var href = node.Attributes["href"];
                        var url = href == null ? null : urlBase + href.Value.Substring(1);
                        var summary = indexItem.ChildNodes[1].InnerText;

                        return new
                        {
                            url,
                            summary
                        };
                    })
                .Where(x => x.url != null)
                .Distinct()
                .Select(
                    item =>
                    {
                        var htmlDocument = web.Load(item.url);

                        var titleNodeText = htmlDocument.DocumentNode.SelectSingleNode("//head/title").InnerText;
                        if (!titleNodeText.EndsWith(item.summary))
                            throw new InvalidOperationException();

                        var mnemonics = titleNodeText
                            .Substring(0, titleNodeText.Length - item.summary.Length)
                            .Trim('\r', '\n', '\t', ' ', '—');

                        var instruction = new InstructionDto
                        {
                            Url = item.url,
                            Mnemonics = mnemonics,
                            Summary = item.summary
                        };

                        var tables = htmlDocument.DocumentNode
                            .SelectNodes("//body/table")
                            .Select(
                                table => (Table: table, Header: table.ChildNodes["tr"]
                                    .ChildNodes
                                    .Where(x => x.Name == "th" || x.Name == "td")
                                    .Select(x => x.InnerText.TrimEnd(' ', '*'))
                                    .ToList()))
                            .ToList();

                        ParseMainTable(tables, instruction);
                        ParseOperandEncodingTable(tables, instruction);

                        return instruction;
                    })
                .Where(x => x.Url != null)
                .ToList();

            var json = JToken.FromObject(decodeMeta, JsonSerializer.CreateDefault(
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                })).ToString();

            File.WriteAllText(decodeFelixcloutierJsonFileName, json);
        }

        private static void ParseMainTable(List<(HtmlNode Table, List<string> Header)> tables, InstructionDto instruction)
        {
            var (table, header) = tables.FirstOrDefault(
                x =>
                    string.Equals(x.Header[0], "Opcode", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(x.Header[0], "Opcode Instruction", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(x.Header[0], "Opcode/Instruction", StringComparison.OrdinalIgnoreCase));
            if (table == null)
                return;

            instruction.Items = new List<InstructionItemDto>();
            
            var indexOpcode = header.FindIndex(x => string.Equals(x, "Opcode", StringComparison.OrdinalIgnoreCase));
            var indexInstruction = header.FindIndex(x => string.Equals(x, "Instruction", StringComparison.OrdinalIgnoreCase));
            var indexOpcodeInstruction =
                Math.Max(
                    header.FindIndex(x => string.Equals(x, "Opcode Instruction", StringComparison.OrdinalIgnoreCase)),
                    header.FindIndex(x => string.Equals(x, "Opcode/Instruction", StringComparison.OrdinalIgnoreCase)));

            var indexOperandEncoding = header.FindIndex(x => string.Equals(x, "Op/En", StringComparison.OrdinalIgnoreCase));
            var index64bitMode = header.FindIndex(x => string.Equals(x, "64-bit Mode", StringComparison.OrdinalIgnoreCase));
            var indexCompatLegMode = header.FindIndex(x => string.Equals(x, "Compat/Leg Mode", StringComparison.OrdinalIgnoreCase));
            var indexBit64Bit32ModeSupport = header.FindIndex(x => string.Equals(x, "64/32 bit Mode Support", StringComparison.OrdinalIgnoreCase));
            var indexCpuidFeatureFlag = header.FindIndex(x => string.Equals(x, "CPUID Feature Flag", StringComparison.OrdinalIgnoreCase));
            var indexDescription = header.FindIndex(x => string.Equals(x, "Description", StringComparison.OrdinalIgnoreCase));

            foreach (var itemNode in table.ChildNodes.Where(x => x.Name == "tr").Skip(1))
            {
                var item = new InstructionItemDto();

                var values = itemNode
                    .ChildNodes
                    .Where(x => x.Name == "td")
                    .Select(x => x.InnerText.Trim())
                    .ToList();

                if (values.Count != header.Count)
                    continue;

                if (0 <= indexOpcodeInstruction)
                {
                    var str = values[indexOpcodeInstruction];

                    item.Mnemonic =
                        str.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => x.TrimEnd('*'))
                            .Where(
                                token =>
                                {
                                    if (char.IsDigit(token[0]))
                                        return false;
                                    if (token.EndsWith(','))
                                        return false;
                                    if (token.Any(y => !char.IsLetterOrDigit(y)))
                                        return false;
                                    if (token.Where(char.IsLetter).All(char.IsLower))
                                        return false;
                                    if (Register.HasRegister(token))
                                        return false;
                                    return true;
                                })
                            .Last();

                    var index = str.IndexOf(item.Mnemonic, StringComparison.InvariantCulture);
                    item.Opcode = str.Substring(0, index).TrimEnd();
                    item.Instruction = str.Substring(index).TrimStart();
                }
                if (0 <= indexOpcode)
                    item.Opcode = values[indexOpcode];
                if (0 <= indexInstruction)
                {
                    item.Instruction = values[indexInstruction];

                    var index = item.Instruction.IndexOf(' ');
                    if (index < 0)
                        index = item.Instruction.Length;
                    item.Mnemonic = item.Instruction.Substring(0, index).TrimEnd('*');
                }

                if (0 <= indexOperandEncoding)
                    item.OperandEncoding = values[indexOperandEncoding];
                if (0 <= index64bitMode)
                    item.Bit64Mode = values[index64bitMode];
                if (0 <= indexCompatLegMode)
                    item.CompatLegMode = values[indexCompatLegMode];
                if (0 <= indexBit64Bit32ModeSupport)
                    item.Bit64Bit32ModeSupport = values[indexBit64Bit32ModeSupport];
                if (0 <= indexCpuidFeatureFlag)
                {
                    item.CpuidFeatureFlag = values[indexCpuidFeatureFlag];
                    if (string.IsNullOrEmpty(item.CpuidFeatureFlag))
                        item.CpuidFeatureFlag = null;
                }

                if (0 <= indexDescription)
                    item.Description = values[indexDescription];

                if (item.Mnemonic == "RET" && item.Description.Contains("Far"))
                    item.MnemonicCode = "retf";

                instruction.Items.Add(item);
            }
        }

        private static void ParseOperandEncodingTable(List<(HtmlNode Table, List<string> Headers)> tables, InstructionDto instruction)
        {
            var (table, header) = tables.FirstOrDefault(x => 2 <= x.Headers.Count && x.Headers[0] == "Op/En" && x.Headers[1] == "Operand 1");
            if (table == null)
                return;

            instruction.OperandEncoding = new List<OperandEncodingDto>();

            foreach (var itemNode in table.ChildNodes.Where(x => x.Name == "tr").Skip(1))
            {
                var item = new OperandEncodingDto();
                instruction.OperandEncoding.Add(item);

                var values = itemNode
                    .ChildNodes
                    .Where(x => x.Name == "td")
                    .Select(x => x.InnerText)
                    .ToList();

                if (values.Count != header.Count)
                    continue;

                item.OperandEncoding = values[0];
                item.Operands = values.Skip(1).TakeWhile(x => x != "NA").ToList();
            }
        }

        [Fact(Skip = "For developer")]
        public void GenerateFiles()
        {
            var str = File.ReadAllText(decodeJsonFileName);
            var decodeMeta = JsonConvert.DeserializeObject<DecodeDto>(str);

            // InstructionUniqueName.cs

            var mnemonicCodes = decodeMeta.Instructions
                .Where(x => x.Items != null)
                .SelectMany(x => x.Items.Select(y => new
                {
                    y.MnemonicCode,
                    x.Summary,
                    x.Url
                }))
                .ToLookup(x => x.MnemonicCode);

            var lines = new[]
            {
                "// ReSharper disable InconsistentNaming",
                "// ReSharper disable IdentifierTypo",
                "// ReSharper disable CommentTypo",
                "",
                "namespace MikhailKhalizev.Processor.x86.InstructionDecode",
                "{",
                "    public enum MnemonicCode",
                "    {",
            }.AsEnumerable();
            
            lines = lines.Concat(mnemonicCodes.OrderBy(x => x.Key).SelectMany(x =>
            {
                var summaries = x.Select(y => y.Summary).Distinct();
                var urls = x.Select(y => y.Url).Distinct().ToList();

                var result = Enumerable.Empty<string>()
                    .Append("        /// <summary>")
                    .Concat(summaries.Select(y => $"        /// {y}."))
                    .Append("        /// </summary>");

                if (urls.Count == 1)
                {
                    result = result
                        .Append($"        /// <remarks>{urls[0]}</remarks>");
                }
                else
                {
                    result = result
                        .Append("        /// <remarks>")
                        .Concat(urls.Select(y => $"        /// {y}"))
                        .Append("        /// </remarks>");
                }

                var prefix = new[] { "in", "out", "lock", "int" }.Contains(x.Key) ? "@" : "";

                result = result
                    .Append($"        {prefix}{x.Key},")
                    .Append("");

                return result;
            }).SkipLast(1));


            lines = lines.Concat(new[]
            {
                "    }",
                "}"
            });

            var json = string.Join(Environment.NewLine, lines);
            File.WriteAllText(mnemonicCodeCsFileName, json);


            // IProcessor.cs (instruction region)

            var fileIProcessorCs = string.Join(
                Environment.NewLine,
                mnemonicCodes.OrderBy(x => x.Key).SelectMany(
                    x =>
                    {
                        return
                            Enumerable.Empty<string>()
                                .Append("/// <summary>")
                                .Concat(x.Select(y => $"/// {y.Summary}."))
                                .Append("/// </summary>")
                                .Append("/// <remarks>")
                                .Concat(x.Select(y => $"/// {y.Url}."))
                                .Append("/// </remarks>")
                                .Append($"void {x.Key}();");
                    }));

            // NOTE Copy manually 'fileIProcessorCs' value to 'IProcessor.cs'.
        }

        [Fact(Skip = "For developer")]
        public void LoadPdfWithAspose()
        {
            var dir = Path.GetDirectoryName(asposePageJsonFileName);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            var pdfApi = new PdfApi(AsposeAppKey, AsposeAppSid);
            var doc = pdfApi.GetDocument(documentName).Document;
            var pageResponse = pdfApi.GetPage(documentName, 1);
            
            for (var i = 1; i <= doc.Pages.List.Count; i++)
            {
                var file = string.Format(asposePageJsonFileName, i.ToString().PadLeft(4, '0'));
                if (File.Exists(file))
                    continue;

                var page = new PageRawDto();
                page.Number = i;
                page.CreationDate = doc.DocumentProperties.List.Single(x => x.Name == "CreationDate").Value;
                page.ModDate = doc.DocumentProperties.List.Single(x => x.Name == "ModDate").Value;
                page.Tables = JObject.Parse(pdfApi.GetPageTables(documentName, i).Tables.ToJson())["List"];
                page.Texts = JObject.Parse(
                    pdfApi.GetPageText(
                        documentName,
                        i,
                        pageResponse.Page.Rectangle.LLX,
                        pageResponse.Page.Rectangle.LLY,
                        pageResponse.Page.Rectangle.URX,
                        pageResponse.Page.Rectangle.URY).TextOccurrences.ToJson())["List"];

                var json = JToken.FromObject(page, JsonSerializer.CreateDefault(
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    })).ToString();
                File.WriteAllText(file, json);
            }
        }

        [Fact(Skip = "For developer")]
        public void LoadPdfBookmarksWithSyncfusion()
        {
            var docStream = new FileStream(Path.Combine(documentFolder, documentName), FileMode.Open, FileAccess.Read);
            var loadedDocument = new PdfLoadedDocument(docStream);

            var pages = loadedDocument.Pages.Cast<object>().ToList();

            //bookmarksJsonFileName 

            BookmarkDto Transform(PdfBookmarkBase bookmarkBase)
            {
                var result = new BookmarkDto();

                if (bookmarkBase is PdfBookmark bookmark)
                {
                    result.Title = bookmark.Title;
                    var page = bookmark.NamedDestination?.Destination?.Page;
                    if (page != null)
                        result.PageNumber = pages.IndexOf(page) + 1;
                }

                result.Children = bookmarkBase.OfType<PdfBookmark>().Select(Transform).ToList();
                if (result.Children.Count == 0)
                    result.Children = null;

                return result;
            }

            var bookmarksDto = Transform(loadedDocument.Bookmarks);

            var json = JToken.FromObject(bookmarksDto, JsonSerializer.CreateDefault(
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    DefaultValueHandling = DefaultValueHandling.Ignore
                })).ToString();
            File.WriteAllText(bookmarksJsonFileName, json);
        }
        
        [Fact(Skip = "For developer")]
        public void ParsePdf()
        {
            var dir = Path.GetDirectoryName(asposePageJsonFileName);
            var pattern = Path.GetFileName(asposePageJsonFileName).Replace("{0}", "*");
            var files = Directory.EnumerateFiles(dir, pattern).OrderBy(x => x).ToList();

            foreach (var file in files)
            {
                var allText = File.ReadAllText(file);
                var decodeMeta = JsonConvert.DeserializeObject<PageDto>(allText);

                if (decodeMeta.Tables == null)
                    continue;

                var opcodesTable = decodeMeta.Tables
                    .Where(
                        x =>
                        {
                            if (x.RowList.Count < 2)
                                return false;

                            if (x.RowList[0].CellList.Count < 2)
                                return false;

                            return x.RowList[0].CellList[0].TextRects.List
                                .Any(y => y.Text.Contains("Opcode", StringComparison.OrdinalIgnoreCase));
                        })
                    .ToList();

                if (opcodesTable.Count == 0)
                    continue;
            }
        }
    }
}