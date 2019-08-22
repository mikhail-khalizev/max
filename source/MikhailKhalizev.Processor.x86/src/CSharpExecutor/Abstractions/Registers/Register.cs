using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Memory;

namespace MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers
{
    /// <summary>
    /// Регистр у которого можно прочитать или установить значение.
    /// </summary>
    public abstract class Register : ValueBase
    {
        public static implicit operator Register(Value value) => new RegisterFromValue(value);
        public static implicit operator Value(Register value) => new ValueFromAnyValue(value);

        public static implicit operator Register(short value) => (Value)value;
        public static implicit operator Register(ushort value) => (Value)value;
        public static implicit operator Register(int value) => (Value)value;
        public static implicit operator Register(uint value) => (Value)value;
        public static implicit operator Register(long value) => (Value)value;
        public static implicit operator Register(ulong value) => (Value)value;

        public static implicit operator Register(Address value) => (Value)value;
        public static implicit operator Register(MemoryValue value) => (Value)value;
    }
}
