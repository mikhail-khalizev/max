FUNC_BEGIN(0x00006001, 0xa16fb5f9d46, 0x10, ({0xe8, 0xf2, 0xff}))
    II(0x00006001, 0x3)   callw(0x00005ff6, -0xe);              /* call 0x5ff6 */
    II(0x00006004, 0)     jmpd_func(0x00006004, 0);             /* Принудительное завершение функции. */
FUNC_END

