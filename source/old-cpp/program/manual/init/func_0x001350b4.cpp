FUNC_BEGIN(0x001350b4, 0xe5266786996bbf1e, 0x10, ({0x1e, 0xb8, 0x68, 0x3e, 0x8e, 0xd8, 0x6a, 0x68, 0x90, 0xe, 0xe8, 0xe7, 0x96, 0x83, 0xc4, 0x2, 0xa3, 0xf8, 0x1e, 0x89, 0x16, 0xfa, 0x1e, 0x8b, 0xc2, 0xb, 0x6, 0xf8, 0x1e, 0x75, 0x11, 0x1e, 0x68, 0x6c, 0x1, 0x90, 0xe, 0xe8, 0x73, 0xbf, 0x83, 0xc4, 0x4, 0xb8, 0x1, 0, 0x1f, 0xcb, 0x6a, 0x68, 0x52, 0xff, 0x36, 0xf8, 0x1e, 0x90, 0xe, 0xe8, 0xe0, 0x3d, 0x83, 0xc4, 0x6, 0x90, 0xe, 0xe8, 0x88, 0x3d, 0xc4, 0x1e, 0xf8, 0x1e, 0x26, 0x89, 0x47, 0x1c, 0x26, 0x89, 0x57, 0x1e, 0xff, 0x36, 0xfa, 0x1e, 0xe, 0xe8, 0xe4, 0x4, 0x83, 0xc4, 0x2, 0xff, 0x36, 0xfa, 0x1e, 0x90, 0xe, 0xe8, 0x9e, 0x3f, 0x83, 0xc4, 0x2, 0x2b, 0xc0, 0x1f, 0xcb}))
    II(0x001350b4, 0x1)   pushw(ds);                            /* push ds */
    II(0x001350b5, 0x3)   mov(ax, 0x3e68);                      /* mov ax, 0x3e68 */
    II(0x001350b8, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x001350ba, 0x2)   pushw(0x68);                          /* push 0x68 */
//    II(0x001350bc, 0x1)   nop();                                /* nop  */
    II(0x001350bd, 0x1)   pushw(cs);                            /* push cs */
    II(0x001350be, 0x3)   callw(0x0012e7a8, -0x6919);           /* call 0x12e7a8 */
    II(0x001350c1, 0x3)   add(sp, 0x2);                         /* add sp, 0x2 */
    II(0x001350c4, 0x3)   mov(memw_a16(ds, 0x1ef8), ax);        /* mov [0x1ef8], ax */
    II(0x001350c7, 0x4)   mov(memw_a16(ds, 0x1efa), dx);        /* mov [0x1efa], dx */
    II(0x001350cb, 0x2)   mov(ax, dx);                          /* mov ax, dx */
    II(0x001350cd, 0x4)   or_(ax, memw_a16(ds, 0x1ef8));        /* or ax, [0x1ef8] */
    II(0x001350d1, 0x2)   jnzw(0x001350e4, 0x11);               /* jnz 0x1350e4 */
    II(0x001350d3, 0x1)   pushw(ds);                            /* push ds */
    II(0x001350d4, 0x3)   pushw(0x16c);                         /* push word 0x16c */
//    II(0x001350d7, 0x1)   nop();                                /* nop  */
    II(0x001350d8, 0x1)   pushw(cs);                            /* push cs */
    II(0x001350d9, 0x3)   callw(0x0013104f, -0x408d);           /* call 0x13104f */
    II(0x001350dc, 0x3)   add(sp, 0x4);                         /* add sp, 0x4 */
    II(0x001350df, 0x3)   mov(ax, 0x1);                         /* mov ax, 0x1 */
    II(0x001350e2, 0x1)   popw(ds);                             /* pop ds */
    II(0x001350e3, 0x1)   retfw();                              /* retf  */
l_0x001350e4:
    II(0x001350e4, 0x2)   pushw(0x68);                          /* push 0x68 */
    II(0x001350e6, 0x1)   pushw(dx);                            /* push dx */
    II(0x001350e7, 0x4)   pushw(memw_a16(ds, 0x1ef8));          /* push word [0x1ef8] */
//    II(0x001350eb, 0x1)   nop();                                /* nop  */
    II(0x001350ec, 0x1)   pushw(cs);                            /* push cs */
    II(0x001350ed, 0x3)   callw(0x00138ed0, 0x3de0);            /* call 0x138ed0 */
    II(0x001350f0, 0x3)   add(sp, 0x6);                         /* add sp, 0x6 */
//    II(0x001350f3, 0x1)   nop();                                /* nop  */
    II(0x001350f4, 0x1)   pushw(cs);                            /* push cs */
    II(0x001350f5, 0x3)   callw(0x00138e80, 0x3d88);            /* call 0x138e80 */
    II(0x001350f8, 0x4)   les(bx, ds, 0x1ef8);                  /* les bx, [0x1ef8] */
    II(0x001350fc, 0x4)   mov(memw_a16(es, bx + 0x1c), ax);     /* mov [es:bx+0x1c], ax */
    II(0x00135100, 0x4)   mov(memw_a16(es, bx + 0x1e), dx);     /* mov [es:bx+0x1e], dx */
    II(0x00135104, 0x4)   pushw(memw_a16(ds, 0x1efa));          /* push word [0x1efa] */
    II(0x00135108, 0x1)   pushw(cs);                            /* push cs */
    II(0x00135109, 0x3)   callw(0x001355f0, 0x4e4);             /* call 0x1355f0 */
    II(0x0013510c, 0x3)   add(sp, 0x2);                         /* add sp, 0x2 */
    II(0x0013510f, 0x4)   pushw(memw_a16(ds, 0x1efa));          /* push word [0x1efa] */
//    II(0x00135113, 0x1)   nop();                                /* nop  */
    II(0x00135114, 0x1)   pushw(cs);                            /* push cs */
    II(0x00135115, 0x3)   callw(0x001390b6, 0x3f9e);            /* call 0x1390b6 */
    II(0x00135118, 0x3)   add(sp, 0x2);                         /* add sp, 0x2 */
    II(0x0013511b, 0x2)   sub(ax, ax);                          /* sub ax, ax */
    II(0x0013511d, 0x1)   popw(ds);                             /* pop ds */
    II(0x0013511e, 0x1)   retfw();                              /* retf  */
FUNC_END

