using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ae4f68b5-6d5e-43d4-8a21-b0f5d7a602d7")]
        public void Method_0000_a410()
        {
            ii(0xa410, 6);    mov(memd_a16[cs, 0x6e14], esi);           /* mov [cs:0x6e14], esi */
            ii(0xa416, 3);    xor(esi, esi);                            /* xor esi, esi */
            ii(0xa419, 6);    mov(memd_a16[cs, 0x6e18], edi);           /* mov [cs:0x6e18], edi */
            ii(0xa41f, 3);    xor(edi, edi);                            /* xor edi, edi */
            ii(0xa422, 6);    mov(memd_a16[cs, 0x6e1c], edx);           /* mov [cs:0x6e1c], edx */
            ii(0xa428, 3);    xor(edx, edx);                            /* xor edx, edx */
            ii(0xa42b, 3);    mov(di, 0xc20);                           /* mov di, 0xc20 */
            ii(0xa42e, 3);    mov(cx, 0x11);                            /* mov cx, 0x11 */
            ii(0xa431, 1);    pushw(ds);                                /* push ds */
            ii(0xa432, 1);    popw(es);                                 /* pop es */
            ii(0xa433, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0xa435, 2);    rep_a16(() => stosw_a16());               /* rep stosw */
            ii(0xa437, 6);    mov(memw_a16[ds, 0xc30], 0x40);           /* mov word [0xc30], 0x40 */
            ii(0xa43d, 2);    mov(ah, 0x48);                            /* mov ah, 0x48 */
            ii(0xa43f, 3);    mov(bx, 0x200);                           /* mov bx, 0x200 */
            ii(0xa442, 2);    @int(0x21);                              /* int 0x21 */
            ii(0xa444, 2);    if(jbw(0xa45f, 0x19)) goto l_0xa45f;      /* jb 0xa45f */
            ii(0xa446, 3);    mov(memw_a16[ds, 0xc34], ax);             /* mov [0xc34], ax */
            ii(0xa449, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0xa44b, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0xa44d, 3);    mov(cx, 0x1000);                          /* mov cx, 0x1000 */
            ii(0xa450, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0xa452, 2);    rep_a16(() => stosw_a16());               /* rep stosw */
            ii(0xa454, 2);    mov(ah, 0x48);                            /* mov ah, 0x48 */
            ii(0xa456, 5);    mov(bx, memw_a16[cs, 0x6d64]);            /* mov bx, [cs:0x6d64] */
            ii(0xa45b, 2);    @int(0x21);                              /* int 0x21 */
            ii(0xa45d, 2);    if(jaew(0xa462, 0x3)) goto l_0xa462;      /* jae 0xa462 */
        l_0xa45f:
            ii(0xa45f, 3);    jmpw_func(0xa74b, 0x2e9);                 /* jmp 0xa74b */
        l_0xa462:
            ii(0xa462, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0xa464, 3);    callw(0xab12, 0x6ab);                     /* call 0xab12 */
            ii(0xa467, 3);    mov(ax, memw_a16[ds, 0xf50]);             /* mov ax, [0xf50] */
            ii(0xa46a, 3);    add(ax, 0x2a);                            /* add ax, 0x2a */
            ii(0xa46d, 1);    pushw(cs);                                /* push cs */
            ii(0xa46e, 1);    popw(ds);                                 /* pop ds */
            ii(0xa46f, 3);    mov(memw_a16[ds, 0x17c2], ax);            /* mov [0x17c2], ax */
            ii(0xa472, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0xa475, 5);    callw_far_abs(0x35f, 0x6dc2);             /* call word 0x35f:0x6dc2 */
            ii(0xa47a, 2);    jbw_func(0xa3fd, -0x7f);                  /* jb 0xa3fd */
            ii(0xa47c, 1);    cld();                                    /* cld */
            ii(0xa47d, 7);    mov(memw_a16[ss, 0xac2], 0x71fc);         /* mov word [ss:0xac2], 0x71fc */
            ii(0xa484, 5);    mov(memw_a16[ss, 0xc32], ds);             /* mov [ss:0xc32], ds */
            ii(0xa489, 4);    mov(memw_a16[ds, 0x208e], ss);            /* mov [0x208e], ss */
            ii(0xa48d, 5);    mov(memw_a16[ss, 0xc2a], es);             /* mov [ss:0xc2a], es */
            ii(0xa492, 5);    mov(memw_a16[ss, 0x9b2], es);             /* mov [ss:0x9b2], es */
            ii(0xa497, 4);    mov(ax, memw_a16[es, 0x2c]);              /* mov ax, [es:0x2c] */
            ii(0xa49b, 4);    mov(memw_a16[ss, 0xc2c], ax);             /* mov [ss:0xc2c], ax */
            ii(0xa49f, 5);    mov(memw_a16[ss, 0x8], ds);               /* mov [ss:0x8], ds */
            ii(0xa4a4, 4);    mov(memw_a16[ds, 0x17c0], cs);            /* mov [0x17c0], cs */
            ii(0xa4a8, 4);    mov(memw_a16[ds, 0x17c4], ss);            /* mov [0x17c4], ss */
            ii(0xa4ac, 3);    sub(sp, 0x8);                             /* sub sp, 0x8 */
            ii(0xa4af, 2);    mov(bx, ss);                              /* mov bx, ss */
            ii(0xa4b1, 2);    mov(di, sp);                              /* mov di, sp */
            ii(0xa4b3, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0xa4b5, 3);    mov(ax, 0xb);                             /* mov ax, 0xb */
            ii(0xa4b8, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa4ba, 5);    and(memb_a16[es, di + 0x6], -0x41 /* 0xbf */); /* and byte [es:di+0x6], 0xbf */
            ii(0xa4bf, 3);    mov(ax, 0xc);                             /* mov ax, 0xc */
            ii(0xa4c2, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa4c4, 2);    mov(bx, ds);                              /* mov bx, ds */
            ii(0xa4c6, 2);    mov(di, sp);                              /* mov di, sp */
            ii(0xa4c8, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0xa4ca, 3);    mov(ax, 0xb);                             /* mov ax, 0xb */
            ii(0xa4cd, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa4cf, 5);    and(memb_a16[es, di + 0x6], -0x41 /* 0xbf */); /* and byte [es:di+0x6], 0xbf */
            ii(0xa4d4, 3);    mov(ax, 0xc);                             /* mov ax, 0xc */
            ii(0xa4d7, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa4d9, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0xa4dc, 3);    mov(si, 0x6d3d);                          /* mov si, 0x6d3d */
            ii(0xa4df, 3);    mov(ax, 0xa00);                           /* mov ax, 0xa00 */
            ii(0xa4e2, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa4e4, 3);    mov(ax, 0x305);                           /* mov ax, 0x305 */
            ii(0xa4e7, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa4e9, 4);    mov(memw_a16[ds, 0x6d4e], cx);            /* mov [0x6d4e], cx */
            ii(0xa4ed, 4);    mov(memw_a16[ds, 0x6d50], bx);            /* mov [0x6d50], bx */
            ii(0xa4f1, 5);    mov(memd_a16[ds, 0x6d54], edi);           /* mov [0x6d54], edi */
            ii(0xa4f6, 4);    mov(memw_a16[ds, 0x6d58], si);            /* mov [0x6d58], si */
            ii(0xa4fa, 3);    mov(memw_a16[ds, 0x6d52], ax);            /* mov [0x6d52], ax */
            ii(0xa4fd, 3);    mov(ax, 0x306);                           /* mov ax, 0x306 */
            ii(0xa500, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa502, 2);    if(jaew(0xa507, 0x3)) goto l_0xa507;      /* jae 0xa507 */
            ii(0xa504, 3);    jmpw_func(0xa74b, 0x244);                 /* jmp 0xa74b */
        l_0xa507:
            ii(0xa507, 4);    mov(memw_a16[ds, 0x6d5a], cx);            /* mov [0x6d5a], cx */
            ii(0xa50b, 4);    mov(memw_a16[ds, 0x6d5c], bx);            /* mov [0x6d5c], bx */
            ii(0xa50f, 5);    mov(memd_a16[ds, 0x6d5e], edi);           /* mov [0x6d5e], edi */
            ii(0xa514, 4);    mov(memw_a16[ds, 0x6d62], si);            /* mov [0x6d62], si */
            ii(0xa518, 2);    mov(bl, 0x21);                            /* mov bl, 0x21 */
            ii(0xa51a, 3);    mov(ax, 0x204);                           /* mov ax, 0x204 */
            ii(0xa51d, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa51f, 5);    mov(memd_a16[ds, 0x6d66], edx);           /* mov [0x6d66], edx */
            ii(0xa524, 4);    mov(memw_a16[ds, 0x6d6a], cx);            /* mov [0x6d6a], cx */
            ii(0xa528, 5);    mov(memw_a16[ss, 0xc42], cx);             /* mov [ss:0xc42], cx */
            ii(0xa52d, 1);    pushw(ss);                                /* push ss */
            ii(0xa52e, 1);    popw(ds);                                 /* pop ds */
            ii(0xa52f, 1);    pushw(ds);                                /* push ds */
            ii(0xa530, 1);    popw(es);                                 /* pop es */
            ii(0xa531, 3);    mov(di, 0xc0);                            /* mov di, 0xc0 */
            ii(0xa534, 1);    pushw(cs);                                /* push cs */
            ii(0xa535, 3);    callw(0xabf6, 0x6be);                     /* call 0xabf6 */
            ii(0xa538, 4);    mov(memw_a16[ds, 0xc26], cs);             /* mov [0xc26], cs */
            ii(0xa53c, 4);    mov(memw_a16[ds, 0xaf8], cs);             /* mov [0xaf8], cs */
            ii(0xa540, 4);    mov(memw_a16[ds, 0xc28], ss);             /* mov [0xc28], ss */
            ii(0xa544, 1);    sti();                                    /* sti */
            ii(0xa545, 4);    mov(memw_a16[ds, 0x2c], ss);              /* mov [0x2c], ss */
            ii(0xa549, 4);    mov(memw_a16[ds, 0x18], cs);              /* mov [0x18], cs */
            ii(0xa54d, 4);    mov(memw_a16[ds, 0x1c], cs);              /* mov [0x1c], cs */
            ii(0xa551, 6);    mov(memw_a16[ds, 0x22], 0x7364);          /* mov word [0x22], 0x7364 */
            ii(0xa557, 4);    mov(memw_a16[ds, 0x24], cs);              /* mov [0x24], cs */
            ii(0xa55b, 4);    mov(memw_a16[ds, 0xc], ss);               /* mov [0xc], ss */
            ii(0xa55f, 4);    mov(memw_a16[ds, 0x3c], ss);              /* mov [0x3c], ss */
            ii(0xa563, 4);    mov(memw_a16[ds, 0x998], ss);             /* mov [0x998], ss */
            ii(0xa567, 4);    mov(memw_a16[ds, 0x44], ss);              /* mov [0x44], ss */
            ii(0xa56b, 3);    mov(ax, 0x203);                           /* mov ax, 0x203 */
            ii(0xa56e, 2);    mov(bl, 0x11);                            /* mov bl, 0x11 */
            ii(0xa570, 2);    mov(cx, cs);                              /* mov cx, cs */
            ii(0xa572, 3);    mov(dx, 0x6d6c);                          /* mov dx, 0x6d6c */
        l_0xa575:
            ii(0xa575, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa577, 3);    add(dx, 0x4);                             /* add dx, 0x4 */
            ii(0xa57a, 2);    dec(bl);                                  /* dec bl */
            ii(0xa57c, 3);    cmp(bl, 0x6);                             /* cmp bl, 0x6 */
            ii(0xa57f, 2);    if(jaew(0xa575, -0xc)) goto l_0xa575;     /* jae 0xa575 */
            ii(0xa581, 2);    mov(bl, 0xd);                             /* mov bl, 0xd */
            ii(0xa583, 3);    mov(dx, 0x6abb);                          /* mov dx, 0x6abb */
            ii(0xa586, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa588, 3);    mov(dx, 0x71f4);                          /* mov dx, 0x71f4 */
            ii(0xa58b, 2);    mov(cx, cs);                              /* mov cx, cs */
            ii(0xa58d, 2);    mov(bl, 0x3);                             /* mov bl, 0x3 */
            ii(0xa58f, 3);    mov(ax, 0x205);                           /* mov ax, 0x205 */
            ii(0xa592, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa594, 3);    mov(dx, 0x732b);                          /* mov dx, 0x732b */
            ii(0xa597, 2);    mov(bl, 0x1);                             /* mov bl, 0x1 */
            ii(0xa599, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa59b, 3);    mov(dx, 0x71f8);                          /* mov dx, 0x71f8 */
            ii(0xa59e, 2);    mov(bl, 0);                               /* mov bl, 0x0 */
            ii(0xa5a0, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa5a2, 3);    mov(dx, 0x7584);                          /* mov dx, 0x7584 */
            ii(0xa5a5, 2);    mov(bl, 0x23);                            /* mov bl, 0x23 */
            ii(0xa5a7, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa5a9, 6);    cmp(memb_a16[cs, 0x6d4b], 0);             /* cmp byte [cs:0x6d4b], 0x0 */
            ii(0xa5af, 2);    if(jnzw(0xa5b6, 0x5)) goto l_0xa5b6;      /* jnz 0xa5b6 */
            ii(0xa5b1, 3);    mov(ax, 0x1682);                          /* mov ax, 0x1682 */
            ii(0xa5b4, 2);    @int(0x2f);                              /* int 0x2f */
        l_0xa5b6:
            ii(0xa5b6, 3);    mov(ax, 0x3);                             /* mov ax, 0x3 */
            ii(0xa5b9, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa5bb, 3);    mov(memw_a16[ds, 0xc48], ax);             /* mov [0xc48], ax */
            ii(0xa5be, 2);    xor(cx, cx);                              /* xor cx, cx */
        l_0xa5c0:
            ii(0xa5c0, 1);    inc(cx);                                  /* inc cx */
            ii(0xa5c1, 2);    shr(ax, 0x1);                             /* shr ax, 1 */
            ii(0xa5c3, 2);    if(jaew(0xa5c0, -0x5)) goto l_0xa5c0;     /* jae 0xa5c0 */
            ii(0xa5c5, 4);    mov(memw_a16[ds, 0xc46], cx);             /* mov [0xc46], cx */
            ii(0xa5c9, 3);    mov(cx, 0x6);                             /* mov cx, 0x6 */
            ii(0xa5cc, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0xa5ce, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa5d0, 2);    if(jaew(0xa5d5, 0x3)) goto l_0xa5d5;      /* jae 0xa5d5 */
        l_0xa5d2:
            ii(0xa5d2, 3);    jmpw_func(0xa74b, 0x176);                 /* jmp 0xa74b */
        l_0xa5d5:
            ii(0xa5d5, 3);    mov(memw_a16[ds, 0xc2e], ax);             /* mov [0xc2e], ax */
            ii(0xa5d8, 1);    xchg(bx, ax);                             /* xchg bx, ax */
            ii(0xa5d9, 3);    mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0xa5dc, 3);    mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0xa5df, 2);    mov(dx, cx);                              /* mov dx, cx */
            ii(0xa5e1, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa5e3, 2);    if(jbw(0xa5d2, -0x13)) goto l_0xa5d2;     /* jb 0xa5d2 */
            ii(0xa5e5, 4);    add(bx, memw_a16[ds, 0xc48]);             /* add bx, [0xc48] */
            ii(0xa5e9, 4);    mov(memw_a16[ds, 0xc38], bx);             /* mov [0xc38], bx */
            ii(0xa5ed, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0xa5ef, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa5f1, 2);    if(jbw(0xa5d2, -0x21)) goto l_0xa5d2;     /* jb 0xa5d2 */
            ii(0xa5f3, 4);    add(bx, memw_a16[ds, 0xc48]);             /* add bx, [0xc48] */
            ii(0xa5f7, 4);    mov(memw_a16[ds, 0xc3e], bx);             /* mov [0xc3e], bx */
            ii(0xa5fb, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa5fd, 2);    if(jbw(0xa5d2, -0x2d)) goto l_0xa5d2;     /* jb 0xa5d2 */
            ii(0xa5ff, 3);    sub(sp, 0x8);                             /* sub sp, 0x8 */
            ii(0xa602, 1);    pushw(ss);                                /* push ss */
            ii(0xa603, 1);    popw(es);                                 /* pop es */
            ii(0xa604, 2);    mov(di, sp);                              /* mov di, sp */
            ii(0xa606, 4);    add(bx, memw_a16[ds, 0xc48]);             /* add bx, [0xc48] */
            ii(0xa60a, 4);    mov(memw_a16[ds, 0xc3c], bx);             /* mov [0xc3c], bx */
            ii(0xa60e, 4);    mov(memw_a16[ds, 0xaf4], bx);             /* mov [0xaf4], bx */
            ii(0xa612, 4);    mov(memw_a16[ds, 0xa00], bx);             /* mov [0xa00], bx */
            ii(0xa616, 4);    mov(memw_a16[ds, 0xa08], bx);             /* mov [0xa08], bx */
            ii(0xa61a, 3);    mov(ax, 0xb);                             /* mov ax, 0xb */
            ii(0xa61d, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa61f, 3);    callw(0x5514, -0x510e);                   /* call 0x5514 */
            ii(0xa622, 1);    dec(ax);                                  /* dec ax */
            ii(0xa623, 1);    stosw_a16();                              /* stosw */
            ii(0xa624, 3);    mov(ax, memw_a16[ds, 0xa10]);             /* mov ax, [0xa10] */
            ii(0xa627, 3);    mov(cx, 0x10);                            /* mov cx, 0x10 */
            ii(0xa62a, 2);    mul(cx);                                  /* mul cx */
            ii(0xa62c, 1);    stosw_a16();                              /* stosw */
            ii(0xa62d, 1);    xchg(dx, ax);                             /* xchg dx, ax */
            ii(0xa62e, 1);    stosb_a16();                              /* stosb */
            ii(0xa62f, 2);    mov(di, sp);                              /* mov di, sp */
            ii(0xa631, 3);    mov(ax, 0xc);                             /* mov ax, 0xc */
            ii(0xa634, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa636, 2);    mov(ds, bx);                              /* mov ds, bx */
            ii(0xa638, 4);    mov(memw_a16[ds, 0x5680], ss);            /* mov [0x5680], ss */
            ii(0xa63c, 2);    mov(ax, cs);                              /* mov ax, cs */
            ii(0xa63e, 3);    mov(memw_a16[ds, 0x3ea8], ax);            /* mov [0x3ea8], ax */
            ii(0xa641, 4);    mov(memw_a16[ds, 0x403], bx);             /* mov [0x403], bx */
            ii(0xa645, 6);    mov(memw_a16[ds, 0x401], 0x5692);         /* mov word [0x401], 0x5692 */
            ii(0xa64b, 5);    mov(memb_a16[ds, 0x400], 0xea);           /* mov byte [0x400], 0xea */
            ii(0xa650, 3);    mov(si, 0x7a0);                           /* mov si, 0x7a0 */
        l_0xa653:
            ii(0xa653, 3);    mov(memw_a16[ds, si + 0x2], bx);          /* mov [si+0x2], bx */
            ii(0xa656, 3);    mov(memw_a16[ds, si + 0x6], bx);          /* mov [si+0x6], bx */
            ii(0xa659, 3);    add(si, 0x8);                             /* add si, 0x8 */
            ii(0xa65c, 3);    cmp(memw_a16[ds, si], 0);                 /* cmp word [si], 0x0 */
            ii(0xa65f, 2);    if(jnzw(0xa653, -0xe)) goto l_0xa653;     /* jnz 0xa653 */
            ii(0xa661, 3);    lar(cx, ax);                              /* lar cx, ax */
            ii(0xa664, 3);    shr(cx, 0x8);                             /* shr cx, 0x8 */
            ii(0xa667, 3);    mov(ax, 0x9);                             /* mov ax, 0x9 */
            ii(0xa66a, 1);    pushw(bx);                                /* push bx */
            ii(0xa66b, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa66d, 2);    mov(cx, ds);                              /* mov cx, ds */
            ii(0xa66f, 3);    mov(bx, 0x10);                            /* mov bx, 0x10 */
            ii(0xa672, 3);    mov(ax, 0x205);                           /* mov ax, 0x205 */
        l_0xa675:
            ii(0xa675, 2);    mov(dx, bx);                              /* mov dx, bx */
            ii(0xa677, 3);    shl(dx, 0x2);                             /* shl dx, 0x2 */
            ii(0xa67a, 4);    add(dx, 0);                               /* add dx, 0x0 */
            ii(0xa67e, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa680, 2);    if(jaew(0xa685, 0x3)) goto l_0xa685;      /* jae 0xa685 */
        l_0xa682:
            ii(0xa682, 3);    jmpw_func(0xa74b, 0xc6);                  /* jmp 0xa74b */
        l_0xa685:
            ii(0xa685, 2);    inc(bl);                                  /* inc bl */
            ii(0xa687, 3);    cmp(bl, 0x1b);                            /* cmp bl, 0x1b */
            ii(0xa68a, 2);    if(jzw(0xa685, -0x7)) goto l_0xa685;      /* jz 0xa685 */
            ii(0xa68c, 3);    cmp(bl, 0x1c);                            /* cmp bl, 0x1c */
            ii(0xa68f, 2);    if(jzw(0xa685, -0xc)) goto l_0xa685;      /* jz 0xa685 */
            ii(0xa691, 3);    cmp(bl, 0x23);                            /* cmp bl, 0x23 */
            ii(0xa694, 2);    if(jzw(0xa685, -0x11)) goto l_0xa685;     /* jz 0xa685 */
            ii(0xa696, 3);    cmp(bl, 0x24);                            /* cmp bl, 0x24 */
            ii(0xa699, 2);    if(jzw(0xa685, -0x16)) goto l_0xa685;     /* jz 0xa685 */
            ii(0xa69b, 3);    cmp(bl, 0x2f);                            /* cmp bl, 0x2f */
            ii(0xa69e, 2);    if(jzw(0xa685, -0x1b)) goto l_0xa685;     /* jz 0xa685 */
            ii(0xa6a0, 3);    cmp(bl, 0x16);                            /* cmp bl, 0x16 */
            ii(0xa6a3, 2);    if(jzw(0xa685, -0x20)) goto l_0xa685;     /* jz 0xa685 */
            ii(0xa6a5, 3);    cmp(bl, 0x2e);                            /* cmp bl, 0x2e */
            ii(0xa6a8, 2);    if(jbew(0xa675, -0x35)) goto l_0xa675;    /* jbe 0xa675 */
            ii(0xa6aa, 3);    mov(dx, 0xc9e);                           /* mov dx, 0xc9e */
            ii(0xa6ad, 2);    mov(bl, 0x21);                            /* mov bl, 0x21 */
            ii(0xa6af, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa6b1, 2);    if(jbw(0xa682, -0x31)) goto l_0xa682;     /* jb 0xa682 */
            ii(0xa6b3, 3);    mov(dx, 0x1a83);                          /* mov dx, 0x1a83 */
            ii(0xa6b6, 2);    mov(bl, 0x10);                            /* mov bl, 0x10 */
            ii(0xa6b8, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa6ba, 3);    mov(dx, 0x556);                           /* mov dx, 0x556 */
            ii(0xa6bd, 2);    mov(bl, 0x75);                            /* mov bl, 0x75 */
            ii(0xa6bf, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa6c1, 1);    pushw(ss);                                /* push ss */
            ii(0xa6c2, 1);    popw(ds);                                 /* pop ds */
            ii(0xa6c3, 3);    mov(ax, 0x1fff);                          /* mov ax, 0x1fff */
            ii(0xa6c6, 1);    stosw_a16();                              /* stosw */
            ii(0xa6c7, 3);    mov(ax, memw_a16[ds, 0xc34]);             /* mov ax, [0xc34] */
            ii(0xa6ca, 3);    mov(cx, 0x10);                            /* mov cx, 0x10 */
            ii(0xa6cd, 2);    mul(cx);                                  /* mul cx */
            ii(0xa6cf, 1);    stosw_a16();                              /* stosw */
            ii(0xa6d0, 1);    xchg(dx, ax);                             /* xchg dx, ax */
            ii(0xa6d1, 1);    stosb_a16();                              /* stosb */
            ii(0xa6d2, 1);    popw(bx);                                 /* pop bx */
            ii(0xa6d3, 4);    add(bx, memw_a16[ds, 0xc48]);             /* add bx, [0xc48] */
            ii(0xa6d7, 4);    mov(memw_a16[ds, 0xc34], bx);             /* mov [0xc34], bx */
            ii(0xa6db, 4);    mov(memw_a16[ds, 0xaa2], bx);             /* mov [0xaa2], bx */
            ii(0xa6df, 2);    mov(di, sp);                              /* mov di, sp */
            ii(0xa6e1, 3);    mov(ax, 0xc);                             /* mov ax, 0xc */
            ii(0xa6e4, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa6e6, 4);    add(bx, memw_a16[ds, 0xc48]);             /* add bx, [0xc48] */
            ii(0xa6ea, 4);    mov(memw_a16[ds, 0xa9c], bx);             /* mov [0xa9c], bx */
            ii(0xa6ee, 3);    mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0xa6f1, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0xa6f3, 3);    mov(dx, 0xffff);                          /* mov dx, 0xffff */
            ii(0xa6f6, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa6f8, 1);    inc(ax);                                  /* inc ax */
            ii(0xa6f9, 2);    mov(cx, cs);                              /* mov cx, cs */
            ii(0xa6fb, 3);    lar(cx, cx);                              /* lar cx, cx */
            ii(0xa6fe, 3);    shr(cx, 0x8);                             /* shr cx, 0x8 */
            ii(0xa701, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa703, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0xa706, 3);    callw(0xaa09, 0x300);                     /* call 0xaa09 */
            ii(0xa709, 2);    mov(dl, 0);                               /* mov dl, 0x0 */
            ii(0xa70b, 4);    xchg(memb_a16[ds, 0x980], dl);            /* xchg [0x980], dl */
            ii(0xa70f, 3);    mov(bx, 0x40);                            /* mov bx, 0x40 */
            ii(0xa712, 2);    mov(ah, 0x48);                            /* mov ah, 0x48 */
            ii(0xa714, 2);    @int(0x21);                              /* int 0x21 */
            ii(0xa716, 4);    jaew_func(0xa71d, 0x3);                   /* jae 0xa71d */
            ii(0xa71a, 2);    jmpw_func(0xa74b, 0x2f);                  /* jmp 0xa74b */
        }
    }
}
