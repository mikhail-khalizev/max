FUNC_BEGIN(0x0014a366, 0xc52afe1c51afa70a, 0x10, ({0x66, 0x9c, 0x66, 0xe, 0x6a, 0, 0xe8, 0x4f, 0x4, 0xcb}))
    II(0x0014a366, 0x2)   pushfd();                             /* pushfd  */
    II(0x0014a368, 0x2)   pushd(cs);                            /* o32 push cs */
    II(0x0014a36a, 0x2)   pushw(0);                             /* push 0x0 */
    II(0x0014a36c, 0x3)   callw(0x0014a7be, 0x44f);             /* call 0x14a7be */
    II(0x0014a36f, 0x1)   retfw();                              /* retf  */
FUNC_END

