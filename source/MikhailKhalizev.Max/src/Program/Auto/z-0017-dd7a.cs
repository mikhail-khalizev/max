using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_dd7a-d925f6b2")]
        public void Method_0017_dd7a()
        {
            ii(0x17_dd7a, 1); push(bp);                                 /* push bp */
            ii(0x17_dd7b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_dd7d, 1); push(ds);                                 /* push ds */
            ii(0x17_dd7e, 1); push(bx);                                 /* push bx */
            ii(0x17_dd7f, 3); lds(bx, memw[ss, bp + 0x6]);              /* lds bx, [bp+0x6] */
            ii(0x17_dd82, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x17_dd85, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x17_dd88, 3); push(memw[ds, bx + 0x2]);                 /* push word [bx+0x2] */
            ii(0x17_dd8b, 2); push(memw[ds, bx]);                       /* push word [bx] */
            ii(0x17_dd8d, 1); push(cs);                                 /* push cs */
            ii(0x17_dd8e, 3); call(0x17_dddc, 0x4b);                    /* call 0xdddc */
            ii(0x17_dd91, 3); mov(memw[ds, bx + 0x2], dx);              /* mov [bx+0x2], dx */
            ii(0x17_dd94, 2); mov(memw[ds, bx], ax);                    /* mov [bx], ax */
            ii(0x17_dd96, 1); pop(bx);                                  /* pop bx */
            ii(0x17_dd97, 1); pop(ds);                                  /* pop ds */
            ii(0x17_dd98, 1); pop(bp);                                  /* pop bp */
            ii(0x17_dd99, 3); retf(0x8);                                /* retf 0x8 */
        }
    }
}
