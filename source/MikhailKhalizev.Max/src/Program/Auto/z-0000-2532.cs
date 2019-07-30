using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9c0c1f7e-5164-4565-a97a-e1c33c888ce8")]
        public void Method_0000_2532()
        {
            ii(0x2532, 1);    pushw(bp);                                /* push bp */
            ii(0x2533, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x2535, 3);    mov(al, memb_a16[ds, 0x9f5]);             /* mov al, [0x9f5] */
            ii(0x2538, 4);    or(al, memb_a16[ds, 0xe6a]);              /* or al, [0xe6a] */
            ii(0x253c, 2);    if(jnzw(0x257d, 0x3f)) goto l_0x257d;     /* jnz 0x257d */
            ii(0x253e, 3);    mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x2541, 3);    mov(ax, memw_a16[ds, 0xce6]);             /* mov ax, [0xce6] */
            ii(0x2544, 4);    sub(ax, memw_a16[ds, 0xcde]);             /* sub ax, [0xcde] */
            ii(0x2548, 2);    sub(ax, bx);                              /* sub ax, bx */
            ii(0x254a, 2);    if(jaw(0x257d, 0x31)) goto l_0x257d;      /* ja 0x257d */
            ii(0x254c, 2);    neg(ax);                                  /* neg ax */
            ii(0x254e, 3);    add(ax, 0xf);                             /* add ax, 0xf */
            ii(0x2551, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x2553, 2);    shr(ax, cl);                              /* shr ax, cl */
            ii(0x2555, 2);    mov(dx, ax);                              /* mov dx, ax */
            ii(0x2557, 4);    mov(cx, memw_a16[ds, 0xb10]);             /* mov cx, [0xb10] */
            ii(0x255b, 1);    inc(cx);                                  /* inc cx */
            ii(0x255c, 2);    add(ax, cx);                              /* add ax, cx */
            ii(0x255e, 4);    sub(ax, memw_a16[ds, 0xcec]);             /* sub ax, [0xcec] */
            ii(0x2562, 1);    xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x2563, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x2566, 2);    sub(cx, ax);                              /* sub cx, ax */
            ii(0x2568, 2);    shl(cx, 0x1);                             /* shl cx, 1 */
            ii(0x256a, 2);    shl(cx, 0x1);                             /* shl cx, 1 */
            ii(0x256c, 2);    shl(cx, 0x1);                             /* shl cx, 1 */
            ii(0x256e, 2);    shl(cx, 0x1);                             /* shl cx, 1 */
            ii(0x2570, 2);    mov(ah, 0x4a);                            /* mov ah, 0x4a */
            ii(0x2572, 4);    mov(es, memw_a16[ds, 0xcec]);             /* mov es, [0xcec] */
            ii(0x2576, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x2578, 3);    mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x257b, 2);    if(jaew(0x2582, 0x5)) goto l_0x2582;      /* jae 0x2582 */
        l_0x257d:
            ii(0x257d, 1);    popw(bp);                                 /* pop bp */
            ii(0x257e, 1);    sti();                                    /* sti */
            ii(0x257f, 1);    pushw(ss);                                /* push ss */
            ii(0x2580, 1);    popw(es);                                 /* pop es */
            ii(0x2581, 1);    retfw(); return;                          /* retf */
        l_0x2582:
            ii(0x2582, 4);    mov(memw_a16[ds, 0x5a], bx);              /* mov [0x5a], bx */
            ii(0x2586, 4);    add(memw_a16[ds, 0xb10], dx);             /* add [0xb10], dx */
            ii(0x258a, 2);    mov(ax, dx);                              /* mov ax, dx */
            ii(0x258c, 1);    pushw(cx);                                /* push cx */
            ii(0x258d, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x258f, 2);    shl(ax, cl);                              /* shl ax, cl */
            ii(0x2591, 1);    popw(cx);                                 /* pop cx */
            ii(0x2592, 4);    add(memw_a16[ds, 0xce6], ax);             /* add [0xce6], ax */
            ii(0x2596, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x2599, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x259b, 2);    add(ax, dx);                              /* add ax, dx */
            ii(0x259d, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x259f, 1);    pushw(si);                                /* push si */
            ii(0x25a0, 1);    pushw(di);                                /* push di */
            ii(0x25a1, 2);    mov(si, cx);                              /* mov si, cx */
            ii(0x25a3, 1);    dec(si);                                  /* dec si */
            ii(0x25a4, 1);    dec(si);                                  /* dec si */
            ii(0x25a5, 2);    mov(di, si);                              /* mov di, si */
            ii(0x25a7, 1);    std();                                    /* std */
            ii(0x25a8, 1);    cli();                                    /* cli */
            ii(0x25a9, 2);    shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x25ab, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x25ad, 1);    cld();                                    /* cld */
            ii(0x25ae, 1);    pushw(ss);                                /* push ss */
            ii(0x25af, 1);    popw(ds);                                 /* pop ds */
            ii(0x25b0, 3);    mov(dx, memw_a16[ss, bp + 0x4]);          /* mov dx, [bp+0x4] */
            ii(0x25b3, 3);    mov(memw_a16[ss, bp + 0x4], ax);          /* mov [bp+0x4], ax */
            ii(0x25b6, 4);    mov(memw_a16[es, 0x28b9], ax);            /* mov [es:0x28b9], ax */
            ii(0x25ba, 3);    mov(memw_a16[ds, 0x9f1], ax);             /* mov [0x9f1], ax */
            ii(0x25bd, 3);    mov(memw_a16[ds, 0x9b6], ax);             /* mov [0x9b6], ax */
            ii(0x25c0, 3);    mov(memw_a16[ds, 0x20], ax);              /* mov [0x20], ax */
            ii(0x25c3, 5);    cmp(memw_a16[ds, 0xa12], 0);              /* cmp word [0xa12], 0x0 */
            ii(0x25c8, 2);    if(jnzw(0x25d2, 0x8)) goto l_0x25d2;      /* jnz 0x25d2 */
            ii(0x25ca, 2);    mov(cx, ax);                              /* mov cx, ax */
            ii(0x25cc, 2);    sub(cx, dx);                              /* sub cx, dx */
            ii(0x25ce, 4);    add(memw_a16[ds, 0xa10], cx);             /* add [0xa10], cx */
        l_0x25d2:
            ii(0x25d2, 4);    mov(es, memw_a16[ds, 0xcec]);             /* mov es, [0xcec] */
            ii(0x25d6, 5);    cmp(memw_a16[es, 0xc], dx);               /* cmp [es:0xc], dx */
            ii(0x25db, 2);    if(jnzw(0x25e1, 0x4)) goto l_0x25e1;      /* jnz 0x25e1 */
            ii(0x25dd, 4);    mov(memw_a16[es, 0xc], ax);               /* mov [es:0xc], ax */
        l_0x25e1:
            ii(0x25e1, 2);    xor(bx, bx);                              /* xor bx, bx */
            ii(0x25e3, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0x25e5, 3);    mov(di, 0xf8c);                           /* mov di, 0xf8c */
            ii(0x25e8, 3);    mov(si, 0x1028);                          /* mov si, 0x1028 */
            ii(0x25eb, 3);    mov(cx, 0x27);                            /* mov cx, 0x27 */
        l_0x25ee:
            ii(0x25ee, 2);    cmp(memw_a16[ds, bx + di], dx);           /* cmp [bx+di], dx */
            ii(0x25f0, 2);    if(jnzw(0x25f4, 0x2)) goto l_0x25f4;      /* jnz 0x25f4 */
            ii(0x25f2, 2);    mov(memw_a16[ds, bx + di], ax);           /* mov [bx+di], ax */
        l_0x25f4:
            ii(0x25f4, 2);    cmp(memw_a16[ds, bx + si], dx);           /* cmp [bx+si], dx */
            ii(0x25f6, 2);    if(jnzw(0x25fa, 0x2)) goto l_0x25fa;      /* jnz 0x25fa */
            ii(0x25f8, 2);    mov(memw_a16[ds, bx + si], ax);           /* mov [bx+si], ax */
        l_0x25fa:
            ii(0x25fa, 4);    cmp(memw_a16[es, bx + 0x22], dx);         /* cmp [es:bx+0x22], dx */
            ii(0x25fe, 2);    if(jnzw(0x2604, 0x4)) goto l_0x2604;      /* jnz 0x2604 */
            ii(0x2600, 4);    mov(memw_a16[es, bx + 0x22], ax);         /* mov [es:bx+0x22], ax */
        l_0x2604:
            ii(0x2604, 3);    add(bx, 0x4);                             /* add bx, 0x4 */
            ii(0x2607, 2);    if(loopw_a16(0x25ee, -0x1b)) goto l_0x25ee; /* loop 0x25ee */
            ii(0x2609, 4);    mov(bl, memb_a16[ds, 0x34]);              /* mov bl, [0x34] */
            ii(0x260d, 3);    cmp(bl, 0x2e);                            /* cmp bl, 0x2e */
            ii(0x2610, 2);    if(jbew(0x2622, 0x10)) goto l_0x2622;     /* jbe 0x2622 */
            ii(0x2612, 2);    xor(bh, bh);                              /* xor bh, bh */
            ii(0x2614, 2);    shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x2616, 2);    shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x2618, 4);    cmp(memw_a16[es, bx + 0x2], dx);          /* cmp [es:bx+0x2], dx */
            ii(0x261c, 2);    if(jnzw(0x2622, 0x4)) goto l_0x2622;      /* jnz 0x2622 */
            ii(0x261e, 4);    mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
        l_0x2622:
            ii(0x2622, 1);    pushw(ax);                                /* push ax */
            ii(0x2623, 1);    popw(es);                                 /* pop es */
            ii(0x2624, 4);    mov(memw_a16[es, 0x12ca], ax);            /* mov [es:0x12ca], ax */
            ii(0x2628, 1);    popw(di);                                 /* pop di */
            ii(0x2629, 1);    popw(si);                                 /* pop si */
            ii(0x262a, 3);    jmpw(0x257d, -0xb0); goto l_0x257d;       /* jmp 0x257d */
        }
    }
}
