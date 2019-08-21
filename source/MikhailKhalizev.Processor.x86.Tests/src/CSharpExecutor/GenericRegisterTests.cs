using FluentAssertions;
using MikhailKhalizev.Processor.x86.Configuration;
using MikhailKhalizev.Processor.x86.Core.Abstractions.Registers;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests.Core
{
    public class GenericRegisterTests
    {
        [Fact]
        public void CheckGenericOffsetRegister()
        {
            var r = new SimpleRegister(32);
            var m = new OffsetRegister(r, 4, 8);

            r.UInt64 = 0x1234;
            m.UInt64.Should().Be(0x23);

            m.UInt64 = 0xff56;
            r.UInt64.Should().Be(0x1564);
        }

        [Fact]
        public void CheckGenericOffsetRegister32()
        {
            var r = new SimpleRegister(32);
            var m = new OffsetRegister(r, 0, 32);

            r.UInt64 = 0x1234_5678;
            m.UInt64.Should().Be(0x1234_5678);

            m.UInt64 = 0x8765_4321;
            r.UInt64.Should().Be(0x8765_4321);
        }

        [Fact]
        public void CheckProcessorGenericRegister()
        {
            var r = new x86.Core.Processor(new ProcessorDto());

            r.eax.UInt64 = 0x1234_5678;
            r.ax.UInt64.Should().Be(0x5678);
            r.al.UInt64.Should().Be(0x78);
            r.ah.UInt64.Should().Be(0x56);

            r.ah = r.al;
            r.eax.UInt64.Should().Be(0x1234_7878);

            r.ax = r.ah;
            r.eax.UInt64.Should().Be(0x1234_0078);

            r.eax = r.ax;
            r.eax.UInt64.Should().Be(0x0000_0078);
        }
    }
}
