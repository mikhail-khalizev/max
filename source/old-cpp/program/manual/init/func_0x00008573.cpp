FUNC_BEGIN(0x00008573, 0xed507fae2bc9f021, 0x10, ({0xc8, 0x1a, 0, 0, 0x56, 0xbe, 0x22, 0, 0x80, 0x3e, 0xee, 0xc, 0x2, 0x75, 0x3, 0xbe, 0x17, 0, 0x80, 0x3e, 0xee, 0xc, 0x3, 0x75, 0xa, 0x80, 0x3e, 0xef, 0xc, 0, 0x75, 0x3, 0xbe, 0x28, 0, 0xc6, 0x46, 0xf3, 0x52, 0x8d, 0x46, 0xea, 0x50, 0x8d, 0x4e, 0xf2, 0x51, 0x51, 0xe8, 0x62, 0xd7, 0x83, 0xc4, 0x6, 0x8b, 0x46, 0xf4, 0x3, 0xc6, 0x89, 0x46, 0xe6, 0x8b, 0x46, 0xea, 0x89, 0x46, 0xe8, 0xbe, 0x28, 0, 0xeb, 0x10, 0x4e, 0x74, 0x20, 0xff, 0x76, 0xe6, 0x52, 0xff, 0x56, 0x4, 0x5b, 0x5b, 0xb, 0xc0, 0x75, 0x13, 0xc4, 0x5e, 0xe6, 0x26, 0x8b, 0x7, 0x26, 0x8b, 0x57, 0x2, 0x89, 0x46, 0xe6, 0x89, 0x56, 0xe8, 0x40, 0x75, 0xdd, 0x5e, 0xc9, 0xc3}))
    II(0x00008573, 0x4)   enterw(0x1a, 0);                      /* enter 0x1a, 0x0 */
    II(0x00008577, 0x1)   pushw(si);                            /* push si */
    II(0x00008578, 0x3)   mov(si, 0x22);                        /* mov si, 0x22 */
    II(0x0000857b, 0x5)   cmp(memb_a16(ds, 0xcee), 0x2);        /* cmp byte [0xcee], 0x2 */
    II(0x00008580, 0x2)   jnzw(0x00008585, 0x3);                /* jnz 0x8585 */
    II(0x00008582, 0x3)   mov(si, 0x17);                        /* mov si, 0x17 */
l_0x00008585:
    II(0x00008585, 0x5)   cmp(memb_a16(ds, 0xcee), 0x3);        /* cmp byte [0xcee], 0x3 */
    II(0x0000858a, 0x2)   jnzw(0x00008596, 0xa);                /* jnz 0x8596 */
    II(0x0000858c, 0x5)   cmp(memb_a16(ds, 0xcef), 0);          /* cmp byte [0xcef], 0x0 */
    II(0x00008591, 0x2)   jnzw(0x00008596, 0x3);                /* jnz 0x8596 */
    II(0x00008593, 0x3)   mov(si, 0x28);                        /* mov si, 0x28 */
l_0x00008596:
    II(0x00008596, 0x4)   mov(memb_a16(ss, bp - 0xd), 0x52);    /* mov byte [bp-0xd], 0x52 */
    II(0x0000859a, 0x3)   lea(ax, bp - 0x16);                   /* lea ax, [bp-0x16] */
    II(0x0000859d, 0x1)   pushw(ax);                            /* push ax */
    II(0x0000859e, 0x3)   lea(cx, bp - 0xe);                    /* lea cx, [bp-0xe] */
    II(0x000085a1, 0x1)   pushw(cx);                            /* push cx */
    II(0x000085a2, 0x1)   pushw(cx);                            /* push cx */
    II(0x000085a3, 0x3)   callw(0x00005d08, -0x289e);           /* call 0x5d08 */
    II(0x000085a6, 0x3)   add(sp, 0x6);                         /* add sp, 0x6 */
    II(0x000085a9, 0x3)   mov(ax, memw_a16(ss, bp - 0xc));      /* mov ax, [bp-0xc] */
    II(0x000085ac, 0x2)   add(ax, si);                          /* add ax, si */
    II(0x000085ae, 0x3)   mov(memw_a16(ss, bp - 0x1a), ax);     /* mov [bp-0x1a], ax */
    II(0x000085b1, 0x3)   mov(ax, memw_a16(ss, bp - 0x16));     /* mov ax, [bp-0x16] */
    II(0x000085b4, 0x3)   mov(memw_a16(ss, bp - 0x18), ax);     /* mov [bp-0x18], ax */
    II(0x000085b7, 0x3)   mov(si, 0x28);                        /* mov si, 0x28 */
    II(0x000085ba, 0x2)   jmpw(0x000085cc, 0x10);               /* jmp 0x85cc */
l_0x000085bc:
    II(0x000085bc, 0x1)   dec(si);                              /* dec si */
    II(0x000085bd, 0x2)   jzw(0x000085df, 0x20);                /* jz 0x85df */
    II(0x000085bf, 0x3)   pushw(memw_a16(ss, bp - 0x1a));       /* push word [bp-0x1a] */
    II(0x000085c2, 0x1)   pushw(dx);                            /* push dx */
    II(0x000085c3, 0x3)   callw_abs(memw_a16(ss, bp + 0x4));    /* call word near [bp+0x4] */
    II(0x000085c6, 0x1)   popw(bx);                             /* pop bx */
    II(0x000085c7, 0x1)   popw(bx);                             /* pop bx */
    II(0x000085c8, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x000085ca, 0x2)   jnzw(0x000085df, 0x13);               /* jnz 0x85df */
l_0x000085cc:
    II(0x000085cc, 0x3)   les(bx, ss, bp - 0x1a);               /* les bx, [bp-0x1a] */
    II(0x000085cf, 0x3)   mov(ax, memw_a16(es, bx));            /* mov ax, [es:bx] */
    II(0x000085d2, 0x4)   mov(dx, memw_a16(es, bx + 0x2));      /* mov dx, [es:bx+0x2] */
    II(0x000085d6, 0x3)   mov(memw_a16(ss, bp - 0x1a), ax);     /* mov [bp-0x1a], ax */
    II(0x000085d9, 0x3)   mov(memw_a16(ss, bp - 0x18), dx);     /* mov [bp-0x18], dx */
    II(0x000085dc, 0x1)   inc(ax);                              /* inc ax */
    II(0x000085dd, 0x2)   jnzw(0x000085bc, -0x23);              /* jnz 0x85bc */
l_0x000085df:
    II(0x000085df, 0x1)   popw(si);                             /* pop si */
    II(0x000085e0, 0x1)   leavew();                             /* leave  */
    II(0x000085e1, 0x1)   retw();                               /* ret  */
FUNC_END

