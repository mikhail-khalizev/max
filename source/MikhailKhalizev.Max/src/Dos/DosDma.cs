using MikhailKhalizev.Max.Program;
using MikhailKhalizev.Processor.x86.Core.Abstractions;

namespace MikhailKhalizev.Max.Dos
{
    public class DosDma : BridgeProcessor
    {
        public RawProgramMain RawProgramMain { get; }

        public DosDma(IProcessor implementation, RawProgramMain rawProgramMain)
            : base(implementation)
        {
            RawProgramMain = rawProgramMain;
        }
    }
}