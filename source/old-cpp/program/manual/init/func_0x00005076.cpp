FUNC_BEGIN(0x00005076, 0xa79b6f83a77e056f, 0x10, ({0xc8, 0x18, 0, 0, 0x83, 0x7e, 0x4, 0, 0x75, 0x5, 0xb8, 0x1, 0, 0xc9, 0xc3, 0x8b, 0x46, 0x4, 0x89, 0x46, 0xf0, 0x89, 0x46, 0xea, 0xc6, 0x46, 0xf3, 0x49, 0x8d, 0x46, 0xea, 0x50, 0x8d, 0x46, 0xf2, 0x50, 0x50, 0xe8, 0x6a, 0xc, 0x8b, 0x46, 0xfe, 0xf7, 0xd0, 0x25, 0x1, 0, 0xc9, 0xc3}))
    II(0x00005076, 0x4)   enterw(0x18, 0);                      /* enter 0x18, 0x0 */
    II(0x0000507a, 0x4)   cmp(memw_a16(ss, bp + 0x4), 0);       /* cmp word [bp+0x4], 0x0 */
    II(0x0000507e, 0x2)   jnzw(0x00005085, 0x5);                /* jnz 0x5085 */
    II(0x00005080, 0x3)   mov(ax, 0x1);                         /* mov ax, 0x1 */
    II(0x00005083, 0x1)   leavew();                             /* leave  */
    II(0x00005084, 0x1)   retw();                               /* ret  */
l_0x00005085:
    II(0x00005085, 0x3)   mov(ax, memw_a16(ss, bp + 0x4));      /* mov ax, [bp+0x4] */
    II(0x00005088, 0x3)   mov(memw_a16(ss, bp - 0x10), ax);     /* mov [bp-0x10], ax */
    II(0x0000508b, 0x3)   mov(memw_a16(ss, bp - 0x16), ax);     /* mov [bp-0x16], ax */
    II(0x0000508e, 0x4)   mov(memb_a16(ss, bp - 0xd), 0x49);    /* mov byte [bp-0xd], 0x49 */
    II(0x00005092, 0x3)   lea(ax, bp - 0x16);                   /* lea ax, [bp-0x16] */
    II(0x00005095, 0x1)   pushw(ax);                            /* push ax */
    II(0x00005096, 0x3)   lea(ax, bp - 0xe);                    /* lea ax, [bp-0xe] */
    II(0x00005099, 0x1)   pushw(ax);                            /* push ax */
    II(0x0000509a, 0x1)   pushw(ax);                            /* push ax */
    II(0x0000509b, 0x3)   callw(0x00005d08, 0xc6a);             /* call 0x5d08 */
    II(0x0000509e, 0x3)   mov(ax, memw_a16(ss, bp - 0x2));      /* mov ax, [bp-0x2] */
    II(0x000050a1, 0x2)   not_(ax);                             /* not ax */
    II(0x000050a3, 0x3)   and_(ax, 0x1);                        /* and ax, 0x1 */
    II(0x000050a6, 0x1)   leavew();                             /* leave  */
    II(0x000050a7, 0x1)   retw();                               /* ret  */
FUNC_END

