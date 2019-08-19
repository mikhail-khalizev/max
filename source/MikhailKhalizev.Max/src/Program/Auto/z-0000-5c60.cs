using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5c60-2b40e281")]
        public void Method_0000_5c60()
        {
            ii(0x5c60, 1);    pushw(ds);                                /* push ds */
            ii(0x5c61, 2);    adc(memb_a16[ss, bp + si], cl);           /* adc [bp+si], cl */
            ii(0x5c63, 2);    mov(dx, cs);                              /* mov dx, cs */
            ii(0x5c65, 2);    sub(bx, dx);                              /* sub bx, dx */
            ii(0x5c67, 2);    sub(bx, ax);                              /* sub bx, ax */
            ii(0x5c69, 2);    add(ax, dx);                              /* add ax, dx */
            ii(0x5c6b, 1);    cld();                                    /* cld */
            ii(0x5c6c, 4);    xchg(memw_a16[ds, 0xa10], ax);            /* xchg [0xa10], ax */
            ii(0x5c70, 2);    xor(si, si);                              /* xor si, si */
            ii(0x5c72, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x5c74, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0x5c76, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x5c78, 1);    pushw(ss);                                /* push ss */
            ii(0x5c79, 1);    popw(ds);                                 /* pop ds */
            ii(0x5c7a, 1);    pushw(bx);                                /* push bx */
            ii(0x5c7b, 3);    callw(0x5cce, 0x50);                      /* call 0x5cce */
            ii(0x5c7e, 1);    popw(cx);                                 /* pop cx */
            ii(0x5c7f, 3);    shl(cx, 0x3);                             /* shl cx, 0x3 */
            ii(0x5c82, 1);    pushw(cs);                                /* push cs */
            ii(0x5c83, 1);    popw(es);                                 /* pop es */
            ii(0x5c84, 3);    mov(ax, 0xcccc);                          /* mov ax, 0xcccc */
            ii(0x5c87, 2);    mov(bx, di);                              /* mov bx, di */
            ii(0x5c89, 2);    rep_a16(() => stosw_a16());               /* rep stosw */
            ii(0x5c8b, 3);    add(bx, 0xf);                             /* add bx, 0xf */
            ii(0x5c8e, 3);    shr(bx, 0x4);                             /* shr bx, 0x4 */
            ii(0x5c91, 4);    add(bx, memw_a16[ds, 0x9b6]);             /* add bx, [0x9b6] */
            ii(0x5c95, 3);    mov(ax, memw_a16[ds, 0xcec]);             /* mov ax, [0xcec] */
            ii(0x5c98, 2);    sub(bx, ax);                              /* sub bx, ax */
            ii(0x5c9a, 4);    mov(memw_a16[ds, 0x5a], bx);              /* mov [0x5a], bx */
            ii(0x5c9e, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x5ca0, 2);    mov(ah, 0x4a);                            /* mov ah, 0x4a */
            ii(0x5ca2, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x5ca4, 1);    popw(si);                                 /* pop si */
            ii(0x5ca5, 1);    popw(di);                                 /* pop di */
            ii(0x5ca6, 1);    popw(ax);                                 /* pop ax */
            ii(0x5ca7, 1);    popw(sp);                                 /* pop sp */
            ii(0x5ca8, 1);    popw(bp);                                 /* pop bp */
            ii(0x5ca9, 1);    retw(); return;                           /* ret */
        }
    }
}
