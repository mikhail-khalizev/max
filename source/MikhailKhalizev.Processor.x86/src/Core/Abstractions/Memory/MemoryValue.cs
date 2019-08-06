using JetBrains.Annotations;
using MikhailKhalizev.Processor.x86.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.Abstractions.Memory
{
    public abstract class MemoryValue : ValueBase
    {
        public abstract SegmentRegister Segment { get; }
        public abstract Address Address { get; }

        public static implicit operator MemoryValue(Value value) => new MemoryValueFromValue(value);
        public static implicit operator Value(MemoryValue value) => new ValueFromAnyValue(value);
        
        public static implicit operator MemoryValue(short value) => (Value)value;
        public static implicit operator MemoryValue(ushort value) => (Value)value;
        public static implicit operator MemoryValue(int value) => (Value)value;
        public static implicit operator MemoryValue(uint value) => (Value)value;
        public static implicit operator MemoryValue(long value) => (Value)value;
        public static implicit operator MemoryValue(ulong value) => (Value)value;

        public static implicit operator MemoryValue(Address value) => (Value)value;
        public static implicit operator MemoryValue(Register value) => (Value)value;
    }
}