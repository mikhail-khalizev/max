using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7aab-cadc5a17")]
        public void Method_0000_7aab()
        {
            ii(0x7aab, 1);  push(bp);                                  /* push bp */
            ii(0x7aac, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x7aae, 3);  push(0x92);                                /* push 0x92 */
            ii(0x7ab1, 3);  push(memw[ss, bp + 8]);                    /* push word [bp+0x8] */
            ii(0x7ab4, 2);  push(0);                                   /* push 0x0 */
            ii(0x7ab6, 3);  push(memw[ss, bp + 6]);                    /* push word [bp+0x6] */
            ii(0x7ab9, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0x7abc, 3);  call(0x7a5a, -0x65);                       /* call 0x7a5a */
            ii(0x7abf, 1);  leave();                                   /* leave */
            ii(0x7ac0, 1);  ret();                                     /* ret */
        }
    }
}
