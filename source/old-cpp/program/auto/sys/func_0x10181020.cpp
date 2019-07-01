FUNC_BEGIN(/* sys */ 0x10181020, 0x29b554db8e700747, 0x20, ({0xff, 0x15, 0xb4, 0xe7, 0x1b, 0x10}))
    II(0x10181020, 0x6)   calld_abs(memd_a32(ds, 0x101be7b4));  /* call dword near [0x101be7b4] */ /* Вызов '0x10181026'. */
    II(0x10181026, 0)     jmpd_func(/* sys */ 0x10181026, 0);   /* Принудительное завершение функции. */
FUNC_END

