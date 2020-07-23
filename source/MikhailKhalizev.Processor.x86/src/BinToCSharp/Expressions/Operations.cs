using System;
using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
{
    public static class Operations
    {
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
                resultItems.Add((Expression.Number(constValue, lengthInBits), 0, constMask));


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