FUNC_BEGIN(0x1009b874, 0x15d3a151a303970a, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xd4, 0xa4, 0xc, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x1b, 0xe8, 0x8e, 0xa6, 0xfd, 0xff, 0x83, 0xe8, 0x1b, 0x89, 0x45, 0xf8, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x17, 0xe8, 0x7b, 0xa6, 0xfd, 0xff, 0x83, 0xe8, 0x17, 0x89, 0x45, 0xf8, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x13, 0xe8, 0x68, 0xa6, 0xfd, 0xff, 0x83, 0xe8, 0x13, 0x89, 0x45, 0xf8, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf8, 0xe8, 0x75, 0x6f, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1009b874, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1009b879, 0x5)   calld(sys_check_available_stack_size, 0xca4d4); /* call 0x10165d52 */
    II(0x1009b87e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009b87f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009b880, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009b881, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009b882, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009b883, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009b885, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1009b88b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1009b88e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1009b891, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1009b893, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009b896, 0x3)   add(eax, 0x1b);                       /* add eax, 0x1b */
    II(0x1009b899, 0x5)   calld(0x10075f2c, -0x25972);          /* call 0x10075f2c */
    II(0x1009b89e, 0x3)   sub(eax, 0x1b);                       /* sub eax, 0x1b */
    II(0x1009b8a1, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1009b8a4, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1009b8a6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009b8a9, 0x3)   add(eax, 0x17);                       /* add eax, 0x17 */
    II(0x1009b8ac, 0x5)   calld(0x10075f2c, -0x25985);          /* call 0x10075f2c */
    II(0x1009b8b1, 0x3)   sub(eax, 0x17);                       /* sub eax, 0x17 */
    II(0x1009b8b4, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1009b8b7, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1009b8b9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009b8bc, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x1009b8bf, 0x5)   calld(0x10075f2c, -0x25998);          /* call 0x10075f2c */
    II(0x1009b8c4, 0x3)   sub(eax, 0x13);                       /* sub eax, 0x13 */
    II(0x1009b8c7, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1009b8ca, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
//    II(0x1009b8cf, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009b8d2, 0x5)   calld(0x100a284c, 0x6f75);            /* call 0x100a284c */
    II(0x1009b8d7, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1009b8da, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009b8dd, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1009b8e0, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1009b8e3, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009b8e5, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009b8e6, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009b8e7, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009b8e8, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009b8e9, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009b8ea, 0x1)   retd();                               /* ret */
FUNC_END

