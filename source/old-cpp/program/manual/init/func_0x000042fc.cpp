FUNC_BEGIN(0x000042fc, 0x168f4af909b97f16, 0x10, ({0xfa, 0x68, 0x26, 0x10, 0xe8, 0x85, 0x5, 0x59, 0xc3}))
    II(0x000042fc, 0x1)   cli();                                /* cli  */
    II(0x000042fd, 0x3)   pushw(0x1026);                        /* push word 0x1026 */
    II(0x00004300, 0x3)   callw(0x00004888, 0x585);             /* call 0x4888 */
    II(0x00004303, 0x1)   popw(cx);                             /* pop cx */
    II(0x00004304, 0x1)   retw();                               /* ret  */
FUNC_END

