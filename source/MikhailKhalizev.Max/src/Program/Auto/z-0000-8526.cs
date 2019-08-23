using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8526-8c65a241")]
        public void Method_0000_8526()
        {
            ii(0x8526, 1);    pushw(bp);                                /* push bp */
            ii(0x8527, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x8529, 2);    mov(dx, di);                              /* mov dx, di */
            ii(0x852b, 2);    mov(ax, ds);                              /* mov ax, ds */
            ii(0x852d, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x852f, 3);    mov(di, memw_a16[ss, bp + 0x4]);          /* mov di, [bp+0x4] */
            ii(0x8532, 2);    mov(bx, di);                              /* mov bx, di */
            ii(0x8534, 3);    mov(cx, memw_a16[ss, bp + 0x8]);          /* mov cx, [bp+0x8] */
            ii(0x8537, 2);    if(jcxzw(0x854e, 0x15)) goto l_0x854e;    /* jcxz 0x854e */
            ii(0x8539, 3);    mov(al, memb_a16[ss, bp + 0x6]);          /* mov al, [bp+0x6] */
            ii(0x853c, 2);    mov(ah, al);                              /* mov ah, al */
            ii(0x853e, 4);    test(di, 0x1);                            /* test di, 0x1 */
            ii(0x8542, 2);    if(jzw(0x8546, 0x2)) goto l_0x8546;       /* jz 0x8546 */
            ii(0x8544, 1);    stosb_a16();                              /* stosb */
            ii(0x8545, 1);    dec(cx);                                  /* dec cx */
        l_0x8546:
            ii(0x8546, 2);    shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x8548, 2);    rep_a16(() => stosw_a16());               /* rep stosw */
            ii(0x854a, 2);    adc(cx, cx);                              /* adc cx, cx */
            ii(0x854c, 2);    rep_a16(() => stosb_a16());               /* rep stosb */
        l_0x854e:
            ii(0x854e, 2);    mov(di, dx);                              /* mov di, dx */
            ii(0x8550, 1);    xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x8551, 1);    popw(bp);                                 /* pop bp */
            ii(0x8552, 1);    retw();                                   /* ret */
        }
    }
}
