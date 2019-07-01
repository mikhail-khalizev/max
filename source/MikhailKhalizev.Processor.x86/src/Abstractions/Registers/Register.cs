using MikhailKhalizev.Processor.x86.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Abstractions.Value;

namespace MikhailKhalizev.Processor.x86.Abstractions.Registers
{
    /// <summary>
    /// Регистр у которого можно прочитать или установить значение.
    /// </summary>
    public abstract class Register : ValueBase
    {
        public static implicit operator Register(Value.Value value) => new RegisterFromValue(value);
        public static implicit operator Value.Value(Register value) => new ValueFromAnyValue(value);

        public static implicit operator Register(short value) => (Value.Value)value;
        public static implicit operator Register(ushort value) => (Value.Value)value;
        public static implicit operator Register(int value) => (Value.Value)value;
        public static implicit operator Register(uint value) => (Value.Value)value;
        public static implicit operator Register(long value) => (Value.Value)value;
        public static implicit operator Register(ulong value) => (Value.Value)value;

        public static implicit operator Register(Address value) => (Value.Value)value;
        public static implicit operator Register(MemoryValue value) => (Value.Value)value;
    }
}
