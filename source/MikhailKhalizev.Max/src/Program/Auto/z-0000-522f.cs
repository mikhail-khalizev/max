using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x522f-5629890a")]
        public void Method_0000_522f()
        {
            ii(0x522f, 1);    pushw(bp);                                /* push bp */
            ii(0x5230, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x5232, 3);    mov(ax, memw_a16[ds, 0x97c]);             /* mov ax, [0x97c] */
            ii(0x5235, 3);    cmp(memw_a16[ss, bp + 0x4], ax);          /* cmp [bp+0x4], ax */
            ii(0x5238, 2);    if(jbew(0x524f, 0x15)) goto l_0x524f;     /* jbe 0x524f */
            ii(0x523a, 2);    sub(al, al);                              /* sub al, al */
            ii(0x523c, 3);    mov(memb_a16[ds, 0x11e9], al);            /* mov [0x11e9], al */
            ii(0x523f, 3);    mov(memb_a16[ds, 0x11e8], al);            /* mov [0x11e8], al */
            ii(0x5242, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x5244, 3);    mov(memw_a16[ds, 0x11ea], ax);            /* mov [0x11ea], ax */
            ii(0x5247, 3);    mov(memw_a16[ds, 0x11e6], ax);            /* mov [0x11e6], ax */
            ii(0x524a, 3);    mov(memw_a16[ds, 0x11e4], ax);            /* mov [0x11e4], ax */
            ii(0x524d, 1);    leavew();                                 /* leave */
            ii(0x524e, 1);    retw(); return;                           /* ret */
        l_0x524f:
            ii(0x524f, 2);    pushw(0x8);                               /* push 0x8 */
            ii(0x5251, 3);    pushw(0x11e4);                            /* push 0x11e4 */
            ii(0x5254, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x5257, 2);    and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x5259, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x525b, 4);    add(ax, memw_a16[ds, 0x98e]);             /* add ax, [0x98e] */
            ii(0x525f, 4);    adc(dx, memw_a16[ds, 0x990]);             /* adc dx, [0x990] */
            ii(0x5263, 1);    pushw(dx);                                /* push dx */
            ii(0x5264, 1);    pushw(ax);                                /* push ax */
            ii(0x5265, 3);    callw(0x47dd, -0xa8b);                    /* call 0x47dd */
            ii(0x5268, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x526b, 1);    leavew();                                 /* leave */
            ii(0x526c, 1);    retw(); return;                           /* ret */
        }
    }
}
