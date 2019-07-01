using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FluentAssertions;
using HtmlAgilityPack;
using MikhailKhalizev.Processor.x86.InstructionDecode.Dto;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;
using Path = System.IO.Path;

namespace MikhailKhalizev.Processor.x86.Tests.CodeGenerator
{
    public class CodeGenerator
    {
        public const string decodeJsonFileName = @"..\..\..\..\Exo.Processor.x86\resources\decode.json";
        public const string instructionUniqueNameCsFileName = @"..\..\..\..\Exo.Processor.x86\src\InstructionDecode\InstructionUniqueName.cs";

        [Fact(Skip = "For developer")]
        public void FelixcloutierParse()
        {
            var web = new HtmlWeb();
            web.CachePath = Path.Combine(Directory.GetCurrentDirectory(), "web-cache");
            web.UsingCache = true;
            web.UsingCacheIfExists = true;

            var urlBase = "https://www.felixcloutier.com/x86";
            var urlIndex = urlBase + "/index.html";

            var htmlDocumentIndex = web.Load(urlIndex);

            var titleNode = htmlDocumentIndex.DocumentNode.SelectNodes("//body/h2")
                .Single(x => x.InnerText == "Core Instructions");
            var indexTable = titleNode.NextSibling;

            var str = File.ReadAllText(decodeJsonFileName);
            var decodeMeta = JsonConvert.DeserializeObject<DecodeDto>(str);

            decodeMeta.Instructions = indexTable.ChildNodes
                .Select(indexItem =>
                {
                    var node = indexItem.ChildNodes[0].FirstChild;
                    var mnemonic = node.InnerText.Replace(" ", "_");
                    var href = node.Attributes["href"];
                    var url = href == null ? null : urlBase + href.Value.Substring(1);
                    var description = indexItem.ChildNodes[1].InnerText;

                    if (url == null)
                        return null;

                    var instruction = new InstructionDto
                    {
                        Mnemonic = mnemonic,
                        Description = description,
                        Url = url
                    };

                    var htmlDocument = web.Load(url);

                    var tables = htmlDocument.DocumentNode
                        .SelectNodes("//body/table")
                        .Select(table => (Table: table, Headers: table.ChildNodes["tr"]
                            .ChildNodes
                            .Where(x => x.Name == "th" || x.Name == "td")
                            .Select(x => x.InnerText)
                            .ToList()))
                        .ToList();

                    ParseMainTable(tables, instruction);
                    ParseOperandEncodingTable(tables, instruction);

                    return instruction;
                })
                .Where(x => x?.Url != null)
                .ToList();

            var mnemonicLowers = decodeMeta.Instructions.Select(x => x.Mnemonic.ToLowerInvariant()).ToHashSet();

            foreach (var instruction in decodeMeta.Instructions)
            {
                var uniqueName = instruction.Mnemonic.ToLowerInvariant();
                if (new[] { "in", "lock", "out" }.Contains(uniqueName))
                    uniqueName = "@" + uniqueName;

                var description = instruction.Description;

                if (description == "Move to/from Control Registers")
                    uniqueName += "_cr";
                else if (description == "Move to/from Debug Registers")
                    uniqueName += "_dr";
                else if (description.Contains("Floating-Point"))
                    uniqueName += "_fp";
                else if (uniqueName == "movq" && description == "Move Doubleword/Move Quadword")
                    uniqueName += "_1";
                else if (uniqueName == "movq" && description == "Move Quadword")
                    uniqueName += "_2";
                else if (uniqueName.StartsWith("vgather") && description.Contains("with Signed"))
                    uniqueName += "_s";
                else if (uniqueName.StartsWith("vpgather") && description.Contains("with Signed"))
                    uniqueName += "_s";
                else if (mnemonicLowers.Contains(uniqueName + "d") &&
                         !mnemonicLowers.Contains(uniqueName + "w") &&
                         instruction.Url.ToLowerInvariant().Contains(uniqueName + "d"))
                    uniqueName += "w";

                instruction.UniqueName = uniqueName;
            }

            decodeMeta.Instructions.Select(x => x.UniqueName).Should().OnlyHaveUniqueItems();

            str = JToken.FromObject(decodeMeta, JsonSerializer.CreateDefault(
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                })).ToString();

            File.WriteAllText(decodeJsonFileName, str);
        }

        private static void ParseMainTable(List<(HtmlNode Table, List<string> Headers)> tables, InstructionDto instruction)
        {
            var (table, header) = tables.FirstOrDefault(x => x.Headers[0] == "Opcode");
            if (table == null)
                return;

            instruction.Table = new List<InstructionTableItemDto>();
            
            var indexOpcode = header.IndexOf("Opcode");
            var indexInstruction = header.IndexOf("Instruction");
            var indexOperandEncoding = header.IndexOf("Op/En");
            var index64bitMode = header.IndexOf("64-bit Mode");
            var indexCompatLegMode = header.IndexOf("Compat/Leg Mode");
            var indexDescription = header.IndexOf("Description");

            foreach (var itemNode in table.ChildNodes.Where(x => x.Name == "tr").Skip(1))
            {
                var item = new InstructionTableItemDto();
                instruction.Table.Add(item);

                var values = itemNode
                    .ChildNodes
                    .Where(x => x.Name == "td")
                    .Select(x => x.InnerText)
                    .ToList();

                if (values.Count != header.Count)
                    continue;

                if (0 <= indexOpcode)
                    item.Opcode = values[indexOpcode];
                if (0 <= indexInstruction)
                    item.Instruction = values[indexInstruction];
                if (0 <= indexOperandEncoding)
                    item.OperandEncoding = values[indexOperandEncoding];
                if (0 <= index64bitMode)
                    item.Bit64Mode = values[index64bitMode];
                if (0 <= indexCompatLegMode)
                    item.CompatLegMode = values[indexCompatLegMode];
                if (0 <= indexDescription)
                    item.Description = values[indexDescription];
            }
        }

        private static void ParseOperandEncodingTable(List<(HtmlNode Table, List<string> Headers)> tables, InstructionDto instruction)
        {
            var (table, header) = tables.FirstOrDefault(x => 2 <= x.Headers.Count && x.Headers[0] == "Op/En" && x.Headers[1] == "Operand 1");
            if (table == null)
                return;

            instruction.OperandEncoding = new List<InstructionOperandEncodingItemDto>();

            foreach (var itemNode in table.ChildNodes.Where(x => x.Name == "tr").Skip(1))
            {
                var item = new InstructionOperandEncodingItemDto();
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
        public void FileGenerator()
        {
            var str = File.ReadAllText(decodeJsonFileName);
            var decodeMeta = JsonConvert.DeserializeObject<DecodeDto>(str);

            // InstructionUniqueName.cs

            var lines = new[]
            {
                "// ReSharper disable InconsistentNaming",
                "// ReSharper disable IdentifierTypo",
                "// ReSharper disable CommentTypo",
                "",
                "namespace Exo.Processor.x86",
                "{",
                "\tpublic enum InstructionUniqueName",
                "\t{",
            }.Concat(decodeMeta.Instructions.SelectMany(x => new[]
            {
                "\t\t/// <summary>",
                $"\t\t/// {x.Description}.",
                "\t\t/// </summary>",
                $"\t\t/// <remarks>{x.Url}</remarks>",
                $"\t\t{x.UniqueName},",
                ""
            }).SkipLast(1)).Concat(new[]
            {
                "\t}",
                "}"
            });

            str = string.Join(Environment.NewLine, lines);
            File.WriteAllText(instructionUniqueNameCsFileName, str);


            // IProcessor.cs (instruction region)

            var fileIProcessorCs = string.Join(Environment.NewLine, decodeMeta.Instructions.SelectMany(x => new[]
            {
                "/// <summary>",
                $"/// {x.Description}.",
                "/// </summary>",
                $"/// <remarks>{x.Url}</remarks>",
                $"void {x.UniqueName}();",
                ""
            }));
        }
    }
}