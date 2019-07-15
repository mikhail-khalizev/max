using FluentAssertions;
using MikhailKhalizev.Processor.x86.Abstractions;
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
    }
}