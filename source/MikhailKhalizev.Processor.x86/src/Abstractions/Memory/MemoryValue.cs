using MikhailKhalizev.Processor.x86.Abstractions.Registers;
using MikhailKhalizev.Processor.x86.Abstractions.Value;

namespace MikhailKhalizev.Processor.x86.Abstractions.Memory
{
    public abstract class MemoryValue : ValueBase
    {
        public abstract Address EffectiveAddress { get; }

        public static implicit operator MemoryValue(Value.Value value) => new MemoryValueFromValue(value);
        public static implicit operator Value.Value(MemoryValue value) => new ValueFromAnyValue(value);
        
        public static implicit operator MemoryValue(short value) => (Value.Value)value;
        public static implicit operator MemoryValue(ushort value) => (Value.Value)value;
        public static implicit operator MemoryValue(int value) => (Value.Value)value;
        public static implicit operator MemoryValue(uint value) => (Value.Value)value;
        public static implicit operator MemoryValue(long value) => (Value.Value)value;
        public static implicit operator MemoryValue(ulong value) => (Value.Value)value;

        public static implicit operator MemoryValue(Address value) => (Value.Value)value;
        public static implicit operator MemoryValue(Register value) => (Value.Value)value;
    }
}