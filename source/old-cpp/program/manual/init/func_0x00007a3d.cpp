FUNC_BEGIN(0x00007a3d, 0x45ee1b2a99d76887, 0x10, ({0xc8, 0x12, 0, 0, 0x57, 0x56, 0xe8, 0xe4, 0xdc, 0x8b, 0x46, 0x4, 0x2b, 0xd2, 0x8b, 0xc8, 0x8b, 0xda, 0x89, 0x56, 0xfa, 0x89, 0x46, 0xfc, 0x2d, 0x8, 0, 0x89, 0x56, 0xf2, 0x89, 0x46, 0xf4, 0x80, 0xcb, 0x8, 0x8e, 0xc3, 0x8b, 0xd9, 0x26, 0x8b, 0x37, 0x46, 0xd1, 0xee, 0xeb, 0x73, 0x8b, 0xde, 0xd1, 0xe3, 0x3, 0x5e, 0xf2, 0x8e, 0x46, 0xf4, 0x26, 0x8b, 0x3f, 0x81, 0xff, 0x80, 0, 0x72, 0x60, 0x39, 0x7e, 0x6, 0x75, 0xd, 0x8b, 0x46, 0x8, 0x8b, 0xde, 0xd1, 0xe3, 0x3, 0x5e, 0xf2, 0x26, 0x89, 0x7, 0x8b, 0x46, 0x6, 0x8b, 0xde, 0xd1, 0xe3, 0x3, 0x5e, 0xfa, 0x8e, 0x46, 0xfc, 0x26, 0x8b, 0x1f, 0x8b, 0xcf, 0x8e, 0xc1, 0x89, 0x5e, 0xee, 0x8c, 0x46, 0xf0, 0x26, 0x39, 0x7, 0x75, 0x2f, 0x8b, 0xc7, 0x24, 0xf8, 0x8b, 0xd8, 0xb9, 0x8, 0, 0x8e, 0xc1, 0x26, 0x8a, 0x47, 0x5, 0x88, 0x46, 0xfe, 0x26, 0xc6, 0x47, 0x5, 0xf2, 0x8b, 0x46, 0x8, 0x8b, 0xcb, 0x8c, 0xc2, 0xc4, 0x5e, 0xee, 0x26, 0x89, 0x7, 0x8a, 0x46, 0xfe, 0x8e, 0xc2, 0x8b, 0xd9, 0x26, 0x88, 0x47, 0x5, 0x4e, 0x79, 0x8a, 0x8b, 0x46, 0x6, 0x24, 0xf8, 0x8b, 0xd8, 0xb9, 0x8, 0, 0x8e, 0xc1, 0x26, 0xc6, 0x47, 0x5, 0x80, 0x8b, 0x46, 0x8, 0x26, 0x89, 0x47, 0x6, 0xe8, 0x63, 0xd4, 0x5e, 0x5f, 0xc9, 0xc3}))
    II(0x00007a3d, 0x4)   enterw(0x12, 0);                      /* enter 0x12, 0x0 */
    II(0x00007a41, 0x1)   pushw(di);                            /* push di */
    II(0x00007a42, 0x1)   pushw(si);                            /* push si */
    II(0x00007a43, 0x3)   callw(0x0000572a, -0x231c);           /* call 0x572a */
    II(0x00007a46, 0x3)   mov(ax, memw_a16(ss, bp + 0x4));      /* mov ax, [bp+0x4] */
    II(0x00007a49, 0x2)   sub(dx, dx);                          /* sub dx, dx */
    II(0x00007a4b, 0x2)   mov(cx, ax);                          /* mov cx, ax */
    II(0x00007a4d, 0x2)   mov(bx, dx);                          /* mov bx, dx */
    II(0x00007a4f, 0x3)   mov(memw_a16(ss, bp - 0x6), dx);      /* mov [bp-0x6], dx */
    II(0x00007a52, 0x3)   mov(memw_a16(ss, bp - 0x4), ax);      /* mov [bp-0x4], ax */
    II(0x00007a55, 0x3)   sub(ax, 0x8);                         /* sub ax, 0x8 */
    II(0x00007a58, 0x3)   mov(memw_a16(ss, bp - 0xe), dx);      /* mov [bp-0xe], dx */
    II(0x00007a5b, 0x3)   mov(memw_a16(ss, bp - 0xc), ax);      /* mov [bp-0xc], ax */
    II(0x00007a5e, 0x3)   or_(bl, 0x8);                         /* or bl, 0x8 */
    II(0x00007a61, 0x2)   mov(es, bx);                          /* mov es, bx */
    II(0x00007a63, 0x2)   mov(bx, cx);                          /* mov bx, cx */
    II(0x00007a65, 0x3)   mov(si, memw_a16(es, bx));            /* mov si, [es:bx] */
    II(0x00007a68, 0x1)   inc(si);                              /* inc si */
    II(0x00007a69, 0x2)   shr(si, 0x1);                         /* shr si, 1 */
    II(0x00007a6b, 0x2)   jmpw(0x00007ae0, 0x73);               /* jmp 0x7ae0 */
l_0x00007a6d:
    II(0x00007a6d, 0x2)   mov(bx, si);                          /* mov bx, si */
    II(0x00007a6f, 0x2)   shl(bx, 0x1);                         /* shl bx, 1 */
    II(0x00007a71, 0x3)   add(bx, memw_a16(ss, bp - 0xe));      /* add bx, [bp-0xe] */
    II(0x00007a74, 0x3)   mov(es, memw_a16(ss, bp - 0xc));      /* mov es, [bp-0xc] */
    II(0x00007a77, 0x3)   mov(di, memw_a16(es, bx));            /* mov di, [es:bx] */
    II(0x00007a7a, 0x4)   cmp(di, 0x80);                        /* cmp di, 0x80 */
    II(0x00007a7e, 0x2)   jbw(0x00007ae0, 0x60);                /* jb 0x7ae0 */
    II(0x00007a80, 0x3)   cmp(memw_a16(ss, bp + 0x6), di);      /* cmp [bp+0x6], di */
    II(0x00007a83, 0x2)   jnzw(0x00007a92, 0xd);                /* jnz 0x7a92 */
    II(0x00007a85, 0x3)   mov(ax, memw_a16(ss, bp + 0x8));      /* mov ax, [bp+0x8] */
    II(0x00007a88, 0x2)   mov(bx, si);                          /* mov bx, si */
    II(0x00007a8a, 0x2)   shl(bx, 0x1);                         /* shl bx, 1 */
    II(0x00007a8c, 0x3)   add(bx, memw_a16(ss, bp - 0xe));      /* add bx, [bp-0xe] */
    II(0x00007a8f, 0x3)   mov(memw_a16(es, bx), ax);            /* mov [es:bx], ax */
l_0x00007a92:
    II(0x00007a92, 0x3)   mov(ax, memw_a16(ss, bp + 0x6));      /* mov ax, [bp+0x6] */
    II(0x00007a95, 0x2)   mov(bx, si);                          /* mov bx, si */
    II(0x00007a97, 0x2)   shl(bx, 0x1);                         /* shl bx, 1 */
    II(0x00007a99, 0x3)   add(bx, memw_a16(ss, bp - 0x6));      /* add bx, [bp-0x6] */
    II(0x00007a9c, 0x3)   mov(es, memw_a16(ss, bp - 0x4));      /* mov es, [bp-0x4] */
    II(0x00007a9f, 0x3)   mov(bx, memw_a16(es, bx));            /* mov bx, [es:bx] */
    II(0x00007aa2, 0x2)   mov(cx, di);                          /* mov cx, di */
    II(0x00007aa4, 0x2)   mov(es, cx);                          /* mov es, cx */
    II(0x00007aa6, 0x3)   mov(memw_a16(ss, bp - 0x12), bx);     /* mov [bp-0x12], bx */
    II(0x00007aa9, 0x3)   mov(memw_a16(ss, bp - 0x10), es);     /* mov [bp-0x10], es */
    II(0x00007aac, 0x3)   cmp(memw_a16(es, bx), ax);            /* cmp [es:bx], ax */
    II(0x00007aaf, 0x2)   jnzw(0x00007ae0, 0x2f);               /* jnz 0x7ae0 */
    II(0x00007ab1, 0x2)   mov(ax, di);                          /* mov ax, di */
    II(0x00007ab3, 0x2)   and_(al, 0xf8);                       /* and al, 0xf8 */
    II(0x00007ab5, 0x2)   mov(bx, ax);                          /* mov bx, ax */
    II(0x00007ab7, 0x3)   mov(cx, 0x8);                         /* mov cx, 0x8 */
    II(0x00007aba, 0x2)   mov(es, cx);                          /* mov es, cx */
    II(0x00007abc, 0x4)   mov(al, memb_a16(es, bx + 0x5));      /* mov al, [es:bx+0x5] */
    II(0x00007ac0, 0x3)   mov(memb_a16(ss, bp - 0x2), al);      /* mov [bp-0x2], al */
    II(0x00007ac3, 0x5)   mov(memb_a16(es, bx + 0x5), 0xf2);    /* mov byte [es:bx+0x5], 0xf2 */
    II(0x00007ac8, 0x3)   mov(ax, memw_a16(ss, bp + 0x8));      /* mov ax, [bp+0x8] */
    II(0x00007acb, 0x2)   mov(cx, bx);                          /* mov cx, bx */
    II(0x00007acd, 0x2)   mov(dx, es);                          /* mov dx, es */
    II(0x00007acf, 0x3)   les(bx, ss, bp - 0x12);               /* les bx, [bp-0x12] */
    II(0x00007ad2, 0x3)   mov(memw_a16(es, bx), ax);            /* mov [es:bx], ax */
    II(0x00007ad5, 0x3)   mov(al, memb_a16(ss, bp - 0x2));      /* mov al, [bp-0x2] */
    II(0x00007ad8, 0x2)   mov(es, dx);                          /* mov es, dx */
    II(0x00007ada, 0x2)   mov(bx, cx);                          /* mov bx, cx */
    II(0x00007adc, 0x4)   mov(memb_a16(es, bx + 0x5), al);      /* mov [es:bx+0x5], al */
l_0x00007ae0:
    II(0x00007ae0, 0x1)   dec(si);                              /* dec si */
    II(0x00007ae1, 0x2)   jnsw(0x00007a6d, -0x76);              /* jns 0x7a6d */
    II(0x00007ae3, 0x3)   mov(ax, memw_a16(ss, bp + 0x6));      /* mov ax, [bp+0x6] */
    II(0x00007ae6, 0x2)   and_(al, 0xf8);                       /* and al, 0xf8 */
    II(0x00007ae8, 0x2)   mov(bx, ax);                          /* mov bx, ax */
    II(0x00007aea, 0x3)   mov(cx, 0x8);                         /* mov cx, 0x8 */
    II(0x00007aed, 0x2)   mov(es, cx);                          /* mov es, cx */
    II(0x00007aef, 0x5)   mov(memb_a16(es, bx + 0x5), 0x80);    /* mov byte [es:bx+0x5], 0x80 */
    II(0x00007af4, 0x3)   mov(ax, memw_a16(ss, bp + 0x8));      /* mov ax, [bp+0x8] */
    II(0x00007af7, 0x4)   mov(memw_a16(es, bx + 0x6), ax);      /* mov [es:bx+0x6], ax */
    II(0x00007afb, 0x3)   callw(0x00004f61, -0x2b9d);           /* call 0x4f61 */
    II(0x00007afe, 0x1)   popw(si);                             /* pop si */
    II(0x00007aff, 0x1)   popw(di);                             /* pop di */
    II(0x00007b00, 0x1)   leavew();                             /* leave  */
    II(0x00007b01, 0x1)   retw();                               /* ret  */
FUNC_END

