FUNC_BEGIN(0x0000efe3, 0x8449623d1903914f, 0x10, ({0xe8, 0xdd, 0xf8, 0xe8, 0x9, 0xfb, 0x72, 0x1f, 0x8b, 0x3e, 0xa, 0, 0x81, 0xc7, 0, 0x1, 0x89, 0x7f, 0x8, 0x8b, 0xe, 0xe, 0, 0x8e, 0x5e, 0x6, 0x8b, 0x76, 0x8, 0xfe, 0xcd, 0xac, 0xaa, 0xa, 0xc0, 0xe0, 0xfa, 0x6, 0x1f, 0xe8, 0x56, 0xf8}))
    II(0x0000efe3, 0x3)   callw(0x0000e8c3, -0x723);            /* call 0xe8c3 */
    II(0x0000efe6, 0x3)   callw(0x0000eaf2, -0x4f7);            /* call 0xeaf2 */
    II(0x0000efe9, 0x2)   jbw(0x0000f00a, 0x1f);                /* jb 0xf00a */
    II(0x0000efeb, 0x4)   mov(di, memw_a16(ds, 0xa));           /* mov di, [0xa] */
    II(0x0000efef, 0x4)   add(di, 0x100);                       /* add di, 0x100 */
    II(0x0000eff3, 0x3)   mov(memw_a16(ds, bx + 0x8), di);      /* mov [bx+0x8], di */
    II(0x0000eff6, 0x4)   mov(cx, memw_a16(ds, 0xe));           /* mov cx, [0xe] */
    II(0x0000effa, 0x3)   mov(ds, memw_a16(ss, bp + 0x6));      /* mov ds, [bp+0x6] */
    II(0x0000effd, 0x3)   mov(si, memw_a16(ss, bp + 0x8));      /* mov si, [bp+0x8] */
    II(0x0000f000, 0x2)   dec(ch);                              /* dec ch */
l_0x0000f002:
    II(0x0000f002, 0x1)   lodsb_a16();                          /* lodsb  */
    II(0x0000f003, 0x1)   stosb_a16();                          /* stosb  */
    II(0x0000f004, 0x2)   or_(al, al);                          /* or al, al */
    II(0x0000f006, 0x2)   loopnzw_a16(0x0000f002, -0x6);        /* loopnz 0xf002 */
    II(0x0000f008, 0x1)   pushw(es);                            /* push es */
    II(0x0000f009, 0x1)   popw(ds);                             /* pop ds */
l_0x0000f00a:
    II(0x0000f00a, 0x3)   callw(0x0000e863, -0x7aa);            /* call 0xe863 */
    II(0x0000f00d, 0)     jmpd_func(0x0000f00d, 0);             /* Принудительное завершение функции. */
FUNC_END

