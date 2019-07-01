FUNC_BEGIN(0x0013dad6, 0x5dc0d0fe018ddd58, 0x10, ({0x55, 0x8b, 0xec, 0x8b, 0xd7, 0x8b, 0xde, 0x8c, 0xd8, 0x8e, 0xc0, 0x8b, 0x7e, 0x6, 0x33, 0xc0, 0xb9, 0xff, 0xff, 0xf2, 0xae, 0x8d, 0x75, 0xff, 0x8b, 0x7e, 0x8, 0xb9, 0xff, 0xff, 0xf2, 0xae, 0xf7, 0xd1, 0x2b, 0xf9, 0x87, 0xfe, 0x8b, 0x46, 0x6, 0xf7, 0xc6, 0x1, 0, 0x74, 0x2, 0xa4, 0x49, 0xd1, 0xe9, 0xf3, 0xa5, 0x13, 0xc9, 0xf3, 0xa4, 0x8b, 0xf3, 0x8b, 0xfa, 0x5d, 0xcb}))
    II(0x0013dad6, 0x1)   pushw(bp);                            /* push bp */
    II(0x0013dad7, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0013dad9, 0x2)   mov(dx, di);                          /* mov dx, di */
    II(0x0013dadb, 0x2)   mov(bx, si);                          /* mov bx, si */
    II(0x0013dadd, 0x2)   mov(ax, ds);                          /* mov ax, ds */
    II(0x0013dadf, 0x2)   mov(es, ax);                          /* mov es, ax */
    II(0x0013dae1, 0x3)   mov(di, memw_a16(ss, bp + 0x6));      /* mov di, [bp+0x6] */
    II(0x0013dae4, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x0013dae6, 0x3)   mov(cx, 0xffff);                      /* mov cx, 0xffff */
    II(0x0013dae9, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x0013daeb, 0x3)   lea(si, di - 0x1);                    /* lea si, [di-0x1] */
    II(0x0013daee, 0x3)   mov(di, memw_a16(ss, bp + 0x8));      /* mov di, [bp+0x8] */
    II(0x0013daf1, 0x3)   mov(cx, 0xffff);                      /* mov cx, 0xffff */
    II(0x0013daf4, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x0013daf6, 0x2)   not_(cx);                             /* not cx */
    II(0x0013daf8, 0x2)   sub(di, cx);                          /* sub di, cx */
    II(0x0013dafa, 0x2)   xchg(si, di);                         /* xchg si, di */
    II(0x0013dafc, 0x3)   mov(ax, memw_a16(ss, bp + 0x6));      /* mov ax, [bp+0x6] */
    II(0x0013daff, 0x4)   test(si, 0x1);                        /* test si, 0x1 */
    II(0x0013db03, 0x2)   jzw(0x0013db07, 0x2);                 /* jz 0x13db07 */
    II(0x0013db05, 0x1)   movsb_a16();                          /* movsb  */
    II(0x0013db06, 0x1)   dec(cx);                              /* dec cx */
l_0x0013db07:
    II(0x0013db07, 0x2)   shr(cx, 0x1);                         /* shr cx, 1 */
    II(0x0013db09, 0x2)   rep_a16 movsw_a16();                  /* rep movsw  */
    II(0x0013db0b, 0x2)   adc(cx, cx);                          /* adc cx, cx */
    II(0x0013db0d, 0x2)   rep_a16 movsb_a16();                  /* rep movsb  */
    II(0x0013db0f, 0x2)   mov(si, bx);                          /* mov si, bx */
    II(0x0013db11, 0x2)   mov(di, dx);                          /* mov di, dx */
    II(0x0013db13, 0x1)   popw(bp);                             /* pop bp */
    II(0x0013db14, 0x1)   retfw();                              /* retf  */
FUNC_END

