FUNC_BEGIN(0x00005c10, 0xd26f6c9e6f8083ce, 0x10, ({0x55, 0x8b, 0xec, 0x8b, 0xd7, 0x8c, 0xd8, 0x8e, 0xc0, 0x8b, 0x7e, 0x4, 0x33, 0xc0, 0xb9, 0xff, 0xff, 0xf2, 0xae, 0xf7, 0xd1, 0x49, 0x91, 0x8b, 0xfa, 0x5d, 0xc3}))
    II(0x00005c10, 0x1)   pushw(bp);                            /* push bp */
    II(0x00005c11, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x00005c13, 0x2)   mov(dx, di);                          /* mov dx, di */
    II(0x00005c15, 0x2)   mov(ax, ds);                          /* mov ax, ds */
    II(0x00005c17, 0x2)   mov(es, ax);                          /* mov es, ax */
    II(0x00005c19, 0x3)   mov(di, memw_a16(ss, bp + 0x4));      /* mov di, [bp+0x4] */
    II(0x00005c1c, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x00005c1e, 0x3)   mov(cx, 0xffff);                      /* mov cx, 0xffff */
    II(0x00005c21, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x00005c23, 0x2)   not_(cx);                             /* not cx */
    II(0x00005c25, 0x1)   dec(cx);                              /* dec cx */
    II(0x00005c26, 0x1)   xchg(cx, ax);                         /* xchg cx, ax */
    II(0x00005c27, 0x2)   mov(di, dx);                          /* mov di, dx */
    II(0x00005c29, 0x1)   popw(bp);                             /* pop bp */
    II(0x00005c2a, 0x1)   retw();                               /* ret  */
FUNC_END

