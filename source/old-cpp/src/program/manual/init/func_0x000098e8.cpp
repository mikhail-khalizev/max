FUNC_BEGIN(0x000098e8, 0xb884b11033d16041, 0x10, ({0x60, 0x1e, 0xb8, 0, 0, 0x8e, 0xd8, 0xbe, 0xf6, 0x2, 0xfd, 0x8b, 0xde, 0xad, 0x8b, 0xd0, 0xad, 0x81, 0xfb, 0xfa, 0x2, 0x73, 0xf4, 0x43, 0x43, 0x39, 0x7, 0x9c, 0x43, 0x43, 0x9d, 0x75, 0xf0, 0x39, 0x17, 0x75, 0xec, 0x1f, 0xa3, 0x56, 0, 0x89, 0x16, 0x58, 0, 0x61, 0xfc, 0xc3}))
    II(0x000098e8, 0x1)   pusha();                              /* pusha  */
    II(0x000098e9, 0x1)   pushw(ds);                            /* push ds */
    II(0x000098ea, 0x3)   mov(ax, 0);                           /* mov ax, 0x0 */
    II(0x000098ed, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x000098ef, 0x3)   mov(si, 0x2f6);                       /* mov si, 0x2f6 */
    II(0x000098f2, 0x1)   std_();                               /* std  */
l_0x000098f3:
    II(0x000098f3, 0x2)   mov(bx, si);                          /* mov bx, si */
    II(0x000098f5, 0x1)   lodsw_a16();                          /* lodsw  */
    II(0x000098f6, 0x2)   mov(dx, ax);                          /* mov dx, ax */
    II(0x000098f8, 0x1)   lodsw_a16();                          /* lodsw  */
l_0x000098f9:
    II(0x000098f9, 0x4)   cmp(bx, 0x2fa);                       /* cmp bx, 0x2fa */
    II(0x000098fd, 0x2)   jaew(0x000098f3, -0xc);               /* jae 0x98f3 */
    II(0x000098ff, 0x1)   inc(bx);                              /* inc bx */
    II(0x00009900, 0x1)   inc(bx);                              /* inc bx */
    II(0x00009901, 0x2)   cmp(memw_a16(ds, bx), ax);            /* cmp [bx], ax */
    II(0x00009903, 0x1)   pushfw();                             /* pushfw  */
    II(0x00009904, 0x1)   inc(bx);                              /* inc bx */
    II(0x00009905, 0x1)   inc(bx);                              /* inc bx */
    II(0x00009906, 0x1)   popfw();                              /* popfw  */
    II(0x00009907, 0x2)   jnzw(0x000098f9, -0x10);              /* jnz 0x98f9 */
    II(0x00009909, 0x2)   cmp(memw_a16(ds, bx), dx);            /* cmp [bx], dx */
    II(0x0000990b, 0x2)   jnzw(0x000098f9, -0x14);              /* jnz 0x98f9 */
    II(0x0000990d, 0x1)   popw(ds);                             /* pop ds */
    II(0x0000990e, 0x3)   mov(memw_a16(ds, 0x56), ax);          /* mov [0x56], ax */
    II(0x00009911, 0x4)   mov(memw_a16(ds, 0x58), dx);          /* mov [0x58], dx */
    II(0x00009915, 0x1)   popa();                               /* popa  */
    II(0x00009916, 0x1)   cld();                                /* cld  */
    II(0x00009917, 0x1)   retw();                               /* ret  */
FUNC_END

