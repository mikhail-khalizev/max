FUNC_BEGIN(0x0014def9, 0x721a7163ea8edb37, 0x10, ({0x51, 0xb9, 0x6f, 0x80, 0xe8, 0x82, 0xf, 0x59, 0x66, 0xea, 0x3c, 0, 0, 0, 0x80, 0}))
    II(0x0014def9, 0x1)   pushw(cx);                            /* push cx */
    II(0x0014defa, 0x3)   mov(cx, 0x806f);                      /* mov cx, 0x806f */
    II(0x0014defd, 0x3)   callw(0x0014ee82, 0xf82);             /* call 0x14ee82 */
    II(0x0014df00, 0x1)   popw(cx);                             /* pop cx */
    II(0x0014df01, 0x8)   jmpd_far_abs(0x80, 0x3c);             /* o32 jmp dword 0x80:0x3c */
FUNC_END

