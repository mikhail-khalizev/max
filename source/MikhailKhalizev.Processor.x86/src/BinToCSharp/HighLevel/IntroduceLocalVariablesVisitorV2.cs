using MikhailKhalizev.Processor.x86.BinToCSharp.Expressions;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class IntroduceLocalVariablesVisitorV2 : ExpressionVisitor
    {
        public static Expression Process(Expression mainNode)
        {
            return mainNode;
        }
    }
}