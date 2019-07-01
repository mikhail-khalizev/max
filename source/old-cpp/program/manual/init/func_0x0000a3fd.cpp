FUNC_BEGIN(0x0000a3fd, 0x5f5fe3c0d8727511, 0x10, ({0x16, 0x1f, 0x6a, 0x20, 0xe8, 0x99, 0xb4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}))
    II(0x0000a3fd, 0x1)   pushw(ss);                            /* push ss */
    II(0x0000a3fe, 0x1)   popw(ds);                             /* pop ds */
    II(0x0000a3ff, 0x2)   pushw(0x20);                          /* push 0x20 */
    II(0x0000a401, 0x3)   callw(0x0000589d, -0x4b67);           /* call 0x589d */
    II(0x0000a404, 0x2)   add(memb_a16(ds, bx + si), al);       /* add [bx+si], al */
    II(0x0000a406, 0x2)   add(memb_a16(ds, bx + si), al);       /* add [bx+si], al */
    II(0x0000a408, 0x2)   add(memb_a16(ds, bx + si), al);       /* add [bx+si], al */
    II(0x0000a40a, 0x2)   add(memb_a16(ds, bx + si), al);       /* add [bx+si], al */
    II(0x0000a40c, 0x2)   add(memb_a16(ds, bx + si), al);       /* add [bx+si], al */
    II(0x0000a40e, 0x2)   add(memb_a16(ds, bx + si), al);       /* add [bx+si], al */
    II(0x0000a410, 0)     jmpd_func(0x0000a410, 0);             /* Принудительное завершение функции. */
FUNC_END

