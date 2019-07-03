FUNC_BEGIN(0x0000f48c, 0x28253c85208e9, 0x10, ({0x6a, 0x43, 0x6a, 0x43}))
    II(0x0000f48c, 0x2)   pushw(0x43);                          /* push 0x43 */
    II(0x0000f48e, 0x2)   pushw(0x43);                          /* push 0x43 */
    II(0x0000f490, 0)     jmpd_func(0x0000f490, 0);             /* Принудительное завершение функции. */
FUNC_END

