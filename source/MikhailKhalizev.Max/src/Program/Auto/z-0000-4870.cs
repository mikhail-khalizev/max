using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("56db432d-2021-4386-bd29-592e59017494")]
        public void Method_0000_4870()
        {
            ii(0x4870, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x4872, 3);    mov(di, memw_a16[ds, bx + 0x2]);          /* mov di, [bx+0x2] */
            ii(0x4875, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x4877, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x4879, 1);    pushw(ss);                                /* push ss */
            ii(0x487a, 1);    popw(es);                                 /* pop es */
            ii(0x487b, 3);    mov(si, 0x20);                            /* mov si, 0x20 */
            ii(0x487e, 1);    cld();                                    /* cld */
            ii(0x487f, 3);    mov(cx, 0x4e);                            /* mov cx, 0x4e */
            ii(0x4882, 1);    cli();                                    /* cli */
            ii(0x4883, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
        }
    }
}
