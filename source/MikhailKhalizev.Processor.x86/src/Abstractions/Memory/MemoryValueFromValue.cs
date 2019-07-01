using System;

namespace MikhailKhalizev.Processor.x86.Abstractions.Memory
{
    public sealed class MemoryValueFromValue : MemoryValue
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

        /// <inheritdoc />
        public override Address EffectiveAddress => throw new NotSupportedException();
        
        public MemoryValueFromValue(ValueBase value)
        {
            Value = value;
        }
    }
}