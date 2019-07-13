using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using FluentAssertions;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SharpDisasm;
using Xunit;
using Instruction = MikhailKhalizev.Processor.x86.BinToCSharp.Instruction;

namespace MikhailKhalizev.Processor.x86.Tests.BinToCSharp
{
    public class InstructionTests
    {
        private static List<object[]> _decodeSource;

        public static List<object[]> DecodeSource
        {
            get
            {
                if (_decodeSource != null)
                    return _decodeSource;

                string json;

                var assembly = typeof(InstructionTests).GetTypeInfo().Assembly;
                using (var stream = new StreamReader(assembly.GetManifestResourceStream(
                    "MikhailKhalizev.Processor.x86.Tests.resources.instruction-decode-test.json")))
                    json = stream.ReadToEnd();

                var data = (JArray) JsonConvert.DeserializeObject(json);
                _decodeSource = data.Select(item => new object[]
                {
                    item["Arch"].Value<int>(),
                    item["Raw"].Value<string>(),
                    Address.Parse(item["Addr"].Value<string>()),
                    item["Dec"].Value<string>()
                }).ToList();

                return _decodeSource;
            }
        }

        [Theory, MemberData(nameof(DecodeSource))]
        public void Decode(int arch, string raw, Address address, string dec)
        {
            var dis = new Disassembler(HexHelper.ToBytes(raw), (ArchitectureMode)arch, address, true);
            var ins = dis.NextInstruction();
            var cmd = new Instruction(ins);
            var str = cmd.ToCodeString();

            str = HexHelper.RemoveGroupSeparatorInAllHexInText(str);

            str.Should().Be(dec);
        }
    }
}