FUNC_BEGIN(0x00009e8e, 0x29b55305b22cdc04, 0x10, ({0x56, 0x33, 0xf6, 0xb9, 0, 0x40}))
    II(0x00009e8e, 0x1)   pushw(si);                            /* push si */
    II(0x00009e8f, 0x2)   xor_(si, si);                         /* xor si, si */
    II(0x00009e91, 0x3)   mov(cx, 0x4000);                      /* mov cx, 0x4000 */
    II(0x00009e94, 0)     jmpd_func(0x00009e94, 0);             /* Принудительное завершение функции. */
FUNC_END

