FUNC_BEGIN(0x00134d3a, 0xafda372dcc7f431d, 0x10, ({0xc8, 0x16, 0, 0, 0x1e, 0xb8, 0x68, 0x3e, 0x8e, 0xd8, 0x68, 0x58, 0x3e, 0x68, 0x7c, 0x86, 0x90, 0xe, 0xe8, 0xe1, 0x98, 0x83, 0xc4, 0x4, 0x89, 0x46, 0xf8, 0x89, 0x56, 0xfa, 0xc7, 0x46, 0xf4, 0x80, 0x86, 0xc7, 0x46, 0xf6, 0x58, 0x3e, 0x8b, 0xc2, 0x89, 0x46, 0xf6, 0xc7, 0x46, 0xec, 0x88, 0x86, 0xc7, 0x46, 0xee, 0x58, 0x3e, 0x89, 0x46, 0xee, 0xc7, 0x46, 0xfc, 0x78, 0x86, 0xc7, 0x46, 0xfe, 0x58, 0x3e, 0x89, 0x46, 0xfe, 0xc7, 0x46, 0xf0, 0x84, 0x86, 0xc7, 0x46, 0xf2, 0x58, 0x3e, 0x89, 0x46, 0xf2, 0x50, 0xff, 0x76, 0xf8, 0x68, 0x58, 0x3e, 0x68, 0xab, 0x87, 0x6a, 0x5, 0xe, 0xe8, 0x44, 0x1, 0x83, 0xc4, 0xa, 0xb, 0xc0, 0x75, 0x64, 0xff, 0x76, 0xfe, 0xff, 0x76, 0xfc, 0x68, 0x58, 0x3e, 0x68, 0x7b, 0x87, 0x6a, 0x4, 0xe, 0xe8, 0x2b, 0x1, 0x83, 0xc4, 0xa, 0xb, 0xc0, 0x75, 0x4b, 0xff, 0x76, 0xf6, 0xff, 0x76, 0xf4, 0x68, 0x58, 0x3e, 0x68, 0xec, 0x87, 0x6a, 0x6, 0xe, 0xe8, 0x12, 0x1, 0x83, 0xc4, 0xa, 0xb, 0xc0, 0x75, 0x32, 0xff, 0x76, 0xf2, 0xff, 0x76, 0xf0, 0x68, 0x58, 0x3e, 0x68, 0x21, 0x88, 0x6a, 0x7, 0xe, 0xe8, 0xf9, 0, 0x83, 0xc4, 0xa, 0xb, 0xc0, 0x75, 0x19, 0xff, 0x76, 0xee, 0xff, 0x76, 0xec, 0x68, 0x58, 0x3e, 0x68, 0x56, 0x88, 0x6a, 0x8, 0xe, 0xe8, 0xe0, 0, 0x83, 0xc4, 0xa, 0xb, 0xc0, 0x74, 0x7, 0xc7, 0x46, 0xea, 0x1, 0, 0xeb, 0x5, 0xc7, 0x46, 0xea, 0, 0, 0x8b, 0x46, 0xea, 0x1f, 0xc9, 0xc3}))
    II(0x00134d3a, 0x4)   enterw(0x16, 0);                      /* enter 0x16, 0x0 */
    II(0x00134d3e, 0x1)   pushw(ds);                            /* push ds */
    II(0x00134d3f, 0x3)   mov(ax, 0x3e68);                      /* mov ax, 0x3e68 */
    II(0x00134d42, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x00134d44, 0x3)   pushw(0x3e58);                        /* push word 0x3e58 */
    II(0x00134d47, 0x3)   pushw(0x867c);                        /* push word 0x867c */
//    II(0x00134d4a, 0x1)   nop();                                /* nop  */
    II(0x00134d4b, 0x1)   pushw(cs);                            /* push cs */
    II(0x00134d4c, 0x3)   callw(0x0012e630, -0x671f);           /* call 0x12e630 */
    II(0x00134d4f, 0x3)   add(sp, 0x4);                         /* add sp, 0x4 */
    II(0x00134d52, 0x3)   mov(memw_a16(ss, bp - 0x8), ax);      /* mov [bp-0x8], ax */
    II(0x00134d55, 0x3)   mov(memw_a16(ss, bp - 0x6), dx);      /* mov [bp-0x6], dx */
    II(0x00134d58, 0x5)   mov(memw_a16(ss, bp - 0xc), 0x8680);  /* mov word [bp-0xc], 0x8680 */
    II(0x00134d5d, 0x5)   mov(memw_a16(ss, bp - 0xa), 0x3e58);  /* mov word [bp-0xa], 0x3e58 */
    II(0x00134d62, 0x2)   mov(ax, dx);                          /* mov ax, dx */
    II(0x00134d64, 0x3)   mov(memw_a16(ss, bp - 0xa), ax);      /* mov [bp-0xa], ax */
    II(0x00134d67, 0x5)   mov(memw_a16(ss, bp - 0x14), 0x8688); /* mov word [bp-0x14], 0x8688 */
    II(0x00134d6c, 0x5)   mov(memw_a16(ss, bp - 0x12), 0x3e58); /* mov word [bp-0x12], 0x3e58 */
    II(0x00134d71, 0x3)   mov(memw_a16(ss, bp - 0x12), ax);     /* mov [bp-0x12], ax */
    II(0x00134d74, 0x5)   mov(memw_a16(ss, bp - 0x4), 0x8678);  /* mov word [bp-0x4], 0x8678 */
    II(0x00134d79, 0x5)   mov(memw_a16(ss, bp - 0x2), 0x3e58);  /* mov word [bp-0x2], 0x3e58 */
    II(0x00134d7e, 0x3)   mov(memw_a16(ss, bp - 0x2), ax);      /* mov [bp-0x2], ax */
    II(0x00134d81, 0x5)   mov(memw_a16(ss, bp - 0x10), 0x8684); /* mov word [bp-0x10], 0x8684 */
    II(0x00134d86, 0x5)   mov(memw_a16(ss, bp - 0xe), 0x3e58);  /* mov word [bp-0xe], 0x3e58 */
    II(0x00134d8b, 0x3)   mov(memw_a16(ss, bp - 0xe), ax);      /* mov [bp-0xe], ax */
    II(0x00134d8e, 0x1)   pushw(ax);                            /* push ax */
    II(0x00134d8f, 0x3)   pushw(memw_a16(ss, bp - 0x8));        /* push word [bp-0x8] */
    II(0x00134d92, 0x3)   pushw(0x3e58);                        /* push word 0x3e58 */
    II(0x00134d95, 0x3)   pushw(0x87ab);                        /* push word 0x87ab */
    II(0x00134d98, 0x2)   pushw(0x5);                           /* push 0x5 */
    II(0x00134d9a, 0x1)   pushw(cs);                            /* push cs */
    II(0x00134d9b, 0x3)   callw(0x00134ee2, 0x144);             /* call 0x134ee2 */
    II(0x00134d9e, 0x3)   add(sp, 0xa);                         /* add sp, 0xa */
    II(0x00134da1, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x00134da3, 0x2)   jnzw(0x00134e09, 0x64);               /* jnz 0x134e09 */
    II(0x00134da5, 0x3)   pushw(memw_a16(ss, bp - 0x2));        /* push word [bp-0x2] */
    II(0x00134da8, 0x3)   pushw(memw_a16(ss, bp - 0x4));        /* push word [bp-0x4] */
    II(0x00134dab, 0x3)   pushw(0x3e58);                        /* push word 0x3e58 */
    II(0x00134dae, 0x3)   pushw(0x877b);                        /* push word 0x877b */
    II(0x00134db1, 0x2)   pushw(0x4);                           /* push 0x4 */
    II(0x00134db3, 0x1)   pushw(cs);                            /* push cs */
    II(0x00134db4, 0x3)   callw(0x00134ee2, 0x12b);             /* call 0x134ee2 */
    II(0x00134db7, 0x3)   add(sp, 0xa);                         /* add sp, 0xa */
    II(0x00134dba, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x00134dbc, 0x2)   jnzw(0x00134e09, 0x4b);               /* jnz 0x134e09 */
    II(0x00134dbe, 0x3)   pushw(memw_a16(ss, bp - 0xa));        /* push word [bp-0xa] */
    II(0x00134dc1, 0x3)   pushw(memw_a16(ss, bp - 0xc));        /* push word [bp-0xc] */
    II(0x00134dc4, 0x3)   pushw(0x3e58);                        /* push word 0x3e58 */
    II(0x00134dc7, 0x3)   pushw(0x87ec);                        /* push word 0x87ec */
    II(0x00134dca, 0x2)   pushw(0x6);                           /* push 0x6 */
    II(0x00134dcc, 0x1)   pushw(cs);                            /* push cs */
    II(0x00134dcd, 0x3)   callw(0x00134ee2, 0x112);             /* call 0x134ee2 */
    II(0x00134dd0, 0x3)   add(sp, 0xa);                         /* add sp, 0xa */
    II(0x00134dd3, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x00134dd5, 0x2)   jnzw(0x00134e09, 0x32);               /* jnz 0x134e09 */
    II(0x00134dd7, 0x3)   pushw(memw_a16(ss, bp - 0xe));        /* push word [bp-0xe] */
    II(0x00134dda, 0x3)   pushw(memw_a16(ss, bp - 0x10));       /* push word [bp-0x10] */
    II(0x00134ddd, 0x3)   pushw(0x3e58);                        /* push word 0x3e58 */
    II(0x00134de0, 0x3)   pushw(0x8821);                        /* push word 0x8821 */
    II(0x00134de3, 0x2)   pushw(0x7);                           /* push 0x7 */
    II(0x00134de5, 0x1)   pushw(cs);                            /* push cs */
    II(0x00134de6, 0x3)   callw(0x00134ee2, 0xf9);              /* call 0x134ee2 */
    II(0x00134de9, 0x3)   add(sp, 0xa);                         /* add sp, 0xa */
    II(0x00134dec, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x00134dee, 0x2)   jnzw(0x00134e09, 0x19);               /* jnz 0x134e09 */
    II(0x00134df0, 0x3)   pushw(memw_a16(ss, bp - 0x12));       /* push word [bp-0x12] */
    II(0x00134df3, 0x3)   pushw(memw_a16(ss, bp - 0x14));       /* push word [bp-0x14] */
    II(0x00134df6, 0x3)   pushw(0x3e58);                        /* push word 0x3e58 */
    II(0x00134df9, 0x3)   pushw(0x8856);                        /* push word 0x8856 */
    II(0x00134dfc, 0x2)   pushw(0x8);                           /* push 0x8 */
    II(0x00134dfe, 0x1)   pushw(cs);                            /* push cs */
    II(0x00134dff, 0x3)   callw(0x00134ee2, 0xe0);              /* call 0x134ee2 */
    II(0x00134e02, 0x3)   add(sp, 0xa);                         /* add sp, 0xa */
    II(0x00134e05, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x00134e07, 0x2)   jzw(0x00134e10, 0x7);                 /* jz 0x134e10 */
l_0x00134e09:
    II(0x00134e09, 0x5)   mov(memw_a16(ss, bp - 0x16), 0x1);    /* mov word [bp-0x16], 0x1 */
    II(0x00134e0e, 0x2)   jmpw(0x00134e15, 0x5);                /* jmp 0x134e15 */
l_0x00134e10:
    II(0x00134e10, 0x5)   mov(memw_a16(ss, bp - 0x16), 0);      /* mov word [bp-0x16], 0x0 */
l_0x00134e15:
    II(0x00134e15, 0x3)   mov(ax, memw_a16(ss, bp - 0x16));     /* mov ax, [bp-0x16] */
    II(0x00134e18, 0x1)   popw(ds);                             /* pop ds */
    II(0x00134e19, 0x1)   leavew();                             /* leave  */
    II(0x00134e1a, 0x1)   retw();                               /* ret  */
FUNC_END

