FUNC_BEGIN(0x0014a45a, 0xc89a7a2806f13ab6, 0x10, ({0xff, 0x76, 0x14, 0xff, 0x76, 0x6, 0xff, 0x76, 0x10, 0xe8, 0x65, 0x2d, 0x59, 0x59, 0xeb, 0xc4}))
    II(0x0014a45a, 0x3)   pushw(memw_a16(ss, bp + 0x14));       /* push word [bp+0x14] */
    II(0x0014a45d, 0x3)   pushw(memw_a16(ss, bp + 0x6));        /* push word [bp+0x6] */
    II(0x0014a460, 0x3)   pushw(memw_a16(ss, bp + 0x10));       /* push word [bp+0x10] */
    II(0x0014a463, 0x3)   callw(0x0014d1cb, 0x2d65);            /* call 0x14d1cb */
    II(0x0014a466, 0x1)   popw(cx);                             /* pop cx */
    II(0x0014a467, 0x1)   popw(cx);                             /* pop cx */
    II(0x0014a468, 0x2)   jmpw_func(0x0014a42e, -0x3c);         /* jmp 0x14a42e */
FUNC_END

