FUNC_BEGIN(0x00134a4e, 0x34f1a32fd206bbe6, 0x10, ({0xc8, 0x2, 0, 0, 0x56, 0x1e, 0xb8, 0x68, 0x3e, 0x8e, 0xd8, 0x8b, 0x76, 0x6, 0x56, 0x90, 0xe, 0xe8, 0xb4, 0x90, 0x83, 0xc4, 0x2, 0x89, 0x46, 0xfe, 0xb, 0xc0, 0x74, 0x8, 0x8b, 0xd8, 0x80, 0x78, 0xff, 0x5c, 0x74, 0xc, 0x68, 0xda, 0, 0x56, 0x90, 0xe, 0xe8, 0x59, 0x90, 0x83, 0xc4, 0x4, 0x80, 0x3e, 0x39, 0, 0, 0x74, 0x19, 0x1e, 0x56, 0x90, 0xe, 0xe8, 0x62, 0x46, 0x83, 0xc4, 0x4, 0xb, 0xc0, 0x74, 0x9, 0xc6, 0x4, 0, 0x2b, 0xc0, 0x1f, 0x5e, 0xc9, 0xcb, 0xeb, 0xc, 0x68, 0xdc, 0, 0x56, 0x90, 0xe, 0xe8, 0x2d, 0x90, 0x83, 0xc4, 0x4, 0x68, 0xe4, 0, 0x56, 0x90, 0xe, 0xe8, 0x21, 0x90, 0x83, 0xc4, 0x4, 0xb8, 0x1, 0, 0x1f, 0x5e, 0xc9, 0xcb}))
    II(0x00134a4e, 0x4)   enterw(0x2, 0);                       /* enter 0x2, 0x0 */
    II(0x00134a52, 0x1)   pushw(si);                            /* push si */
    II(0x00134a53, 0x1)   pushw(ds);                            /* push ds */
    II(0x00134a54, 0x3)   mov(ax, 0x3e68);                      /* mov ax, 0x3e68 */
    II(0x00134a57, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x00134a59, 0x3)   mov(si, memw_a16(ss, bp + 0x6));      /* mov si, [bp+0x6] */
    II(0x00134a5c, 0x1)   pushw(si);                            /* push si */
//    II(0x00134a5d, 0x1)   nop();                                /* nop  */
    II(0x00134a5e, 0x1)   pushw(cs);                            /* push cs */
    II(0x00134a5f, 0x3)   callw(0x0012db16, -0x6f4c);           /* call 0x12db16 */
    II(0x00134a62, 0x3)   add(sp, 0x2);                         /* add sp, 0x2 */
    II(0x00134a65, 0x3)   mov(memw_a16(ss, bp - 0x2), ax);      /* mov [bp-0x2], ax */
    II(0x00134a68, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x00134a6a, 0x2)   jzw(0x00134a74, 0x8);                 /* jz 0x134a74 */
    II(0x00134a6c, 0x2)   mov(bx, ax);                          /* mov bx, ax */
    II(0x00134a6e, 0x4)   cmp(memb_a16(ds, bx + si - 0x1), 0x5c); /* cmp byte [bx+si-0x1], 0x5c */
    II(0x00134a72, 0x2)   jzw(0x00134a80, 0xc);                 /* jz 0x134a80 */
l_0x00134a74:
    II(0x00134a74, 0x3)   pushw(0xda);                          /* push word 0xda */
    II(0x00134a77, 0x1)   pushw(si);                            /* push si */
//    II(0x00134a78, 0x1)   nop();                                /* nop  */
    II(0x00134a79, 0x1)   pushw(cs);                            /* push cs */
    II(0x00134a7a, 0x3)   callw(0x0012dad6, -0x6fa7);           /* call 0x12dad6 */
    II(0x00134a7d, 0x3)   add(sp, 0x4);                         /* add sp, 0x4 */
l_0x00134a80:
    II(0x00134a80, 0x5)   cmp(memb_a16(ds, 0x39), 0);           /* cmp byte [0x39], 0x0 */
    II(0x00134a85, 0x2)   jzw(0x00134aa0, 0x19);                /* jz 0x134aa0 */
    II(0x00134a87, 0x1)   pushw(ds);                            /* push ds */
    II(0x00134a88, 0x1)   pushw(si);                            /* push si */
//    II(0x00134a89, 0x1)   nop();                                /* nop  */
    II(0x00134a8a, 0x1)   pushw(cs);                            /* push cs */
    II(0x00134a8b, 0x3)   callw(0x001390f0, 0x4662);            /* call 0x1390f0 */
    II(0x00134a8e, 0x3)   add(sp, 0x4);                         /* add sp, 0x4 */
    II(0x00134a91, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x00134a93, 0x2)   jzw(0x00134a9e, 0x9);                 /* jz 0x134a9e */
    II(0x00134a95, 0x3)   mov(memb_a16(ds, si), 0);             /* mov byte [si], 0x0 */
    II(0x00134a98, 0x2)   sub(ax, ax);                          /* sub ax, ax */
    II(0x00134a9a, 0x1)   popw(ds);                             /* pop ds */
    II(0x00134a9b, 0x1)   popw(si);                             /* pop si */
    II(0x00134a9c, 0x1)   leavew();                             /* leave  */
    II(0x00134a9d, 0x1)   retfw();                              /* retf  */
l_0x00134a9e:
    II(0x00134a9e, 0x2)   jmpw(0x00134aac, 0xc);                /* jmp 0x134aac */
l_0x00134aa0:
    II(0x00134aa0, 0x3)   pushw(0xdc);                          /* push word 0xdc */
    II(0x00134aa3, 0x1)   pushw(si);                            /* push si */
//    II(0x00134aa4, 0x1)   nop();                                /* nop  */
    II(0x00134aa5, 0x1)   pushw(cs);                            /* push cs */
    II(0x00134aa6, 0x3)   callw(0x0012dad6, -0x6fd3);           /* call 0x12dad6 */
    II(0x00134aa9, 0x3)   add(sp, 0x4);                         /* add sp, 0x4 */
l_0x00134aac:
    II(0x00134aac, 0x3)   pushw(0xe4);                          /* push word 0xe4 */
    II(0x00134aaf, 0x1)   pushw(si);                            /* push si */
//    II(0x00134ab0, 0x1)   nop();                                /* nop  */
    II(0x00134ab1, 0x1)   pushw(cs);                            /* push cs */
    II(0x00134ab2, 0x3)   callw(0x0012dad6, -0x6fdf);           /* call 0x12dad6 */
    II(0x00134ab5, 0x3)   add(sp, 0x4);                         /* add sp, 0x4 */
    II(0x00134ab8, 0x3)   mov(ax, 0x1);                         /* mov ax, 0x1 */
    II(0x00134abb, 0x1)   popw(ds);                             /* pop ds */
    II(0x00134abc, 0x1)   popw(si);                             /* pop si */
    II(0x00134abd, 0x1)   leavew();                             /* leave  */
    II(0x00134abe, 0x1)   retfw();                              /* retf  */
FUNC_END

