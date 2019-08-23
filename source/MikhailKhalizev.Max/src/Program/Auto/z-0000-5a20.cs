using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5a20-48b060fa")]
        public void Method_0000_5a20()
        {
            ii(0x5a20, 1);    pushw(bp);                                /* push bp */
            ii(0x5a21, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x5a23, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x5a26, 3);    callw(0x5a12, -0x17);                     /* call 0x5a12 */
            ii(0x5a29, 1);    popw(bx);                                 /* pop bx */
            ii(0x5a2a, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x5a2c, 1);    popw(bp);                                 /* pop bp */
            ii(0x5a2d, 1);    retw();                                   /* ret */
        }
    }
}
