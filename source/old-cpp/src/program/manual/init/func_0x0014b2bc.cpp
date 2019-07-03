FUNC_BEGIN(0x0014b2bc, 0x5ef5848e0fd4dd3f, 0x10, ({0xb9, 0x10, 0, 0xf7, 0xe1, 0x92, 0x91, 0x87, 0xdf, 0xb8, 0x7, 0, 0xe, 0xe8, 0xed, 0xf0, 0x87, 0xdf, 0xc3}))
    II(0x0014b2bc, 0x3)   mov(cx, 0x10);                        /* mov cx, 0x10 */
    II(0x0014b2bf, 0x2)   mul(cx);                              /* mul cx */
    II(0x0014b2c1, 0x1)   xchg(dx, ax);                         /* xchg dx, ax */
    II(0x0014b2c2, 0x1)   xchg(cx, ax);                         /* xchg cx, ax */
    II(0x0014b2c3, 0x2)   xchg(di, bx);                         /* xchg di, bx */
    II(0x0014b2c5, 0x3)   mov(ax, 0x7);                         /* mov ax, 0x7 */
    II(0x0014b2c8, 0x1)   pushw(cs);                            /* push cs */
    II(0x0014b2c9, 0x3)   callw(0x0014a3b9, -0xf13);            /* call 0x14a3b9 */
    II(0x0014b2cc, 0x2)   xchg(di, bx);                         /* xchg di, bx */
    II(0x0014b2ce, 0x1)   retw();                               /* ret  */
FUNC_END

