using System.Collections.Generic;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class ConditionExpression : Expression
    {
        public Expression Left { get; }
        public ConditionType Condition { get; }
        public Expression Right { get; }

        public ConditionExpression(Expression left, ConditionType condition, Expression right)
            : base(1)
        {
            Condition = condition;
            Left = left;
            Right = right;
        }
    }
}