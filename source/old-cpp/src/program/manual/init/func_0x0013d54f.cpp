FUNC_BEGIN(0x0013d54f, 0x5e774c5aad71ea8f, 0x10, ({0x55, 0x8b, 0xec, 0x33, 0xc9, 0xeb, 0x1a}))
    II(0x0013d54f, 0x1)   pushw(bp);                            /* push bp */
    II(0x0013d550, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0013d552, 0x2)   xor_(cx, cx);                         /* xor cx, cx */
    II(0x0013d554, 0x2)   jmpw_func(0x0013d570, 0x1a);          /* jmp 0x13d570 */
FUNC_END

