FUNC_BEGIN(0x00155030, 0xacd8ab1f8528769c, 0x10, ({0xc8, 0x4, 0, 0, 0x1e, 0xb8, 0xa8, 0, 0x8e, 0xd8, 0x8e, 0x6, 0xe8, 0x3f, 0x26, 0xa1, 0x78, 0x3b, 0x2b, 0xdb, 0x8e, 0xc0, 0x26, 0x8b, 0x47, 0x42, 0x26, 0x8b, 0x57, 0x44, 0x89, 0x46, 0xfc, 0x89, 0x56, 0xfe, 0x8b, 0xc2, 0xb, 0x46, 0xfc, 0x74, 0x31, 0xc4, 0x5e, 0xfc, 0x26, 0xff, 0x77, 0x6, 0x26, 0xff, 0x77, 0x4, 0xff, 0x76, 0x8, 0xff, 0x76, 0x6, 0xe, 0xe8, 0xf8, 0xfd, 0x83, 0xc4, 0x8, 0xb, 0xc0, 0x74, 0x9, 0x8b, 0x46, 0xfc, 0x8b, 0x56, 0xfe, 0x1f, 0xc9, 0xcb, 0xc4, 0x5e, 0xfc, 0x26, 0x8b, 0x7, 0x26, 0x8b, 0x57, 0x2, 0xeb, 0xc2, 0x2b, 0xc0, 0x99, 0x1f, 0xc9, 0xcb}))
    II(0x00155030, 0x4)   enterw(0x4, 0);                       /* enter 0x4, 0x0 */
    II(0x00155034, 0x1)   pushw(ds);                            /* push ds */
    II(0x00155035, 0x3)   mov(ax, 0xa8);                        /* mov ax, 0xa8 */
    II(0x00155038, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x0015503a, 0x4)   mov(es, memw_a16(ds, 0x3fe8));        /* mov es, [0x3fe8] */
    II(0x0015503e, 0x4)   mov(ax, memw_a16(es, 0x3b78));        /* mov ax, [es:0x3b78] */
    II(0x00155042, 0x2)   sub(bx, bx);                          /* sub bx, bx */
    II(0x00155044, 0x2)   mov(es, ax);                          /* mov es, ax */
    II(0x00155046, 0x4)   mov(ax, memw_a16(es, bx + 0x42));     /* mov ax, [es:bx+0x42] */
    II(0x0015504a, 0x4)   mov(dx, memw_a16(es, bx + 0x44));     /* mov dx, [es:bx+0x44] */
l_0x0015504e:
    II(0x0015504e, 0x3)   mov(memw_a16(ss, bp - 0x4), ax);      /* mov [bp-0x4], ax */
    II(0x00155051, 0x3)   mov(memw_a16(ss, bp - 0x2), dx);      /* mov [bp-0x2], dx */
    II(0x00155054, 0x2)   mov(ax, dx);                          /* mov ax, dx */
    II(0x00155056, 0x3)   or_(ax, memw_a16(ss, bp - 0x4));      /* or ax, [bp-0x4] */
    II(0x00155059, 0x2)   jzw(0x0015508c, 0x31);                /* jz 0x15508c */
    II(0x0015505b, 0x3)   les(bx, ss, bp - 0x4);                /* les bx, [bp-0x4] */
    II(0x0015505e, 0x4)   pushw(memw_a16(es, bx + 0x6));        /* push word [es:bx+0x6] */
    II(0x00155062, 0x4)   pushw(memw_a16(es, bx + 0x4));        /* push word [es:bx+0x4] */
    II(0x00155066, 0x3)   pushw(memw_a16(ss, bp + 0x8));        /* push word [bp+0x8] */
    II(0x00155069, 0x3)   pushw(memw_a16(ss, bp + 0x6));        /* push word [bp+0x6] */
    II(0x0015506c, 0x1)   pushw(cs);                            /* push cs */
    II(0x0015506d, 0x3)   callw(0x00154e68, -0x208);            /* call 0x154e68 */
    II(0x00155070, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
    II(0x00155073, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x00155075, 0x2)   jzw(0x00155080, 0x9);                 /* jz 0x155080 */
    II(0x00155077, 0x3)   mov(ax, memw_a16(ss, bp - 0x4));      /* mov ax, [bp-0x4] */
    II(0x0015507a, 0x3)   mov(dx, memw_a16(ss, bp - 0x2));      /* mov dx, [bp-0x2] */
    II(0x0015507d, 0x1)   popw(ds);                             /* pop ds */
    II(0x0015507e, 0x1)   leavew();                             /* leave  */
    II(0x0015507f, 0x1)   retfw();                              /* retf  */
l_0x00155080:
    II(0x00155080, 0x3)   les(bx, ss, bp - 0x4);                /* les bx, [bp-0x4] */
    II(0x00155083, 0x3)   mov(ax, memw_a16(es, bx));            /* mov ax, [es:bx] */
    II(0x00155086, 0x4)   mov(dx, memw_a16(es, bx + 0x2));      /* mov dx, [es:bx+0x2] */
    II(0x0015508a, 0x2)   jmpw(0x0015504e, -0x3e);              /* jmp 0x15504e */
l_0x0015508c:
    II(0x0015508c, 0x2)   sub(ax, ax);                          /* sub ax, ax */
    II(0x0015508e, 0x1)   cwd();                                /* cwd  */
    II(0x0015508f, 0x1)   popw(ds);                             /* pop ds */
    II(0x00155090, 0x1)   leavew();                             /* leave  */
    II(0x00155091, 0x1)   retfw();                              /* retf  */
FUNC_END

