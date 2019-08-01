﻿using MikhailKhalizev.Max.Program;
using MikhailKhalizev.Processor.x86.Abstractions;

namespace MikhailKhalizev.Max.Dos
{
    public class Timer : BridgeProcessor
    {
        public RawProgramMain RawProgramMain { get; }

        public Timer(IProcessor implementation, RawProgramMain rawProgramMain)
            : base(implementation)
        {
            RawProgramMain = rawProgramMain;
        }

        public void timers_init()
        {
            // TODO
        }
    }
}