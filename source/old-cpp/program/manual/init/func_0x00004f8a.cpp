FUNC_BEGIN(0x00004f8a, 0x729d2e078352d733, 0x10, ({0xc8, 0x10, 0, 0, 0x56, 0xa1, 0xb4, 0x9, 0x2b, 0xd2, 0xb1, 0x4, 0xe8, 0xfb, 0xd, 0x8b, 0xda, 0xa3, 0xe2, 0x8, 0x8b, 0xd0, 0x8b, 0xf3, 0x88, 0x1e, 0xe4, 0x8, 0x89, 0x56, 0xf8, 0x89, 0x76, 0xfa, 0x81, 0xc2, 0xc0, 0x8, 0x83, 0xd6, 0, 0x89, 0x16, 0x76, 0x9, 0x89, 0x36, 0x78, 0x9, 0xc7, 0x6, 0xc8, 0x8, 0x9f, 0, 0x89, 0x56, 0xf4, 0x89, 0x76, 0xf6, 0x89, 0x16, 0xca, 0x8, 0x8a, 0x46, 0xf6, 0xa2, 0xcc, 0x8, 0xb8, 0x60, 0x9, 0x2d, 0xc0, 0x8, 0x2b, 0xd2, 0x3, 0x46, 0xf4, 0x13, 0xd6, 0x8b, 0xc8, 0x8b, 0xda, 0xa3, 0x12, 0x9, 0x8b, 0xd0, 0x8b, 0xf3, 0x88, 0x1e, 0x14, 0x9, 0x2b, 0xc0, 0xa3, 0xce, 0x8, 0xa3, 0x16, 0x9, 0xb8, 0x60, 0x9, 0x2d, 0xc0, 0, 0x2b, 0xd0, 0x83, 0xde, 0, 0x89, 0x76, 0xf2, 0x89, 0x16, 0xd2, 0x8, 0x8a, 0x46, 0xf2, 0xa2, 0xd4, 0x8, 0xa1, 0xb6, 0x9, 0x2b, 0xd2, 0xb1, 0x4, 0xe8, 0x7d, 0xd, 0x8b, 0xda, 0xa3, 0xa, 0x9, 0xa3, 0xda, 0x8, 0x88, 0x1e, 0xc, 0x9, 0x88, 0x1e, 0xdc, 0x8, 0xb8, 0x74, 0xd, 0x2b, 0xd2, 0x3, 0x46, 0xf8, 0x13, 0x56, 0xfa, 0x8b, 0xc8, 0x8b, 0xda, 0xa3, 0x1a, 0x9, 0x88, 0x1e, 0x1c, 0x9, 0xa1, 0x10, 0xa, 0x8b, 0x16, 0x12, 0xa, 0xb1, 0x4, 0xe8, 0x4b, 0xd, 0x89, 0x56, 0xfe, 0xa3, 0x32, 0x9, 0x8a, 0x46, 0xfe, 0xa2, 0x34, 0x9, 0x8a, 0x46, 0xff, 0x98, 0x8a, 0xe0, 0x2a, 0xc0, 0xa3, 0x36, 0x9, 0xc7, 0x6, 0x70, 0xd, 0x80, 0, 0x80, 0x3e, 0x2f, 0, 0x3, 0x7c, 0x6, 0xc7, 0x6, 0xfe, 0x8, 0x8f, 0, 0x5e, 0xc9, 0xc3}))
    II(0x00004f8a, 0x4)   enterw(0x10, 0);                      /* enter 0x10, 0x0 */
    II(0x00004f8e, 0x1)   pushw(si);                            /* push si */
    II(0x00004f8f, 0x3)   mov(ax, memw_a16(ds, 0x9b4));         /* mov ax, [0x9b4] */
    II(0x00004f92, 0x2)   sub(dx, dx);                          /* sub dx, dx */
    II(0x00004f94, 0x2)   mov(cl, 0x4);                         /* mov cl, 0x4 */
    II(0x00004f96, 0x3)   callw(0x00005d94, 0xdfb);             /* call 0x5d94 */
    II(0x00004f99, 0x2)   mov(bx, dx);                          /* mov bx, dx */
    II(0x00004f9b, 0x3)   mov(memw_a16(ds, 0x8e2), ax);         /* mov [0x8e2], ax */
    II(0x00004f9e, 0x2)   mov(dx, ax);                          /* mov dx, ax */
    II(0x00004fa0, 0x2)   mov(si, bx);                          /* mov si, bx */
    II(0x00004fa2, 0x4)   mov(memb_a16(ds, 0x8e4), bl);         /* mov [0x8e4], bl */
    II(0x00004fa6, 0x3)   mov(memw_a16(ss, bp - 0x8), dx);      /* mov [bp-0x8], dx */
    II(0x00004fa9, 0x3)   mov(memw_a16(ss, bp - 0x6), si);      /* mov [bp-0x6], si */
    II(0x00004fac, 0x4)   add(dx, 0x8c0);                       /* add dx, 0x8c0 */
    II(0x00004fb0, 0x3)   adc(si, 0);                           /* adc si, 0x0 */
    II(0x00004fb3, 0x4)   mov(memw_a16(ds, 0x976), dx);         /* mov [0x976], dx */
    II(0x00004fb7, 0x4)   mov(memw_a16(ds, 0x978), si);         /* mov [0x978], si */
    II(0x00004fbb, 0x6)   mov(memw_a16(ds, 0x8c8), 0x9f);       /* mov word [0x8c8], 0x9f */
    II(0x00004fc1, 0x3)   mov(memw_a16(ss, bp - 0xc), dx);      /* mov [bp-0xc], dx */
    II(0x00004fc4, 0x3)   mov(memw_a16(ss, bp - 0xa), si);      /* mov [bp-0xa], si */
    II(0x00004fc7, 0x4)   mov(memw_a16(ds, 0x8ca), dx);         /* mov [0x8ca], dx */
    II(0x00004fcb, 0x3)   mov(al, memb_a16(ss, bp - 0xa));      /* mov al, [bp-0xa] */
    II(0x00004fce, 0x3)   mov(memb_a16(ds, 0x8cc), al);         /* mov [0x8cc], al */
    II(0x00004fd1, 0x3)   mov(ax, 0x960);                       /* mov ax, 0x960 */
    II(0x00004fd4, 0x3)   sub(ax, 0x8c0);                       /* sub ax, 0x8c0 */
    II(0x00004fd7, 0x2)   sub(dx, dx);                          /* sub dx, dx */
    II(0x00004fd9, 0x3)   add(ax, memw_a16(ss, bp - 0xc));      /* add ax, [bp-0xc] */
    II(0x00004fdc, 0x2)   adc(dx, si);                          /* adc dx, si */
    II(0x00004fde, 0x2)   mov(cx, ax);                          /* mov cx, ax */
    II(0x00004fe0, 0x2)   mov(bx, dx);                          /* mov bx, dx */
    II(0x00004fe2, 0x3)   mov(memw_a16(ds, 0x912), ax);         /* mov [0x912], ax */
    II(0x00004fe5, 0x2)   mov(dx, ax);                          /* mov dx, ax */
    II(0x00004fe7, 0x2)   mov(si, bx);                          /* mov si, bx */
    II(0x00004fe9, 0x4)   mov(memb_a16(ds, 0x914), bl);         /* mov [0x914], bl */
    II(0x00004fed, 0x2)   sub(ax, ax);                          /* sub ax, ax */
    II(0x00004fef, 0x3)   mov(memw_a16(ds, 0x8ce), ax);         /* mov [0x8ce], ax */
    II(0x00004ff2, 0x3)   mov(memw_a16(ds, 0x916), ax);         /* mov [0x916], ax */
    II(0x00004ff5, 0x3)   mov(ax, 0x960);                       /* mov ax, 0x960 */
    II(0x00004ff8, 0x3)   sub(ax, 0xc0);                        /* sub ax, 0xc0 */
    II(0x00004ffb, 0x2)   sub(dx, ax);                          /* sub dx, ax */
    II(0x00004ffd, 0x3)   sbb(si, 0);                           /* sbb si, 0x0 */
    II(0x00005000, 0x3)   mov(memw_a16(ss, bp - 0xe), si);      /* mov [bp-0xe], si */
    II(0x00005003, 0x4)   mov(memw_a16(ds, 0x8d2), dx);         /* mov [0x8d2], dx */
    II(0x00005007, 0x3)   mov(al, memb_a16(ss, bp - 0xe));      /* mov al, [bp-0xe] */
    II(0x0000500a, 0x3)   mov(memb_a16(ds, 0x8d4), al);         /* mov [0x8d4], al */
    II(0x0000500d, 0x3)   mov(ax, memw_a16(ds, 0x9b6));         /* mov ax, [0x9b6] */
    II(0x00005010, 0x2)   sub(dx, dx);                          /* sub dx, dx */
    II(0x00005012, 0x2)   mov(cl, 0x4);                         /* mov cl, 0x4 */
    II(0x00005014, 0x3)   callw(0x00005d94, 0xd7d);             /* call 0x5d94 */
    II(0x00005017, 0x2)   mov(bx, dx);                          /* mov bx, dx */
    II(0x00005019, 0x3)   mov(memw_a16(ds, 0x90a), ax);         /* mov [0x90a], ax */
    II(0x0000501c, 0x3)   mov(memw_a16(ds, 0x8da), ax);         /* mov [0x8da], ax */
    II(0x0000501f, 0x4)   mov(memb_a16(ds, 0x90c), bl);         /* mov [0x90c], bl */
    II(0x00005023, 0x4)   mov(memb_a16(ds, 0x8dc), bl);         /* mov [0x8dc], bl */
    II(0x00005027, 0x3)   mov(ax, 0xd74);                       /* mov ax, 0xd74 */
    II(0x0000502a, 0x2)   sub(dx, dx);                          /* sub dx, dx */
    II(0x0000502c, 0x3)   add(ax, memw_a16(ss, bp - 0x8));      /* add ax, [bp-0x8] */
    II(0x0000502f, 0x3)   adc(dx, memw_a16(ss, bp - 0x6));      /* adc dx, [bp-0x6] */
    II(0x00005032, 0x2)   mov(cx, ax);                          /* mov cx, ax */
    II(0x00005034, 0x2)   mov(bx, dx);                          /* mov bx, dx */
    II(0x00005036, 0x3)   mov(memw_a16(ds, 0x91a), ax);         /* mov [0x91a], ax */
    II(0x00005039, 0x4)   mov(memb_a16(ds, 0x91c), bl);         /* mov [0x91c], bl */
    II(0x0000503d, 0x3)   mov(ax, memw_a16(ds, 0xa10));         /* mov ax, [0xa10] */
    II(0x00005040, 0x4)   mov(dx, memw_a16(ds, 0xa12));         /* mov dx, [0xa12] */
    II(0x00005044, 0x2)   mov(cl, 0x4);                         /* mov cl, 0x4 */
    II(0x00005046, 0x3)   callw(0x00005d94, 0xd4b);             /* call 0x5d94 */
    II(0x00005049, 0x3)   mov(memw_a16(ss, bp - 0x2), dx);      /* mov [bp-0x2], dx */
    II(0x0000504c, 0x3)   mov(memw_a16(ds, 0x932), ax);         /* mov [0x932], ax */
    II(0x0000504f, 0x3)   mov(al, memb_a16(ss, bp - 0x2));      /* mov al, [bp-0x2] */
    II(0x00005052, 0x3)   mov(memb_a16(ds, 0x934), al);         /* mov [0x934], al */
    II(0x00005055, 0x3)   mov(al, memb_a16(ss, bp - 0x1));      /* mov al, [bp-0x1] */
    II(0x00005058, 0x1)   cbw();                                /* cbw  */
    II(0x00005059, 0x2)   mov(ah, al);                          /* mov ah, al */
    II(0x0000505b, 0x2)   sub(al, al);                          /* sub al, al */
    II(0x0000505d, 0x3)   mov(memw_a16(ds, 0x936), ax);         /* mov [0x936], ax */
    II(0x00005060, 0x6)   mov(memw_a16(ds, 0xd70), 0x80);       /* mov word [0xd70], 0x80 */
    II(0x00005066, 0x5)   cmp(memb_a16(ds, 0x2f), 0x3);         /* cmp byte [0x2f], 0x3 */
    II(0x0000506b, 0x2)   jlw(0x00005073, 0x6);                 /* jl 0x5073 */
    II(0x0000506d, 0x6)   mov(memw_a16(ds, 0x8fe), 0x8f);       /* mov word [0x8fe], 0x8f */
l_0x00005073:
    II(0x00005073, 0x1)   popw(si);                             /* pop si */
    II(0x00005074, 0x1)   leavew();                             /* leave  */
    II(0x00005075, 0x1)   retw();                               /* ret  */
FUNC_END

