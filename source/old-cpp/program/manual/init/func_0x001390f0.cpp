FUNC_BEGIN(0x001390f0, 0xe30c67fc5e59402d, 0x10, ({0x55, 0x8b, 0xec, 0x1e, 0x51, 0x52, 0xb4, 0x5a, 0xb9, 0, 0, 0xc5, 0x56, 0x6, 0xff, 0x1e, 0xe0, 0x1f, 0xf, 0x82, 0x11, 0, 0x53, 0x8b, 0xd8, 0xb4, 0x3e, 0xcd, 0x21, 0x5b, 0xb4, 0x41, 0xc5, 0x56, 0x6, 0xcd, 0x21, 0x33, 0xc0, 0x5a, 0x59, 0x1f, 0x5d, 0xcb}))
    II(0x001390f0, 0x1)   pushw(bp);                            /* push bp */
    II(0x001390f1, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x001390f3, 0x1)   pushw(ds);                            /* push ds */
    II(0x001390f4, 0x1)   pushw(cx);                            /* push cx */
    II(0x001390f5, 0x1)   pushw(dx);                            /* push dx */
    II(0x001390f6, 0x2)   mov(ah, 0x5a);                        /* mov ah, 0x5a */
    II(0x001390f8, 0x3)   mov(cx, 0);                           /* mov cx, 0x0 */
    II(0x001390fb, 0x3)   lds(dx, ss, bp + 0x6);                /* lds dx, [bp+0x6] */
    II(0x001390fe, 0x4)   callw_a16_far_ind(ds, 0x1fe0);        /* call word far [0x1fe0] */
    II(0x00139102, 0x4)   jbw(0x00139117, 0x11);                /* jb word 0x139117 */
    II(0x00139106, 0x1)   pushw(bx);                            /* push bx */
    II(0x00139107, 0x2)   mov(bx, ax);                          /* mov bx, ax */
    II(0x00139109, 0x2)   mov(ah, 0x3e);                        /* mov ah, 0x3e */
    II(0x0013910b, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x0013910d, 0x1)   popw(bx);                             /* pop bx */
    II(0x0013910e, 0x2)   mov(ah, 0x41);                        /* mov ah, 0x41 */
    II(0x00139110, 0x3)   lds(dx, ss, bp + 0x6);                /* lds dx, [bp+0x6] */
    II(0x00139113, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x00139115, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
l_0x00139117:
    II(0x00139117, 0x1)   popw(dx);                             /* pop dx */
    II(0x00139118, 0x1)   popw(cx);                             /* pop cx */
    II(0x00139119, 0x1)   popw(ds);                             /* pop ds */
    II(0x0013911a, 0x1)   popw(bp);                             /* pop bp */
    II(0x0013911b, 0x1)   retfw();                              /* retf  */
FUNC_END

