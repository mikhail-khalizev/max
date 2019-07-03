FUNC_BEGIN(0x00008d20, 0xd52b2a3bb6f89f06, 0x10, ({0xe8, 0x18, 0xfe, 0x8b, 0xc5, 0x50, 0xe8, 0x50, 0xff, 0x5b, 0x8b, 0xe5, 0x5d, 0xc3}))
    II(0x00008d20, 0x3)   callw(0x00008b3b, -0x1e8);            /* call 0x8b3b */
    II(0x00008d23, 0x2)   mov(ax, bp);                          /* mov ax, bp */
    II(0x00008d25, 0x1)   pushw(ax);                            /* push ax */
    II(0x00008d26, 0x3)   callw(0x00008c79, -0xb0);             /* call 0x8c79 */
    II(0x00008d29, 0x1)   popw(bx);                             /* pop bx */
    II(0x00008d2a, 0x2)   mov(sp, bp);                          /* mov sp, bp */
    II(0x00008d2c, 0x1)   popw(bp);                             /* pop bp */
    II(0x00008d2d, 0x1)   retw();                               /* ret  */
FUNC_END

