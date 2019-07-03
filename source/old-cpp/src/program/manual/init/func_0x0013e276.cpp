FUNC_BEGIN(0x0013e276, 0xde23325ee81b9607, 0x10, ({0x55, 0x8b, 0xec, 0x57, 0x56, 0x1e, 0x7, 0x8b, 0x4e, 0xa, 0xe3, 0x26, 0x8b, 0xd9, 0x8b, 0x7e, 0x6, 0x8b, 0xf7, 0x33, 0xc0, 0xf2, 0xae, 0xf7, 0xd9, 0x3, 0xcb, 0x8b, 0xfe, 0x8b, 0x76, 0x8, 0xf3, 0xa6, 0x8a, 0x44, 0xff, 0x33, 0xc9, 0x3a, 0x45, 0xff, 0x77, 0x4, 0x74, 0x4, 0x49, 0x49, 0xf7, 0xd1, 0x8b, 0xc1, 0x5e, 0x5f, 0x8b, 0xe5, 0x5d, 0xcb}))
    II(0x0013e276, 0x1)   pushw(bp);                            /* push bp */
    II(0x0013e277, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0013e279, 0x1)   pushw(di);                            /* push di */
    II(0x0013e27a, 0x1)   pushw(si);                            /* push si */
    II(0x0013e27b, 0x1)   pushw(ds);                            /* push ds */
    II(0x0013e27c, 0x1)   popw(es);                             /* pop es */
    II(0x0013e27d, 0x3)   mov(cx, memw_a16(ss, bp + 0xa));      /* mov cx, [bp+0xa] */
    II(0x0013e280, 0x2)   jcxzw(0x0013e2a8, 0x26);              /* jcxz 0x13e2a8 */
    II(0x0013e282, 0x2)   mov(bx, cx);                          /* mov bx, cx */
    II(0x0013e284, 0x3)   mov(di, memw_a16(ss, bp + 0x6));      /* mov di, [bp+0x6] */
    II(0x0013e287, 0x2)   mov(si, di);                          /* mov si, di */
    II(0x0013e289, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x0013e28b, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x0013e28d, 0x2)   neg(cx);                              /* neg cx */
    II(0x0013e28f, 0x2)   add(cx, bx);                          /* add cx, bx */
    II(0x0013e291, 0x2)   mov(di, si);                          /* mov di, si */
    II(0x0013e293, 0x3)   mov(si, memw_a16(ss, bp + 0x8));      /* mov si, [bp+0x8] */
    II(0x0013e296, 0x2)   repe_a16 cmpsb_a16();                 /* rep cmpsb  */
    II(0x0013e298, 0x3)   mov(al, memb_a16(ds, si - 0x1));      /* mov al, [si-0x1] */
    II(0x0013e29b, 0x2)   xor_(cx, cx);                         /* xor cx, cx */
    II(0x0013e29d, 0x3)   cmp(al, memb_a16(ds, di - 0x1));      /* cmp al, [di-0x1] */
    II(0x0013e2a0, 0x2)   jaw(0x0013e2a6, 0x4);                 /* ja 0x13e2a6 */
    II(0x0013e2a2, 0x2)   jzw(0x0013e2a8, 0x4);                 /* jz 0x13e2a8 */
    II(0x0013e2a4, 0x1)   dec(cx);                              /* dec cx */
    II(0x0013e2a5, 0x1)   dec(cx);                              /* dec cx */
l_0x0013e2a6:
    II(0x0013e2a6, 0x2)   not_(cx);                             /* not cx */
l_0x0013e2a8:
    II(0x0013e2a8, 0x2)   mov(ax, cx);                          /* mov ax, cx */
    II(0x0013e2aa, 0x1)   popw(si);                             /* pop si */
    II(0x0013e2ab, 0x1)   popw(di);                             /* pop di */
    II(0x0013e2ac, 0x2)   mov(sp, bp);                          /* mov sp, bp */
    II(0x0013e2ae, 0x1)   popw(bp);                             /* pop bp */
    II(0x0013e2af, 0x1)   retfw();                              /* retf  */
FUNC_END

