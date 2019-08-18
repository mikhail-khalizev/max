using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e00ef369-a929-4c00-80f9-f542028e5e63")]
        public void Method_0000_638e()
        {
            ii(0x638e, 1);    pushw(bp);                                /* push bp */
            ii(0x638f, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x6391, 2);    mov(dx, di);                              /* mov dx, di */
            ii(0x6393, 2);    mov(bx, si);                              /* mov bx, si */
            ii(0x6395, 3);    mov(si, memw_a16[ss, bp + 0x6]);          /* mov si, [bp+0x6] */
            ii(0x6398, 2);    mov(di, si);                              /* mov di, si */
            ii(0x639a, 2);    mov(ax, ds);                              /* mov ax, ds */
            ii(0x639c, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x639e, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x63a0, 3);    mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x63a3, 2);    repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x63a5, 2);    not(cx);                                  /* not cx */
            ii(0x63a7, 3);    mov(di, memw_a16[ss, bp + 0x4]);          /* mov di, [bp+0x4] */
            ii(0x63aa, 2);    mov(ax, di);                              /* mov ax, di */
            ii(0x63ac, 2);    test(al, 0x1);                            /* test al, 0x1 */
            ii(0x63ae, 2);    if(jzw(0x63b2, 0x2)) goto l_0x63b2;       /* jz 0x63b2 */
            ii(0x63b0, 1);    movsb_a16();                              /* movsb */
            ii(0x63b1, 1);    dec(cx);                                  /* dec cx */
        l_0x63b2:
            ii(0x63b2, 2);    shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x63b4, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x63b6, 2);    adc(cx, cx);                              /* adc cx, cx */
            ii(0x63b8, 2);    rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x63ba, 2);    mov(si, bx);                              /* mov si, bx */
            ii(0x63bc, 2);    mov(di, dx);                              /* mov di, dx */
            ii(0x63be, 1);    popw(bp);                                 /* pop bp */
            ii(0x63bf, 1);    retw(); return;                           /* ret */
        }
    }
}
