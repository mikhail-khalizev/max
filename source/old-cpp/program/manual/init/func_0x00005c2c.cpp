FUNC_BEGIN(0x00005c2c, 0xae4036c5b42471c4, 0x10, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x1e, 0x83, 0xec, 0xa, 0xc6, 0x46, 0xf4, 0xcd, 0x8b, 0x46, 0x4, 0x88, 0x46, 0xf5, 0x3c, 0x25, 0x74, 0xa, 0x3c, 0x26, 0x74, 0x6, 0xc6, 0x46, 0xf6, 0xcb, 0xeb, 0xc, 0xc6, 0x46, 0xf8, 0xcb, 0xc6, 0x46, 0xf7, 0x44, 0xc6, 0x46, 0xf6, 0x44, 0x8c, 0x56, 0xf2, 0x8d, 0x46, 0xf4, 0x89, 0x46, 0xf0, 0x8b, 0x7e, 0x6, 0x8b, 0x5, 0x8b, 0x5d, 0x2, 0x8b, 0x4d, 0x4, 0x8b, 0x55, 0x6, 0x8b, 0x75, 0x8, 0xff, 0x75, 0xa, 0x8b, 0x7e, 0xa, 0x8e, 0x5, 0x8e, 0x5d, 0x6, 0x5f, 0x55, 0xff, 0x5e, 0xf0, 0x5d, 0xfc, 0x57, 0x1e, 0x16, 0x1f, 0x8b, 0x7e, 0xa, 0x8c, 0x5, 0x8f, 0x45, 0x6, 0x8b, 0x7e, 0x8, 0x89, 0x5, 0x89, 0x5d, 0x2, 0x89, 0x4d, 0x4, 0x89, 0x55, 0x6, 0x89, 0x75, 0x8, 0x8f, 0x45, 0xa, 0x72, 0x4, 0x33, 0xf6, 0xeb, 0x8, 0xe8, 0x20, 0x1, 0xbe, 0x1, 0, 0x8b, 0x5, 0x89, 0x75, 0xc, 0x83, 0xc4, 0xa, 0x1f, 0x5f, 0x5e, 0x8b, 0xe5, 0x5d, 0xc3}))
    II(0x00005c2c, 0x1)   pushw(bp);                            /* push bp */
    II(0x00005c2d, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x00005c2f, 0x1)   pushw(si);                            /* push si */
    II(0x00005c30, 0x1)   pushw(di);                            /* push di */
    II(0x00005c31, 0x1)   pushw(ds);                            /* push ds */
    II(0x00005c32, 0x3)   sub(sp, 0xa);                         /* sub sp, 0xa */
    II(0x00005c35, 0x4)   mov(memb_a16(ss, bp - 0xc), 0xcd);    /* mov byte [bp-0xc], 0xcd */
    II(0x00005c39, 0x3)   mov(ax, memw_a16(ss, bp + 0x4));      /* mov ax, [bp+0x4] */
    II(0x00005c3c, 0x3)   mov(memb_a16(ss, bp - 0xb), al);      /* mov [bp-0xb], al */
    II(0x00005c3f, 0x2)   cmp(al, 0x25);                        /* cmp al, 0x25 */
    II(0x00005c41, 0x2)   jzw(0x00005c4d, 0xa);                 /* jz 0x5c4d */
    II(0x00005c43, 0x2)   cmp(al, 0x26);                        /* cmp al, 0x26 */
    II(0x00005c45, 0x2)   jzw(0x00005c4d, 0x6);                 /* jz 0x5c4d */
    II(0x00005c47, 0x4)   mov(memb_a16(ss, bp - 0xa), 0xcb);    /* mov byte [bp-0xa], 0xcb */
    II(0x00005c4b, 0x2)   jmpw(0x00005c59, 0xc);                /* jmp 0x5c59 */
l_0x00005c4d:
    II(0x00005c4d, 0x4)   mov(memb_a16(ss, bp - 0x8), 0xcb);    /* mov byte [bp-0x8], 0xcb */
    II(0x00005c51, 0x4)   mov(memb_a16(ss, bp - 0x9), 0x44);    /* mov byte [bp-0x9], 0x44 */
    II(0x00005c55, 0x4)   mov(memb_a16(ss, bp - 0xa), 0x44);    /* mov byte [bp-0xa], 0x44 */
l_0x00005c59:
    II(0x00005c59, 0x3)   mov(memw_a16(ss, bp - 0xe), ss);      /* mov [bp-0xe], ss */
    II(0x00005c5c, 0x3)   lea(ax, bp - 0xc);                    /* lea ax, [bp-0xc] */
    II(0x00005c5f, 0x3)   mov(memw_a16(ss, bp - 0x10), ax);     /* mov [bp-0x10], ax */
    II(0x00005c62, 0x3)   mov(di, memw_a16(ss, bp + 0x6));      /* mov di, [bp+0x6] */
    II(0x00005c65, 0x2)   mov(ax, memw_a16(ds, di));            /* mov ax, [di] */
    II(0x00005c67, 0x3)   mov(bx, memw_a16(ds, di + 0x2));      /* mov bx, [di+0x2] */
    II(0x00005c6a, 0x3)   mov(cx, memw_a16(ds, di + 0x4));      /* mov cx, [di+0x4] */
    II(0x00005c6d, 0x3)   mov(dx, memw_a16(ds, di + 0x6));      /* mov dx, [di+0x6] */
    II(0x00005c70, 0x3)   mov(si, memw_a16(ds, di + 0x8));      /* mov si, [di+0x8] */
    II(0x00005c73, 0x3)   pushw(memw_a16(ds, di + 0xa));        /* push word [di+0xa] */
    II(0x00005c76, 0x3)   mov(di, memw_a16(ss, bp + 0xa));      /* mov di, [bp+0xa] */
    II(0x00005c79, 0x2)   mov(es, memw_a16(ds, di));            /* mov es, [di] */
    II(0x00005c7b, 0x3)   mov(ds, memw_a16(ds, di + 0x6));      /* mov ds, [di+0x6] */
    II(0x00005c7e, 0x1)   popw(di);                             /* pop di */
    II(0x00005c7f, 0x1)   pushw(bp);                            /* push bp */
    II(0x00005c80, 0x3)   callw_a16_far_ind(ss, bp - 0x10);     /* call word far [bp-0x10] */
    II(0x00005c83, 0x1)   popw(bp);                             /* pop bp */
    II(0x00005c84, 0x1)   cld();                                /* cld  */
    II(0x00005c85, 0x1)   pushw(di);                            /* push di */
    II(0x00005c86, 0x1)   pushw(ds);                            /* push ds */
    II(0x00005c87, 0x1)   pushw(ss);                            /* push ss */
    II(0x00005c88, 0x1)   popw(ds);                             /* pop ds */
    II(0x00005c89, 0x3)   mov(di, memw_a16(ss, bp + 0xa));      /* mov di, [bp+0xa] */
    II(0x00005c8c, 0x2)   mov(memw_a16(ds, di), es);            /* mov [di], es */
    II(0x00005c8e, 0x3)   popw(memw_a16(ds, di + 0x6));         /* pop word [di+0x6] */
    II(0x00005c91, 0x3)   mov(di, memw_a16(ss, bp + 0x8));      /* mov di, [bp+0x8] */
    II(0x00005c94, 0x2)   mov(memw_a16(ds, di), ax);            /* mov [di], ax */
    II(0x00005c96, 0x3)   mov(memw_a16(ds, di + 0x2), bx);      /* mov [di+0x2], bx */
    II(0x00005c99, 0x3)   mov(memw_a16(ds, di + 0x4), cx);      /* mov [di+0x4], cx */
    II(0x00005c9c, 0x3)   mov(memw_a16(ds, di + 0x6), dx);      /* mov [di+0x6], dx */
    II(0x00005c9f, 0x3)   mov(memw_a16(ds, di + 0x8), si);      /* mov [di+0x8], si */
    II(0x00005ca2, 0x3)   popw(memw_a16(ds, di + 0xa));         /* pop word [di+0xa] */
    II(0x00005ca5, 0x2)   jbw(0x00005cab, 0x4);                 /* jb 0x5cab */
    II(0x00005ca7, 0x2)   xor_(si, si);                         /* xor si, si */
    II(0x00005ca9, 0x2)   jmpw(0x00005cb3, 0x8);                /* jmp 0x5cb3 */
l_0x00005cab:
    II(0x00005cab, 0x3)   callw(0x00005dce, 0x120);             /* call 0x5dce */
    II(0x00005cae, 0x3)   mov(si, 0x1);                         /* mov si, 0x1 */
    II(0x00005cb1, 0x2)   mov(ax, memw_a16(ds, di));            /* mov ax, [di] */
l_0x00005cb3:
    II(0x00005cb3, 0x3)   mov(memw_a16(ds, di + 0xc), si);      /* mov [di+0xc], si */
    II(0x00005cb6, 0x3)   add(sp, 0xa);                         /* add sp, 0xa */
    II(0x00005cb9, 0x1)   popw(ds);                             /* pop ds */
    II(0x00005cba, 0x1)   popw(di);                             /* pop di */
    II(0x00005cbb, 0x1)   popw(si);                             /* pop si */
    II(0x00005cbc, 0x2)   mov(sp, bp);                          /* mov sp, bp */
    II(0x00005cbe, 0x1)   popw(bp);                             /* pop bp */
    II(0x00005cbf, 0x1)   retw();                               /* ret  */
FUNC_END

