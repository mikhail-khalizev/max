using System;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
{
    public class ConstantExpression : Expression
    {
        public int Value { get; }

        /// <inheritdoc />
        public ConstantExpression(int value, int lengthInBits) : base(ExpressionType.Todo_Remove, lengthInBits)
        {
            if (lengthInBits != 32)
            {
                var isNegative = (value & (1 << (lengthInBits - 1))) != 0;
                if (isNegative)
                    value |= ~((1 << lengthInBits) - 1);
            }

            Value = value;
        }

        public static ConstantExpression operator -(ConstantExpression a) => new ConstantExpression(-a.Value, a.LengthInBits);

        public static ConstantExpression operator +(ConstantExpression a, ConstantExpression b)
        {
            if (a.LengthInBits != b.LengthInBits)
                throw new NotSupportedException("a.LengthInBits != b.LengthInBits");
            return new ConstantExpression(a.Value + b.Value, a.LengthInBits);
        }

        public static ConstantExpression operator -(ConstantExpression a, ConstantExpression b)
        {
            if (a.LengthInBits != b.LengthInBits)
                throw new NotSupportedException("a.LengthInBits != b.LengthInBits");
            return new ConstantExpression(a.Value - b.Value, a.LengthInBits);
        }

        public static ConstantExpression operator *(ConstantExpression a, int b) => new ConstantExpression(a.Value * b, a.LengthInBits);

        public static ConstantExpression operator *(int a, ConstantExpression b) => b * a;
        

        public static ConstantExpression operator ^(ConstantExpression a, ConstantExpression b)
        {
            if (a.LengthInBits != b.LengthInBits)
                throw new NotSupportedException("a.LengthInBits != b.LengthInBits");
            return new ConstantExpression(a.Value ^ b.Value, a.LengthInBits);
        }
    }
}