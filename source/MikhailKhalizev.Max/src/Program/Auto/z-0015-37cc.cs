using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f791f24c-0307-40a7-ab82-cc3d0edb3ec1")]
        public void Method_0015_37cc()
        {
            ii(0x15_37cc, 1); pushw(bp);                                /* push bp */
            ii(0x15_37cd, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_37cf, 1); pushw(bx);                                /* push bx */
            ii(0x15_37d0, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x15_37d3, 2); mov(ax, memw_a16[ds, bx]);                /* mov ax, [bx] */
            ii(0x15_37d5, 3); mov(dx, memw_a16[ds, bx + 0x2]);          /* mov dx, [bx+0x2] */
            ii(0x15_37d8, 3); mov(cx, memw_a16[ss, bp + 0x8]);          /* mov cx, [bp+0x8] */
            ii(0x15_37db, 1); pushw(cs);                                /* push cs */
            ii(0x15_37dc, 3); callw(0x15_37b4, -0x2b);                  /* call 0x37b4 */
            ii(0x15_37df, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x15_37e1, 3); mov(memw_a16[ds, bx + 0x2], dx);          /* mov [bx+0x2], dx */
            ii(0x15_37e4, 1); popw(bx);                                 /* pop bx */
            ii(0x15_37e5, 1); popw(bp);                                 /* pop bp */
            ii(0x15_37e6, 3); retfw(0x4); return;                       /* retf 0x4 */
        }
    }
}
