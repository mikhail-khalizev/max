FUNC_BEGIN(0x00159db8, 0x6dd3abdec8d98bf9, 0x10, ({0x1e, 0x68, 0x88, 0x1f, 0x68, 0x64, 0x13, 0xe8, 0x6e, 0xfe, 0xa3, 0x1a, 0x1f, 0x89, 0x16, 0x1c, 0x1f, 0x8b, 0xc2, 0xb, 0x6, 0x1a, 0x1f, 0x75, 0x3, 0x2b, 0xc0, 0xc3, 0xc4, 0x1e, 0x1a, 0x1f, 0x26, 0x80, 0x3f, 0, 0x75, 0x24, 0x6a, 0, 0x68, 0x64, 0x13, 0x6, 0x53, 0x90, 0xe, 0xe8, 0xc5, 0x71, 0x83, 0xc4, 0x8, 0x68, 0xff, 0, 0x6a, 0x10, 0xff, 0x36, 0x1c, 0x1f, 0xff, 0x36, 0x1a, 0x1f, 0x90, 0xe, 0xe8, 0xb0, 0x71, 0x83, 0xc4, 0x8, 0xc4, 0x1e, 0x1a, 0x1f, 0x26, 0xff, 0x47, 0x10, 0xb8, 0x1, 0, 0xc3}))
    II(0x00159db8, 0x1)   pushw(ds);                            /* push ds */
    II(0x00159db9, 0x3)   pushw(0x1f88);                        /* push word 0x1f88 */
    II(0x00159dbc, 0x3)   pushw(0x1364);                        /* push word 0x1364 */
    II(0x00159dbf, 0x3)   callw(0x00159c30, -0x192);            /* call 0x159c30 */
    II(0x00159dc2, 0x3)   mov(memw_a16(ds, 0x1f1a), ax);        /* mov [0x1f1a], ax */
    II(0x00159dc5, 0x4)   mov(memw_a16(ds, 0x1f1c), dx);        /* mov [0x1f1c], dx */
    II(0x00159dc9, 0x2)   mov(ax, dx);                          /* mov ax, dx */
    II(0x00159dcb, 0x4)   or_(ax, memw_a16(ds, 0x1f1a));        /* or ax, [0x1f1a] */
    II(0x00159dcf, 0x2)   jnzw(0x00159dd4, 0x3);                /* jnz 0x159dd4 */
    II(0x00159dd1, 0x2)   sub(ax, ax);                          /* sub ax, ax */
    II(0x00159dd3, 0x1)   retw();                               /* ret  */
l_0x00159dd4:
    II(0x00159dd4, 0x4)   les(bx, ds, 0x1f1a);                  /* les bx, [0x1f1a] */
    II(0x00159dd8, 0x4)   cmp(memb_a16(es, bx), 0);             /* cmp byte [es:bx], 0x0 */
    II(0x00159ddc, 0x2)   jnzw(0x00159e02, 0x24);               /* jnz 0x159e02 */
    II(0x00159dde, 0x2)   pushw(0);                             /* push 0x0 */
    II(0x00159de0, 0x3)   pushw(0x1364);                        /* push word 0x1364 */
    II(0x00159de3, 0x1)   pushw(es);                            /* push es */
    II(0x00159de4, 0x1)   pushw(bx);                            /* push bx */
//    II(0x00159de5, 0x1)   nop();                                /* nop  */
    II(0x00159de6, 0x1)   pushw(cs);                            /* push cs */
    II(0x00159de7, 0x3)   callw(0x00160faf, 0x71c5);            /* call 0x160faf */
    II(0x00159dea, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
    II(0x00159ded, 0x3)   pushw(0xff);                          /* push word 0xff */
    II(0x00159df0, 0x2)   pushw(0x10);                          /* push 0x10 */
    II(0x00159df2, 0x4)   pushw(memw_a16(ds, 0x1f1c));          /* push word [0x1f1c] */
    II(0x00159df6, 0x4)   pushw(memw_a16(ds, 0x1f1a));          /* push word [0x1f1a] */
//    II(0x00159dfa, 0x1)   nop();                                /* nop  */
    II(0x00159dfb, 0x1)   pushw(cs);                            /* push cs */
    II(0x00159dfc, 0x3)   callw(0x00160faf, 0x71b0);            /* call 0x160faf */
    II(0x00159dff, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
l_0x00159e02:
    II(0x00159e02, 0x4)   les(bx, ds, 0x1f1a);                  /* les bx, [0x1f1a] */
    II(0x00159e06, 0x4)   inc(memw_a16(es, bx + 0x10));         /* inc word [es:bx+0x10] */
    II(0x00159e0a, 0x3)   mov(ax, 0x1);                         /* mov ax, 0x1 */
    II(0x00159e0d, 0x1)   retw();                               /* ret  */
FUNC_END

