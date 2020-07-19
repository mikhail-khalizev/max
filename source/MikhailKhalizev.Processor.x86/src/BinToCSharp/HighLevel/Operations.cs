using System;
using System.Collections.Generic;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public static class Operations
    {
        public static Value From(int value, int lengthInBits)
        {
            return new ConstantValue(value, lengthInBits);
        }

        public static Value From(uint value, int lengthInBits) => new ConstantValue((int)value, lengthInBits);


        public static Value Add(Value a, Value b) => Sum(new[] { (1, a), (1, b) });
        public static Value Add(Value a, int b) => Sum(new[] { (1, a), (1, From(b, a.LengthInBits)) });
        public static Value Add(int a, Value b) => Sum(new[] { (1, From(a, b.LengthInBits)), (1, b) });

        public static Value Sub(Value a, Value b) => Sum(new[] { (1, a), (-1, b) });
        public static Value Sub(Value a, int b) => Sum(new[] { (1, a), (-1, From(b, a.LengthInBits)) });
        public static Value Sub(int a, Value b) => Sum(new[] { (1, From(a, b.LengthInBits)), (-1, b) });

        public static Value Mul(Value a, int b) => Sum(new[] { (b, a) });
        public static Value Mul(int a, Value b) => Sum(new[] { (a, b) });

        public static Value Sum(IEnumerable<(int Count, Value Value)> e)
        {
            var lengthInBits = 0;
            ConstantValue constant = null;
            var result = new Dictionary<Value, int>();
            var toProcess = new List<IEnumerable<(int Count, Value Value)>> { e };

            while (toProcess.Count != 0)
            {
                var ee = toProcess[^1];
                toProcess.RemoveAt(toProcess.Count - 1);

                foreach (var (count, value) in ee)
                {
                    if (count == 0)
                        continue;

                    if (lengthInBits == 0)
                        lengthInBits = value.LengthInBits;
                    else if (lengthInBits != value.LengthInBits)
                        throw new NotSupportedException($"lengthInBits != value.LengthInBits. lengthInBits = {lengthInBits}, value.LengthInBits = {value.LengthInBits}.");
                    
                    switch (value)
                    {
                        case SumValue sum:
                            toProcess.Add(sum.Items.Select(x => (count * x.Value, x.Key)));
                            break;
                        case ConstantValue c:
                            constant += count * c;
                            break;
                        default:
                            var newCount = result.GetValueOrDefault(value) + count;
                            if (newCount != 0)
                                result[value] = newCount;
                            else
                                result.Remove(value);
                            break;
                    }
                }
            }

            if (constant != null)
                result[constant] = 1;


            if (result.Count == 0)
                return ConstantValue.Zero(lengthInBits);

            if (result.Count == 1)
            {
                var first = result.First();
                if (first.Value == 1)
                    return first.Key;
            }

            return new SumValue(result, lengthInBits);
        }
    }
}