FUNC_BEGIN(0x0000f957, 0x138b93d0f3dabd23, 0x10, ({0x60, 0x1e, 0x6, 0x80, 0x3e, 0x2f, 0, 0x3, 0x72, 0x30, 0xb4, 0xff, 0xb6, 0x4f, 0x33, 0xc9, 0xcd, 0x21, 0xe3, 0x26, 0x66, 0xf, 0xb7, 0xc0, 0x66, 0xc1, 0xe2, 0x10, 0x66, 0xb, 0xc2, 0x8b, 0x1e, 0x96, 0x15, 0xc1, 0xe3, 0x2, 0x81, 0xc3, 0x98, 0x15, 0x66, 0x89, 0x7, 0x66, 0x83, 0xc0, 0x4, 0x83, 0xc3, 0x4, 0xff, 0x6, 0x96, 0x15, 0xe2, 0xf0, 0x7, 0x1f, 0x61, 0xc3}))
    II(0x0000f957, 0x1)   pusha();                              /* pusha  */
    II(0x0000f958, 0x1)   pushw(ds);                            /* push ds */
    II(0x0000f959, 0x1)   pushw(es);                            /* push es */
    II(0x0000f95a, 0x5)   cmp(memb_a16(ds, 0x2f), 0x3);         /* cmp byte [0x2f], 0x3 */
    II(0x0000f95f, 0x2)   jbw(0x0000f991, 0x30);                /* jb 0xf991 */
    II(0x0000f961, 0x2)   mov(ah, 0xff);                        /* mov ah, 0xff */
    II(0x0000f963, 0x2)   mov(dh, 0x4f);                        /* mov dh, 0x4f */
    II(0x0000f965, 0x2)   xor_(cx, cx);                         /* xor cx, cx */
    II(0x0000f967, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x0000f969, 0x2)   jcxzw(0x0000f991, 0x26);              /* jcxz 0xf991 */
    II(0x0000f96b, 0x4)   movzx(eax, ax);                       /* movzx eax, ax */
    II(0x0000f96f, 0x4)   shl(edx, 0x10);                       /* shl edx, 0x10 */
    II(0x0000f973, 0x3)   or_(eax, edx);                        /* or eax, edx */
    II(0x0000f976, 0x4)   mov(bx, memw_a16(ds, 0x1596));        /* mov bx, [0x1596] */
    II(0x0000f97a, 0x3)   shl(bx, 0x2);                         /* shl bx, 0x2 */
    II(0x0000f97d, 0x4)   add(bx, 0x1598);                      /* add bx, 0x1598 */
l_0x0000f981:
    II(0x0000f981, 0x3)   mov(memd_a16(ds, bx), eax);           /* mov [bx], eax */
    II(0x0000f984, 0x4)   add(eax, 0x4);                        /* add eax, 0x4 */
    II(0x0000f988, 0x3)   add(bx, 0x4);                         /* add bx, 0x4 */
    II(0x0000f98b, 0x4)   inc(memw_a16(ds, 0x1596));            /* inc word [0x1596] */
    II(0x0000f98f, 0x2)   loopw_a16(0x0000f981, -0x10);         /* loop 0xf981 */
l_0x0000f991:
    II(0x0000f991, 0x1)   popw(es);                             /* pop es */
    II(0x0000f992, 0x1)   popw(ds);                             /* pop ds */
    II(0x0000f993, 0x1)   popa();                               /* popa  */
    II(0x0000f994, 0x1)   retw();                               /* ret  */
FUNC_END

