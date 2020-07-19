using System.Linq;
using FluentAssertions;
using MikhailKhalizev.Processor.x86.Utils;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests.Utils
{
    public class BinaryHelperTests
    {
        [Fact]
        public void EnumerateBits()
        {
            BinaryHelper.EnumerateBits(0).Reverse().SkipWhile(x => !x).Should().BeEquivalentTo();
            BinaryHelper.EnumerateBits(1).Reverse().SkipWhile(x => !x).Should().BeEquivalentTo(true);
            BinaryHelper.EnumerateBits(2).Reverse().SkipWhile(x => !x).Should().BeEquivalentTo(true, false);
            BinaryHelper.EnumerateBits(3).Reverse().SkipWhile(x => !x).Should().BeEquivalentTo(true, true);

            BinaryHelper.EnumerateBits(-1).Reverse().SkipWhile(x => x).Should().BeEquivalentTo();
            BinaryHelper.EnumerateBits(-2).Reverse().SkipWhile(x => x).Should().BeEquivalentTo(false);
            BinaryHelper.EnumerateBits(-3).Reverse().SkipWhile(x => x).Should().BeEquivalentTo(false, true);
            BinaryHelper.EnumerateBits(-4).Reverse().SkipWhile(x => x).Should().BeEquivalentTo(false, false);
        }

        [Fact]
        public void CheckMaskInt32()
        {
            BinaryHelper.MaskInt32(0).Should().Be(0);
            BinaryHelper.MaskInt32(1).Should().Be(1);
            BinaryHelper.MaskInt32(2).Should().Be(3);
            BinaryHelper.MaskInt32(3).Should().Be(7);
            BinaryHelper.MaskInt32(30).Should().Be(int.MaxValue / 2);
            BinaryHelper.MaskInt32(31).Should().Be(int.MaxValue);
            BinaryHelper.MaskInt32(32).Should().Be(-1);
        }

        [Fact]
        public void CheckMaskUInt32()
        {
            BinaryHelper.MaskUInt32(0).Should().Be(0);
            BinaryHelper.MaskUInt32(1).Should().Be(1);
            BinaryHelper.MaskUInt32(2).Should().Be(3);
            BinaryHelper.MaskUInt32(3).Should().Be(7);
            BinaryHelper.MaskUInt32(30).Should().Be(uint.MaxValue / 4);
            BinaryHelper.MaskUInt32(31).Should().Be(uint.MaxValue / 2);
            BinaryHelper.MaskUInt32(32).Should().Be(uint.MaxValue);
        }

        [Fact]
        public void CheckMaskUInt64()
        {
            BinaryHelper.MaskUInt64(0).Should().Be(0);
            BinaryHelper.MaskUInt64(1).Should().Be(1);
            BinaryHelper.MaskUInt64(2).Should().Be(3);
            BinaryHelper.MaskUInt64(3).Should().Be(7);
            BinaryHelper.MaskUInt64(62).Should().Be(ulong.MaxValue / 4);
            BinaryHelper.MaskUInt64(63).Should().Be(ulong.MaxValue / 2);
            BinaryHelper.MaskUInt64(64).Should().Be(ulong.MaxValue);
        }
    }
}