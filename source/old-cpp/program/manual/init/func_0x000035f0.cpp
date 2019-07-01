FUNC_BEGIN(0x000035f0, 0x80fe7966a7411fbc, 0x10, ({0xa2, 0x1, 0x46, 0x2, 0x66, 0xcf, 0, 0, 0xff, 0xff, 0, 0, 0, 0, 0, 0, 0x9c, 0x8c, 0xd1, 0x8b, 0xd4, 0x2e, 0x8e, 0x16, 0, 0, 0x36, 0x8b, 0x26, 0x50, 0xf, 0x51, 0x52, 0xe8, 0x44, 0, 0xa1, 0xc2, 0x10, 0x8b, 0x16, 0xc4, 0x10, 0x59, 0x17, 0x8b, 0xe1, 0x52, 0x50, 0xcf}))
    II(0x000035f0, 0x3)   mov(memb_a16(ds, 0x4601), al);        /* mov [0x4601], al */
    II(0x000035f3, 0x3)   add(ah, memb_a16(ss, bp - 0x31));     /* add ah, [bp-0x31] */
    II(0x000035f6, 0x2)   add(memb_a16(ds, bx + si), al);       /* add [bx+si], al */
    II(0x000035f8, 0x2)   invalid();                            /* invalid  */
    II(0x000035fa, 0x2)   add(memb_a16(ds, bx + si), al);       /* add [bx+si], al */
    II(0x000035fc, 0x2)   add(memb_a16(ds, bx + si), al);       /* add [bx+si], al */
    II(0x000035fe, 0x2)   add(memb_a16(ds, bx + si), al);       /* add [bx+si], al */
    II(0x00003600, 0x1)   pushfw();                             /* pushfw  */
    II(0x00003601, 0x2)   mov(cx, ss);                          /* mov cx, ss */
    II(0x00003603, 0x2)   mov(dx, sp);                          /* mov dx, sp */
    II(0x00003605, 0x5)   mov(ss, memw_a16(cs, 0));             /* mov ss, [cs:0x0] */
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

