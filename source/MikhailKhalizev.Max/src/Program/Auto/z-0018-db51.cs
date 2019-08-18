using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6fd9ff60-807b-435d-ae99-ebf7aa4e761b")]
        public void Method_0018_db51()
        {
            ii(0x18_db51, 1); pushw(bp);                                /* push bp */
            ii(0x18_db52, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_db54, 5); cmp(memb_a16[ds, 0x2f], 0x3);             /* cmp byte [0x2f], 0x3 */
            ii(0x18_db59, 2); if(jaew_func(0x18_db07, -0x54)) return;   /* jae 0xdb07 */
            ii(0x18_db5b, 1); pushw(ds);                                /* push ds */
            ii(0x18_db5c, 3); callw(0x18_db82, 0x23);                   /* call 0xdb82 */
            ii(0x18_db5f, 2); mov(ax, memw_a16[ds, bx]);                /* mov ax, [bx] */
            ii(0x18_db61, 3); mov(dx, memw_a16[ds, bx + 0x2]);          /* mov dx, [bx+0x2] */
            ii(0x18_db64, 1); popw(ds);                                 /* pop ds */
            ii(0x18_db65, 1); popw(bp);                                 /* pop bp */
            ii(0x18_db66, 1); retw(); return;                           /* ret */
        }
    }
}
