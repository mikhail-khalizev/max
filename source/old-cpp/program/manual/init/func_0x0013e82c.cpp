FUNC_BEGIN(0x0013e82c, 0x86e255ee975a5eda, 0x10, ({0xc8, 0x14, 0, 0, 0x1e, 0xb8, 0x68, 0x3e, 0x8e, 0xd8, 0xc7, 0x46, 0xfa, 0, 0x1, 0x6a, 0, 0x6a, 0, 0x8d, 0x46, 0xec, 0x16, 0x50, 0x6a, 0xff, 0x90, 0xe, 0xe8, 0xf5, 0x2, 0x83, 0xc4, 0xa, 0x8b, 0x56, 0xfa, 0x2b, 0xc0, 0x3, 0x46, 0xfe, 0x83, 0xd2, 0, 0xb1, 0x4, 0xd1, 0xe0, 0xd1, 0xd2, 0xfe, 0xc9, 0x75, 0xf8, 0x1f, 0xc9, 0xcb}))
    II(0x0013e82c, 0x4)   enterw(0x14, 0);                      /* enter 0x14, 0x0 */
    II(0x0013e830, 0x1)   pushw(ds);                            /* push ds */
    II(0x0013e831, 0x3)   mov(ax, 0x3e68);                      /* mov ax, 0x3e68 */
    II(0x0013e834, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x0013e836, 0x5)   mov(memw_a16(ss, bp - 0x6), 0x100);   /* mov word [bp-0x6], 0x100 */
    II(0x0013e83b, 0x2)   pushw(0);                             /* push 0x0 */
    II(0x0013e83d, 0x2)   pushw(0);                             /* push 0x0 */
    II(0x0013e83f, 0x3)   lea(ax, bp - 0x14);                   /* lea ax, [bp-0x14] */
    II(0x0013e842, 0x1)   pushw(ss);                            /* push ss */
    II(0x0013e843, 0x1)   pushw(ax);                            /* push ax */
    II(0x0013e844, 0x2)   pushw(-0x1 /* 0xff */);               /* push 0xff */
//    II(0x0013e846, 0x1)   nop();                                /* nop  */
    II(0x0013e847, 0x1)   pushw(cs);                            /* push cs */
    II(0x0013e848, 0x3)   callw(0x0013eb40, 0x2f5);             /* call 0x13eb40 */
    II(0x0013e84b, 0x3)   add(sp, 0xa);                         /* add sp, 0xa */
    II(0x0013e84e, 0x3)   mov(dx, memw_a16(ss, bp - 0x6));      /* mov dx, [bp-0x6] */
    II(0x0013e851, 0x2)   sub(ax, ax);                          /* sub ax, ax */
    II(0x0013e853, 0x3)   add(ax, memw_a16(ss, bp - 0x2));      /* add ax, [bp-0x2] */
    II(0x0013e856, 0x3)   adc(dx, 0);                           /* adc dx, 0x0 */
    II(0x0013e859, 0x2)   mov(cl, 0x4);                         /* mov cl, 0x4 */
l_0x0013e85b:
    II(0x0013e85b, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
    II(0x0013e85d, 0x2)   rcl(dx, 0x1);                         /* rcl dx, 1 */
    II(0x0013e85f, 0x2)   dec(cl);                              /* dec cl */
    II(0x0013e861, 0x2)   jnzw(0x0013e85b, -0x8);               /* jnz 0x13e85b */
    II(0x0013e863, 0x1)   popw(ds);                             /* pop ds */
    II(0x0013e864, 0x1)   leavew();                             /* leave  */
    II(0x0013e865, 0x1)   retfw();                              /* retf  */
FUNC_END

