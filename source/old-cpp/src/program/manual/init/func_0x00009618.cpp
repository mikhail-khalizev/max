FUNC_BEGIN(0x00009618, 0xc9c40e4120323481, 0x10, ({0x55, 0x8b, 0xec, 0x8b, 0xd7, 0x8b, 0xde, 0x8c, 0xd8, 0x8e, 0xc0, 0x8b, 0x76, 0x4, 0x8b, 0x7e, 0x6, 0x33, 0xc0, 0xb9, 0xff, 0xff, 0xf2, 0xae, 0xf7, 0xd1, 0x2b, 0xf9, 0xf3, 0xa6, 0x74, 0x5, 0x1b, 0xc0, 0x1d, 0xff, 0xff, 0x8b, 0xf3, 0x8b, 0xfa, 0x5d, 0xc3}))
    II(0x00009618, 0x1)   pushw(bp);                            /* push bp */
    II(0x00009619, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0000961b, 0x2)   mov(dx, di);                          /* mov dx, di */
    II(0x0000961d, 0x2)   mov(bx, si);                          /* mov bx, si */
    II(0x0000961f, 0x2)   mov(ax, ds);                          /* mov ax, ds */
    II(0x00009621, 0x2)   mov(es, ax);                          /* mov es, ax */
    II(0x00009623, 0x3)   mov(si, memw_a16(ss, bp + 0x4));      /* mov si, [bp+0x4] */
    II(0x00009626, 0x3)   mov(di, memw_a16(ss, bp + 0x6));      /* mov di, [bp+0x6] */
    II(0x00009629, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x0000962b, 0x3)   mov(cx, 0xffff);                      /* mov cx, 0xffff */
    II(0x0000962e, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x00009630, 0x2)   not_(cx);                             /* not cx */
    II(0x00009632, 0x2)   sub(di, cx);                          /* sub di, cx */
    II(0x00009634, 0x2)   repe_a16 cmpsb_a16();                 /* rep cmpsb  */
    II(0x00009636, 0x2)   jzw(0x0000963d, 0x5);                 /* jz 0x963d */
    II(0x00009638, 0x2)   sbb(ax, ax);                          /* sbb ax, ax */
    II(0x0000963a, 0x3)   sbb(ax, 0xffff);                      /* sbb ax, 0xffff */
l_0x0000963d:
    II(0x0000963d, 0x2)   mov(si, bx);                          /* mov si, bx */
    II(0x0000963f, 0x2)   mov(di, dx);                          /* mov di, dx */
    II(0x00009641, 0x1)   popw(bp);                             /* pop bp */
    II(0x00009642, 0x1)   retw();                               /* ret  */
FUNC_END

