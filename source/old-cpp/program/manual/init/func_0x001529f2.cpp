FUNC_BEGIN(0x001529f2, 0xe57b499bd3392c70, 0x10, ({0x55, 0x8b, 0xec, 0xb8, 0xfc, 0, 0x50, 0xe, 0xe8, 0x90, 0x2, 0x83, 0x3e, 0x4e, 0x3c, 0, 0x74, 0x4, 0xff, 0x1e, 0x4c, 0x3c, 0xb8, 0xff, 0, 0x50, 0xe, 0xe8, 0x7d, 0x2, 0x8b, 0xe5, 0x5d, 0xcb}))
    II(0x001529f2, 0x1)   pushw(bp);                            /* push bp */
    II(0x001529f3, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x001529f5, 0x3)   mov(ax, 0xfc);                        /* mov ax, 0xfc */
    II(0x001529f8, 0x1)   pushw(ax);                            /* push ax */
    II(0x001529f9, 0x1)   pushw(cs);                            /* push cs */
    II(0x001529fa, 0x3)   callw(0x00152c8d, 0x290);             /* call 0x152c8d */
    II(0x001529fd, 0x5)   cmp(memw_a16(ds, 0x3c4e), 0);         /* cmp word [0x3c4e], 0x0 */
    II(0x00152a02, 0x2)   jzw(0x00152a08, 0x4);                 /* jz 0x152a08 */
    II(0x00152a04, 0x4)   callw_a16_far_ind(ds, 0x3c4c);        /* call word far [0x3c4c] */
l_0x00152a08:
    II(0x00152a08, 0x3)   mov(ax, 0xff);                        /* mov ax, 0xff */
    II(0x00152a0b, 0x1)   pushw(ax);                            /* push ax */
    II(0x00152a0c, 0x1)   pushw(cs);                            /* push cs */
    II(0x00152a0d, 0x3)   callw(0x00152c8d, 0x27d);             /* call 0x152c8d */
    II(0x00152a10, 0x2)   mov(sp, bp);                          /* mov sp, bp */
    II(0x00152a12, 0x1)   popw(bp);                             /* pop bp */
    II(0x00152a13, 0x1)   retfw();                              /* retf  */
FUNC_END

