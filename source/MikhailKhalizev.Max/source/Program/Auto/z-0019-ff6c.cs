using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_ff6c-b554c312")]
        public void Method_0019_ff6c()
        {
            ii(0x19_ff6c, 1);  push(bp);                               /* push bp */
            ii(0x19_ff6d, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_ff6f, 1);  push(ds);                               /* push ds */
            ii(0x19_ff70, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_ff73, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_ff75, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_ff78, 3);  push(memw[ss, bp + 4]);                 /* push word [bp+0x4] */
            ii(0x19_ff7b, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x19_ff7e, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_ff81, 5);  call_far_abs(0x80, 0x4544);             /* call word 0x80:0x4544 */
            ii(0x19_ff86, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_ff89, 1);  pop(ds);                                /* pop ds */
            ii(0x19_ff8a, 1);  leave();                                /* leave */
            ii(0x19_ff8b, 3);  ret(8);                                 /* ret 0x8 */
        }
    }
}
