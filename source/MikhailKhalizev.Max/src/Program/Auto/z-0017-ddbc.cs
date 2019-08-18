using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_ddbc-debdba9f")]
        public void Method_0017_ddbc()
        {
            ii(0x17_ddbc, 1); pushw(bp);                                /* push bp */
            ii(0x17_ddbd, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_ddbf, 1); pushw(ds);                                /* push ds */
            ii(0x17_ddc0, 1); pushw(bx);                                /* push bx */
            ii(0x17_ddc1, 3); lds(bx, ss, bp + 0x6);                    /* lds bx, [bp+0x6] */
            ii(0x17_ddc4, 2); mov(ax, memw_a16[ds, bx]);                /* mov ax, [bx] */
            ii(0x17_ddc6, 3); mov(dx, memw_a16[ds, bx + 0x2]);          /* mov dx, [bx+0x2] */
            ii(0x17_ddc9, 3); mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x17_ddcc, 1); pushw(cs);                                /* push cs */
            ii(0x17_ddcd, 3); callw(0x17_df60, 0x190);                  /* call 0xdf60 */
            ii(0x17_ddd0, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x17_ddd2, 3); mov(memw_a16[ds, bx + 0x2], dx);          /* mov [bx+0x2], dx */
            ii(0x17_ddd5, 1); popw(bx);                                 /* pop bx */
            ii(0x17_ddd6, 1); popw(ds);                                 /* pop ds */
            ii(0x17_ddd7, 1); popw(bp);                                 /* pop bp */
            ii(0x17_ddd8, 3); retfw(0x6); return;                       /* retf 0x6 */
        }
    }
}
