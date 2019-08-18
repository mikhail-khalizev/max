using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("178e14e6-fa52-4586-a3a8-aacf0c2a300e")]
        public void Method_0019_292f()
        {
            ii(0x19_292f, 1); pushw(bp);                                /* push bp */
            ii(0x19_2930, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_2932, 2); xor(cx, cx);                              /* xor cx, cx */
            ii(0x19_2934, 2); if(jmpw_func(0x19_2950, 0x1a)) return;    /* jmp 0x2950 */
        }
    }
}
