FUNC_BEGIN(0x0000f3c2, 0x86a3fd431165e446, 0x10, ({0x8a, 0x4e, 0x16, 0x80, 0xf9, 0x20, 0x73, 0x6e, 0x80, 0xf9, 0x1, 0x74, 0x3d, 0xb8, 0, 0x2f, 0xd3, 0xe0, 0x79, 0x33, 0xa1, 0xa, 0, 0x89, 0x47, 0x8, 0xa1, 0xb4, 0x9, 0x89, 0x47, 0x6, 0xe8, 0x7e, 0xf4, 0x8b, 0x4f, 0x14, 0x89, 0x4e, 0x14, 0x8b, 0x7e, 0x8, 0x8e, 0x46, 0x6, 0x8b, 0x36, 0xa, 0, 0xf3, 0xa4, 0x8b, 0x76, 0x8, 0xa1, 0x3e, 0xc, 0x8b, 0xf8, 0x26, 0x87, 0x44, 0x3, 0xe8, 0x86, 0xfe, 0xe9, 0x4, 0xfc}))
    II(0x0000f3c2, 0x3)   mov(cl, memb_a16(ss, bp + 0x16));     /* mov cl, [bp+0x16] */
    II(0x0000f3c5, 0x3)   cmp(cl, 0x20);                        /* cmp cl, 0x20 */
    II(0x0000f3c8, 0x2)   jaew_func(0x0000f438, 0x6e);          /* jae 0xf438 */
    II(0x0000f3ca, 0x3)   cmp(cl, 0x1);                         /* cmp cl, 0x1 */
    II(0x0000f3cd, 0x2)   jzw_func(0x0000f40c, 0x3d);           /* jz 0xf40c */
    II(0x0000f3cf, 0x3)   mov(ax, 0x2f00);                      /* mov ax, 0x2f00 */
    II(0x0000f3d2, 0x2)   shl(ax, cl);                          /* shl ax, cl */
    II(0x0000f3d4, 0x2)   jnsw_func(0x0000f409, 0x33);          /* jns 0xf409 */
    II(0x0000f3d6, 0x3)   mov(ax, memw_a16(ds, 0xa));           /* mov ax, [0xa] */
    II(0x0000f3d9, 0x3)   mov(memw_a16(ds, bx + 0x8), ax);      /* mov [bx+0x8], ax */
    II(0x0000f3dc, 0x3)   mov(ax, memw_a16(ds, 0x9b4));         /* mov ax, [0x9b4] */
    II(0x0000f3df, 0x3)   mov(memw_a16(ds, bx + 0x6), ax);      /* mov [bx+0x6], ax */
    II(0x0000f3e2, 0x3)   callw(0x0000e863, -0xb82);            /* call 0xe863 */
    II(0x0000f3e5, 0x3)   mov(cx, memw_a16(ds, bx + 0x14));     /* mov cx, [bx+0x14] */
    II(0x0000f3e8, 0x3)   mov(memw_a16(ss, bp + 0x14), cx);     /* mov [bp+0x14], cx */
    II(0x0000f3eb, 0x3)   mov(di, memw_a16(ss, bp + 0x8));      /* mov di, [bp+0x8] */
    II(0x0000f3ee, 0x3)   mov(es, memw_a16(ss, bp + 0x6));      /* mov es, [bp+0x6] */
    II(0x0000f3f1, 0x4)   mov(si, memw_a16(ds, 0xa));           /* mov si, [0xa] */
    II(0x0000f3f5, 0x2)   rep_a16 movsb_a16();                  /* rep movsb  */
    II(0x0000f3f7, 0x3)   mov(si, memw_a16(ss, bp + 0x8));      /* mov si, [bp+0x8] */
    II(0x0000f3fa, 0x3)   mov(ax, memw_a16(ds, 0xc3e));         /* mov ax, [0xc3e] */
    II(0x0000f3fd, 0x2)   mov(di, ax);                          /* mov di, ax */
    II(0x0000f3ff, 0x4)   xchg(memw_a16(es, si + 0x3), ax);     /* xchg [es:si+0x3], ax */
    II(0x0000f403, 0x3)   callw(0x0000f28c, -0x17a);            /* call 0xf28c */
    II(0x0000f406, 0x3)   jmpw_func(0x0000f00d, -0x3fc);        /* jmp 0xf00d */
FUNC_END

