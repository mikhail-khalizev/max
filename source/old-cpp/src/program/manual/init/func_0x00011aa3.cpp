FUNC_BEGIN(0x00011aa3, 0x8eacd6a978a85a6a, 0x10, ({0x55, 0x8b, 0xec, 0x6, 0x57, 0x8e, 0x46, 0x4, 0x8b, 0x7e, 0x6, 0x8b, 0x4e, 0x8, 0x8a, 0x46, 0xa, 0x8a, 0xe0, 0xfc, 0x83, 0xe9, 0x1, 0x41, 0xd1, 0xd9, 0xf3, 0xab, 0xd1, 0xd1, 0xf3, 0xaa, 0x5f, 0x7, 0x5d, 0xc3}))
    II(0x00011aa3, 0x1)   pushw(bp);                            /* push bp */
    II(0x00011aa4, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x00011aa6, 0x1)   pushw(es);                            /* push es */
    II(0x00011aa7, 0x1)   pushw(di);                            /* push di */
    II(0x00011aa8, 0x3)   mov(es, memw_a16(ss, bp + 0x4));      /* mov es, [bp+0x4] */
    II(0x00011aab, 0x3)   mov(di, memw_a16(ss, bp + 0x6));      /* mov di, [bp+0x6] */
    II(0x00011aae, 0x3)   mov(cx, memw_a16(ss, bp + 0x8));      /* mov cx, [bp+0x8] */
    II(0x00011ab1, 0x3)   mov(al, memb_a16(ss, bp + 0xa));      /* mov al, [bp+0xa] */
    II(0x00011ab4, 0x2)   mov(ah, al);                          /* mov ah, al */
    II(0x00011ab6, 0x1)   cld();                                /* cld  */
    II(0x00011ab7, 0x3)   sub(cx, 0x1);                         /* sub cx, 0x1 */
    II(0x00011aba, 0x1)   inc(cx);                              /* inc cx */
    II(0x00011abb, 0x2)   rcr(cx, 0x1);                         /* rcr cx, 1 */
    II(0x00011abd, 0x2)   rep_a16 stosw_a16();                  /* rep stosw  */
    II(0x00011abf, 0x2)   rcl(cx, 0x1);                         /* rcl cx, 1 */
    II(0x00011ac1, 0x2)   rep_a16 stosb_a16();                  /* rep stosb  */
    II(0x00011ac3, 0x1)   popw(di);                             /* pop di */
    II(0x00011ac4, 0x1)   popw(es);                             /* pop es */
    II(0x00011ac5, 0x1)   popw(bp);                             /* pop bp */
    II(0x00011ac6, 0x1)   retw();                               /* ret  */
FUNC_END

