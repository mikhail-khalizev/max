FUNC_BEGIN(0x0000e829, 0x7785ab53602fcf1c, 0x10, ({0xc6, 0x6, 0x45, 0xc, 0, 0xb8, 0xfe, 0x4c, 0xcd, 0x21}))
    II(0x0000e829, 0x5)   mov(memb_a16(ds, 0xc45), 0);          /* mov byte [0xc45], 0x0 */
    II(0x0000e82e, 0x3)   mov(ax, 0x4cfe);                      /* mov ax, 0x4cfe */
    II(0x0000e831, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x0000e833, 0)     jmpd_func(0x0000e833, 0);             /* Принудительное завершение функции. */
FUNC_END

