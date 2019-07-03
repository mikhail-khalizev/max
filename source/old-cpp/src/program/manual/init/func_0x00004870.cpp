FUNC_BEGIN(0x00004870, 0xa59f3cde81830ed3, 0x10, ({0x8b, 0xdc, 0x8b, 0x7f, 0x2, 0x33, 0xc0, 0x8e, 0xd8, 0x16, 0x7, 0xbe, 0x20, 0, 0xfc, 0xb9, 0x4e, 0, 0xfa, 0xf3, 0xa5}))
    II(0x00004870, 0x2)   mov(bx, sp);                          /* mov bx, sp */
    II(0x00004872, 0x3)   mov(di, memw_a16(ds, bx + 0x2));      /* mov di, [bx+0x2] */
    II(0x00004875, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x00004877, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x00004879, 0x1)   pushw(ss);                            /* push ss */
    II(0x0000487a, 0x1)   popw(es);                             /* pop es */
    II(0x0000487b, 0x3)   mov(si, 0x20);                        /* mov si, 0x20 */
    II(0x0000487e, 0x1)   cld();                                /* cld  */
    II(0x0000487f, 0x3)   mov(cx, 0x4e);                        /* mov cx, 0x4e */
    II(0x00004882, 0x1)   cli();                                /* cli  */
    II(0x00004883, 0x2)   rep_a16 movsw_a16();                  /* rep movsw  */
    II(0x00004885, 0)     jmpd_func(0x00004885, 0);             /* Принудительное завершение функции. */
FUNC_END

