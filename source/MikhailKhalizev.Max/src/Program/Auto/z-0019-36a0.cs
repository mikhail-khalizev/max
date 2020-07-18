using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_36a0-67a6d92")]
        public void Method_0019_36a0()
        {
            ii(0x19_36a0, 1);  push(bp);                               /* push bp */
            ii(0x19_36a1, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_36a3, 1);  push(ds);                               /* push ds */
            ii(0x19_36a4, 1);  push(bx);                               /* push bx */
            ii(0x19_36a5, 3);  lds(bx, memw[ss, bp + 6]);              /* lds bx, [bp+0x6] */
            ii(0x19_36a8, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x19_36ab, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x19_36ae, 3);  push(memw[ds, bx + 2]);                 /* push word [bx+0x2] */
            ii(0x19_36b1, 2);  push(memw[ds, bx]);                     /* push word [bx] */
            ii(0x19_36b3, 1);  push(cs);                               /* push cs */
            ii(0x19_36b4, 3);  call(0x19_36e2, 0x2b);                  /* call 0x36e2 */
            ii(0x19_36b7, 2);  mov(memw[ds, bx], ax);                  /* mov [bx], ax */
            ii(0x19_36b9, 3);  mov(memw[ds, bx + 2], dx);              /* mov [bx+0x2], dx */
            ii(0x19_36bc, 1);  pop(bx);                                /* pop bx */
            ii(0x19_36bd, 1);  pop(ds);                                /* pop ds */
            ii(0x19_36be, 1);  pop(bp);                                /* pop bp */
            ii(0x19_36bf, 3);  retf(8);                                /* retf 0x8 */
        }
    }
}
