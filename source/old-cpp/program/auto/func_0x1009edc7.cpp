FUNC_BEGIN(0x1009edc7, 0xbf1c8e115765217d, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x81, 0x6f, 0xc, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x6, 0xc1, 0xf8, 0x10, 0x3, 0x45, 0xf8, 0xc6, 0x40, 0x23, 0, 0xe8, 0xa3, 0xb9, 0xfe, 0xff, 0x31, 0xdb, 0x88, 0xc3, 0x8b, 0x55, 0xfc, 0xb8, 0x80, 0x31, 0x1c, 0x10, 0xe8, 0xa2, 0x65, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1009edc7, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1009edcc, 0x5)   calld(sys_check_available_stack_size, 0xc6f81); /* call 0x10165d52 */
    II(0x1009edd1, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009edd2, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009edd3, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009edd4, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009edd5, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009edd6, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009edd8, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1009edde, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1009ede1, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1009ede4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009ede7, 0x3)   mov(eax, memd_a32(ds, eax + 0x6));    /* mov eax, [eax+0x6] */
    II(0x1009edea, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1009eded, 0x3)   add(eax, memd_a32(ss, ebp - 0x8));    /* add eax, [ebp-0x8] */
    II(0x1009edf0, 0x4)   mov(memb_a32(ds, eax + 0x23), 0);     /* mov byte [eax+0x23], 0x0 */
    II(0x1009edf4, 0x5)   calld(0x1008a79c, -0x1465d);          /* call 0x1008a79c */
    II(0x1009edf9, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1009edfb, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x1009edfd, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1009ee00, 0x5)   mov(eax, 0x101c3180);                 /* mov eax, 0x101c3180 */
    II(0x1009ee05, 0x5)   calld(0x100a53ac, 0x65a2);            /* call 0x100a53ac */
    II(0x1009ee0a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009ee0c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009ee0d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009ee0e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009ee0f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009ee10, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009ee11, 0x1)   retd();                               /* ret */
FUNC_END

