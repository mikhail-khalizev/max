FUNC_BEGIN(0x00153a0a, 0x6de82e98cc38d33c, 0x10, ({0x55, 0x8b, 0xec, 0x8b, 0xd7, 0x8b, 0xde, 0x1e, 0xc4, 0x7e, 0x6, 0x33, 0xc0, 0xb9, 0xff, 0xff, 0xf2, 0xae, 0x8d, 0x75, 0xff, 0xc4, 0x7e, 0xa, 0xb9, 0xff, 0xff, 0xf2, 0xae, 0xf7, 0xd1, 0x2b, 0xf9, 0x8c, 0xc0, 0x8e, 0xd8, 0x8e, 0x46, 0x8, 0x87, 0xfe, 0x8b, 0x46, 0x6, 0xf7, 0xc6, 0x1, 0, 0x74, 0x2, 0xa4, 0x49, 0xd1, 0xe9, 0xf3, 0xa5, 0x13, 0xc9, 0xf3, 0xa4, 0x8b, 0xf3, 0x8b, 0xfa, 0x1f, 0x8c, 0xc2, 0x5d, 0xcb}))
    II(0x00153a0a, 0x1)   pushw(bp);                            /* push bp */
    II(0x00153a0b, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x00153a0d, 0x2)   mov(dx, di);                          /* mov dx, di */
    II(0x00153a0f, 0x2)   mov(bx, si);                          /* mov bx, si */
    II(0x00153a11, 0x1)   pushw(ds);                            /* push ds */
    II(0x00153a12, 0x3)   les(di, ss, bp + 0x6);                /* les di, [bp+0x6] */
    II(0x00153a15, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x00153a17, 0x3)   mov(cx, 0xffff);                      /* mov cx, 0xffff */
    II(0x00153a1a, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x00153a1c, 0x3)   lea(si, di - 0x1);                    /* lea si, [di-0x1] */
    II(0x00153a1f, 0x3)   les(di, ss, bp + 0xa);                /* les di, [bp+0xa] */
    II(0x00153a22, 0x3)   mov(cx, 0xffff);                      /* mov cx, 0xffff */
    II(0x00153a25, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x00153a27, 0x2)   not_(cx);                             /* not cx */
    II(0x00153a29, 0x2)   sub(di, cx);                          /* sub di, cx */
    II(0x00153a2b, 0x2)   mov(ax, es);                          /* mov ax, es */
    II(0x00153a2d, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x00153a2f, 0x3)   mov(es, memw_a16(ss, bp + 0x8));      /* mov es, [bp+0x8] */
    II(0x00153a32, 0x2)   xchg(si, di);                         /* xchg si, di */
    II(0x00153a34, 0x3)   mov(ax, memw_a16(ss, bp + 0x6));      /* mov ax, [bp+0x6] */
    II(0x00153a37, 0x4)   test(si, 0x1);                        /* test si, 0x1 */
    II(0x00153a3b, 0x2)   jzw(0x00153a3f, 0x2);                 /* jz 0x153a3f */
    II(0x00153a3d, 0x1)   movsb_a16();                          /* movsb  */
    II(0x00153a3e, 0x1)   dec(cx);                              /* dec cx */
l_0x00153a3f:
    II(0x00153a3f, 0x2)   shr(cx, 0x1);                         /* shr cx, 1 */
    II(0x00153a41, 0x2)   rep_a16 movsw_a16();                  /* rep movsw  */
    II(0x00153a43, 0x2)   adc(cx, cx);                          /* adc cx, cx */
    II(0x00153a45, 0x2)   rep_a16 movsb_a16();                  /* rep movsb  */
    II(0x00153a47, 0x2)   mov(si, bx);                          /* mov si, bx */
    II(0x00153a49, 0x2)   mov(di, dx);                          /* mov di, dx */
    II(0x00153a4b, 0x1)   popw(ds);                             /* pop ds */
    II(0x00153a4c, 0x2)   mov(dx, es);                          /* mov dx, es */
    II(0x00153a4e, 0x1)   popw(bp);                             /* pop bp */
    II(0x00153a4f, 0x1)   retfw();                              /* retf  */
FUNC_END

