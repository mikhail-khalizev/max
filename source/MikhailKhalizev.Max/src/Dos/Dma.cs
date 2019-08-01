using MikhailKhalizev.Max.Program;
using MikhailKhalizev.Processor.x86.Abstractions;

namespace MikhailKhalizev.Max.Dos
{
    public class Dma : BridgeProcessor
    {
        public RawProgramMain RawProgramMain { get; }

        public Dma(IProcessor implementation, RawProgramMain rawProgramMain)
            : base(implementation)
        {
            RawProgramMain = rawProgramMain;
        }
    }
}