using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a3332edc-631f-4584-91c0-7021c79a9a23")]
        public void Method_0013_dd9c()
        {
            ii(0x13_dd9c, 1); pushw(bp);                                /* push bp */
            ii(0x13_dd9d, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_dd9f, 1); pushw(ds);                                /* push ds */
            ii(0x13_dda0, 1); pushw(bx);                                /* push bx */
            ii(0x13_dda1, 3); lds(bx, ss, bp + 0x6);                    /* lds bx, [bp+0x6] */
            ii(0x13_dda4, 2); mov(ax, memw_a16[ds, bx]);                /* mov ax, [bx] */
            ii(0x13_dda6, 3); mov(dx, memw_a16[ds, bx + 0x2]);          /* mov dx, [bx+0x2] */
            ii(0x13_dda9, 3); mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x13_ddac, 1); pushw(cs);                                /* push cs */
            ii(0x13_ddad, 3); callw(0x13_df48, 0x198);                  /* call 0xdf48 */
            ii(0x13_ddb0, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x13_ddb2, 3); mov(memw_a16[ds, bx + 0x2], dx);          /* mov [bx+0x2], dx */
            ii(0x13_ddb5, 1); popw(bx);                                 /* pop bx */
            ii(0x13_ddb6, 1); popw(ds);                                 /* pop ds */
            ii(0x13_ddb7, 1); popw(bp);                                 /* pop bp */
            ii(0x13_ddb8, 3); retfw(0x6); return;                       /* retf 0x6 */
        }
    }
}
