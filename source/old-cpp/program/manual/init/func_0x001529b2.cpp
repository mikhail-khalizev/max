FUNC_BEGIN(0x001529b2, 0x29ecec04f7f76ff, 0x10, ({0x8b, 0xe, 0x7a, 0x3f, 0xe3, 0x7, 0xbb, 0x2, 0, 0xff, 0x1e, 0x78, 0x3f, 0x1e, 0xc5, 0x16, 0x4, 0x3c, 0xb8, 0, 0x25, 0xcd, 0x21, 0x1f, 0x80, 0x3e, 0x46, 0x3c, 0, 0x74, 0xd, 0x1e, 0xa0, 0x47, 0x3c, 0xc5, 0x16, 0x48, 0x3c, 0xb4, 0x25, 0xcd, 0x21, 0x1f, 0xc3}))
    II(0x001529b2, 0x4)   mov(cx, memw_a16(ds, 0x3f7a));        /* mov cx, [0x3f7a] */
    II(0x001529b6, 0x2)   jcxzw(0x001529bf, 0x7);               /* jcxz 0x1529bf */
    II(0x001529b8, 0x3)   mov(bx, 0x2);                         /* mov bx, 0x2 */
    II(0x001529bb, 0x4)   callw_a16_far_ind(ds, 0x3f78);        /* call word far [0x3f78] */
l_0x001529bf:
    II(0x001529bf, 0x1)   pushw(ds);                            /* push ds */
    II(0x001529c0, 0x4)   lds(dx, ds, 0x3c04);                  /* lds dx, [0x3c04] */
    II(0x001529c4, 0x3)   mov(ax, 0x2500);                      /* mov ax, 0x2500 */
    II(0x001529c7, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x001529c9, 0x1)   popw(ds);                             /* pop ds */
    II(0x001529ca, 0x5)   cmp(memb_a16(ds, 0x3c46), 0);         /* cmp byte [0x3c46], 0x0 */
    II(0x001529cf, 0x2)   jzw(0x001529de, 0xd);                 /* jz 0x1529de */
    II(0x001529d1, 0x1)   pushw(ds);                            /* push ds */
    II(0x001529d2, 0x3)   mov(al, memb_a16(ds, 0x3c47));        /* mov al, [0x3c47] */
    II(0x001529d5, 0x4)   lds(dx, ds, 0x3c48);                  /* lds dx, [0x3c48] */
    II(0x001529d9, 0x2)   mov(ah, 0x25);                        /* mov ah, 0x25 */
    II(0x001529db, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x001529dd, 0x1)   popw(ds);                             /* pop ds */
l_0x001529de:
    II(0x001529de, 0x1)   retw();                               /* ret  */
FUNC_END

