FUNC_BEGIN(0x0000dd62, 0xe164d98be6754b1f, 0x10, ({0xc8, 0x4, 0, 0, 0x83, 0x3e, 0xa2, 0, 0, 0x74, 0x2c, 0xa1, 0xa0, 0, 0x89, 0x46, 0xfc, 0xc7, 0x46, 0xfe, 0x60, 0, 0x68, 0x92, 0, 0x6a, 0xff, 0x6a, 0, 0xff, 0x36, 0xa2, 0, 0x6a, 0x60, 0xe8, 0xcc, 0x1c, 0x8b, 0x46, 0x4, 0x8b, 0x56, 0x6, 0xc4, 0x5e, 0xfc, 0x26, 0x1, 0x47, 0xc, 0x26, 0x11, 0x57, 0xe, 0xc9, 0xc3}))
    II(0x0000dd62, 0x4)   enterw(0x4, 0);                       /* enter 0x4, 0x0 */
    II(0x0000dd66, 0x5)   cmp(memw_a16(ds, 0xa2), 0);           /* cmp word [0xa2], 0x0 */
    II(0x0000dd6b, 0x2)   jzw(0x0000dd99, 0x2c);                /* jz 0xdd99 */
    II(0x0000dd6d, 0x3)   mov(ax, memw_a16(ds, 0xa0));          /* mov ax, [0xa0] */
    II(0x0000dd70, 0x3)   mov(memw_a16(ss, bp - 0x4), ax);      /* mov [bp-0x4], ax */
    II(0x0000dd73, 0x5)   mov(memw_a16(ss, bp - 0x2), 0x60);    /* mov word [bp-0x2], 0x60 */
    II(0x0000dd78, 0x3)   pushw(0x92);                          /* push word 0x92 */
    II(0x0000dd7b, 0x2)   pushw(-0x1 /* 0xff */);               /* push 0xff */
    II(0x0000dd7d, 0x2)   pushw(0);                             /* push 0x0 */
    II(0x0000dd7f, 0x4)   pushw(memw_a16(ds, 0xa2));            /* push word [0xa2] */
    II(0x0000dd83, 0x2)   pushw(0x60);                          /* push 0x60 */
    II(0x0000dd85, 0x3)   callw(0x0000fa54, 0x1ccc);            /* call 0xfa54 */
    II(0x0000dd88, 0x3)   mov(ax, memw_a16(ss, bp + 0x4));      /* mov ax, [bp+0x4] */
    II(0x0000dd8b, 0x3)   mov(dx, memw_a16(ss, bp + 0x6));      /* mov dx, [bp+0x6] */
    II(0x0000dd8e, 0x3)   les(bx, ss, bp - 0x4);                /* les bx, [bp-0x4] */
    II(0x0000dd91, 0x4)   add(memw_a16(es, bx + 0xc), ax);      /* add [es:bx+0xc], ax */
    II(0x0000dd95, 0x4)   adc(memw_a16(es, bx + 0xe), dx);      /* adc [es:bx+0xe], dx */
l_0x0000dd99:
    II(0x0000dd99, 0x1)   leavew();                             /* leave  */
    II(0x0000dd9a, 0x1)   retw();                               /* ret  */
FUNC_END

