using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b61596a0-86bb-435d-931e-6ca789b014fe")]
        public void Method_0000_61c2()
        {
            ii(0x61c2, 1);    pushw(bp);                                /* push bp */
            ii(0x61c3, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x61c5, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x61c8, 3);    callw(0x61a4, -0x27);                     /* call 0x59f4 */
            ii(0x61cb, 1);    popw(bx);                                 /* pop bx */
            ii(0x61cc, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x61ce, 1);    popw(bp);                                 /* pop bp */
            ii(0x61cf, 1);    retw(); return;                           /* ret */
        }
    }
}
