using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3f5494c4-67b1-4f66-a2f8-d58160c305b8")]
        public void Method_0000_81e0()
        {
            ii(0x81e0, 1);    pushw(bp);                                /* push bp */
            ii(0x81e1, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x81e3, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x81e6, 3);    callw(0x81d2, -0x17);                     /* call 0x5a12 */
            ii(0x81e9, 1);    popw(bx);                                 /* pop bx */
            ii(0x81ea, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x81ec, 1);    popw(bp);                                 /* pop bp */
            ii(0x81ed, 1);    retw(); return;                           /* ret */
        }
    }
}
