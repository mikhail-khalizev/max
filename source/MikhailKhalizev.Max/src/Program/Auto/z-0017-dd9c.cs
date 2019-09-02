using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_dd9c-96033697")]
        public void Method_0017_dd9c()
        {
            ii(0x17_dd9c, 1); push(bp);                                 /* push bp */
            ii(0x17_dd9d, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_dd9f, 1); push(ds);                                 /* push ds */
            ii(0x17_dda0, 1); push(bx);                                 /* push bx */
            ii(0x17_dda1, 3); lds(bx, memw[ss, bp + 6]);                /* lds bx, [bp+0x6] */
            ii(0x17_dda4, 2); mov(ax, memw[ds, bx]);                    /* mov ax, [bx] */
            ii(0x17_dda6, 3); mov(dx, memw[ds, bx + 2]);                /* mov dx, [bx+0x2] */
            ii(0x17_dda9, 3); mov(cx, memw[ss, bp + 10]);               /* mov cx, [bp+0xa] */
            ii(0x17_ddac, 1); push(cs);                                 /* push cs */
            ii(0x17_ddad, 3); call(0x17_df48, 0x198);                   /* call 0xdf48 */
            ii(0x17_ddb0, 2); mov(memw[ds, bx], ax);                    /* mov [bx], ax */
            ii(0x17_ddb2, 3); mov(memw[ds, bx + 2], dx);                /* mov [bx+0x2], dx */
            ii(0x17_ddb5, 1); pop(bx);                                  /* pop bx */
            ii(0x17_ddb6, 1); pop(ds);                                  /* pop ds */
            ii(0x17_ddb7, 1); pop(bp);                                  /* pop bp */
            ii(0x17_ddb8, 3); retf(6);                                  /* retf 0x6 */
        }
    }
}
