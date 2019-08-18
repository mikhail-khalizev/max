using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5020-4593437c")]
        public void Method_0000_5020()
        {
            ii(0x5020, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x5022, 3);    mov(di, memw_a16[ds, bx + 0x2]);          /* mov di, [bx+0x2] */
            ii(0x5025, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x5027, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x5029, 1);    pushw(ss);                                /* push ss */
            ii(0x502a, 1);    popw(es);                                 /* pop es */
            ii(0x502b, 3);    mov(si, 0x20);                            /* mov si, 0x20 */
            ii(0x502e, 1);    cld();                                    /* cld */
            ii(0x502f, 3);    mov(cx, 0x4e);                            /* mov cx, 0x4e */
            ii(0x5032, 1);    cli();                                    /* cli */
            ii(0x5033, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
        }
    }
}
