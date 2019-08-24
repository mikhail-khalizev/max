using System;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.CSharpExecutor
{
    public sealed class FpuStackRegisterImpl : FpuStackRegister
    {
        public Processor Processor { get; }
        public override int Number { get; }

        public FpuStackRegisterImpl(Processor processor, int number)
        {
            Processor = processor;
            Number = number;
        }

        /// <inheritdoc />
        public override int Bits => 64;

        /// <inheritdoc />
        protected override ulong UInt64Internal
        {
            get
            {
                if (Processor.get_tag(Number) == 3)
                    throw new NotImplementedException("get_tag == 3");
                return (ulong) BitConverter.DoubleToInt64Bits(Processor.RawST(Number));
            }
            set
            {
                var d = BitConverter.Int64BitsToDouble((long) value);
                Processor.RawST(Number) = d;
                Processor.set_tag(0, d == 0 ? 1 : 0);
            }
        }
    }
}
