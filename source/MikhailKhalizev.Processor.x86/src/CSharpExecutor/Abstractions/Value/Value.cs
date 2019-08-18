using System;

namespace MikhailKhalizev.Processor.x86.Core.Abstractions
{
    public abstract class Value : ValueBase
    {
        public static implicit operator Value(short value) => new NumericValue16(value);
        public static implicit operator Value(ushort value) => new NumericValue16(value);
        public static implicit operator Value(int value) => new NumericValue32(value);
        public static implicit operator Value(uint value) => new NumericValue32(value);
        public static implicit operator Value(long value) => new NumericValue64(value);
        public static implicit operator Value(ulong value) => new NumericValue64(value);

        public static implicit operator Value(double value) => new NumericValue64(BitConverter.DoubleToInt64Bits(value));
    }
}