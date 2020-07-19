using System;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class ConstantValue : Value
    {
        public static ConstantValue Zero(int lengthInBits)
        {
            return new ConstantValue(0, lengthInBits);
        }

        public int Value { get; }

        /// <inheritdoc />
        public ConstantValue(int value, int lengthInBits) : base(lengthInBits)
        {
            if (lengthInBits != 32)
            {
                var isNegative = (value & (1 << (lengthInBits - 1))) != 0;
                if (isNegative)
                    value |= ~((1 << lengthInBits) - 1);
            }

            Value = value;
        }

        public static ConstantValue operator -(ConstantValue a) => new ConstantValue(-a.Value, a.LengthInBits);

        public static ConstantValue operator +(ConstantValue a, ConstantValue b)
        {
            if (a == null)
                return b;
            if (b == null)
                return a;

            if (a.LengthInBits != b.LengthInBits)
                throw new NotSupportedException("a.LengthInBits != b.LengthInBits");
            return new ConstantValue(a.Value + b.Value, a.LengthInBits);
        }

        public static ConstantValue operator -(ConstantValue a, ConstantValue b)
        {
            if (a == null)
                return -b;
            if (b == null)
                return a;

            if (a.LengthInBits != b.LengthInBits)
                throw new NotSupportedException("a.LengthInBits != b.LengthInBits");
            return new ConstantValue(a.Value - b.Value, a.LengthInBits);
        }

        public static ConstantValue operator *(ConstantValue a, int b) => new ConstantValue(a.Value * b, a.LengthInBits);

        public static ConstantValue operator *(int a, ConstantValue b) => b * a;
        

        public static ConstantValue operator ^(ConstantValue a, ConstantValue b)
        {
            if (a == null)
                return b;
            if (b == null)
                return a;

            if (a.LengthInBits != b.LengthInBits)
                throw new NotSupportedException("a.LengthInBits != b.LengthInBits");
            return new ConstantValue(a.Value ^ b.Value, a.LengthInBits);
        }
    }
}