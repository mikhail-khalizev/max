FUNC_BEGIN(0x00138f00, 0xa16fb5ebc2d, 0x10, ({0x16, 0x58, 0xcb}))
    II(0x00138f00, 0x1)   pushw(ss);                            /* push ss */
    II(0x00138f01, 0x1)   popw(ax);                             /* pop ax */
    II(0x00138f02, 0x1)   retfw();                              /* retf  */
FUNC_END

