using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_36c2-b6dbbafd")]
        public void Method_0019_36c2()
        {
            ii(0x19_36c2, 1); pushw(bp);                                /* push bp */
            ii(0x19_36c3, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_36c5, 1); pushw(ds);                                /* push ds */
            ii(0x19_36c6, 1); pushw(bx);                                /* push bx */
            ii(0x19_36c7, 3); lds(bx, ss, bp + 0x6);                    /* lds bx, [bp+0x6] */
            ii(0x19_36ca, 2); mov(ax, memw_a16[ds, bx]);                /* mov ax, [bx] */
            ii(0x19_36cc, 3); mov(dx, memw_a16[ds, bx + 0x2]);          /* mov dx, [bx+0x2] */
            ii(0x19_36cf, 3); mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x19_36d2, 1); pushw(cs);                                /* push cs */
            ii(0x19_36d3, 3); callw(0x19_3808, 0x132);                  /* call 0x3808 */
            ii(0x19_36d6, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x19_36d8, 3); mov(memw_a16[ds, bx + 0x2], dx);          /* mov [bx+0x2], dx */
            ii(0x19_36db, 1); popw(bx);                                 /* pop bx */
            ii(0x19_36dc, 1); popw(ds);                                 /* pop ds */
            ii(0x19_36dd, 1); popw(bp);                                 /* pop bp */
            ii(0x19_36de, 3); retfw(0x6);                               /* retf 0x6 */
        }
    }
}
