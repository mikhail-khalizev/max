using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_37cc-8498812b")]
        public void Method_0019_37cc()
        {
            ii(0x19_37cc, 1); push(bp);                                 /* push bp */
            ii(0x19_37cd, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_37cf, 1); push(bx);                                 /* push bx */
            ii(0x19_37d0, 3); mov(bx, memw[ss, bp + 6]);                /* mov bx, [bp+0x6] */
            ii(0x19_37d3, 2); mov(ax, memw[ds, bx]);                    /* mov ax, [bx] */
            ii(0x19_37d5, 3); mov(dx, memw[ds, bx + 2]);                /* mov dx, [bx+0x2] */
            ii(0x19_37d8, 3); mov(cx, memw[ss, bp + 8]);                /* mov cx, [bp+0x8] */
            ii(0x19_37db, 1); push(cs);                                 /* push cs */
            ii(0x19_37dc, 3); call(0x19_37b4, -0x2b);                   /* call 0x37b4 */
            ii(0x19_37df, 2); mov(memw[ds, bx], ax);                    /* mov [bx], ax */
            ii(0x19_37e1, 3); mov(memw[ds, bx + 2], dx);                /* mov [bx+0x2], dx */
            ii(0x19_37e4, 1); pop(bx);                                  /* pop bx */
            ii(0x19_37e5, 1); pop(bp);                                  /* pop bp */
            ii(0x19_37e6, 3); retf(4);                                  /* retf 0x4 */
        }
    }
}
