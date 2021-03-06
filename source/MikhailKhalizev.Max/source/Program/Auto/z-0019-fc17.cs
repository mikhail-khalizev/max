using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_fc17-5a8497bd")]
        public void Method_0019_fc17()
        {
            ii(0x19_fc17, 1);  push(bp);                               /* push bp */
            ii(0x19_fc18, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_fc1a, 1);  push(ds);                               /* push ds */
            ii(0x19_fc1b, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_fc1e, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_fc20, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x19_fc23, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x19_fc26, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_fc29, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_fc2c, 3);  call(0x19_fbdb, -0x54);                 /* call 0xfbdb */
            ii(0x19_fc2f, 1);  pop(ds);                                /* pop ds */
            ii(0x19_fc30, 1);  leave();                                /* leave */
            ii(0x19_fc31, 3);  retf(8);                                /* retf 0x8 */
        }
    }
}
