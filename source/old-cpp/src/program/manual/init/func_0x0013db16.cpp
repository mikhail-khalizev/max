FUNC_BEGIN(0x0013db16, 0xe3b9ba68f7c7dc26, 0x10, ({0x55, 0x8b, 0xec, 0x8b, 0xd7, 0x8c, 0xd8, 0x8e, 0xc0, 0x8b, 0x7e, 0x6, 0x33, 0xc0, 0xb9, 0xff, 0xff, 0xf2, 0xae, 0xf7, 0xd1, 0x49, 0x91, 0x8b, 0xfa, 0x5d, 0xcb}))
    II(0x0013db16, 0x1)   pushw(bp);                            /* push bp */
    II(0x0013db17, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0013db19, 0x2)   mov(dx, di);                          /* mov dx, di */
    II(0x0013db1b, 0x2)   mov(ax, ds);                          /* mov ax, ds */
    II(0x0013db1d, 0x2)   mov(es, ax);                          /* mov es, ax */
    II(0x0013db1f, 0x3)   mov(di, memw_a16(ss, bp + 0x6));      /* mov di, [bp+0x6] */
    II(0x0013db22, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x0013db24, 0x3)   mov(cx, 0xffff);                      /* mov cx, 0xffff */
    II(0x0013db27, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x0013db29, 0x2)   not_(cx);                             /* not cx */
    II(0x0013db2b, 0x1)   dec(cx);                              /* dec cx */
    II(0x0013db2c, 0x1)   xchg(cx, ax);                         /* xchg cx, ax */
    II(0x0013db2d, 0x2)   mov(di, dx);                          /* mov di, dx */
    II(0x0013db2f, 0x1)   popw(bp);                             /* pop bp */
    II(0x0013db30, 0x1)   retfw();                              /* retf  */
FUNC_END

