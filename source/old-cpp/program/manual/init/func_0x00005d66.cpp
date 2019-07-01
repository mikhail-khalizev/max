FUNC_BEGIN(0x00005d66, 0x858fa99eb333cfd3, 0x10, ({0x55, 0x8b, 0xec, 0x8b, 0xd7, 0x8c, 0xd8, 0x8e, 0xc0, 0x8b, 0x7e, 0x4, 0x8b, 0xdf, 0x8b, 0x4e, 0x8, 0xe3, 0x15, 0x8a, 0x46, 0x6, 0x8a, 0xe0, 0xf7, 0xc7, 0x1, 0, 0x74, 0x2, 0xaa, 0x49, 0xd1, 0xe9, 0xf3, 0xab, 0x13, 0xc9, 0xf3, 0xaa, 0x8b, 0xfa, 0x93, 0x5d, 0xc3}))
    II(0x00005d66, 0x1)   pushw(bp);                            /* push bp */
    II(0x00005d67, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x00005d69, 0x2)   mov(dx, di);                          /* mov dx, di */
    II(0x00005d6b, 0x2)   mov(ax, ds);                          /* mov ax, ds */
    II(0x00005d6d, 0x2)   mov(es, ax);                          /* mov es, ax */
    II(0x00005d6f, 0x3)   mov(di, memw_a16(ss, bp + 0x4));      /* mov di, [bp+0x4] */
    II(0x00005d72, 0x2)   mov(bx, di);                          /* mov bx, di */
    II(0x00005d74, 0x3)   mov(cx, memw_a16(ss, bp + 0x8));      /* mov cx, [bp+0x8] */
    II(0x00005d77, 0x2)   jcxzw(0x00005d8e, 0x15);              /* jcxz 0x5d8e */
    II(0x00005d79, 0x3)   mov(al, memb_a16(ss, bp + 0x6));      /* mov al, [bp+0x6] */
    II(0x00005d7c, 0x2)   mov(ah, al);                          /* mov ah, al */
    II(0x00005d7e, 0x4)   test(di, 0x1);                        /* test di, 0x1 */
    II(0x00005d82, 0x2)   jzw(0x00005d86, 0x2);                 /* jz 0x5d86 */
    II(0x00005d84, 0x1)   stosb_a16();                          /* stosb  */
    II(0x00005d85, 0x1)   dec(cx);                              /* dec cx */
l_0x00005d86:
    II(0x00005d86, 0x2)   shr(cx, 0x1);                         /* shr cx, 1 */
    II(0x00005d88, 0x2)   rep_a16 stosw_a16();                  /* rep stosw  */
    II(0x00005d8a, 0x2)   adc(cx, cx);                          /* adc cx, cx */
    II(0x00005d8c, 0x2)   rep_a16 stosb_a16();                  /* rep stosb  */
l_0x00005d8e:
    II(0x00005d8e, 0x2)   mov(di, dx);                          /* mov di, dx */
    II(0x00005d90, 0x1)   xchg(bx, ax);                         /* xchg bx, ax */
    II(0x00005d91, 0x1)   popw(bp);                             /* pop bp */
    II(0x00005d92, 0x1)   retw();                               /* ret  */
FUNC_END

