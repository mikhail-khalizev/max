namespace MikhailKhalizev.Processor.x86.Abstractions
{
    public abstract class Value : ValueBase
    {
        public static implicit operator Value(short value) => new NumericValue(value);
        public static implicit operator Value(ushort value) => new NumericValue(value);
        public static implicit operator Value(int value) => new NumericValue(value);
        public static implicit operator Value(uint value) => new NumericValue(value);
        public static implicit operator Value(long value) => new NumericValue(value);
        public static implicit operator Value(ulong value) => new NumericValue(value);
    }
}