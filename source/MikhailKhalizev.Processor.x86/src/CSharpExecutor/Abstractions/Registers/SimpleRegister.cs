namespace MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers
{
    public sealed class SimpleRegister : Register
    {
        public SimpleRegister(int bits)
        {
            Bits = bits;
        }

        /// <inheritdoc />
        public override int Bits { get; }

        /// <inheritdoc />
        protected override ulong UInt64Internal { get; set; }
    }
}
    