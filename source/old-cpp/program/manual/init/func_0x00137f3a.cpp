FUNC_BEGIN(0x00137f3a, 0xd204c0d5397c7d3c, 0x10, ({0xc8, 0x2, 0, 0, 0x56, 0x1e, 0xb8, 0x68, 0x3e, 0x8e, 0xd8, 0xc7, 0x46, 0xfe, 0, 0, 0xeb, 0x3, 0xff, 0x46, 0xfe, 0xa1, 0x9e, 0x51, 0x39, 0x46, 0xfe, 0x73, 0x2f, 0x8b, 0x46, 0x6, 0x8b, 0x56, 0x8, 0x8b, 0x5e, 0xfe, 0xc1, 0xe3, 0x2, 0xc4, 0x36, 0xa0, 0x4f, 0x26, 0x39, 0, 0x75, 0x18, 0x26, 0x39, 0x50, 0x2, 0x75, 0x12, 0xc4, 0x36, 0xa4, 0x4f, 0x2b, 0xc0, 0x26, 0x89, 0x40, 0x2, 0x26, 0x89, 0, 0x1f, 0x5e, 0xc9, 0xcb, 0x90, 0xeb, 0xc6, 0x1f, 0x5e, 0xc9, 0xcb}))
    II(0x00137f3a, 0x4)   enterw(0x2, 0);                       /* enter 0x2, 0x0 */
    II(0x00137f3e, 0x1)   pushw(si);                            /* push si */
    II(0x00137f3f, 0x1)   pushw(ds);                            /* push ds */
    II(0x00137f40, 0x3)   mov(ax, 0x3e68);                      /* mov ax, 0x3e68 */
    II(0x00137f43, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x00137f45, 0x5)   mov(memw_a16(ss, bp - 0x2), 0);       /* mov word [bp-0x2], 0x0 */
    II(0x00137f4a, 0x2)   jmpw(0x00137f4f, 0x3);                /* jmp 0x137f4f */
l_0x00137f4c:
    II(0x00137f4c, 0x3)   inc(memw_a16(ss, bp - 0x2));          /* inc word [bp-0x2] */
l_0x00137f4f:
    II(0x00137f4f, 0x3)   mov(ax, memw_a16(ds, 0x519e));        /* mov ax, [0x519e] */
    II(0x00137f52, 0x3)   cmp(memw_a16(ss, bp - 0x2), ax);      /* cmp [bp-0x2], ax */
    II(0x00137f55, 0x2)   jaew(0x00137f86, 0x2f);               /* jae 0x137f86 */
    II(0x00137f57, 0x3)   mov(ax, memw_a16(ss, bp + 0x6));      /* mov ax, [bp+0x6] */
    II(0x00137f5a, 0x3)   mov(dx, memw_a16(ss, bp + 0x8));      /* mov dx, [bp+0x8] */
    II(0x00137f5d, 0x3)   mov(bx, memw_a16(ss, bp - 0x2));      /* mov bx, [bp-0x2] */
    II(0x00137f60, 0x3)   shl(bx, 0x2);                         /* shl bx, 0x2 */
    II(0x00137f63, 0x4)   les(si, ds, 0x4fa0);                  /* les si, [0x4fa0] */
    II(0x00137f67, 0x3)   cmp(memw_a16(es, bx + si), ax);       /* cmp [es:bx+si], ax */
    II(0x00137f6a, 0x2)   jnzw(0x00137f84, 0x18);               /* jnz 0x137f84 */
    II(0x00137f6c, 0x4)   cmp(memw_a16(es, bx + si + 0x2), dx); /* cmp [es:bx+si+0x2], dx */
    II(0x00137f70, 0x2)   jnzw(0x00137f84, 0x12);               /* jnz 0x137f84 */
    II(0x00137f72, 0x4)   les(si, ds, 0x4fa4);                  /* les si, [0x4fa4] */
    II(0x00137f76, 0x2)   sub(ax, ax);                          /* sub ax, ax */
    II(0x00137f78, 0x4)   mov(memw_a16(es, bx + si + 0x2), ax); /* mov [es:bx+si+0x2], ax */
    II(0x00137f7c, 0x3)   mov(memw_a16(es, bx + si), ax);       /* mov [es:bx+si], ax */
    II(0x00137f7f, 0x1)   popw(ds);                             /* pop ds */
    II(0x00137f80, 0x1)   popw(si);                             /* pop si */
    II(0x00137f81, 0x1)   leavew();                             /* leave  */
    II(0x00137f82, 0x1)   retfw();                              /* retf  */
//    II(0x00137f83, 0x1)   /* Недостижимый код. */
l_0x00137f84:
    II(0x00137f84, 0x2)   jmpw(0x00137f4c, -0x3a);              /* jmp 0x137f4c */
l_0x00137f86:
    II(0x00137f86, 0x1)   popw(ds);                             /* pop ds */
    II(0x00137f87, 0x1)   popw(si);                             /* pop si */
    II(0x00137f88, 0x1)   leavew();                             /* leave  */
    II(0x00137f89, 0x1)   retfw();                              /* retf  */
FUNC_END

