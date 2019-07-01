FUNC_BEGIN(0x00160faf, 0xc10997101a12ab63, 0x10, ({0xc8, 0, 0, 0, 0x6, 0x57, 0x51, 0xfc, 0xc4, 0x7e, 0x6, 0x8b, 0x46, 0xc, 0x8b, 0x4e, 0xa, 0xf3, 0xaa, 0x90, 0x59, 0x5f, 0x7, 0xc9, 0xcb}))
    II(0x00160faf, 0x4)   enterw(0, 0);                         /* enter 0x0, 0x0 */
    II(0x00160fb3, 0x1)   pushw(es);                            /* push es */
    II(0x00160fb4, 0x1)   pushw(di);                            /* push di */
    II(0x00160fb5, 0x1)   pushw(cx);                            /* push cx */
    II(0x00160fb6, 0x1)   cld();                                /* cld  */
    II(0x00160fb7, 0x3)   les(di, ss, bp + 0x6);                /* les di, [bp+0x6] */
    II(0x00160fba, 0x3)   mov(ax, memw_a16(ss, bp + 0xc));      /* mov ax, [bp+0xc] */
    II(0x00160fbd, 0x3)   mov(cx, memw_a16(ss, bp + 0xa));      /* mov cx, [bp+0xa] */
    II(0x00160fc0, 0x2)   rep_a16 stosb_a16();                  /* rep stosb  */
//    II(0x00160fc2, 0x1)   nop();                                /* nop  */
    II(0x00160fc3, 0x1)   popw(cx);                             /* pop cx */
    II(0x00160fc4, 0x1)   popw(di);                             /* pop di */
    II(0x00160fc5, 0x1)   popw(es);                             /* pop es */
    II(0x00160fc6, 0x1)   leavew();                             /* leave  */
    II(0x00160fc7, 0x1)   retfw();                              /* retf  */
FUNC_END

