FUNC_BEGIN(0x001536e2, 0xf5007aaae1849831, 0x10, ({0x55, 0x8b, 0xec, 0x8b, 0x46, 0x8, 0x8b, 0x4e, 0xc, 0xb, 0xc8, 0x8b, 0x4e, 0xa, 0x75, 0x9, 0x8b, 0x46, 0x6, 0xf7, 0xe1, 0x5d, 0xca, 0x8, 0, 0x53, 0xf7, 0xe1, 0x8b, 0xd8, 0x8b, 0x46, 0x6, 0xf7, 0x66, 0xc, 0x3, 0xd8, 0x8b, 0x46, 0x6, 0xf7, 0xe1, 0x3, 0xd3, 0x5b, 0x5d, 0xca, 0x8, 0}))
    II(0x001536e2, 0x1)   pushw(bp);                            /* push bp */
    II(0x001536e3, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x001536e5, 0x3)   mov(ax, memw_a16(ss, bp + 0x8));      /* mov ax, [bp+0x8] */
    II(0x001536e8, 0x3)   mov(cx, memw_a16(ss, bp + 0xc));      /* mov cx, [bp+0xc] */
    II(0x001536eb, 0x2)   or_(cx, ax);                          /* or cx, ax */
    II(0x001536ed, 0x3)   mov(cx, memw_a16(ss, bp + 0xa));      /* mov cx, [bp+0xa] */
    II(0x001536f0, 0x2)   jnzw(0x001536fb, 0x9);                /* jnz 0x1536fb */
    II(0x001536f2, 0x3)   mov(ax, memw_a16(ss, bp + 0x6));      /* mov ax, [bp+0x6] */
    II(0x001536f5, 0x2)   mul(cx);                              /* mul cx */
    II(0x001536f7, 0x1)   popw(bp);                             /* pop bp */
    II(0x001536f8, 0x3)   retfw(0x8);                           /* retf 0x8 */
l_0x001536fb:
    II(0x001536fb, 0x1)   pushw(bx);                            /* push bx */
    II(0x001536fc, 0x2)   mul(cx);                              /* mul cx */
    II(0x001536fe, 0x2)   mov(bx, ax);                          /* mov bx, ax */
    II(0x00153700, 0x3)   mov(ax, memw_a16(ss, bp + 0x6));      /* mov ax, [bp+0x6] */
    II(0x00153703, 0x3)   mul(memw_a16(ss, bp + 0xc));          /* mul word [bp+0xc] */
    II(0x00153706, 0x2)   add(bx, ax);                          /* add bx, ax */
    II(0x00153708, 0x3)   mov(ax, memw_a16(ss, bp + 0x6));      /* mov ax, [bp+0x6] */
    II(0x0015370b, 0x2)   mul(cx);                              /* mul cx */
    II(0x0015370d, 0x2)   add(dx, bx);                          /* add dx, bx */
    II(0x0015370f, 0x1)   popw(bx);                             /* pop bx */
    II(0x00153710, 0x1)   popw(bp);                             /* pop bp */
    II(0x00153711, 0x3)   retfw(0x8);                           /* retf 0x8 */
FUNC_END

