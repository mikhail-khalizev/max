using FluentAssertions;
using MikhailKhalizev.Processor.x86.Decoder;
using SharpDisasm.Udis86;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests.Decoder
{
    public class RegisterInfoTest
    {
        [Fact]
        public void CheckRegisterInfoAh()
        {
            var info = RegisterInfo.GetRegister(ud_type.UD_R_AH);
            info.BitOffset.Should().Be(8);
            info.BitMask.Should().Be(0xff00);
            info.LengthInBits.Should().Be(8);
        }
    }
}