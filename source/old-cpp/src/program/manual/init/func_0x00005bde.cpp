FUNC_BEGIN(0x00005bde, 0xa58383ebcb2b957e, 0x10, ({0x55, 0x8b, 0xec, 0x8b, 0xd7, 0x8b, 0xde, 0x8b, 0x76, 0x6, 0x8b, 0xfe, 0x8c, 0xd8, 0x8e, 0xc0, 0x33, 0xc0, 0xb9, 0xff, 0xff, 0xf2, 0xae, 0xf7, 0xd1, 0x8b, 0x7e, 0x4, 0x8b, 0xc7, 0xa8, 0x1, 0x74, 0x2, 0xa4, 0x49, 0xd1, 0xe9, 0xf3, 0xa5, 0x13, 0xc9, 0xf3, 0xa4, 0x8b, 0xf3, 0x8b, 0xfa, 0x5d, 0xc3}))
    II(0x00005bde, 0x1)   pushw(bp);                            /* push bp */
    II(0x00005bdf, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x00005be1, 0x2)   mov(dx, di);                          /* mov dx, di */
    II(0x00005be3, 0x2)   mov(bx, si);                          /* mov bx, si */
    II(0x00005be5, 0x3)   mov(si, memw_a16(ss, bp + 0x6));      /* mov si, [bp+0x6] */
    II(0x00005be8, 0x2)   mov(di, si);                          /* mov di, si */
    II(0x00005bea, 0x2)   mov(ax, ds);                          /* mov ax, ds */
    II(0x00005bec, 0x2)   mov(es, ax);                          /* mov es, ax */
    II(0x00005bee, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x00005bf0, 0x3)   mov(cx, 0xffff);                      /* mov cx, 0xffff */
    II(0x00005bf3, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x00005bf5, 0x2)   not_(cx);                             /* not cx */
    II(0x00005bf7, 0x3)   mov(di, memw_a16(ss, bp + 0x4));      /* mov di, [bp+0x4] */
    II(0x00005bfa, 0x2)   mov(ax, di);                          /* mov ax, di */
    II(0x00005bfc, 0x2)   test(al, 0x1);                        /* test al, 0x1 */
    II(0x00005bfe, 0x2)   jzw(0x00005c02, 0x2);                 /* jz 0x5c02 */
    II(0x00005c00, 0x1)   movsb_a16();                          /* movsb  */
    II(0x00005c01, 0x1)   dec(cx);                              /* dec cx */
l_0x00005c02:
    II(0x00005c02, 0x2)   shr(cx, 0x1);                         /* shr cx, 1 */
    II(0x00005c04, 0x2)   rep_a16 movsw_a16();                  /* rep movsw  */
    II(0x00005c06, 0x2)   adc(cx, cx);                          /* adc cx, cx */
    II(0x00005c08, 0x2)   rep_a16 movsb_a16();                  /* rep movsb  */
    II(0x00005c0a, 0x2)   mov(si, bx);                          /* mov si, bx */
    II(0x00005c0c, 0x2)   mov(di, dx);                          /* mov di, dx */
    II(0x00005c0e, 0x1)   popw(bp);                             /* pop bp */
    II(0x00005c0f, 0x1)   retw();                               /* ret  */
FUNC_END

