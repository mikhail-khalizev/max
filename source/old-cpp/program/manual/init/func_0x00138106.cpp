FUNC_BEGIN(0x00138106, 0x11e9da044ff3ee3a, 0x10, ({0x55, 0x8b, 0xec, 0x1e, 0xb8, 0x68, 0x3e, 0x8e, 0xd8, 0x80, 0x3e, 0x2a, 0xa, 0, 0x74, 0xe, 0x8b, 0x46, 0x6, 0xc4, 0x1e, 0x26, 0xa, 0x26, 0x89, 0x47, 0x10, 0x1f, 0xc9, 0xcb, 0xb4, 0x50, 0x8b, 0x5e, 0x6, 0xcd, 0x21, 0x1f, 0xc9, 0xcb}))
    II(0x00138106, 0x1)   pushw(bp);                            /* push bp */
    II(0x00138107, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x00138109, 0x1)   pushw(ds);                            /* push ds */
    II(0x0013810a, 0x3)   mov(ax, 0x3e68);                      /* mov ax, 0x3e68 */
    II(0x0013810d, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x0013810f, 0x5)   cmp(memb_a16(ds, 0xa2a), 0);          /* cmp byte [0xa2a], 0x0 */
    II(0x00138114, 0x2)   jzw(0x00138124, 0xe);                 /* jz 0x138124 */
    II(0x00138116, 0x3)   mov(ax, memw_a16(ss, bp + 0x6));      /* mov ax, [bp+0x6] */
    II(0x00138119, 0x4)   les(bx, ds, 0xa26);                   /* les bx, [0xa26] */
    II(0x0013811d, 0x4)   mov(memw_a16(es, bx + 0x10), ax);     /* mov [es:bx+0x10], ax */
    II(0x00138121, 0x1)   popw(ds);                             /* pop ds */
    II(0x00138122, 0x1)   leavew();                             /* leave  */
    II(0x00138123, 0x1)   retfw();                              /* retf  */
l_0x00138124:
    II(0x00138124, 0x2)   mov(ah, 0x50);                        /* mov ah, 0x50 */
    II(0x00138126, 0x3)   mov(bx, memw_a16(ss, bp + 0x6));      /* mov bx, [bp+0x6] */
    II(0x00138129, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x0013812b, 0x1)   popw(ds);                             /* pop ds */
    II(0x0013812c, 0x1)   leavew();                             /* leave  */
    II(0x0013812d, 0x1)   retfw();                              /* retf  */
FUNC_END

