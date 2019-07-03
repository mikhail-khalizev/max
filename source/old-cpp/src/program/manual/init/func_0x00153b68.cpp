FUNC_BEGIN(0x00153b68, 0x190602dd5cc95c07, 0x10, ({0x55, 0x8b, 0xec, 0x8b, 0xd7, 0xc4, 0x7e, 0x6, 0x33, 0xc0, 0xb9, 0xff, 0xff, 0xf2, 0xae, 0xf7, 0xd1, 0x49, 0x91, 0x8b, 0xfa, 0x5d, 0xcb}))
    II(0x00153b68, 0x1)   pushw(bp);                            /* push bp */
    II(0x00153b69, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x00153b6b, 0x2)   mov(dx, di);                          /* mov dx, di */
    II(0x00153b6d, 0x3)   les(di, ss, bp + 0x6);                /* les di, [bp+0x6] */
    II(0x00153b70, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x00153b72, 0x3)   mov(cx, 0xffff);                      /* mov cx, 0xffff */
    II(0x00153b75, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x00153b77, 0x2)   not_(cx);                             /* not cx */
    II(0x00153b79, 0x1)   dec(cx);                              /* dec cx */
    II(0x00153b7a, 0x1)   xchg(cx, ax);                         /* xchg cx, ax */
    II(0x00153b7b, 0x2)   mov(di, dx);                          /* mov di, dx */
    II(0x00153b7d, 0x1)   popw(bp);                             /* pop bp */
    II(0x00153b7e, 0x1)   retfw();                              /* retf  */
FUNC_END

