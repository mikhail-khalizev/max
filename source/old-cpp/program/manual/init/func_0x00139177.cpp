FUNC_BEGIN(0x00139177, 0x5f6c991de0c65e29, 0x10, ({0x55, 0x8b, 0xec, 0x8b, 0x5e, 0x6, 0x6, 0x1e, 0x1e, 0x7, 0xc5, 0x56, 0x8, 0x8b, 0x4e, 0xc, 0x26, 0xff, 0x1e, 0xe0, 0x1f, 0x1b, 0xdb, 0xb, 0xc3, 0x1f, 0x7, 0x5d, 0xfc, 0xcb}))
    II(0x00139177, 0x1)   pushw(bp);                            /* push bp */
    II(0x00139178, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0013917a, 0x3)   mov(bx, memw_a16(ss, bp + 0x6));      /* mov bx, [bp+0x6] */
    II(0x0013917d, 0x1)   pushw(es);                            /* push es */
    II(0x0013917e, 0x1)   pushw(ds);                            /* push ds */
    II(0x0013917f, 0x1)   pushw(ds);                            /* push ds */
    II(0x00139180, 0x1)   popw(es);                             /* pop es */
    II(0x00139181, 0x3)   lds(dx, ss, bp + 0x8);                /* lds dx, [bp+0x8] */
    II(0x00139184, 0x3)   mov(cx, memw_a16(ss, bp + 0xc));      /* mov cx, [bp+0xc] */
    II(0x00139187, 0x5)   callw_a16_far_ind(es, 0x1fe0);        /* call word far [es:0x1fe0] */
    II(0x0013918c, 0x2)   sbb(bx, bx);                          /* sbb bx, bx */
    II(0x0013918e, 0x2)   or_(ax, bx);                          /* or ax, bx */
    II(0x00139190, 0x1)   popw(ds);                             /* pop ds */
    II(0x00139191, 0x1)   popw(es);                             /* pop es */
    II(0x00139192, 0x1)   popw(bp);                             /* pop bp */
    II(0x00139193, 0x1)   cld();                                /* cld  */
    II(0x00139194, 0x1)   retfw();                              /* retf  */
FUNC_END

