using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_ddbc-debdba9f")]
        public void Method_0017_ddbc()
        {
            ii(0x17_ddbc, 1); push(bp);                                 /* push bp */
            ii(0x17_ddbd, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_ddbf, 1); push(ds);                                 /* push ds */
            ii(0x17_ddc0, 1); push(bx);                                 /* push bx */
            ii(0x17_ddc1, 3); lds(bx, memw[ss, bp + 6]);                /* lds bx, [bp+0x6] */
            ii(0x17_ddc4, 2); mov(ax, memw[ds, bx]);                    /* mov ax, [bx] */
            ii(0x17_ddc6, 3); mov(dx, memw[ds, bx + 2]);                /* mov dx, [bx+0x2] */
            ii(0x17_ddc9, 3); mov(cx, memw[ss, bp + 0xa]);              /* mov cx, [bp+0xa] */
            ii(0x17_ddcc, 1); push(cs);                                 /* push cs */
            ii(0x17_ddcd, 3); call(0x17_df60, 0x190);                   /* call 0xdf60 */
            ii(0x17_ddd0, 2); mov(memw[ds, bx], ax);                    /* mov [bx], ax */
            ii(0x17_ddd2, 3); mov(memw[ds, bx + 2], dx);                /* mov [bx+0x2], dx */
            ii(0x17_ddd5, 1); pop(bx);                                  /* pop bx */
            ii(0x17_ddd6, 1); pop(ds);                                  /* pop ds */
            ii(0x17_ddd7, 1); pop(bp);                                  /* pop bp */
            ii(0x17_ddd8, 3); retf(6);                                  /* retf 0x6 */
        }
    }
}
