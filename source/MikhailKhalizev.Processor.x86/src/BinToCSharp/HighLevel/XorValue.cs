using System.Collections.Generic;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class XorValue : Value
    {
        public IEnumerable<Value> Items => _items;
        private readonly List<Value> _items;

        public XorValue(List<Value> items)
            : base(items.Select(x => x.LengthInBits).Distinct().Single())
        {
            _items = items;
        }

        public XorValue(List<Value> items, int lengthInBits)
            : base(lengthInBits)
        {
            _items = items;
        }
    }
}