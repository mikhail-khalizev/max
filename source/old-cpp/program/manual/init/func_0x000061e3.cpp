FUNC_BEGIN(0x000061e3, 0xd1b537c9d129012b, 0x10, ({0x66, 0x60, 0xe8, 0xe3, 0xfe, 0x33, 0xc9, 0x86, 0xe, 0, 0xe, 0xe3, 0x49, 0xf6, 0x6, 0x47, 0, 0x80, 0x74, 0x1a, 0xc4, 0x1e, 0xa0, 0, 0x26, 0x66, 0x8b, 0x47, 0x14, 0x66, 0xa3, 0xac, 0, 0xb8, 0xde, 0xbf, 0xbb, 0xa, 0, 0xe8, 0xd7, 0xe2, 0xb, 0xc0, 0x7d, 0x28, 0xc7, 0x6, 0xca, 0xe, 0, 0x10, 0xfb, 0x68, 0xff, 0xf7, 0x66, 0xff, 0x36, 0x9c, 0, 0x66, 0xf, 0xb7, 0x6, 0xca, 0xe, 0x66, 0xc1, 0xe0, 0x6, 0x66, 0x50, 0xe8, 0x51, 0xd6, 0xe, 0xe8, 0x4, 0xff, 0x83, 0xc4, 0xa, 0xe8, 0xe3, 0xdc, 0x66, 0x61, 0xc3}))
    II(0x000061e3, 0x2)   pushad();                             /* pushad  */
    II(0x000061e5, 0x3)   callw(0x000060cb, -0x11d);            /* call 0x60cb */
    II(0x000061e8, 0x2)   xor_(cx, cx);                         /* xor cx, cx */
    II(0x000061ea, 0x4)   xchg(memb_a16(ds, 0xe00), cl);        /* xchg [0xe00], cl */
    II(0x000061ee, 0x2)   jcxzw(0x00006239, 0x49);              /* jcxz 0x6239 */
    II(0x000061f0, 0x5)   test(memb_a16(ds, 0x47), 0x80);       /* test byte [0x47], 0x80 */
    II(0x000061f5, 0x2)   jzw(0x00006211, 0x1a);                /* jz 0x6211 */
    II(0x000061f7, 0x4)   les(bx, ds, 0xa0);                    /* les bx, [0xa0] */
    II(0x000061fb, 0x5)   mov(eax, memd_a16(es, bx + 0x14));    /* mov eax, [es:bx+0x14] */
    II(0x00006200, 0x4)   mov(memd_a16(ds, 0xac), eax);         /* mov [0xac], eax */
    II(0x00006204, 0x3)   mov(ax, 0xbfde);                      /* mov ax, 0xbfde */
    II(0x00006207, 0x3)   mov(bx, 0xa);                         /* mov bx, 0xa */
    II(0x0000620a, 0x3)   callw(0x000044e4, -0x1d29);           /* call 0x44e4 */
    II(0x0000620d, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x0000620f, 0x2)   jgew(0x00006239, 0x28);               /* jge 0x6239 */
l_0x00006211:
    II(0x00006211, 0x6)   mov(memw_a16(ds, 0xeca), 0x1000);     /* mov word [0xeca], 0x1000 */
    II(0x00006217, 0x1)   sti();                                /* sti  */
    II(0x00006218, 0x3)   pushw(0xf7ff);                        /* push word 0xf7ff */
    II(0x0000621b, 0x5)   pushd(memd_a16(ds, 0x9c));            /* push dword [0x9c] */
    II(0x00006220, 0x6)   movzx(eax, memw_a16(ds, 0xeca));      /* movzx eax, word [0xeca] */
    II(0x00006226, 0x4)   shl(eax, 0x6);                        /* shl eax, 0x6 */
    II(0x0000622a, 0x2)   pushd(eax);                           /* push eax */
    II(0x0000622c, 0x3)   callw(0x00003880, -0x29af);           /* call 0x3880 */
    II(0x0000622f, 0x1)   pushw(cs);                            /* push cs */
    II(0x00006230, 0x3)   callw(0x00006137, -0xfc);             /* call 0x6137 */
    II(0x00006233, 0x3)   add(sp, 0xa);                         /* add sp, 0xa */
    II(0x00006236, 0x3)   callw(0x00003f1c, -0x231d);           /* call 0x3f1c */
l_0x00006239:
    II(0x00006239, 0x2)   popad();                              /* popad  */
    II(0x0000623b, 0x1)   retw();                               /* ret  */
FUNC_END

