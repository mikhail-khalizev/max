FUNC_BEGIN(0x100ca974, 0xe84ac7efaf0567f, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xd4, 0xb3, 0x9, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf, 0xbf, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xb5, 0x6, 0x7, 0, 0x89, 0x45, 0xf8, 0x8d, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100ca974, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100ca979, 0x5)   calld(sys_check_available_stack_size, 0x9b3d4); /* call 0x10165d52 */
    II(0x100ca97e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ca97f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ca980, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ca981, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ca982, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ca983, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ca985, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x100ca98b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100ca98e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100ca991, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x4));  /* movsx edx, word [ebp-0x4] */
    II(0x100ca995, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ca998, 0x5)   calld(0x1013b052, 0x706b5);           /* call 0x1013b052 */
    II(0x100ca99d, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100ca9a0, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x100ca9a3, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100ca9a6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ca9a9, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x100ca9ac, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100ca9af, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ca9b1, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ca9b2, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ca9b3, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ca9b4, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ca9b5, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ca9b6, 0x1)   retd();                               /* ret */
FUNC_END

