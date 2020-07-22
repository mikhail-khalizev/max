using System.Collections.Generic;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class SumExpression : Expression
    {
        public IReadOnlyDictionary<Expression, int> Items => _items;
        private readonly Dictionary<Expression, int> _items;

        public SumExpression(Dictionary<Expression, int /* count, multiply coefficient */> items)
            : base(items.Select(x => x.Key.LengthInBits).Distinct().Single())
        {
            _items = items;
        }

        public SumExpression(Dictionary<Expression, int> items, int lengthInBits)
            : base(lengthInBits)
        {
            _items = items;
        }
    }
}