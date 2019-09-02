using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_b0af-e64d0b8b")]
        public void Method_0018_b0af()
        {
            ii(0x18_b0af, 1); push(bp);                                 /* push bp */
            ii(0x18_b0b0, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_b0b2, 3); mov(bp, memw[ss, bp + 4]);                /* mov bp, [bp+0x4] */
            ii(0x18_b0b5, 4); mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x18_b0b9, 4); mov(memb[ds, bx + 0x17], 0x49);           /* mov byte [bx+0x17], 0x49 */
            ii(0x18_b0bd, 3); call(0x18_a893, -0x82d);                  /* call 0xa893 */
            ii(0x18_b0c0, 3); mov(al, memb[ds, bx + 0x26]);             /* mov al, [bx+0x26] */
            ii(0x18_b0c3, 3); and(ax, 1);                               /* and ax, 0x1 */
            ii(0x18_b0c6, 1); pop(bp);                                  /* pop bp */
            ii(0x18_b0c7, 1); ret();                                    /* ret */
        }
    }
}
