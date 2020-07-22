using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers
{
    public sealed class OffsetRegister : Register
    {
        public Register Register { get; }
        public int Offset { get; }
        public ulong Mask { get; }
        /// <inheritdoc />
        public override int LengthInBits { get; }

        protected override ulong UInt64Internal
        {
            get => Register.UInt64 >> Offset;
            set => Register.UInt64 = (Register.UInt64 & ~Mask) | ((value << Offset) & Mask);
        }

        public OffsetRegister(Register register, int offset, int lengthInBits)
        {
            Register = register;
            LengthInBits = lengthInBits;
            Offset = offset;
            Mask = BinaryHelper.MaskUInt64(lengthInBits, offset);
        }
    }
}