FUNC_BEGIN(0x0000665b, 0xdf7c5d5cddbb4991, 0x10, ({0x8e, 0xd3, 0x2e, 0x8e, 0x1e, 0, 0, 0x8e, 0x2e, 0x66, 0xd, 0x8e, 0x26, 0x64, 0xd, 0xf, 0x1, 0x1e, 0xdc, 0xd, 0x66, 0x58, 0x81, 0x3e, 0x35, 0, 0, 0x80, 0x75, 0x25, 0x80, 0x3e, 0xf0, 0x11, 0, 0x75, 0x28, 0x33, 0xc0, 0x8e, 0xc0, 0xa1, 0x56, 0xf, 0x26, 0xa3, 0x67, 0x4, 0xa1, 0x58, 0xf, 0x26, 0xa3, 0x69, 0x4, 0x8e, 0xc3, 0x80, 0x3e, 0x2e, 0, 0x2, 0x74, 0x6, 0xe8, 0xfd, 0xe2, 0x5b, 0x58, 0xc3, 0x32, 0xe4, 0xe8, 0xbd, 0xe2, 0xeb, 0xf6, 0x80, 0x3e, 0x2e, 0, 0x5, 0x74, 0x18, 0x80, 0x3e, 0x2e, 0, 0xe, 0x74, 0x19, 0x80, 0x3e, 0x2e, 0, 0xf, 0x74, 0x2d, 0x80, 0x3e, 0x2e, 0, 0x1, 0x74, 0x33, 0x5b, 0x58, 0xc3, 0x8e, 0xc3, 0xb0, 0x80, 0xe6, 0x20, 0xeb, 0xcf, 0xb0, 0xff, 0xe6, 0xf2, 0x9c, 0xfa, 0x52, 0xba, 0x40, 0x1, 0xb0, 0x1, 0xee, 0xfe, 0xc8, 0xee, 0x5a, 0x9d, 0x51, 0xb9, 0xa0, 0xf, 0xe2, 0xfe, 0x59, 0xeb, 0xb4, 0x52, 0xba, 0x4, 0x4, 0xec, 0x24, 0xf9, 0xeb, 0, 0xee, 0x5a, 0xeb, 0xa7, 0xb0, 0x3, 0xe6, 0xf6, 0xeb, 0xa1}))
    II(0x0000665b, 0x2)   mov(ss, bx);                          /* mov ss, bx */
    II(0x0000665d, 0x5)   mov(ds, memw_a16(cs, 0));             /* mov ds, [cs:0x0] */
    II(0x00006662, 0x4)   mov(gs, memw_a16(ds, 0xd66));         /* mov gs, [0xd66] */
    II(0x00006666, 0x4)   mov(fs, memw_a16(ds, 0xd64));         /* mov fs, [0xd64] */
    II(0x0000666a, 0x5)   lidtw_a16(ds, 0xddc);                 /* lidt [0xddc] */
    II(0x0000666f, 0x2)   popd(eax);                            /* pop eax */
    II(0x00006671, 0x6)   cmp(memw_a16(ds, 0x35), 0x8000);      /* cmp word [0x35], 0x8000 */
    II(0x00006677, 0x2)   jnzw(0x0000669e, 0x25);               /* jnz 0x669e */
    II(0x00006679, 0x5)   cmp(memb_a16(ds, 0x11f0), 0);         /* cmp byte [0x11f0], 0x0 */
    II(0x0000667e, 0x2)   jnzw(0x000066a8, 0x28);               /* jnz 0x66a8 */
    II(0x00006680, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x00006682, 0x2)   mov(es, ax);                          /* mov es, ax */
    II(0x00006684, 0x3)   mov(ax, memw_a16(ds, 0xf56));         /* mov ax, [0xf56] */
    II(0x00006687, 0x4)   mov(memw_a16(es, 0x467), ax);         /* mov [es:0x467], ax */
    II(0x0000668b, 0x3)   mov(ax, memw_a16(ds, 0xf58));         /* mov ax, [0xf58] */
    II(0x0000668e, 0x4)   mov(memw_a16(es, 0x469), ax);         /* mov [es:0x469], ax */
    II(0x00006692, 0x2)   mov(es, bx);                          /* mov es, bx */
    II(0x00006694, 0x5)   cmp(memb_a16(ds, 0x2e), 0x2);         /* cmp byte [0x2e], 0x2 */
    II(0x00006699, 0x2)   jzw(0x000066a1, 0x6);                 /* jz 0x66a1 */
    II(0x0000669b, 0x3)   callw(0x0000499b, -0x1d03);           /* call 0x499b */
l_0x0000669e:
    II(0x0000669e, 0x1)   popw(bx);                             /* pop bx */
    II(0x0000669f, 0x1)   popw(ax);                             /* pop ax */
    II(0x000066a0, 0x1)   retw();                               /* ret  */
l_0x000066a1:
    II(0x000066a1, 0x2)   xor_(ah, ah);                         /* xor ah, ah */
    II(0x000066a3, 0x3)   callw(0x00004963, -0x1d43);           /* call 0x4963 */
    II(0x000066a6, 0x2)   jmpw(0x0000669e, -0xa);               /* jmp 0x669e */
l_0x000066a8:
    II(0x000066a8, 0x5)   cmp(memb_a16(ds, 0x2e), 0x5);         /* cmp byte [0x2e], 0x5 */
    II(0x000066ad, 0x2)   jzw(0x000066c7, 0x18);                /* jz 0x66c7 */
    II(0x000066af, 0x5)   cmp(memb_a16(ds, 0x2e), 0xe);         /* cmp byte [0x2e], 0xe */
    II(0x000066b4, 0x2)   jzw(0x000066cf, 0x19);                /* jz 0x66cf */
    II(0x000066b6, 0x5)   cmp(memb_a16(ds, 0x2e), 0xf);         /* cmp byte [0x2e], 0xf */
    II(0x000066bb, 0x2)   jzw(0x000066ea, 0x2d);                /* jz 0x66ea */
    II(0x000066bd, 0x5)   cmp(memb_a16(ds, 0x2e), 0x1);         /* cmp byte [0x2e], 0x1 */
    II(0x000066c2, 0x2)   jzw(0x000066f7, 0x33);                /* jz 0x66f7 */
    II(0x000066c4, 0x1)   popw(bx);                             /* pop bx */
    II(0x000066c5, 0x1)   popw(ax);                             /* pop ax */
    II(0x000066c6, 0x1)   retw();                               /* ret  */
l_0x000066c7:
    II(0x000066c7, 0x2)   mov(es, bx);                          /* mov es, bx */
    II(0x000066c9, 0x2)   mov(al, 0x80);                        /* mov al, 0x80 */
    II(0x000066cb, 0x2)   outb(0x20, al);                       /* out 0x20, al */
    II(0x000066cd, 0x2)   jmpw(0x0000669e, -0x31);              /* jmp 0x669e */
l_0x000066cf:
    II(0x000066cf, 0x2)   mov(al, 0xff);                        /* mov al, 0xff */
    II(0x000066d1, 0x2)   outb(0xf2, al);                       /* out 0xf2, al */
    II(0x000066d3, 0x1)   pushfw();                             /* pushfw  */
    II(0x000066d4, 0x1)   cli();                                /* cli  */
    II(0x000066d5, 0x1)   pushw(dx);                            /* push dx */
    II(0x000066d6, 0x3)   mov(dx, 0x140);                       /* mov dx, 0x140 */
    II(0x000066d9, 0x2)   mov(al, 0x1);                         /* mov al, 0x1 */
    II(0x000066db, 0x1)   outb(dx, al);                         /* out dx, al */
    II(0x000066dc, 0x2)   dec(al);                              /* dec al */
    II(0x000066de, 0x1)   outb(dx, al);                         /* out dx, al */
    II(0x000066df, 0x1)   popw(dx);                             /* pop dx */
    II(0x000066e0, 0x1)   popfw();                              /* popfw  */
    II(0x000066e1, 0x1)   pushw(cx);                            /* push cx */
    II(0x000066e2, 0x3)   mov(cx, 0xfa0);                       /* mov cx, 0xfa0 */
l_0x000066e5:
    II(0x000066e5, 0x2)   loopw_a16(0x000066e5, -0x2);          /* loop 0x66e5 */
    II(0x000066e7, 0x1)   popw(cx);                             /* pop cx */
    II(0x000066e8, 0x2)   jmpw(0x0000669e, -0x4c);              /* jmp 0x669e */
l_0x000066ea:
    II(0x000066ea, 0x1)   pushw(dx);                            /* push dx */
    II(0x000066eb, 0x3)   mov(dx, 0x404);                       /* mov dx, 0x404 */
    II(0x000066ee, 0x1)   inb(al, dx);                          /* in al, dx */
    II(0x000066ef, 0x2)   and_(al, 0xf9);                       /* and al, 0xf9 */
    II(0x000066f1, 0x2)   jmpw(0x000066f3, 0);                  /* jmp 0x66f3 */
l_0x000066f3:
    II(0x000066f3, 0x1)   outb(dx, al);                         /* out dx, al */
    II(0x000066f4, 0x1)   popw(dx);                             /* pop dx */
    II(0x000066f5, 0x2)   jmpw(0x0000669e, -0x59);              /* jmp 0x669e */
l_0x000066f7:
    II(0x000066f7, 0x2)   mov(al, 0x3);                         /* mov al, 0x3 */
    II(0x000066f9, 0x2)   outb(0xf6, al);                       /* out 0xf6, al */
    II(0x000066fb, 0x2)   jmpw(0x0000669e, -0x5f);              /* jmp 0x669e */
FUNC_END

