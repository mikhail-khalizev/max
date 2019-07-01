namespace MikhailKhalizev.Processor.x86.Abstractions.Value
{
    public sealed class NumericValue : Value
    {
        public override int Bits { get; }

        /// <inheritdoc />
        protected override ulong UInt64Internal { get; set; }
        

        public NumericValue(short value, int bits = 16)
        {
            UInt64Internal = (ulong)value;
            Bits = bits;
        }

        public NumericValue(ushort value, int bits = 16)
        {
            UInt64Internal = value;
            Bits = bits;
        }


        public NumericValue(int value, int bits = 32)
        {
            UInt64Internal = (ulong)value;
            Bits = bits;
        }

        public NumericValue(uint value, int bits = 32)
        {
            UInt64Internal = value;
            Bits = bits;
        }
        

        public NumericValue(long value, int bits = 64)
        {
            UInt64Internal = (ulong)value;
            Bits = bits;
        }

        public NumericValue(ulong value, int bits = 64)
        {
            UInt64Internal = value;
            Bits = bits;
        }
    }
}