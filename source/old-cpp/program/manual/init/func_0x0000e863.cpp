FUNC_BEGIN(0x0000e863, 0x2dcd5aad5309be0f, 0x10, ({0x80, 0x3e, 0x2e, 0, 0, 0x74, 0xc9, 0xfa, 0x60, 0xea, 0x68, 0x10, 0x18, 0}))
    II(0x0000e863, 0x5)   cmp(memb_a16(ds, 0x2e), 0);           /* cmp byte [0x2e], 0x0 */
    II(0x0000e868, 0x2)   jzw_func(0x0000e833, -0x37);          /* jz 0xe833 */
    II(0x0000e86a, 0x1)   cli();                                /* cli  */
    II(0x0000e86b, 0x1)   pusha();                              /* pusha  */
    II(0x0000e86c, 0x5)   jmpw_far_abs(0x18, 0x1068);           /* jmp word 0x18:0x1068 */
FUNC_END

