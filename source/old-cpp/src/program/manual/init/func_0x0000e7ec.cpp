FUNC_BEGIN(0x0000e7ec, 0xa16fb5fbc62, 0x10, ({0xe8, 0x74, 0}))
    II(0x0000e7ec, 0x3)   callw(0x0000e863, 0x74);              /* call 0xe863 */
    II(0x0000e7ef, 0)     jmpd_func(0x0000e7ef, 0);             /* Принудительное завершение функции. */
FUNC_END

