using FluentAssertions;
using MikhailKhalizev.Processor.x86.Abstractions.Registers;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests.Core
{
    public class SegmentTests
    {
        [Fact]
        public void Get_Set_SegmentDescriptor_Limit()
        {
            var s = new SegmentDescriptor();

            s.Limit = 0;
            s.Limit.Should().Be(0);

            s.Limit = 10;
            s.Limit.Should().Be(10);
            
            s.Limit = 10000;
            s.Limit.Should().Be(10000);

            s.Limit = 40000;
            s.Limit.Should().Be(40000);

            s.Limit = 80000;
            s.Limit.Should().Be(80000);
        }

        [Fact]
        public void Get_Set_SegmentDescriptor_P()
        {
            var s = new SegmentDescriptor();

            s.Present = true;
            s.Present.Should().BeTrue();

            s.Present = false;
            s.Present.Should().BeFalse();
        }
    }
}