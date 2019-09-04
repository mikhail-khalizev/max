using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x524c-ca213ab3")]
        public void Method_0000_524c()
        {
            ii(0x524c, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x524e, 4);    push(memw[ds, 0xac2]);                    /* push word [0xac2] */
            ii(0x5252, 6);    mov(memw[ds, 0xac2], 0x14c4);             /* mov word [0xac2], 0x14c4 */
            ii(0x5258, 4);    push(memw[ss, bx + 2]);                   /* push word [ss:bx+0x2] */
            ii(0x525c, 3);    call(0x604d, 0xdee);                      /* call 0x604d */
            ii(0x525f, 1);    pop(cx);                                  /* pop cx */
            ii(0x5260, 4);    pop(memw[ds, 0xac2]);                     /* pop word [0xac2] */
            ii(0x5264, 1);    ret();                                    /* ret */
        }
    }
}
