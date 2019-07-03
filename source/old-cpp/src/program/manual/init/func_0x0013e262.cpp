FUNC_BEGIN(0x0013e262, 0xd90c406204f7daa, 0x10, ({0x59, 0x5a, 0xa1, 0xa6, 0x1d, 0x3b, 0xc4, 0x73, 0x7, 0x2b, 0xc4, 0xf7, 0xd8, 0x52, 0x51, 0xcb, 0x33, 0xc0, 0xeb, 0xf9}))
    II(0x0013e262, 0x1)   popw(cx);                             /* pop cx */
    II(0x0013e263, 0x1)   popw(dx);                             /* pop dx */
    II(0x0013e264, 0x3)   mov(ax, memw_a16(ds, 0x1da6));        /* mov ax, [0x1da6] */
    II(0x0013e267, 0x2)   cmp(ax, sp);                          /* cmp ax, sp */
    II(0x0013e269, 0x2)   jaew(0x0013e272, 0x7);                /* jae 0x13e272 */
    II(0x0013e26b, 0x2)   sub(ax, sp);                          /* sub ax, sp */
    II(0x0013e26d, 0x2)   neg(ax);                              /* neg ax */
l_0x0013e26f:
    II(0x0013e26f, 0x1)   pushw(dx);                            /* push dx */
    II(0x0013e270, 0x1)   pushw(cx);                            /* push cx */
    II(0x0013e271, 0x1)   retfw();                              /* retf  */
l_0x0013e272:
    II(0x0013e272, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x0013e274, 0x2)   jmpw(0x0013e26f, -0x7);               /* jmp 0x13e26f */
FUNC_END

