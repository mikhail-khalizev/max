FUNC_BEGIN(0x0000499d, 0x54330d573de1b90e, 0x10, ({0xe8, 0xbb, 0x2, 0x75, 0x75, 0x33, 0xdb, 0x8e, 0xc3, 0x8a, 0x1e, 0x34, 0, 0xc1, 0xe3, 0x2, 0x8c, 0xca, 0x26, 0x3b, 0x57, 0x2, 0x75, 0x1f, 0xb4, 0x25, 0x80, 0x3e, 0x34, 0, 0x15, 0x2e, 0xc5, 0x16, 0xc4, 0x12, 0x74, 0x5, 0x36, 0xc5, 0x16, 0x84, 0xf, 0xfa, 0x26, 0x89, 0x17, 0x26, 0x8c, 0x5f, 0x2, 0xfb, 0x16, 0x1f, 0xc3, 0x91, 0x8e, 0xd8, 0x3b, 0x47, 0xfe, 0x75, 0x3b, 0x3b, 0x5f, 0xfc, 0x75, 0x36, 0x8b, 0x47, 0xfa, 0x3b, 0xd0, 0x74, 0x5, 0x8b, 0x5f, 0xf8, 0xeb, 0xe8, 0x2e, 0xa1, 0xc4, 0x12, 0xfa, 0x89, 0x47, 0xf8, 0x2e, 0xa1, 0xc6, 0x12, 0x89, 0x47, 0xfa, 0xfb, 0xa1, 0, 0, 0xb, 0xc0, 0x75, 0x3, 0xa1, 0x10, 0, 0xb, 0xc0, 0x74, 0xc, 0x2d, 0x11, 0, 0x8e, 0xd8, 0x40, 0x39, 0x6, 0x1, 0, 0x74, 0x3, 0xb8, 0xff, 0xff, 0x36, 0x8b, 0x1e, 0xec, 0xc, 0x4b, 0x8e, 0xdb, 0xa3, 0x1, 0, 0x16, 0x1f, 0xc3}))
    II(0x0000499d, 0x3)   callw(0x00004c5b, 0x2bb);             /* call 0x4c5b */
    II(0x000049a0, 0x2)   jnzw(0x00004a17, 0x75);               /* jnz 0x4a17 */
    II(0x000049a2, 0x2)   xor_(bx, bx);                         /* xor bx, bx */
    II(0x000049a4, 0x2)   mov(es, bx);                          /* mov es, bx */
    II(0x000049a6, 0x4)   mov(bl, memb_a16(ds, 0x34));          /* mov bl, [0x34] */
    II(0x000049aa, 0x3)   shl(bx, 0x2);                         /* shl bx, 0x2 */
    II(0x000049ad, 0x2)   mov(dx, cs);                          /* mov dx, cs */
    II(0x000049af, 0x4)   cmp(dx, memw_a16(es, bx + 0x2));      /* cmp dx, [es:bx+0x2] */
    II(0x000049b3, 0x2)   jnzw(0x000049d4, 0x1f);               /* jnz 0x49d4 */
    II(0x000049b5, 0x2)   mov(ah, 0x25);                        /* mov ah, 0x25 */
    II(0x000049b7, 0x5)   cmp(memb_a16(ds, 0x34), 0x15);        /* cmp byte [0x34], 0x15 */
    II(0x000049bc, 0x5)   lds(dx, cs, 0x12c4);                  /* lds dx, [cs:0x12c4] */
    II(0x000049c1, 0x2)   jzw(0x000049c8, 0x5);                 /* jz 0x49c8 */
    II(0x000049c3, 0x5)   lds(dx, ss, 0xf84);                   /* lds dx, [ss:0xf84] */
l_0x000049c8:
    II(0x000049c8, 0x1)   cli();                                /* cli  */
    II(0x000049c9, 0x3)   mov(memw_a16(es, bx), dx);            /* mov [es:bx], dx */
    II(0x000049cc, 0x4)   mov(memw_a16(es, bx + 0x2), ds);      /* mov [es:bx+0x2], ds */
    II(0x000049d0, 0x1)   sti();                                /* sti  */
    II(0x000049d1, 0x1)   pushw(ss);                            /* push ss */
    II(0x000049d2, 0x1)   popw(ds);                             /* pop ds */
    II(0x000049d3, 0x1)   retw();                               /* ret  */
l_0x000049d4:
    II(0x000049d4, 0x1)   xchg(cx, ax);                         /* xchg cx, ax */
l_0x000049d5:
    II(0x000049d5, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x000049d7, 0x3)   cmp(ax, memw_a16(ds, bx - 0x2));      /* cmp ax, [bx-0x2] */
    II(0x000049da, 0x2)   jnzw(0x00004a17, 0x3b);               /* jnz 0x4a17 */
    II(0x000049dc, 0x3)   cmp(bx, memw_a16(ds, bx - 0x4));      /* cmp bx, [bx-0x4] */
    II(0x000049df, 0x2)   jnzw(0x00004a17, 0x36);               /* jnz 0x4a17 */
    II(0x000049e1, 0x3)   mov(ax, memw_a16(ds, bx - 0x6));      /* mov ax, [bx-0x6] */
    II(0x000049e4, 0x2)   cmp(dx, ax);                          /* cmp dx, ax */
    II(0x000049e6, 0x2)   jzw(0x000049ed, 0x5);                 /* jz 0x49ed */
    II(0x000049e8, 0x3)   mov(bx, memw_a16(ds, bx - 0x8));      /* mov bx, [bx-0x8] */
    II(0x000049eb, 0x2)   jmpw(0x000049d5, -0x18);              /* jmp 0x49d5 */
l_0x000049ed:
    II(0x000049ed, 0x4)   mov(ax, memw_a16(cs, 0x12c4));        /* mov ax, [cs:0x12c4] */
    II(0x000049f1, 0x1)   cli();                                /* cli  */
    II(0x000049f2, 0x3)   mov(memw_a16(ds, bx - 0x8), ax);      /* mov [bx-0x8], ax */
    II(0x000049f5, 0x4)   mov(ax, memw_a16(cs, 0x12c6));        /* mov ax, [cs:0x12c6] */
    II(0x000049f9, 0x3)   mov(memw_a16(ds, bx - 0x6), ax);      /* mov [bx-0x6], ax */
    II(0x000049fc, 0x1)   sti();                                /* sti  */
    II(0x000049fd, 0x3)   mov(ax, memw_a16(ds, 0));             /* mov ax, [0x0] */
    II(0x00004a00, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x00004a02, 0x2)   jnzw(0x00004a07, 0x3);                /* jnz 0x4a07 */
    II(0x00004a04, 0x3)   mov(ax, memw_a16(ds, 0x10));          /* mov ax, [0x10] */
l_0x00004a07:
    II(0x00004a07, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x00004a09, 0x2)   jzw(0x00004a17, 0xc);                 /* jz 0x4a17 */
    II(0x00004a0b, 0x3)   sub(ax, 0x11);                        /* sub ax, 0x11 */
    II(0x00004a0e, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x00004a10, 0x1)   inc(ax);                              /* inc ax */
    II(0x00004a11, 0x4)   cmp(memw_a16(ds, 0x1), ax);           /* cmp [0x1], ax */
    II(0x00004a15, 0x2)   jzw(0x00004a1a, 0x3);                 /* jz 0x4a1a */
l_0x00004a17:
    II(0x00004a17, 0x3)   mov(ax, 0xffff);                      /* mov ax, 0xffff */
l_0x00004a1a:
    II(0x00004a1a, 0x5)   mov(bx, memw_a16(ss, 0xcec));         /* mov bx, [ss:0xcec] */
    II(0x00004a1f, 0x1)   dec(bx);                              /* dec bx */
    II(0x00004a20, 0x2)   mov(ds, bx);                          /* mov ds, bx */
    II(0x00004a22, 0x3)   mov(memw_a16(ds, 0x1), ax);           /* mov [0x1], ax */
    II(0x00004a25, 0x1)   pushw(ss);                            /* push ss */
    II(0x00004a26, 0x1)   popw(ds);                             /* pop ds */
    II(0x00004a27, 0x1)   retw();                               /* ret  */
FUNC_END

