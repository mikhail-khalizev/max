FUNC_BEGIN(0x0014a481, 0xb8eb5cae7415cc5d, 0x10, ({0xff, 0x76, 0x14, 0x33, 0xc0, 0x8a, 0x46, 0x16, 0x50, 0xff, 0x76, 0x10, 0xe8, 0xad, 0x2d, 0x83, 0xc4, 0x6, 0x89, 0x46, 0x6, 0xb, 0xc0, 0x74, 0x4, 0x80, 0x66, 0x26, 0xfe}))
    II(0x0014a481, 0x3)   pushw(memw_a16(ss, bp + 0x14));       /* push word [bp+0x14] */
    II(0x0014a484, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x0014a486, 0x3)   mov(al, memb_a16(ss, bp + 0x16));     /* mov al, [bp+0x16] */
    II(0x0014a489, 0x1)   pushw(ax);                            /* push ax */
    II(0x0014a48a, 0x3)   pushw(memw_a16(ss, bp + 0x10));       /* push word [bp+0x10] */
    II(0x0014a48d, 0x3)   callw(0x0014d23d, 0x2dad);            /* call 0x14d23d */
    II(0x0014a490, 0x3)   add(sp, 0x6);                         /* add sp, 0x6 */
    II(0x0014a493, 0x3)   mov(memw_a16(ss, bp + 0x6), ax);      /* mov [bp+0x6], ax */
    II(0x0014a496, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x0014a498, 0x2)   jzw_func(0x0014a49e, 0x4);            /* jz 0x14a49e */
    II(0x0014a49a, 0x4)   and_(memb_a16(ss, bp + 0x26), -0x2 /* 0xfe */); /* and byte [bp+0x26], 0xfe */
    II(0x0014a49e, 0)     jmpd_func(0x0014a49e, 0);             /* Принудительное завершение функции. */
FUNC_END

