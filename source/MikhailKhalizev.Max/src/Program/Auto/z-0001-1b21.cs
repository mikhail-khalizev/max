using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fe128bb3-5ac2-42cf-acd9-064532bdd329")]
        public void Method_0001_1b21()
        {
            ii(0x1_1b21, 1);  pushw(bp);                                /* push bp */
            ii(0x1_1b22, 2);  mov(bp, sp);                              /* mov bp, sp */
            ii(0x1_1b24, 5);  cmp(memb_a16[ds, 0x2f], 0x3);             /* cmp byte [0x2f], 0x3 */
            ii(0x1_1b29, 2);  if(jaew_func(0x1_1ad7, -0x54)) return;    /* jae 0x1ad7 */
            ii(0x1_1b2b, 1);  pushw(ds);                                /* push ds */
            ii(0x1_1b2c, 3);  callw(0x1_1b52, 0x23);                    /* call 0x1b52 */
            ii(0x1_1b2f, 2);  mov(ax, memw_a16[ds, bx]);                /* mov ax, [bx] */
            ii(0x1_1b31, 3);  mov(dx, memw_a16[ds, bx + 0x2]);          /* mov dx, [bx+0x2] */
        }
    }
}
