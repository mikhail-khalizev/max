using System.Linq;
using FluentAssertions;
using MikhailKhalizev.Utils;
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
    }
}