FUNC_BEGIN(0x1012b7dc, 0xb7a955b3760fafc2, 0x20, ({0x68, 0x38, 0, 0, 0, 0xe8, 0x6c, 0xa5, 0x3, 0, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf0, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xfc, 0x89, 0x4d, 0xf4, 0x8b, 0x45, 0x10, 0x5, 0x10, 0, 0, 0, 0x98, 0x50, 0x8b, 0x45, 0xf4, 0x5, 0x10, 0, 0, 0, 0x98, 0x50, 0x31, 0xc0, 0xa0, 0xda, 0x37, 0x1c, 0x10, 0xf, 0xbf, 0xc8, 0xf, 0xbf, 0x5d, 0xfc, 0xf, 0xbf, 0x55, 0xf8, 0x8b, 0x45, 0xf0, 0xe8, 0x84, 0xfe, 0xff, 0xff, 0xe8, 0xec, 0x9a, 0xfa, 0xff, 0x25, 0xff, 0, 0, 0, 0x50, 0x31, 0xc0, 0x50, 0xf, 0xbf, 0x45, 0x18, 0x50, 0xb8, 0x20, 0, 0, 0, 0x50, 0x8b, 0x45, 0x14, 0x83, 0xe8, 0x23, 0x98, 0x50, 0xf, 0xbf, 0x45, 0x10, 0x50, 0x8b, 0x45, 0xf4, 0x5, 0x23, 0, 0, 0, 0xf, 0xbf, 0xc8, 0xf, 0xbf, 0x5d, 0xfc, 0x6b, 0xdb, 0x33, 0x8b, 0x9b, 0xd7, 0x81, 0x1c, 0x10, 0xf, 0xbf, 0x55, 0xf8, 0x8b, 0x45, 0xf0, 0xe8, 0x70, 0xe2, 0xfb, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0xc2, 0xc, 0}))
    II(0x1012b7dc, 0x5)   pushd(0x38);                          /* push dword 0x38 */
    II(0x1012b7e1, 0x5)   calld(sys_check_available_stack_size, 0x3a56c); /* call 0x10165d52 */
    II(0x1012b7e6, 0x1)   pushd(esi);                           /* push esi */
    II(0x1012b7e7, 0x1)   pushd(edi);                           /* push edi */
    II(0x1012b7e8, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1012b7e9, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1012b7eb, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x1012b7f1, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x1012b7f4, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x1012b7f7, 0x3)   mov(memd_a32(ss, ebp - 0x4), ebx);    /* mov [ebp-0x4], ebx */
    II(0x1012b7fa, 0x3)   mov(memd_a32(ss, ebp - 0xc), ecx);    /* mov [ebp-0xc], ecx */
    II(0x1012b7fd, 0x3)   mov(eax, memd_a32(ss, ebp + 0x10));   /* mov eax, [ebp+0x10] */
    II(0x1012b800, 0x5)   add(eax, 0x10);                       /* add eax, 0x10 */
    II(0x1012b805, 0x1)   cwde();                               /* cwde */
    II(0x1012b806, 0x1)   pushd(eax);                           /* push eax */
    II(0x1012b807, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1012b80a, 0x5)   add(eax, 0x10);                       /* add eax, 0x10 */
    II(0x1012b80f, 0x1)   cwde();                               /* cwde */
    II(0x1012b810, 0x1)   pushd(eax);                           /* push eax */
    II(0x1012b811, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1012b813, 0x5)   mov(al, memb_a32(ds, 0x101c37da));    /* mov al, [0x101c37da] */
    II(0x1012b818, 0x3)   movsx(ecx, ax);                       /* movsx ecx, ax */
    II(0x1012b81b, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x4));  /* movsx ebx, word [ebp-0x4] */
    II(0x1012b81f, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x8));  /* movsx edx, word [ebp-0x8] */
    II(0x1012b823, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x1012b826, 0x5)   calld(0x1012b6af, -0x17c);            /* call 0x1012b6af */
    II(0x1012b82b, 0x5)   calld(0x100d531c, -0x56514);          /* call 0x100d531c */
    II(0x1012b830, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x1012b835, 0x1)   pushd(eax);                           /* push eax */
    II(0x1012b836, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1012b838, 0x1)   pushd(eax);                           /* push eax */
    II(0x1012b839, 0x4)   movsx(eax, memw_a32(ss, ebp + 0x18)); /* movsx eax, word [ebp+0x18] */
    II(0x1012b83d, 0x1)   pushd(eax);                           /* push eax */
    II(0x1012b83e, 0x5)   mov(eax, 0x20);                       /* mov eax, 0x20 */
    II(0x1012b843, 0x1)   pushd(eax);                           /* push eax */
    II(0x1012b844, 0x3)   mov(eax, memd_a32(ss, ebp + 0x14));   /* mov eax, [ebp+0x14] */
    II(0x1012b847, 0x3)   sub(eax, 0x23);                       /* sub eax, 0x23 */
    II(0x1012b84a, 0x1)   cwde();                               /* cwde */
    II(0x1012b84b, 0x1)   pushd(eax);                           /* push eax */
    II(0x1012b84c, 0x4)   movsx(eax, memw_a32(ss, ebp + 0x10)); /* movsx eax, word [ebp+0x10] */
    II(0x1012b850, 0x1)   pushd(eax);                           /* push eax */
    II(0x1012b851, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1012b854, 0x5)   add(eax, 0x23);                       /* add eax, 0x23 */
    II(0x1012b859, 0x3)   movsx(ecx, ax);                       /* movsx ecx, ax */
    II(0x1012b85c, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x4));  /* movsx ebx, word [ebp-0x4] */
    II(0x1012b860, 0x3)   imul(ebx, ebx, 0x33);                 /* imul ebx, ebx, 0x33 */
    II(0x1012b863, 0x6)   mov(ebx, memd_a32(ds, ebx + 0x101c81d7)); /* mov ebx, [ebx+0x101c81d7] */
    II(0x1012b869, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x8));  /* movsx edx, word [ebp-0x8] */
    II(0x1012b86d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x1012b870, 0x5)   calld(0x100e9ae5, -0x41d90);          /* call 0x100e9ae5 */
    II(0x1012b875, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1012b877, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1012b878, 0x1)   popd(edi);                            /* pop edi */
    II(0x1012b879, 0x1)   popd(esi);                            /* pop esi */
    II(0x1012b87a, 0x3)   retd(0xc);                            /* ret 0xc */
FUNC_END

