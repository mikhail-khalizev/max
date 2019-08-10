using MikhailKhalizev.Processor.x86.Core.Abstractions;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram : BridgeProcessor
    {
        public RawProgramMain RawProgramMain { get; set; }

        /// <inheritdoc />
        public RawProgram(IProcessor implementation)
            : base(implementation)
        { }
    }
}