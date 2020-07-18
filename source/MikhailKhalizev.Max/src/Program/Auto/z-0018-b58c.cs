using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_b58c-df90dad1")]
        public void Method_0018_b58c()
        {
            ii(0x18_b58c, 1);  pusha();                                /* pusha */
            ii(0x18_b58d, 3);  mov(ax, memw[ds, 0x9b4]);               /* mov ax, [0x9b4] */
            ii(0x18_b590, 1);  push(ax);                               /* push ax */
            ii(0x18_b591, 1);  push(ax);                               /* push ax */
            ii(0x18_b592, 2);  mov(ax, sp);                            /* mov ax, sp */
            ii(0x18_b594, 1);  push(ss);                               /* push ss */
            ii(0x18_b595, 1);  push(ax);                               /* push ax */
            ii(0x18_b596, 1);  push(ss);                               /* push ss */
            ii(0x18_b597, 1);  push(ax);                               /* push ax */
            ii(0x18_b598, 2);  push(0x10);                             /* push 0x10 */
            ii(0x18_b59a, 4);  call_far_ind(memw[ds, 0x22]);           /* call far word [0x22] */
            ii(0x18_b59e, 3);  add(sp, 0xe);                           /* add sp, 0xe */
            ii(0x18_b5a1, 1);  popa();                                 /* popa */
            ii(0x18_b5a2, 1);  ret();                                  /* ret */
        }
    }
}
