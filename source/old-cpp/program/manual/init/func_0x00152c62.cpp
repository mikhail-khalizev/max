FUNC_BEGIN(0x00152c62, 0x10c38dd07ad461fb, 0x10, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x1e, 0x7, 0x8b, 0x56, 0x6, 0xbe, 0xf8, 0x3f, 0xad, 0x3b, 0xc2, 0x74, 0x10, 0x40, 0x96, 0x74, 0xc, 0x97, 0x33, 0xc0, 0xb9, 0xff, 0xff, 0xf2, 0xae, 0x8b, 0xf7, 0xeb, 0xeb, 0x96, 0x5f, 0x5e, 0x8b, 0xe5, 0x5d, 0xca, 0x2, 0}))
    II(0x00152c62, 0x1)   pushw(bp);                            /* push bp */
    II(0x00152c63, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x00152c65, 0x1)   pushw(si);                            /* push si */
    II(0x00152c66, 0x1)   pushw(di);                            /* push di */
    II(0x00152c67, 0x1)   pushw(ds);                            /* push ds */
    II(0x00152c68, 0x1)   popw(es);                             /* pop es */
    II(0x00152c69, 0x3)   mov(dx, memw_a16(ss, bp + 0x6));      /* mov dx, [bp+0x6] */
    II(0x00152c6c, 0x3)   mov(si, 0x3ff8);                      /* mov si, 0x3ff8 */
l_0x00152c6f:
    II(0x00152c6f, 0x1)   lodsw_a16();                          /* lodsw  */
    II(0x00152c70, 0x2)   cmp(ax, dx);                          /* cmp ax, dx */
    II(0x00152c72, 0x2)   jzw(0x00152c84, 0x10);                /* jz 0x152c84 */
    II(0x00152c74, 0x1)   inc(ax);                              /* inc ax */
    II(0x00152c75, 0x1)   xchg(si, ax);                         /* xchg si, ax */
    II(0x00152c76, 0x2)   jzw(0x00152c84, 0xc);                 /* jz 0x152c84 */
    II(0x00152c78, 0x1)   xchg(di, ax);                         /* xchg di, ax */
    II(0x00152c79, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x00152c7b, 0x3)   mov(cx, 0xffff);                      /* mov cx, 0xffff */
    II(0x00152c7e, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x00152c80, 0x2)   mov(si, di);                          /* mov si, di */
    II(0x00152c82, 0x2)   jmpw(0x00152c6f, -0x15);              /* jmp 0x152c6f */
l_0x00152c84:
    II(0x00152c84, 0x1)   xchg(si, ax);                         /* xchg si, ax */
    II(0x00152c85, 0x1)   popw(di);                             /* pop di */
    II(0x00152c86, 0x1)   popw(si);                             /* pop si */
    II(0x00152c87, 0x2)   mov(sp, bp);                          /* mov sp, bp */
    II(0x00152c89, 0x1)   popw(bp);                             /* pop bp */
    II(0x00152c8a, 0x3)   retfw(0x2);                           /* retf 0x2 */
FUNC_END

