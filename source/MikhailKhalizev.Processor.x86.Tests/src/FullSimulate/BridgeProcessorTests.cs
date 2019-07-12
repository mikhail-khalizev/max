using FluentAssertions;
using MikhailKhalizev.Processor.x86.Abstractions;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests.FullSimulate
{
    public class BridgeProcessorTests : BridgeProcessor
    {
        /// <inheritdoc />
        public BridgeProcessorTests()
            : base(new x86.FullSimulate.Processor())
        { }

        [Fact]
        public void Check_movsx()
        {
            eax = 0x0000_7678;
            movsx(ebx, ax);
            ebx.UInt64.Should().Be(0x0000_7678);

            eax = 0x0000_8678;
            movsx(ebx, ax);
            ebx.UInt64.Should().Be(0xffff_8678);
        }

        [Fact]
        public void Check_sar()
        {
            eax = 0x0000_7678;
            sar(eax, 4);
            eax.UInt64.Should().Be(0x0000_0767);

            eax = 0xffff_fffe;
            sar(eax, 1);
            eax.UInt64.Should().Be(0xffff_ffff);
        }

        [Fact]
        public void Check_shl()
        {
            eax = 0x8000_7678;
            shl(eax, 4);
            eax.UInt64.Should().Be(0x0007_6780);
        }

        [Fact]
        public void Check_shr()
        {
            eax = 0x8000_7678;
            shr(eax, 4);
            eax.UInt64.Should().Be(0x0800_0767);
        }

        [Fact]
        public void Check_rcl()
        {
            al = 0b0000_0001;

            rcl(al, 1);
            al.UInt64.Should().Be(0b0000_0010);
            eflags.cf.Should().BeFalse();

            rcl(al, 6);
            al.UInt64.Should().Be(0b1000_0000);
            eflags.cf.Should().BeFalse();

            rcl(al, 1);
            al.UInt64.Should().Be(0b0000_0000);
            eflags.cf.Should().BeTrue();

            rcl(al, 1);
            al.UInt64.Should().Be(0b0000_0001);
            eflags.cf.Should().BeFalse();
        }

        [Fact]
        public void Check_rcr()
        {
            al = 5;

            al = 0b1000_0000;

            rcr(al, 7);
            al.UInt64.Should().Be(0b0000_0001);
            eflags.cf.Should().BeFalse();

            rcr(al, 1);
            al.UInt64.Should().Be(0b0000_0000);
            eflags.cf.Should().BeTrue();

            rcr(al, 1);
            al.UInt64.Should().Be(0b1000_0000);
            eflags.cf.Should().BeFalse();
        }

        [Fact]
        public void Check_rol()
        {
            al = 0b0000_0001;

            rol(al, 1);
            al.UInt64.Should().Be(0b0000_0010);
            eflags.cf.Should().BeFalse();

            rol(al, 6);
            al.UInt64.Should().Be(0b1000_0000);
            eflags.cf.Should().BeFalse();

            rol(al, 1);
            al.UInt64.Should().Be(0b0000_0001);
            eflags.cf.Should().BeTrue();
        }

        [Fact]
        public void Check_ror()
        {
            al = 0b1000_0000;

            ror(al, 7);
            al.UInt64.Should().Be(0b0000_0001);
            eflags.cf.Should().BeFalse();

            ror(al, 1);
            al.UInt64.Should().Be(0b1000_0000);
            eflags.cf.Should().BeTrue();
        }

        [Fact]
        public void Check_mem_raw_read()
        {
            memd_a32[0x0] = 0x0102_0304;

            memb_a32[0x0].UInt64.Should().Be(4);
            memb_a32[0x1].UInt64.Should().Be(3);
            memb_a32[0x2].UInt64.Should().Be(2);
            memb_a32[0x3].UInt64.Should().Be(1);
        }

        [Fact]
        public void Check_mem_raw_write()
        {
            memb_a32[0x0] = 4;
            memb_a32[0x1] = 3;
            memb_a32[0x2] = 2;
            memb_a32[0x3] = 1;

            memd_a32[0x0].UInt64.Should().Be(0x0102_0304);
        }

        [Fact]
        public void CheckPopRegister()
        {
            memw_a32[0] = 0x0102;

            popw(eax);

            eax.UInt32.Should().Be(0x0102);
            esp.UInt32.Should().Be(2);
        }

        [Fact(Skip = "work-in-progress")]
        public void Experemental()
        {
            ii(0x100a1dca, 0x5); pushd(0x24);                          /* push dword 0x24 */
         // ii(0x100a1dcf, 0x5); calld(sys_check_available_stack_size, 0xc3f7e); /* call 0x10165d52 */
            ii(0x100a1dd4, 0x1); pushd(ebx);                           /* push ebx */
            ii(0x100a1dd5, 0x1); pushd(ecx);                           /* push ecx */
            ii(0x100a1dd6, 0x1); pushd(memb_a16[ss, 0x5]);
            ii(0x100a1dd7, 0x1); memb_a16[ss, 0x5] = memb_a16[ss, 0x6];
            ii(0x100a1dd8, 0x1); pushd(edi);                           /* push edi */
            ii(0x100a1dd9, 0x1); pushd(ebp);                           /* push ebp */
            ii(0x100a1dda, 0x2); mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a1ddc, 0x6); sub(esp, 0x4);                        /* sub esp, 0x4 */
        }
    }
}
