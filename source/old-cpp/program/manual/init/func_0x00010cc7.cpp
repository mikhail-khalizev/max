FUNC_BEGIN(0x00010cc7, 0x2229339e8947bace, 0x10, ({0xc8, 0x10, 0, 0, 0x56, 0xc7, 0x46, 0xfc, 0, 0, 0xc4, 0x5e, 0x4, 0x26, 0xc7, 0x47, 0x16, 0x1, 0, 0x26, 0x8b, 0x47, 0x6, 0xa3, 0x38, 0, 0x89, 0x46, 0xfe, 0x8d, 0x46, 0xf0, 0x50, 0xff, 0x76, 0xfe, 0xe8, 0x70, 0xf, 0x5b, 0x5b, 0xf6, 0x46, 0xf8, 0x10, 0x74, 0x1b, 0x8b, 0x46, 0xfe, 0xc4, 0x5e, 0x4, 0x26, 0x39, 0x47, 0x2, 0x74, 0xf, 0x8b, 0xd8, 0xc1, 0xeb, 0x3, 0xc4, 0x36, 0xa0, 0xa, 0x26, 0xf6, 0, 0x1, 0x75, 0x3, 0xe9, 0xe2, 0, 0x83, 0x7e, 0xf2, 0x10, 0x77, 0x2, 0x72, 0x61, 0xff, 0x76, 0xf4, 0xe8, 0xa5, 0xd, 0x5b, 0x6a, 0, 0x50, 0xff, 0x76, 0xf2, 0xff, 0x76, 0xf0, 0xe8, 0x5d, 0xe, 0x5b, 0x5b, 0x52, 0x50, 0xe8, 0xaa, 0xf2, 0x83, 0xc4, 0x8, 0x8b, 0x5e, 0xfe, 0xc1, 0xeb, 0x3, 0xc4, 0x36, 0xa0, 0xa, 0x26, 0x8a, 0, 0x98, 0x89, 0x46, 0xfa, 0xff, 0x76, 0xfe, 0xe8, 0x81, 0xf, 0x5b, 0xf6, 0x46, 0xfa, 0x10, 0x74, 0x19, 0xf6, 0x6, 0x15, 0, 0x4, 0x75, 0x12, 0xff, 0x76, 0xf4, 0xff, 0x76, 0xf2, 0xff, 0x76, 0xf0, 0xff, 0x76, 0xfe, 0xe8, 0x7c, 0x8, 0x83, 0xc4, 0x8, 0xf6, 0x46, 0xfa, 0x2, 0x74, 0x55, 0x83, 0x46, 0xfe, 0x8, 0xe9, 0x67, 0xff, 0xff, 0x76, 0xf2, 0xff, 0x76, 0xf0, 0xe8, 0x6, 0xe, 0x5b, 0x5b, 0x8b, 0x1e, 0x96, 0x9, 0x89, 0x47, 0x6, 0x8b, 0x46, 0xfc, 0x8b, 0x1e, 0x96, 0x9, 0x39, 0x47, 0x6, 0x74, 0x1c, 0xff, 0x76, 0x4, 0xe8, 0xde, 0xe2, 0x5b, 0xb, 0xc0, 0x74, 0x11, 0x8b, 0x1e, 0x96, 0x9, 0x8b, 0x47, 0x16, 0xc4, 0x5e, 0x4, 0x26, 0x89, 0x47, 0x16, 0x5e, 0xc9, 0xc3, 0xff, 0x76, 0xf4, 0xe8, 0xa, 0xd, 0x5b, 0x8b, 0x1e, 0x96, 0x9, 0x3, 0x47, 0x6, 0x89, 0x46, 0xfc, 0xe9, 0x6e, 0xff, 0xc4, 0x5e, 0x4, 0x26, 0x80, 0x67, 0x26, 0xfe, 0x26, 0x8b, 0x47, 0x6, 0x26, 0x89, 0x47, 0x16, 0x26, 0xc7, 0x47, 0x6, 0, 0, 0xa1, 0x38, 0, 0x26, 0x39, 0x47, 0x4, 0x75, 0x6, 0x26, 0xc7, 0x47, 0x4, 0, 0, 0x6a, 0x1, 0xe8, 0x84, 0xd7, 0x5b, 0x5e, 0xc9, 0xc3}))
    II(0x00010cc7, 0x4)   enterw(0x10, 0);                      /* enter 0x10, 0x0 */
    II(0x00010ccb, 0x1)   pushw(si);                            /* push si */
    II(0x00010ccc, 0x5)   mov(memw_a16(ss, bp - 0x4), 0);       /* mov word [bp-0x4], 0x0 */
    II(0x00010cd1, 0x3)   les(bx, ss, bp + 0x4);                /* les bx, [bp+0x4] */
    II(0x00010cd4, 0x6)   mov(memw_a16(es, bx + 0x16), 0x1);    /* mov word [es:bx+0x16], 0x1 */
    II(0x00010cda, 0x4)   mov(ax, memw_a16(es, bx + 0x6));      /* mov ax, [es:bx+0x6] */
    II(0x00010cde, 0x3)   mov(memw_a16(ds, 0x38), ax);          /* mov [0x38], ax */
    II(0x00010ce1, 0x3)   mov(memw_a16(ss, bp - 0x2), ax);      /* mov [bp-0x2], ax */
l_0x00010ce4:
    II(0x00010ce4, 0x3)   lea(ax, bp - 0x10);                   /* lea ax, [bp-0x10] */
    II(0x00010ce7, 0x1)   pushw(ax);                            /* push ax */
    II(0x00010ce8, 0x3)   pushw(memw_a16(ss, bp - 0x2));        /* push word [bp-0x2] */
    II(0x00010ceb, 0x3)   callw(0x00011c5e, 0xf70);             /* call 0x11c5e */
    II(0x00010cee, 0x1)   popw(bx);                             /* pop bx */
    II(0x00010cef, 0x1)   popw(bx);                             /* pop bx */
    II(0x00010cf0, 0x4)   test(memb_a16(ss, bp - 0x8), 0x10);   /* test byte [bp-0x8], 0x10 */
    II(0x00010cf4, 0x2)   jzw(0x00010d11, 0x1b);                /* jz 0x10d11 */
    II(0x00010cf6, 0x3)   mov(ax, memw_a16(ss, bp - 0x2));      /* mov ax, [bp-0x2] */
    II(0x00010cf9, 0x3)   les(bx, ss, bp + 0x4);                /* les bx, [bp+0x4] */
    II(0x00010cfc, 0x4)   cmp(memw_a16(es, bx + 0x2), ax);      /* cmp [es:bx+0x2], ax */
    II(0x00010d00, 0x2)   jzw(0x00010d11, 0xf);                 /* jz 0x10d11 */
    II(0x00010d02, 0x2)   mov(bx, ax);                          /* mov bx, ax */
    II(0x00010d04, 0x3)   shr(bx, 0x3);                         /* shr bx, 0x3 */
    II(0x00010d07, 0x4)   les(si, ds, 0xaa0);                   /* les si, [0xaa0] */
    II(0x00010d0b, 0x4)   test(memb_a16(es, bx + si), 0x1);     /* test byte [es:bx+si], 0x1 */
    II(0x00010d0f, 0x2)   jnzw(0x00010d14, 0x3);                /* jnz 0x10d14 */
l_0x00010d11:
    II(0x00010d11, 0x3)   jmpw(0x00010df6, 0xe2);               /* jmp 0x10df6 */
l_0x00010d14:
    II(0x00010d14, 0x4)   cmp(memw_a16(ss, bp - 0xe), 0x10);    /* cmp word [bp-0xe], 0x10 */
    II(0x00010d18, 0x2)   jaw(0x00010d1c, 0x2);                 /* ja 0x10d1c */
    II(0x00010d1a, 0x2)   jbw(0x00010d7d, 0x61);                /* jb 0x10d7d */
l_0x00010d1c:
    II(0x00010d1c, 0x3)   pushw(memw_a16(ss, bp - 0xc));        /* push word [bp-0xc] */
    II(0x00010d1f, 0x3)   callw(0x00011ac7, 0xda5);             /* call 0x11ac7 */
    II(0x00010d22, 0x1)   popw(bx);                             /* pop bx */
    II(0x00010d23, 0x2)   pushw(0);                             /* push 0x0 */
    II(0x00010d25, 0x1)   pushw(ax);                            /* push ax */
    II(0x00010d26, 0x3)   pushw(memw_a16(ss, bp - 0xe));        /* push word [bp-0xe] */
    II(0x00010d29, 0x3)   pushw(memw_a16(ss, bp - 0x10));       /* push word [bp-0x10] */
    II(0x00010d2c, 0x3)   callw(0x00011b8c, 0xe5d);             /* call 0x11b8c */
    II(0x00010d2f, 0x1)   popw(bx);                             /* pop bx */
    II(0x00010d30, 0x1)   popw(bx);                             /* pop bx */
    II(0x00010d31, 0x1)   pushw(dx);                            /* push dx */
    II(0x00010d32, 0x1)   pushw(ax);                            /* push ax */
    II(0x00010d33, 0x3)   callw(0x0000ffe0, -0xd56);            /* call 0xffe0 */
    II(0x00010d36, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
l_0x00010d39:
    II(0x00010d39, 0x3)   mov(bx, memw_a16(ss, bp - 0x2));      /* mov bx, [bp-0x2] */
    II(0x00010d3c, 0x3)   shr(bx, 0x3);                         /* shr bx, 0x3 */
    II(0x00010d3f, 0x4)   les(si, ds, 0xaa0);                   /* les si, [0xaa0] */
    II(0x00010d43, 0x3)   mov(al, memb_a16(es, bx + si));       /* mov al, [es:bx+si] */
    II(0x00010d46, 0x1)   cbw();                                /* cbw  */
    II(0x00010d47, 0x3)   mov(memw_a16(ss, bp - 0x6), ax);      /* mov [bp-0x6], ax */
    II(0x00010d4a, 0x3)   pushw(memw_a16(ss, bp - 0x2));        /* push word [bp-0x2] */
    II(0x00010d4d, 0x3)   callw(0x00011cd1, 0xf81);             /* call 0x11cd1 */
    II(0x00010d50, 0x1)   popw(bx);                             /* pop bx */
    II(0x00010d51, 0x4)   test(memb_a16(ss, bp - 0x6), 0x10);   /* test byte [bp-0x6], 0x10 */
    II(0x00010d55, 0x2)   jzw(0x00010d70, 0x19);                /* jz 0x10d70 */
    II(0x00010d57, 0x5)   test(memb_a16(ds, 0x15), 0x4);        /* test byte [0x15], 0x4 */
    II(0x00010d5c, 0x2)   jnzw(0x00010d70, 0x12);               /* jnz 0x10d70 */
    II(0x00010d5e, 0x3)   pushw(memw_a16(ss, bp - 0xc));        /* push word [bp-0xc] */
    II(0x00010d61, 0x3)   pushw(memw_a16(ss, bp - 0xe));        /* push word [bp-0xe] */
    II(0x00010d64, 0x3)   pushw(memw_a16(ss, bp - 0x10));       /* push word [bp-0x10] */
    II(0x00010d67, 0x3)   pushw(memw_a16(ss, bp - 0x2));        /* push word [bp-0x2] */
    II(0x00010d6a, 0x3)   callw(0x000115e9, 0x87c);             /* call 0x115e9 */
    II(0x00010d6d, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
l_0x00010d70:
    II(0x00010d70, 0x4)   test(memb_a16(ss, bp - 0x6), 0x2);    /* test byte [bp-0x6], 0x2 */
    II(0x00010d74, 0x2)   jzw(0x00010dcb, 0x55);                /* jz 0x10dcb */
    II(0x00010d76, 0x4)   add(memw_a16(ss, bp - 0x2), 0x8);     /* add word [bp-0x2], 0x8 */
    II(0x00010d7a, 0x3)   jmpw(0x00010ce4, -0x99);              /* jmp 0x10ce4 */
l_0x00010d7d:
    II(0x00010d7d, 0x3)   pushw(memw_a16(ss, bp - 0xe));        /* push word [bp-0xe] */
    II(0x00010d80, 0x3)   pushw(memw_a16(ss, bp - 0x10));       /* push word [bp-0x10] */
    II(0x00010d83, 0x3)   callw(0x00011b8c, 0xe06);             /* call 0x11b8c */
    II(0x00010d86, 0x1)   popw(bx);                             /* pop bx */
    II(0x00010d87, 0x1)   popw(bx);                             /* pop bx */
    II(0x00010d88, 0x4)   mov(bx, memw_a16(ds, 0x996));         /* mov bx, [0x996] */
    II(0x00010d8c, 0x3)   mov(memw_a16(ds, bx + 0x6), ax);      /* mov [bx+0x6], ax */
    II(0x00010d8f, 0x3)   mov(ax, memw_a16(ss, bp - 0x4));      /* mov ax, [bp-0x4] */
    II(0x00010d92, 0x4)   mov(bx, memw_a16(ds, 0x996));         /* mov bx, [0x996] */
    II(0x00010d96, 0x3)   cmp(memw_a16(ds, bx + 0x6), ax);      /* cmp [bx+0x6], ax */
    II(0x00010d99, 0x2)   jzw(0x00010db7, 0x1c);                /* jz 0x10db7 */
    II(0x00010d9b, 0x3)   pushw(memw_a16(ss, bp + 0x4));        /* push word [bp+0x4] */
    II(0x00010d9e, 0x3)   callw(0x0000f07f, -0x1d22);           /* call 0xf07f */
    II(0x00010da1, 0x1)   popw(bx);                             /* pop bx */
    II(0x00010da2, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x00010da4, 0x2)   jzw(0x00010db7, 0x11);                /* jz 0x10db7 */
    II(0x00010da6, 0x4)   mov(bx, memw_a16(ds, 0x996));         /* mov bx, [0x996] */
    II(0x00010daa, 0x3)   mov(ax, memw_a16(ds, bx + 0x16));     /* mov ax, [bx+0x16] */
    II(0x00010dad, 0x3)   les(bx, ss, bp + 0x4);                /* les bx, [bp+0x4] */
    II(0x00010db0, 0x4)   mov(memw_a16(es, bx + 0x16), ax);     /* mov [es:bx+0x16], ax */
    II(0x00010db4, 0x1)   popw(si);                             /* pop si */
    II(0x00010db5, 0x1)   leavew();                             /* leave  */
    II(0x00010db6, 0x1)   retw();                               /* ret  */
l_0x00010db7:
    II(0x00010db7, 0x3)   pushw(memw_a16(ss, bp - 0xc));        /* push word [bp-0xc] */
    II(0x00010dba, 0x3)   callw(0x00011ac7, 0xd0a);             /* call 0x11ac7 */
    II(0x00010dbd, 0x1)   popw(bx);                             /* pop bx */
    II(0x00010dbe, 0x4)   mov(bx, memw_a16(ds, 0x996));         /* mov bx, [0x996] */
    II(0x00010dc2, 0x3)   add(ax, memw_a16(ds, bx + 0x6));      /* add ax, [bx+0x6] */
    II(0x00010dc5, 0x3)   mov(memw_a16(ss, bp - 0x4), ax);      /* mov [bp-0x4], ax */
    II(0x00010dc8, 0x3)   jmpw(0x00010d39, -0x92);              /* jmp 0x10d39 */
l_0x00010dcb:
    II(0x00010dcb, 0x3)   les(bx, ss, bp + 0x4);                /* les bx, [bp+0x4] */
    II(0x00010dce, 0x5)   and_(memb_a16(es, bx + 0x26), -0x2 /* 0xfe */); /* and byte [es:bx+0x26], 0xfe */
    II(0x00010dd3, 0x4)   mov(ax, memw_a16(es, bx + 0x6));      /* mov ax, [es:bx+0x6] */
    II(0x00010dd7, 0x4)   mov(memw_a16(es, bx + 0x16), ax);     /* mov [es:bx+0x16], ax */
    II(0x00010ddb, 0x6)   mov(memw_a16(es, bx + 0x6), 0);       /* mov word [es:bx+0x6], 0x0 */
    II(0x00010de1, 0x3)   mov(ax, memw_a16(ds, 0x38));          /* mov ax, [0x38] */
    II(0x00010de4, 0x4)   cmp(memw_a16(es, bx + 0x4), ax);      /* cmp [es:bx+0x4], ax */
    II(0x00010de8, 0x2)   jnzw(0x00010df0, 0x6);                /* jnz 0x10df0 */
    II(0x00010dea, 0x6)   mov(memw_a16(es, bx + 0x4), 0);       /* mov word [es:bx+0x4], 0x0 */
l_0x00010df0:
    II(0x00010df0, 0x2)   pushw(0x1);                           /* push 0x1 */
    II(0x00010df2, 0x3)   callw(0x0000e579, -0x287c);           /* call 0xe579 */
    II(0x00010df5, 0x1)   popw(bx);                             /* pop bx */
l_0x00010df6:
    II(0x00010df6, 0x1)   popw(si);                             /* pop si */
    II(0x00010df7, 0x1)   leavew();                             /* leave  */
    II(0x00010df8, 0x1)   retw();                               /* ret  */
FUNC_END

