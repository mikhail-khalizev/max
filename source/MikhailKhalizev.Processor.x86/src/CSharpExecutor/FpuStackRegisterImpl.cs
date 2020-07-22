using System;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.CSharpExecutor
{
    public sealed class FpuStackRegisterImpl : FpuStackRegister
    {
        public Cpu Cpu { get; }
        public override int Number { get; }

        public FpuStackRegisterImpl(Cpu cpu, int number)
        {
            Cpu = cpu;
            Number = number;
        }

        /// <inheritdoc />
        public override int LengthInBits => 64;

        /// <inheritdoc />
        protected override ulong UInt64Internal
        {
            get
            {
                if (Cpu.get_tag(Number) == 3)
                    throw new NotImplementedException($"get_tag({Number}) == 3");
                return (ulong) BitConverter.DoubleToInt64Bits(Cpu.RawST(Number));
            }
            set
            {
                var d = BitConverter.Int64BitsToDouble((long) value);
                Cpu.RawST(Number) = d;
                Cpu.set_tag(0, d == 0 ? 1 : 0);
            }
        }

        public override double Double
        {
            get
            {
                if (Cpu.get_tag(Number) == 3)
                    throw new NotImplementedException($"get_tag({Number}) == 3");
                return Cpu.RawST(Number);
            }
            set
            {
                Cpu.RawST(Number) = value;
                Cpu.set_tag(0, value == 0 ? 1 : 0);
            }
        }
    }
}
