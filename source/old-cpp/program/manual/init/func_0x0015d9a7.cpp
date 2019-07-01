FUNC_BEGIN(0x0015d9a7, 0x29b5532a93b539a3, 0x10, ({0x55, 0x8b, 0xec, 0xb8, 0x6, 0x5}))
    II(0x0015d9a7, 0x1)   pushw(bp);                            /* push bp */
    II(0x0015d9a8, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0015d9aa, 0x3)   mov(ax, 0x506);                       /* mov ax, 0x506 */
    II(0x0015d9ad, 0)     jmpd_func(0x0015d9ad, 0);             /* Принудительное завершение функции. */
FUNC_END

