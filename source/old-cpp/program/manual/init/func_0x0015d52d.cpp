FUNC_BEGIN(0x0015d52d, 0x5054929129aa6aa0, 0x10, ({0xc8, 0x1c, 0, 0, 0x8b, 0x46, 0x6, 0x8b, 0x56, 0x8, 0x89, 0x46, 0xe4, 0x89, 0x56, 0xe6, 0x8b, 0x46, 0xa, 0x89, 0x46, 0xf4, 0xc7, 0x46, 0xf6, 0, 0, 0x8b, 0x46, 0xc, 0x89, 0x46, 0xf8, 0xa1, 0x96, 0x32, 0xb, 0x6, 0x94, 0x32, 0x74, 0x9, 0xa1, 0xec, 0x19, 0xb, 0x6, 0xea, 0x19, 0x75, 0x1c, 0x6a, 0x4, 0xff, 0x76, 0xc, 0xff, 0x76, 0xa, 0x52, 0xff, 0x76, 0x6, 0x8d, 0x46, 0xec, 0x16, 0x50, 0xe8, 0x10, 0xf1, 0x89, 0x46, 0xf0, 0x89, 0x56, 0xf2, 0xeb, 0xb, 0x8d, 0x46, 0xe4, 0x16, 0x50, 0xff, 0x1e, 0x94, 0x32, 0x5b, 0x5b, 0x8b, 0x46, 0xf0, 0x8b, 0x56, 0xf2, 0x39, 0x16, 0xec, 0x19, 0x72, 0x20, 0x77, 0x6, 0x39, 0x6, 0xea, 0x19, 0x76, 0x18, 0xa1, 0x84, 0x2a, 0x8b, 0x16, 0x86, 0x2a, 0x89, 0x46, 0xa, 0x89, 0x56, 0xc, 0x8e, 0xc2, 0x8b, 0xd8, 0x26, 0xfe, 0x47, 0x7, 0xe9, 0x7e, 0xff, 0xc9, 0xcb}))
    II(0x0015d52d, 0x4)   enterw(0x1c, 0);                      /* enter 0x1c, 0x0 */
l_0x0015d531:
    II(0x0015d531, 0x3)   mov(ax, memw_a16(ss, bp + 0x6));      /* mov ax, [bp+0x6] */
    II(0x0015d534, 0x3)   mov(dx, memw_a16(ss, bp + 0x8));      /* mov dx, [bp+0x8] */
    II(0x0015d537, 0x3)   mov(memw_a16(ss, bp - 0x1c), ax);     /* mov [bp-0x1c], ax */
    II(0x0015d53a, 0x3)   mov(memw_a16(ss, bp - 0x1a), dx);     /* mov [bp-0x1a], dx */
    II(0x0015d53d, 0x3)   mov(ax, memw_a16(ss, bp + 0xa));      /* mov ax, [bp+0xa] */
    II(0x0015d540, 0x3)   mov(memw_a16(ss, bp - 0xc), ax);      /* mov [bp-0xc], ax */
    II(0x0015d543, 0x5)   mov(memw_a16(ss, bp - 0xa), 0);       /* mov word [bp-0xa], 0x0 */
    II(0x0015d548, 0x3)   mov(ax, memw_a16(ss, bp + 0xc));      /* mov ax, [bp+0xc] */
    II(0x0015d54b, 0x3)   mov(memw_a16(ss, bp - 0x8), ax);      /* mov [bp-0x8], ax */
    II(0x0015d54e, 0x3)   mov(ax, memw_a16(ds, 0x3296));        /* mov ax, [0x3296] */
    II(0x0015d551, 0x4)   or_(ax, memw_a16(ds, 0x3294));        /* or ax, [0x3294] */
    II(0x0015d555, 0x2)   jzw(0x0015d560, 0x9);                 /* jz 0x15d560 */
    II(0x0015d557, 0x3)   mov(ax, memw_a16(ds, 0x19ec));        /* mov ax, [0x19ec] */
    II(0x0015d55a, 0x4)   or_(ax, memw_a16(ds, 0x19ea));        /* or ax, [0x19ea] */
    II(0x0015d55e, 0x2)   jnzw(0x0015d57c, 0x1c);               /* jnz 0x15d57c */
l_0x0015d560:
    II(0x0015d560, 0x2)   pushw(0x4);                           /* push 0x4 */
    II(0x0015d562, 0x3)   pushw(memw_a16(ss, bp + 0xc));        /* push word [bp+0xc] */
    II(0x0015d565, 0x3)   pushw(memw_a16(ss, bp + 0xa));        /* push word [bp+0xa] */
    II(0x0015d568, 0x1)   pushw(dx);                            /* push dx */
    II(0x0015d569, 0x3)   pushw(memw_a16(ss, bp + 0x6));        /* push word [bp+0x6] */
    II(0x0015d56c, 0x3)   lea(ax, bp - 0x14);                   /* lea ax, [bp-0x14] */
    II(0x0015d56f, 0x1)   pushw(ss);                            /* push ss */
    II(0x0015d570, 0x1)   pushw(ax);                            /* push ax */
    II(0x0015d571, 0x3)   callw(0x0015c684, -0xef0);            /* call 0x15c684 */
    II(0x0015d574, 0x3)   mov(memw_a16(ss, bp - 0x10), ax);     /* mov [bp-0x10], ax */
    II(0x0015d577, 0x3)   mov(memw_a16(ss, bp - 0xe), dx);      /* mov [bp-0xe], dx */
    II(0x0015d57a, 0x2)   jmpw(0x0015d587, 0xb);                /* jmp 0x15d587 */
l_0x0015d57c:
    II(0x0015d57c, 0x3)   lea(ax, bp - 0x1c);                   /* lea ax, [bp-0x1c] */
    II(0x0015d57f, 0x1)   pushw(ss);                            /* push ss */
    II(0x0015d580, 0x1)   pushw(ax);                            /* push ax */
    II(0x0015d581, 0x4)   callw_a16_far_ind(ds, 0x3294);        /* call word far [0x3294] */
    II(0x0015d585, 0x1)   popw(bx);                             /* pop bx */
    II(0x0015d586, 0x1)   popw(bx);                             /* pop bx */
l_0x0015d587:
    II(0x0015d587, 0x3)   mov(ax, memw_a16(ss, bp - 0x10));     /* mov ax, [bp-0x10] */
    II(0x0015d58a, 0x3)   mov(dx, memw_a16(ss, bp - 0xe));      /* mov dx, [bp-0xe] */
    II(0x0015d58d, 0x4)   cmp(memw_a16(ds, 0x19ec), dx);        /* cmp [0x19ec], dx */
    II(0x0015d591, 0x2)   jbw(0x0015d5b3, 0x20);                /* jb 0x15d5b3 */
    II(0x0015d593, 0x2)   jaw(0x0015d59b, 0x6);                 /* ja 0x15d59b */
    II(0x0015d595, 0x4)   cmp(memw_a16(ds, 0x19ea), ax);        /* cmp [0x19ea], ax */
    II(0x0015d599, 0x2)   jbew(0x0015d5b3, 0x18);               /* jbe 0x15d5b3 */
l_0x0015d59b:
    II(0x0015d59b, 0x3)   mov(ax, memw_a16(ds, 0x2a84));        /* mov ax, [0x2a84] */
    II(0x0015d59e, 0x4)   mov(dx, memw_a16(ds, 0x2a86));        /* mov dx, [0x2a86] */
    II(0x0015d5a2, 0x3)   mov(memw_a16(ss, bp + 0xa), ax);      /* mov [bp+0xa], ax */
    II(0x0015d5a5, 0x3)   mov(memw_a16(ss, bp + 0xc), dx);      /* mov [bp+0xc], dx */
    II(0x0015d5a8, 0x2)   mov(es, dx);                          /* mov es, dx */
    II(0x0015d5aa, 0x2)   mov(bx, ax);                          /* mov bx, ax */
    II(0x0015d5ac, 0x4)   inc(memb_a16(es, bx + 0x7));          /* inc byte [es:bx+0x7] */
    II(0x0015d5b0, 0x3)   jmpw(0x0015d531, -0x82);              /* jmp 0x15d531 */
l_0x0015d5b3:
    II(0x0015d5b3, 0x1)   leavew();                             /* leave  */
    II(0x0015d5b4, 0x1)   retfw();                              /* retf  */
FUNC_END

