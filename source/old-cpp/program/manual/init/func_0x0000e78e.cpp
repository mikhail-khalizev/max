FUNC_BEGIN(0x0000e78e, 0x83a417c9c5c02fdf, 0x10, ({0x83, 0xec, 0x6, 0x60, 0x6, 0x1e, 0x16, 0x8c, 0xd3, 0x8e, 0xdb, 0x2e, 0x8b, 0x16, 0x80, 0x56, 0x8e, 0xc2, 0x26, 0x8b, 0xe, 0x9e, 0x9, 0x26, 0x8b, 0x3e, 0x96, 0x9, 0xb, 0xc9, 0x75, 0xbf}))
    II(0x0000e78e, 0x3)   sub(sp, 0x6);                         /* sub sp, 0x6 */
    II(0x0000e791, 0x1)   pusha();                              /* pusha  */
    II(0x0000e792, 0x1)   pushw(es);                            /* push es */
    II(0x0000e793, 0x1)   pushw(ds);                            /* push ds */
    II(0x0000e794, 0x1)   pushw(ss);                            /* push ss */
    II(0x0000e795, 0x2)   mov(bx, ss);                          /* mov bx, ss */
    II(0x0000e797, 0x2)   mov(ds, bx);                          /* mov ds, bx */
    II(0x0000e799, 0x5)   mov(dx, memw_a16(cs, 0x5680));        /* mov dx, [cs:0x5680] */
    II(0x0000e79e, 0x2)   mov(es, dx);                          /* mov es, dx */
    II(0x0000e7a0, 0x5)   mov(cx, memw_a16(es, 0x99e));         /* mov cx, [es:0x99e] */
    II(0x0000e7a5, 0x5)   mov(di, memw_a16(es, 0x996));         /* mov di, [es:0x996] */
    II(0x0000e7aa, 0x2)   or_(cx, cx);                          /* or cx, cx */
    II(0x0000e7ac, 0x2)   jnzw_func(0x0000e76d, -0x41);         /* jnz 0xe76d */
    II(0x0000e7ae, 0)     jmpd_func(0x0000e7ae, 0);             /* Принудительное завершение функции. */
FUNC_END

