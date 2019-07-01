FUNC_BEGIN(0x00009644, 0x5a8c4c4117951253, 0x10, ({0x55, 0x8b, 0xec, 0x57, 0x56, 0x1e, 0x7, 0x8b, 0x7e, 0x4, 0x8b, 0x76, 0x6, 0x8b, 0xdf, 0x8b, 0x4e, 0x8, 0xe3, 0xc, 0xac, 0xa, 0xc0, 0x74, 0x3, 0xaa, 0xe2, 0xf8, 0x32, 0xc0, 0xf3, 0xaa, 0x8b, 0xc3, 0x5e, 0x5f, 0x8b, 0xe5, 0x5d, 0xc3}))
    II(0x00009644, 0x1)   pushw(bp);                            /* push bp */
    II(0x00009645, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x00009647, 0x1)   pushw(di);                            /* push di */
    II(0x00009648, 0x1)   pushw(si);                            /* push si */
    II(0x00009649, 0x1)   pushw(ds);                            /* push ds */
    II(0x0000964a, 0x1)   popw(es);                             /* pop es */
    II(0x0000964b, 0x3)   mov(di, memw_a16(ss, bp + 0x4));      /* mov di, [bp+0x4] */
    II(0x0000964e, 0x3)   mov(si, memw_a16(ss, bp + 0x6));      /* mov si, [bp+0x6] */
    II(0x00009651, 0x2)   mov(bx, di);                          /* mov bx, di */
    II(0x00009653, 0x3)   mov(cx, memw_a16(ss, bp + 0x8));      /* mov cx, [bp+0x8] */
    II(0x00009656, 0x2)   jcxzw(0x00009664, 0xc);               /* jcxz 0x9664 */
l_0x00009658:
    II(0x00009658, 0x1)   lodsb_a16();                          /* lodsb  */
    II(0x00009659, 0x2)   or_(al, al);                          /* or al, al */
    II(0x0000965b, 0x2)   jzw(0x00009660, 0x3);                 /* jz 0x9660 */
    II(0x0000965d, 0x1)   stosb_a16();                          /* stosb  */
    II(0x0000965e, 0x2)   loopw_a16(0x00009658, -0x8);          /* loop 0x9658 */
l_0x00009660:
    II(0x00009660, 0x2)   xor_(al, al);                         /* xor al, al */
    II(0x00009662, 0x2)   rep_a16 stosb_a16();                  /* rep stosb  */
l_0x00009664:
    II(0x00009664, 0x2)   mov(ax, bx);                          /* mov ax, bx */
    II(0x00009666, 0x1)   popw(si);                             /* pop si */
    II(0x00009667, 0x1)   popw(di);                             /* pop di */
    II(0x00009668, 0x2)   mov(sp, bp);                          /* mov sp, bp */
    II(0x0000966a, 0x1)   popw(bp);                             /* pop bp */
    II(0x0000966b, 0x1)   retw();                               /* ret  */
FUNC_END

