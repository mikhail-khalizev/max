FUNC_BEGIN(0x00003608, 0xb67d2c2a82b2b1d, 0x10, ({0, 0, 0x36, 0x8b, 0x26, 0x50, 0xf, 0x51, 0x52, 0xe8, 0x44, 0, 0xa1, 0xc2, 0x10, 0x8b, 0x16, 0xc4, 0x10, 0x59, 0x17, 0x8b, 0xe1, 0x52, 0x50, 0xcf}))
    II(0x00003608, 0x2)   add(memb_a16(ds, bx + si), al);       /* add [bx+si], al */
    II(0x0000360a, 0x5)   mov(sp, memw_a16(ss, 0xf50));         /* mov sp, [ss:0xf50] */
    II(0x0000360f, 0x1)   pushw(cx);                            /* push cx */
    II(0x00003610, 0x1)   pushw(dx);                            /* push dx */
    II(0x00003611, 0x3)   callw(0x00003658, 0x44);              /* call 0x3658 */
    II(0x00003614, 0x3)   mov(ax, memw_a16(ds, 0x10c2));        /* mov ax, [0x10c2] */
    II(0x00003617, 0x4)   mov(dx, memw_a16(ds, 0x10c4));        /* mov dx, [0x10c4] */
    II(0x0000361b, 0x1)   popw(cx);                             /* pop cx */
    II(0x0000361c, 0x1)   popw(ss);                             /* pop ss */
    II(0x0000361d, 0x2)   mov(sp, cx);                          /* mov sp, cx */
    II(0x0000361f, 0x1)   pushw(dx);                            /* push dx */
    II(0x00003620, 0x1)   pushw(ax);                            /* push ax */
    II(0x00003621, 0x1)   iretw();                              /* iretw  */
FUNC_END

