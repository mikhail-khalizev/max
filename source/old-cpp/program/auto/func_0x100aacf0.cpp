FUNC_BEGIN(0x100aacf0, 0x5eb8f27ecd136ac1, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x58, 0xb0, 0xb, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x93, 0xf5, 0x8, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100aacf0, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100aacf5, 0x5)   calld(sys_check_available_stack_size, 0xbb058); /* call 0x10165d52 */
    II(0x100aacfa, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100aacfb, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100aacfc, 0x1)   pushd(esi);                           /* push esi */
    II(0x100aacfd, 0x1)   pushd(edi);                           /* push edi */
    II(0x100aacfe, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100aacff, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100aad01, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100aad07, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100aad0a, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100aad0d, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x100aad10, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100aad13, 0x5)   calld(0x1013a2ab, 0x8f593);           /* call 0x1013a2ab */
    II(0x100aad18, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100aad1a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100aad1b, 0x1)   popd(edi);                            /* pop edi */
    II(0x100aad1c, 0x1)   popd(esi);                            /* pop esi */
    II(0x100aad1d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100aad1e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100aad1f, 0x1)   retd();                               /* ret */
FUNC_END

