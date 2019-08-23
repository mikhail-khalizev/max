using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_d9f4-a2e659a")]
        public void Method_0019_d9f4()
        {
            ii(0x19_d9f4, 1); push(bp);                                 /* push bp */
            ii(0x19_d9f5, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_d9f7, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_d9fa, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x19_d9fd, 5); call_far_abs(0x80, 0x55dc);               /* call word 0x80:0x55dc */
            ii(0x19_da02, 1); pop(bx);                                  /* pop bx */
            ii(0x19_da03, 1); pop(bx);                                  /* pop bx */
            ii(0x19_da04, 4); sub(ax, memw[ds, 0x19ea]);                /* sub ax, [0x19ea] */
            ii(0x19_da08, 4); sbb(dx, memw[ds, 0x19ec]);                /* sbb dx, [0x19ec] */
            ii(0x19_da0c, 1); leave();                                  /* leave */
            ii(0x19_da0d, 3); ret(0x4);                                 /* ret 0x4 */
        }
    }
}
