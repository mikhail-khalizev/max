using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1938dede-c825-4ea5-9253-b5339ea2b217")]
        public void Method_0019_d9f4()
        {
            ii(0x19_d9f4, 1); pushw(bp);                                /* push bp */
            ii(0x19_d9f5, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_d9f7, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_d9fa, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_d9fd, 5); callw_far_abs(0x80, 0x55dc);              /* call word 0x80:0x55dc */
            ii(0x19_da02, 1); popw(bx);                                 /* pop bx */
            ii(0x19_da03, 1); popw(bx);                                 /* pop bx */
            ii(0x19_da04, 4); sub(ax, memw_a16[ds, 0x19ea]);            /* sub ax, [0x19ea] */
            ii(0x19_da08, 4); sbb(dx, memw_a16[ds, 0x19ec]);            /* sbb dx, [0x19ec] */
            ii(0x19_da0c, 1); leavew();                                 /* leave */
            ii(0x19_da0d, 3); retw(0x4); return;                        /* ret 0x4 */
        }
    }
}
