FUNC_BEGIN(0x0001130e, 0xa16fb5fa02d, 0x10, ({0xe8, 0x5, 0}))
    II(0x0001130e, 0x3)   callw(0x00011316, 0x5);               /* call 0x11316 */
    II(0x00011311, 0)     jmpd_func(0x00011311, 0);             /* Принудительное завершение функции. */
FUNC_END

