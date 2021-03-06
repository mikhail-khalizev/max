using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_ff2f-cda6867b")]
        public void Method_0019_ff2f()
        {
            ii(0x19_ff2f, 1);  push(bp);                               /* push bp */
            ii(0x19_ff30, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_ff32, 1);  push(ds);                               /* push ds */
            ii(0x19_ff33, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_ff36, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_ff38, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_ff3b, 3);  push(memw[ss, bp + 4]);                 /* push word [bp+0x4] */
            ii(0x19_ff3e, 5);  call_far_abs(0x80, 0x452c);             /* call word 0x80:0x452c */
            ii(0x19_ff43, 1);  pop(bx);                                /* pop bx */
            ii(0x19_ff44, 1);  pop(bx);                                /* pop bx */
            ii(0x19_ff45, 1);  pop(ds);                                /* pop ds */
            ii(0x19_ff46, 1);  leave();                                /* leave */
            ii(0x19_ff47, 3);  ret(4);                                 /* ret 0x4 */
        }
    }
}
