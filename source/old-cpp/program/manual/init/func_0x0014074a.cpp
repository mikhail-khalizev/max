FUNC_BEGIN(0x0014074a, 0x4a8d40cf2e5e2f23, 0x10, ({0xc8, 0x16, 0, 0, 0x1e, 0xb8, 0x68, 0x3e, 0x8e, 0xd8, 0xc7, 0x46, 0xfe, 0, 0x3c, 0xc7, 0x46, 0xec, 0, 0, 0x8b, 0x46, 0x6, 0x89, 0x46, 0xfa, 0x8b, 0x46, 0xa, 0x89, 0x46, 0xea, 0x8b, 0x46, 0x8, 0x89, 0x46, 0xf8, 0x8d, 0x46, 0xea, 0x16, 0x50, 0x68, 0, 0x3c, 0x90, 0xe, 0xe8, 0x70, 0xe3, 0x83, 0xc4, 0x6, 0xb, 0xc0, 0x74, 0x5, 0x8b, 0x46, 0xfc, 0xeb, 0x3, 0xb8, 0xff, 0xff, 0x1f, 0xc9, 0xca, 0x6, 0}))
    II(0x0014074a, 0x4)   enterw(0x16, 0);                      /* enter 0x16, 0x0 */
    II(0x0014074e, 0x1)   pushw(ds);                            /* push ds */
    II(0x0014074f, 0x3)   mov(ax, 0x3e68);                      /* mov ax, 0x3e68 */
    II(0x00140752, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x00140754, 0x5)   mov(memw_a16(ss, bp - 0x2), 0x3c00);  /* mov word [bp-0x2], 0x3c00 */
    II(0x00140759, 0x5)   mov(memw_a16(ss, bp - 0x14), 0);      /* mov word [bp-0x14], 0x0 */
    II(0x0014075e, 0x3)   mov(ax, memw_a16(ss, bp + 0x6));      /* mov ax, [bp+0x6] */
    II(0x00140761, 0x3)   mov(memw_a16(ss, bp - 0x6), ax);      /* mov [bp-0x6], ax */
    II(0x00140764, 0x3)   mov(ax, memw_a16(ss, bp + 0xa));      /* mov ax, [bp+0xa] */
    II(0x00140767, 0x3)   mov(memw_a16(ss, bp - 0x16), ax);     /* mov [bp-0x16], ax */
    II(0x0014076a, 0x3)   mov(ax, memw_a16(ss, bp + 0x8));      /* mov ax, [bp+0x8] */
    II(0x0014076d, 0x3)   mov(memw_a16(ss, bp - 0x8), ax);      /* mov [bp-0x8], ax */
    II(0x00140770, 0x3)   lea(ax, bp - 0x16);                   /* lea ax, [bp-0x16] */
    II(0x00140773, 0x1)   pushw(ss);                            /* push ss */
    II(0x00140774, 0x1)   pushw(ax);                            /* push ax */
    II(0x00140775, 0x3)   pushw(0x3c00);                        /* push word 0x3c00 */
//    II(0x00140778, 0x1)   nop();                                /* nop  */
    II(0x00140779, 0x1)   pushw(cs);                            /* push cs */
    II(0x0014077a, 0x3)   callw(0x0013eaed, -0x1c90);           /* call 0x13eaed */
    II(0x0014077d, 0x3)   add(sp, 0x6);                         /* add sp, 0x6 */
    II(0x00140780, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x00140782, 0x2)   jzw(0x00140789, 0x5);                 /* jz 0x140789 */
    II(0x00140784, 0x3)   mov(ax, memw_a16(ss, bp - 0x4));      /* mov ax, [bp-0x4] */
    II(0x00140787, 0x2)   jmpw(0x0014078c, 0x3);                /* jmp 0x14078c */
l_0x00140789:
    II(0x00140789, 0x3)   mov(ax, 0xffff);                      /* mov ax, 0xffff */
l_0x0014078c:
    II(0x0014078c, 0x1)   popw(ds);                             /* pop ds */
    II(0x0014078d, 0x1)   leavew();                             /* leave  */
    II(0x0014078e, 0x3)   retfw(0x6);                           /* retf 0x6 */
FUNC_END

