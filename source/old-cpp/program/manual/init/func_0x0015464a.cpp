FUNC_BEGIN(0x0015464a, 0xc828332f446c0540, 0x10, ({0xc8, 0x14, 0, 0, 0x1e, 0xb8, 0xa8, 0, 0x8e, 0xd8, 0x8b, 0x46, 0x6, 0x89, 0x46, 0xfa, 0x6a, 0, 0x6a, 0, 0x8d, 0x46, 0xec, 0x16, 0x50, 0x6a, 0xff, 0x90, 0xe, 0xe8, 0x1e, 0xfb, 0x83, 0xc4, 0xa, 0x8a, 0x66, 0xfe, 0x2a, 0xc0, 0xc1, 0xf8, 0x8, 0x1f, 0xc9, 0xcb}))
    II(0x0015464a, 0x4)   enterw(0x14, 0);                      /* enter 0x14, 0x0 */
    II(0x0015464e, 0x1)   pushw(ds);                            /* push ds */
    II(0x0015464f, 0x3)   mov(ax, 0xa8);                        /* mov ax, 0xa8 */
    II(0x00154652, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x00154654, 0x3)   mov(ax, memw_a16(ss, bp + 0x6));      /* mov ax, [bp+0x6] */
    II(0x00154657, 0x3)   mov(memw_a16(ss, bp - 0x6), ax);      /* mov [bp-0x6], ax */
    II(0x0015465a, 0x2)   pushw(0);                             /* push 0x0 */
    II(0x0015465c, 0x2)   pushw(0);                             /* push 0x0 */
    II(0x0015465e, 0x3)   lea(ax, bp - 0x14);                   /* lea ax, [bp-0x14] */
    II(0x00154661, 0x1)   pushw(ss);                            /* push ss */
    II(0x00154662, 0x1)   pushw(ax);                            /* push ax */
    II(0x00154663, 0x2)   pushw(-0x1 /* 0xff */);               /* push 0xff */
//    II(0x00154665, 0x1)   nop();                                /* nop  */
    II(0x00154666, 0x1)   pushw(cs);                            /* push cs */
    II(0x00154667, 0x3)   callw(0x00154188, -0x4e2);            /* call 0x154188 */
    II(0x0015466a, 0x3)   add(sp, 0xa);                         /* add sp, 0xa */
    II(0x0015466d, 0x3)   mov(ah, memb_a16(ss, bp - 0x2));      /* mov ah, [bp-0x2] */
    II(0x00154670, 0x2)   sub(al, al);                          /* sub al, al */
    II(0x00154672, 0x3)   sar(ax, 0x8);                         /* sar ax, 0x8 */
    II(0x00154675, 0x1)   popw(ds);                             /* pop ds */
    II(0x00154676, 0x1)   leavew();                             /* leave  */
    II(0x00154677, 0x1)   retfw();                              /* retf  */
FUNC_END

