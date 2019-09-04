using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5a9b-cadc5a17")]
        public void Method_0000_5a9b()
        {
            ii(0x5a9b, 1);    push(bp);                                 /* push bp */
            ii(0x5a9c, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x5a9e, 3);    push(0x92);                               /* push 0x92 */
            ii(0x5aa1, 3);    push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x5aa4, 2);    push(0);                                  /* push 0x0 */
            ii(0x5aa6, 3);    push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x5aa9, 3);    push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x5aac, 3);    call(0x5a4a, -0x65);                      /* call 0x5a4a */
            ii(0x5aaf, 1);    leave();                                  /* leave */
            ii(0x5ab0, 1);    ret();                                    /* ret */
        }
    }
}
