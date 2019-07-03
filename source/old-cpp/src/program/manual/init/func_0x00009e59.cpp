FUNC_BEGIN(0x00009e59, 0x89873196551a8690, 0x10, ({0x8b, 0xdc, 0x8b, 0x57, 0x4, 0x8b, 0x5f, 0x2, 0x56, 0x57, 0xe, 0x1f, 0xb9, 0x2c, 0, 0xbe, 0x61, 0x67, 0xeb, 0, 0xad, 0x97, 0xad, 0x3b, 0xc2, 0xac, 0x75, 0x4, 0x3b, 0xfb, 0x74, 0x8, 0xe2, 0xf2, 0x33, 0xc0, 0x33, 0xd2, 0xeb, 0x8, 0x32, 0xe4, 0x8b, 0xd0, 0xac, 0xc1, 0xe0, 0x4, 0x16, 0x1f, 0x5f, 0x5e, 0xc3}))
    II(0x00009e59, 0x2)   mov(bx, sp);                          /* mov bx, sp */
    II(0x00009e5b, 0x3)   mov(dx, memw_a16(ds, bx + 0x4));      /* mov dx, [bx+0x4] */
    II(0x00009e5e, 0x3)   mov(bx, memw_a16(ds, bx + 0x2));      /* mov bx, [bx+0x2] */
    II(0x00009e61, 0x1)   pushw(si);                            /* push si */
    II(0x00009e62, 0x1)   pushw(di);                            /* push di */
    II(0x00009e63, 0x1)   pushw(cs);                            /* push cs */
    II(0x00009e64, 0x1)   popw(ds);                             /* pop ds */
    II(0x00009e65, 0x3)   mov(cx, 0x2c);                        /* mov cx, 0x2c */
    II(0x00009e68, 0x3)   mov(si, 0x6761);                      /* mov si, 0x6761 */
    II(0x00009e6b, 0x2)   jmpw(0x00009e6d, 0);                  /* jmp 0x9e6d */
l_0x00009e6d:
    II(0x00009e6d, 0x1)   lodsw_a16();                          /* lodsw  */
    II(0x00009e6e, 0x1)   xchg(di, ax);                         /* xchg di, ax */
    II(0x00009e6f, 0x1)   lodsw_a16();                          /* lodsw  */
    II(0x00009e70, 0x2)   cmp(ax, dx);                          /* cmp ax, dx */
    II(0x00009e72, 0x1)   lodsb_a16();                          /* lodsb  */
    II(0x00009e73, 0x2)   jnzw(0x00009e79, 0x4);                /* jnz 0x9e79 */
    II(0x00009e75, 0x2)   cmp(di, bx);                          /* cmp di, bx */
    II(0x00009e77, 0x2)   jzw(0x00009e81, 0x8);                 /* jz 0x9e81 */
l_0x00009e79:
    II(0x00009e79, 0x2)   loopw_a16(0x00009e6d, -0xe);          /* loop 0x9e6d */
    II(0x00009e7b, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x00009e7d, 0x2)   xor_(dx, dx);                         /* xor dx, dx */
    II(0x00009e7f, 0x2)   jmpw(0x00009e89, 0x8);                /* jmp 0x9e89 */
l_0x00009e81:
    II(0x00009e81, 0x2)   xor_(ah, ah);                         /* xor ah, ah */
    II(0x00009e83, 0x2)   mov(dx, ax);                          /* mov dx, ax */
    II(0x00009e85, 0x1)   lodsb_a16();                          /* lodsb  */
    II(0x00009e86, 0x3)   shl(ax, 0x4);                         /* shl ax, 0x4 */
l_0x00009e89:
    II(0x00009e89, 0x1)   pushw(ss);                            /* push ss */
    II(0x00009e8a, 0x1)   popw(ds);                             /* pop ds */
    II(0x00009e8b, 0x1)   popw(di);                             /* pop di */
    II(0x00009e8c, 0x1)   popw(si);                             /* pop si */
    II(0x00009e8d, 0x1)   retw();                               /* ret  */
FUNC_END

