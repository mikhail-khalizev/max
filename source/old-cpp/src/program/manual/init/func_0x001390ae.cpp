FUNC_BEGIN(0x001390ae, 0xeb07a59ab98838d8, 0x10, ({0x55, 0x8b, 0xec, 0x8e, 0x6e, 0x4, 0x5d, 0xc3}))
    II(0x001390ae, 0x1)   pushw(bp);                            /* push bp */
    II(0x001390af, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x001390b1, 0x3)   mov(gs, memw_a16(ss, bp + 0x4));      /* mov gs, [bp+0x4] */
    II(0x001390b4, 0x1)   popw(bp);                             /* pop bp */
    II(0x001390b5, 0x1)   retw();                               /* ret  */
FUNC_END

