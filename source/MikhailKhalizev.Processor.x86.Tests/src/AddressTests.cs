using FluentAssertions;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Abstractions.Value;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests
{
    public class AddressTests
    {
        [Fact]
        public void Convert_sbyte_to_Address()
        {
            const sbyte b = -1;
            var addr = (Address)b;
            ((uint)addr).Should().Be(0xffff_ffff);
            ((Value)addr).UInt64.Should().Be(0xffff_ffff);
        }
    }
}