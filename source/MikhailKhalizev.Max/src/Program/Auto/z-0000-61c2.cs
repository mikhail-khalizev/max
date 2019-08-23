using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x61c2-d0e0220a")]
        public void Method_0000_61c2()
        {
            ii(0x61c2, 1);    push(bp);                                 /* push bp */
            ii(0x61c3, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x61c5, 3);    push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x61c8, 3);    call(0x61a4, -0x27);                      /* call 0x61a4 */
            ii(0x61cb, 1);    pop(bx);                                  /* pop bx */
            ii(0x61cc, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x61ce, 1);    pop(bp);                                  /* pop bp */
            ii(0x61cf, 1);    ret();                                    /* ret */
        }
    }
}
