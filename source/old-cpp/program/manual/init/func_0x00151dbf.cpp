FUNC_BEGIN(0x00151dbf, 0xbc6b75dab549fbe2, 0x10, ({0xc8, 0x6, 0, 0, 0xb8, 0xdc, 0x3a, 0x89, 0x46, 0xfc, 0x8c, 0x5e, 0xfe, 0x83, 0x7e, 0xa, 0, 0x74, 0x12, 0xff, 0x76, 0x8, 0x1e, 0x50, 0xff, 0x76, 0x6, 0xff, 0x76, 0x4, 0x90, 0xe, 0xe8, 0x8c, 0x14, 0xeb, 0x12, 0xff, 0x76, 0x8, 0x1e, 0x68, 0xdc, 0x3a, 0xff, 0x76, 0x6, 0xff, 0x76, 0x4, 0x90, 0xe, 0xe8, 0x82, 0x14, 0x83, 0xc4, 0xa, 0xeb, 0x10, 0x3c, 0x61, 0x7c, 0x9, 0x3c, 0x66, 0x7f, 0x5, 0x2c, 0x20, 0x26, 0x88, 0x7, 0xff, 0x46, 0xfc, 0xc4, 0x5e, 0xfc, 0x26, 0x8a, 0x7, 0xa, 0xc0, 0x75, 0xe6, 0x8b, 0xc3, 0x2d, 0xdc, 0x3a, 0xc9, 0xc3}))
    II(0x00151dbf, 0x4)   enterw(0x6, 0);                       /* enter 0x6, 0x0 */
    II(0x00151dc3, 0x3)   mov(ax, 0x3adc);                      /* mov ax, 0x3adc */
    II(0x00151dc6, 0x3)   mov(memw_a16(ss, bp - 0x4), ax);      /* mov [bp-0x4], ax */
    II(0x00151dc9, 0x3)   mov(memw_a16(ss, bp - 0x2), ds);      /* mov [bp-0x2], ds */
    II(0x00151dcc, 0x4)   cmp(memw_a16(ss, bp + 0xa), 0);       /* cmp word [bp+0xa], 0x0 */
    II(0x00151dd0, 0x2)   jzw(0x00151de4, 0x12);                /* jz 0x151de4 */
    II(0x00151dd2, 0x3)   pushw(memw_a16(ss, bp + 0x8));        /* push word [bp+0x8] */
    II(0x00151dd5, 0x1)   pushw(ds);                            /* push ds */
    II(0x00151dd6, 0x1)   pushw(ax);                            /* push ax */
    II(0x00151dd7, 0x3)   pushw(memw_a16(ss, bp + 0x6));        /* push word [bp+0x6] */
    II(0x00151dda, 0x3)   pushw(memw_a16(ss, bp + 0x4));        /* push word [bp+0x4] */
//    II(0x00151ddd, 0x1)   nop();                                /* nop  */
    II(0x00151dde, 0x1)   pushw(cs);                            /* push cs */
    II(0x00151ddf, 0x3)   callw(0x0015326e, 0x148c);            /* call 0x15326e */
    II(0x00151de2, 0x2)   jmpw(0x00151df6, 0x12);               /* jmp 0x151df6 */
l_0x00151de4:
    II(0x00151de4, 0x3)   pushw(memw_a16(ss, bp + 0x8));        /* push word [bp+0x8] */
    II(0x00151de7, 0x1)   pushw(ds);                            /* push ds */
    II(0x00151de8, 0x3)   pushw(0x3adc);                        /* push word 0x3adc */
    II(0x00151deb, 0x3)   pushw(memw_a16(ss, bp + 0x6));        /* push word [bp+0x6] */
    II(0x00151dee, 0x3)   pushw(memw_a16(ss, bp + 0x4));        /* push word [bp+0x4] */
//    II(0x00151df1, 0x1)   nop();                                /* nop  */
    II(0x00151df2, 0x1)   pushw(cs);                            /* push cs */
    II(0x00151df3, 0x3)   callw(0x00153278, 0x1482);            /* call 0x153278 */
l_0x00151df6:
    II(0x00151df6, 0x3)   add(sp, 0xa);                         /* add sp, 0xa */
    II(0x00151df9, 0x2)   jmpw(0x00151e0b, 0x10);               /* jmp 0x151e0b */
l_0x00151dfb:
    II(0x00151dfb, 0x2)   cmp(al, 0x61);                        /* cmp al, 0x61 */
    II(0x00151dfd, 0x2)   jlw(0x00151e08, 0x9);                 /* jl 0x151e08 */
    II(0x00151dff, 0x2)   cmp(al, 0x66);                        /* cmp al, 0x66 */
    II(0x00151e01, 0x2)   jgw(0x00151e08, 0x5);                 /* jg 0x151e08 */
    II(0x00151e03, 0x2)   sub(al, 0x20);                        /* sub al, 0x20 */
    II(0x00151e05, 0x3)   mov(memb_a16(es, bx), al);            /* mov [es:bx], al */
l_0x00151e08:
    II(0x00151e08, 0x3)   inc(memw_a16(ss, bp - 0x4));          /* inc word [bp-0x4] */
l_0x00151e0b:
    II(0x00151e0b, 0x3)   les(bx, ss, bp - 0x4);                /* les bx, [bp-0x4] */
    II(0x00151e0e, 0x3)   mov(al, memb_a16(es, bx));            /* mov al, [es:bx] */
    II(0x00151e11, 0x2)   or_(al, al);                          /* or al, al */
    II(0x00151e13, 0x2)   jnzw(0x00151dfb, -0x1a);              /* jnz 0x151dfb */
    II(0x00151e15, 0x2)   mov(ax, bx);                          /* mov ax, bx */
    II(0x00151e17, 0x3)   sub(ax, 0x3adc);                      /* sub ax, 0x3adc */
    II(0x00151e1a, 0x1)   leavew();                             /* leave  */
    II(0x00151e1b, 0x1)   retw();                               /* ret  */
FUNC_END

