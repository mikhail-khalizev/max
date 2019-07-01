FUNC_BEGIN(0x00003f19, 0xa16fb57fa1a, 0x10, ({0x6a, 0x20, 0x1f}))
    II(0x00003f19, 0x2)   pushw(0x20);                          /* push 0x20 */
    II(0x00003f1b, 0x1)   popw(ds);                             /* pop ds */
    II(0x00003f1c, 0)     jmpd_func(0x00003f1c, 0);             /* Принудительное завершение функции. */
FUNC_END

