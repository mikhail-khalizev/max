using System;
using MikhailKhalizev.Processor.x86.Core.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.Core
{
    public sealed class FpuStackRegisterImpl : FpuStackRegister
    {
        public Processor Processor { get; }
        public override int Number { get; }

        public FpuStackRegisterImpl(Processor processor, int number)
        {
            Processor = processor;
            Number = number;
        }

        /// <inheritdoc />
        public override int Bits => 64;

        /// <inheritdoc />
        protected override ulong UInt64Internal
        {
            get => (ulong)BitConverter.DoubleToInt64Bits(Processor.MyST(Number));
            set => Processor.MyST(Number) = BitConverter.Int64BitsToDouble((long)value);
        }
    }
}
    