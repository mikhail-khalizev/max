FUNC_BEGIN(0x00009710, 0xc74ea5a3daee89f7, 0x10, ({0x55, 0x8b, 0xec, 0x57, 0x8b, 0x7e, 0x4, 0x1e, 0x7, 0x8b, 0xdf, 0x33, 0xc0, 0xb9, 0xff, 0xff, 0xf2, 0xae, 0x41, 0xf7, 0xd9, 0x8a, 0x46, 0x6, 0x8b, 0xfb, 0xf2, 0xae, 0x4f, 0x38, 0x5, 0x74, 0x2, 0x33, 0xff, 0x8b, 0xc7, 0x5f, 0x8b, 0xe5, 0x5d, 0xc3}))
    II(0x00009710, 0x1)   pushw(bp);                            /* push bp */
    II(0x00009711, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x00009713, 0x1)   pushw(di);                            /* push di */
    II(0x00009714, 0x3)   mov(di, memw_a16(ss, bp + 0x4));      /* mov di, [bp+0x4] */
    II(0x00009717, 0x1)   pushw(ds);                            /* push ds */
    II(0x00009718, 0x1)   popw(es);                             /* pop es */
    II(0x00009719, 0x2)   mov(bx, di);                          /* mov bx, di */
    II(0x0000971b, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x0000971d, 0x3)   mov(cx, 0xffff);                      /* mov cx, 0xffff */
    II(0x00009720, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x00009722, 0x1)   inc(cx);                              /* inc cx */
    II(0x00009723, 0x2)   neg(cx);                              /* neg cx */
    II(0x00009725, 0x3)   mov(al, memb_a16(ss, bp + 0x6));      /* mov al, [bp+0x6] */
    II(0x00009728, 0x2)   mov(di, bx);                          /* mov di, bx */
    II(0x0000972a, 0x2)   repne_a16 scasb_a16();                /* repne scasb  */
    II(0x0000972c, 0x1)   dec(di);                              /* dec di */
    II(0x0000972d, 0x2)   cmp(memb_a16(ds, di), al);            /* cmp [di], al */
    II(0x0000972f, 0x2)   jzw(0x00009733, 0x2);                 /* jz 0x9733 */
    II(0x00009731, 0x2)   xor_(di, di);                         /* xor di, di */
l_0x00009733:
    II(0x00009733, 0x2)   mov(ax, di);                          /* mov ax, di */
    II(0x00009735, 0x1)   popw(di);                             /* pop di */
    II(0x00009736, 0x2)   mov(sp, bp);                          /* mov sp, bp */
    II(0x00009738, 0x1)   popw(bp);                             /* pop bp */
    II(0x00009739, 0x1)   retw();                               /* ret  */
FUNC_END

