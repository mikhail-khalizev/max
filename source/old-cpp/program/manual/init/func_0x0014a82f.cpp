FUNC_BEGIN(0x0014a82f, 0x1561a01540282560, 0x10, ({0x8b, 0x47, 0x26, 0x80, 0xe4, 0xe, 0x89, 0x46, 0x26}))
    II(0x0014a82f, 0x3)   mov(ax, memw_a16(ds, bx + 0x26));     /* mov ax, [bx+0x26] */
    II(0x0014a832, 0x3)   and_(ah, 0xe);                        /* and ah, 0xe */
    II(0x0014a835, 0x3)   mov(memw_a16(ss, bp + 0x26), ax);     /* mov [bp+0x26], ax */
    II(0x0014a838, 0)     jmpd_func(0x0014a838, 0);             /* Принудительное завершение функции. */
FUNC_END

