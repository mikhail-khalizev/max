FUNC_BEGIN(0x0015a06c, 0xef91cc10ef1d3c0a, 0x10, ({0xc8, 0x2, 0, 0, 0x57, 0x56, 0xc4, 0x5e, 0x4, 0x2b, 0xc0, 0x26, 0x89, 0x47, 0x2, 0x26, 0x89, 0x7, 0xc4, 0x1e, 0x1a, 0x1f, 0x26, 0x83, 0xbf, 0x62, 0x13, 0x10, 0x72, 0x6, 0xb8, 0xff, 0xff, 0xe9, 0xb6, 0, 0x89, 0x46, 0xfe, 0xeb, 0x3, 0xff, 0x46, 0xfe, 0x8b, 0x1e, 0x1a, 0x1f, 0x81, 0xc3, 0x52, 0x13, 0x8b, 0x76, 0xfe, 0x26, 0x80, 0x38, 0, 0x74, 0x7, 0x83, 0xfe, 0x10, 0x72, 0xe7, 0xeb, 0xda, 0x69, 0xc6, 0x34, 0x1, 0x8b, 0xc8, 0x3, 0x6, 0x1a, 0x1f, 0x8c, 0xc2, 0x8b, 0xd8, 0x8c, 0xc6, 0x5, 0x12, 0, 0xc4, 0x7e, 0x4, 0x26, 0x89, 0x5, 0x26, 0x89, 0x55, 0x2, 0x8b, 0xc3, 0xc4, 0x1e, 0x1a, 0x1f, 0x8b, 0x7e, 0xfe, 0x26, 0xc6, 0x81, 0x52, 0x13, 0x1, 0xff, 0x76, 0xa, 0xff, 0x76, 0x8, 0x5, 0xfc, 0, 0x56, 0x50, 0x8b, 0xf1, 0xe8, 0xd7, 0x33, 0x83, 0x7e, 0xa, 0, 0x74, 0x32, 0xff, 0x76, 0xa, 0xff, 0x76, 0x8, 0x8b, 0xc6, 0x3, 0x36, 0x1a, 0x1f, 0x8b, 0xe, 0x1c, 0x1f, 0x81, 0xc6, 0x84, 0, 0x51, 0x56, 0x8b, 0xf0, 0x90, 0xe, 0xe8, 0xde, 0x60, 0x3, 0x36, 0x1a, 0x1f, 0x8b, 0xe, 0x1c, 0x1f, 0x81, 0xc6, 0x84, 0, 0x51, 0x56, 0x9a, 0x8, 0x45, 0x80, 0, 0x5b, 0x5b, 0xc4, 0x5e, 0x4, 0x26, 0xff, 0x77, 0x2, 0x26, 0xff, 0x37, 0xe8, 0xdd, 0xfc, 0x8b, 0xdf, 0xd1, 0xe3, 0xc7, 0x87, 0x24, 0x1f, 0x1, 0, 0xc4, 0x1e, 0x1a, 0x1f, 0x26, 0xff, 0x87, 0x62, 0x13, 0x8b, 0xc7, 0x5e, 0x5f, 0xc9, 0xc2, 0x8, 0}))
    II(0x0015a06c, 0x4)   enterw(0x2, 0);                       /* enter 0x2, 0x0 */
    II(0x0015a070, 0x1)   pushw(di);                            /* push di */
    II(0x0015a071, 0x1)   pushw(si);                            /* push si */
    II(0x0015a072, 0x3)   les(bx, ss, bp + 0x4);                /* les bx, [bp+0x4] */
    II(0x0015a075, 0x2)   sub(ax, ax);                          /* sub ax, ax */
    II(0x0015a077, 0x4)   mov(memw_a16(es, bx + 0x2), ax);      /* mov [es:bx+0x2], ax */
    II(0x0015a07b, 0x3)   mov(memw_a16(es, bx), ax);            /* mov [es:bx], ax */
    II(0x0015a07e, 0x4)   les(bx, ds, 0x1f1a);                  /* les bx, [0x1f1a] */
    II(0x0015a082, 0x6)   cmp(memw_a16(es, bx + 0x1362), 0x10); /* cmp word [es:bx+0x1362], 0x10 */
    II(0x0015a088, 0x2)   jbw(0x0015a090, 0x6);                 /* jb 0x15a090 */
l_0x0015a08a:
    II(0x0015a08a, 0x3)   mov(ax, 0xffff);                      /* mov ax, 0xffff */
    II(0x0015a08d, 0x3)   jmpw(0x0015a146, 0xb6);               /* jmp 0x15a146 */
l_0x0015a090:
    II(0x0015a090, 0x3)   mov(memw_a16(ss, bp - 0x2), ax);      /* mov [bp-0x2], ax */
    II(0x0015a093, 0x2)   jmpw(0x0015a098, 0x3);                /* jmp 0x15a098 */
l_0x0015a095:
    II(0x0015a095, 0x3)   inc(memw_a16(ss, bp - 0x2));          /* inc word [bp-0x2] */
l_0x0015a098:
    II(0x0015a098, 0x4)   mov(bx, memw_a16(ds, 0x1f1a));        /* mov bx, [0x1f1a] */
    II(0x0015a09c, 0x4)   add(bx, 0x1352);                      /* add bx, 0x1352 */
    II(0x0015a0a0, 0x3)   mov(si, memw_a16(ss, bp - 0x2));      /* mov si, [bp-0x2] */
    II(0x0015a0a3, 0x4)   cmp(memb_a16(es, bx + si), 0);        /* cmp byte [es:bx+si], 0x0 */
    II(0x0015a0a7, 0x2)   jzw(0x0015a0b0, 0x7);                 /* jz 0x15a0b0 */
    II(0x0015a0a9, 0x3)   cmp(si, 0x10);                        /* cmp si, 0x10 */
    II(0x0015a0ac, 0x2)   jbw(0x0015a095, -0x19);               /* jb 0x15a095 */
    II(0x0015a0ae, 0x2)   jmpw(0x0015a08a, -0x26);              /* jmp 0x15a08a */
l_0x0015a0b0:
    II(0x0015a0b0, 0x4)   imul(ax, si, 0x134);                  /* imul ax, si, 0x134 */
    II(0x0015a0b4, 0x2)   mov(cx, ax);                          /* mov cx, ax */
    II(0x0015a0b6, 0x4)   add(ax, memw_a16(ds, 0x1f1a));        /* add ax, [0x1f1a] */
    II(0x0015a0ba, 0x2)   mov(dx, es);                          /* mov dx, es */
    II(0x0015a0bc, 0x2)   mov(bx, ax);                          /* mov bx, ax */
    II(0x0015a0be, 0x2)   mov(si, es);                          /* mov si, es */
    II(0x0015a0c0, 0x3)   add(ax, 0x12);                        /* add ax, 0x12 */
    II(0x0015a0c3, 0x3)   les(di, ss, bp + 0x4);                /* les di, [bp+0x4] */
    II(0x0015a0c6, 0x3)   mov(memw_a16(es, di), ax);            /* mov [es:di], ax */
    II(0x0015a0c9, 0x4)   mov(memw_a16(es, di + 0x2), dx);      /* mov [es:di+0x2], dx */
    II(0x0015a0cd, 0x2)   mov(ax, bx);                          /* mov ax, bx */
    II(0x0015a0cf, 0x4)   les(bx, ds, 0x1f1a);                  /* les bx, [0x1f1a] */
    II(0x0015a0d3, 0x3)   mov(di, memw_a16(ss, bp - 0x2));      /* mov di, [bp-0x2] */
    II(0x0015a0d6, 0x6)   mov(memb_a16(es, bx + di + 0x1352), 0x1); /* mov byte [es:bx+di+0x1352], 0x1 */
    II(0x0015a0dc, 0x3)   pushw(memw_a16(ss, bp + 0xa));        /* push word [bp+0xa] */
    II(0x0015a0df, 0x3)   pushw(memw_a16(ss, bp + 0x8));        /* push word [bp+0x8] */
    II(0x0015a0e2, 0x3)   add(ax, 0xfc);                        /* add ax, 0xfc */
    II(0x0015a0e5, 0x1)   pushw(si);                            /* push si */
    II(0x0015a0e6, 0x1)   pushw(ax);                            /* push ax */
    II(0x0015a0e7, 0x2)   mov(si, cx);                          /* mov si, cx */
    II(0x0015a0e9, 0x3)   callw(0x0015d4c3, 0x33d7);            /* call 0x15d4c3 */
    II(0x0015a0ec, 0x4)   cmp(memw_a16(ss, bp + 0xa), 0);       /* cmp word [bp+0xa], 0x0 */
    II(0x0015a0f0, 0x2)   jzw(0x0015a124, 0x32);                /* jz 0x15a124 */
    II(0x0015a0f2, 0x3)   pushw(memw_a16(ss, bp + 0xa));        /* push word [bp+0xa] */
    II(0x0015a0f5, 0x3)   pushw(memw_a16(ss, bp + 0x8));        /* push word [bp+0x8] */
    II(0x0015a0f8, 0x2)   mov(ax, si);                          /* mov ax, si */
    II(0x0015a0fa, 0x4)   add(si, memw_a16(ds, 0x1f1a));        /* add si, [0x1f1a] */
    II(0x0015a0fe, 0x4)   mov(cx, memw_a16(ds, 0x1f1c));        /* mov cx, [0x1f1c] */
    II(0x0015a102, 0x4)   add(si, 0x84);                        /* add si, 0x84 */
    II(0x0015a106, 0x1)   pushw(cx);                            /* push cx */
    II(0x0015a107, 0x1)   pushw(si);                            /* push si */
    II(0x0015a108, 0x2)   mov(si, ax);                          /* mov si, ax */
//    II(0x0015a10a, 0x1)   nop();                                /* nop  */
    II(0x0015a10b, 0x1)   pushw(cs);                            /* push cs */
    II(0x0015a10c, 0x3)   callw(0x001601ed, 0x60de);            /* call 0x1601ed */
    II(0x0015a10f, 0x4)   add(si, memw_a16(ds, 0x1f1a));        /* add si, [0x1f1a] */
    II(0x0015a113, 0x4)   mov(cx, memw_a16(ds, 0x1f1c));        /* mov cx, [0x1f1c] */
    II(0x0015a117, 0x4)   add(si, 0x84);                        /* add si, 0x84 */
    II(0x0015a11b, 0x1)   pushw(cx);                            /* push cx */
    II(0x0015a11c, 0x1)   pushw(si);                            /* push si */
    II(0x0015a11d, 0x5)   callw_far_abs(0x80, 0x4508);          /* call word 0x80:0x4508 */
    II(0x0015a122, 0x1)   popw(bx);                             /* pop bx */
    II(0x0015a123, 0x1)   popw(bx);                             /* pop bx */
l_0x0015a124:
    II(0x0015a124, 0x3)   les(bx, ss, bp + 0x4);                /* les bx, [bp+0x4] */
    II(0x0015a127, 0x4)   pushw(memw_a16(es, bx + 0x2));        /* push word [es:bx+0x2] */
    II(0x0015a12b, 0x3)   pushw(memw_a16(es, bx));              /* push word [es:bx] */
    II(0x0015a12e, 0x3)   callw(0x00159e0e, -0x323);            /* call 0x159e0e */
    II(0x0015a131, 0x2)   mov(bx, di);                          /* mov bx, di */
    II(0x0015a133, 0x2)   shl(bx, 0x1);                         /* shl bx, 1 */
    II(0x0015a135, 0x6)   mov(memw_a16(ds, bx + 0x1f24), 0x1);  /* mov word [bx+0x1f24], 0x1 */
    II(0x0015a13b, 0x4)   les(bx, ds, 0x1f1a);                  /* les bx, [0x1f1a] */
    II(0x0015a13f, 0x5)   inc(memw_a16(es, bx + 0x1362));       /* inc word [es:bx+0x1362] */
    II(0x0015a144, 0x2)   mov(ax, di);                          /* mov ax, di */
l_0x0015a146:
    II(0x0015a146, 0x1)   popw(si);                             /* pop si */
    II(0x0015a147, 0x1)   popw(di);                             /* pop di */
    II(0x0015a148, 0x1)   leavew();                             /* leave  */
    II(0x0015a149, 0x3)   retw(0x8);                            /* ret 0x8 */
FUNC_END

