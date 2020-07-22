using System.Collections.Generic;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class ConditionValue : Value
    {
        public ConditionType Condition { get; }
        public IReadOnlyCollection<Value> Values { get; }

        public ConditionValue(ConditionType condition, params Value[] values)
            : base(1)
        {
            Condition = condition;
            Values = values;
        }
    }
}