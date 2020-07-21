using FluentAssertions;
using MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel;
using SharpDisasm.Udis86;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests.BinToCSharp.HighLevel
{
    public class OperationsTests
    {
        [Fact]
        public void CheckOperationsCombineWithDuplicateValueAndIntersects()
        {
            var r1 = new RegisterValue(ud_type.UD_R_AX);
            var r2 = new RegisterValue(ud_type.UD_R_BX);

            var c = Operations.Combine(
                16,
                (r1, 2, 0b0011_1100),
                (r2, 3, 0b1111_0000),
                (r1, 2, 0b1000_0011));


            var cc = c.Should().BeOfType<CombineValue>().Subject;
            cc.Items.Should().HaveCount(2);

            var i1 = cc.Items.Should().ContainSingle(x => x.Value == r1).Subject;
            var i2 = cc.Items.Should().ContainSingle(x => x.Value == r2).Subject;

            i1.Offset.Should().Be(2);
            i1.Mask.Should().Be(0b1000_1111);

            i2.Offset.Should().Be(3);
            i2.Mask.Should().Be(0b0111_0000);
        }
    }
}