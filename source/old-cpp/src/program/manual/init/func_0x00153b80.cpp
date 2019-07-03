FUNC_BEGIN(0x00153b80, 0x6550d17ac6fb2e7a, 0x10, ({0x55, 0x8b, 0xec, 0x57, 0x56, 0x1e, 0x8b, 0x4e, 0xe, 0xe3, 0x27, 0x8b, 0xd9, 0xc4, 0x7e, 0x6, 0x8b, 0xf7, 0x33, 0xc0, 0xf2, 0xae, 0xf7, 0xd9, 0x3, 0xcb, 0x8b, 0xfe, 0xc5, 0x76, 0xa, 0xf3, 0xa6, 0x8a, 0x44, 0xff, 0x33, 0xc9, 0x26, 0x3a, 0x45, 0xff, 0x77, 0x4, 0x74, 0x4, 0x49, 0x49, 0xf7, 0xd1, 0x8b, 0xc1, 0x1f, 0x5e, 0x5f, 0x8b, 0xe5, 0x5d, 0xcb}))
    II(0x00153b80, 0x1)   pushw(bp);                            /* push bp */
    II(0x00153b81, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x00153b83, 0x1)   pushw(di);                            /* push di */
    II(0x00153b84, 0x1)   pushw(si);                            /* push si */
    II(0x00153b85, 0x1)   pushw(ds);                            /* push ds */
    II(0x00153b86, 0x3)   mov(cx, memw_a16(ss, bp + 0xe));      /* mov cx, [bp+0xe] */
    II(0x00153b89, 0x2)   jcxzw(0x00153bb2, 0x27);              /* jcxz 0x153bb2 */
    II(0x00153b8b, 0x2)   mov(bx, cx);                          /* mov bx, cx */
    II(0x00153b8d, 0x3)   les(di, ss, bp + 0x6);                /* les di, [bp+0x6] */
    II(0x00153b90, 0x2)   mov(si, di);                          /* mov si, di */
    II(0x00153b92, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x00153b94, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x00153b96, 0x2)   neg(cx);                              /* neg cx */
    II(0x00153b98, 0x2)   add(cx, bx);                          /* add cx, bx */
    II(0x00153b9a, 0x2)   mov(di, si);                          /* mov di, si */
    II(0x00153b9c, 0x3)   lds(si, ss, bp + 0xa);                /* lds si, [bp+0xa] */
    II(0x00153b9f, 0x2)   repe_a16 cmpsb_a16();                 /* rep cmpsb  */
    II(0x00153ba1, 0x3)   mov(al, memb_a16(ds, si - 0x1));      /* mov al, [si-0x1] */
    II(0x00153ba4, 0x2)   xor_(cx, cx);                         /* xor cx, cx */
    II(0x00153ba6, 0x4)   cmp(al, memb_a16(es, di - 0x1));      /* cmp al, [es:di-0x1] */
    II(0x00153baa, 0x2)   jaw(0x00153bb0, 0x4);                 /* ja 0x153bb0 */
    II(0x00153bac, 0x2)   jzw(0x00153bb2, 0x4);                 /* jz 0x153bb2 */
    II(0x00153bae, 0x1)   dec(cx);                              /* dec cx */
    II(0x00153baf, 0x1)   dec(cx);                              /* dec cx */
l_0x00153bb0:
    II(0x00153bb0, 0x2)   not_(cx);                             /* not cx */
l_0x00153bb2:
    II(0x00153bb2, 0x2)   mov(ax, cx);                          /* mov ax, cx */
    II(0x00153bb4, 0x1)   popw(ds);                             /* pop ds */
    II(0x00153bb5, 0x1)   popw(si);                             /* pop si */
    II(0x00153bb6, 0x1)   popw(di);                             /* pop di */
    II(0x00153bb7, 0x2)   mov(sp, bp);                          /* mov sp, bp */
    II(0x00153bb9, 0x1)   popw(bp);                             /* pop bp */
    II(0x00153bba, 0x1)   retfw();                              /* retf  */
FUNC_END

