FUNC_BEGIN(0x0013e12c, 0x2bc359085823ac96, 0x10, ({0x55, 0x8b, 0xec, 0x8b, 0xd7, 0x8b, 0xde, 0x1e, 0xc5, 0x76, 0xa, 0x8b, 0xfe, 0x8c, 0xd8, 0x8e, 0xc0, 0x33, 0xc0, 0xb9, 0xff, 0xff, 0xf2, 0xae, 0xf7, 0xd1, 0xc4, 0x7e, 0x6, 0x8b, 0xc7, 0xa8, 0x1, 0x74, 0x2, 0xa4, 0x49, 0xd1, 0xe9, 0xf3, 0xa5, 0x13, 0xc9, 0xf3, 0xa4, 0x8b, 0xf3, 0x8b, 0xfa, 0x1f, 0x8c, 0xc2, 0x5d, 0xcb}))
    II(0x0013e12c, 0x1)   pushw(bp);                            /* push bp */
    II(0x0013e12d, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0013e12f, 0x2)   mov(dx, di);                          /* mov dx, di */
    II(0x0013e131, 0x2)   mov(bx, si);                          /* mov bx, si */
    II(0x0013e133, 0x1)   pushw(ds);                            /* push ds */
    II(0x0013e134, 0x3)   lds(si, ss, bp + 0xa);                /* lds si, [bp+0xa] */
    II(0x0013e137, 0x2)   mov(di, si);                          /* mov di, si */
    II(0x0013e139, 0x2)   mov(ax, ds);                          /* mov ax, ds */
    II(0x0013e13b, 0x2)   mov(es, ax);                          /* mov es, ax */
    II(0x0013e13d, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x0013e13f, 0x3)   mov(cx, 0xffff);                      /* mov cx, 0xffff */
    II(0x0013e142, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x0013e144, 0x2)   not_(cx);                             /* not cx */
    II(0x0013e146, 0x3)   les(di, ss, bp + 0x6);                /* les di, [bp+0x6] */
    II(0x0013e149, 0x2)   mov(ax, di);                          /* mov ax, di */
    II(0x0013e14b, 0x2)   test(al, 0x1);                        /* test al, 0x1 */
    II(0x0013e14d, 0x2)   jzw(0x0013e151, 0x2);                 /* jz 0x13e151 */
    II(0x0013e14f, 0x1)   movsb_a16();                          /* movsb  */
    II(0x0013e150, 0x1)   dec(cx);                              /* dec cx */
l_0x0013e151:
    II(0x0013e151, 0x2)   shr(cx, 0x1);                         /* shr cx, 1 */
    II(0x0013e153, 0x2)   rep_a16 movsw_a16();                  /* rep movsw  */
    II(0x0013e155, 0x2)   adc(cx, cx);                          /* adc cx, cx */
    II(0x0013e157, 0x2)   rep_a16 movsb_a16();                  /* rep movsb  */
    II(0x0013e159, 0x2)   mov(si, bx);                          /* mov si, bx */
    II(0x0013e15b, 0x2)   mov(di, dx);                          /* mov di, dx */
    II(0x0013e15d, 0x1)   popw(ds);                             /* pop ds */
    II(0x0013e15e, 0x2)   mov(dx, es);                          /* mov dx, es */
    II(0x0013e160, 0x1)   popw(bp);                             /* pop bp */
    II(0x0013e161, 0x1)   retfw();                              /* retf  */
FUNC_END

