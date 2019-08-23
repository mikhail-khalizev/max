using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x61d0-48b060fa")]
        public void Method_0000_61d0()
        {
            ii(0x61d0, 1);    push(bp);                                 /* push bp */
            ii(0x61d1, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x61d3, 3);    push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x61d6, 3);    call(0x61c2, -0x17);                      /* call 0x61c2 */
            ii(0x61d9, 1);    pop(bx);                                  /* pop bx */
            ii(0x61da, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x61dc, 1);    pop(bp);                                  /* pop bp */
            ii(0x61dd, 1);    ret();                                    /* ret */
        }
    }
}
