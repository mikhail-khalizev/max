FUNC_BEGIN(0x0014fe65, 0xc4e9e0303e5407fc, 0x10, ({0xc8, 0, 0, 0, 0x66, 0xf, 0xb7, 0xc4, 0x2d, 0xc, 0x6, 0x25, 0xfc, 0xff, 0x66, 0xa3, 0x42, 0xa, 0x66, 0xa3, 0x46, 0xa, 0x1e, 0xb8, 0x80, 0xff, 0xba, 0x1, 0x13, 0x8c, 0xc9, 0x8e, 0xd9, 0x8e, 0xc1, 0xcd, 0x21, 0x1f, 0x33, 0xf6, 0xfa, 0xff, 0x76, 0x6, 0x56, 0x90, 0xe, 0xe8, 0x59, 0, 0xb, 0xc0, 0x5e, 0x58, 0xf, 0x84, 0x1a, 0, 0x46, 0x81, 0xfe, 0x20, 0x1, 0x72, 0xe8, 0xb8, 0x5, 0x2, 0xb3, 0xfc, 0x8c, 0xc9, 0x66, 0x2b, 0xd2, 0xba, 0x2e, 0xa, 0xcd, 0x31, 0xf, 0x83, 0x2, 0, 0x2b, 0xc0, 0xfb, 0x5d, 0xcb}))
    II(0x0014fe65, 0x4)   enterw(0, 0);                         /* enter 0x0, 0x0 */
    II(0x0014fe69, 0x4)   movzx(eax, sp);                       /* movzx eax, sp */
    II(0x0014fe6d, 0x3)   sub(ax, 0x60c);                       /* sub ax, 0x60c */
    II(0x0014fe70, 0x3)   and_(ax, 0xfffc);                     /* and ax, 0xfffc */
    II(0x0014fe73, 0x4)   mov(memd_a16(ds, 0xa42), eax);        /* mov [0xa42], eax */
    II(0x0014fe77, 0x4)   mov(memd_a16(ds, 0xa46), eax);        /* mov [0xa46], eax */
    II(0x0014fe7b, 0x1)   pushw(ds);                            /* push ds */
    II(0x0014fe7c, 0x3)   mov(ax, 0xff80);                      /* mov ax, 0xff80 */
    II(0x0014fe7f, 0x3)   mov(dx, 0x1301);                      /* mov dx, 0x1301 */
    II(0x0014fe82, 0x2)   mov(cx, cs);                          /* mov cx, cs */
    II(0x0014fe84, 0x2)   mov(ds, cx);                          /* mov ds, cx */
    II(0x0014fe86, 0x2)   mov(es, cx);                          /* mov es, cx */
    II(0x0014fe88, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x0014fe8a, 0x1)   popw(ds);                             /* pop ds */
    II(0x0014fe8b, 0x2)   xor_(si, si);                         /* xor si, si */
    II(0x0014fe8d, 0x1)   cli();                                /* cli  */
l_0x0014fe8e:
    II(0x0014fe8e, 0x3)   pushw(memw_a16(ss, bp + 0x6));        /* push word [bp+0x6] */
    II(0x0014fe91, 0x1)   pushw(si);                            /* push si */
//    II(0x0014fe92, 0x1)   nop();                                /* nop  */
    II(0x0014fe93, 0x1)   pushw(cs);                            /* push cs */
    II(0x0014fe94, 0x3)   callw(0x0014fef0, 0x59);              /* call 0x14fef0 */
    II(0x0014fe97, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x0014fe99, 0x1)   popw(si);                             /* pop si */
    II(0x0014fe9a, 0x1)   popw(ax);                             /* pop ax */
    II(0x0014fe9b, 0x4)   jzw(0x0014feb9, 0x1a);                /* jz word 0x14feb9 */
    II(0x0014fe9f, 0x1)   inc(si);                              /* inc si */
    II(0x0014fea0, 0x4)   cmp(si, 0x120);                       /* cmp si, 0x120 */
    II(0x0014fea4, 0x2)   jbw(0x0014fe8e, -0x18);               /* jb 0x14fe8e */
    II(0x0014fea6, 0x3)   mov(ax, 0x205);                       /* mov ax, 0x205 */
    II(0x0014fea9, 0x2)   mov(bl, 0xfc);                        /* mov bl, 0xfc */
    II(0x0014feab, 0x2)   mov(cx, cs);                          /* mov cx, cs */
    II(0x0014fead, 0x3)   sub(edx, edx);                        /* sub edx, edx */
    II(0x0014feb0, 0x3)   mov(dx, 0xa2e);                       /* mov dx, 0xa2e */
    II(0x0014feb3, 0x2)   int_(0x31);                           /* int 0x31 */
    II(0x0014feb5, 0x4)   jaew(0x0014febb, 0x2);                /* jae word 0x14febb */
l_0x0014feb9:
    II(0x0014feb9, 0x2)   sub(ax, ax);                          /* sub ax, ax */
l_0x0014febb:
    II(0x0014febb, 0x1)   sti();                                /* sti  */
    II(0x0014febc, 0x1)   popw(bp);                             /* pop bp */
    II(0x0014febd, 0x1)   retfw();                              /* retf  */
FUNC_END

