FUNC_BEGIN(0x00153ae2, 0x36bc41e062502d4d, 0x10, ({0x53, 0x6, 0x51, 0xb9, 0, 0x4, 0x87, 0xe, 0x64, 0x3f, 0x51, 0x50, 0x90, 0xe, 0xe8, 0xb3, 0x1, 0x5b, 0x8f, 0x6, 0x64, 0x3f, 0x59, 0x8b, 0xda, 0xb, 0xd8, 0x74, 0x3, 0x7, 0x5b, 0xc3, 0x8b, 0xc1, 0xe9, 0xfc, 0xe6}))
    II(0x00153ae2, 0x1)   pushw(bx);                            /* push bx */
    II(0x00153ae3, 0x1)   pushw(es);                            /* push es */
    II(0x00153ae4, 0x1)   pushw(cx);                            /* push cx */
    II(0x00153ae5, 0x3)   mov(cx, 0x400);                       /* mov cx, 0x400 */
    II(0x00153ae8, 0x4)   xchg(memw_a16(ds, 0x3f64), cx);       /* xchg [0x3f64], cx */
    II(0x00153aec, 0x1)   pushw(cx);                            /* push cx */
    II(0x00153aed, 0x1)   pushw(ax);                            /* push ax */
//    II(0x00153aee, 0x1)   nop();                                /* nop  */
    II(0x00153aef, 0x1)   pushw(cs);                            /* push cs */
    II(0x00153af0, 0x3)   callw(0x00153ca6, 0x1b3);             /* call 0x153ca6 */
    II(0x00153af3, 0x1)   popw(bx);                             /* pop bx */
    II(0x00153af4, 0x4)   popw(memw_a16(ds, 0x3f64));           /* pop word [0x3f64] */
    II(0x00153af8, 0x1)   popw(cx);                             /* pop cx */
    II(0x00153af9, 0x2)   mov(bx, dx);                          /* mov bx, dx */
    II(0x00153afb, 0x2)   or_(bx, ax);                          /* or bx, ax */
    II(0x00153afd, 0x2)   jzw(0x00153b02, 0x3);                 /* jz 0x153b02 */
    II(0x00153aff, 0x1)   popw(es);                             /* pop es */
    II(0x00153b00, 0x1)   popw(bx);                             /* pop bx */
    II(0x00153b01, 0x1)   retw();                               /* ret  */
l_0x00153b02:
    II(0x00153b02, 0x2)   mov(ax, cx);                          /* mov ax, cx */
    II(0x00153b04, 0x3)   jmpw_func(0x00152203, -0x1904);       /* jmp 0x152203 */
FUNC_END

