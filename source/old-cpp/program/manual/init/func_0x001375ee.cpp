FUNC_BEGIN(0x001375ee, 0xa10cabb39c3a9f59, 0x10, ({0xc8, 0x2, 0, 0, 0x1e, 0xb8, 0x68, 0x3e, 0x8e, 0xd8, 0xc7, 0x46, 0xfe, 0, 0, 0xff, 0x76, 0xc, 0xff, 0x76, 0x8, 0xff, 0x76, 0x6, 0x6a, 0x1, 0x90, 0xe, 0xe8, 0xf, 0x92, 0x48, 0x75, 0x20, 0xc4, 0x5e, 0x6, 0x26, 0x80, 0x3f, 0xa, 0x74, 0x17, 0x26, 0x80, 0x3f, 0x1a, 0x74, 0x11, 0x8b, 0x46, 0xa, 0xff, 0x46, 0xfe, 0x39, 0x46, 0xfe, 0x7f, 0x6, 0xff, 0x46, 0x6, 0xeb, 0xce, 0x90, 0xc4, 0x5e, 0x6, 0x26, 0xc6, 0x7, 0, 0x8b, 0x46, 0xfe, 0x1f, 0xc9, 0xcb}))
    II(0x001375ee, 0x4)   enterw(0x2, 0);                       /* enter 0x2, 0x0 */
    II(0x001375f2, 0x1)   pushw(ds);                            /* push ds */
    II(0x001375f3, 0x3)   mov(ax, 0x3e68);                      /* mov ax, 0x3e68 */
    II(0x001375f6, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x001375f8, 0x5)   mov(memw_a16(ss, bp - 0x2), 0);       /* mov word [bp-0x2], 0x0 */
l_0x001375fd:
    II(0x001375fd, 0x3)   pushw(memw_a16(ss, bp + 0xc));        /* push word [bp+0xc] */
    II(0x00137600, 0x3)   pushw(memw_a16(ss, bp + 0x8));        /* push word [bp+0x8] */
    II(0x00137603, 0x3)   pushw(memw_a16(ss, bp + 0x6));        /* push word [bp+0x6] */
    II(0x00137606, 0x2)   pushw(0x1);                           /* push 0x1 */
//    II(0x00137608, 0x1)   nop();                                /* nop  */
    II(0x00137609, 0x1)   pushw(cs);                            /* push cs */
    II(0x0013760a, 0x3)   callw(0x0013081c, -0x6df1);           /* call 0x13081c */
    II(0x0013760d, 0x1)   dec(ax);                              /* dec ax */
    II(0x0013760e, 0x2)   jnzw(0x00137630, 0x20);               /* jnz 0x137630 */
    II(0x00137610, 0x3)   les(bx, ss, bp + 0x6);                /* les bx, [bp+0x6] */
    II(0x00137613, 0x4)   cmp(memb_a16(es, bx), 0xa);           /* cmp byte [es:bx], 0xa */
    II(0x00137617, 0x2)   jzw(0x00137630, 0x17);                /* jz 0x137630 */
    II(0x00137619, 0x4)   cmp(memb_a16(es, bx), 0x1a);          /* cmp byte [es:bx], 0x1a */
    II(0x0013761d, 0x2)   jzw(0x00137630, 0x11);                /* jz 0x137630 */
    II(0x0013761f, 0x3)   mov(ax, memw_a16(ss, bp + 0xa));      /* mov ax, [bp+0xa] */
    II(0x00137622, 0x3)   inc(memw_a16(ss, bp - 0x2));          /* inc word [bp-0x2] */
    II(0x00137625, 0x3)   cmp(memw_a16(ss, bp - 0x2), ax);      /* cmp [bp-0x2], ax */
    II(0x00137628, 0x2)   jgw(0x00137630, 0x6);                 /* jg 0x137630 */
    II(0x0013762a, 0x3)   inc(memw_a16(ss, bp + 0x6));          /* inc word [bp+0x6] */
    II(0x0013762d, 0x2)   jmpw(0x001375fd, -0x32);              /* jmp 0x1375fd */
//    II(0x0013762f, 0x1)   /* Недостижимый код. */
l_0x00137630:
    II(0x00137630, 0x3)   les(bx, ss, bp + 0x6);                /* les bx, [bp+0x6] */
    II(0x00137633, 0x4)   mov(memb_a16(es, bx), 0);             /* mov byte [es:bx], 0x0 */
    II(0x00137637, 0x3)   mov(ax, memw_a16(ss, bp - 0x2));      /* mov ax, [bp-0x2] */
    II(0x0013763a, 0x1)   popw(ds);                             /* pop ds */
    II(0x0013763b, 0x1)   leavew();                             /* leave  */
    II(0x0013763c, 0x1)   retfw();                              /* retf  */
FUNC_END

