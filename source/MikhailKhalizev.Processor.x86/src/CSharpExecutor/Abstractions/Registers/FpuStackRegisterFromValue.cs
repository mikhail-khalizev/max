using System;

namespace MikhailKhalizev.Processor.x86.Core.Abstractions.Registers
{
    public sealed class FpuStackRegisterFromValue : FpuStackRegister
    {
        /// <inheritdoc />
        public override int Number => throw new NotSupportedException();

        public ValueBase Value { get; }

        /// <inheritdoc />
        public override int Bits => Value.Bits;

        /// <inheritdoc />
        protected override ulong UInt64Internal
        {
            get => Value.UInt64;
            set => Value.UInt64 = value;
        }
        
        public FpuStackRegisterFromValue(ValueBase value)
        {
            Value = value;
        }
    }
}