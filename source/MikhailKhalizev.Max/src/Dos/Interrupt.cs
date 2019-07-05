using MikhailKhalizev.Processor.x86.Abstractions;

namespace MikhailKhalizev.Max.Dos
{
    public class Interrupt : BridgeProcessor
    {
        public Interrupt(IProcessor implementation)
            : base(implementation)
        { }

        public void install_std_ints()
        {
            // TODO
        }
    }
}