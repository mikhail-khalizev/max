FUNC_BEGIN(0x0000851a, 0x33f1a1bfe3ecef51, 0x10, ({0xc8, 0x16, 0, 0, 0x6a, 0x12, 0x8d, 0x46, 0xea, 0x50, 0x6a, 0x10, 0x6a, 0, 0xe8, 0xb2, 0xc2, 0x83, 0xc4, 0x8, 0x68, 0xf4, 0xe, 0x8d, 0x46, 0xea, 0x50, 0xe8, 0x15, 0xca, 0x5b, 0x5b, 0xb, 0xc0, 0x74, 0x31, 0x6a, 0x4, 0x8d, 0x46, 0xfc, 0x50, 0x6a, 0x10, 0x6a, 0x32, 0xe8, 0x92, 0xc2, 0x83, 0xc4, 0x8, 0x8b, 0x46, 0xfc, 0x2b, 0x46, 0xfe, 0x80, 0xc4, 0x4, 0x2b, 0xd2, 0x5, 0x1, 0, 0x13, 0xd2, 0xb1, 0x6, 0xe8, 0x31, 0xd8, 0xa3, 0x98, 0, 0x89, 0x16, 0x9a, 0, 0xb8, 0x1, 0, 0xc9, 0xc3, 0x2b, 0xc0, 0xc9, 0xc3}))
    II(0x0000851a, 0x4)   enterw(0x16, 0);                      /* enter 0x16, 0x0 */
    II(0x0000851e, 0x2)   pushw(0x12);                          /* push 0x12 */
    II(0x00008520, 0x3)   lea(ax, bp - 0x16);                   /* lea ax, [bp-0x16] */
    II(0x00008523, 0x1)   pushw(ax);                            /* push ax */
    II(0x00008524, 0x2)   pushw(0x10);                          /* push 0x10 */
    II(0x00008526, 0x2)   pushw(0);                             /* push 0x0 */
    II(0x00008528, 0x3)   callw(0x000047dd, -0x3d4e);           /* call 0x47dd */
    II(0x0000852b, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
    II(0x0000852e, 0x3)   pushw(0xef4);                         /* push word 0xef4 */
    II(0x00008531, 0x3)   lea(ax, bp - 0x16);                   /* lea ax, [bp-0x16] */
    II(0x00008534, 0x1)   pushw(ax);                            /* push ax */
    II(0x00008535, 0x3)   callw(0x00004f4d, -0x35eb);           /* call 0x4f4d */
    II(0x00008538, 0x1)   popw(bx);                             /* pop bx */
    II(0x00008539, 0x1)   popw(bx);                             /* pop bx */
    II(0x0000853a, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x0000853c, 0x2)   jzw(0x0000856f, 0x31);                /* jz 0x856f */
    II(0x0000853e, 0x2)   pushw(0x4);                           /* push 0x4 */
    II(0x00008540, 0x3)   lea(ax, bp - 0x4);                    /* lea ax, [bp-0x4] */
    II(0x00008543, 0x1)   pushw(ax);                            /* push ax */
    II(0x00008544, 0x2)   pushw(0x10);                          /* push 0x10 */
    II(0x00008546, 0x2)   pushw(0x32);                          /* push 0x32 */
    II(0x00008548, 0x3)   callw(0x000047dd, -0x3d6e);           /* call 0x47dd */
    II(0x0000854b, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
    II(0x0000854e, 0x3)   mov(ax, memw_a16(ss, bp - 0x4));      /* mov ax, [bp-0x4] */
    II(0x00008551, 0x3)   sub(ax, memw_a16(ss, bp - 0x2));      /* sub ax, [bp-0x2] */
    II(0x00008554, 0x3)   add(ah, 0x4);                         /* add ah, 0x4 */
    II(0x00008557, 0x2)   sub(dx, dx);                          /* sub dx, dx */
    II(0x00008559, 0x3)   add(ax, 0x1);                         /* add ax, 0x1 */
    II(0x0000855c, 0x2)   adc(dx, dx);                          /* adc dx, dx */
    II(0x0000855e, 0x2)   mov(cl, 0x6);                         /* mov cl, 0x6 */
    II(0x00008560, 0x3)   callw(0x00005d94, -0x27cf);           /* call 0x5d94 */
    II(0x00008563, 0x3)   mov(memw_a16(ds, 0x98), ax);          /* mov [0x98], ax */
    II(0x00008566, 0x4)   mov(memw_a16(ds, 0x9a), dx);          /* mov [0x9a], dx */
    II(0x0000856a, 0x3)   mov(ax, 0x1);                         /* mov ax, 0x1 */
    II(0x0000856d, 0x1)   leavew();                             /* leave  */
    II(0x0000856e, 0x1)   retw();                               /* ret  */
l_0x0000856f:
    II(0x0000856f, 0x2)   sub(ax, ax);                          /* sub ax, ax */
    II(0x00008571, 0x1)   leavew();                             /* leave  */
    II(0x00008572, 0x1)   retw();                               /* ret  */
FUNC_END

