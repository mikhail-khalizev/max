FUNC_BEGIN(0x0014fb4e, 0x5e7703b04b8e0f44, 0x10, ({0x83, 0xc4, 0x4, 0x66, 0xf, 0xb7, 0xf5}))
    II(0x0014fb4e, 0x3)   add(sp, 0x4);                         /* add sp, 0x4 */
    II(0x0014fb51, 0x4)   movzx(esi, bp);                       /* movzx esi, bp */
    II(0x0014fb55, 0)     jmpd_func(0x0014fb55, 0);             /* Принудительное завершение функции. */
FUNC_END

