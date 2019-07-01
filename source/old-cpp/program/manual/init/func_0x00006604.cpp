FUNC_BEGIN(0x00006604, 0x5e774ca4d9b207e6, 0x10, ({0x50, 0x53, 0x8b, 0x1e, 0xb4, 0x9, 0xfa}))
    II(0x00006604, 0x1)   pushw(ax);                            /* push ax */
    II(0x00006605, 0x1)   pushw(bx);                            /* push bx */
    II(0x00006606, 0x4)   mov(bx, memw_a16(ds, 0x9b4));         /* mov bx, [0x9b4] */
    II(0x0000660a, 0x1)   cli();                                /* cli  */
    II(0x0000660b, 0)     jmpd_func(0x0000660b, 0);             /* Принудительное завершение функции. */
FUNC_END

