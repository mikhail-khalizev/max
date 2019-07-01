FUNC_BEGIN(0x00138ed0, 0x401145adecb8e3da, 0x10, ({0x55, 0x8b, 0xec, 0x6, 0x57, 0x51, 0x8b, 0x4e, 0xa, 0x8e, 0x46, 0x8, 0x8b, 0x7e, 0x6, 0x32, 0xc0, 0xf3, 0xaa, 0x59, 0x5f, 0x7, 0x5d, 0xcb}))
    II(0x00138ed0, 0x1)   pushw(bp);                            /* push bp */
    II(0x00138ed1, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x00138ed3, 0x1)   pushw(es);                            /* push es */
    II(0x00138ed4, 0x1)   pushw(di);                            /* push di */
    II(0x00138ed5, 0x1)   pushw(cx);                            /* push cx */
    II(0x00138ed6, 0x3)   mov(cx, memw_a16(ss, bp + 0xa));      /* mov cx, [bp+0xa] */
    II(0x00138ed9, 0x3)   mov(es, memw_a16(ss, bp + 0x8));      /* mov es, [bp+0x8] */
    II(0x00138edc, 0x3)   mov(di, memw_a16(ss, bp + 0x6));      /* mov di, [bp+0x6] */
    II(0x00138edf, 0x2)   xor_(al, al);                         /* xor al, al */
    II(0x00138ee1, 0x2)   rep_a16 stosb_a16();                  /* rep stosb  */
    II(0x00138ee3, 0x1)   popw(cx);                             /* pop cx */
    II(0x00138ee4, 0x1)   popw(di);                             /* pop di */
    II(0x00138ee5, 0x1)   popw(es);                             /* pop es */
    II(0x00138ee6, 0x1)   popw(bp);                             /* pop bp */
    II(0x00138ee7, 0x1)   retfw();                              /* retf  */
FUNC_END

