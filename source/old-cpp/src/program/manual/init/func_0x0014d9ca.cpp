FUNC_BEGIN(0x0014d9ca, 0x7eea446b7cb0b4e8, 0x10, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x1e, 0xe8, 0xaf, 0x1, 0x33, 0xf6, 0x33, 0xff, 0xf, 0x3, 0xcb, 0xe3, 0x25, 0x1e, 0x7, 0x53, 0x1f, 0x83, 0xc1, 0x1, 0xd1, 0xd9, 0xfc, 0xf3, 0xa5, 0x73, 0x1, 0xa4, 0x8c, 0xd3, 0x3b, 0x5e, 0x8, 0x75, 0xf, 0x8b, 0x4e, 0x6, 0x8b, 0x56, 0x4, 0xb8, 0x6, 0, 0xe, 0xe8, 0xba, 0xc9, 0x16, 0x17, 0x1f, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x0014d9ca, 0x1)   pushw(bp);                            /* push bp */
    II(0x0014d9cb, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0014d9cd, 0x1)   pushw(si);                            /* push si */
    II(0x0014d9ce, 0x1)   pushw(di);                            /* push di */
    II(0x0014d9cf, 0x1)   pushw(ds);                            /* push ds */
    II(0x0014d9d0, 0x3)   callw(0x0014db82, 0x1af);             /* call 0x14db82 */
    II(0x0014d9d3, 0x2)   xor_(si, si);                         /* xor si, si */
    II(0x0014d9d5, 0x2)   xor_(di, di);                         /* xor di, di */
    II(0x0014d9d7, 0x3)   lsl(cx, bx);                          /* lsl cx, bx */
    II(0x0014d9da, 0x2)   jcxzw(0x0014da01, 0x25);              /* jcxz 0x14da01 */
    II(0x0014d9dc, 0x1)   pushw(ds);                            /* push ds */
    II(0x0014d9dd, 0x1)   popw(es);                             /* pop es */
    II(0x0014d9de, 0x1)   pushw(bx);                            /* push bx */
    II(0x0014d9df, 0x1)   popw(ds);                             /* pop ds */
    II(0x0014d9e0, 0x3)   add(cx, 0x1);                         /* add cx, 0x1 */
    II(0x0014d9e3, 0x2)   rcr(cx, 0x1);                         /* rcr cx, 1 */
    II(0x0014d9e5, 0x1)   cld();                                /* cld  */
    II(0x0014d9e6, 0x2)   rep_a16 movsw_a16();                  /* rep movsw  */
    II(0x0014d9e8, 0x2)   jaew(0x0014d9eb, 0x1);                /* jae 0x14d9eb */
    II(0x0014d9ea, 0x1)   movsb_a16();                          /* movsb  */
l_0x0014d9eb:
    II(0x0014d9eb, 0x2)   mov(bx, ss);                          /* mov bx, ss */
    II(0x0014d9ed, 0x3)   cmp(bx, memw_a16(ss, bp + 0x8));      /* cmp bx, [bp+0x8] */
    II(0x0014d9f0, 0x2)   jnzw(0x0014da01, 0xf);                /* jnz 0x14da01 */
    II(0x0014d9f2, 0x3)   mov(cx, memw_a16(ss, bp + 0x6));      /* mov cx, [bp+0x6] */
    II(0x0014d9f5, 0x3)   mov(dx, memw_a16(ss, bp + 0x4));      /* mov dx, [bp+0x4] */
    II(0x0014d9f8, 0x3)   mov(ax, 0x6);                         /* mov ax, 0x6 */
    II(0x0014d9fb, 0x1)   pushw(cs);                            /* push cs */
    II(0x0014d9fc, 0x3)   callw(0x0014a3b9, -0x3646);           /* call 0x14a3b9 */
    II(0x0014d9ff, 0x1)   pushw(ss);                            /* push ss */
    II(0x0014da00, 0x1)   popw(ss);                             /* pop ss */
l_0x0014da01:
    II(0x0014da01, 0x1)   popw(ds);                             /* pop ds */
    II(0x0014da02, 0x1)   popw(di);                             /* pop di */
    II(0x0014da03, 0x1)   popw(si);                             /* pop si */
    II(0x0014da04, 0x1)   popw(bp);                             /* pop bp */
    II(0x0014da05, 0x1)   retw();                               /* ret  */
FUNC_END

