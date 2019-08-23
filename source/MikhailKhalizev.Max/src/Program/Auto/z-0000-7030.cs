using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7030-e5b41616")]
        public void Method_0000_7030()
        {
            ii(0x7030, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x7032, 3);    mov(di, memw_a16[ds, bx + 0x2]);          /* mov di, [bx+0x2] */
            ii(0x7035, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x7037, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x7039, 1);    pushw(ss);                                /* push ss */
            ii(0x703a, 1);    popw(es);                                 /* pop es */
            ii(0x703b, 3);    mov(si, 0x20);                            /* mov si, 0x20 */
            ii(0x703e, 1);    cld();                                    /* cld */
            ii(0x703f, 3);    mov(cx, 0x4e);                            /* mov cx, 0x4e */
            ii(0x7042, 1);    cli();                                    /* cli */
            ii(0x7043, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x7045, 1);    pushw(ss);                                /* push ss */
            ii(0x7046, 1);    popw(ds);                                 /* pop ds */
            ii(0x7047, 1);    retw();                                   /* ret */
        }
    }
}
