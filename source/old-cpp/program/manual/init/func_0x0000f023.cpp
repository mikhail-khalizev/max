FUNC_BEGIN(0x0000f023, 0xa3b7db860a8790, 0x10, ({0x59, 0x59, 0xe9, 0xe0, 0xf7}))
    II(0x0000f023, 0x1)   popw(cx);                             /* pop cx */
    II(0x0000f024, 0x1)   popw(cx);                             /* pop cx */
    II(0x0000f025, 0x3)   jmpw_func(0x0000e808, -0x820);        /* jmp 0xe808 */
FUNC_END

