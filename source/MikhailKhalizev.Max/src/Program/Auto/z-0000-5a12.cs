using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5a12-d0e0220a")]
        public void Method_0000_5a12()
        {
            ii(0x5a12, 1);    push(bp);                                 /* push bp */
            ii(0x5a13, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x5a15, 3);    push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x5a18, 3);    call(0x59f4, -0x27);                      /* call 0x59f4 */
            ii(0x5a1b, 1);    pop(bx);                                  /* pop bx */
            ii(0x5a1c, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x5a1e, 1);    pop(bp);                                  /* pop bp */
            ii(0x5a1f, 1);    ret();                                    /* ret */
        }
    }
}
