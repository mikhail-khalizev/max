FUNC_BEGIN(0x0015a16e, 0xf667f6fe3610b777, 0x10, ({0xc8, 0x2, 0, 0, 0x56, 0xc7, 0x46, 0xfe, 0, 0, 0xeb, 0x3, 0xff, 0x46, 0xfe, 0x83, 0x7e, 0xfe, 0x10, 0x73, 0x36, 0xc4, 0x1e, 0x1a, 0x1f, 0x81, 0xc3, 0x52, 0x13, 0x8b, 0x76, 0xfe, 0x26, 0x80, 0x38, 0, 0x74, 0xe6, 0x69, 0xc6, 0x34, 0x1, 0x3, 0x6, 0x1a, 0x1f, 0x8c, 0xc2, 0x5, 0xfc, 0, 0x52, 0x50, 0xff, 0x76, 0x6, 0xff, 0x76, 0x4, 0x9a, 0x38, 0x44, 0x80, 0, 0x83, 0xc4, 0x8, 0xb, 0xc0, 0x75, 0xc5, 0x8b, 0xc6, 0xeb, 0x3, 0xb8, 0xff, 0xff, 0x5e, 0xc9, 0xc2, 0x4, 0}))
    II(0x0015a16e, 0x4)   enterw(0x2, 0);                       /* enter 0x2, 0x0 */
    II(0x0015a172, 0x1)   pushw(si);                            /* push si */
    II(0x0015a173, 0x5)   mov(memw_a16(ss, bp - 0x2), 0);       /* mov word [bp-0x2], 0x0 */
    II(0x0015a178, 0x2)   jmpw(0x0015a17d, 0x3);                /* jmp 0x15a17d */
l_0x0015a17a:
    II(0x0015a17a, 0x3)   inc(memw_a16(ss, bp - 0x2));          /* inc word [bp-0x2] */
l_0x0015a17d:
    II(0x0015a17d, 0x4)   cmp(memw_a16(ss, bp - 0x2), 0x10);    /* cmp word [bp-0x2], 0x10 */
    II(0x0015a181, 0x2)   jaew(0x0015a1b9, 0x36);               /* jae 0x15a1b9 */
    II(0x0015a183, 0x4)   les(bx, ds, 0x1f1a);                  /* les bx, [0x1f1a] */
    II(0x0015a187, 0x4)   add(bx, 0x1352);                      /* add bx, 0x1352 */
    II(0x0015a18b, 0x3)   mov(si, memw_a16(ss, bp - 0x2));      /* mov si, [bp-0x2] */
    II(0x0015a18e, 0x4)   cmp(memb_a16(es, bx + si), 0);        /* cmp byte [es:bx+si], 0x0 */
    II(0x0015a192, 0x2)   jzw(0x0015a17a, -0x1a);               /* jz 0x15a17a */
    II(0x0015a194, 0x4)   imul(ax, si, 0x134);                  /* imul ax, si, 0x134 */
    II(0x0015a198, 0x4)   add(ax, memw_a16(ds, 0x1f1a));        /* add ax, [0x1f1a] */
    II(0x0015a19c, 0x2)   mov(dx, es);                          /* mov dx, es */
    II(0x0015a19e, 0x3)   add(ax, 0xfc);                        /* add ax, 0xfc */
    II(0x0015a1a1, 0x1)   pushw(dx);                            /* push dx */
    II(0x0015a1a2, 0x1)   pushw(ax);                            /* push ax */
    II(0x0015a1a3, 0x3)   pushw(memw_a16(ss, bp + 0x6));        /* push word [bp+0x6] */
    II(0x0015a1a6, 0x3)   pushw(memw_a16(ss, bp + 0x4));        /* push word [bp+0x4] */
    II(0x0015a1a9, 0x5)   callw_far_abs(0x80, 0x4438);          /* call word 0x80:0x4438 */
    II(0x0015a1ae, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
    II(0x0015a1b1, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x0015a1b3, 0x2)   jnzw(0x0015a17a, -0x3b);              /* jnz 0x15a17a */
    II(0x0015a1b5, 0x2)   mov(ax, si);                          /* mov ax, si */
    II(0x0015a1b7, 0x2)   jmpw(0x0015a1bc, 0x3);                /* jmp 0x15a1bc */
l_0x0015a1b9:
    II(0x0015a1b9, 0x3)   mov(ax, 0xffff);                      /* mov ax, 0xffff */
l_0x0015a1bc:
    II(0x0015a1bc, 0x1)   popw(si);                             /* pop si */
    II(0x0015a1bd, 0x1)   leavew();                             /* leave  */
    II(0x0015a1be, 0x3)   retw(0x4);                            /* ret 0x4 */
FUNC_END

