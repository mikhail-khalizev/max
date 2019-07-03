FUNC_BEGIN(sys_delete, 0xee1daf27aeb96e22, 0x20, ({0x85, 0xc0, 0xf, 0x85, 0x55, 0x51, 0, 0, 0xc3}))
    II(0x10165f64, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10165f66, 0x6)   jnzd_func(sys_free, 0x5155);          /* jnz dword 0x1016b0c1 */
    II(0x10165f6c, 0x1)   retd();                               /* ret */
FUNC_END

