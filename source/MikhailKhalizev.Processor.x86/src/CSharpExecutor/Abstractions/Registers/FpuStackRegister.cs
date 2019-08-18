using MikhailKhalizev.Processor.x86.Core.Abstractions.Memory;

namespace MikhailKhalizev.Processor.x86.Core.Abstractions.Registers
{
    public abstract class FpuStackRegister : Register
    {
        public abstract int Number { get; }
        
        public static implicit operator FpuStackRegister(Value value) => new FpuStackRegisterFromValue(value);
        public static implicit operator Value(FpuStackRegister value) => new ValueFromAnyValue(value);

        public static implicit operator FpuStackRegister(short value) => (Value)value;
        public static implicit operator FpuStackRegister(ushort value) => (Value)value;
        public static implicit operator FpuStackRegister(int value) => (Value)value;
        public static implicit operator FpuStackRegister(uint value) => (Value)value;
        public static implicit operator FpuStackRegister(long value) => (Value)value;
        public static implicit operator FpuStackRegister(ulong value) => (Value)value;

        public static implicit operator FpuStackRegister(Address value) => (Value)value;
        public static implicit operator FpuStackRegister(MemoryValue value) => (Value)value;
    }
}