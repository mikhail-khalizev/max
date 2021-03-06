using FluentAssertions;
using MikhailKhalizev.Processor.x86.Decoder;
using MikhailKhalizev.Processor.x86.Decoder.Metadata;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests.Decoder
{
    public class InstructionTest
    {
        [Fact]
        public void PrefixRepeated()
        {
            var code = new byte[]
            {
                PrefixMetadata.PrefixCs,
                PrefixMetadata.PrefixOperandSizeOverride,
                PrefixMetadata.PrefixDs,
                PrefixMetadata.PrefixAddressSizeOverride,
                0xda, 0x0a
            };
            var instruction = Instruction.Decode(code, 32);
            
            instruction.IsInvalid.Should().BeTrue();
            instruction.Reason.Should().Be("Prefix group repeated: (2e, 3e).");
            instruction.ReadLength.Should().Be(3);
        }
    }
}