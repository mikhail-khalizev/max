using System.Linq;
using FluentAssertions;
using MikhailKhalizev.Processor.x86.InstructionDecode;
using MikhailKhalizev.Utils;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests.InstructionDecode
{
    public class InstructionTest
    {
        [Fact]
        public void PrefixRepeated()
        {
            var code = new byte[] { PrefixMetadata.PrefixOperandSizeOverride, PrefixMetadata.PrefixCs, PrefixMetadata.PrefixDs, 0xda, 0x0a };
            var instruction = Instruction.Decode(code, 32);
            
            instruction.IsInvalid.Should().BeTrue();
            instruction.Reason.Should().Be("Prefix group repeated: (2e, 3e).");
            instruction.ReadLength.Should().Be(3);
        }
    }
}