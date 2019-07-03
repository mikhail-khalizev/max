FUNC_BEGIN(0x001405e3, 0x5110f8293d98c57f, 0x10, ({0xc8, 0, 0, 0, 0x6, 0x57, 0x51, 0xfc, 0xc4, 0x7e, 0x6, 0x8b, 0x4e, 0xa, 0x8b, 0x46, 0xc, 0xf2, 0xae, 0x8b, 0xc1, 0x8b, 0x46, 0xa, 0x2b, 0xc1, 0x48, 0x59, 0x5f, 0x7, 0xc9, 0xcb}))
    II(0x001405e3, 0x4)   enterw(0, 0);                         /* enter 0x0, 0x0 */
    II(0x001405e7, 0x1)   pushw(es);                            /* push es */
    II(0x001405e8, 0x1)   pushw(di);                            /* push di */
    II(0x001405e9, 0x1)   pushw(cx);                            /* push cx */
    II(0x001405ea, 0x1)   cld();                                /* cld  */
    II(0x001405eb, 0x3)   les(di, ss, bp + 0x6);                /* les di, [bp+0x6] */
    II(0x001405ee, 0x3)   mov(cx, memw_a16(ss, bp + 0xa));      /* mov cx, [bp+0xa] */
    II(0x001405f1, 0x3)   mov(ax, memw_a16(ss, bp + 0xc));      /* mov ax, [bp+0xc] */
    II(0x001405f4, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x001405f6, 0x2)   mov(ax, cx);                          /* mov ax, cx */
    II(0x001405f8, 0x3)   mov(ax, memw_a16(ss, bp + 0xa));      /* mov ax, [bp+0xa] */
    II(0x001405fb, 0x2)   sub(ax, cx);                          /* sub ax, cx */
    II(0x001405fd, 0x1)   dec(ax);                              /* dec ax */
    II(0x001405fe, 0x1)   popw(cx);                             /* pop cx */
    II(0x001405ff, 0x1)   popw(di);                             /* pop di */
    II(0x00140600, 0x1)   popw(es);                             /* pop es */
    II(0x00140601, 0x1)   leavew();                             /* leave  */
    II(0x00140602, 0x1)   retfw();                              /* retf  */
FUNC_END

