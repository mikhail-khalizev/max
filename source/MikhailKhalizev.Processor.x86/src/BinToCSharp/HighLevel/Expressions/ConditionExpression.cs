using System.Collections.Generic;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class ConditionExpression : Expression
    {
        public ConditionType Condition { get; }
        public IReadOnlyCollection<Expression> Values { get; }

        public ConditionExpression(ConditionType condition, params Expression[] values)
            : base(1)
        {
            Condition = condition;
            Values = values;
        }
    }
}