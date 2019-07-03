FUNC_BEGIN(0x0014dcef, 0xccd81c11f0942248, 0x10, ({0x33, 0xc0, 0x8b, 0xdc, 0x36, 0x8b, 0x4f, 0x2, 0xe, 0xe8, 0xbe, 0xc6}))
    II(0x0014dcef, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x0014dcf1, 0x2)   mov(bx, sp);                          /* mov bx, sp */
    II(0x0014dcf3, 0x4)   mov(cx, memw_a16(ss, bx + 0x2));      /* mov cx, [ss:bx+0x2] */
    II(0x0014dcf7, 0x1)   pushw(cs);                            /* push cs */
    II(0x0014dcf8, 0x3)   callw(0x0014a3b9, -0x3942);           /* call 0x14a3b9 */
    II(0x0014dcfb, 0)     jmpd_func(0x0014dcfb, 0);             /* Принудительное завершение функции. */
FUNC_END

