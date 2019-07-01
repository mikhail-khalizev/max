FUNC_BEGIN(0x0014a417, 0xecf048a1435893d5, 0x10, ({0xb9, 0x9, 0x33, 0x16, 0x55, 0xff, 0xd1, 0x59, 0x59, 0xe9, 0x15, 0x4}))
    II(0x0014a417, 0x3)   mov(cx, 0x3309);                      /* mov cx, 0x3309 */
    II(0x0014a41a, 0x1)   pushw(ss);                            /* push ss */
    II(0x0014a41b, 0x1)   pushw(bp);                            /* push bp */
    II(0x0014a41c, 0x2)   callw_abs(cx);                        /* call cx */
    II(0x0014a41e, 0x1)   popw(cx);                             /* pop cx */
    II(0x0014a41f, 0x1)   popw(cx);                             /* pop cx */
    II(0x0014a420, 0x3)   jmpw_func(0x0014a838, 0x415);         /* jmp 0x14a838 */
FUNC_END

