FUNC_BEGIN(0x0013d86f, 0x7164a5ae92da0dc3, 0x10, ({0x55, 0x8b, 0xec, 0x57, 0xff, 0x76, 0x6, 0xe, 0xe8, 0xca, 0xff, 0xb, 0xc0, 0x74, 0x20, 0x92, 0x8b, 0xfa, 0x33, 0xc0, 0xb9, 0xff, 0xff, 0xf2, 0xae, 0xf7, 0xd1, 0x49, 0xbb, 0x2, 0, 0x81, 0x3e, 0xac, 0x1d, 0xd6, 0xd6, 0x75, 0x4, 0xff, 0x16, 0xae, 0x1d, 0xb4, 0x40, 0xcd, 0x21, 0x5f, 0x8b, 0xe5, 0x5d, 0xca, 0x2, 0}))
    II(0x0013d86f, 0x1)   pushw(bp);                            /* push bp */
    II(0x0013d870, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0013d872, 0x1)   pushw(di);                            /* push di */
    II(0x0013d873, 0x3)   pushw(memw_a16(ss, bp + 0x6));        /* push word [bp+0x6] */
    II(0x0013d876, 0x1)   pushw(cs);                            /* push cs */
    II(0x0013d877, 0x3)   callw(0x0013d844, -0x36);             /* call 0x13d844 */
    II(0x0013d87a, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x0013d87c, 0x2)   jzw(0x0013d89e, 0x20);                /* jz 0x13d89e */
    II(0x0013d87e, 0x1)   xchg(dx, ax);                         /* xchg dx, ax */
    II(0x0013d87f, 0x2)   mov(di, dx);                          /* mov di, dx */
    II(0x0013d881, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x0013d883, 0x3)   mov(cx, 0xffff);                      /* mov cx, 0xffff */
    II(0x0013d886, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x0013d888, 0x2)   not_(cx);                             /* not cx */
    II(0x0013d88a, 0x1)   dec(cx);                              /* dec cx */
    II(0x0013d88b, 0x3)   mov(bx, 0x2);                         /* mov bx, 0x2 */
    II(0x0013d88e, 0x6)   cmp(memw_a16(ds, 0x1dac), 0xd6d6);    /* cmp word [0x1dac], 0xd6d6 */
    II(0x0013d894, 0x2)   jnzw(0x0013d89a, 0x4);                /* jnz 0x13d89a */
    II(0x0013d896, 0x4)   callw_abs(memw_a16(ds, 0x1dae));      /* call word near [0x1dae] */ /* Вызов '0x00134820'. */
l_0x0013d89a:
    II(0x0013d89a, 0x2)   mov(ah, 0x40);                        /* mov ah, 0x40 */
    II(0x0013d89c, 0x2)   int_(0x21);                           /* int 0x21 */
l_0x0013d89e:
    II(0x0013d89e, 0x1)   popw(di);                             /* pop di */
    II(0x0013d89f, 0x2)   mov(sp, bp);                          /* mov sp, bp */
    II(0x0013d8a1, 0x1)   popw(bp);                             /* pop bp */
    II(0x0013d8a2, 0x3)   retfw(0x2);                           /* retf 0x2 */
FUNC_END

