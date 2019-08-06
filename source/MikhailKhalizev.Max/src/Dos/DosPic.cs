using MikhailKhalizev.Max.Program;
using MikhailKhalizev.Processor.x86.Abstractions;

namespace MikhailKhalizev.Max.Dos
{
    public class DosPic : BridgeProcessor
    {
        public RawProgramMain RawProgramMain { get; }

        public DosPic(IProcessor implementation, RawProgramMain rawProgramMain)
            : base(implementation)
        {
            RawProgramMain = rawProgramMain;
        }

        public void set_irq_mask(int irq, bool masked)
        {
            // TODO
        }

        public void write_command(int port, int val)
        {
            // TODO
        }

        public int read_command(int port)
        {
            // TODO
            return 0;
        }
    }
}