using FluentAssertions;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests
{
    public class ValuesTests
    {
        [Fact]
        public void CheckInt16ValueNegative()
        {
            var v = (Value)((short)-1);
            v.UInt64.Should().Be(0xffff);
        }

        [Fact]
        public void CheckInt32ValueNegative()
        {
            var v = (Value)(-1);
            v.UInt64.Should().Be(0xffff_ffff);
        }

        [Fact]
        public void CheckInt64ValueNegative()
        {
            var v = (Value)(-1L);
            v.UInt64.Should().Be(0xffff_ffff_ffff_ffff);
        }

        [Fact]
        public void CheckCastValues()
        {
            Value v = 5;
            MemoryValue mv = 6;
            Register vr = 7;
            Address adr = 8;
            
            v = mv;
            v.UInt64.Should().Be(6);
            mv = v;

            v = vr;
            v.UInt64.Should().Be(7);
            vr = v;

            mv = vr;
            mv.UInt64.Should().Be(7);
            vr = mv;

            v = adr;
            mv = adr;
            vr = adr;
        }


        [Fact]
        public void CheckRegisterPlusNumeric()
        {
            Register val = 0x1000_7678;
            val += 1;
            val.UInt64.Should().Be(0x1000_7679);
        }

        [Fact]
        public void CheckRegisterPlusRegister()
        {
            Register val1 = 1;
            Register val2 = 2;
            var r = val1 + val2;
            r.UInt64.Should().Be(3);
        }

        [Fact]
        public void CheckRegisterPlusMemory()
        {
            Register reg = 0x1000_7678;
            MemoryValue mem = 1;
            reg += mem;
            reg.UInt64.Should().Be(0x1000_7679);
        }
        

        [Fact]
        public void CheckMemoryPlusNumeric()
        {
            MemoryValue val = 0x1000_7678;
            val += 1;
            val.UInt64.Should().Be(0x1000_7679);
        }

        [Fact]
        public void CheckMemoryPlusMemory()
        {
            MemoryValue val1 = 1;
            MemoryValue val2 = 2;
            var r = val1 + val2;
            r.UInt64.Should().Be(3);
        }

        [Fact]
        public void CheckEqualityValues()
        {
            Value v = 5;
            MemoryValue mv = 5;
            Register vr = 5;

            var a = v == 5;
            a.Should().BeTrue();
            a = mv == 5;
            a.Should().BeTrue();
            a = vr == 5;
            a.Should().BeTrue();

            a = v == mv;
            a.Should().BeTrue();
            a = mv == v;
            a.Should().BeTrue();

            a = v == vr;
            a.Should().BeTrue();
            a = vr == v;
            a.Should().BeTrue();

            a = mv == vr;
            a.Should().BeTrue();
            a = vr == mv;
            a.Should().BeTrue();
        }
    }
}
