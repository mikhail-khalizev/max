FUNC_BEGIN(0x0015394a, 0xbc65d61590e4b05b, 0x10, ({0x55, 0x8b, 0xec, 0x57, 0x56, 0x1e, 0xc4, 0x7e, 0x6, 0xc5, 0x76, 0xa, 0x8b, 0xdf, 0x8b, 0x4e, 0xe, 0xe3, 0xc, 0xac, 0xa, 0xc0, 0x74, 0x3, 0xaa, 0xe2, 0xf8, 0x32, 0xc0, 0xf3, 0xaa, 0x8b, 0xc3, 0x8c, 0xc2, 0x1f, 0x5e, 0x5f, 0x8b, 0xe5, 0x5d, 0xcb}))
    II(0x0015394a, 0x1)   pushw(bp);                            /* push bp */
    II(0x0015394b, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0015394d, 0x1)   pushw(di);                            /* push di */
    II(0x0015394e, 0x1)   pushw(si);                            /* push si */
    II(0x0015394f, 0x1)   pushw(ds);                            /* push ds */
    II(0x00153950, 0x3)   les(di, ss, bp + 0x6);                /* les di, [bp+0x6] */
    II(0x00153953, 0x3)   lds(si, ss, bp + 0xa);                /* lds si, [bp+0xa] */
    II(0x00153956, 0x2)   mov(bx, di);                          /* mov bx, di */
    II(0x00153958, 0x3)   mov(cx, memw_a16(ss, bp + 0xe));      /* mov cx, [bp+0xe] */
    II(0x0015395b, 0x2)   jcxzw(0x00153969, 0xc);               /* jcxz 0x153969 */
l_0x0015395d:
    II(0x0015395d, 0x1)   lodsb_a16();                          /* lodsb  */
    II(0x0015395e, 0x2)   or_(al, al);                          /* or al, al */
    II(0x00153960, 0x2)   jzw(0x00153965, 0x3);                 /* jz 0x153965 */
    II(0x00153962, 0x1)   stosb_a16();                          /* stosb  */
    II(0x00153963, 0x2)   loopw_a16(0x0015395d, -0x8);          /* loop 0x15395d */
l_0x00153965:
    II(0x00153965, 0x2)   xor_(al, al);                         /* xor al, al */
    II(0x00153967, 0x2)   rep_a16 stosb_a16();                  /* rep stosb  */
l_0x00153969:
    II(0x00153969, 0x2)   mov(ax, bx);                          /* mov ax, bx */
    II(0x0015396b, 0x2)   mov(dx, es);                          /* mov dx, es */
    II(0x0015396d, 0x1)   popw(ds);                             /* pop ds */
    II(0x0015396e, 0x1)   popw(si);                             /* pop si */
    II(0x0015396f, 0x1)   popw(di);                             /* pop di */
    II(0x00153970, 0x2)   mov(sp, bp);                          /* mov sp, bp */
    II(0x00153972, 0x1)   popw(bp);                             /* pop bp */
    II(0x00153973, 0x1)   retfw();                              /* retf  */
FUNC_END

