FUNC_BEGIN(0x00158277, 0x80aa8d3e66b70a0c, 0x10, ({0xc8, 0, 0, 0, 0x57, 0x56, 0x90, 0xe, 0xe8, 0x98, 0xff, 0x3d, 0, 0, 0x74, 0x3, 0xe9, 0x68, 0, 0xc4, 0x5e, 0x6, 0x26, 0x83, 0x7f, 0x2c, 0x3, 0x74, 0x3, 0xe9, 0x6, 0, 0xb8, 0x1, 0, 0xe9, 0x68, 0, 0xc4, 0x5e, 0x6, 0x26, 0x83, 0x7f, 0x2c, 0x1, 0x74, 0x3, 0xe9, 0x42, 0, 0x6a, 0x2, 0x1e, 0x68, 0xa4, 0x48, 0xc4, 0x5e, 0x6, 0x26, 0xff, 0x77, 0x36, 0xc4, 0x5e, 0x6, 0x26, 0x8b, 0x47, 0x32, 0x26, 0x8b, 0x57, 0x34, 0x2d, 0x2, 0, 0x83, 0xda, 0, 0x52, 0x50, 0x9a, 0x34, 0x15, 0x80, 0, 0x83, 0xc4, 0xc, 0x81, 0x3e, 0xa4, 0x48, 0xcd, 0x1, 0x74, 0x3, 0xe9, 0x6, 0, 0xb8, 0x1, 0, 0xe9, 0x3, 0, 0xb8, 0, 0, 0xe9, 0x1c, 0, 0xe9, 0x6, 0, 0xb8, 0, 0, 0xe9, 0x13, 0, 0xff, 0x76, 0x8, 0xff, 0x76, 0x6, 0xff, 0x1e, 0xd4, 0x16, 0x83, 0xc4, 0x4, 0xb8, 0x1, 0, 0xe9, 0, 0, 0x5e, 0x5f, 0xc9, 0xcb}))
    II(0x00158277, 0x4)   enterw(0, 0);                         /* enter 0x0, 0x0 */
    II(0x0015827b, 0x1)   pushw(di);                            /* push di */
    II(0x0015827c, 0x1)   pushw(si);                            /* push si */
//    II(0x0015827d, 0x1)   nop();                                /* nop  */
    II(0x0015827e, 0x1)   pushw(cs);                            /* push cs */
    II(0x0015827f, 0x3)   callw(0x0015821a, -0x68);             /* call 0x15821a */
    II(0x00158282, 0x3)   cmp(ax, 0);                           /* cmp ax, 0x0 */
    II(0x00158285, 0x2)   jzw(0x0015828a, 0x3);                 /* jz 0x15828a */
    II(0x00158287, 0x3)   jmpw(0x001582f2, 0x68);               /* jmp 0x1582f2 */
l_0x0015828a:
    II(0x0015828a, 0x3)   les(bx, ss, bp + 0x6);                /* les bx, [bp+0x6] */
    II(0x0015828d, 0x5)   cmp(memw_a16(es, bx + 0x2c), 0x3);    /* cmp word [es:bx+0x2c], 0x3 */
    II(0x00158292, 0x2)   jzw(0x00158297, 0x3);                 /* jz 0x158297 */
    II(0x00158294, 0x3)   jmpw(0x0015829d, 0x6);                /* jmp 0x15829d */
l_0x00158297:
    II(0x00158297, 0x3)   mov(ax, 0x1);                         /* mov ax, 0x1 */
    II(0x0015829a, 0x3)   jmpw(0x00158305, 0x68);               /* jmp 0x158305 */
l_0x0015829d:
    II(0x0015829d, 0x3)   les(bx, ss, bp + 0x6);                /* les bx, [bp+0x6] */
    II(0x001582a0, 0x5)   cmp(memw_a16(es, bx + 0x2c), 0x1);    /* cmp word [es:bx+0x2c], 0x1 */
    II(0x001582a5, 0x2)   jzw(0x001582aa, 0x3);                 /* jz 0x1582aa */
    II(0x001582a7, 0x3)   jmpw(0x001582ec, 0x42);               /* jmp 0x1582ec */
l_0x001582aa:
    II(0x001582aa, 0x2)   pushw(0x2);                           /* push 0x2 */
    II(0x001582ac, 0x1)   pushw(ds);                            /* push ds */
    II(0x001582ad, 0x3)   pushw(0x48a4);                        /* push word 0x48a4 */
    II(0x001582b0, 0x3)   les(bx, ss, bp + 0x6);                /* les bx, [bp+0x6] */
    II(0x001582b3, 0x4)   pushw(memw_a16(es, bx + 0x36));       /* push word [es:bx+0x36] */
    II(0x001582b7, 0x3)   les(bx, ss, bp + 0x6);                /* les bx, [bp+0x6] */
    II(0x001582ba, 0x4)   mov(ax, memw_a16(es, bx + 0x32));     /* mov ax, [es:bx+0x32] */
    II(0x001582be, 0x4)   mov(dx, memw_a16(es, bx + 0x34));     /* mov dx, [es:bx+0x34] */
    II(0x001582c2, 0x3)   sub(ax, 0x2);                         /* sub ax, 0x2 */
    II(0x001582c5, 0x3)   sbb(dx, 0);                           /* sbb dx, 0x0 */
    II(0x001582c8, 0x1)   pushw(dx);                            /* push dx */
    II(0x001582c9, 0x1)   pushw(ax);                            /* push ax */
    II(0x001582ca, 0x5)   callw_far_abs(0x80, 0x1534);          /* call word 0x80:0x1534 */
    II(0x001582cf, 0x3)   add(sp, 0xc);                         /* add sp, 0xc */
    II(0x001582d2, 0x6)   cmp(memw_a16(ds, 0x48a4), 0x1cd);     /* cmp word [0x48a4], 0x1cd */
    II(0x001582d8, 0x2)   jzw(0x001582dd, 0x3);                 /* jz 0x1582dd */
    II(0x001582da, 0x3)   jmpw(0x001582e3, 0x6);                /* jmp 0x1582e3 */
l_0x001582dd:
    II(0x001582dd, 0x3)   mov(ax, 0x1);                         /* mov ax, 0x1 */
    II(0x001582e0, 0x3)   jmpw(0x001582e6, 0x3);                /* jmp 0x1582e6 */
l_0x001582e3:
    II(0x001582e3, 0x3)   mov(ax, 0);                           /* mov ax, 0x0 */
l_0x001582e6:
    II(0x001582e6, 0x3)   jmpw(0x00158305, 0x1c);               /* jmp 0x158305 */
//    II(0x001582e9, 0x3)   /* Недостижимый код. */
l_0x001582ec:
    II(0x001582ec, 0x3)   mov(ax, 0);                           /* mov ax, 0x0 */
    II(0x001582ef, 0x3)   jmpw(0x00158305, 0x13);               /* jmp 0x158305 */
l_0x001582f2:
    II(0x001582f2, 0x3)   pushw(memw_a16(ss, bp + 0x8));        /* push word [bp+0x8] */
    II(0x001582f5, 0x3)   pushw(memw_a16(ss, bp + 0x6));        /* push word [bp+0x6] */
    II(0x001582f8, 0x4)   callw_a16_far_ind(ds, 0x16d4);        /* call word far [0x16d4] */
    II(0x001582fc, 0x3)   add(sp, 0x4);                         /* add sp, 0x4 */
    II(0x001582ff, 0x3)   mov(ax, 0x1);                         /* mov ax, 0x1 */
    II(0x00158302, 0x3)   jmpw(0x00158305, 0);                  /* jmp 0x158305 */
l_0x00158305:
    II(0x00158305, 0x1)   popw(si);                             /* pop si */
    II(0x00158306, 0x1)   popw(di);                             /* pop di */
    II(0x00158307, 0x1)   leavew();                             /* leave  */
    II(0x00158308, 0x1)   retfw();                              /* retf  */
FUNC_END

