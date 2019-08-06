using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Aspose.Pdf.Cloud.Sdk.Api;
using MikhailKhalizev.Processor.x86.InstructionDecode;
using MikhailKhalizev.Processor.x86.InstructionDecode.Dto;
using MikhailKhalizev.Processor.x86.Tests.CodeGenerator.Dto;
using MikhailKhalizev.Processor.x86.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Pdf.Parsing;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests.CodeGenerator
{
    public class ParsePdfPart
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
        public void LoadPdfWithAspose()
        {
            var dir = Path.GetDirectoryName(AsposePageJsonFileName);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            var bag = new ConcurrentBag<PdfApi>();
            var pdfApiInit = new PdfApi(AsposeAppKey, AsposeAppSid);

            var doc = pdfApiInit.GetDocument(DocumentName).Document;
            var creationDate = doc.DocumentProperties.List.Single(x => x.Name == "CreationDate").Value;
            var modDate = doc.DocumentProperties.List.Single(x => x.Name == "ModDate").Value;
            var pageResponse = pdfApiInit.GetPage(DocumentName, 1);

            bag.Add(pdfApiInit);

            Parallel.For(
                1,
                doc.Pages.List.Count + 1,
                new ParallelOptions { MaxDegreeOfParallelism = 3 },
                i =>
                {
                    var file = string.Format(AsposePageJsonFileName, i.ToString().PadLeft(4, '0'));
                    if (File.Exists(file))
                    {
                        var filePath = string.Format(AsposePageJsonFileName, i.ToString().PadLeft(4, '0'));
                        var allText = File.ReadAllText(filePath);
                        var pageDto = JsonConvert.DeserializeObject<PageDto>(allText);
                        if (pageDto.Number == i && pageDto.CreationDate == creationDate && pageDto.ModDate == modDate)
                            return;
                    }

                    bag.TryTake(out var pdfApi);
                    if (pdfApi == null)
                        pdfApi = new PdfApi(AsposeAppKey, AsposeAppSid);

                    var page = new PageRawDto();
                    page.Number = i;
                    page.CreationDate = creationDate;
                    page.ModDate = modDate;
                    page.Tables = JObject.Parse(pdfApi.GetPageTables(DocumentName, i).Tables.ToJson())["List"];
                    page.Texts = JObject.Parse(
                        pdfApi.GetPageText(
                            DocumentName,
                            i,
                            pageResponse.Page.Rectangle.LLX,
                            pageResponse.Page.Rectangle.LLY,
                            pageResponse.Page.Rectangle.URX,
                            pageResponse.Page.Rectangle.URY).TextOccurrences.ToJson())["List"];

                    bag.Add(pdfApi);
                    pdfApi = null;

                    var json = JToken.FromObject(
                        page,
                        JsonSerializer.CreateDefault(
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            })).ToString();
                    File.WriteAllText(file, json);
                });
        }

        [Fact(Skip = "For developer")]
        public void SplitPdfWithSyncfusion()
        {
            var dir = Path.GetDirectoryName(SplitPdfFileName);
            Directory.CreateDirectory(dir);

            var docStream = new FileStream(Path.Combine(DocumentFolder, DocumentName), FileMode.Open, FileAccess.Read);
            var loadedDocument = new PdfLoadedDocument(docStream);

            for (var i = 0; i < loadedDocument.PageCount; i++)
            {
                var document = new PdfDocument();
                document.ImportPage(loadedDocument, i);

                var path = string.Format(SplitPdfFileName, (i + 1).ToString().PadLeft(4, '0'));
                var fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

                document.Save(fileStream);
                document.Close(true);

                fileStream.SetLength(fileStream.Position);
                fileStream.Dispose();
            }
        }

        [Fact(Skip = "For developer")]
        public void LoadPdfBookmarksWithSyncfusion()
        {
            var docStream = new FileStream(Path.Combine(DocumentFolder, DocumentName), FileMode.Open, FileAccess.Read);
            var loadedDocument = new PdfLoadedDocument(docStream);

            var pages = loadedDocument.Pages.Cast<PdfPageBase>().ToList();

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

            var json = JToken.FromObject(
                bookmarksDto,
                JsonSerializer.CreateDefault(
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        DefaultValueHandling = DefaultValueHandling.Ignore
                    })).ToString();
            File.WriteAllText(BookmarksJsonFileName, json);
        }

        [Fact(Skip = "For developer")]
        public void ParsePdf()
        {
            // Load documents.

            var allText = File.ReadAllText(BookmarksJsonFileName);
            var bookmarks = JsonConvert.DeserializeObject<BookmarkDto>(allText);

            allText = File.ReadAllText(DecodeFelixcloutierJsonFileName);
            var felixcloutierDecodeDto = JsonConvert.DeserializeObject<DecodeDto>(allText);
            var felixcloutierInstructionDtoTyTitle = felixcloutierDecodeDto.Instructions.ToDictionary(x => x.Title.Replace("∗", "*"));


            IEnumerable<BookmarkDto> DeepFind(BookmarkDto root, Func<BookmarkDto, bool> predicate)
            {
                if (predicate(root))
                    return new[] { root };
                else
                    return root.Children?.SelectMany(x => DeepFind(x, predicate)) ?? Enumerable.Empty<BookmarkDto>();
            }

            var parentInstructionBookmarks =
                DeepFind(
                        bookmarks,
                        x => x.Children != null && x.Title?.Contains(" Instructions (", StringComparison.Ordinal) == true)
                    .ToList();
            var instructionsBookmarks = parentInstructionBookmarks.SelectMany(x => x.Children).ToList();


            // Main cycle.

            var decodeDto = new DecodeDto();
            decodeDto.Instructions = new List<InstructionDto>(felixcloutierDecodeDto.Instructions.Count);

            var later = new List<(InstructionDto, BookmarkDto)>();

            foreach (var bookmark in instructionsBookmarks)
            {
                var instruction = new InstructionDto();

                var index = bookmark.Title
                    .TakeWhile(x => char.GetUnicodeCategory(x) != UnicodeCategory.DashPunctuation)
                    .Count();

                instruction.Mnemonics = string.Join('/', bookmark.Title.Substring(0, index).Split('/').Select(x => x.Trim()));
                instruction.Summary = bookmark.Title.Substring(index + 1).Trim();
                instruction.PageNumber = bookmark.PageNumber;

                // Add url from felixcloutier.

                felixcloutierInstructionDtoTyTitle.TryGetValue(instruction.Title, out var felixcloutierInstruction);
                if (felixcloutierInstruction != null)
                {
                    felixcloutierInstructionDtoTyTitle.Remove(instruction.Title);
                    instruction.Url = felixcloutierInstruction.Url;
                    instruction.Items = felixcloutierInstruction.Items;
                    instruction.OperandEncoding = felixcloutierInstruction.OperandEncoding;
                }
                else
                    later.Add((instruction, bookmark));

                // Add opcodes from intel pdf.
                // TODO LoadFromPdf(bookmark, instruction);

                decodeDto.Instructions.Add(instruction);
            }


            // Add url for felixcloutier later items.

            var felixcloutierInstructionDtoTySummary = felixcloutierInstructionDtoTyTitle.Values.ToDictionary(x => x.Summary);

            foreach (var valueTuple in later)
            {
                if (felixcloutierInstructionDtoTySummary.Count == 0)
                    break;

                var instruction = valueTuple.Item1;
                felixcloutierInstructionDtoTySummary.TryGetValue(instruction.Summary, out var felixcloutierInstruction);
                if (felixcloutierInstruction != null)
                {
                    felixcloutierInstructionDtoTySummary.Remove(instruction.Summary);
                    instruction.Url = felixcloutierInstruction.Url;
                    instruction.Items = felixcloutierInstruction.Items;
                    instruction.OperandEncoding = felixcloutierInstruction.OperandEncoding;
                }
            }

            if (felixcloutierInstructionDtoTySummary.Count != 0)
                throw new InvalidOperationException();


            // Save to decode.json

            var json = JToken.FromObject(decodeDto, JsonSerializer.CreateDefault(
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    DefaultValueHandling = DefaultValueHandling.Ignore
                })).ToString();

            File.WriteAllText(DecodeJsonFileName, json);
        }

        private static void LoadFromPdf(BookmarkDto bookmark, InstructionDto instruction)
        {
            var filePath = string.Format(AsposePageJsonFileName, bookmark.PageNumber.ToString().PadLeft(4, '0'));
            var allText = File.ReadAllText(filePath);
            var pageDto = JsonConvert.DeserializeObject<PageDto>(allText);
            
            if (pageDto.Tables == null) 
                return;

            var opcodesTables = pageDto.Tables
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

            var opcodesTable = opcodesTables.FirstOrDefault();
            if (opcodesTable == null)
                return;
        
            instruction.Items = new List<InstructionItemDto>();

            var header = opcodesTable.RowList[0].CellList.Select(x => x.Text.TrimEnd('*')).ToList();
            var indexOpcode = header.IndexOf(x => x == "Opcode");
            var indexInstruction = header.IndexOf(x => x == "Instruction");
            var indexOpcodeInstruction = Math.Max(
                header.IndexOf(x => x.StartsWith("Opcode Instruction")),
                header.IndexOf(x => x.StartsWith("Opcode/Instruction")));
            var indexOperandEncoding = header.IndexOf(x => x == "Op/En");
            var index64BitMode = header.IndexOf(x => string.Equals(x, "64-bit Mode", StringComparison.OrdinalIgnoreCase));
            var indexCompatLegMode = header.IndexOf(x => x == "Compat/Leg Mode");
            var indexBit64Bit32ModeSupport = header.IndexOf(x => x == "64/32 bit Mode Support");
            var indexCpuidFeatureFlag = header.IndexOf(x => x == "CPUID Feature Flag");
            var indexDescription = header.IndexOf(x => x == "Description");

            // TODO. Fix documentation error.
            // LZCNT has incorrect table.
            for (var i = 1; i < opcodesTable.RowList.Count; i++)
            {
                var itemNode = opcodesTable.RowList[i];
                if (header.Count == itemNode.CellList.Count + 1)
                {

                }
            }

            foreach (var itemNode in opcodesTable.RowList.Skip(1))
            {
                var item = new InstructionItemDto();

                var values = itemNode.CellList.Select(x => x.Text).ToList();
                if (header.Count != values.Count)
                    continue;
                
                if (0 <= indexDescription)
                    item.Description = values[indexDescription];


                int index;
                if (0 <= indexOpcodeInstruction)
                {
                    var opcodeInstruction = values[indexOpcodeInstruction];

                    // Fix documentation error.
                    if (opcodeInstruction == "VEX.128.66.0F.W0 6E /VMOVD xmm1, r32/m32")
                        opcodeInstruction = "VEX.128.66.0F.W0 6E /r VMOVD xmm1, r32/m32";

                    item.Mnemonic =
                        opcodeInstruction.Split(' ', StringSplitOptions.RemoveEmptyEntries)
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

                    index = opcodeInstruction.IndexOf(item.Mnemonic, StringComparison.InvariantCulture);
                    item.Opcode = opcodeInstruction.Substring(0, index).TrimEnd();
                    item.Instruction = opcodeInstruction.Substring(index).TrimStart();
                }

                if (0 <= indexOpcode)
                    item.Opcode = values[indexOpcode];
                if (0 <= indexInstruction)
                {
                    item.Instruction = values[indexInstruction];

                    index = item.Instruction.IndexOf(' ');
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

                if (item.Mnemonic == "RET" && item.Description.Contains("Far"))
                    item.MnemonicCode = "retf";

                instruction.Items.Add(item);
            }
        }
    }
}