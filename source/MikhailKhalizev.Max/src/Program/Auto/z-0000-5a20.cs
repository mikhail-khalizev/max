using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5a20-48b060fa")]
        public void Method_0000_5a20()
        {
            ii(0x5a20, 1);    push(bp);                                 /* push bp */
            ii(0x5a21, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x5a23, 3);    push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x5a26, 3);    call(0x5a12, -0x17);                      /* call 0x5a12 */
            ii(0x5a29, 1);    pop(bx);                                  /* pop bx */
            ii(0x5a2a, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x5a2c, 1);    pop(bp);                                  /* pop bp */
            ii(0x5a2d, 1);    ret();                                    /* ret */
        }
    }
}
