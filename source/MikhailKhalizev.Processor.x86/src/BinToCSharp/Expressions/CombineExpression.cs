using System;
using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.BinToCSharp.Expressions;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class CombineExpression : Expression
    {
        // Combination of ((value << offset) & mask).

        public IReadOnlyList<(Expression Value, int Offset, int Mask)> Items => _items;
        private readonly List<(Expression Value, int Offset, int Mask)> _items;


        public CombineExpression(int lengthInBits)
            : base(ExpressionType.Todo_Remove, lengthInBits)
        {
            _items = new List<(Expression Value, int Offset, int Mask)>();
        }

        public CombineExpression(List<(Expression Value, int Offset, int Mask)> items, int lengthInBits)
            : base(ExpressionType.Todo_Remove, lengthInBits)
        {
            _items = items;

            // Mask не должны пересекаться.
            var or = 0;
            var xor = 0;
            var sum = 0;
            foreach (var item in items)
            {
                or |= item.Mask;
                xor ^= item.Mask;
                sum += item.Mask;

                if (or == xor && xor == sum)
                    continue;

                throw new ArgumentException("Mask's intersects.");
            }
        }
    }
}