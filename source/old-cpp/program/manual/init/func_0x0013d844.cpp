FUNC_BEGIN(0x0013d844, 0x16f0c5ea08369d4a, 0x10, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x1e, 0x7, 0x8b, 0x56, 0x6, 0xbe, 0xda, 0x1d, 0xad, 0x3b, 0xc2, 0x74, 0x10, 0x40, 0x96, 0x74, 0xc, 0x97, 0x33, 0xc0, 0xb9, 0xff, 0xff, 0xf2, 0xae, 0x8b, 0xf7, 0xeb, 0xeb, 0x96, 0x5f, 0x5e, 0x8b, 0xe5, 0x5d, 0xca, 0x2, 0}))
    II(0x0013d844, 0x1)   pushw(bp);                            /* push bp */
    II(0x0013d845, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0013d847, 0x1)   pushw(si);                            /* push si */
    II(0x0013d848, 0x1)   pushw(di);                            /* push di */
    II(0x0013d849, 0x1)   pushw(ds);                            /* push ds */
    II(0x0013d84a, 0x1)   popw(es);                             /* pop es */
    II(0x0013d84b, 0x3)   mov(dx, memw_a16(ss, bp + 0x6));      /* mov dx, [bp+0x6] */
    II(0x0013d84e, 0x3)   mov(si, 0x1dda);                      /* mov si, 0x1dda */
l_0x0013d851:
    II(0x0013d851, 0x1)   lodsw_a16();                          /* lodsw  */
    II(0x0013d852, 0x2)   cmp(ax, dx);                          /* cmp ax, dx */
    II(0x0013d854, 0x2)   jzw(0x0013d866, 0x10);                /* jz 0x13d866 */
    II(0x0013d856, 0x1)   inc(ax);                              /* inc ax */
    II(0x0013d857, 0x1)   xchg(si, ax);                         /* xchg si, ax */
    II(0x0013d858, 0x2)   jzw(0x0013d866, 0xc);                 /* jz 0x13d866 */
    II(0x0013d85a, 0x1)   xchg(di, ax);                         /* xchg di, ax */
    II(0x0013d85b, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x0013d85d, 0x3)   mov(cx, 0xffff);                      /* mov cx, 0xffff */
    II(0x0013d860, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x0013d862, 0x2)   mov(si, di);                          /* mov si, di */
    II(0x0013d864, 0x2)   jmpw(0x0013d851, -0x15);              /* jmp 0x13d851 */
l_0x0013d866:
    II(0x0013d866, 0x1)   xchg(si, ax);                         /* xchg si, ax */
    II(0x0013d867, 0x1)   popw(di);                             /* pop di */
    II(0x0013d868, 0x1)   popw(si);                             /* pop si */
    II(0x0013d869, 0x2)   mov(sp, bp);                          /* mov sp, bp */
    II(0x0013d86b, 0x1)   popw(bp);                             /* pop bp */
    II(0x0013d86c, 0x3)   retfw(0x2);                           /* retf 0x2 */
FUNC_END

