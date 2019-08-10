using System;
using MikhailKhalizev.Max.Program;
using MikhailKhalizev.Processor.x86.Core.Abstractions;

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
            Console.WriteLine($"\tset_irq_mask. irq: 0x{irq:x}, masked: {masked}");
            // TODO
        }

        public void write_command(int port, int value)
        {
            Console.WriteLine($"\twrite_command. port: 0x{port:x}, value: 0x{value:x}");
            // TODO
        }

        public int read_command(int port)
        {
            Console.WriteLine($"\tread_command. port: 0x{port:x}");
            // TODO
            return 0;
        }

        public void RunIrqs()
        {
            // TODO
        }
    }
}