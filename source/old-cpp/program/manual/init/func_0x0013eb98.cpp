FUNC_BEGIN(0x0013eb98, 0x2d0aefc3986c862, 0x10, ({0x55, 0x8b, 0xec, 0x53, 0x1e, 0xc5, 0x5e, 0xa, 0x8b, 0x46, 0xe, 0x89, 0x7, 0x8b, 0x46, 0x10, 0x89, 0x47, 0x2, 0x1e, 0x53, 0xff, 0x76, 0x8, 0xff, 0x76, 0x6, 0x90, 0xe, 0xe8, 0xac, 0xff, 0x83, 0xc4, 0x8, 0x1f, 0x5b, 0x5d, 0xcb}))
    II(0x0013eb98, 0x1)   pushw(bp);                            /* push bp */
    II(0x0013eb99, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0013eb9b, 0x1)   pushw(bx);                            /* push bx */
    II(0x0013eb9c, 0x1)   pushw(ds);                            /* push ds */
    II(0x0013eb9d, 0x3)   lds(bx, ss, bp + 0xa);                /* lds bx, [bp+0xa] */
    II(0x0013eba0, 0x3)   mov(ax, memw_a16(ss, bp + 0xe));      /* mov ax, [bp+0xe] */
    II(0x0013eba3, 0x2)   mov(memw_a16(ds, bx), ax);            /* mov [bx], ax */
    II(0x0013eba5, 0x3)   mov(ax, memw_a16(ss, bp + 0x10));     /* mov ax, [bp+0x10] */
    II(0x0013eba8, 0x3)   mov(memw_a16(ds, bx + 0x2), ax);      /* mov [bx+0x2], ax */
    II(0x0013ebab, 0x1)   pushw(ds);                            /* push ds */
    II(0x0013ebac, 0x1)   pushw(bx);                            /* push bx */
    II(0x0013ebad, 0x3)   pushw(memw_a16(ss, bp + 0x8));        /* push word [bp+0x8] */
    II(0x0013ebb0, 0x3)   pushw(memw_a16(ss, bp + 0x6));        /* push word [bp+0x6] */
//    II(0x0013ebb3, 0x1)   nop();                                /* nop  */
    II(0x0013ebb4, 0x1)   pushw(cs);                            /* push cs */
    II(0x0013ebb5, 0x3)   callw(0x0013eb64, -0x54);             /* call 0x13eb64 */
    II(0x0013ebb8, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
    II(0x0013ebbb, 0x1)   popw(ds);                             /* pop ds */
    II(0x0013ebbc, 0x1)   popw(bx);                             /* pop bx */
    II(0x0013ebbd, 0x1)   popw(bp);                             /* pop bp */
    II(0x0013ebbe, 0x1)   retfw();                              /* retf  */
FUNC_END

