using MikhailKhalizev.Processor.x86.Abstractions;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram : BridgeProcessor
    {
        /// <inheritdoc />
        public RawProgram(IProcessor implementation) 
            : base(implementation)
        { }
    }
}