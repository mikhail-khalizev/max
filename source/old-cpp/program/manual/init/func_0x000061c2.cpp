FUNC_BEGIN(0x000061c2, 0x83174620417c1882, 0x10, ({0x55, 0x8b, 0xec, 0xff, 0x76, 0x4, 0xe8, 0xd9, 0xff, 0x5b, 0x8b, 0xe5, 0x5d, 0xc3}))
    II(0x000061c2, 0x1)   pushw(bp);                            /* push bp */
    II(0x000061c3, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x000061c5, 0x3)   pushw(memw_a16(ss, bp + 0x4));        /* push word [bp+0x4] */
    II(0x000061c8, 0x3)   callw(0x000061a4, -0x27);             /* call 0x61a4 */
    II(0x000061cb, 0x1)   popw(bx);                             /* pop bx */
    II(0x000061cc, 0x2)   mov(sp, bp);                          /* mov sp, bp */
    II(0x000061ce, 0x1)   popw(bp);                             /* pop bp */
    II(0x000061cf, 0x1)   retw();                               /* ret  */
FUNC_END

