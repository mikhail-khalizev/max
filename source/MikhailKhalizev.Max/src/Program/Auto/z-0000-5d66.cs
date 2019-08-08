using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c65285e6-1c6a-4af0-b788-33f94db310b3")]
        public void Method_0000_5d66()
        {
            ii(0x5d66, 1);    pushw(bp);                                /* push bp */
            ii(0x5d67, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x5d69, 2);    mov(dx, di);                              /* mov dx, di */
            ii(0x5d6b, 2);    mov(ax, ds);                              /* mov ax, ds */
            ii(0x5d6d, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x5d6f, 3);    mov(di, memw_a16[ss, bp + 0x4]);          /* mov di, [bp+0x4] */
            ii(0x5d72, 2);    mov(bx, di);                              /* mov bx, di */
            ii(0x5d74, 3);    mov(cx, memw_a16[ss, bp + 0x8]);          /* mov cx, [bp+0x8] */
            ii(0x5d77, 2);    if(jcxzw(0x5d8e, 0x15)) goto l_0x5d8e;    /* jcxz 0x5d8e */
            ii(0x5d79, 3);    mov(al, memb_a16[ss, bp + 0x6]);          /* mov al, [bp+0x6] */
            ii(0x5d7c, 2);    mov(ah, al);                              /* mov ah, al */
            ii(0x5d7e, 4);    test(di, 0x1);                            /* test di, 0x1 */
            ii(0x5d82, 2);    if(jzw(0x5d86, 0x2)) goto l_0x5d86;       /* jz 0x5d86 */
            ii(0x5d84, 1);    stosb_a16();                              /* stosb */
            ii(0x5d85, 1);    dec(cx);                                  /* dec cx */
        l_0x5d86:
            ii(0x5d86, 2);    shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x5d88, 2);    rep_a16(() => stosw_a16());               /* rep stosw */
            ii(0x5d8a, 2);    adc(cx, cx);                              /* adc cx, cx */
            ii(0x5d8c, 2);    rep_a16(() => stosb_a16());               /* rep stosb */
        l_0x5d8e:
            ii(0x5d8e, 2);    mov(di, dx);                              /* mov di, dx */
            ii(0x5d90, 1);    xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x5d91, 1);    popw(bp);                                 /* pop bp */
            ii(0x5d92, 1);    retw(); return;                           /* ret */
        }
    }
}
