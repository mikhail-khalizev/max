using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a417-c7a86ec6")]
        public void Method_0018_a417()
        {
            ii(0x18_a417, 3);  mov(cx, 0x3309);                        /* mov cx, 0x3309 */
            ii(0x18_a41a, 1);  push(ss);                               /* push ss */
            ii(0x18_a41b, 1);  push(bp);                               /* push bp */
            ii(0x18_a41c, 2);  call_abs(cx);                           /* call cx */
            ii(0x18_a41e, 1);  pop(cx);                                /* pop cx */
            ii(0x18_a41f, 1);  pop(cx);                                /* pop cx */
            ii(0x18_a420, 3);  jmp_func(0x18_a838, 0x415);             /* jmp 0xa838 */
        }
    }
}
