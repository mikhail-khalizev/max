namespace MikhailKhalizev.Processor.x86.Core.Abstractions.Registers
{
    public abstract class FpuStackRegister : Register
    {
        public abstract int Number { get; }
    }
}