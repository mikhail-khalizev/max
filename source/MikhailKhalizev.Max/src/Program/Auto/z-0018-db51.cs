using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_db51-1712529")]
        public void Method_0018_db51()
        {
            ii(0x18_db51, 1); push(bp);                                 /* push bp */
            ii(0x18_db52, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_db54, 5); cmp(memb[ds, 0x2f], 3);                   /* cmp byte [0x2f], 0x3 */
            ii(0x18_db59, 2); if(jae_func(0x18_db07, -0x54)) return;    /* jae 0xdb07 */
            ii(0x18_db5b, 1); push(ds);                                 /* push ds */
            ii(0x18_db5c, 3); call(0x18_db82, 0x23);                    /* call 0xdb82 */
            ii(0x18_db5f, 2); mov(ax, memw[ds, bx]);                    /* mov ax, [bx] */
            ii(0x18_db61, 3); mov(dx, memw[ds, bx + 2]);                /* mov dx, [bx+0x2] */
            ii(0x18_db64, 1); pop(ds);                                  /* pop ds */
            ii(0x18_db65, 1); pop(bp);                                  /* pop bp */
            ii(0x18_db66, 1); ret();                                    /* ret */
        }
    }
}
