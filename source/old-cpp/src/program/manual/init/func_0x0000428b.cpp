FUNC_BEGIN(0x0000428b, 0x28253c85dfac2, 0x10, ({0x6a, 0, 0x6a, 0}))
    II(0x0000428b, 0x2)   pushw(0);                             /* push 0x0 */
    II(0x0000428d, 0x2)   pushw(0);                             /* push 0x0 */
    II(0x0000428f, 0)     jmpd_func(0x0000428f, 0);             /* Принудительное завершение функции. */
FUNC_END

