FUNC_BEGIN(0x00011c5e, 0xf09aa8747d919dd9, 0x10, ({0x8b, 0xdc, 0x56, 0x36, 0x8b, 0x77, 0x2, 0x3b, 0x36, 0x7c, 0x9, 0x73, 0xef, 0x1e, 0x55, 0x36, 0x8b, 0x6f, 0x4, 0x80, 0x3e, 0x2e, 0, 0, 0x74, 0x28, 0x6a, 0x8, 0x1f, 0x83, 0xe6, 0xf8, 0xad, 0x89, 0x46, 0x4, 0xad, 0x89, 0x46, 0, 0xad, 0x88, 0x46, 0x2, 0x88, 0x66, 0x8, 0xad, 0x24, 0xf0, 0x88, 0x46, 0x9, 0x88, 0x66, 0x3, 0xc7, 0x46, 0x6, 0, 0, 0x40, 0x5d, 0x1f, 0x5e, 0xc3, 0x1e, 0x7, 0x66, 0x57, 0x66, 0x33, 0xff, 0xbf, 0xc0, 0x8, 0x8b, 0xf7, 0x36, 0x8b, 0x5f, 0x2, 0xb8, 0xb, 0, 0xe, 0xe8, 0xd2, 0xc6, 0x66, 0x5f, 0x73, 0xc3, 0x33, 0xc0, 0xeb, 0xdd}))
    II(0x00011c5e, 0x2)   mov(bx, sp);                          /* mov bx, sp */
    II(0x00011c60, 0x1)   pushw(si);                            /* push si */
    II(0x00011c61, 0x4)   mov(si, memw_a16(ss, bx + 0x2));      /* mov si, [ss:bx+0x2] */
    II(0x00011c65, 0x4)   cmp(si, memw_a16(ds, 0x97c));         /* cmp si, [0x97c] */
    II(0x00011c69, 0x2)   jaew_func(0x00011c5a, -0x11);         /* jae 0x11c5a */
    II(0x00011c6b, 0x1)   pushw(ds);                            /* push ds */
    II(0x00011c6c, 0x1)   pushw(bp);                            /* push bp */
    II(0x00011c6d, 0x4)   mov(bp, memw_a16(ss, bx + 0x4));      /* mov bp, [ss:bx+0x4] */
    II(0x00011c71, 0x5)   cmp(memb_a16(ds, 0x2e), 0);           /* cmp byte [0x2e], 0x0 */
    II(0x00011c76, 0x2)   jzw(0x00011ca0, 0x28);                /* jz 0x11ca0 */
    II(0x00011c78, 0x2)   pushw(0x8);                           /* push 0x8 */
    II(0x00011c7a, 0x1)   popw(ds);                             /* pop ds */
    II(0x00011c7b, 0x3)   and_(si, -0x8 /* 0xf8 */);            /* and si, 0xf8 */
l_0x00011c7e:
    II(0x00011c7e, 0x1)   lodsw_a16();                          /* lodsw  */
    II(0x00011c7f, 0x3)   mov(memw_a16(ss, bp + 0x4), ax);      /* mov [bp+0x4], ax */
    II(0x00011c82, 0x1)   lodsw_a16();                          /* lodsw  */
    II(0x00011c83, 0x3)   mov(memw_a16(ss, bp + 0), ax);        /* mov [bp+0x0], ax */
    II(0x00011c86, 0x1)   lodsw_a16();                          /* lodsw  */
    II(0x00011c87, 0x3)   mov(memb_a16(ss, bp + 0x2), al);      /* mov [bp+0x2], al */
    II(0x00011c8a, 0x3)   mov(memb_a16(ss, bp + 0x8), ah);      /* mov [bp+0x8], ah */
    II(0x00011c8d, 0x1)   lodsw_a16();                          /* lodsw  */
    II(0x00011c8e, 0x2)   and_(al, 0xf0);                       /* and al, 0xf0 */
    II(0x00011c90, 0x3)   mov(memb_a16(ss, bp + 0x9), al);      /* mov [bp+0x9], al */
    II(0x00011c93, 0x3)   mov(memb_a16(ss, bp + 0x3), ah);      /* mov [bp+0x3], ah */
    II(0x00011c96, 0x5)   mov(memw_a16(ss, bp + 0x6), 0);       /* mov word [bp+0x6], 0x0 */
    II(0x00011c9b, 0x1)   inc(ax);                              /* inc ax */
l_0x00011c9c:
    II(0x00011c9c, 0x1)   popw(bp);                             /* pop bp */
    II(0x00011c9d, 0x1)   popw(ds);                             /* pop ds */
    II(0x00011c9e, 0x1)   popw(si);                             /* pop si */
    II(0x00011c9f, 0x1)   retw();                               /* ret  */
l_0x00011ca0:
    II(0x00011ca0, 0x1)   pushw(ds);                            /* push ds */
    II(0x00011ca1, 0x1)   popw(es);                             /* pop es */
    II(0x00011ca2, 0x2)   pushd(edi);                           /* push edi */
    II(0x00011ca4, 0x3)   xor_(edi, edi);                       /* xor edi, edi */
    II(0x00011ca7, 0x3)   mov(di, 0x8c0);                       /* mov di, 0x8c0 */
    II(0x00011caa, 0x2)   mov(si, di);                          /* mov si, di */
    II(0x00011cac, 0x4)   mov(bx, memw_a16(ss, bx + 0x2));      /* mov bx, [ss:bx+0x2] */
    II(0x00011cb0, 0x3)   mov(ax, 0xb);                         /* mov ax, 0xb */
    II(0x00011cb3, 0x1)   pushw(cs);                            /* push cs */
    II(0x00011cb4, 0x3)   callw(0x0000e389, -0x392e);           /* call 0xe389 */
    II(0x00011cb7, 0x2)   popd(edi);                            /* pop edi */
    II(0x00011cb9, 0x2)   jaew(0x00011c7e, -0x3d);              /* jae 0x11c7e */
    II(0x00011cbb, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x00011cbd, 0x2)   jmpw(0x00011c9c, -0x23);              /* jmp 0x11c9c */
FUNC_END

