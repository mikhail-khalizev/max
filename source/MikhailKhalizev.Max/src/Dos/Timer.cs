using MikhailKhalizev.Processor.x86.Abstractions;

namespace MikhailKhalizev.Max.Dos
{
    public class Timer : BridgeProcessor
    {
        public Timer(IProcessor implementation)
            : base(implementation)
        { }

        public void timers_init()
        {
            // TODO
        }
    }
}