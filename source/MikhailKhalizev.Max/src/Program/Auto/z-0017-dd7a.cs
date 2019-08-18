using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cd482518-e7a6-4fb1-9205-5e8a09957ca4")]
        public void Method_0017_dd7a()
        {
            ii(0x17_dd7a, 1); pushw(bp);                                /* push bp */
            ii(0x17_dd7b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_dd7d, 1); pushw(ds);                                /* push ds */
            ii(0x17_dd7e, 1); pushw(bx);                                /* push bx */
            ii(0x17_dd7f, 3); lds(bx, ss, bp + 0x6);                    /* lds bx, [bp+0x6] */
            ii(0x17_dd82, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x17_dd85, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x17_dd88, 3); pushw(memw_a16[ds, bx + 0x2]);            /* push word [bx+0x2] */
            ii(0x17_dd8b, 2); pushw(memw_a16[ds, bx]);                  /* push word [bx] */
            ii(0x17_dd8d, 1); pushw(cs);                                /* push cs */
            ii(0x17_dd8e, 3); callw(0x17_dddc, 0x4b);                   /* call 0xdddc */
            ii(0x17_dd91, 3); mov(memw_a16[ds, bx + 0x2], dx);          /* mov [bx+0x2], dx */
            ii(0x17_dd94, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x17_dd96, 1); popw(bx);                                 /* pop bx */
            ii(0x17_dd97, 1); popw(ds);                                 /* pop ds */
            ii(0x17_dd98, 1); popw(bp);                                 /* pop bp */
            ii(0x17_dd99, 3); retfw(0x8); return;                       /* retf 0x8 */
        }
    }
}
