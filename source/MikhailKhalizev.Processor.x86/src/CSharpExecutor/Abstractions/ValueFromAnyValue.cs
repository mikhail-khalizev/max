namespace MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions
{
    public class ValueFromAnyValue : Value
    {
        public ValueBase Value { get; }

        /// <inheritdoc />
        public override int LengthInBits => _bits ?? Value.LengthInBits;

        private readonly int? _bits;

        /// <inheritdoc />
        protected override ulong UInt64Internal
        {
            get => Value.UInt64;
            set => Value.UInt64 = value;
        }

        public ValueFromAnyValue(ValueBase value)
        {
            Value = value;
        }

        public ValueFromAnyValue(ValueBase value, int bits)
        {
            Value = value;
            _bits = bits;
        }
    }
}