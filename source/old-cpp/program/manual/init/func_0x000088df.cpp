FUNC_BEGIN(0x000088df, 0x6e8190a387e47269, 0x10, ({0xc8, 0xa, 0, 0, 0x57, 0x56, 0xc7, 0x46, 0xfc, 0xe0, 0xff, 0xc7, 0x46, 0xfe, 0, 0xf0, 0xa1, 0x9c, 0, 0x8b, 0x16, 0x9e, 0, 0x89, 0x46, 0xf8, 0x89, 0x56, 0xfa, 0x83, 0xfa, 0x1, 0x7f, 0xc, 0x7d, 0xa, 0xc7, 0x46, 0xf8, 0, 0, 0xc7, 0x46, 0xfa, 0x1, 0, 0xa1, 0xc, 0xf, 0x8b, 0x16, 0xe, 0xf, 0xc4, 0x5e, 0xfc, 0x26, 0x39, 0x47, 0xa, 0x75, 0x30, 0x26, 0x39, 0x57, 0xc, 0x75, 0x2a, 0xa1, 0x11, 0xf, 0x26, 0x39, 0x47, 0xe, 0x75, 0x21, 0x81, 0x3e, 0xce, 0xe, 0, 0x3e, 0x72, 0x19, 0x8b, 0x46, 0xf8, 0x8b, 0x56, 0xfa, 0x2b, 0x6, 0x98, 0, 0x1b, 0x16, 0x9a, 0, 0xb1, 0x6, 0xe8, 0x8b, 0xe, 0x3b, 0x6, 0xcc, 0xe, 0x72, 0x5, 0x2b, 0xc0, 0x99, 0xeb, 0x7a, 0xc4, 0x5e, 0xfc, 0x26, 0x8b, 0x7, 0x89, 0x46, 0xfc, 0xa3, 0xec, 0x11, 0x8b, 0xd8, 0x26, 0x83, 0x3f, 0xff, 0x74, 0xe7, 0x26, 0x8b, 0x47, 0x4, 0x26, 0x39, 0x47, 0x2, 0x72, 0xdd, 0x26, 0x3b, 0x47, 0x6, 0x73, 0xd7, 0x89, 0x46, 0xf6, 0x8b, 0x5e, 0x4, 0x89, 0x7, 0x3d, 0, 0x10, 0x72, 0xca, 0x8b, 0x5e, 0xfc, 0x26, 0x8b, 0x47, 0x6, 0xba, 0xf, 0, 0x8b, 0xc8, 0x8b, 0xda, 0x2d, 0x1, 0, 0x83, 0xda, 0, 0x52, 0x50, 0x8b, 0xf1, 0x8b, 0xfb, 0xe8, 0x4d, 0xfc, 0x5b, 0x5b, 0xb, 0xc0, 0x74, 0xa7, 0x2b, 0x76, 0xf6, 0x83, 0xdf, 0, 0x57, 0x56, 0xe8, 0x3c, 0xfc, 0x5b, 0x5b, 0xb, 0xc0, 0x74, 0x96, 0xff, 0x76, 0xf6, 0xe8, 0x44, 0xc9, 0x5b, 0xb, 0xc0, 0x74, 0x8b, 0xc4, 0x5e, 0xfc, 0x26, 0x8b, 0x47, 0x6, 0xba, 0xf, 0, 0x5e, 0x5f, 0xc9, 0xc3}))
    II(0x000088df, 0x4)   enterw(0xa, 0);                       /* enter 0xa, 0x0 */
    II(0x000088e3, 0x1)   pushw(di);                            /* push di */
    II(0x000088e4, 0x1)   pushw(si);                            /* push si */
    II(0x000088e5, 0x5)   mov(memw_a16(ss, bp - 0x4), 0xffe0);  /* mov word [bp-0x4], 0xffe0 */
    II(0x000088ea, 0x5)   mov(memw_a16(ss, bp - 0x2), 0xf000);  /* mov word [bp-0x2], 0xf000 */
    II(0x000088ef, 0x3)   mov(ax, memw_a16(ds, 0x9c));          /* mov ax, [0x9c] */
    II(0x000088f2, 0x4)   mov(dx, memw_a16(ds, 0x9e));          /* mov dx, [0x9e] */
    II(0x000088f6, 0x3)   mov(memw_a16(ss, bp - 0x8), ax);      /* mov [bp-0x8], ax */
    II(0x000088f9, 0x3)   mov(memw_a16(ss, bp - 0x6), dx);      /* mov [bp-0x6], dx */
    II(0x000088fc, 0x3)   cmp(dx, 0x1);                         /* cmp dx, 0x1 */
    II(0x000088ff, 0x2)   jgw(0x0000890d, 0xc);                 /* jg 0x890d */
    II(0x00008901, 0x2)   jgew(0x0000890d, 0xa);                /* jge 0x890d */
    II(0x00008903, 0x5)   mov(memw_a16(ss, bp - 0x8), 0);       /* mov word [bp-0x8], 0x0 */
    II(0x00008908, 0x5)   mov(memw_a16(ss, bp - 0x6), 0x1);     /* mov word [bp-0x6], 0x1 */
l_0x0000890d:
    II(0x0000890d, 0x3)   mov(ax, memw_a16(ds, 0xf0c));         /* mov ax, [0xf0c] */
    II(0x00008910, 0x4)   mov(dx, memw_a16(ds, 0xf0e));         /* mov dx, [0xf0e] */
    II(0x00008914, 0x3)   les(bx, ss, bp - 0x4);                /* les bx, [bp-0x4] */
    II(0x00008917, 0x4)   cmp(memw_a16(es, bx + 0xa), ax);      /* cmp [es:bx+0xa], ax */
    II(0x0000891b, 0x2)   jnzw(0x0000894d, 0x30);               /* jnz 0x894d */
    II(0x0000891d, 0x4)   cmp(memw_a16(es, bx + 0xc), dx);      /* cmp [es:bx+0xc], dx */
    II(0x00008921, 0x2)   jnzw(0x0000894d, 0x2a);               /* jnz 0x894d */
    II(0x00008923, 0x3)   mov(ax, memw_a16(ds, 0xf11));         /* mov ax, [0xf11] */
    II(0x00008926, 0x4)   cmp(memw_a16(es, bx + 0xe), ax);      /* cmp [es:bx+0xe], ax */
    II(0x0000892a, 0x2)   jnzw(0x0000894d, 0x21);               /* jnz 0x894d */
    II(0x0000892c, 0x6)   cmp(memw_a16(ds, 0xece), 0x3e00);     /* cmp word [0xece], 0x3e00 */
    II(0x00008932, 0x2)   jbw(0x0000894d, 0x19);                /* jb 0x894d */
    II(0x00008934, 0x3)   mov(ax, memw_a16(ss, bp - 0x8));      /* mov ax, [bp-0x8] */
    II(0x00008937, 0x3)   mov(dx, memw_a16(ss, bp - 0x6));      /* mov dx, [bp-0x6] */
    II(0x0000893a, 0x4)   sub(ax, memw_a16(ds, 0x98));          /* sub ax, [0x98] */
    II(0x0000893e, 0x4)   sbb(dx, memw_a16(ds, 0x9a));          /* sbb dx, [0x9a] */
    II(0x00008942, 0x2)   mov(cl, 0x6);                         /* mov cl, 0x6 */
    II(0x00008944, 0x3)   callw(0x000097d2, 0xe8b);             /* call 0x97d2 */
    II(0x00008947, 0x4)   cmp(ax, memw_a16(ds, 0xecc));         /* cmp ax, [0xecc] */
    II(0x0000894b, 0x2)   jbw(0x00008952, 0x5);                 /* jb 0x8952 */
l_0x0000894d:
    II(0x0000894d, 0x2)   sub(ax, ax);                          /* sub ax, ax */
    II(0x0000894f, 0x1)   cwd();                                /* cwd  */
    II(0x00008950, 0x2)   jmpw(0x000089cc, 0x7a);               /* jmp 0x89cc */
l_0x00008952:
    II(0x00008952, 0x3)   les(bx, ss, bp - 0x4);                /* les bx, [bp-0x4] */
    II(0x00008955, 0x3)   mov(ax, memw_a16(es, bx));            /* mov ax, [es:bx] */
    II(0x00008958, 0x3)   mov(memw_a16(ss, bp - 0x4), ax);      /* mov [bp-0x4], ax */
    II(0x0000895b, 0x3)   mov(memw_a16(ds, 0x11ec), ax);        /* mov [0x11ec], ax */
    II(0x0000895e, 0x2)   mov(bx, ax);                          /* mov bx, ax */
    II(0x00008960, 0x4)   cmp(memw_a16(es, bx), -0x1 /* 0xff */); /* cmp word [es:bx], 0xff */
    II(0x00008964, 0x2)   jzw(0x0000894d, -0x19);               /* jz 0x894d */
    II(0x00008966, 0x4)   mov(ax, memw_a16(es, bx + 0x4));      /* mov ax, [es:bx+0x4] */
    II(0x0000896a, 0x4)   cmp(memw_a16(es, bx + 0x2), ax);      /* cmp [es:bx+0x2], ax */
    II(0x0000896e, 0x2)   jbw(0x0000894d, -0x23);               /* jb 0x894d */
    II(0x00008970, 0x4)   cmp(ax, memw_a16(es, bx + 0x6));      /* cmp ax, [es:bx+0x6] */
    II(0x00008974, 0x2)   jaew(0x0000894d, -0x29);              /* jae 0x894d */
    II(0x00008976, 0x3)   mov(memw_a16(ss, bp - 0xa), ax);      /* mov [bp-0xa], ax */
    II(0x00008979, 0x3)   mov(bx, memw_a16(ss, bp + 0x4));      /* mov bx, [bp+0x4] */
    II(0x0000897c, 0x2)   mov(memw_a16(ds, bx), ax);            /* mov [bx], ax */
    II(0x0000897e, 0x3)   cmp(ax, 0x1000);                      /* cmp ax, 0x1000 */
    II(0x00008981, 0x2)   jbw(0x0000894d, -0x36);               /* jb 0x894d */
    II(0x00008983, 0x3)   mov(bx, memw_a16(ss, bp - 0x4));      /* mov bx, [bp-0x4] */
    II(0x00008986, 0x4)   mov(ax, memw_a16(es, bx + 0x6));      /* mov ax, [es:bx+0x6] */
    II(0x0000898a, 0x3)   mov(dx, 0xf);                         /* mov dx, 0xf */
    II(0x0000898d, 0x2)   mov(cx, ax);                          /* mov cx, ax */
    II(0x0000898f, 0x2)   mov(bx, dx);                          /* mov bx, dx */
    II(0x00008991, 0x3)   sub(ax, 0x1);                         /* sub ax, 0x1 */
    II(0x00008994, 0x3)   sbb(dx, 0);                           /* sbb dx, 0x0 */
    II(0x00008997, 0x1)   pushw(dx);                            /* push dx */
    II(0x00008998, 0x1)   pushw(ax);                            /* push ax */
    II(0x00008999, 0x2)   mov(si, cx);                          /* mov si, cx */
    II(0x0000899b, 0x2)   mov(di, bx);                          /* mov di, bx */
    II(0x0000899d, 0x3)   callw(0x000085ed, -0x3b3);            /* call 0x85ed */
    II(0x000089a0, 0x1)   popw(bx);                             /* pop bx */
    II(0x000089a1, 0x1)   popw(bx);                             /* pop bx */
    II(0x000089a2, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x000089a4, 0x2)   jzw(0x0000894d, -0x59);               /* jz 0x894d */
    II(0x000089a6, 0x3)   sub(si, memw_a16(ss, bp - 0xa));      /* sub si, [bp-0xa] */
    II(0x000089a9, 0x3)   sbb(di, 0);                           /* sbb di, 0x0 */
    II(0x000089ac, 0x1)   pushw(di);                            /* push di */
    II(0x000089ad, 0x1)   pushw(si);                            /* push si */
    II(0x000089ae, 0x3)   callw(0x000085ed, -0x3c4);            /* call 0x85ed */
    II(0x000089b1, 0x1)   popw(bx);                             /* pop bx */
    II(0x000089b2, 0x1)   popw(bx);                             /* pop bx */
    II(0x000089b3, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x000089b5, 0x2)   jzw(0x0000894d, -0x6a);               /* jz 0x894d */
    II(0x000089b7, 0x3)   pushw(memw_a16(ss, bp - 0xa));        /* push word [bp-0xa] */
    II(0x000089ba, 0x3)   callw(0x00005301, -0x36bc);           /* call 0x5301 */
    II(0x000089bd, 0x1)   popw(bx);                             /* pop bx */
    II(0x000089be, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x000089c0, 0x2)   jzw(0x0000894d, -0x75);               /* jz 0x894d */
    II(0x000089c2, 0x3)   les(bx, ss, bp - 0x4);                /* les bx, [bp-0x4] */
    II(0x000089c5, 0x4)   mov(ax, memw_a16(es, bx + 0x6));      /* mov ax, [es:bx+0x6] */
    II(0x000089c9, 0x3)   mov(dx, 0xf);                         /* mov dx, 0xf */
l_0x000089cc:
    II(0x000089cc, 0x1)   popw(si);                             /* pop si */
    II(0x000089cd, 0x1)   popw(di);                             /* pop di */
    II(0x000089ce, 0x1)   leavew();                             /* leave  */
    II(0x000089cf, 0x1)   retw();                               /* ret  */
FUNC_END

