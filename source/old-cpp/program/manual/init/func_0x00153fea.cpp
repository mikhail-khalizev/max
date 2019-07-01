FUNC_BEGIN(0x00153fea, 0xc0d0d7819a7f0232, 0x10, ({0x6, 0x57, 0x8b, 0xf8, 0x3, 0xfb, 0x89, 0x7f, 0x4, 0x4f, 0x4f, 0x2d, 0x16, 0, 0x8d, 0x77, 0x14, 0xc7, 0x5, 0xfe, 0xff, 0x89, 0x7f, 0xa, 0x48, 0x89, 0x4, 0x8c, 0x1f, 0x8b, 0xc6, 0x8c, 0xda, 0x8e, 0xc2, 0x8d, 0x7f, 0x6, 0xfc, 0xab, 0xab, 0x47, 0x47, 0x33, 0xc0, 0xab, 0xab, 0xab, 0xab, 0x5f, 0x7, 0xc3}))
    II(0x00153fea, 0x1)   pushw(es);                            /* push es */
    II(0x00153feb, 0x1)   pushw(di);                            /* push di */
    II(0x00153fec, 0x2)   mov(di, ax);                          /* mov di, ax */
    II(0x00153fee, 0x2)   add(di, bx);                          /* add di, bx */
    II(0x00153ff0, 0x3)   mov(memw_a16(ds, bx + 0x4), di);      /* mov [bx+0x4], di */
    II(0x00153ff3, 0x1)   dec(di);                              /* dec di */
    II(0x00153ff4, 0x1)   dec(di);                              /* dec di */
    II(0x00153ff5, 0x3)   sub(ax, 0x16);                        /* sub ax, 0x16 */
    II(0x00153ff8, 0x3)   lea(si, bx + 0x14);                   /* lea si, [bx+0x14] */
    II(0x00153ffb, 0x4)   mov(memw_a16(ds, di), 0xfffe);        /* mov word [di], 0xfffe */
    II(0x00153fff, 0x3)   mov(memw_a16(ds, bx + 0xa), di);      /* mov [bx+0xa], di */
    II(0x00154002, 0x1)   dec(ax);                              /* dec ax */
    II(0x00154003, 0x2)   mov(memw_a16(ds, si), ax);            /* mov [si], ax */
    II(0x00154005, 0x2)   mov(memw_a16(ds, bx), ds);            /* mov [bx], ds */
    II(0x00154007, 0x2)   mov(ax, si);                          /* mov ax, si */
    II(0x00154009, 0x2)   mov(dx, ds);                          /* mov dx, ds */
    II(0x0015400b, 0x2)   mov(es, dx);                          /* mov es, dx */
    II(0x0015400d, 0x3)   lea(di, bx + 0x6);                    /* lea di, [bx+0x6] */
    II(0x00154010, 0x1)   cld();                                /* cld  */
    II(0x00154011, 0x1)   stosw_a16();                          /* stosw  */
    II(0x00154012, 0x1)   stosw_a16();                          /* stosw  */
    II(0x00154013, 0x1)   inc(di);                              /* inc di */
    II(0x00154014, 0x1)   inc(di);                              /* inc di */
    II(0x00154015, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x00154017, 0x1)   stosw_a16();                          /* stosw  */
    II(0x00154018, 0x1)   stosw_a16();                          /* stosw  */
    II(0x00154019, 0x1)   stosw_a16();                          /* stosw  */
    II(0x0015401a, 0x1)   stosw_a16();                          /* stosw  */
    II(0x0015401b, 0x1)   popw(di);                             /* pop di */
    II(0x0015401c, 0x1)   popw(es);                             /* pop es */
    II(0x0015401d, 0x1)   retw();                               /* ret  */
FUNC_END

