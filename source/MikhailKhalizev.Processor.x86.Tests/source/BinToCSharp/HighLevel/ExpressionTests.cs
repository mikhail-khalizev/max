using FluentAssertions;
using MikhailKhalizev.Processor.x86.BinToCSharp.Expressions;
using MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel;
using SharpDisasm.Udis86;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests.BinToCSharp.HighLevel
{
    public class ExpressionTests
    {
        [Fact]
        public void CheckCombine()
        {
            var ax = new RegisterExpression(ud_type.UD_R_AX);
            var bx = new RegisterExpression(ud_type.UD_R_BX);

            var c = Expression.Combine(
                16,
                (ax, 2, 0b0011_1100),
                (bx, 3, 0b1111_0000),
                (ax, 2, 0b1000_0011));

            var str = c.ToString();
            str.Should().Be("ax << 2 & 0x8f | bx << 3 & 0x70");
        }
    }
}