FUNC_BEGIN(0x00160016, 0x2507bccbaffbde8c, 0x10, ({0xc8, 0x4, 0, 0, 0x1e, 0xb8, 0xa8, 0, 0x8e, 0xd8, 0x1e, 0x68, 0xcc, 0x31, 0x9a, 0xa0, 0x5b, 0x80, 0, 0x5b, 0x5b, 0x89, 0x46, 0xfc, 0x89, 0x56, 0xfe, 0xb, 0xd0, 0x74, 0x62, 0x1e, 0x68, 0xe0, 0x31, 0xff, 0x76, 0xfe, 0x50, 0x9a, 0x20, 0x5a, 0x80, 0, 0x83, 0xc4, 0x8, 0xa3, 0x90, 0x32, 0x89, 0x16, 0x92, 0x32, 0x1e, 0x68, 0xf9, 0x31, 0xff, 0x76, 0xfe, 0xff, 0x76, 0xfc, 0x9a, 0x20, 0x5a, 0x80, 0, 0x83, 0xc4, 0x8, 0xa3, 0xac, 0x32, 0x89, 0x16, 0xae, 0x32, 0x1e, 0x68, 0xe, 0x32, 0xff, 0x76, 0xfe, 0xff, 0x76, 0xfc, 0x9a, 0x20, 0x5a, 0x80, 0, 0x83, 0xc4, 0x8, 0xa3, 0xb0, 0x32, 0x89, 0x16, 0xb2, 0x32, 0x1e, 0x68, 0x27, 0x32, 0xff, 0x76, 0xfe, 0xff, 0x76, 0xfc, 0x9a, 0x20, 0x5a, 0x80, 0, 0x83, 0xc4, 0x8, 0xa3, 0xa8, 0x32, 0x89, 0x16, 0xaa, 0x32, 0x1e, 0x68, 0x3d, 0x32, 0x9a, 0xa0, 0x5b, 0x80, 0, 0x5b, 0x5b, 0x89, 0x46, 0xfc, 0x89, 0x56, 0xfe, 0xb, 0xd0, 0x74, 0x49, 0x1e, 0x68, 0x43, 0x32, 0xff, 0x76, 0xfe, 0x50, 0x9a, 0x20, 0x5a, 0x80, 0, 0x83, 0xc4, 0x8, 0xa3, 0x94, 0x32, 0x89, 0x16, 0x96, 0x32, 0x1e, 0x68, 0x4e, 0x32, 0xff, 0x76, 0xfe, 0xff, 0x76, 0xfc, 0x9a, 0x20, 0x5a, 0x80, 0, 0x83, 0xc4, 0x8, 0xa3, 0x98, 0x32, 0x89, 0x16, 0x9a, 0x32, 0x1e, 0x68, 0x5b, 0x32, 0xff, 0x76, 0xfe, 0xff, 0x76, 0xfc, 0x9a, 0x20, 0x5a, 0x80, 0, 0x83, 0xc4, 0x8, 0xa3, 0x9c, 0x32, 0x89, 0x16, 0x9e, 0x32, 0x1e, 0x68, 0x66, 0x32, 0x9a, 0xa0, 0x5b, 0x80, 0, 0x5b, 0x5b, 0x89, 0x46, 0xfc, 0x89, 0x56, 0xfe, 0xb, 0xd0, 0x74, 0x30, 0x1e, 0x68, 0x71, 0x32, 0xff, 0x76, 0xfe, 0x50, 0x9a, 0x20, 0x5a, 0x80, 0, 0x83, 0xc4, 0x8, 0xa3, 0xa0, 0x32, 0x89, 0x16, 0xa2, 0x32, 0x1e, 0x68, 0x7e, 0x32, 0xff, 0x76, 0xfe, 0xff, 0x76, 0xfc, 0x9a, 0x20, 0x5a, 0x80, 0, 0x83, 0xc4, 0x8, 0xa3, 0xa4, 0x32, 0x89, 0x16, 0xa6, 0x32, 0xb8, 0x1, 0, 0x1f, 0xc9, 0xcb}))
    II(0x00160016, 0x4)   enterw(0x4, 0);                       /* enter 0x4, 0x0 */
    II(0x0016001a, 0x1)   pushw(ds);                            /* push ds */
    II(0x0016001b, 0x3)   mov(ax, 0xa8);                        /* mov ax, 0xa8 */
    II(0x0016001e, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x00160020, 0x1)   pushw(ds);                            /* push ds */
    II(0x00160021, 0x3)   pushw(0x31cc);                        /* push word 0x31cc */
    II(0x00160024, 0x5)   callw_far_abs(0x80, 0x5ba0);          /* call word 0x80:0x5ba0 */
    II(0x00160029, 0x1)   popw(bx);                             /* pop bx */
    II(0x0016002a, 0x1)   popw(bx);                             /* pop bx */
    II(0x0016002b, 0x3)   mov(memw_a16(ss, bp - 0x4), ax);      /* mov [bp-0x4], ax */
    II(0x0016002e, 0x3)   mov(memw_a16(ss, bp - 0x2), dx);      /* mov [bp-0x2], dx */
    II(0x00160031, 0x2)   or_(dx, ax);                          /* or dx, ax */
    II(0x00160033, 0x2)   jzw(0x00160097, 0x62);                /* jz 0x160097 */
    II(0x00160035, 0x1)   pushw(ds);                            /* push ds */
    II(0x00160036, 0x3)   pushw(0x31e0);                        /* push word 0x31e0 */
    II(0x00160039, 0x3)   pushw(memw_a16(ss, bp - 0x2));        /* push word [bp-0x2] */
    II(0x0016003c, 0x1)   pushw(ax);                            /* push ax */
    II(0x0016003d, 0x5)   callw_far_abs(0x80, 0x5a20);          /* call word 0x80:0x5a20 */
    II(0x00160042, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
    II(0x00160045, 0x3)   mov(memw_a16(ds, 0x3290), ax);        /* mov [0x3290], ax */
    II(0x00160048, 0x4)   mov(memw_a16(ds, 0x3292), dx);        /* mov [0x3292], dx */
    II(0x0016004c, 0x1)   pushw(ds);                            /* push ds */
    II(0x0016004d, 0x3)   pushw(0x31f9);                        /* push word 0x31f9 */
    II(0x00160050, 0x3)   pushw(memw_a16(ss, bp - 0x2));        /* push word [bp-0x2] */
    II(0x00160053, 0x3)   pushw(memw_a16(ss, bp - 0x4));        /* push word [bp-0x4] */
    II(0x00160056, 0x5)   callw_far_abs(0x80, 0x5a20);          /* call word 0x80:0x5a20 */
    II(0x0016005b, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
    II(0x0016005e, 0x3)   mov(memw_a16(ds, 0x32ac), ax);        /* mov [0x32ac], ax */
    II(0x00160061, 0x4)   mov(memw_a16(ds, 0x32ae), dx);        /* mov [0x32ae], dx */
    II(0x00160065, 0x1)   pushw(ds);                            /* push ds */
    II(0x00160066, 0x3)   pushw(0x320e);                        /* push word 0x320e */
    II(0x00160069, 0x3)   pushw(memw_a16(ss, bp - 0x2));        /* push word [bp-0x2] */
    II(0x0016006c, 0x3)   pushw(memw_a16(ss, bp - 0x4));        /* push word [bp-0x4] */
    II(0x0016006f, 0x5)   callw_far_abs(0x80, 0x5a20);          /* call word 0x80:0x5a20 */
    II(0x00160074, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
    II(0x00160077, 0x3)   mov(memw_a16(ds, 0x32b0), ax);        /* mov [0x32b0], ax */
    II(0x0016007a, 0x4)   mov(memw_a16(ds, 0x32b2), dx);        /* mov [0x32b2], dx */
    II(0x0016007e, 0x1)   pushw(ds);                            /* push ds */
    II(0x0016007f, 0x3)   pushw(0x3227);                        /* push word 0x3227 */
    II(0x00160082, 0x3)   pushw(memw_a16(ss, bp - 0x2));        /* push word [bp-0x2] */
    II(0x00160085, 0x3)   pushw(memw_a16(ss, bp - 0x4));        /* push word [bp-0x4] */
    II(0x00160088, 0x5)   callw_far_abs(0x80, 0x5a20);          /* call word 0x80:0x5a20 */
    II(0x0016008d, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
    II(0x00160090, 0x3)   mov(memw_a16(ds, 0x32a8), ax);        /* mov [0x32a8], ax */
    II(0x00160093, 0x4)   mov(memw_a16(ds, 0x32aa), dx);        /* mov [0x32aa], dx */
l_0x00160097:
    II(0x00160097, 0x1)   pushw(ds);                            /* push ds */
    II(0x00160098, 0x3)   pushw(0x323d);                        /* push word 0x323d */
    II(0x0016009b, 0x5)   callw_far_abs(0x80, 0x5ba0);          /* call word 0x80:0x5ba0 */
    II(0x001600a0, 0x1)   popw(bx);                             /* pop bx */
    II(0x001600a1, 0x1)   popw(bx);                             /* pop bx */
    II(0x001600a2, 0x3)   mov(memw_a16(ss, bp - 0x4), ax);      /* mov [bp-0x4], ax */
    II(0x001600a5, 0x3)   mov(memw_a16(ss, bp - 0x2), dx);      /* mov [bp-0x2], dx */
    II(0x001600a8, 0x2)   or_(dx, ax);                          /* or dx, ax */
    II(0x001600aa, 0x2)   jzw(0x001600f5, 0x49);                /* jz 0x1600f5 */
    II(0x001600ac, 0x1)   pushw(ds);                            /* push ds */
    II(0x001600ad, 0x3)   pushw(0x3243);                        /* push word 0x3243 */
    II(0x001600b0, 0x3)   pushw(memw_a16(ss, bp - 0x2));        /* push word [bp-0x2] */
    II(0x001600b3, 0x1)   pushw(ax);                            /* push ax */
    II(0x001600b4, 0x5)   callw_far_abs(0x80, 0x5a20);          /* call word 0x80:0x5a20 */
    II(0x001600b9, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
    II(0x001600bc, 0x3)   mov(memw_a16(ds, 0x3294), ax);        /* mov [0x3294], ax */
    II(0x001600bf, 0x4)   mov(memw_a16(ds, 0x3296), dx);        /* mov [0x3296], dx */
    II(0x001600c3, 0x1)   pushw(ds);                            /* push ds */
    II(0x001600c4, 0x3)   pushw(0x324e);                        /* push word 0x324e */
    II(0x001600c7, 0x3)   pushw(memw_a16(ss, bp - 0x2));        /* push word [bp-0x2] */
    II(0x001600ca, 0x3)   pushw(memw_a16(ss, bp - 0x4));        /* push word [bp-0x4] */
    II(0x001600cd, 0x5)   callw_far_abs(0x80, 0x5a20);          /* call word 0x80:0x5a20 */
    II(0x001600d2, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
    II(0x001600d5, 0x3)   mov(memw_a16(ds, 0x3298), ax);        /* mov [0x3298], ax */
    II(0x001600d8, 0x4)   mov(memw_a16(ds, 0x329a), dx);        /* mov [0x329a], dx */
    II(0x001600dc, 0x1)   pushw(ds);                            /* push ds */
    II(0x001600dd, 0x3)   pushw(0x325b);                        /* push word 0x325b */
    II(0x001600e0, 0x3)   pushw(memw_a16(ss, bp - 0x2));        /* push word [bp-0x2] */
    II(0x001600e3, 0x3)   pushw(memw_a16(ss, bp - 0x4));        /* push word [bp-0x4] */
    II(0x001600e6, 0x5)   callw_far_abs(0x80, 0x5a20);          /* call word 0x80:0x5a20 */
    II(0x001600eb, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
    II(0x001600ee, 0x3)   mov(memw_a16(ds, 0x329c), ax);        /* mov [0x329c], ax */
    II(0x001600f1, 0x4)   mov(memw_a16(ds, 0x329e), dx);        /* mov [0x329e], dx */
l_0x001600f5:
    II(0x001600f5, 0x1)   pushw(ds);                            /* push ds */
    II(0x001600f6, 0x3)   pushw(0x3266);                        /* push word 0x3266 */
    II(0x001600f9, 0x5)   callw_far_abs(0x80, 0x5ba0);          /* call word 0x80:0x5ba0 */
    II(0x001600fe, 0x1)   popw(bx);                             /* pop bx */
    II(0x001600ff, 0x1)   popw(bx);                             /* pop bx */
    II(0x00160100, 0x3)   mov(memw_a16(ss, bp - 0x4), ax);      /* mov [bp-0x4], ax */
    II(0x00160103, 0x3)   mov(memw_a16(ss, bp - 0x2), dx);      /* mov [bp-0x2], dx */
    II(0x00160106, 0x2)   or_(dx, ax);                          /* or dx, ax */
    II(0x00160108, 0x2)   jzw(0x0016013a, 0x30);                /* jz 0x16013a */
    II(0x0016010a, 0x1)   pushw(ds);                            /* push ds */
    II(0x0016010b, 0x3)   pushw(0x3271);                        /* push word 0x3271 */
    II(0x0016010e, 0x3)   pushw(memw_a16(ss, bp - 0x2));        /* push word [bp-0x2] */
    II(0x00160111, 0x1)   pushw(ax);                            /* push ax */
    II(0x00160112, 0x5)   callw_far_abs(0x80, 0x5a20);          /* call word 0x80:0x5a20 */
    II(0x00160117, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
    II(0x0016011a, 0x3)   mov(memw_a16(ds, 0x32a0), ax);        /* mov [0x32a0], ax */
    II(0x0016011d, 0x4)   mov(memw_a16(ds, 0x32a2), dx);        /* mov [0x32a2], dx */
    II(0x00160121, 0x1)   pushw(ds);                            /* push ds */
    II(0x00160122, 0x3)   pushw(0x327e);                        /* push word 0x327e */
    II(0x00160125, 0x3)   pushw(memw_a16(ss, bp - 0x2));        /* push word [bp-0x2] */
    II(0x00160128, 0x3)   pushw(memw_a16(ss, bp - 0x4));        /* push word [bp-0x4] */
    II(0x0016012b, 0x5)   callw_far_abs(0x80, 0x5a20);          /* call word 0x80:0x5a20 */
    II(0x00160130, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
    II(0x00160133, 0x3)   mov(memw_a16(ds, 0x32a4), ax);        /* mov [0x32a4], ax */
    II(0x00160136, 0x4)   mov(memw_a16(ds, 0x32a6), dx);        /* mov [0x32a6], dx */
l_0x0016013a:
    II(0x0016013a, 0x3)   mov(ax, 0x1);                         /* mov ax, 0x1 */
    II(0x0016013d, 0x1)   popw(ds);                             /* pop ds */
    II(0x0016013e, 0x1)   leavew();                             /* leave  */
    II(0x0016013f, 0x1)   retfw();                              /* retf  */
FUNC_END

