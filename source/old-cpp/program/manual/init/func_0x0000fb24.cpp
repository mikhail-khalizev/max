FUNC_BEGIN(0x0000fb24, 0xa16fb5ecb05, 0x10, ({0x1f, 0x5d, 0xc3}))
    II(0x0000fb24, 0x1)   popw(ds);                             /* pop ds */
    II(0x0000fb25, 0x1)   popw(bp);                             /* pop bp */
    II(0x0000fb26, 0x1)   retw();                               /* ret  */
FUNC_END

