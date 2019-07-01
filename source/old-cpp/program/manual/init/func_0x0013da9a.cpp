FUNC_BEGIN(0x0013da9a, 0xa3b7d9380fe3f7, 0x10, ({0x8b, 0x66, 0xf8, 0x5e, 0x5f}))
    II(0x0013da9a, 0x3)   mov(sp, memw_a16(ss, bp - 0x8));      /* mov sp, [bp-0x8] */
    II(0x0013da9d, 0x1)   popw(si);                             /* pop si */
    II(0x0013da9e, 0x1)   popw(di);                             /* pop di */
    II(0x0013da9f, 0)     jmpd_func(0x0013da9f, 0);             /* Принудительное завершение функции. */
FUNC_END

