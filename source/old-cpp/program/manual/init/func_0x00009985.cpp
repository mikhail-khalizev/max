FUNC_BEGIN(0x00009985, 0x38bfbf0ae1dae1a4, 0x10, ({0x6, 0xbf, 0x41, 0x63, 0x83, 0xc7, 0xe, 0x2e, 0x83, 0x3d, 0x1, 0x74, 0x5, 0x2e, 0x39, 0x35, 0x75, 0xf2, 0x56, 0x8b, 0xf7, 0x16, 0x7, 0xbf, 0x4a, 0, 0xfc, 0xad, 0xb9, 0x6, 0, 0xf3, 0x2e, 0xa5, 0x5e, 0x80, 0x3e, 0x34, 0, 0x15, 0x75, 0x5, 0xc6, 0x6, 0x34, 0, 0x7f, 0xbb, 0, 0, 0x8e, 0xc3, 0x8a, 0x1e, 0x34, 0, 0xc1, 0xe3, 0x2, 0x26, 0xc5, 0x3f, 0x8c, 0xd8, 0x36, 0xa3, 0x86, 0xf, 0x36, 0x89, 0x3e, 0x84, 0xf, 0x2b, 0x45, 0xfe, 0x2b, 0x7d, 0xfc, 0x16, 0x1f, 0xb, 0xc7, 0x74, 0x9, 0x26, 0xc7, 0x7, 0xf9, 0x9, 0x26, 0x8c, 0x5f, 0x2, 0xa0, 0x34, 0, 0x2e, 0xa2, 0xf5, 0xe, 0x2e, 0xa2, 0x7f, 0x98, 0x7, 0xc3}))
    II(0x00009985, 0x1)   pushw(es);                            /* push es */
    II(0x00009986, 0x3)   mov(di, 0x6341);                      /* mov di, 0x6341 */
l_0x00009989:
    II(0x00009989, 0x3)   add(di, 0xe);                         /* add di, 0xe */
    II(0x0000998c, 0x4)   cmp(memw_a16(cs, di), 0x1);           /* cmp word [cs:di], 0x1 */
    II(0x00009990, 0x2)   jzw(0x00009997, 0x5);                 /* jz 0x9997 */
    II(0x00009992, 0x3)   cmp(memw_a16(cs, di), si);            /* cmp [cs:di], si */
    II(0x00009995, 0x2)   jnzw(0x00009989, -0xe);               /* jnz 0x9989 */
l_0x00009997:
    II(0x00009997, 0x1)   pushw(si);                            /* push si */
    II(0x00009998, 0x2)   mov(si, di);                          /* mov si, di */
    II(0x0000999a, 0x1)   pushw(ss);                            /* push ss */
    II(0x0000999b, 0x1)   popw(es);                             /* pop es */
    II(0x0000999c, 0x3)   mov(di, 0x4a);                        /* mov di, 0x4a */
    II(0x0000999f, 0x1)   cld();                                /* cld  */
    II(0x000099a0, 0x1)   lodsw_a16();                          /* lodsw  */
    II(0x000099a1, 0x3)   mov(cx, 0x6);                         /* mov cx, 0x6 */
    II(0x000099a4, 0x3)   rep_a16 movsw_a16(cs);                /* rep cs movsw  */
    II(0x000099a7, 0x1)   popw(si);                             /* pop si */
    II(0x000099a8, 0x5)   cmp(memb_a16(ds, 0x34), 0x15);        /* cmp byte [0x34], 0x15 */
    II(0x000099ad, 0x2)   jnzw(0x000099b4, 0x5);                /* jnz 0x99b4 */
    II(0x000099af, 0x5)   mov(memb_a16(ds, 0x34), 0x7f);        /* mov byte [0x34], 0x7f */
l_0x000099b4:
    II(0x000099b4, 0x3)   mov(bx, 0);                           /* mov bx, 0x0 */
    II(0x000099b7, 0x2)   mov(es, bx);                          /* mov es, bx */
    II(0x000099b9, 0x4)   mov(bl, memb_a16(ds, 0x34));          /* mov bl, [0x34] */
    II(0x000099bd, 0x3)   shl(bx, 0x2);                         /* shl bx, 0x2 */
    II(0x000099c0, 0x3)   lds(di, es, bx);                      /* lds di, [es:bx] */
    II(0x000099c3, 0x2)   mov(ax, ds);                          /* mov ax, ds */
    II(0x000099c5, 0x4)   mov(memw_a16(ss, 0xf86), ax);         /* mov [ss:0xf86], ax */
    II(0x000099c9, 0x5)   mov(memw_a16(ss, 0xf84), di);         /* mov [ss:0xf84], di */
    II(0x000099ce, 0x3)   sub(ax, memw_a16(ds, di - 0x2));      /* sub ax, [di-0x2] */
    II(0x000099d1, 0x3)   sub(di, memw_a16(ds, di - 0x4));      /* sub di, [di-0x4] */
    II(0x000099d4, 0x1)   pushw(ss);                            /* push ss */
    II(0x000099d5, 0x1)   popw(ds);                             /* pop ds */
    II(0x000099d6, 0x2)   or_(ax, di);                          /* or ax, di */
    II(0x000099d8, 0x2)   jzw(0x000099e3, 0x9);                 /* jz 0x99e3 */
    II(0x000099da, 0x5)   mov(memw_a16(es, bx), 0x9f9);         /* mov word [es:bx], 0x9f9 */
    II(0x000099df, 0x4)   mov(memw_a16(es, bx + 0x2), ds);      /* mov [es:bx+0x2], ds */
l_0x000099e3:
    II(0x000099e3, 0x3)   mov(al, memb_a16(ds, 0x34));          /* mov al, [0x34] */
    II(0x000099e6, 0x4)   mov(memb_a16(cs, 0xef5), al);         /* mov [cs:0xef5], al */
    II(0x000099ea, 0x4)   mov(memb_a16(cs, -0x6781), al);       /* mov [cs:0x987f], al */
    II(0x000099ee, 0x1)   popw(es);                             /* pop es */
    II(0x000099ef, 0x1)   retw();                               /* ret  */
FUNC_END

