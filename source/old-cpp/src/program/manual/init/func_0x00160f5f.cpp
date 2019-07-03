FUNC_BEGIN(0x00160f5f, 0xd9599e6256816588, 0x10, ({0xc8, 0, 0, 0, 0x6, 0x1e, 0x56, 0x57, 0x51, 0xc5, 0x76, 0xa, 0xc4, 0x7e, 0x6, 0x8b, 0xc7, 0x8b, 0x4e, 0xe, 0xe3, 0x31, 0x8c, 0xc0, 0x3b, 0x46, 0xc, 0x75, 0x1a, 0x3b, 0xfe, 0x76, 0x16, 0x8b, 0xc6, 0x3, 0xc1, 0x3b, 0xf8, 0x73, 0xe, 0x8b, 0xc7, 0x3, 0xf1, 0x3, 0xf9, 0x4e, 0x4f, 0xfd, 0xf3, 0xa4, 0xfc, 0xeb, 0x10, 0x8b, 0xc7, 0xa8, 0x1, 0x74, 0x2, 0xa4, 0x49, 0xd1, 0xe9, 0xf3, 0xa5, 0x13, 0xc9, 0xf3, 0xa4, 0x8c, 0xc2, 0x59, 0x5f, 0x5e, 0x1f, 0x7, 0xc9, 0xcb}))
    II(0x00160f5f, 0x4)   enterw(0, 0);                         /* enter 0x0, 0x0 */
    II(0x00160f63, 0x1)   pushw(es);                            /* push es */
    II(0x00160f64, 0x1)   pushw(ds);                            /* push ds */
    II(0x00160f65, 0x1)   pushw(si);                            /* push si */
    II(0x00160f66, 0x1)   pushw(di);                            /* push di */
    II(0x00160f67, 0x1)   pushw(cx);                            /* push cx */
    II(0x00160f68, 0x3)   lds(si, ss, bp + 0xa);                /* lds si, [bp+0xa] */
    II(0x00160f6b, 0x3)   les(di, ss, bp + 0x6);                /* les di, [bp+0x6] */
    II(0x00160f6e, 0x2)   mov(ax, di);                          /* mov ax, di */
    II(0x00160f70, 0x3)   mov(cx, memw_a16(ss, bp + 0xe));      /* mov cx, [bp+0xe] */
    II(0x00160f73, 0x2)   jcxzw(0x00160fa6, 0x31);              /* jcxz 0x160fa6 */
    II(0x00160f75, 0x2)   mov(ax, es);                          /* mov ax, es */
    II(0x00160f77, 0x3)   cmp(ax, memw_a16(ss, bp + 0xc));      /* cmp ax, [bp+0xc] */
    II(0x00160f7a, 0x2)   jnzw(0x00160f96, 0x1a);               /* jnz 0x160f96 */
    II(0x00160f7c, 0x2)   cmp(di, si);                          /* cmp di, si */
    II(0x00160f7e, 0x2)   jbew(0x00160f96, 0x16);               /* jbe 0x160f96 */
    II(0x00160f80, 0x2)   mov(ax, si);                          /* mov ax, si */
    II(0x00160f82, 0x2)   add(ax, cx);                          /* add ax, cx */
    II(0x00160f84, 0x2)   cmp(di, ax);                          /* cmp di, ax */
    II(0x00160f86, 0x2)   jaew(0x00160f96, 0xe);                /* jae 0x160f96 */
    II(0x00160f88, 0x2)   mov(ax, di);                          /* mov ax, di */
    II(0x00160f8a, 0x2)   add(si, cx);                          /* add si, cx */
    II(0x00160f8c, 0x2)   add(di, cx);                          /* add di, cx */
    II(0x00160f8e, 0x1)   dec(si);                              /* dec si */
    II(0x00160f8f, 0x1)   dec(di);                              /* dec di */
    II(0x00160f90, 0x1)   std_();                               /* std  */
    II(0x00160f91, 0x2)   rep_a16 movsb_a16();                  /* rep movsb  */
    II(0x00160f93, 0x1)   cld();                                /* cld  */
    II(0x00160f94, 0x2)   jmpw(0x00160fa6, 0x10);               /* jmp 0x160fa6 */
l_0x00160f96:
    II(0x00160f96, 0x2)   mov(ax, di);                          /* mov ax, di */
    II(0x00160f98, 0x2)   test(al, 0x1);                        /* test al, 0x1 */
    II(0x00160f9a, 0x2)   jzw(0x00160f9e, 0x2);                 /* jz 0x160f9e */
    II(0x00160f9c, 0x1)   movsb_a16();                          /* movsb  */
    II(0x00160f9d, 0x1)   dec(cx);                              /* dec cx */
l_0x00160f9e:
    II(0x00160f9e, 0x2)   shr(cx, 0x1);                         /* shr cx, 1 */
    II(0x00160fa0, 0x2)   rep_a16 movsw_a16();                  /* rep movsw  */
    II(0x00160fa2, 0x2)   adc(cx, cx);                          /* adc cx, cx */
    II(0x00160fa4, 0x2)   rep_a16 movsb_a16();                  /* rep movsb  */
l_0x00160fa6:
    II(0x00160fa6, 0x2)   mov(dx, es);                          /* mov dx, es */
    II(0x00160fa8, 0x1)   popw(cx);                             /* pop cx */
    II(0x00160fa9, 0x1)   popw(di);                             /* pop di */
    II(0x00160faa, 0x1)   popw(si);                             /* pop si */
    II(0x00160fab, 0x1)   popw(ds);                             /* pop ds */
    II(0x00160fac, 0x1)   popw(es);                             /* pop es */
    II(0x00160fad, 0x1)   leavew();                             /* leave  */
    II(0x00160fae, 0x1)   retfw();                              /* retf  */
FUNC_END

