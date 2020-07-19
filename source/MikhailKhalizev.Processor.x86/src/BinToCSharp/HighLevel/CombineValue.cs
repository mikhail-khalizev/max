using System;
using System.Collections.Generic;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class CombineValue : Value
    {
        // Combination of ((value << offset) & mask).

        public IReadOnlyList<(Value Value, int Offset, int Mask)> Items => _items;
        private readonly List<(Value Value, int Offset, int Mask)> _items;


        public CombineValue(int lengthInBits) : base(lengthInBits)
        {
            _items = new List<(Value Value, int Offset, int Mask)>();
        }

        public CombineValue(List<(Value Value, int Offset, int Mask)> items, int lengthInBits) : base(lengthInBits)
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