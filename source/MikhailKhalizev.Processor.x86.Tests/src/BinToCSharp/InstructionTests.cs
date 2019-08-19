using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using FluentAssertions;
using MikhailKhalizev.Processor.x86.BinToCSharp;
using MikhailKhalizev.Processor.x86.Core.Abstractions;
using MikhailKhalizev.Processor.x86.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SharpDisasm;
using SharpDisasm.Udis86;
using Xunit;

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
            var u = new ud();
            udis86.ud_init(ref u);
            udis86.ud_set_input_buffer(ref u, new AssemblyCodeArray(HexHelper.ToBytes(raw)));

            udis86.ud_set_mode(ref u, (byte)arch);
            udis86.ud_set_pc(ref u, address);
            udis86.ud_set_vendor(ref u, (int)Vendor.Any);

            var length = udis86.ud_disassemble(ref u);
            length.Should().BeGreaterOrEqualTo(0);
            u.error.Should().Be(0);

            var cmd = new CSharpInstruction(new DefinitionCollection(), u);
            var str = cmd.ToCodeString(onlyRawCmd: true);

            str = HexHelper.RemoveGroupSeparatorInAllHexInText(str);

            str.Should().Be(dec);
        }

        class AssemblyCodeArray : IAssemblyCode
        {
            private byte[] _buffer;

            public AssemblyCodeArray(byte[] buffer)
            {
                _buffer = buffer;
            }

            byte IAssemblyCode.this[int index] => _buffer[index];

            int IAssemblyCode.Length => _buffer.Length;
        }
    }
}