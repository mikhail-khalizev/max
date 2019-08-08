using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("87beeb66-21b6-45b8-95ed-38f45b829ed8")]
        public void Method_0014_db51()
        {
            ii(0x14_db51, 1); pushw(bp);                                /* push bp */
            ii(0x14_db52, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x14_db54, 5); cmp(memb_a16[ds, 0x2f], 0x3);             /* cmp byte [0x2f], 0x3 */
            ii(0x14_db59, 2); if(jaew_func(0x14_db07, -0x54)) return;   /* jae 0xdb07 */
            ii(0x14_db5b, 1); pushw(ds);                                /* push ds */
            ii(0x14_db5c, 3); callw(0x14_db82, 0x23);                   /* call 0xdb82 */
            ii(0x14_db5f, 2); mov(ax, memw_a16[ds, bx]);                /* mov ax, [bx] */
            ii(0x14_db61, 3); mov(dx, memw_a16[ds, bx + 0x2]);          /* mov dx, [bx+0x2] */
            ii(0x14_db64, 1); popw(ds);                                 /* pop ds */
            ii(0x14_db65, 1); popw(bp);                                 /* pop bp */
            ii(0x14_db66, 1); retw(); return;                           /* ret */
        }
    }
}
