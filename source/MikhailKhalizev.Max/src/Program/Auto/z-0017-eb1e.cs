using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_eb1e-de431d81")]
        public void Method_0017_eb1e()
        {
            ii(0x17_eb1e, 2); pop(memw[ds, bx]);                        /* pop word [bx] */
            ii(0x17_eb20, 3); mov(memw[ds, bx + 2], es);                /* mov [bx+0x2], es */
            ii(0x17_eb23, 3); mov(memw[ds, bx + 4], di);                /* mov [bx+0x4], di */
            ii(0x17_eb26, 3); mov(memw[ds, bx + 6], si);                /* mov [bx+0x6], si */
            ii(0x17_eb29, 3); mov(memw[ds, bx + 14], dx);               /* mov [bx+0xe], dx */
            ii(0x17_eb2c, 3); mov(memw[ds, bx + 16], cx);               /* mov [bx+0x10], cx */
            ii(0x17_eb2f, 3); pop(memw[ds, bx + 12]);                   /* pop word [bx+0xc] */
            ii(0x17_eb32, 3); mov(memw[ds, bx + 18], ax);               /* mov [bx+0x12], ax */
            ii(0x17_eb35, 1); pop(ds);                                  /* pop ds */
            ii(0x17_eb36, 1); pop(di);                                  /* pop di */
            ii(0x17_eb37, 1); pop(si);                                  /* pop si */
            ii(0x17_eb38, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x17_eb3b, 1); cmc();                                    /* cmc */
            ii(0x17_eb3c, 2); rcl(ax, 1);                               /* rcl ax, 1 */
            ii(0x17_eb3e, 1); pop(bp);                                  /* pop bp */
            ii(0x17_eb3f, 1); retf();                                   /* retf */
        }
    }
}
