FUNC_BEGIN(0x0013e23c, 0x63cc5cba825d2e84, 0x10, ({0x53, 0x6, 0x51, 0xb9, 0, 0x4, 0x87, 0xe, 0xa8, 0x1d, 0x51, 0x50, 0x90, 0xe, 0xe8, 0xcb, 0, 0x5b, 0x8f, 0x6, 0xa8, 0x1d, 0x59, 0x8c, 0xda, 0xb, 0xc0, 0x74, 0x3, 0x7, 0x5b, 0xc3, 0x8b, 0xc1, 0xe9, 0xa, 0xef}))
    II(0x0013e23c, 0x1)   pushw(bx);                            /* push bx */
    II(0x0013e23d, 0x1)   pushw(es);                            /* push es */
    II(0x0013e23e, 0x1)   pushw(cx);                            /* push cx */
    II(0x0013e23f, 0x3)   mov(cx, 0x400);                       /* mov cx, 0x400 */
    II(0x0013e242, 0x4)   xchg(memw_a16(ds, 0x1da8), cx);       /* xchg [0x1da8], cx */
    II(0x0013e246, 0x1)   pushw(cx);                            /* push cx */
    II(0x0013e247, 0x1)   pushw(ax);                            /* push ax */
//    II(0x0013e248, 0x1)   nop();                                /* nop  */
    II(0x0013e249, 0x1)   pushw(cs);                            /* push cs */
    II(0x0013e24a, 0x3)   callw(0x0013e318, 0xcb);              /* call 0x13e318 */
    II(0x0013e24d, 0x1)   popw(bx);                             /* pop bx */
    II(0x0013e24e, 0x4)   popw(memw_a16(ds, 0x1da8));           /* pop word [0x1da8] */
    II(0x0013e252, 0x1)   popw(cx);                             /* pop cx */
    II(0x0013e253, 0x2)   mov(dx, ds);                          /* mov dx, ds */
    II(0x0013e255, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x0013e257, 0x2)   jzw(0x0013e25c, 0x3);                 /* jz 0x13e25c */
    II(0x0013e259, 0x1)   popw(es);                             /* pop es */
    II(0x0013e25a, 0x1)   popw(bx);                             /* pop bx */
    II(0x0013e25b, 0x1)   retw();                               /* ret  */
l_0x0013e25c:
    II(0x0013e25c, 0x2)   mov(ax, cx);                          /* mov ax, cx */
    II(0x0013e25e, 0x3)   jmpw_func(0x0013d16b, -0x10f6);       /* jmp 0x13d16b */
FUNC_END

