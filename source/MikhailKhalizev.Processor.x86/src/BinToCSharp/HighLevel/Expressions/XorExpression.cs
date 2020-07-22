using System.Collections.Generic;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class XorExpression : Expression
    {
        public IEnumerable<Expression> Items => _items;
        private readonly List<Expression> _items;

        public XorExpression(List<Expression> items)
            : base(items.Select(x => x.LengthInBits).Distinct().Single())
        {
            _items = items;
        }

        public XorExpression(List<Expression> items, int lengthInBits)
            : base(lengthInBits)
        {
            _items = items;
        }
    }
}