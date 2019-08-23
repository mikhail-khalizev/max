using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6516-8c65a241")]
        public void Method_0000_6516()
        {
            ii(0x6516, 1);    push(bp);                                 /* push bp */
            ii(0x6517, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x6519, 2);    mov(dx, di);                              /* mov dx, di */
            ii(0x651b, 2);    mov(ax, ds);                              /* mov ax, ds */
            ii(0x651d, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x651f, 3);    mov(di, memw[ss, bp + 0x4]);              /* mov di, [bp+0x4] */
            ii(0x6522, 2);    mov(bx, di);                              /* mov bx, di */
            ii(0x6524, 3);    mov(cx, memw[ss, bp + 0x8]);              /* mov cx, [bp+0x8] */
            ii(0x6527, 2);    if(jcxz(0x653e, 0x15)) goto l_0x653e;     /* jcxz 0x653e */
            ii(0x6529, 3);    mov(al, memb[ss, bp + 0x6]);              /* mov al, [bp+0x6] */
            ii(0x652c, 2);    mov(ah, al);                              /* mov ah, al */
            ii(0x652e, 4);    test(di, 0x1);                            /* test di, 0x1 */
            ii(0x6532, 2);    if(jz(0x6536, 0x2)) goto l_0x6536;        /* jz 0x6536 */
            ii(0x6534, 1);    stosb();                                  /* stosb */
            ii(0x6535, 1);    dec(cx);                                  /* dec cx */
        l_0x6536:
            ii(0x6536, 2);    shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x6538, 2);    rep(() => stosw());                       /* rep stosw */
            ii(0x653a, 2);    adc(cx, cx);                              /* adc cx, cx */
            ii(0x653c, 2);    rep(() => stosb());                       /* rep stosb */
        l_0x653e:
            ii(0x653e, 2);    mov(di, dx);                              /* mov di, dx */
            ii(0x6540, 1);    xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x6541, 1);    pop(bp);                                  /* pop bp */
            ii(0x6542, 1);    ret();                                    /* ret */
        }
    }
}
