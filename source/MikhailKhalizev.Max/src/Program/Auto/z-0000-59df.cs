using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x59df-5629890a")]
        public void Method_0000_59df()
        {
            ii(0x59df, 1);    pushw(bp);                                /* push bp */
            ii(0x59e0, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x59e2, 3);    mov(ax, memw_a16[ds, 0x97c]);             /* mov ax, [0x97c] */
            ii(0x59e5, 3);    cmp(memw_a16[ss, bp + 0x4], ax);          /* cmp [bp+0x4], ax */
            ii(0x59e8, 2);    if(jbew(0x59ff, 0x15)) goto l_0x59ff;     /* jbe 0x59ff */
            ii(0x59ea, 2);    sub(al, al);                              /* sub al, al */
            ii(0x59ec, 3);    mov(memb_a16[ds, 0x11e9], al);            /* mov [0x11e9], al */
            ii(0x59ef, 3);    mov(memb_a16[ds, 0x11e8], al);            /* mov [0x11e8], al */
            ii(0x59f2, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x59f4, 3);    mov(memw_a16[ds, 0x11ea], ax);            /* mov [0x11ea], ax */
            ii(0x59f7, 3);    mov(memw_a16[ds, 0x11e6], ax);            /* mov [0x11e6], ax */
            ii(0x59fa, 3);    mov(memw_a16[ds, 0x11e4], ax);            /* mov [0x11e4], ax */
            ii(0x59fd, 1);    leavew();                                 /* leave */
            ii(0x59fe, 1);    retw(); return;                           /* ret */
        l_0x59ff:
            ii(0x59ff, 2);    pushw(0x8);                               /* push 0x8 */
            ii(0x5a01, 3);    pushw(0x11e4);                            /* push 0x11e4 */
            ii(0x5a04, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x5a07, 2);    and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x5a09, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x5a0b, 4);    add(ax, memw_a16[ds, 0x98e]);             /* add ax, [0x98e] */
            ii(0x5a0f, 4);    adc(dx, memw_a16[ds, 0x990]);             /* adc dx, [0x990] */
            ii(0x5a13, 1);    pushw(dx);                                /* push dx */
            ii(0x5a14, 1);    pushw(ax);                                /* push ax */
            ii(0x5a15, 3);    callw(0x4f8d, -0xa8b);                    /* call 0x4f8d */
            ii(0x5a18, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x5a1b, 1);    leavew();                                 /* leave */
            ii(0x5a1c, 1);    retw(); return;                           /* ret */
        }
    }
}
