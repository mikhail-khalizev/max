FUNC_BEGIN(0x0000b078, 0xd1e3b6e20958028, 0x10, ({0x55, 0x8b, 0xec, 0x57, 0x56, 0xe8, 0, 0x88, 0x2e, 0x66, 0xf, 0xb7, 0xe, 0xf6, 0x79, 0xe3, 0x79, 0x66, 0xf, 0xb7, 0x36, 0xaa, 0, 0x6a, 0x38, 0x1f, 0x66, 0xc1, 0xe6, 0x4, 0x66, 0x8b, 0xfe, 0x66, 0x81, 0xc7, 0, 0x1c, 0, 0, 0x2e, 0x66, 0x8b, 0x16, 0xf8, 0x79, 0x67, 0x66, 0x87, 0x16, 0x83, 0xc6, 0x4, 0xf, 0x20, 0xd8, 0xf, 0x22, 0xd8, 0x67, 0x66, 0xad, 0x66, 0x8b, 0xd8, 0x67, 0x66, 0x87, 0x7, 0x67, 0x66, 0x89, 0x1d, 0, 0, 0x30, 0, 0x67, 0x66, 0x89, 0x7, 0x67, 0x66, 0x89, 0x56, 0xf8, 0xf, 0x20, 0xd8, 0xf, 0x22, 0xd8, 0x66, 0xbf, 0x4, 0, 0x40, 0, 0x1e, 0x7, 0x8b, 0xd9, 0x49, 0xf3, 0x67, 0x66, 0xa5, 0x8b, 0xcb, 0xc1, 0xe1, 0xa, 0x2b, 0xcb, 0x66, 0x33, 0xc0, 0xf3, 0x67, 0x66, 0xab, 0x16, 0x1f, 0x8b, 0xe, 0xfa, 0xd, 0xe3, 0x9, 0x66, 0xbe, 0, 0xf0, 0x3f, 0, 0xe8, 0xd7, 0, 0x66, 0xff, 0x76, 0x4, 0x66, 0xff, 0x36, 0x98, 0, 0x9a, 0xbb, 0x57, 0x70, 0, 0x83, 0xc4, 0x8, 0x50, 0xe8, 0x5, 0x8e, 0x58, 0x40, 0x5e, 0x5f, 0x2e, 0xc7, 0x6, 0xf6, 0x79, 0, 0, 0x5d, 0xc3}))
    II(0x0000b078, 0x1)   pushw(bp);                            /* push bp */
    II(0x0000b079, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0000b07b, 0x1)   pushw(di);                            /* push di */
    II(0x0000b07c, 0x1)   pushw(si);                            /* push si */
    II(0x0000b07d, 0x3)   callw(0x00003880, -0x7800);           /* call 0x3880 */
    II(0x0000b080, 0x7)   movzx(ecx, memw_a16(cs, 0x79f6));     /* movzx ecx, word [cs:0x79f6] */
    II(0x0000b087, 0x2)   jcxzw(0x0000b102, 0x79);              /* jcxz 0xb102 */
    II(0x0000b089, 0x6)   movzx(esi, memw_a16(ds, 0xaa));       /* movzx esi, word [0xaa] */
    II(0x0000b08f, 0x2)   pushw(0x38);                          /* push 0x38 */
    II(0x0000b091, 0x1)   popw(ds);                             /* pop ds */
    II(0x0000b092, 0x4)   shl(esi, 0x4);                        /* shl esi, 0x4 */
    II(0x0000b096, 0x3)   mov(edi, esi);                        /* mov edi, esi */
    II(0x0000b099, 0x7)   add(edi, 0x1c00);                     /* add edi, 0x1c00 */
    II(0x0000b0a0, 0x6)   mov(edx, memd_a16(cs, 0x79f8));       /* mov edx, [cs:0x79f8] */
    II(0x0000b0a6, 0x4)   xchg(memd_a32(ds, esi), edx);         /* xchg [esi], edx */
    II(0x0000b0aa, 0x3)   add(si, 0x4);                         /* add si, 0x4 */
    II(0x0000b0ad, 0x3)   mov(eax, cr3);                        /* mov eax, cr3 */
//    II(0x0000b0b0, 0x3)   mov(cr3, eax);                        /* mov cr3, eax */
    II(0x0000b0b3, 0x3)   lodsd_a32();                          /* a32 lodsd  */
    II(0x0000b0b6, 0x3)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x0000b0b9, 0x4)   xchg(memd_a32(ds, edi), eax);         /* xchg [edi], eax */
    II(0x0000b0bd, 0x8)   mov(memd_a32(ds, 0x300000), ebx);     /* mov [0x300000], ebx */
    II(0x0000b0c5, 0x4)   mov(memd_a32(ds, edi), eax);          /* mov [edi], eax */
    II(0x0000b0c9, 0x5)   mov(memd_a32(ds, esi - 0x8), edx);    /* mov [esi-0x8], edx */
    II(0x0000b0ce, 0x3)   mov(eax, cr3);                        /* mov eax, cr3 */
//    II(0x0000b0d1, 0x3)   mov(cr3, eax);                        /* mov cr3, eax */
    II(0x0000b0d4, 0x6)   mov(edi, 0x400004);                   /* mov edi, 0x400004 */
    II(0x0000b0da, 0x1)   pushw(ds);                            /* push ds */
    II(0x0000b0db, 0x1)   popw(es);                             /* pop es */
    II(0x0000b0dc, 0x2)   mov(bx, cx);                          /* mov bx, cx */
    II(0x0000b0de, 0x1)   dec(cx);                              /* dec cx */
    II(0x0000b0df, 0x4)   rep_a32 movsd_a32();                  /* a32 rep movsd  */
    II(0x0000b0e3, 0x2)   mov(cx, bx);                          /* mov cx, bx */
    II(0x0000b0e5, 0x3)   shl(cx, 0xa);                         /* shl cx, 0xa */
    II(0x0000b0e8, 0x2)   sub(cx, bx);                          /* sub cx, bx */
    II(0x0000b0ea, 0x3)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x0000b0ed, 0x4)   rep_a32 stosd_a32();                  /* a32 rep stosd  */
    II(0x0000b0f1, 0x1)   pushw(ss);                            /* push ss */
    II(0x0000b0f2, 0x1)   popw(ds);                             /* pop ds */
    II(0x0000b0f3, 0x4)   mov(cx, memw_a16(ds, 0xdfa));         /* mov cx, [0xdfa] */
    II(0x0000b0f7, 0x2)   jcxzw(0x0000b102, 0x9);               /* jcxz 0xb102 */
    II(0x0000b0f9, 0x6)   mov(esi, 0x3ff000);                   /* mov esi, 0x3ff000 */
    II(0x0000b0ff, 0x3)   callw(0x0000b1d9, 0xd7);              /* call 0xb1d9 */
l_0x0000b102:
    II(0x0000b102, 0x4)   pushd(memd_a16(ss, bp + 0x4));        /* push dword [bp+0x4] */
    II(0x0000b106, 0x5)   pushd(memd_a16(ds, 0x98));            /* push dword [0x98] */
    II(0x0000b10b, 0x5)   callw_far_abs(0x70, 0x57bb);          /* call word 0x70:0x57bb */
    II(0x0000b110, 0x3)   add(sp, 0x8);                         /* add sp, 0x8 */
    II(0x0000b113, 0x1)   pushw(ax);                            /* push ax */
    II(0x0000b114, 0x3)   callw(0x00003f1c, -0x71fb);           /* call 0x3f1c */
    II(0x0000b117, 0x1)   popw(ax);                             /* pop ax */
    II(0x0000b118, 0x1)   inc(ax);                              /* inc ax */
    II(0x0000b119, 0x1)   popw(si);                             /* pop si */
    II(0x0000b11a, 0x1)   popw(di);                             /* pop di */
    II(0x0000b11b, 0x7)   mov(memw_a16(cs, 0x79f6), 0);         /* mov word [cs:0x79f6], 0x0 */
    II(0x0000b122, 0x1)   popw(bp);                             /* pop bp */
    II(0x0000b123, 0x1)   retw();                               /* ret  */
FUNC_END

