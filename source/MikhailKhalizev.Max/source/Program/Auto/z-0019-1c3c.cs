using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_1c3c-f56f96ee")]
        public void Method_0019_1c3c()
        {
            ii(0x19_1c3c, 1);  push(ds);                               /* push ds */
            ii(0x19_1c3d, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_1c40, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_1c42, 1);  push(ds);                               /* push ds */
            ii(0x19_1c43, 3);  push(0x392a);                           /* push 0x392a */
            ii(0x19_1c46, 3);  push(0xa8);                             /* push 0xa8 */
            ii(0x19_1c49, 3);  push(0x3b06);                           /* push 0x3b06 */
            ii(0x19_1c4c, 5);  call_far_abs(0x88, 0xa7f7);             /* call word 0x88:0xa7f7 */
            ii(0x19_1c51, 1);  pop(ds);                                /* pop ds */
            ii(0x19_1c52, 1);  retf();                                 /* retf */
        }
    }
}
