FUNC_BEGIN(0x0013effa, 0x88762f2a83d09380, 0x10, ({0xc8, 0x1c, 0, 0, 0x57, 0x56, 0x1e, 0xb8, 0x68, 0x3e, 0x8e, 0xd8, 0x90, 0xe, 0xe8, 0x29, 0x1, 0xb, 0xc0, 0x74, 0x1f, 0x8b, 0x46, 0x8, 0x89, 0x46, 0xf0, 0xff, 0x76, 0xa, 0x6a, 0, 0x8d, 0x46, 0xec, 0x16, 0x50, 0xff, 0x76, 0x6, 0x6a, 0xb, 0x90, 0xe, 0xe8, 0x6f, 0xfb, 0x83, 0xc4, 0xc, 0xeb, 0x36, 0xa1, 0x12, 0x14, 0x89, 0x46, 0xe6, 0xc7, 0x46, 0xe4, 0, 0, 0x8b, 0x46, 0x6, 0x24, 0xf8, 0x3, 0x46, 0xe4, 0x8b, 0x56, 0xe6, 0x89, 0x46, 0xe8, 0x89, 0x56, 0xea, 0xc4, 0x5e, 0x8, 0x8b, 0xfb, 0x8b, 0xf0, 0x1e, 0x8e, 0xda, 0xa5, 0xa5, 0xa5, 0xa5, 0x1f, 0xc4, 0x5e, 0xe8, 0x26, 0x80, 0x7f, 0x5, 0x1, 0x1b, 0xc0, 0x40, 0x89, 0x46, 0x6, 0x1f, 0x5e, 0x5f, 0xc9, 0xcb}))
    II(0x0013effa, 0x4)   enterw(0x1c, 0);                      /* enter 0x1c, 0x0 */
    II(0x0013effe, 0x1)   pushw(di);                            /* push di */
    II(0x0013efff, 0x1)   pushw(si);                            /* push si */
    II(0x0013f000, 0x1)   pushw(ds);                            /* push ds */
    II(0x0013f001, 0x3)   mov(ax, 0x3e68);                      /* mov ax, 0x3e68 */
    II(0x0013f004, 0x2)   mov(ds, ax);                          /* mov ds, ax */
//    II(0x0013f006, 0x1)   nop();                                /* nop  */
    II(0x0013f007, 0x1)   pushw(cs);                            /* push cs */
    II(0x0013f008, 0x3)   callw(0x0013f134, 0x129);             /* call 0x13f134 */
    II(0x0013f00b, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x0013f00d, 0x2)   jzw(0x0013f02e, 0x1f);                /* jz 0x13f02e */
    II(0x0013f00f, 0x3)   mov(ax, memw_a16(ss, bp + 0x8));      /* mov ax, [bp+0x8] */
    II(0x0013f012, 0x3)   mov(memw_a16(ss, bp - 0x10), ax);     /* mov [bp-0x10], ax */
    II(0x0013f015, 0x3)   pushw(memw_a16(ss, bp + 0xa));        /* push word [bp+0xa] */
    II(0x0013f018, 0x2)   pushw(0);                             /* push 0x0 */
    II(0x0013f01a, 0x3)   lea(ax, bp - 0x14);                   /* lea ax, [bp-0x14] */
    II(0x0013f01d, 0x1)   pushw(ss);                            /* push ss */
    II(0x0013f01e, 0x1)   pushw(ax);                            /* push ax */
    II(0x0013f01f, 0x3)   pushw(memw_a16(ss, bp + 0x6));        /* push word [bp+0x6] */
    II(0x0013f022, 0x2)   pushw(0xb);                           /* push 0xb */
//    II(0x0013f024, 0x1)   nop();                                /* nop  */
    II(0x0013f025, 0x1)   pushw(cs);                            /* push cs */
    II(0x0013f026, 0x3)   callw(0x0013eb98, -0x491);            /* call 0x13eb98 */
    II(0x0013f029, 0x3)   add(sp, 0xc);                         /* add sp, 0xc */
    II(0x0013f02c, 0x2)   jmpw(0x0013f064, 0x36);               /* jmp 0x13f064 */
l_0x0013f02e:
    II(0x0013f02e, 0x3)   mov(ax, memw_a16(ds, 0x1412));        /* mov ax, [0x1412] */
    II(0x0013f031, 0x3)   mov(memw_a16(ss, bp - 0x1a), ax);     /* mov [bp-0x1a], ax */
    II(0x0013f034, 0x5)   mov(memw_a16(ss, bp - 0x1c), 0);      /* mov word [bp-0x1c], 0x0 */
    II(0x0013f039, 0x3)   mov(ax, memw_a16(ss, bp + 0x6));      /* mov ax, [bp+0x6] */
    II(0x0013f03c, 0x2)   and_(al, 0xf8);                       /* and al, 0xf8 */
    II(0x0013f03e, 0x3)   add(ax, memw_a16(ss, bp - 0x1c));     /* add ax, [bp-0x1c] */
    II(0x0013f041, 0x3)   mov(dx, memw_a16(ss, bp - 0x1a));     /* mov dx, [bp-0x1a] */
    II(0x0013f044, 0x3)   mov(memw_a16(ss, bp - 0x18), ax);     /* mov [bp-0x18], ax */
    II(0x0013f047, 0x3)   mov(memw_a16(ss, bp - 0x16), dx);     /* mov [bp-0x16], dx */
    II(0x0013f04a, 0x3)   les(bx, ss, bp + 0x8);                /* les bx, [bp+0x8] */
    II(0x0013f04d, 0x2)   mov(di, bx);                          /* mov di, bx */
    II(0x0013f04f, 0x2)   mov(si, ax);                          /* mov si, ax */
    II(0x0013f051, 0x1)   pushw(ds);                            /* push ds */
    II(0x0013f052, 0x2)   mov(ds, dx);                          /* mov ds, dx */
    II(0x0013f054, 0x1)   movsw_a16();                          /* movsw  */
    II(0x0013f055, 0x1)   movsw_a16();                          /* movsw  */
    II(0x0013f056, 0x1)   movsw_a16();                          /* movsw  */
    II(0x0013f057, 0x1)   movsw_a16();                          /* movsw  */
    II(0x0013f058, 0x1)   popw(ds);                             /* pop ds */
    II(0x0013f059, 0x3)   les(bx, ss, bp - 0x18);               /* les bx, [bp-0x18] */
    II(0x0013f05c, 0x5)   cmp(memb_a16(es, bx + 0x5), 0x1);     /* cmp byte [es:bx+0x5], 0x1 */
    II(0x0013f061, 0x2)   sbb(ax, ax);                          /* sbb ax, ax */
    II(0x0013f063, 0x1)   inc(ax);                              /* inc ax */
l_0x0013f064:
    II(0x0013f064, 0x3)   mov(memw_a16(ss, bp + 0x6), ax);      /* mov [bp+0x6], ax */
    II(0x0013f067, 0x1)   popw(ds);                             /* pop ds */
    II(0x0013f068, 0x1)   popw(si);                             /* pop si */
    II(0x0013f069, 0x1)   popw(di);                             /* pop di */
    II(0x0013f06a, 0x1)   leavew();                             /* leave  */
    II(0x0013f06b, 0x1)   retfw();                              /* retf  */
FUNC_END

