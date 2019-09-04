using FluentAssertions;
using MikhailKhalizev.Processor.x86.Configuration;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests.CSharpExecutor
{
    public class InstructionTests : BridgeCpu
    {
        /// <inheritdoc />
        public InstructionTests()
            : base(new x86.CSharpExecutor.Cpu(new ProcessorDto()))
        { }

        [Fact]
        public void CheckAdc()
        {
            // Case: -1 + 1

            ax = 0xffff;
            bx = 0xffff;
            dx = 0xffff;

            add(ax, 1);

            ax.UInt32.Should().Be(0);
            eflags.cf.Should().BeTrue();
            eflags.of.Should().BeFalse();

            adc(bx, 0);

            bx.UInt32.Should().Be(0);
            eflags.cf.Should().BeTrue();
            eflags.of.Should().BeFalse();

            adc(dx, 0);

            dx.UInt32.Should().Be(0);
            eflags.cf.Should().BeTrue();
            eflags.of.Should().BeFalse();


            // Case: MinValue - 1

            ax = 0;
            bx = 0;
            dx = 0x8000;

            add(ax, 0xffff);

            ax.UInt32.Should().Be(0xffff);
            eflags.cf.Should().BeFalse();
            eflags.of.Should().BeFalse();

            adc(bx, 0xffff);

            bx.UInt32.Should().Be(0xffff);
            eflags.cf.Should().BeFalse();
            eflags.of.Should().BeFalse();

            adc(dx, 0xffff);

            dx.UInt32.Should().Be(0x7fff);
            eflags.cf.Should().BeTrue();
            eflags.of.Should().BeTrue();
        }

        [Fact]
        public void CheckAdd()
        {
            ax = 5;
            bx = 6;

            add(ax, bx);
            ax.UInt32.Should().Be(11);
            eflags.of.Should().BeFalse();
            eflags.cf.Should().BeFalse();

            ax = -1;
            bx = 2;

            add(ax, bx);
            ax.UInt32.Should().Be(1);
            eflags.of.Should().BeFalse();
            eflags.cf.Should().BeTrue();

            ax = 0x7fff;
            bx = 1;

            add(ax, bx);
            ax.UInt32.Should().Be(0x8000);
            eflags.of.Should().BeTrue();
            eflags.cf.Should().BeFalse();

            ax = 0x8000;
            bx = -1;

            add(ax, bx);
            ax.UInt32.Should().Be(0x7fff);
            eflags.of.Should().BeTrue();
            eflags.cf.Should().BeTrue();
        }

        [Fact]
        public void CheckCmp()
        {
            ax = 6;
            bx = 5;

            sub(ax, bx);
            eflags.of.Should().BeFalse();
            eflags.cf.Should().BeFalse();

            ax = 5;
            bx = 6;

            sub(ax, bx);
            eflags.of.Should().BeFalse();
            eflags.cf.Should().BeTrue();

            ax = 0x7fff; // max
            bx = 0xffff; // -1

            sub(ax, bx);
            eflags.of.Should().BeTrue();
            eflags.cf.Should().BeTrue();
        }

        [Fact]
        public void CheckMemoryRead()
        {
            memd_a32[0x0] = 0x0102_0304;

            memb_a32[0x0].UInt64.Should().Be(4);
            memb_a32[0x1].UInt64.Should().Be(3);
            memb_a32[0x2].UInt64.Should().Be(2);
            memb_a32[0x3].UInt64.Should().Be(1);
        }

        [Fact]
        public void CheckMemoryWrite()
        {
            memb_a32[0x0] = 4;
            memb_a32[0x1] = 3;
            memb_a32[0x2] = 2;
            memb_a32[0x3] = 1;

            memd_a32[0x0].UInt64.Should().Be(0x0102_0304);
        }

        [Fact]
        public void CheckMovsx()
        {
            eax = 0x0000_7678;
            movsx(ebx, ax);
            ebx.UInt64.Should().Be(0x0000_7678);

            eax = 0x0000_8678;
            movsx(ebx, ax);
            ebx.UInt64.Should().Be(0xffff_8678);
        }

        [Fact]
        public void CheckPopRegister()
        {
            memw_a32[0] = 0x0102;

            popw(eax);

            eax.UInt32.Should().Be(0x0102);
            esp.UInt32.Should().Be(2);
        }

        [Fact]
        public void CheckPushSpRegister()
        {
            sp = 20;
            pushw(sp);
            popw(bx);

            sp.UInt32.Should().Be(20);
            bx.UInt32.Should().Be(20);
        }

        [Fact]
        public void CheckPushEspRegister()
        {
            esp = 20;
            pushd(esp);
            popd(ebx);

            esp.UInt32.Should().Be(20);
            ebx.UInt32.Should().Be(20);
        }

        [Fact]
        public void CheckRcl()
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
        public void CheckRcr()
        {
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
        public void CheckRol()
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
        public void CheckRor()
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
        public void CheckSar()
        {
            eax = 0x0000_7678;
            sar(eax, 4);
            eax.UInt64.Should().Be(0x0000_0767);

            eax = 0xffff_fffe;
            sar(eax, 1);
            eax.UInt64.Should().Be(0xffff_ffff);
        }

        [Fact]
        public void CheckSbb()
        {
            // Case: 0 - 1

            ax = 0;
            bx = 0;
            dx = 0;

            sub(ax, 1);

            ax.UInt32.Should().Be(0xffff);
            eflags.of.Should().BeFalse();
            eflags.cf.Should().BeTrue();

            sbb(bx, 0);

            bx.UInt32.Should().Be(0xffff);
            eflags.of.Should().BeFalse();
            eflags.cf.Should().BeTrue();

            sbb(dx, 0);

            dx.UInt32.Should().Be(0xffff);
            eflags.of.Should().BeFalse();
            eflags.cf.Should().BeTrue();

            // Case: Min - 1

            ax = 0;
            bx = 0;
            dx = 0x8000;

            sub(ax, 1);

            ax.UInt32.Should().Be(0xffff);
            eflags.of.Should().BeFalse();
            eflags.cf.Should().BeTrue();

            sbb(bx, 0);

            bx.UInt32.Should().Be(0xffff);
            eflags.of.Should().BeFalse();
            eflags.cf.Should().BeTrue();

            sbb(dx, 0);

            dx.UInt32.Should().Be(0x7fff);
            eflags.of.Should().BeTrue();
            eflags.cf.Should().BeFalse();
        }

        [Fact]
        public void CheckShl()
        {
            eax = 0x8000_7678;
            shl(eax, 4);
            eax.UInt64.Should().Be(0x0007_6780);
            eflags.cf.Should().BeFalse();

            shl(eax, 14);
            eflags.cf.Should().BeTrue();
        }

        [Fact]
        public void CheckShr()
        {
            eax = 0x8000_7678;
            shr(eax, 4);
            eax.UInt64.Should().Be(0x0800_0767);
        }

        [Fact]
        public void CheckSub()
        {
            ax = 6;
            bx = 5;

            sub(ax, bx);
            ax.UInt32.Should().Be(1);
            eflags.of.Should().BeFalse();
            eflags.cf.Should().BeFalse();

            ax = 5;
            bx = 6;

            sub(ax, bx);
            ax.UInt32.Should().Be(0xffff);
            eflags.of.Should().BeFalse();
            eflags.cf.Should().BeTrue();

            ax = 0x7fff; // max
            bx = 0xffff; // -1

            sub(ax, bx);
            ax.UInt32.Should().Be(0x8000);
            eflags.of.Should().BeTrue();
            eflags.cf.Should().BeTrue();
        }

        [Fact]
        public void CheckJged()
        {
            var a = cs[eip];

            cmp(5, 5);
            jge(a, 0).Should().BeTrue();

            cmp(0, 0);
            jge(a, 0).Should().BeTrue();

            cmp(-5, -5);
            jge(a, 0).Should().BeTrue();


            cmp(15, 5);
            jge(a, 0).Should().BeTrue();

            cmp(5, -5);
            jge(a, 0).Should().BeTrue();

            cmp(-5, -15);
            jge(a, 0).Should().BeTrue();


            cmp(5, 15);
            jge(a, 0).Should().BeFalse();

            cmp(-5, 5);
            jge(a, 0).Should().BeFalse();

            cmp(-15, -5);
            jge(a, 0).Should().BeFalse();
        }

        [Fact]
        public void CheckJaed()
        {
            var a = cs[eip];

            cmp(5, 5);
            jae(a, 0).Should().BeTrue();

            cmp(0, 0);
            jae(a, 0).Should().BeTrue();

            cmp(uint.MaxValue, uint.MaxValue);
            jae(a, 0).Should().BeTrue();


            cmp(15, 5);
            jae(a, 0).Should().BeTrue();

            cmp(uint.MaxValue, 5);
            jae(a, 0).Should().BeTrue();

            cmp(uint.MaxValue, uint.MaxValue - 1);
            jae(a, 0).Should().BeTrue();


            cmp(5, 15);
            jae(a, 0).Should().BeFalse();

            cmp(5, uint.MaxValue);
            jae(a, 0).Should().BeFalse();

            cmp(uint.MaxValue - 1, uint.MaxValue);
            jae(a, 0).Should().BeFalse();
        }
    }
}