FUNC_BEGIN(0x00151798, 0x110662afefb6ec92, 0x10, ({0x55, 0x8b, 0xec, 0x80, 0x7e, 0x4, 0xa, 0x75, 0x6, 0x6a, 0xd, 0xe8, 0xf2, 0xff, 0x5b, 0x8a, 0x46, 0x4, 0xa2, 0x78, 0x3a, 0xb4, 0x40, 0xbb, 0x2, 0, 0xb9, 0x1, 0, 0xba, 0x78, 0x3a, 0xcd, 0x21, 0xc9, 0xc3}))
    II(0x00151798, 0x1)   pushw(bp);                            /* push bp */
    II(0x00151799, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0015179b, 0x4)   cmp(memb_a16(ss, bp + 0x4), 0xa);     /* cmp byte [bp+0x4], 0xa */
    II(0x0015179f, 0x2)   jnzw(0x001517a7, 0x6);                /* jnz 0x1517a7 */
    II(0x001517a1, 0x2)   pushw(0xd);                           /* push 0xd */
    II(0x001517a3, 0x3)   callw(0x00151798, -0xe);              /* call 0x151798 */
    II(0x001517a6, 0x1)   popw(bx);                             /* pop bx */
l_0x001517a7:
    II(0x001517a7, 0x3)   mov(al, memb_a16(ss, bp + 0x4));      /* mov al, [bp+0x4] */
    II(0x001517aa, 0x3)   mov(memb_a16(ds, 0x3a78), al);        /* mov [0x3a78], al */
    II(0x001517ad, 0x2)   mov(ah, 0x40);                        /* mov ah, 0x40 */
    II(0x001517af, 0x3)   mov(bx, 0x2);                         /* mov bx, 0x2 */
    II(0x001517b2, 0x3)   mov(cx, 0x1);                         /* mov cx, 0x1 */
    II(0x001517b5, 0x3)   mov(dx, 0x3a78);                      /* mov dx, 0x3a78 */
    II(0x001517b8, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x001517ba, 0x1)   leavew();                             /* leave  */
    II(0x001517bb, 0x1)   retw();                               /* ret  */
FUNC_END

