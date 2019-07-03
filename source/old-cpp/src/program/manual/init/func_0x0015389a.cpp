FUNC_BEGIN(0x0015389a, 0x410ee94c9c7a9ee8, 0x10, ({0x55, 0x8b, 0xec, 0x57, 0xc4, 0x7e, 0x6, 0x8b, 0xdf, 0x33, 0xc0, 0xb9, 0xff, 0xff, 0xf2, 0xae, 0x41, 0xf7, 0xd9, 0x8a, 0x46, 0xa, 0x8b, 0xfb, 0xf2, 0xae, 0x4f, 0x26, 0x38, 0x5, 0x74, 0x4, 0x33, 0xff, 0x8e, 0xc7, 0x8b, 0xc7, 0x8c, 0xc2, 0x5f, 0x8b, 0xe5, 0x5d, 0xcb}))
    II(0x0015389a, 0x1)   pushw(bp);                            /* push bp */
    II(0x0015389b, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0015389d, 0x1)   pushw(di);                            /* push di */
    II(0x0015389e, 0x3)   les(di, ss, bp + 0x6);                /* les di, [bp+0x6] */
    II(0x001538a1, 0x2)   mov(bx, di);                          /* mov bx, di */
    II(0x001538a3, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x001538a5, 0x3)   mov(cx, 0xffff);                      /* mov cx, 0xffff */
    II(0x001538a8, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x001538aa, 0x1)   inc(cx);                              /* inc cx */
    II(0x001538ab, 0x2)   neg(cx);                              /* neg cx */
    II(0x001538ad, 0x3)   mov(al, memb_a16(ss, bp + 0xa));      /* mov al, [bp+0xa] */
    II(0x001538b0, 0x2)   mov(di, bx);                          /* mov di, bx */
    II(0x001538b2, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x001538b4, 0x1)   dec(di);                              /* dec di */
    II(0x001538b5, 0x3)   cmp(memb_a16(es, di), al);            /* cmp [es:di], al */
    II(0x001538b8, 0x2)   jzw(0x001538be, 0x4);                 /* jz 0x1538be */
    II(0x001538ba, 0x2)   xor_(di, di);                         /* xor di, di */
    II(0x001538bc, 0x2)   mov(es, di);                          /* mov es, di */
l_0x001538be:
    II(0x001538be, 0x2)   mov(ax, di);                          /* mov ax, di */
    II(0x001538c0, 0x2)   mov(dx, es);                          /* mov dx, es */
    II(0x001538c2, 0x1)   popw(di);                             /* pop di */
    II(0x001538c3, 0x2)   mov(sp, bp);                          /* mov sp, bp */
    II(0x001538c5, 0x1)   popw(bp);                             /* pop bp */
    II(0x001538c6, 0x1)   retfw();                              /* retf  */
FUNC_END

