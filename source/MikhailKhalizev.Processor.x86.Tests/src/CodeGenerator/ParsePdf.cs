using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using MikhailKhalizev.Processor.x86.InstructionDecode;
using MikhailKhalizev.Processor.x86.InstructionDecode.Dto;
using MikhailKhalizev.Processor.x86.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        public const string DocumentFolder = Constants.DocumentFolder;
        public const string DocumentName = Constants.DocumentName;

        public const string AsposeAppSid = Constants.AsposeAppSid;
        public const string AsposeAppKey = Constants.AsposeAppKey;

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

            if (instruction.Mnemonics == "PADDSB/PADDSW")
            {
                var debug = 0;
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
                                    if (Register.HasRegister(token))
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