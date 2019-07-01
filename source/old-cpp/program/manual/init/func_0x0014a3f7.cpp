FUNC_BEGIN(0x0014a3f7, 0xa16fb45c0ff, 0x10, ({0x89, 0x46, 0x16}))
    II(0x0014a3f7, 0x3)   mov(memw_a16(ss, bp + 0x16), ax);     /* mov [bp+0x16], ax */
    II(0x0014a3fa, 0)     jmpd_func(0x0014a3fa, 0);             /* Принудительное завершение функции. */
FUNC_END

