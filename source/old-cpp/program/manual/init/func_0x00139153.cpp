FUNC_BEGIN(0x00139153, 0x483b4858ec326537, 0x10, ({0x55, 0x8b, 0xec, 0x53, 0x51, 0x52, 0x8b, 0x5e, 0x6, 0x8b, 0x56, 0x8, 0x8b, 0x4e, 0xa, 0xb8, 0, 0x42, 0xff, 0x1e, 0xe0, 0x1f, 0xf, 0x82, 0x2, 0, 0x33, 0xc0, 0x5a, 0x59, 0x5b, 0x5d, 0xfc, 0xcb}))
    II(0x00139153, 0x1)   pushw(bp);                            /* push bp */
    II(0x00139154, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x00139156, 0x1)   pushw(bx);                            /* push bx */
    II(0x00139157, 0x1)   pushw(cx);                            /* push cx */
    II(0x00139158, 0x1)   pushw(dx);                            /* push dx */
    II(0x00139159, 0x3)   mov(bx, memw_a16(ss, bp + 0x6));      /* mov bx, [bp+0x6] */
    II(0x0013915c, 0x3)   mov(dx, memw_a16(ss, bp + 0x8));      /* mov dx, [bp+0x8] */
    II(0x0013915f, 0x3)   mov(cx, memw_a16(ss, bp + 0xa));      /* mov cx, [bp+0xa] */
    II(0x00139162, 0x3)   mov(ax, 0x4200);                      /* mov ax, 0x4200 */
    II(0x00139165, 0x4)   callw_a16_far_ind(ds, 0x1fe0);        /* call word far [0x1fe0] */
    II(0x00139169, 0x4)   jbw(0x0013916f, 0x2);                 /* jb word 0x13916f */
    II(0x0013916d, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
l_0x0013916f:
    II(0x0013916f, 0x1)   popw(dx);                             /* pop dx */
    II(0x00139170, 0x1)   popw(cx);                             /* pop cx */
    II(0x00139171, 0x1)   popw(bx);                             /* pop bx */
    II(0x00139172, 0x1)   popw(bp);                             /* pop bp */
    II(0x00139173, 0x1)   cld();                                /* cld  */
    II(0x00139174, 0x1)   retfw();                              /* retf  */
FUNC_END

