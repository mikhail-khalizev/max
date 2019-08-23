using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7d56-39522c90")]
        public void Method_0000_7d56()
        {
            ii(0x7d56, 3);    call(0x66dc, -0x167d);                    /* call 0x66dc */
            ii(0x7d59, 5);    xchg(memw[cs, 0x1fbb], cx);               /* xchg [cs:0x1fbb], cx */
            ii(0x7d5e, 3);    mov(memw[ss, bp + 0x14], cx);             /* mov [bp+0x14], cx */
            ii(0x7d61, 2);    jmp(0x7d63, 0); goto l_0x7d63;            /* jmp 0x7d63 */
        l_0x7d63:
            ii(0x7d63, 1);    pop(ax);                                  /* pop ax */
            ii(0x7d64, 1);    pop(ss);                                  /* pop ss */
            ii(0x7d65, 1);    xchg(sp, ax);                             /* xchg sp, ax */
            ii(0x7d66, 1);    pop(ds);                                  /* pop ds */
            ii(0x7d67, 1);    pop(es);                                  /* pop es */
            ii(0x7d68, 2);    popad();                                  /* popad */
            ii(0x7d6a, 1);    popfw();                                  /* popfw */
        }
    }
}
