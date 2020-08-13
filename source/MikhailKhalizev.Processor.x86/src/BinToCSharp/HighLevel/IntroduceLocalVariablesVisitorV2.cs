using MikhailKhalizev.Processor.x86.BinToCSharp.Expressions;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class IntroduceLocalVariablesVisitorV2 : ExpressionVisitor
    {
        public Expression MainNode { get; }

        public IntroduceLocalVariablesVisitorV2(Expression mainNode)
        {
            MainNode = mainNode;
        }

        public Expression Process()
        {
            return MainNode;
        }
    }
}