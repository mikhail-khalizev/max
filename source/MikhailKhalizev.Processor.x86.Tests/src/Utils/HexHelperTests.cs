using FluentAssertions;
using MikhailKhalizev.Utils;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests.Utils
{
    public class HexHelperTests
    {
        [Theory]
        [InlineData("123", new byte[] { 0x01, 0x23 })]
        [InlineData("1234", new byte[] { 0x12, 0x34 })]
        [InlineData("0x000_102_030_405", new byte[] { 0, 1, 2, 3, 4, 5 })]
        public void HexConvertToBytes(string hex, byte[] expected)
        {
            var bytes = HexHelper.ToBytes(hex, o => o.SetLittleEndian());
            bytes.Should().Equal(expected);

            bytes = HexHelper.ToBytes(hex, o => o.SetBigEndian());
            bytes.Should().Equal(expected);
        }

        [Theory]
        [InlineData(new byte[] { 0, 0 }, 0, false, "0x0000")]
        [InlineData(new byte[] { 0, 0 }, 3, false, "0x0_000")]
        [InlineData(new byte[] { 0, 0 }, 0, true, "0")]
        [InlineData(new byte[] { 0, 0 }, 3, true, "0")]
        [InlineData(new byte[] { 0, 1, 2, 3, 4, 5 }, 0, false, "0x000102030405")]
        [InlineData(new byte[] { 1, 2, 3, 4, 5 }, 0, false, "0x0102030405")]
        [InlineData(new byte[] { 0, 1, 2, 3, 4, 5 }, 3, false, "0x000_102_030_405")]
        [InlineData(new byte[] { 1, 2, 3, 4, 5 }, 3, false, "0x0_102_030_405")]
        [InlineData(new byte[] { 2, 3, 4, 5 }, 3, false, "0x02_030_405")]
        [InlineData(new byte[] { 3, 4, 5 }, 3, false, "0x030_405")]
        [InlineData(new byte[] { 4, 5 }, 3, false, "0x0_405")]
        [InlineData(new byte[] { 5 }, 3, false, "0x05")]
        [InlineData(new byte[] { 0, 1, 2, 3, 4, 5 }, 0, true, "0x102030405")]
        [InlineData(new byte[] { 1, 2, 3, 4, 5 }, 0, true, "0x102030405")]
        [InlineData(new byte[] { 0, 1, 2, 3, 4, 5 }, 3, true, "0x102_030_405")]
        [InlineData(new byte[] { 1, 2, 3, 4, 5 }, 3, true, "0x102_030_405")]
        [InlineData(new byte[] { 2, 3, 4, 5 }, 3, true, "0x2_030_405")]
        [InlineData(new byte[] { 3, 4, 5 }, 3, true, "0x30_405")]
        [InlineData(new byte[] { 4, 5 }, 3, true, "0x405")]
        [InlineData(new byte[] { 5 }, 3, true, "0x5")]
        public void HexConvertToString(byte[] bytes, int groupSize, bool trimZero, string expected)
        {
            var hex = HexHelper.ToString(bytes, o => o.SetGroupSize(groupSize).SetTrimZero(trimZero).SetLittleEndian());
            hex.Should().Be(expected);

            hex = HexHelper.ToString(bytes, o => o.SetGroupSize(groupSize).SetTrimZero(trimZero).SetBigEndian());
            hex.Should().Be(expected);
        }

        [Theory]
        [InlineData(new byte[] { 0xab, 0xcd, 0xef }, null, "0xAbC_DeF")]
        [InlineData(new byte[] { 0xab, 0xcd, 0xef }, "", "0xABc_DEF")]
        [InlineData(new byte[] { 0xab, 0xcd, 0xef }, "x86", "0xaBc_dEF")]
        public void CheckChecksumWithGroup(byte[] bytes, string purpose, string expected)
        {
            var hex = HexHelper.ToString(bytes, o => o.AddChecksum(purpose).SetGroupSize(3));
            hex.Should().Be(expected);

            hex = HexHelper.ToString(bytes, o => o.AddChecksum(purpose).SetGroupSize(0));
            hex.Should().Be(expected.Replace("_", ""));
        }

        [Fact]
        public void CheckRemovedGroupSeparator()
        {
            HexHelper.RemoveGroupSeparatorInAllHexInText("0xa_a_b_b").Should().Be("0xaabb");
        }

        [Fact]
        public void IntToString()
        {
            var str = HexHelper.ToString(0x01020304, o => o.SetGroupSize(0).SetLittleEndian().SetTrimZero());
            str.Should().Be("0x1020304");

            str = HexHelper.ToString(0x01020304, o => o.SetGroupSize(0).SetLittleEndian().SetTrimZero(false));
            str.Should().Be("0x01020304");

            str = HexHelper.ToString(0x01020304, o => o.SetGroupSize(0).SetBigEndian().SetTrimZero());
            str.Should().Be("0x4030201");

            str = HexHelper.ToString(0x01020304, o => o.SetGroupSize(0).SetBigEndian().SetTrimZero(false));
            str.Should().Be("0x04030201");
        }
    }
}