using System;
using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public static class Operations
    {
        public static Expression From(int value, int lengthInBits)
        {
            return new ConstantExpression(value, lengthInBits);
        }

        public static Expression From(uint value, int lengthInBits) => new ConstantExpression((int) value, lengthInBits);

        public static Expression From(ConditionType condition, params Expression[] values) => new ConditionExpression(condition, values);


        public static Expression Add(Expression a, Expression b) => Sum(new[] { (1, a), (1, b) });
        public static Expression Add(Expression a, int b) => Sum(new[] { (1, a), (1, From(b, a.LengthInBits)) });
        public static Expression Add(int a, Expression b) => Sum(new[] { (1, From(a, b.LengthInBits)), (1, b) });

        public static Expression Sub(Expression a, Expression b) => Sum(new[] { (1, a), (-1, b) });
        public static Expression Sub(Expression a, int b) => Sum(new[] { (1, a), (-1, From(b, a.LengthInBits)) });
        public static Expression Sub(int a, Expression b) => Sum(new[] { (1, From(a, b.LengthInBits)), (-1, b) });

        public static Expression Mul(Expression a, int b) => Sum(new[] { (b, a) });
        public static Expression Mul(int a, Expression b) => Sum(new[] { (a, b) });

        public static Expression Xor(Expression a, Expression b) => Xor(new[] { a, b });


        public static Expression Sum(IEnumerable<(int Count, Expression Value)> e)
        {
            var lengthInBits = 0;
            ConstantExpression constant = null;
            var result = new Dictionary<Expression, int>();
            var toProcess = new List<IEnumerable<(int Count, Expression Value)>> { e };

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
                            $"lengthInBits != expression.LengthInBits. lengthInBits = {lengthInBits}, expression.LengthInBits = {value.LengthInBits}.");

                    switch (value)
                    {
                        case SumExpression sum:
                            toProcess.Add(sum.Items.Select(x => (count * x.Value, x.Key)));
                            break;
                        case ConstantExpression c:
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
                return ConstantExpression.Zero(lengthInBits);

            if (result.Count == 1)
            {
                var first = result.First();
                if (first.Value == 1)
                    return first.Key;
            }

            return new SumExpression(result, lengthInBits);
        }

        public static Expression Xor(IEnumerable<Expression> items)
        {
            var lengthInBits = 0;
            ConstantExpression constant = null;
            var result = new HashSet<Expression>();
            var toProcess = new List<IEnumerable<Expression>> { items };

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
                            $"lengthInBits != expression.LengthInBits. lengthInBits = {lengthInBits}, expression.LengthInBits = {value.LengthInBits}.");

                    switch (value)
                    {
                        case XorExpression xor:
                            toProcess.Add(xor.Items);
                            break;
                        case ConstantExpression c:
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
                return ConstantExpression.Zero(lengthInBits);

            if (result.Count == 1)
                return result.First();

            return new XorExpression(result.ToList(), lengthInBits);
        }

        // Combine of ((expression << offset) & mask).
        public static Expression Combine(
            int lengthInBits,
            Expression first,
            int firstOffset,
            int firstMask)
        {
            return Combine(
                lengthInBits,
                new[]
                {
                    (first, firstOffset, firstMask)
                });
        }

        // Combine of ((value << offset) & mask).
        public static Expression Combine(int lengthInBits, params (Expression Value, int Offset, int Mask)[] sourceItems)
        {
            return Combine(lengthInBits, sourceItems.AsEnumerable());
        }

        // Combine of ((value << offset) & mask).
        public static Expression Combine(int lengthInBits, IEnumerable<(Expression Value, int Offset, int Mask)> sourceItems)
        {
            var resultItems = new List<(Expression Value, int Offset, int Mask)>();
            var valueMask = BinaryHelper.MaskInt32(lengthInBits);

            foreach (var sourceItem in sourceItems)
            {
                for (var i = 0; i < resultItems.Count; i++)
                {
                    var item = resultItems[i];
                    resultItems[i] = (item.Value, item.Offset, item.Mask & ~sourceItem.Mask & valueMask);
                }

                if (sourceItem.Value is CombineExpression cv)
                {
                    if (sourceItem.Offset == 0)
                        resultItems.AddRange(
                            cv.Items.Select(
                                x =>
                                    (x.Value, x.Offset, Mask: x.Mask & sourceItem.Mask & valueMask)));
                    else
                        resultItems.AddRange(
                            cv.Items.Select(
                                x =>
                                    (x.Value, x.Offset + sourceItem.Offset,
                                        Mask: (x.Mask << sourceItem.Offset) & sourceItem.Mask & valueMask)));
                }
                else
                    resultItems.Add(
                        (sourceItem.Value, sourceItem.Offset, BinaryHelper.MaskInt32(lengthInBits) & sourceItem.Mask & valueMask));
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
                else if (item.Value is ConstantExpression cv)
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


            resultItems = resultItems
                .GroupBy(
                    x => (x.Value, x.Offset),
                    (tuple, tuples) => (tuple.Value, tuple.Offset, tuples.Aggregate(0, (mask, valueTuple) => mask | valueTuple.Mask)))
                .ToList();


            if (resultItems.Count == 0)
                return ConstantExpression.Zero(lengthInBits);

            if (resultItems.Count == 1)
            {
                var item = resultItems[0];

                if (item.Value is ConstantExpression cv3)
                    return cv3;

                if (item.Offset == 0 && item.Mask == BinaryHelper.MaskInt32(item.Value.LengthInBits))
                    return item.Value;
            }


            return new CombineExpression(resultItems, lengthInBits);
        }
    }
}