using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7c4f-fabebabb")]
        public void Method_0000_7c4f()
        {
            ii(0x7c4f, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x7c51, 1);    pushw(di);                                /* push di */
            ii(0x7c52, 1);    pushw(si);                                /* push si */
            ii(0x7c53, 4);    mov(di, memw_a16[ss, bx + 0x4]);          /* mov di, [ss:bx+0x4] */
            ii(0x7c57, 5);    cmp(memw_a16[ds, 0xa12], 0);              /* cmp word [0xa12], 0x0 */
            ii(0x7c5c, 2);    if(jnzw(0x7cba, 0x5c)) goto l_0x7cba;     /* jnz 0x7cba */
            ii(0x7c5e, 3);    callw(0x7cd4, 0x73);                      /* call 0x7cd4 */
            ii(0x7c61, 2);    shr(ax, 0x1);                             /* shr ax, 1 */
            ii(0x7c63, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0x7c64, 3);    add(di, 0xf);                             /* add di, 0xf */
            ii(0x7c67, 3);    and(di, -0x10 /* 0xf0 */);                /* and di, 0xfff0 */
            ii(0x7c6a, 2);    mov(ax, di);                              /* mov ax, di */
            ii(0x7c6c, 3);    shr(ax, 0x4);                             /* shr ax, 0x4 */
            ii(0x7c6f, 4);    mov(bx, memw_a16[ds, 0xa10]);             /* mov bx, [0xa10] */
            ii(0x7c73, 2);    mov(dx, cs);                              /* mov dx, cs */
            ii(0x7c75, 2);    sub(bx, dx);                              /* sub bx, dx */
            ii(0x7c77, 2);    sub(bx, ax);                              /* sub bx, ax */
            ii(0x7c79, 2);    add(ax, dx);                              /* add ax, dx */
            ii(0x7c7b, 1);    cld();                                    /* cld */
            ii(0x7c7c, 4);    xchg(memw_a16[ds, 0xa10], ax);            /* xchg [0xa10], ax */
            ii(0x7c80, 2);    xor(si, si);                              /* xor si, si */
            ii(0x7c82, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x7c84, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0x7c86, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x7c88, 1);    pushw(ss);                                /* push ss */
            ii(0x7c89, 1);    popw(ds);                                 /* pop ds */
            ii(0x7c8a, 1);    pushw(bx);                                /* push bx */
            ii(0x7c8b, 3);    callw(0x7cde, 0x50);                      /* call 0x7cde */
            ii(0x7c8e, 1);    popw(cx);                                 /* pop cx */
            ii(0x7c8f, 3);    shl(cx, 0x3);                             /* shl cx, 0x3 */
        l_0x7c92:
            ii(0x7c92, 1);    pushw(cs);                                /* push cs */
            ii(0x7c93, 1);    popw(es);                                 /* pop es */
            ii(0x7c94, 3);    mov(ax, 0xcccc);                          /* mov ax, 0xcccc */
            ii(0x7c97, 2);    mov(bx, di);                              /* mov bx, di */
            ii(0x7c99, 2);    rep_a16(() => stosw_a16());               /* rep stosw */
            ii(0x7c9b, 3);    add(bx, 0xf);                             /* add bx, 0xf */
            ii(0x7c9e, 3);    shr(bx, 0x4);                             /* shr bx, 0x4 */
            ii(0x7ca1, 4);    add(bx, memw_a16[ds, 0x9b6]);             /* add bx, [0x9b6] */
            ii(0x7ca5, 3);    mov(ax, memw_a16[ds, 0xcec]);             /* mov ax, [0xcec] */
            ii(0x7ca8, 2);    sub(bx, ax);                              /* sub bx, ax */
            ii(0x7caa, 4);    mov(memw_a16[ds, 0x5a], bx);              /* mov [0x5a], bx */
            ii(0x7cae, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x7cb0, 2);    mov(ah, 0x4a);                            /* mov ah, 0x4a */
            ii(0x7cb2, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x7cb4, 1);    popw(si);                                 /* pop si */
            ii(0x7cb5, 1);    popw(di);                                 /* pop di */
            ii(0x7cb6, 1);    popw(ax);                                 /* pop ax */
            ii(0x7cb7, 1);    popw(sp);                                 /* pop sp */
            ii(0x7cb8, 1);    popw(bp);                                 /* pop bp */
            ii(0x7cb9, 1);    retw(); return;                           /* ret */
        l_0x7cba:
            ii(0x7cba, 4);    mov(cx, memw_a16[ds, 0xcec]);             /* mov cx, [0xcec] */
            ii(0x7cbe, 1);    dec(cx);                                  /* dec cx */
            ii(0x7cbf, 2);    mov(es, cx);                              /* mov es, cx */
            ii(0x7cc1, 5);    add(cx, memw_a16[es, 0x3]);               /* add cx, [es:0x3] */
            ii(0x7cc6, 1);    inc(cx);                                  /* inc cx */
            ii(0x7cc7, 2);    mov(ax, cs);                              /* mov ax, cs */
            ii(0x7cc9, 2);    sub(cx, ax);                              /* sub cx, ax */
            ii(0x7ccb, 3);    shl(cx, 0x4);                             /* shl cx, 0x4 */
            ii(0x7cce, 2);    sub(cx, di);                              /* sub cx, di */
            ii(0x7cd0, 2);    shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x7cd2, 2);    jmpw(0x7c92, -0x42); goto l_0x7c92;       /* jmp 0x7c92 */
        }
    }
}
