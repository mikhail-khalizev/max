using MikhailKhalizev.Max.Program;
using MikhailKhalizev.Processor.x86.Abstractions;

namespace MikhailKhalizev.Max.Dos
{
    public class Pic : BridgeProcessor
    {
        public RawProgramMain RawProgramMain { get; }

        public Pic(IProcessor implementation, RawProgramMain rawProgramMain)
            : base(implementation)
        {
            RawProgramMain = rawProgramMain;
        }

        public void set_irq_mask(int a, bool b)
        {
            // TODO
        }
    }
}