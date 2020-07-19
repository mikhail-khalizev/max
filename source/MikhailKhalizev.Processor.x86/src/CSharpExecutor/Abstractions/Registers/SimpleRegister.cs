namespace MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers
{
    public sealed class SimpleRegister : Register
    {
        public SimpleRegister(int bits)
        {
            LengthInBits = bits;
        }

        /// <inheritdoc />
        public override int LengthInBits { get; }

        /// <inheritdoc />
        protected override ulong UInt64Internal { get; set; }
    }
}
    