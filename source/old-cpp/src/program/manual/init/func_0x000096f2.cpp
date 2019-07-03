FUNC_BEGIN(0x000096f2, 0xd5cbc17c6eb7f85e, 0x10, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x1e, 0x8e, 0x5e, 0x4, 0x8b, 0x76, 0x6, 0x8e, 0x46, 0x8, 0x8b, 0x7e, 0xa, 0x8b, 0x4e, 0xc, 0xf3, 0xa4, 0x1f, 0x5f, 0x5e, 0x8b, 0xe5, 0x5d, 0xc3}))
    II(0x000096f2, 0x1)   pushw(bp);                            /* push bp */
    II(0x000096f3, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x000096f5, 0x1)   pushw(si);                            /* push si */
    II(0x000096f6, 0x1)   pushw(di);                            /* push di */
    II(0x000096f7, 0x1)   pushw(ds);                            /* push ds */
    II(0x000096f8, 0x3)   mov(ds, memw_a16(ss, bp + 0x4));      /* mov ds, [bp+0x4] */
    II(0x000096fb, 0x3)   mov(si, memw_a16(ss, bp + 0x6));      /* mov si, [bp+0x6] */
    II(0x000096fe, 0x3)   mov(es, memw_a16(ss, bp + 0x8));      /* mov es, [bp+0x8] */
    II(0x00009701, 0x3)   mov(di, memw_a16(ss, bp + 0xa));      /* mov di, [bp+0xa] */
    II(0x00009704, 0x3)   mov(cx, memw_a16(ss, bp + 0xc));      /* mov cx, [bp+0xc] */
    II(0x00009707, 0x2)   rep_a16 movsb_a16();                  /* rep movsb  */
    II(0x00009709, 0x1)   popw(ds);                             /* pop ds */
    II(0x0000970a, 0x1)   popw(di);                             /* pop di */
    II(0x0000970b, 0x1)   popw(si);                             /* pop si */
    II(0x0000970c, 0x2)   mov(sp, bp);                          /* mov sp, bp */
    II(0x0000970e, 0x1)   popw(bp);                             /* pop bp */
    II(0x0000970f, 0x1)   retw();                               /* ret  */
FUNC_END

