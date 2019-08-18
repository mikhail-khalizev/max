using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_292f-a8e718c9")]
        public void Method_0019_292f()
        {
            ii(0x19_292f, 1); pushw(bp);                                /* push bp */
            ii(0x19_2930, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_2932, 2); xor(cx, cx);                              /* xor cx, cx */
            ii(0x19_2934, 2); if(jmpw_func(0x19_2950, 0x1a)) return;    /* jmp 0x2950 */
        }
    }
}
