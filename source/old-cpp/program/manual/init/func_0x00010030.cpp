FUNC_BEGIN(0x00010030, 0x4202d01f441f57f4, 0x10, ({0x67, 0x66, 0xf, 0xb7, 0x5d, 0x14, 0xb8, 0x8, 0, 0x8e, 0xd8, 0x3b, 0x1e, 0x8, 0, 0x73, 0xe1, 0x83, 0xe3, 0xf8, 0x74, 0xdc, 0x33, 0xc9, 0x8a, 0x4f, 0x5, 0xf6, 0xc1, 0x80, 0x74, 0x15, 0x6, 0x6a, 0x50, 0x7, 0x56, 0x8b, 0xf3, 0xc1, 0xee, 0x3, 0x26, 0x8a, 0x4, 0x5e, 0x7, 0x24, 0xf0, 0x3c, 0xf0, 0x74, 0x2, 0xf8, 0xc3, 0xf9, 0xc3}))
    II(0x00010030, 0x6)   movzx(ebx, memw_a32(ss, ebp + 0x14)); /* movzx ebx, word [ebp+0x14] */
    II(0x00010036, 0x3)   mov(ax, 0x8);                         /* mov ax, 0x8 */
    II(0x00010039, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x0001003b, 0x4)   cmp(bx, memw_a16(ds, 0x8));           /* cmp bx, [0x8] */
    II(0x0001003f, 0x2)   jaew_func(0x00010022, -0x1f);         /* jae 0x10022 */
    II(0x00010041, 0x3)   and_(bx, -0x8 /* 0xf8 */);            /* and bx, 0xf8 */
    II(0x00010044, 0x2)   jzw_func(0x00010022, -0x24);          /* jz 0x10022 */
    II(0x00010046, 0x2)   xor_(cx, cx);                         /* xor cx, cx */
    II(0x00010048, 0x3)   mov(cl, memb_a16(ds, bx + 0x5));      /* mov cl, [bx+0x5] */
    II(0x0001004b, 0x3)   test(cl, 0x80);                       /* test cl, 0x80 */
    II(0x0001004e, 0x2)   jzw(0x00010065, 0x15);                /* jz 0x10065 */
    II(0x00010050, 0x1)   pushw(es);                            /* push es */
    II(0x00010051, 0x2)   pushw(0x50);                          /* push 0x50 */
    II(0x00010053, 0x1)   popw(es);                             /* pop es */
    II(0x00010054, 0x1)   pushw(si);                            /* push si */
    II(0x00010055, 0x2)   mov(si, bx);                          /* mov si, bx */
    II(0x00010057, 0x3)   shr(si, 0x3);                         /* shr si, 0x3 */
    II(0x0001005a, 0x3)   mov(al, memb_a16(es, si));            /* mov al, [es:si] */
    II(0x0001005d, 0x1)   popw(si);                             /* pop si */
    II(0x0001005e, 0x1)   popw(es);                             /* pop es */
    II(0x0001005f, 0x2)   and_(al, 0xf0);                       /* and al, 0xf0 */
    II(0x00010061, 0x2)   cmp(al, -0x10 /* 0xf0 */);            /* cmp al, 0xf0 */
    II(0x00010063, 0x2)   jzw(0x00010067, 0x2);                 /* jz 0x10067 */
l_0x00010065:
    II(0x00010065, 0x1)   clc();                                /* clc  */
    II(0x00010066, 0x1)   retw();                               /* ret  */
l_0x00010067:
    II(0x00010067, 0x1)   stc();                                /* stc  */
    II(0x00010068, 0x1)   retw();                               /* ret  */
FUNC_END

