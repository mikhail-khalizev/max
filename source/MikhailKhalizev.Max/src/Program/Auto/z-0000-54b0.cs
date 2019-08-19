using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x54b0-2b40e281")]
        public void Method_0000_54b0()
        {
            ii(0x54b0, 1);    pushw(ds);                                /* push ds */
            ii(0x54b1, 2);    adc(memb_a16[ss, bp + si], cl);           /* adc [bp+si], cl */
            ii(0x54b3, 2);    mov(dx, cs);                              /* mov dx, cs */
            ii(0x54b5, 2);    sub(bx, dx);                              /* sub bx, dx */
            ii(0x54b7, 2);    sub(bx, ax);                              /* sub bx, ax */
            ii(0x54b9, 2);    add(ax, dx);                              /* add ax, dx */
            ii(0x54bb, 1);    cld();                                    /* cld */
            ii(0x54bc, 4);    xchg(memw_a16[ds, 0xa10], ax);            /* xchg [0xa10], ax */
            ii(0x54c0, 2);    xor(si, si);                              /* xor si, si */
            ii(0x54c2, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x54c4, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0x54c6, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x54c8, 1);    pushw(ss);                                /* push ss */
            ii(0x54c9, 1);    popw(ds);                                 /* pop ds */
            ii(0x54ca, 1);    pushw(bx);                                /* push bx */
            ii(0x54cb, 3);    callw(0x551e, 0x50);                      /* call 0x551e */
            ii(0x54ce, 1);    popw(cx);                                 /* pop cx */
            ii(0x54cf, 3);    shl(cx, 0x3);                             /* shl cx, 0x3 */
            ii(0x54d2, 1);    pushw(cs);                                /* push cs */
            ii(0x54d3, 1);    popw(es);                                 /* pop es */
            ii(0x54d4, 3);    mov(ax, 0xcccc);                          /* mov ax, 0xcccc */
            ii(0x54d7, 2);    mov(bx, di);                              /* mov bx, di */
            ii(0x54d9, 2);    rep_a16(() => stosw_a16());               /* rep stosw */
            ii(0x54db, 3);    add(bx, 0xf);                             /* add bx, 0xf */
            ii(0x54de, 3);    shr(bx, 0x4);                             /* shr bx, 0x4 */
            ii(0x54e1, 4);    add(bx, memw_a16[ds, 0x9b6]);             /* add bx, [0x9b6] */
            ii(0x54e5, 3);    mov(ax, memw_a16[ds, 0xcec]);             /* mov ax, [0xcec] */
            ii(0x54e8, 2);    sub(bx, ax);                              /* sub bx, ax */
            ii(0x54ea, 4);    mov(memw_a16[ds, 0x5a], bx);              /* mov [0x5a], bx */
            ii(0x54ee, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x54f0, 2);    mov(ah, 0x4a);                            /* mov ah, 0x4a */
            ii(0x54f2, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x54f4, 1);    popw(si);                                 /* pop si */
            ii(0x54f5, 1);    popw(di);                                 /* pop di */
            ii(0x54f6, 1);    popw(ax);                                 /* pop ax */
            ii(0x54f7, 1);    popw(sp);                                 /* pop sp */
            ii(0x54f8, 1);    popw(bp);                                 /* pop bp */
            ii(0x54f9, 1);    retw(); return;                           /* ret */
        }
    }
}
