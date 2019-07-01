FUNC_BEGIN(0x0000ea47, 0x28253cf8f8d63, 0x10, ({0xfe, 0xe, 0xed, 0x10}))
    II(0x0000ea47, 0x4)   dec(memb_a16(ds, 0x10ed));            /* dec byte [0x10ed] */
    II(0x0000ea4b, 0)     jmpd_func(0x0000ea4b, 0);             /* Принудительное завершение функции. */
FUNC_END

