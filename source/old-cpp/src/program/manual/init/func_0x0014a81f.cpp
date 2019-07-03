FUNC_BEGIN(0x0014a81f, 0x35393836d648fb02, 0x10, ({0x8c, 0xd0, 0x8e, 0xc0, 0xfc, 0x8d, 0x7e, 0x8, 0x8d, 0x77, 0x8, 0xb9, 0x8, 0, 0xf3, 0xa5}))
    II(0x0014a81f, 0x2)   mov(ax, ss);                          /* mov ax, ss */
    II(0x0014a821, 0x2)   mov(es, ax);                          /* mov es, ax */
    II(0x0014a823, 0x1)   cld();                                /* cld  */
    II(0x0014a824, 0x3)   lea(di, bp + 0x8);                    /* lea di, [bp+0x8] */
    II(0x0014a827, 0x3)   lea(si, bx + 0x8);                    /* lea si, [bx+0x8] */
    II(0x0014a82a, 0x3)   mov(cx, 0x8);                         /* mov cx, 0x8 */
    II(0x0014a82d, 0x2)   rep_a16 movsw_a16();                  /* rep movsw  */
    II(0x0014a82f, 0)     jmpd_func(0x0014a82f, 0);             /* Принудительное завершение функции. */
FUNC_END

