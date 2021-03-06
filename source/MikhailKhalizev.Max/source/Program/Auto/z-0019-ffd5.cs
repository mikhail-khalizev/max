using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_ffd5-f8232716")]
        public void Method_0019_ffd5()
        {
            ii(0x19_ffd5, 1);  push(bp);                               /* push bp */
            ii(0x19_ffd6, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_ffd8, 1);  push(ds);                               /* push ds */
            ii(0x19_ffd9, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_ffdc, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_ffde, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_ffe1, 3);  push(memw[ss, bp + 4]);                 /* push word [bp+0x4] */
            ii(0x19_ffe4, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x19_ffe7, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_ffea, 5);  call_far_abs(0x80, 0x45c0);             /* call word 0x80:0x45c0 */
            ii(0x19_ffef, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_fff2, 1);  pop(ds);                                /* pop ds */
            ii(0x19_fff3, 1);  leave();                                /* leave */
            ii(0x19_fff4, 3);  ret(8);                                 /* ret 0x8 */
        }
    }
}
