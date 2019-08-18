using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("aa5b166f-344e-4001-bf7a-05a892219c43")]
        public void Method_0018_b0af()
        {
            ii(0x18_b0af, 1); pushw(bp);                                /* push bp */
            ii(0x18_b0b0, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_b0b2, 3); mov(bp, memw_a16[ss, bp + 0x4]);          /* mov bp, [bp+0x4] */
            ii(0x18_b0b5, 4); mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x18_b0b9, 4); mov(memb_a16[ds, bx + 0x17], 0x49);       /* mov byte [bx+0x17], 0x49 */
            ii(0x18_b0bd, 3); callw(0x18_a893, -0x82d);                 /* call 0xa893 */
            ii(0x18_b0c0, 3); mov(al, memb_a16[ds, bx + 0x26]);         /* mov al, [bx+0x26] */
            ii(0x18_b0c3, 3); and(ax, 0x1);                             /* and ax, 0x1 */
            ii(0x18_b0c6, 1); popw(bp);                                 /* pop bp */
            ii(0x18_b0c7, 1); retw(); return;                           /* ret */
        }
    }
}
