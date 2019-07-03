FUNC_BEGIN(0x00005c60, 0x2e97821207fda5f, 0x10, ({0x1e, 0x10, 0xa, 0x8c, 0xca, 0x2b, 0xda, 0x2b, 0xd8, 0x3, 0xc2, 0xfc, 0x87, 0x6, 0x10, 0xa, 0x33, 0xf6, 0x8e, 0xd8, 0x8e, 0xc2, 0xf3, 0xa5, 0x16, 0x1f, 0x53, 0xe8, 0x50, 0, 0x59, 0xc1, 0xe1, 0x3, 0xe, 0x7, 0xb8, 0xcc, 0xcc, 0x8b, 0xdf, 0xf3, 0xab, 0x83, 0xc3, 0xf, 0xc1, 0xeb, 0x4, 0x3, 0x1e, 0xb6, 0x9, 0xa1, 0xec, 0xc, 0x2b, 0xd8, 0x89, 0x1e, 0x5a, 0, 0x8e, 0xc0, 0xb4, 0x4a, 0xcd, 0x21, 0x5e, 0x5f, 0x58, 0x5c, 0x5d, 0xc3}))
    II(0x00005c60, 0x1)   pushw(ds);                            /* push ds */
    II(0x00005c61, 0x2)   adc(memb_a16(ss, bp + si), cl);       /* adc [bp+si], cl */
    II(0x00005c63, 0x2)   mov(dx, cs);                          /* mov dx, cs */
    II(0x00005c65, 0x2)   sub(bx, dx);                          /* sub bx, dx */
    II(0x00005c67, 0x2)   sub(bx, ax);                          /* sub bx, ax */
    II(0x00005c69, 0x2)   add(ax, dx);                          /* add ax, dx */
    II(0x00005c6b, 0x1)   cld();                                /* cld  */
    II(0x00005c6c, 0x4)   xchg(memw_a16(ds, 0xa10), ax);        /* xchg [0xa10], ax */
    II(0x00005c70, 0x2)   xor_(si, si);                         /* xor si, si */
    II(0x00005c72, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x00005c74, 0x2)   mov(es, dx);                          /* mov es, dx */
    II(0x00005c76, 0x2)   rep_a16 movsw_a16();                  /* rep movsw  */
    II(0x00005c78, 0x1)   pushw(ss);                            /* push ss */
    II(0x00005c79, 0x1)   popw(ds);                             /* pop ds */
    II(0x00005c7a, 0x1)   pushw(bx);                            /* push bx */
    II(0x00005c7b, 0x3)   callw(0x00005cce, 0x50);              /* call 0x5cce */
    II(0x00005c7e, 0x1)   popw(cx);                             /* pop cx */
    II(0x00005c7f, 0x3)   shl(cx, 0x3);                         /* shl cx, 0x3 */
    II(0x00005c82, 0x1)   pushw(cs);                            /* push cs */
    II(0x00005c83, 0x1)   popw(es);                             /* pop es */
    II(0x00005c84, 0x3)   mov(ax, 0xcccc);                      /* mov ax, 0xcccc */
    II(0x00005c87, 0x2)   mov(bx, di);                          /* mov bx, di */
    II(0x00005c89, 0x2)   rep_a16 stosw_a16();                  /* rep stosw  */
    II(0x00005c8b, 0x3)   add(bx, 0xf);                         /* add bx, 0xf */
    II(0x00005c8e, 0x3)   shr(bx, 0x4);                         /* shr bx, 0x4 */
    II(0x00005c91, 0x4)   add(bx, memw_a16(ds, 0x9b6));         /* add bx, [0x9b6] */
    II(0x00005c95, 0x3)   mov(ax, memw_a16(ds, 0xcec));         /* mov ax, [0xcec] */
    II(0x00005c98, 0x2)   sub(bx, ax);                          /* sub bx, ax */
    II(0x00005c9a, 0x4)   mov(memw_a16(ds, 0x5a), bx);          /* mov [0x5a], bx */
    II(0x00005c9e, 0x2)   mov(es, ax);                          /* mov es, ax */
    II(0x00005ca0, 0x2)   mov(ah, 0x4a);                        /* mov ah, 0x4a */
    II(0x00005ca2, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x00005ca4, 0x1)   popw(si);                             /* pop si */
    II(0x00005ca5, 0x1)   popw(di);                             /* pop di */
    II(0x00005ca6, 0x1)   popw(ax);                             /* pop ax */
    II(0x00005ca7, 0x1)   popw(sp);                             /* pop sp */
    II(0x00005ca8, 0x1)   popw(bp);                             /* pop bp */
    II(0x00005ca9, 0x1)   retw();                               /* ret  */
FUNC_END

