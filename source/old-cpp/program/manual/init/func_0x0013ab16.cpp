FUNC_BEGIN(0x0013ab16, 0x3f34a79543de13da, 0x10, ({0xc8, 0x14, 0, 0, 0x1e, 0xb8, 0x68, 0x3e, 0x8e, 0xd8, 0x2b, 0xc0, 0x89, 0x46, 0xfe, 0x89, 0x46, 0xfc, 0x89, 0x46, 0xf6, 0xc4, 0x5e, 0x6, 0x26, 0x80, 0x67, 0x2c, 0xfe, 0x26, 0xf7, 0x47, 0xa, 0xff, 0xff, 0x74, 0x9, 0xc7, 0x46, 0xf6, 0x23, 0x80, 0xe9, 0xd3, 0, 0x90, 0xc4, 0x5e, 0x6, 0x26, 0x8b, 0x47, 0x8, 0x89, 0x46, 0xec, 0x50, 0xe, 0xe8, 0x49, 0x1c, 0x83, 0xc4, 0x2, 0x89, 0x46, 0xf2, 0x89, 0x56, 0xf4, 0x3d, 0xff, 0xff, 0x75, 0xd, 0x3b, 0xd0, 0x75, 0x9, 0xc7, 0x46, 0xf6, 0x23, 0x80, 0xe9, 0xa9, 0, 0x90, 0x5, 0, 0, 0x83, 0xd2, 0x1, 0x8a, 0xf2, 0x8a, 0xd4, 0x8a, 0xe0, 0x2a, 0xc0, 0xd1, 0xe0, 0xd1, 0xd2, 0xd1, 0xe0, 0xd1, 0xd2, 0xd1, 0xe0, 0xd1, 0xd2, 0xd1, 0xe0, 0xd1, 0xd2, 0x89, 0x46, 0xf8, 0x89, 0x56, 0xfa, 0xff, 0x76, 0xf4, 0xff, 0x76, 0xf2, 0xff, 0x36, 0xf6, 0x4f, 0xff, 0x36, 0xf4, 0x4f, 0xe8, 0x21, 0xe5, 0x83, 0xc4, 0x8, 0x3b, 0x46, 0xec, 0x75, 0x13, 0x83, 0x46, 0xfc, 0x1, 0x83, 0x56, 0xfe, 0, 0x83, 0x46, 0xf2, 0x1, 0x83, 0x56, 0xf4, 0, 0xeb, 0xd5, 0x90, 0x8b, 0x46, 0xfa, 0xc4, 0x5e, 0x6, 0x26, 0x89, 0x47, 0x14, 0x26, 0xc7, 0x47, 0x16, 0, 0, 0x8b, 0x46, 0xf8, 0x26, 0x89, 0x47, 0x1c, 0x26, 0xc7, 0x47, 0x1e, 0, 0, 0x8b, 0x46, 0xfc, 0x8b, 0x56, 0xfe, 0x8a, 0xf2, 0x8a, 0xd4, 0x8a, 0xe0, 0x2a, 0xc0, 0xd1, 0xe0, 0xd1, 0xd2, 0xd1, 0xe0, 0xd1, 0xd2, 0xd1, 0xe0, 0xd1, 0xd2, 0xd1, 0xe0, 0xd1, 0xd2, 0x89, 0x46, 0xee, 0x89, 0x56, 0xf0, 0x26, 0x89, 0x57, 0x8, 0x26, 0xc7, 0x47, 0xa, 0, 0, 0x8b, 0x46, 0xee, 0x26, 0x89, 0x47, 0x4, 0x26, 0xc7, 0x47, 0x6, 0, 0, 0x83, 0x7e, 0xf6, 0, 0x74, 0x14, 0x8b, 0x46, 0xf6, 0x99, 0xc4, 0x5e, 0x6, 0x26, 0x89, 0x47, 0x20, 0x26, 0x89, 0x57, 0x22, 0x26, 0x80, 0x4f, 0x2c, 0x1, 0x1f, 0xc9, 0xcb}))
    II(0x0013ab16, 0x4)   enterw(0x14, 0);                      /* enter 0x14, 0x0 */
    II(0x0013ab1a, 0x1)   pushw(ds);                            /* push ds */
    II(0x0013ab1b, 0x3)   mov(ax, 0x3e68);                      /* mov ax, 0x3e68 */
    II(0x0013ab1e, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x0013ab20, 0x2)   sub(ax, ax);                          /* sub ax, ax */
    II(0x0013ab22, 0x3)   mov(memw_a16(ss, bp - 0x2), ax);      /* mov [bp-0x2], ax */
    II(0x0013ab25, 0x3)   mov(memw_a16(ss, bp - 0x4), ax);      /* mov [bp-0x4], ax */
    II(0x0013ab28, 0x3)   mov(memw_a16(ss, bp - 0xa), ax);      /* mov [bp-0xa], ax */
    II(0x0013ab2b, 0x3)   les(bx, ss, bp + 0x6);                /* les bx, [bp+0x6] */
    II(0x0013ab2e, 0x5)   and_(memb_a16(es, bx + 0x2c), -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
    II(0x0013ab33, 0x6)   test(memw_a16(es, bx + 0xa), 0xffff); /* test word [es:bx+0xa], 0xffff */
    II(0x0013ab39, 0x2)   jzw(0x0013ab44, 0x9);                 /* jz 0x13ab44 */
    II(0x0013ab3b, 0x5)   mov(memw_a16(ss, bp - 0xa), 0x8023);  /* mov word [bp-0xa], 0x8023 */
    II(0x0013ab40, 0x3)   jmpw(0x0013ac16, 0xd3);               /* jmp 0x13ac16 */
//    II(0x0013ab43, 0x1)   /* Недостижимый код. */
l_0x0013ab44:
    II(0x0013ab44, 0x3)   les(bx, ss, bp + 0x6);                /* les bx, [bp+0x6] */
    II(0x0013ab47, 0x4)   mov(ax, memw_a16(es, bx + 0x8));      /* mov ax, [es:bx+0x8] */
    II(0x0013ab4b, 0x3)   mov(memw_a16(ss, bp - 0x14), ax);     /* mov [bp-0x14], ax */
    II(0x0013ab4e, 0x1)   pushw(ax);                            /* push ax */
    II(0x0013ab4f, 0x1)   pushw(cs);                            /* push cs */
    II(0x0013ab50, 0x3)   callw(0x0013c79c, 0x1c49);            /* call 0x13c79c */
    II(0x0013ab53, 0x3)   add(sp, 0x2);                         /* add sp, 0x2 */
    II(0x0013ab56, 0x3)   mov(memw_a16(ss, bp - 0xe), ax);      /* mov [bp-0xe], ax */
    II(0x0013ab59, 0x3)   mov(memw_a16(ss, bp - 0xc), dx);      /* mov [bp-0xc], dx */
    II(0x0013ab5c, 0x3)   cmp(ax, 0xffff);                      /* cmp ax, 0xffff */
    II(0x0013ab5f, 0x2)   jnzw(0x0013ab6e, 0xd);                /* jnz 0x13ab6e */
    II(0x0013ab61, 0x2)   cmp(dx, ax);                          /* cmp dx, ax */
    II(0x0013ab63, 0x2)   jnzw(0x0013ab6e, 0x9);                /* jnz 0x13ab6e */
    II(0x0013ab65, 0x5)   mov(memw_a16(ss, bp - 0xa), 0x8023);  /* mov word [bp-0xa], 0x8023 */
    II(0x0013ab6a, 0x3)   jmpw(0x0013ac16, 0xa9);               /* jmp 0x13ac16 */
//    II(0x0013ab6d, 0x1)   /* Недостижимый код. */
l_0x0013ab6e:
    II(0x0013ab6e, 0x3)   add(ax, 0);                           /* add ax, 0x0 */
    II(0x0013ab71, 0x3)   adc(dx, 0x1);                         /* adc dx, 0x1 */
    II(0x0013ab74, 0x2)   mov(dh, dl);                          /* mov dh, dl */
    II(0x0013ab76, 0x2)   mov(dl, ah);                          /* mov dl, ah */
    II(0x0013ab78, 0x2)   mov(ah, al);                          /* mov ah, al */
    II(0x0013ab7a, 0x2)   sub(al, al);                          /* sub al, al */
    II(0x0013ab7c, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
    II(0x0013ab7e, 0x2)   rcl(dx, 0x1);                         /* rcl dx, 1 */
    II(0x0013ab80, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
    II(0x0013ab82, 0x2)   rcl(dx, 0x1);                         /* rcl dx, 1 */
    II(0x0013ab84, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
    II(0x0013ab86, 0x2)   rcl(dx, 0x1);                         /* rcl dx, 1 */
    II(0x0013ab88, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
    II(0x0013ab8a, 0x2)   rcl(dx, 0x1);                         /* rcl dx, 1 */
    II(0x0013ab8c, 0x3)   mov(memw_a16(ss, bp - 0x8), ax);      /* mov [bp-0x8], ax */
    II(0x0013ab8f, 0x3)   mov(memw_a16(ss, bp - 0x6), dx);      /* mov [bp-0x6], dx */
l_0x0013ab92:
    II(0x0013ab92, 0x3)   pushw(memw_a16(ss, bp - 0xc));        /* push word [bp-0xc] */
    II(0x0013ab95, 0x3)   pushw(memw_a16(ss, bp - 0xe));        /* push word [bp-0xe] */
    II(0x0013ab98, 0x4)   pushw(memw_a16(ds, 0x4ff6));          /* push word [0x4ff6] */
    II(0x0013ab9c, 0x4)   pushw(memw_a16(ds, 0x4ff4));          /* push word [0x4ff4] */
    II(0x0013aba0, 0x3)   callw(0x001390c4, -0x1adf);           /* call 0x1390c4 */
    II(0x0013aba3, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
    II(0x0013aba6, 0x3)   cmp(ax, memw_a16(ss, bp - 0x14));     /* cmp ax, [bp-0x14] */
    II(0x0013aba9, 0x2)   jnzw(0x0013abbe, 0x13);               /* jnz 0x13abbe */
    II(0x0013abab, 0x4)   add(memw_a16(ss, bp - 0x4), 0x1);     /* add word [bp-0x4], 0x1 */
    II(0x0013abaf, 0x4)   adc(memw_a16(ss, bp - 0x2), 0);       /* adc word [bp-0x2], 0x0 */
    II(0x0013abb3, 0x4)   add(memw_a16(ss, bp - 0xe), 0x1);     /* add word [bp-0xe], 0x1 */
    II(0x0013abb7, 0x4)   adc(memw_a16(ss, bp - 0xc), 0);       /* adc word [bp-0xc], 0x0 */
    II(0x0013abbb, 0x2)   jmpw(0x0013ab92, -0x2b);              /* jmp 0x13ab92 */
//    II(0x0013abbd, 0x1)   /* Недостижимый код. */
l_0x0013abbe:
    II(0x0013abbe, 0x3)   mov(ax, memw_a16(ss, bp - 0x6));      /* mov ax, [bp-0x6] */
    II(0x0013abc1, 0x3)   les(bx, ss, bp + 0x6);                /* les bx, [bp+0x6] */
    II(0x0013abc4, 0x4)   mov(memw_a16(es, bx + 0x14), ax);     /* mov [es:bx+0x14], ax */
    II(0x0013abc8, 0x6)   mov(memw_a16(es, bx + 0x16), 0);      /* mov word [es:bx+0x16], 0x0 */
    II(0x0013abce, 0x3)   mov(ax, memw_a16(ss, bp - 0x8));      /* mov ax, [bp-0x8] */
    II(0x0013abd1, 0x4)   mov(memw_a16(es, bx + 0x1c), ax);     /* mov [es:bx+0x1c], ax */
    II(0x0013abd5, 0x6)   mov(memw_a16(es, bx + 0x1e), 0);      /* mov word [es:bx+0x1e], 0x0 */
    II(0x0013abdb, 0x3)   mov(ax, memw_a16(ss, bp - 0x4));      /* mov ax, [bp-0x4] */
    II(0x0013abde, 0x3)   mov(dx, memw_a16(ss, bp - 0x2));      /* mov dx, [bp-0x2] */
    II(0x0013abe1, 0x2)   mov(dh, dl);                          /* mov dh, dl */
    II(0x0013abe3, 0x2)   mov(dl, ah);                          /* mov dl, ah */
    II(0x0013abe5, 0x2)   mov(ah, al);                          /* mov ah, al */
    II(0x0013abe7, 0x2)   sub(al, al);                          /* sub al, al */
    II(0x0013abe9, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
    II(0x0013abeb, 0x2)   rcl(dx, 0x1);                         /* rcl dx, 1 */
    II(0x0013abed, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
    II(0x0013abef, 0x2)   rcl(dx, 0x1);                         /* rcl dx, 1 */
    II(0x0013abf1, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
    II(0x0013abf3, 0x2)   rcl(dx, 0x1);                         /* rcl dx, 1 */
    II(0x0013abf5, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
    II(0x0013abf7, 0x2)   rcl(dx, 0x1);                         /* rcl dx, 1 */
    II(0x0013abf9, 0x3)   mov(memw_a16(ss, bp - 0x12), ax);     /* mov [bp-0x12], ax */
    II(0x0013abfc, 0x3)   mov(memw_a16(ss, bp - 0x10), dx);     /* mov [bp-0x10], dx */
    II(0x0013abff, 0x4)   mov(memw_a16(es, bx + 0x8), dx);      /* mov [es:bx+0x8], dx */
    II(0x0013ac03, 0x6)   mov(memw_a16(es, bx + 0xa), 0);       /* mov word [es:bx+0xa], 0x0 */
    II(0x0013ac09, 0x3)   mov(ax, memw_a16(ss, bp - 0x12));     /* mov ax, [bp-0x12] */
    II(0x0013ac0c, 0x4)   mov(memw_a16(es, bx + 0x4), ax);      /* mov [es:bx+0x4], ax */
    II(0x0013ac10, 0x6)   mov(memw_a16(es, bx + 0x6), 0);       /* mov word [es:bx+0x6], 0x0 */
l_0x0013ac16:
    II(0x0013ac16, 0x4)   cmp(memw_a16(ss, bp - 0xa), 0);       /* cmp word [bp-0xa], 0x0 */
    II(0x0013ac1a, 0x2)   jzw(0x0013ac30, 0x14);                /* jz 0x13ac30 */
    II(0x0013ac1c, 0x3)   mov(ax, memw_a16(ss, bp - 0xa));      /* mov ax, [bp-0xa] */
    II(0x0013ac1f, 0x1)   cwd();                                /* cwd  */
    II(0x0013ac20, 0x3)   les(bx, ss, bp + 0x6);                /* les bx, [bp+0x6] */
    II(0x0013ac23, 0x4)   mov(memw_a16(es, bx + 0x20), ax);     /* mov [es:bx+0x20], ax */
    II(0x0013ac27, 0x4)   mov(memw_a16(es, bx + 0x22), dx);     /* mov [es:bx+0x22], dx */
    II(0x0013ac2b, 0x5)   or_(memb_a16(es, bx + 0x2c), 0x1);    /* or byte [es:bx+0x2c], 0x1 */
l_0x0013ac30:
    II(0x0013ac30, 0x1)   popw(ds);                             /* pop ds */
    II(0x0013ac31, 0x1)   leavew();                             /* leave  */
    II(0x0013ac32, 0x1)   retfw();                              /* retf  */
FUNC_END

