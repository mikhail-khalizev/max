FUNC_BEGIN(0x00009686, 0xf4c67bc4bae97aa2, 0x10, ({0xc8, 0x14, 0, 0, 0x83, 0x3e, 0x12, 0xa, 0x1, 0x7c, 0x3, 0xe9, 0x9c, 0, 0x2b, 0xc0, 0x89, 0x46, 0xf0, 0x89, 0x46, 0xee, 0xf6, 0x6, 0x47, 0, 0x80, 0x74, 0x27, 0xa1, 0xf4, 0xd, 0xa3, 0xaa, 0, 0xc7, 0x46, 0xf2, 0xde, 0xbf, 0xc7, 0x46, 0xf4, 0x2, 0, 0x2b, 0xc0, 0x89, 0x46, 0xf6, 0x89, 0x46, 0xf8, 0x8d, 0x46, 0xf2, 0x50, 0x50, 0x6a, 0x15, 0xe8, 0x5f, 0x7, 0x83, 0xc4, 0x6, 0xc9, 0xc3, 0x8b, 0x46, 0xf0, 0xb, 0x46, 0xee, 0x75, 0x46, 0xe8, 0xef, 0xc5, 0x89, 0x46, 0xec, 0xe8, 0x4f, 0xc0, 0x8b, 0x46, 0xec, 0xc1, 0xe8, 0x4, 0x6a, 0, 0x50, 0xe8, 0x21, 0xc5, 0x5b, 0x5b, 0x89, 0x46, 0xee, 0x89, 0x56, 0xf0, 0xb, 0xd0, 0x74, 0x22, 0x68, 0x92, 0, 0x6a, 0xff, 0xff, 0x76, 0xf0, 0x50, 0x6a, 0x60, 0xe8, 0x1b, 0xc5, 0x83, 0xc4, 0xa, 0xff, 0x76, 0xec, 0x6a, 0, 0x6a, 0x60, 0x6a, 0, 0x6a, 0x70, 0xe8, 0x90, 0x7, 0x83, 0xc4, 0xa, 0xe8, 0x49, 0xb8, 0x8b, 0x46, 0xf0, 0xb, 0x46, 0xee, 0x74, 0x10, 0x8b, 0x46, 0xee, 0x8b, 0x56, 0xf0, 0xa3, 0x10, 0xa, 0x89, 0x16, 0x12, 0xa, 0xe8, 0x9e, 0xc5, 0xc9, 0xc3}))
    II(0x00009686, 0x4)   enterw(0x14, 0);                      /* enter 0x14, 0x0 */
    II(0x0000968a, 0x5)   cmp(memw_a16(ds, 0xa12), 0x1);        /* cmp word [0xa12], 0x1 */
    II(0x0000968f, 0x2)   jlw(0x00009694, 0x3);                 /* jl 0x9694 */
    II(0x00009691, 0x3)   jmpw(0x00009730, 0x9c);               /* jmp 0x9730 */
l_0x00009694:
    II(0x00009694, 0x2)   sub(ax, ax);                          /* sub ax, ax */
    II(0x00009696, 0x3)   mov(memw_a16(ss, bp - 0x10), ax);     /* mov [bp-0x10], ax */
    II(0x00009699, 0x3)   mov(memw_a16(ss, bp - 0x12), ax);     /* mov [bp-0x12], ax */
    II(0x0000969c, 0x5)   test(memb_a16(ds, 0x47), 0x80);       /* test byte [0x47], 0x80 */
    II(0x000096a1, 0x2)   jzw(0x000096ca, 0x27);                /* jz 0x96ca */
    II(0x000096a3, 0x3)   mov(ax, memw_a16(ds, 0xdf4));         /* mov ax, [0xdf4] */
    II(0x000096a6, 0x3)   mov(memw_a16(ds, 0xaa), ax);          /* mov [0xaa], ax */
    II(0x000096a9, 0x5)   mov(memw_a16(ss, bp - 0xe), 0xbfde);  /* mov word [bp-0xe], 0xbfde */
    II(0x000096ae, 0x5)   mov(memw_a16(ss, bp - 0xc), 0x2);     /* mov word [bp-0xc], 0x2 */
    II(0x000096b3, 0x2)   sub(ax, ax);                          /* sub ax, ax */
    II(0x000096b5, 0x3)   mov(memw_a16(ss, bp - 0xa), ax);      /* mov [bp-0xa], ax */
    II(0x000096b8, 0x3)   mov(memw_a16(ss, bp - 0x8), ax);      /* mov [bp-0x8], ax */
    II(0x000096bb, 0x3)   lea(ax, bp - 0xe);                    /* lea ax, [bp-0xe] */
    II(0x000096be, 0x1)   pushw(ax);                            /* push ax */
    II(0x000096bf, 0x1)   pushw(ax);                            /* push ax */
    II(0x000096c0, 0x2)   pushw(0x15);                          /* push 0x15 */
    II(0x000096c2, 0x3)   callw(0x00009e24, 0x75f);             /* call 0x9e24 */
    II(0x000096c5, 0x3)   add(sp, 0x6);                         /* add sp, 0x6 */
    II(0x000096c8, 0x1)   leavew();                             /* leave  */
    II(0x000096c9, 0x1)   retw();                               /* ret  */
l_0x000096ca:
    II(0x000096ca, 0x3)   mov(ax, memw_a16(ss, bp - 0x10));     /* mov ax, [bp-0x10] */
    II(0x000096cd, 0x3)   or_(ax, memw_a16(ss, bp - 0x12));     /* or ax, [bp-0x12] */
    II(0x000096d0, 0x2)   jnzw(0x00009718, 0x46);               /* jnz 0x9718 */
    II(0x000096d2, 0x3)   callw(0x00005cc4, -0x3a11);           /* call 0x5cc4 */
    II(0x000096d5, 0x3)   mov(memw_a16(ss, bp - 0x14), ax);     /* mov [bp-0x14], ax */
    II(0x000096d8, 0x3)   callw(0x0000572a, -0x3fb1);           /* call 0x572a */
    II(0x000096db, 0x3)   mov(ax, memw_a16(ss, bp - 0x14));     /* mov ax, [bp-0x14] */
    II(0x000096de, 0x3)   shr(ax, 0x4);                         /* shr ax, 0x4 */
    II(0x000096e1, 0x2)   pushw(0);                             /* push 0x0 */
    II(0x000096e3, 0x1)   pushw(ax);                            /* push ax */
    II(0x000096e4, 0x3)   callw(0x00005c08, -0x3adf);           /* call 0x5c08 */
    II(0x000096e7, 0x1)   popw(bx);                             /* pop bx */
    II(0x000096e8, 0x1)   popw(bx);                             /* pop bx */
    II(0x000096e9, 0x3)   mov(memw_a16(ss, bp - 0x12), ax);     /* mov [bp-0x12], ax */
    II(0x000096ec, 0x3)   mov(memw_a16(ss, bp - 0x10), dx);     /* mov [bp-0x10], dx */
    II(0x000096ef, 0x2)   or_(dx, ax);                          /* or dx, ax */
    II(0x000096f1, 0x2)   jzw(0x00009715, 0x22);                /* jz 0x9715 */
    II(0x000096f3, 0x3)   pushw(0x92);                          /* push word 0x92 */
    II(0x000096f6, 0x2)   pushw(-0x1 /* 0xff */);               /* push 0xff */
    II(0x000096f8, 0x3)   pushw(memw_a16(ss, bp - 0x10));       /* push word [bp-0x10] */
    II(0x000096fb, 0x1)   pushw(ax);                            /* push ax */
    II(0x000096fc, 0x2)   pushw(0x60);                          /* push 0x60 */
    II(0x000096fe, 0x3)   callw(0x00005c1c, -0x3ae5);           /* call 0x5c1c */
    II(0x00009701, 0x3)   add(sp, 0xa);                         /* add sp, 0xa */
    II(0x00009704, 0x3)   pushw(memw_a16(ss, bp - 0x14));       /* push word [bp-0x14] */
    II(0x00009707, 0x2)   pushw(0);                             /* push 0x0 */
    II(0x00009709, 0x2)   pushw(0x60);                          /* push 0x60 */
    II(0x0000970b, 0x2)   pushw(0);                             /* push 0x0 */
    II(0x0000970d, 0x2)   pushw(0x70);                          /* push 0x70 */
    II(0x0000970f, 0x3)   callw(0x00009ea2, 0x790);             /* call 0x9ea2 */
    II(0x00009712, 0x3)   add(sp, 0xa);                         /* add sp, 0xa */
l_0x00009715:
    II(0x00009715, 0x3)   callw(0x00004f61, -0x47b7);           /* call 0x4f61 */
l_0x00009718:
    II(0x00009718, 0x3)   mov(ax, memw_a16(ss, bp - 0x10));     /* mov ax, [bp-0x10] */
    II(0x0000971b, 0x3)   or_(ax, memw_a16(ss, bp - 0x12));     /* or ax, [bp-0x12] */
    II(0x0000971e, 0x2)   jzw(0x00009730, 0x10);                /* jz 0x9730 */
    II(0x00009720, 0x3)   mov(ax, memw_a16(ss, bp - 0x12));     /* mov ax, [bp-0x12] */
    II(0x00009723, 0x3)   mov(dx, memw_a16(ss, bp - 0x10));     /* mov dx, [bp-0x10] */
    II(0x00009726, 0x3)   mov(memw_a16(ds, 0xa10), ax);         /* mov [0xa10], ax */
    II(0x00009729, 0x4)   mov(memw_a16(ds, 0xa12), dx);         /* mov [0xa12], dx */
    II(0x0000972d, 0x3)   callw(0x00005cce, -0x3a62);           /* call 0x5cce */
l_0x00009730:
    II(0x00009730, 0x1)   leavew();                             /* leave  */
    II(0x00009731, 0x1)   retw();                               /* ret  */
FUNC_END

