using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram : BridgeProcessor
    {
        public RawProgramMain RawProgramMain { get; set; }

        public new MikhailKhalizev.Processor.x86.CSharpExecutor.Processor Implementation { get; }

        /// <inheritdoc />
        public RawProgram(MikhailKhalizev.Processor.x86.CSharpExecutor.Processor implementation)
            : base(implementation)
        {
            Implementation = implementation;
        }
    }
}