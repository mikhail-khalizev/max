FUNC_BEGIN(0x0015338a, 0xebeab31e0827f4f8, 0x10, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x1e, 0x8e, 0x5e, 0x6, 0x8b, 0x76, 0x8, 0x8e, 0x46, 0xa, 0x8b, 0x7e, 0xc, 0x8b, 0x4e, 0xe, 0xf3, 0xa4, 0x1f, 0x5f, 0x5e, 0x8b, 0xe5, 0x5d, 0xcb}))
    II(0x0015338a, 0x1)   pushw(bp);                            /* push bp */
    II(0x0015338b, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0015338d, 0x1)   pushw(si);                            /* push si */
    II(0x0015338e, 0x1)   pushw(di);                            /* push di */
    II(0x0015338f, 0x1)   pushw(ds);                            /* push ds */
    II(0x00153390, 0x3)   mov(ds, memw_a16(ss, bp + 0x6));      /* mov ds, [bp+0x6] */
    II(0x00153393, 0x3)   mov(si, memw_a16(ss, bp + 0x8));      /* mov si, [bp+0x8] */
    II(0x00153396, 0x3)   mov(es, memw_a16(ss, bp + 0xa));      /* mov es, [bp+0xa] */
    II(0x00153399, 0x3)   mov(di, memw_a16(ss, bp + 0xc));      /* mov di, [bp+0xc] */
    II(0x0015339c, 0x3)   mov(cx, memw_a16(ss, bp + 0xe));      /* mov cx, [bp+0xe] */
    II(0x0015339f, 0x2)   rep_a16 movsb_a16();                  /* rep movsb  */
    II(0x001533a1, 0x1)   popw(ds);                             /* pop ds */
    II(0x001533a2, 0x1)   popw(di);                             /* pop di */
    II(0x001533a3, 0x1)   popw(si);                             /* pop si */
    II(0x001533a4, 0x2)   mov(sp, bp);                          /* mov sp, bp */
    II(0x001533a6, 0x1)   popw(bp);                             /* pop bp */
    II(0x001533a7, 0x1)   retfw();                              /* retf  */
FUNC_END

