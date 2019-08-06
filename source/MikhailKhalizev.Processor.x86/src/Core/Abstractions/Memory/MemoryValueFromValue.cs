using System;
using MikhailKhalizev.Processor.x86.Abstractions.Registers;

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
        
        public MemoryValueFromValue(ValueBase value)
        {
            Value = value;
        }

        /// <inheritdoc />
        public override SegmentRegister Segment => throw new NotSupportedException();

        /// <inheritdoc />
        public override Address Address => throw new NotSupportedException();
    }
}