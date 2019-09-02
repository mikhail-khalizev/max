using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5d66-8c65a241")]
        public void Method_0000_5d66()
        {
            ii(0x5d66, 1);    push(bp);                                 /* push bp */
            ii(0x5d67, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x5d69, 2);    mov(dx, di);                              /* mov dx, di */
            ii(0x5d6b, 2);    mov(ax, ds);                              /* mov ax, ds */
            ii(0x5d6d, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x5d6f, 3);    mov(di, memw[ss, bp + 4]);                /* mov di, [bp+0x4] */
            ii(0x5d72, 2);    mov(bx, di);                              /* mov bx, di */
            ii(0x5d74, 3);    mov(cx, memw[ss, bp + 8]);                /* mov cx, [bp+0x8] */
            ii(0x5d77, 2);    if(jcxz(0x5d8e, 0x15)) goto l_0x5d8e;     /* jcxz 0x5d8e */
            ii(0x5d79, 3);    mov(al, memb[ss, bp + 6]);                /* mov al, [bp+0x6] */
            ii(0x5d7c, 2);    mov(ah, al);                              /* mov ah, al */
            ii(0x5d7e, 4);    test(di, 1);                              /* test di, 0x1 */
            ii(0x5d82, 2);    if(jz(0x5d86, 2)) goto l_0x5d86;          /* jz 0x5d86 */
            ii(0x5d84, 1);    stosb();                                  /* stosb */
            ii(0x5d85, 1);    dec(cx);                                  /* dec cx */
        l_0x5d86:
            ii(0x5d86, 2);    shr(cx, 1);                               /* shr cx, 1 */
            ii(0x5d88, 2);    rep(() => stosw());                       /* rep stosw */
            ii(0x5d8a, 2);    adc(cx, cx);                              /* adc cx, cx */
            ii(0x5d8c, 2);    rep(() => stosb());                       /* rep stosb */
        l_0x5d8e:
            ii(0x5d8e, 2);    mov(di, dx);                              /* mov di, dx */
            ii(0x5d90, 1);    xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x5d91, 1);    pop(bp);                                  /* pop bp */
            ii(0x5d92, 1);    ret();                                    /* ret */
        }
    }
}
