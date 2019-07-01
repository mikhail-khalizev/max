namespace MikhailKhalizev.Processor.x86.Abstractions.Registers
{
    public sealed class RegisterFromValue : Register
    {
        public ValueBase Value { get; }

        /// <inheritdoc />
        public override int Bits => Value.Bits;

        /// <inheritdoc />
        protected override ulong UInt64Internal
        {
            get => Value.UInt64;
            set => Value.UInt64 = value;
        }
        
        public RegisterFromValue(ValueBase value)
        {
            Value = value;
        }
    }
}