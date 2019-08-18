using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5bde-47100b14")]
        public void Method_0000_5bde()
        {
            ii(0x5bde, 1);    pushw(bp);                                /* push bp */
            ii(0x5bdf, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x5be1, 2);    mov(dx, di);                              /* mov dx, di */
            ii(0x5be3, 2);    mov(bx, si);                              /* mov bx, si */
            ii(0x5be5, 3);    mov(si, memw_a16[ss, bp + 0x6]);          /* mov si, [bp+0x6] */
            ii(0x5be8, 2);    mov(di, si);                              /* mov di, si */
            ii(0x5bea, 2);    mov(ax, ds);                              /* mov ax, ds */
            ii(0x5bec, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x5bee, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x5bf0, 3);    mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x5bf3, 2);    repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x5bf5, 2);    not(cx);                                  /* not cx */
            ii(0x5bf7, 3);    mov(di, memw_a16[ss, bp + 0x4]);          /* mov di, [bp+0x4] */
            ii(0x5bfa, 2);    mov(ax, di);                              /* mov ax, di */
            ii(0x5bfc, 2);    test(al, 0x1);                            /* test al, 0x1 */
            ii(0x5bfe, 2);    if(jzw(0x5c02, 0x2)) goto l_0x5c02;       /* jz 0x5c02 */
            ii(0x5c00, 1);    movsb_a16();                              /* movsb */
            ii(0x5c01, 1);    dec(cx);                                  /* dec cx */
        l_0x5c02:
            ii(0x5c02, 2);    shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x5c04, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x5c06, 2);    adc(cx, cx);                              /* adc cx, cx */
            ii(0x5c08, 2);    rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x5c0a, 2);    mov(si, bx);                              /* mov si, bx */
            ii(0x5c0c, 2);    mov(di, dx);                              /* mov di, dx */
            ii(0x5c0e, 1);    popw(bp);                                 /* pop bp */
            ii(0x5c0f, 1);    retw(); return;                           /* ret */
        }
    }
}
