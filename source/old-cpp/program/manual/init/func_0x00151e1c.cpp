FUNC_BEGIN(0x00151e1c, 0x9c480a5d47dcfcf6, 0x10, ({0xc8, 0x6, 0, 0, 0x8d, 0x46, 0xc, 0x16, 0x50, 0xff, 0x76, 0xa, 0xff, 0x76, 0x8, 0xff, 0x76, 0x6, 0xff, 0x76, 0x4, 0xe, 0xe8, 0x2, 0, 0xc9, 0xc3}))
    II(0x00151e1c, 0x4)   enterw(0x6, 0);                       /* enter 0x6, 0x0 */
    II(0x00151e20, 0x3)   lea(ax, bp + 0xc);                    /* lea ax, [bp+0xc] */
    II(0x00151e23, 0x1)   pushw(ss);                            /* push ss */
    II(0x00151e24, 0x1)   pushw(ax);                            /* push ax */
    II(0x00151e25, 0x3)   pushw(memw_a16(ss, bp + 0xa));        /* push word [bp+0xa] */
    II(0x00151e28, 0x3)   pushw(memw_a16(ss, bp + 0x8));        /* push word [bp+0x8] */
    II(0x00151e2b, 0x3)   pushw(memw_a16(ss, bp + 0x6));        /* push word [bp+0x6] */
    II(0x00151e2e, 0x3)   pushw(memw_a16(ss, bp + 0x4));        /* push word [bp+0x4] */
    II(0x00151e31, 0x1)   pushw(cs);                            /* push cs */
    II(0x00151e32, 0x3)   callw(0x00151e37, 0x2);               /* call 0x151e37 */
    II(0x00151e35, 0x1)   leavew();                             /* leave  */
    II(0x00151e36, 0x1)   retw();                               /* ret  */
FUNC_END

