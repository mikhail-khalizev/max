FUNC_BEGIN(0x00154a6c, 0x6c0cae09fa8604f6, 0x10, ({0xc8, 0xc, 0, 0, 0x1e, 0xb8, 0xa8, 0, 0x8e, 0xd8, 0xc7, 0x46, 0xfc, 0xff, 0xff, 0xc7, 0x46, 0xfe, 0xff, 0xff, 0x8d, 0x46, 0xf4, 0x16, 0x50, 0xff, 0x76, 0x8, 0x90, 0xe, 0xe8, 0x85, 0xf9, 0x83, 0xc4, 0x6, 0xb, 0xc0, 0x74, 0x1f, 0x8b, 0x46, 0xfa, 0x2a, 0xc0, 0x8b, 0xd0, 0x8b, 0x4e, 0xf6, 0x8b, 0x5e, 0xf8, 0x2a, 0xff, 0x8b, 0xc1, 0xb, 0xd3, 0x3, 0x46, 0x6, 0x83, 0xd2, 0, 0x89, 0x46, 0xfc, 0x89, 0x56, 0xfe, 0x8b, 0x46, 0xfc, 0x8b, 0x56, 0xfe, 0x1f, 0xc9, 0xcb}))
    II(0x00154a6c, 0x4)   enterw(0xc, 0);                       /* enter 0xc, 0x0 */
    II(0x00154a70, 0x1)   pushw(ds);                            /* push ds */
    II(0x00154a71, 0x3)   mov(ax, 0xa8);                        /* mov ax, 0xa8 */
    II(0x00154a74, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x00154a76, 0x5)   mov(memw_a16(ss, bp - 0x4), 0xffff);  /* mov word [bp-0x4], 0xffff */
    II(0x00154a7b, 0x5)   mov(memw_a16(ss, bp - 0x2), 0xffff);  /* mov word [bp-0x2], 0xffff */
    II(0x00154a80, 0x3)   lea(ax, bp - 0xc);                    /* lea ax, [bp-0xc] */
    II(0x00154a83, 0x1)   pushw(ss);                            /* push ss */
    II(0x00154a84, 0x1)   pushw(ax);                            /* push ax */
    II(0x00154a85, 0x3)   pushw(memw_a16(ss, bp + 0x8));        /* push word [bp+0x8] */
//    II(0x00154a88, 0x1)   nop();                                /* nop  */
    II(0x00154a89, 0x1)   pushw(cs);                            /* push cs */
    II(0x00154a8a, 0x3)   callw(0x00154412, -0x67b);            /* call 0x154412 */
    II(0x00154a8d, 0x3)   add(sp, 0x6);                         /* add sp, 0x6 */
    II(0x00154a90, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x00154a92, 0x2)   jzw(0x00154ab3, 0x1f);                /* jz 0x154ab3 */
    II(0x00154a94, 0x3)   mov(ax, memw_a16(ss, bp - 0x6));      /* mov ax, [bp-0x6] */
    II(0x00154a97, 0x2)   sub(al, al);                          /* sub al, al */
    II(0x00154a99, 0x2)   mov(dx, ax);                          /* mov dx, ax */
    II(0x00154a9b, 0x3)   mov(cx, memw_a16(ss, bp - 0xa));      /* mov cx, [bp-0xa] */
    II(0x00154a9e, 0x3)   mov(bx, memw_a16(ss, bp - 0x8));      /* mov bx, [bp-0x8] */
    II(0x00154aa1, 0x2)   sub(bh, bh);                          /* sub bh, bh */
    II(0x00154aa3, 0x2)   mov(ax, cx);                          /* mov ax, cx */
    II(0x00154aa5, 0x2)   or_(dx, bx);                          /* or dx, bx */
    II(0x00154aa7, 0x3)   add(ax, memw_a16(ss, bp + 0x6));      /* add ax, [bp+0x6] */
    II(0x00154aaa, 0x3)   adc(dx, 0);                           /* adc dx, 0x0 */
    II(0x00154aad, 0x3)   mov(memw_a16(ss, bp - 0x4), ax);      /* mov [bp-0x4], ax */
    II(0x00154ab0, 0x3)   mov(memw_a16(ss, bp - 0x2), dx);      /* mov [bp-0x2], dx */
l_0x00154ab3:
    II(0x00154ab3, 0x3)   mov(ax, memw_a16(ss, bp - 0x4));      /* mov ax, [bp-0x4] */
    II(0x00154ab6, 0x3)   mov(dx, memw_a16(ss, bp - 0x2));      /* mov dx, [bp-0x2] */
    II(0x00154ab9, 0x1)   popw(ds);                             /* pop ds */
    II(0x00154aba, 0x1)   leavew();                             /* leave  */
    II(0x00154abb, 0x1)   retfw();                              /* retf  */
FUNC_END

