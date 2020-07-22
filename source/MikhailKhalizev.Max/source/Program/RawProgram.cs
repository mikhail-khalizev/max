using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram : BridgeCpu
    {
        public RawProgramMain RawProgramMain { get; set; }

        public new MikhailKhalizev.Processor.x86.CSharpExecutor.Cpu Implementation { get; }

        /// <inheritdoc />
        public RawProgram(MikhailKhalizev.Processor.x86.CSharpExecutor.Cpu implementation)
            : base(implementation)
        {
            Implementation = implementation;
        }
    }
}