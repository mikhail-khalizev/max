FUNC_BEGIN(0x001537cc, 0xfcf53cbdbb76e0f9, 0x10, ({0x55, 0x8b, 0xec, 0x53, 0x8b, 0x5e, 0x6, 0x8b, 0x7, 0x8b, 0x57, 0x2, 0x8b, 0x4e, 0x8, 0xe, 0xe8, 0xd5, 0xff, 0x89, 0x7, 0x89, 0x57, 0x2, 0x5b, 0x5d, 0xca, 0x4, 0}))
    II(0x001537cc, 0x1)   pushw(bp);                            /* push bp */
    II(0x001537cd, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x001537cf, 0x1)   pushw(bx);                            /* push bx */
    II(0x001537d0, 0x3)   mov(bx, memw_a16(ss, bp + 0x6));      /* mov bx, [bp+0x6] */
    II(0x001537d3, 0x2)   mov(ax, memw_a16(ds, bx));            /* mov ax, [bx] */
    II(0x001537d5, 0x3)   mov(dx, memw_a16(ds, bx + 0x2));      /* mov dx, [bx+0x2] */
    II(0x001537d8, 0x3)   mov(cx, memw_a16(ss, bp + 0x8));      /* mov cx, [bp+0x8] */
    II(0x001537db, 0x1)   pushw(cs);                            /* push cs */
    II(0x001537dc, 0x3)   callw(0x001537b4, -0x2b);             /* call 0x1537b4 */
    II(0x001537df, 0x2)   mov(memw_a16(ds, bx), ax);            /* mov [bx], ax */
    II(0x001537e1, 0x3)   mov(memw_a16(ds, bx + 0x2), dx);      /* mov [bx+0x2], dx */
    II(0x001537e4, 0x1)   popw(bx);                             /* pop bx */
    II(0x001537e5, 0x1)   popw(bp);                             /* pop bp */
    II(0x001537e6, 0x3)   retfw(0x4);                           /* retf 0x4 */
FUNC_END

