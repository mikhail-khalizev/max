using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HtmlAgilityPack;
using MikhailKhalizev.Processor.x86.InstructionDecode;
using MikhailKhalizev.Processor.x86.InstructionDecode.Dto;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;
using Path = System.IO.Path;

namespace MikhailKhalizev.Processor.x86.Tests.CodeGenerator
{
    public class CodeGenerator
    {
        public const string MnemonicCodeCsFileName = Constants.MnemonicCodeCsFileName;
        public const string DecodeJsonFileName = Constants.DecodeJsonFileName;

        public const string DecodeFelixcloutierJsonFileName = Constants.DecodeFelixcloutierJsonFileName;
        public const string AsposePageJsonFileName = Constants.AsposePageJsonFileName;
        public const string BookmarksJsonFileName = Constants.BookmarksJsonFileName;
        public const string SplitPdfFileName = Constants.SplitPdfFileName;

        public const string DocumentFolder = Constants.DocumentFolder;
        public const string DocumentName = Constants.DocumentName;

        public const string AsposeAppSid = Constants.AsposeAppSid;
        public const string AsposeAppKey = Constants.AsposeAppKey;


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

            var decodeDto = new DecodeDto();
            decodeDto.Instructions = indexTable.ChildNodes
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

            var json = JToken.FromObject(
                decodeDto,
                JsonSerializer.CreateDefault(
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        DefaultValueHandling = DefaultValueHandling.Ignore
                    })).ToString();

            File.WriteAllText(DecodeFelixcloutierJsonFileName, json);
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
            var index64BitMode = header.FindIndex(x => string.Equals(x, "64-bit Mode", StringComparison.OrdinalIgnoreCase));
            var indexCompatLegMode = header.FindIndex(x => string.Equals(x, "Compat/Leg Mode", StringComparison.OrdinalIgnoreCase));
            var indexBit64Bit32ModeSupport =
                header.FindIndex(x => string.Equals(x, "64/32 bit Mode Support", StringComparison.OrdinalIgnoreCase));
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
                                    if (RegisterInfo.HasRegister(token))
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
                if (0 <= index64BitMode)
                    item.Bit64Mode = values[index64BitMode];
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
            var (table, header) =
                tables.FirstOrDefault(x => 2 <= x.Headers.Count && x.Headers[0] == "Op/En" && x.Headers[1] == "Operand 1");
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
            var str = File.ReadAllText(DecodeJsonFileName);
            var decodeMeta = JsonConvert.DeserializeObject<DecodeDto>(str);

            // InstructionUniqueName.cs

            var mnemonicCodes = decodeMeta.Instructions
                .Where(x => x.Items != null)
                .SelectMany(
                    x => x.Items.Select(
                        y => new
                        {
                            y.MnemonicCode,
                            x.Summary,
                            x.Url,
                            x.PageNumber
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

            lines = lines.Concat(
                mnemonicCodes.OrderBy(x => x.Key).SelectMany(
                    x =>
                    {
                        var xo = x.OrderBy(y => y.PageNumber).ToList();

                        var summaries = xo.Select(y => y.Summary).Distinct();
                        var remarks = xo.Select(y => y.Url).Distinct().ToList();
                        var pages = xo.Select(y => y.PageNumber).Distinct().ToList();
                        remarks.Add($"Page{(1 < pages.Count ? "s" : "")} {string.Join(", ", pages)} in Intel documentation file '{InstructionDto.DocumentationFile}'.");

                        var result = Enumerable.Empty<string>()
                            .Append("        /// <summary>")
                            .Concat(summaries.Select(y => $"        /// {y}."))
                            .Append("        /// </summary>");

                        if (remarks.Count == 1)
                        {
                            result = result
                                .Append($"        /// <remarks>{remarks[0]}</remarks>");
                        }
                        else
                        {
                            result = result
                                .Append("        /// <remarks>")
                                .Concat(remarks.Select(y => $"        /// {y}"))
                                .Append("        /// </remarks>");
                        }

                        var prefix = new[] { "in", "out", "lock", "int" }.Contains(x.Key) ? "@" : "";

                        result = result
                            .Append($"        {prefix}{x.Key},")
                            .Append("");

                        return result;
                    }).SkipLast(1));


            lines = lines.Concat(
                new[]
                {
                    "    }",
                    "}"
                });

            var json = string.Join(Environment.NewLine, lines);
            File.WriteAllText(MnemonicCodeCsFileName, json);


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
    }
}