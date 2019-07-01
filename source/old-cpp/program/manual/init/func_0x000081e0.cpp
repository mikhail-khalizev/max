FUNC_BEGIN(0x000081e0, 0x8317450f3f5d5cc7, 0x10, ({0x55, 0x8b, 0xec, 0xff, 0x76, 0x4, 0xe8, 0xe9, 0xff, 0x5b, 0x8b, 0xe5, 0x5d, 0xc3}))
    II(0x000081e0, 0x1)   pushw(bp);                            /* push bp */
    II(0x000081e1, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x000081e3, 0x3)   pushw(memw_a16(ss, bp + 0x4));        /* push word [bp+0x4] */
    II(0x000081e6, 0x3)   callw(0x000081d2, -0x17);             /* call 0x81d2 */
    II(0x000081e9, 0x1)   popw(bx);                             /* pop bx */
    II(0x000081ea, 0x2)   mov(sp, bp);                          /* mov sp, bp */
    II(0x000081ec, 0x1)   popw(bp);                             /* pop bp */
    II(0x000081ed, 0x1)   retw();                               /* ret  */
FUNC_END

