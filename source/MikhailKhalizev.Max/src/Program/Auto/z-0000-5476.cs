using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("75ad495d-4fc0-423f-b492-6c6476b3ea06")]
        public void Method_0000_5476()
        {
            ii(0x5476, 1);    popw(bx);                                 /* pop bx */
            ii(0x5477, 3);    mov(cx, memw_a16[cs, bx]);                /* mov cx, [cs:bx] */
            ii(0x547a, 4);    mov(bx, memw_a16[ds, 0xafa]);             /* mov bx, [0xafa] */
            ii(0x547e, 1);    inc(bx);                                  /* inc bx */
            ii(0x547f, 1);    inc(bx);                                  /* inc bx */
            ii(0x5480, 4);    mov(memw_a16[ds, 0xafa], bx);             /* mov [0xafa], bx */
            ii(0x5484, 2);    popw(memw_a16[ds, bx]);                   /* pop word [bx] */
            ii(0x5486, 3);    pushw(0x3e8f);                            /* push 0x3e8f */
            ii(0x5489, 4);    if(jmpw_a16_far_ind(ds, 0xaf2)) return;   /* jmp far word [0xaf2] */
            ii(0x548d, 2);    if(jmpw_abs(cx)) return;                  /* jmp cx */
            ii(0x548f, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x5491, 1);    pushw(di);                                /* push di */
            ii(0x5492, 1);    pushw(si);                                /* push si */
            ii(0x5493, 4);    mov(di, memw_a16[ss, bx + 0x4]);          /* mov di, [ss:bx+0x4] */
            ii(0x5497, 5);    cmp(memw_a16[ds, 0xa12], 0);              /* cmp word [0xa12], 0x0 */
            ii(0x549c, 2);    if(jnzw(0x54fa, 0x5c)) goto l_0x54fa;     /* jnz 0x54fa */
            ii(0x549e, 3);    callw(0x5514, 0x73);                      /* call 0x5514 */
            ii(0x54a1, 2);    shr(ax, 0x1);                             /* shr ax, 1 */
            ii(0x54a3, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0x54a4, 3);    add(di, 0xf);                             /* add di, 0xf */
            ii(0x54a7, 3);    and(di, -0x10 /* 0xf0 */);                /* and di, 0xfff0 */
            ii(0x54aa, 2);    mov(ax, di);                              /* mov ax, di */
            ii(0x54ac, 3);    shr(ax, 0x4);                             /* shr ax, 0x4 */
            ii(0x54af, 4);    mov(bx, memw_a16[ds, 0xa10]);             /* mov bx, [0xa10] */
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
        l_0x54d2:
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
        l_0x54fa:
            ii(0x54fa, 4);    mov(cx, memw_a16[ds, 0xcec]);             /* mov cx, [0xcec] */
            ii(0x54fe, 1);    dec(cx);                                  /* dec cx */
            ii(0x54ff, 2);    mov(es, cx);                              /* mov es, cx */
            ii(0x5501, 5);    add(cx, memw_a16[es, 0x3]);               /* add cx, [es:0x3] */
            ii(0x5506, 1);    inc(cx);                                  /* inc cx */
            ii(0x5507, 2);    mov(ax, cs);                              /* mov ax, cs */
            ii(0x5509, 2);    sub(cx, ax);                              /* sub cx, ax */
            ii(0x550b, 3);    shl(cx, 0x4);                             /* shl cx, 0x4 */
            ii(0x550e, 2);    sub(cx, di);                              /* sub cx, di */
            ii(0x5510, 2);    shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x5512, 2);    jmpw(0x54d2, -0x42); goto l_0x54d2;       /* jmp 0x54d2 */
        }
    }
}
