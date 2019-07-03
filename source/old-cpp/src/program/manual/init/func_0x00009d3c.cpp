FUNC_BEGIN(0x00009d3c, 0x36dc548d7ab03216, 0x10, ({0xb9, 0x6, 0, 0x5b, 0x58, 0x50, 0x33, 0xd2, 0xd1, 0xe0, 0xd1, 0xd2, 0xe2, 0xfa, 0xff, 0xe3}))
    II(0x00009d3c, 0x3)   mov(cx, 0x6);                         /* mov cx, 0x6 */
    II(0x00009d3f, 0x1)   popw(bx);                             /* pop bx */
    II(0x00009d40, 0x1)   popw(ax);                             /* pop ax */
    II(0x00009d41, 0x1)   pushw(ax);                            /* push ax */
    II(0x00009d42, 0x2)   xor_(dx, dx);                         /* xor dx, dx */
l_0x00009d44:
    II(0x00009d44, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
    II(0x00009d46, 0x2)   rcl(dx, 0x1);                         /* rcl dx, 1 */
    II(0x00009d48, 0x2)   loopw_a16(0x00009d44, -0x6);          /* loop 0x9d44 */
    II(0x00009d4a, 0x2)   jmpw_abs(bx);                         /* jmp bx */
FUNC_END

