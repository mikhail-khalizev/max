FUNC_BEGIN(0x0013e91a, 0x81a3a023e49da676, 0x10, ({0xc8, 0xc, 0, 0, 0x1e, 0xb8, 0x68, 0x3e, 0x8e, 0xd8, 0xc7, 0x46, 0xfc, 0xff, 0xff, 0xc7, 0x46, 0xfe, 0xff, 0xff, 0x8d, 0x46, 0xf4, 0x16, 0x50, 0xff, 0x76, 0x8, 0x90, 0xe, 0xe8, 0xbf, 0x6, 0x83, 0xc4, 0x6, 0xb, 0xc0, 0x74, 0x1f, 0x8b, 0x46, 0xfa, 0x2a, 0xc0, 0x8b, 0xd0, 0x8b, 0x4e, 0xf6, 0x8b, 0x5e, 0xf8, 0x2a, 0xff, 0x8b, 0xc1, 0xb, 0xd3, 0x3, 0x46, 0x6, 0x83, 0xd2, 0, 0x89, 0x46, 0xfc, 0x89, 0x56, 0xfe, 0x8b, 0x46, 0xfc, 0x8b, 0x56, 0xfe, 0x1f, 0xc9, 0xcb}))
    II(0x0013e91a, 0x4)   enterw(0xc, 0);                       /* enter 0xc, 0x0 */
    II(0x0013e91e, 0x1)   pushw(ds);                            /* push ds */
    II(0x0013e91f, 0x3)   mov(ax, 0x3e68);                      /* mov ax, 0x3e68 */
    II(0x0013e922, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x0013e924, 0x5)   mov(memw_a16(ss, bp - 0x4), 0xffff);  /* mov word [bp-0x4], 0xffff */
    II(0x0013e929, 0x5)   mov(memw_a16(ss, bp - 0x2), 0xffff);  /* mov word [bp-0x2], 0xffff */
    II(0x0013e92e, 0x3)   lea(ax, bp - 0xc);                    /* lea ax, [bp-0xc] */
    II(0x0013e931, 0x1)   pushw(ss);                            /* push ss */
    II(0x0013e932, 0x1)   pushw(ax);                            /* push ax */
    II(0x0013e933, 0x3)   pushw(memw_a16(ss, bp + 0x8));        /* push word [bp+0x8] */
//    II(0x0013e936, 0x1)   nop();                                /* nop  */
    II(0x0013e937, 0x1)   pushw(cs);                            /* push cs */
    II(0x0013e938, 0x3)   callw(0x0013effa, 0x6bf);             /* call 0x13effa */
    II(0x0013e93b, 0x3)   add(sp, 0x6);                         /* add sp, 0x6 */
    II(0x0013e93e, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x0013e940, 0x2)   jzw(0x0013e961, 0x1f);                /* jz 0x13e961 */
    II(0x0013e942, 0x3)   mov(ax, memw_a16(ss, bp - 0x6));      /* mov ax, [bp-0x6] */
    II(0x0013e945, 0x2)   sub(al, al);                          /* sub al, al */
    II(0x0013e947, 0x2)   mov(dx, ax);                          /* mov dx, ax */
    II(0x0013e949, 0x3)   mov(cx, memw_a16(ss, bp - 0xa));      /* mov cx, [bp-0xa] */
    II(0x0013e94c, 0x3)   mov(bx, memw_a16(ss, bp - 0x8));      /* mov bx, [bp-0x8] */
    II(0x0013e94f, 0x2)   sub(bh, bh);                          /* sub bh, bh */
    II(0x0013e951, 0x2)   mov(ax, cx);                          /* mov ax, cx */
    II(0x0013e953, 0x2)   or_(dx, bx);                          /* or dx, bx */
    II(0x0013e955, 0x3)   add(ax, memw_a16(ss, bp + 0x6));      /* add ax, [bp+0x6] */
    II(0x0013e958, 0x3)   adc(dx, 0);                           /* adc dx, 0x0 */
    II(0x0013e95b, 0x3)   mov(memw_a16(ss, bp - 0x4), ax);      /* mov [bp-0x4], ax */
    II(0x0013e95e, 0x3)   mov(memw_a16(ss, bp - 0x2), dx);      /* mov [bp-0x2], dx */
l_0x0013e961:
    II(0x0013e961, 0x3)   mov(ax, memw_a16(ss, bp - 0x4));      /* mov ax, [bp-0x4] */
    II(0x0013e964, 0x3)   mov(dx, memw_a16(ss, bp - 0x2));      /* mov dx, [bp-0x2] */
    II(0x0013e967, 0x1)   popw(ds);                             /* pop ds */
    II(0x0013e968, 0x1)   leavew();                             /* leave  */
    II(0x0013e969, 0x1)   retfw();                              /* retf  */
FUNC_END

