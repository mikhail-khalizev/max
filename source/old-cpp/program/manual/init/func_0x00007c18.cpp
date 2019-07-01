FUNC_BEGIN(0x00007c18, 0x362b03c22d1cf63b, 0x10, ({0xe8, 0x1b, 0, 0xbb, 0x22, 0xe8, 0x16, 0, 0xf0, 0x24, 0xe8, 0x11, 0, 0xe2, 0x21}))
    II(0x00007c18, 0x3)   callw(0x00007c36, 0x1b);              /* call 0x7c36 */
    II(0x00007c1b, 0x3)   mov(bx, 0xe822);                      /* mov bx, 0xe822 */
    II(0x00007c1e, 0x1)   pushw(ss);                            /* push ss */
    II(0x00007c1f, 0x2)   add(al, dh);                          /* add al, dh */
    II(0x00007c21, 0x2)   and_(al, 0xe8);                       /* and al, 0xe8 */
    II(0x00007c23, 0x2)   adc(memw_a16(ds, bx + si), ax);       /* adc [bx+si], ax */
    II(0x00007c25, 0x2)   loopw_a16_func(0x00007c48, 0x21);     /* loop 0x7c48 */
    II(0x00007c27, 0)     jmpd_func(0x00007c27, 0);             /* Принудительное завершение функции. */
FUNC_END

