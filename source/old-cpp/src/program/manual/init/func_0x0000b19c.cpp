FUNC_BEGIN(0x0000b19c, 0x29b5532af038a656, 0x10, ({0x52, 0xe8, 0x47, 0xa2, 0x5a, 0xc3}))
    II(0x0000b19c, 0x1)   pushw(dx);                            /* push dx */
    II(0x0000b19d, 0x3)   callw(0x000053e7, -0x5db9);           /* call 0x53e7 */
    II(0x0000b1a0, 0x1)   popw(dx);                             /* pop dx */
    II(0x0000b1a1, 0x1)   retw();                               /* ret  */
FUNC_END

