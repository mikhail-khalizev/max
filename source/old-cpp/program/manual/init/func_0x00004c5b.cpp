FUNC_BEGIN(0x00004c5b, 0x5a2df5caec4d8cff, 0x10, ({0x60, 0x1e, 0x6, 0x2e, 0x8b, 0x16, 0xd4, 0x14, 0x2e, 0x8b, 0xe, 0xd6, 0x14, 0x8e, 0xd9, 0xb, 0xca, 0x74, 0x36, 0x6a, 0, 0x7, 0x26, 0x8b, 0x1e, 0xbe, 0, 0x8c, 0xc9, 0x2b, 0xcb, 0x72, 0x3, 0xb9, 0, 0, 0x75, 0xa, 0x26, 0x89, 0x16, 0xbc, 0, 0x26, 0x8c, 0x1e, 0xbe, 0, 0x16, 0x1f, 0xf7, 0x6, 0x82, 0x15, 0x1, 0, 0x74, 0xf, 0xb8, 0x6, 0x17, 0xa3, 0xc0, 0x9, 0xb8, 0x2, 0, 0xff, 0x1e, 0x5c, 0x15, 0xd1, 0xd1, 0x7, 0x1f, 0x33, 0xc0, 0x2e, 0xa3, 0xd4, 0x14, 0x2e, 0xa3, 0xd6, 0x14, 0x85, 0xc9, 0x61, 0xc3}))
    II(0x00004c5b, 0x1)   pusha();                              /* pusha  */
    II(0x00004c5c, 0x1)   pushw(ds);                            /* push ds */
    II(0x00004c5d, 0x1)   pushw(es);                            /* push es */
    II(0x00004c5e, 0x5)   mov(dx, memw_a16(cs, 0x14d4));        /* mov dx, [cs:0x14d4] */
    II(0x00004c63, 0x5)   mov(cx, memw_a16(cs, 0x14d6));        /* mov cx, [cs:0x14d6] */
    II(0x00004c68, 0x2)   mov(ds, cx);                          /* mov ds, cx */
    II(0x00004c6a, 0x2)   or_(cx, dx);                          /* or cx, dx */
    II(0x00004c6c, 0x2)   jzw(0x00004ca4, 0x36);                /* jz 0x4ca4 */
    II(0x00004c6e, 0x2)   pushw(0);                             /* push 0x0 */
    II(0x00004c70, 0x1)   popw(es);                             /* pop es */
    II(0x00004c71, 0x5)   mov(bx, memw_a16(es, 0xbe));          /* mov bx, [es:0xbe] */
    II(0x00004c76, 0x2)   mov(cx, cs);                          /* mov cx, cs */
    II(0x00004c78, 0x2)   sub(cx, bx);                          /* sub cx, bx */
    II(0x00004c7a, 0x2)   jbw(0x00004c7f, 0x3);                 /* jb 0x4c7f */
    II(0x00004c7c, 0x3)   mov(cx, 0);                           /* mov cx, 0x0 */
l_0x00004c7f:
    II(0x00004c7f, 0x2)   jnzw(0x00004c8b, 0xa);                /* jnz 0x4c8b */
    II(0x00004c81, 0x5)   mov(memw_a16(es, 0xbc), dx);          /* mov [es:0xbc], dx */
    II(0x00004c86, 0x5)   mov(memw_a16(es, 0xbe), ds);          /* mov [es:0xbe], ds */
l_0x00004c8b:
    II(0x00004c8b, 0x1)   pushw(ss);                            /* push ss */
    II(0x00004c8c, 0x1)   popw(ds);                             /* pop ds */
    II(0x00004c8d, 0x6)   test(memw_a16(ds, 0x1582), 0x1);      /* test word [0x1582], 0x1 */
    II(0x00004c93, 0x2)   jzw(0x00004ca4, 0xf);                 /* jz 0x4ca4 */
    II(0x00004c95, 0x3)   mov(ax, 0x1706);                      /* mov ax, 0x1706 */
    II(0x00004c98, 0x3)   mov(memw_a16(ds, 0x9c0), ax);         /* mov [0x9c0], ax */
    II(0x00004c9b, 0x3)   mov(ax, 0x2);                         /* mov ax, 0x2 */
    II(0x00004c9e, 0x4)   callw_a16_far_ind(ds, 0x155c);        /* call word far [0x155c] */
    II(0x00004ca2, 0x2)   rcl(cx, 0x1);                         /* rcl cx, 1 */
l_0x00004ca4:
    II(0x00004ca4, 0x1)   popw(es);                             /* pop es */
    II(0x00004ca5, 0x1)   popw(ds);                             /* pop ds */
    II(0x00004ca6, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x00004ca8, 0x4)   mov(memw_a16(cs, 0x14d4), ax);        /* mov [cs:0x14d4], ax */
    II(0x00004cac, 0x4)   mov(memw_a16(cs, 0x14d6), ax);        /* mov [cs:0x14d6], ax */
    II(0x00004cb0, 0x2)   test(cx, cx);                         /* test cx, cx */
    II(0x00004cb2, 0x1)   popa();                               /* popa  */
    II(0x00004cb3, 0x1)   retw();                               /* ret  */
FUNC_END

