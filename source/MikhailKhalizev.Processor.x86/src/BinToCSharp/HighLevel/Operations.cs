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
            Value first, int firstOffset, int firstMask,
            Value second, int secondOffset, int secondMask,
            int lengthInBits)
        {
            var items = new List<(Value Value, int Offset, int Mask)>();

            if (first is CombineValue cv1)
            {
                if (firstOffset == 0)
                    items.AddRange(cv1.Items.Select(x => (x.Value, x.Offset, Mask: x.Mask & firstMask & ~secondMask)));
                else
                    items.AddRange(cv1.Items.Select(x =>
                        (x.Value, x.Offset + firstOffset, Mask: (x.Mask << firstOffset) & firstMask & ~secondMask)));
            }
            else
                items.Add((first, firstOffset, BinaryHelper.MaskInt32(lengthInBits) & firstMask & ~secondMask));

            if (second is CombineValue cv2)
            {
                if (secondOffset == 0)
                    items.AddRange(cv2.Items.Select(x => (x.Value, x.Offset, Mask: x.Mask & secondMask)));
                else
                    items.AddRange(cv2.Items.Select(x =>
                        (x.Value, x.Offset + secondOffset, Mask: (x.Mask << secondOffset) & secondMask)));
            }
            else
                items.Add((second, secondOffset, BinaryHelper.MaskInt32(lengthInBits) & secondMask));


            var constValue = 0;
            var constMask = 0;

            for (var i = 0; i < items.Count; i++)
            {
                var item = items[0];
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
                    items.RemoveAt(i);
                    i--;
                }
            }

            if (constValue != 0)
                items.Add((From(constValue, lengthInBits), 0, constMask));


            if (items.Count == 0)
                return ConstantValue.Zero(lengthInBits);

            if (items.Count == 1)
            {
                var item = items[0];

                if (item.Value is ConstantValue cv3)
                    return cv3;

                if (item.Offset == 0 && item.Mask == BinaryHelper.MaskInt32(item.Value.LengthInBits))
                    return item.Value;
            }


            return new CombineValue(items, lengthInBits);
        }
    }
}