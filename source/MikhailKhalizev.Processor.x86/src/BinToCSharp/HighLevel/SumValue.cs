using System.Collections.Generic;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class SumValue : Value
    {
        public IReadOnlyDictionary<Value, int> Items => _items;
        private readonly Dictionary<Value, int> _items;

        public SumValue(Dictionary<Value, int /* count, multiply coefficient */> items)
            : base(items.Select(x => x.Key.LengthInBits).Distinct().Single())
        {
            _items = items;
        }

        public SumValue(Dictionary<Value, int> items, int lengthInBits)
            : base(lengthInBits)
        {
            _items = items;
        }
    }
}