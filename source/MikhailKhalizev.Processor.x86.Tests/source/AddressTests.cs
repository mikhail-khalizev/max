using FluentAssertions;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests
{
    public class AddressTests
    {
        [Fact]
        public void ConvertSbyteToAddress()
        {
            const sbyte b = -1;
            var address = (Address)b;
            ((uint)address).Should().Be(0xffff_ffff);
            ((Value)address).UInt64.Should().Be(0xffff_ffff);
        }

        [Fact]
        public void NegativeAddress()
        {
            var a = (Address) (-20);
            var u = (uint) a;
            u.Should().Be(unchecked((uint)(-20)));
        }

        [Fact]
        public void ShiftAddress()
        {
            Address a = 0xff00_0000;
            var b = a >> 16;
            b.Should().Be(0xff00);
        }
    }
}