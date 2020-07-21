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
            return new ConstantValue(value, lengthInBits);
        }

        public static Value From(uint value, int lengthInBits) => new ConstantValue((int) value, lengthInBits);


        public static Value Add(Value a, Value b) => Sum(new[] { (1, a), (1, b) });
        public static Value Add(Value a, int b) => Sum(new[] { (1, a), (1, From(b, a.LengthInBits)) });
        public static Value Add(int a, Value b) => Sum(new[] { (1, From(a, b.LengthInBits)), (1, b) });

        public static Value Sub(Value a, Value b) => Sum(new[] { (1, a), (-1, b) });
        public static Value Sub(Value a, int b) => Sum(new[] { (1, a), (-1, From(b, a.LengthInBits)) });
        public static Value Sub(int a, Value b) => Sum(new[] { (1, From(a, b.LengthInBits)), (-1, b) });

        public static Value Mul(Value a, int b) => Sum(new[] { (b, a) });
        public static Value Mul(int a, Value b) => Sum(new[] { (a, b) });

        public static Value Xor(Value a, Value b) => Xor(new[] { a, b });


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
                        throw new NotSupportedException(
                            $"lengthInBits != value.LengthInBits. lengthInBits = {lengthInBits}, value.LengthInBits = {value.LengthInBits}.");

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

            if (constant != null && constant.Value != 0)
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

        public static Value Xor(IEnumerable<Value> items)
        {
            var lengthInBits = 0;
            ConstantValue constant = null;
            var result = new HashSet<Value>();
            var toProcess = new List<IEnumerable<Value>> { items };

            while (toProcess.Count != 0)
            {
                var ee = toProcess[^1];
                toProcess.RemoveAt(toProcess.Count - 1);

                foreach (var value in ee)
                {
                    if (lengthInBits == 0)
                        lengthInBits = value.LengthInBits;
                    else if (lengthInBits != value.LengthInBits)
                        throw new NotSupportedException(
                            $"lengthInBits != value.LengthInBits. lengthInBits = {lengthInBits}, value.LengthInBits = {value.LengthInBits}.");

                    switch (value)
                    {
                        case XorValue xor:
                            toProcess.Add(xor.Items);
                            break;
                        case ConstantValue c:
                            constant ^= c;
                            break;
                        default:
                            if (!result.Remove(value))
                                result.Add(value);
                            break;
                    }
                }
            }

            if (constant != null && constant.Value != 0)
                result.Add(constant);


            if (result.Count == 0)
                return ConstantValue.Zero(lengthInBits);

            if (result.Count == 1)
                return result.First();

            return new XorValue(result.ToList(), lengthInBits);
        }

        // Combine of ((value << offset) & mask).
        public static Value Combine(
            int lengthInBits,
            Value first,
            int firstOffset,
            int firstMask)
        {
            return Combine(lengthInBits,
                new[]
                {
                    (first, firstOffset, firstMask)
                });
        }

        // Combine of ((value << offset) & mask).
        public static Value Combine(int lengthInBits, params (Value Value, int Offset, int Mask)[] sourceItems)
        {
            return Combine(lengthInBits, sourceItems.AsEnumerable());
        }

        // Combine of ((value << offset) & mask).
        public static Value Combine(int lengthInBits, IEnumerable<(Value Value, int Offset, int Mask)> sourceItems)
        {
            var resultItems = new List<(Value Value, int Offset, int Mask)>();
            var valueMask = BinaryHelper.MaskInt32(lengthInBits);

            foreach (var sourceItem in sourceItems)
            {
                for (var i = 0; i < resultItems.Count; i++)
                {
                    var item = resultItems[i];
                    resultItems[i] = (item.Value, item.Offset, item.Mask & ~sourceItem.Mask & valueMask);
                }

                if (sourceItem.Value is CombineValue cv)
                {
                    if (sourceItem.Offset == 0)
                        resultItems.AddRange(cv.Items.Select(x =>
                            (x.Value, x.Offset, Mask: x.Mask & sourceItem.Mask & valueMask)));
                    else
                        resultItems.AddRange(cv.Items.Select(x =>
                            (x.Value, x.Offset + sourceItem.Offset, Mask: (x.Mask << sourceItem.Offset) & sourceItem.Mask & valueMask)));
                }
                else
                    resultItems.Add((sourceItem.Value, sourceItem.Offset, BinaryHelper.MaskInt32(lengthInBits) & sourceItem.Mask & valueMask));
            }


            var constValue = 0;
            var constMask = 0;

            for (var i = 0; i < resultItems.Count; i++)
            {
                var item = resultItems[i];
                var shouldRemove = false;

                if (item.Mask == 0)
                {
                    shouldRemove = true;
                }
                else if (item.Value is ConstantValue cv)
                {
                    constValue |= (cv.Value << item.Offset) & item.Mask;
                    constMask |= item.Mask;
                    shouldRemove = true;
                }

                if (shouldRemove)
                {
                    resultItems.RemoveAt(i);
                    i--;
                }
            }

            if (constValue != 0)
                resultItems.Add((From(constValue, lengthInBits), 0, constMask));


            if (resultItems.Count == 0)
                return ConstantValue.Zero(lengthInBits);

            if (resultItems.Count == 1)
            {
                var item = resultItems[0];

                if (item.Value is ConstantValue cv3)
                    return cv3;

                if (item.Offset == 0 && item.Mask == BinaryHelper.MaskInt32(item.Value.LengthInBits))
                    return item.Value;
            }


            return new CombineValue(resultItems, lengthInBits);
        }
    }
}