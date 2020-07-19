using System;
using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public static class Operations
    {
        public static Value From(int value, int lengthInBits)
        {
            if (lengthInBits != 32)
            {
                var isNegative = (value & (1 << (lengthInBits - 1))) != 0;
                if (isNegative)
                    value |= ~((1 << lengthInBits) - 1);
            }

            return new ConstantValue(value, lengthInBits);
        }

        public static Value From(uint value, int lengthInBits) => new ConstantValue((int)value, lengthInBits);


        public static Value Add(Value a, Value b) => Sum(new[] { (1, a), (1, b) });

        public static Value Add(Value a, int b) => a + From(b, a.LengthInBits);
        public static Value Add(int a, Value b) => From(a, b.LengthInBits) + b;

        public static Value Sub(Value a, Value b) => Sum(new[] { (1, a), (-1, b) });

        public static Value Sub(Value a, int b) => a - From(b, a.LengthInBits);
        public static Value Sub(int a, Value b) => From(a, b.LengthInBits) - b;

        private static Value Sum(IEnumerable<(int Count, Value Value)> e)
        {
            var bits = 0;
            ConstantValue constant = null;
            var result = new Dictionary<Value, int>();
            var toProcess = new List<IEnumerable<(int Count, Value Value)>> { e };

            while (toProcess.Count != 0)
            {
                var ee = toProcess[toProcess.Count - 1];
                toProcess.RemoveAt(toProcess.Count - 1);

                foreach (var (count, value) in ee)
                {
#if DEBUG
                    if (lengthInBits == 0)
                        lengthInBits = value.LengthInBits;
                    else if (lengthInBits != value.LengthInBits)
                        throw new InvalidOperationException($"lengthInBits != value.LengthInBits. lengthInBits = {lengthInBits}, value.LengthInBits = {value.LengthInBits}.");
#else
                    bits = value.LengthInBits;
#endif

                    switch (value)
                    {
                        case SumValue sum:
                            toProcess.Add(sum.Items.Select(x => (count * x.Value, x.Key)).ToList());
                            break;
                        case ConstantValue c:
                            constant += count * c;
                            break;
                        default:
                            result[value] = result.GetValueOrDefault(value) + count;
                            break;
                    }
                }
            }

            if (constant != null)
                result[constant] = 1;


            foreach (var pair in result.Where(x => x.Value == 0).ToList())
                result.Remove(pair.Key);


            if (result.Count == 0)
                return new ConstantValue(0, bits);

            if (result.Count == 1)
            {
                var first = result.First();
                if (first.Value == 1)
                    return first.Key;
            }

            return new SumValue(result, bits);
        }
    }
}