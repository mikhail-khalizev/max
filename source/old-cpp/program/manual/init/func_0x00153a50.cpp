FUNC_BEGIN(0x00153a50, 0xc7fd863edfe5268b, 0x10, ({0x55, 0x8b, 0xec, 0x83, 0xec, 0x2, 0x56, 0x57, 0x1e, 0xc4, 0x7e, 0xa, 0x6, 0x1f, 0x33, 0xc0, 0xb9, 0xff, 0xff, 0xf2, 0xae, 0xf7, 0xd1, 0x49, 0xe3, 0x3c, 0x49, 0x89, 0x4e, 0xfe, 0xc4, 0x7e, 0x6, 0x8b, 0xdf, 0x33, 0xc0, 0xb9, 0xff, 0xff, 0xf2, 0xae, 0xf7, 0xd1, 0x49, 0x8b, 0xd1, 0x2b, 0x56, 0xfe, 0x76, 0x29, 0x8b, 0xfb, 0x8b, 0x76, 0xa, 0xac, 0x8b, 0xfb, 0x8b, 0xca, 0xf2, 0xae, 0x75, 0x1b, 0x8b, 0xd1, 0x8b, 0xdf, 0x8b, 0x4e, 0xfe, 0xe3, 0x4, 0xf3, 0xa6, 0x75, 0xe7, 0x8d, 0x47, 0xff, 0x8c, 0xc2, 0xeb, 0xa, 0xc4, 0x46, 0x6, 0x8c, 0xc2, 0xeb, 0x3, 0x33, 0xc0, 0x99, 0x1f, 0x5f, 0x5e, 0x8b, 0xe5, 0x5d, 0xcb}))
    II(0x00153a50, 0x1)   pushw(bp);                            /* push bp */
    II(0x00153a51, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x00153a53, 0x3)   sub(sp, 0x2);                         /* sub sp, 0x2 */
    II(0x00153a56, 0x1)   pushw(si);                            /* push si */
    II(0x00153a57, 0x1)   pushw(di);                            /* push di */
    II(0x00153a58, 0x1)   pushw(ds);                            /* push ds */
    II(0x00153a59, 0x3)   les(di, ss, bp + 0xa);                /* les di, [bp+0xa] */
    II(0x00153a5c, 0x1)   pushw(es);                            /* push es */
    II(0x00153a5d, 0x1)   popw(ds);                             /* pop ds */
    II(0x00153a5e, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x00153a60, 0x3)   mov(cx, 0xffff);                      /* mov cx, 0xffff */
    II(0x00153a63, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x00153a65, 0x2)   not_(cx);                             /* not cx */
    II(0x00153a67, 0x1)   dec(cx);                              /* dec cx */
    II(0x00153a68, 0x2)   jcxzw(0x00153aa6, 0x3c);              /* jcxz 0x153aa6 */
    II(0x00153a6a, 0x1)   dec(cx);                              /* dec cx */
    II(0x00153a6b, 0x3)   mov(memw_a16(ss, bp - 0x2), cx);      /* mov [bp-0x2], cx */
    II(0x00153a6e, 0x3)   les(di, ss, bp + 0x6);                /* les di, [bp+0x6] */
    II(0x00153a71, 0x2)   mov(bx, di);                          /* mov bx, di */
    II(0x00153a73, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x00153a75, 0x3)   mov(cx, 0xffff);                      /* mov cx, 0xffff */
    II(0x00153a78, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x00153a7a, 0x2)   not_(cx);                             /* not cx */
    II(0x00153a7c, 0x1)   dec(cx);                              /* dec cx */
    II(0x00153a7d, 0x2)   mov(dx, cx);                          /* mov dx, cx */
    II(0x00153a7f, 0x3)   sub(dx, memw_a16(ss, bp - 0x2));      /* sub dx, [bp-0x2] */
    II(0x00153a82, 0x2)   jbew(0x00153aad, 0x29);               /* jbe 0x153aad */
    II(0x00153a84, 0x2)   mov(di, bx);                          /* mov di, bx */
l_0x00153a86:
    II(0x00153a86, 0x3)   mov(si, memw_a16(ss, bp + 0xa));      /* mov si, [bp+0xa] */
    II(0x00153a89, 0x1)   lodsb_a16();                          /* lodsb  */
    II(0x00153a8a, 0x2)   mov(di, bx);                          /* mov di, bx */
    II(0x00153a8c, 0x2)   mov(cx, dx);                          /* mov cx, dx */
    II(0x00153a8e, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x00153a90, 0x2)   jnzw(0x00153aad, 0x1b);               /* jnz 0x153aad */
    II(0x00153a92, 0x2)   mov(dx, cx);                          /* mov dx, cx */
    II(0x00153a94, 0x2)   mov(bx, di);                          /* mov bx, di */
    II(0x00153a96, 0x3)   mov(cx, memw_a16(ss, bp - 0x2));      /* mov cx, [bp-0x2] */
    II(0x00153a99, 0x2)   jcxzw(0x00153a9f, 0x4);               /* jcxz 0x153a9f */
    II(0x00153a9b, 0x2)   repe_a16 cmpsb_a16();                 /* rep cmpsb  */
    II(0x00153a9d, 0x2)   jnzw(0x00153a86, -0x19);              /* jnz 0x153a86 */
l_0x00153a9f:
    II(0x00153a9f, 0x3)   lea(ax, bx - 0x1);                    /* lea ax, [bx-0x1] */
    II(0x00153aa2, 0x2)   mov(dx, es);                          /* mov dx, es */
    II(0x00153aa4, 0x2)   jmpw(0x00153ab0, 0xa);                /* jmp 0x153ab0 */
l_0x00153aa6:
    II(0x00153aa6, 0x3)   les(ax, ss, bp + 0x6);                /* les ax, [bp+0x6] */
    II(0x00153aa9, 0x2)   mov(dx, es);                          /* mov dx, es */
    II(0x00153aab, 0x2)   jmpw(0x00153ab0, 0x3);                /* jmp 0x153ab0 */
l_0x00153aad:
    II(0x00153aad, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x00153aaf, 0x1)   cwd();                                /* cwd  */
l_0x00153ab0:
    II(0x00153ab0, 0x1)   popw(ds);                             /* pop ds */
    II(0x00153ab1, 0x1)   popw(di);                             /* pop di */
    II(0x00153ab2, 0x1)   popw(si);                             /* pop si */
    II(0x00153ab3, 0x2)   mov(sp, bp);                          /* mov sp, bp */
    II(0x00153ab5, 0x1)   popw(bp);                             /* pop bp */
    II(0x00153ab6, 0x1)   retfw();                              /* retf  */
FUNC_END

