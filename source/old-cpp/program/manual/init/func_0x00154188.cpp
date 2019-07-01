FUNC_BEGIN(0x00154188, 0x9b61c024ac749907, 0x10, ({0x55, 0x8b, 0xec, 0x53, 0x1e, 0xc5, 0x5e, 0x8, 0x8b, 0x46, 0xc, 0x89, 0x7, 0x8b, 0x46, 0xe, 0x89, 0x47, 0x2, 0x1e, 0x53, 0xff, 0x76, 0x6, 0x90, 0xe, 0xe8, 0x8a, 0xff, 0x83, 0xc4, 0x6, 0x1f, 0x5b, 0x5d, 0xcb}))
    II(0x00154188, 0x1)   pushw(bp);                            /* push bp */
    II(0x00154189, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0015418b, 0x1)   pushw(bx);                            /* push bx */
    II(0x0015418c, 0x1)   pushw(ds);                            /* push ds */
    II(0x0015418d, 0x3)   lds(bx, ss, bp + 0x8);                /* lds bx, [bp+0x8] */
    II(0x00154190, 0x3)   mov(ax, memw_a16(ss, bp + 0xc));      /* mov ax, [bp+0xc] */
    II(0x00154193, 0x2)   mov(memw_a16(ds, bx), ax);            /* mov [bx], ax */
    II(0x00154195, 0x3)   mov(ax, memw_a16(ss, bp + 0xe));      /* mov ax, [bp+0xe] */
    II(0x00154198, 0x3)   mov(memw_a16(ds, bx + 0x2), ax);      /* mov [bx+0x2], ax */
    II(0x0015419b, 0x1)   pushw(ds);                            /* push ds */
    II(0x0015419c, 0x1)   pushw(bx);                            /* push bx */
    II(0x0015419d, 0x3)   pushw(memw_a16(ss, bp + 0x6));        /* push word [bp+0x6] */
//    II(0x001541a0, 0x1)   nop();                                /* nop  */
    II(0x001541a1, 0x1)   pushw(cs);                            /* push cs */
    II(0x001541a2, 0x3)   callw(0x0015412f, -0x76);             /* call 0x15412f */
    II(0x001541a5, 0x3)   add(sp, 0x6);                         /* add sp, 0x6 */
    II(0x001541a8, 0x1)   popw(ds);                             /* pop ds */
    II(0x001541a9, 0x1)   popw(bx);                             /* pop bx */
    II(0x001541aa, 0x1)   popw(bp);                             /* pop bp */
    II(0x001541ab, 0x1)   retfw();                              /* retf  */
FUNC_END

