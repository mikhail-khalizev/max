FUNC_BEGIN(0x0013dbe0, 0x478e2dfe813f696, 0x10, ({0x55, 0x8b, 0xec, 0x83, 0xec, 0x2, 0x56, 0x57, 0x1e, 0x7, 0x8b, 0x7e, 0x8, 0x33, 0xc0, 0xb9, 0xff, 0xff, 0xf2, 0xae, 0xf7, 0xd1, 0x49, 0xe3, 0x3a, 0x49, 0x89, 0x4e, 0xfe, 0x8b, 0x7e, 0x6, 0x8b, 0xdf, 0x33, 0xc0, 0xb9, 0xff, 0xff, 0xf2, 0xae, 0xf7, 0xd1, 0x49, 0x8b, 0xd1, 0x2b, 0x56, 0xfe, 0x76, 0x25, 0x8b, 0xfb, 0x8b, 0x76, 0x8, 0xac, 0x8b, 0xfb, 0x8b, 0xca, 0xf2, 0xae, 0x75, 0x17, 0x8b, 0xd1, 0x8b, 0xdf, 0x8b, 0x4e, 0xfe, 0xe3, 0x4, 0xf3, 0xa6, 0x75, 0xe7, 0x8d, 0x47, 0xff, 0xeb, 0x7, 0x8b, 0x46, 0x6, 0xeb, 0x2, 0x33, 0xc0, 0x5f, 0x5e, 0x8b, 0xe5, 0x5d, 0xcb}))
    II(0x0013dbe0, 0x1)   pushw(bp);                            /* push bp */
    II(0x0013dbe1, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0013dbe3, 0x3)   sub(sp, 0x2);                         /* sub sp, 0x2 */
    II(0x0013dbe6, 0x1)   pushw(si);                            /* push si */
    II(0x0013dbe7, 0x1)   pushw(di);                            /* push di */
    II(0x0013dbe8, 0x1)   pushw(ds);                            /* push ds */
    II(0x0013dbe9, 0x1)   popw(es);                             /* pop es */
    II(0x0013dbea, 0x3)   mov(di, memw_a16(ss, bp + 0x8));      /* mov di, [bp+0x8] */
    II(0x0013dbed, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x0013dbef, 0x3)   mov(cx, 0xffff);                      /* mov cx, 0xffff */
    II(0x0013dbf2, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x0013dbf4, 0x2)   not_(cx);                             /* not cx */
    II(0x0013dbf6, 0x1)   dec(cx);                              /* dec cx */
    II(0x0013dbf7, 0x2)   jcxzw(0x0013dc33, 0x3a);              /* jcxz 0x13dc33 */
    II(0x0013dbf9, 0x1)   dec(cx);                              /* dec cx */
    II(0x0013dbfa, 0x3)   mov(memw_a16(ss, bp - 0x2), cx);      /* mov [bp-0x2], cx */
    II(0x0013dbfd, 0x3)   mov(di, memw_a16(ss, bp + 0x6));      /* mov di, [bp+0x6] */
    II(0x0013dc00, 0x2)   mov(bx, di);                          /* mov bx, di */
    II(0x0013dc02, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x0013dc04, 0x3)   mov(cx, 0xffff);                      /* mov cx, 0xffff */
    II(0x0013dc07, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x0013dc09, 0x2)   not_(cx);                             /* not cx */
    II(0x0013dc0b, 0x1)   dec(cx);                              /* dec cx */
    II(0x0013dc0c, 0x2)   mov(dx, cx);                          /* mov dx, cx */
    II(0x0013dc0e, 0x3)   sub(dx, memw_a16(ss, bp - 0x2));      /* sub dx, [bp-0x2] */
    II(0x0013dc11, 0x2)   jbew(0x0013dc38, 0x25);               /* jbe 0x13dc38 */
    II(0x0013dc13, 0x2)   mov(di, bx);                          /* mov di, bx */
l_0x0013dc15:
    II(0x0013dc15, 0x3)   mov(si, memw_a16(ss, bp + 0x8));      /* mov si, [bp+0x8] */
    II(0x0013dc18, 0x1)   lodsb_a16();                          /* lodsb  */
    II(0x0013dc19, 0x2)   mov(di, bx);                          /* mov di, bx */
    II(0x0013dc1b, 0x2)   mov(cx, dx);                          /* mov cx, dx */
    II(0x0013dc1d, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x0013dc1f, 0x2)   jnzw(0x0013dc38, 0x17);               /* jnz 0x13dc38 */
    II(0x0013dc21, 0x2)   mov(dx, cx);                          /* mov dx, cx */
    II(0x0013dc23, 0x2)   mov(bx, di);                          /* mov bx, di */
    II(0x0013dc25, 0x3)   mov(cx, memw_a16(ss, bp - 0x2));      /* mov cx, [bp-0x2] */
    II(0x0013dc28, 0x2)   jcxzw(0x0013dc2e, 0x4);               /* jcxz 0x13dc2e */
    II(0x0013dc2a, 0x2)   repe_a16 cmpsb_a16();                 /* rep cmpsb  */
    II(0x0013dc2c, 0x2)   jnzw(0x0013dc15, -0x19);              /* jnz 0x13dc15 */
l_0x0013dc2e:
    II(0x0013dc2e, 0x3)   lea(ax, bx - 0x1);                    /* lea ax, [bx-0x1] */
    II(0x0013dc31, 0x2)   jmpw(0x0013dc3a, 0x7);                /* jmp 0x13dc3a */
l_0x0013dc33:
    II(0x0013dc33, 0x3)   mov(ax, memw_a16(ss, bp + 0x6));      /* mov ax, [bp+0x6] */
    II(0x0013dc36, 0x2)   jmpw(0x0013dc3a, 0x2);                /* jmp 0x13dc3a */
l_0x0013dc38:
    II(0x0013dc38, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
l_0x0013dc3a:
    II(0x0013dc3a, 0x1)   popw(di);                             /* pop di */
    II(0x0013dc3b, 0x1)   popw(si);                             /* pop si */
    II(0x0013dc3c, 0x2)   mov(sp, bp);                          /* mov sp, bp */
    II(0x0013dc3e, 0x1)   popw(bp);                             /* pop bp */
    II(0x0013dc3f, 0x1)   retfw();                              /* retf  */
FUNC_END

