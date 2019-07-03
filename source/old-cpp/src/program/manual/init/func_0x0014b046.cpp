FUNC_BEGIN(0x0014b046, 0xb80bec3100f14152, 0x10, ({0x80, 0x4e, 0x26, 0x1, 0x6a, 0, 0x16, 0x55, 0xfb, 0xe8, 0xc, 0x18, 0x59}))
    II(0x0014b046, 0x4)   or_(memb_a16(ss, bp + 0x26), 0x1);    /* or byte [bp+0x26], 0x1 */
    II(0x0014b04a, 0x2)   pushw(0);                             /* push 0x0 */
    II(0x0014b04c, 0x1)   pushw(ss);                            /* push ss */
    II(0x0014b04d, 0x1)   pushw(bp);                            /* push bp */
    II(0x0014b04e, 0x1)   sti();                                /* sti  */
    II(0x0014b04f, 0x3)   callw(0x0014c85e, 0x180c);            /* call 0x14c85e */
    II(0x0014b052, 0x1)   popw(cx);                             /* pop cx */
    II(0x0014b053, 0)     jmpd_func(0x0014b053, 0);             /* Принудительное завершение функции. */
FUNC_END

