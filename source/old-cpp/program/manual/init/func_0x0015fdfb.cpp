FUNC_BEGIN(0x0015fdfb, 0x810e08692b5f6ba8, 0x10, ({0xe8, 0xec, 0xfe, 0xb, 0xc0, 0x74, 0x3, 0x2b, 0xc0, 0xcb, 0x6a, 0x4, 0xe, 0xe8, 0x7, 0xff, 0xcb}))
    II(0x0015fdfb, 0x3)   callw(0x0015fcea, -0x114);            /* call 0x15fcea */
    II(0x0015fdfe, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x0015fe00, 0x2)   jzw(0x0015fe05, 0x3);                 /* jz 0x15fe05 */
    II(0x0015fe02, 0x2)   sub(ax, ax);                          /* sub ax, ax */
    II(0x0015fe04, 0x1)   retfw();                              /* retf  */
l_0x0015fe05:
    II(0x0015fe05, 0x2)   pushw(0x4);                           /* push 0x4 */
    II(0x0015fe07, 0x1)   pushw(cs);                            /* push cs */
    II(0x0015fe08, 0x3)   callw(0x0015fd12, -0xf9);             /* call 0x15fd12 */
    II(0x0015fe0b, 0x1)   retfw();                              /* retf  */
FUNC_END

