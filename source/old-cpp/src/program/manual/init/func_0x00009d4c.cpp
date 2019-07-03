FUNC_BEGIN(0x00009d4c, 0x5e77466ed19a8f8a, 0x10, ({0x59, 0x51, 0x51, 0x8b, 0xc4, 0xff, 0xe1}))
    II(0x00009d4c, 0x1)   popw(cx);                             /* pop cx */
    II(0x00009d4d, 0x1)   pushw(cx);                            /* push cx */
    II(0x00009d4e, 0x1)   pushw(cx);                            /* push cx */
    II(0x00009d4f, 0x2)   mov(ax, sp);                          /* mov ax, sp */
    II(0x00009d51, 0x2)   jmpw_abs(cx);                         /* jmp cx */
FUNC_END

