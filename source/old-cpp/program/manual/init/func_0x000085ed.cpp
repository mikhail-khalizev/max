FUNC_BEGIN(0x000085ed, 0x375a5a011cf4fb80, 0x10, ({0xc8, 0x4, 0, 0, 0x6a, 0x4, 0x8d, 0x46, 0x4, 0x50, 0xe8, 0xa0, 0x11, 0x83, 0xfa, 0x10, 0x7f, 0x2, 0x7c, 0x39, 0x6a, 0x4, 0x68, 0x8, 0xf, 0xff, 0x76, 0x6, 0xff, 0x76, 0x4, 0xe8, 0x3, 0xc2, 0x83, 0xc4, 0x8, 0x6a, 0x4, 0x8d, 0x46, 0xfc, 0x50, 0xff, 0x76, 0x6, 0xff, 0x76, 0x4, 0xe8, 0xbc, 0xc1, 0x83, 0xc4, 0x8, 0xa1, 0x8, 0xf, 0x8b, 0x16, 0xa, 0xf, 0x39, 0x46, 0xfc, 0x75, 0xa, 0x39, 0x56, 0xfe, 0x75, 0x5, 0xb8, 0x1, 0, 0xc9, 0xc3, 0x2b, 0xc0, 0xc9, 0xc3}))
    II(0x000085ed, 0x4)   enterw(0x4, 0);                       /* enter 0x4, 0x0 */
    II(0x000085f1, 0x2)   pushw(0x4);                           /* push 0x4 */
    II(0x000085f3, 0x3)   lea(ax, bp + 0x4);                    /* lea ax, [bp+0x4] */
    II(0x000085f6, 0x1)   pushw(ax);                            /* push ax */
    II(0x000085f7, 0x3)   callw(0x0000979a, 0x11a0);            /* call 0x979a */
    II(0x000085fa, 0x3)   cmp(dx, 0x10);                        /* cmp dx, 0x10 */
    II(0x000085fd, 0x2)   jgw(0x00008601, 0x2);                 /* jg 0x8601 */
    II(0x000085ff, 0x2)   jlw(0x0000863a, 0x39);                /* jl 0x863a */
l_0x00008601:
    II(0x00008601, 0x2)   pushw(0x4);                           /* push 0x4 */
    II(0x00008603, 0x3)   pushw(0xf08);                         /* push word 0xf08 */
    II(0x00008606, 0x3)   pushw(memw_a16(ss, bp + 0x6));        /* push word [bp+0x6] */
    II(0x00008609, 0x3)   pushw(memw_a16(ss, bp + 0x4));        /* push word [bp+0x4] */
    II(0x0000860c, 0x3)   callw(0x00004812, -0x3dfd);           /* call 0x4812 */
    II(0x0000860f, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
    II(0x00008612, 0x2)   pushw(0x4);                           /* push 0x4 */
    II(0x00008614, 0x3)   lea(ax, bp - 0x4);                    /* lea ax, [bp-0x4] */
    II(0x00008617, 0x1)   pushw(ax);                            /* push ax */
    II(0x00008618, 0x3)   pushw(memw_a16(ss, bp + 0x6));        /* push word [bp+0x6] */
    II(0x0000861b, 0x3)   pushw(memw_a16(ss, bp + 0x4));        /* push word [bp+0x4] */
    II(0x0000861e, 0x3)   callw(0x000047dd, -0x3e44);           /* call 0x47dd */
    II(0x00008621, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
    II(0x00008624, 0x3)   mov(ax, memw_a16(ds, 0xf08));         /* mov ax, [0xf08] */
    II(0x00008627, 0x4)   mov(dx, memw_a16(ds, 0xf0a));         /* mov dx, [0xf0a] */
    II(0x0000862b, 0x3)   cmp(memw_a16(ss, bp - 0x4), ax);      /* cmp [bp-0x4], ax */
    II(0x0000862e, 0x2)   jnzw(0x0000863a, 0xa);                /* jnz 0x863a */
    II(0x00008630, 0x3)   cmp(memw_a16(ss, bp - 0x2), dx);      /* cmp [bp-0x2], dx */
    II(0x00008633, 0x2)   jnzw(0x0000863a, 0x5);                /* jnz 0x863a */
    II(0x00008635, 0x3)   mov(ax, 0x1);                         /* mov ax, 0x1 */
    II(0x00008638, 0x1)   leavew();                             /* leave  */
    II(0x00008639, 0x1)   retw();                               /* ret  */
l_0x0000863a:
    II(0x0000863a, 0x2)   sub(ax, ax);                          /* sub ax, ax */
    II(0x0000863c, 0x1)   leavew();                             /* leave  */
    II(0x0000863d, 0x1)   retw();                               /* ret  */
FUNC_END

