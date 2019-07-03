FUNC_BEGIN(0x1013b842, 0x9e6cf0a009628489, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x6, 0xa5, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x6, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013b842, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1013b847, 0x5)   calld(sys_check_available_stack_size, 0x2a506); /* call 0x10165d52 */
    II(0x1013b84c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013b84d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013b84e, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013b84f, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013b850, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013b851, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013b853, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1013b859, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013b85c, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1013b85f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013b862, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x1013b865, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1013b868, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1013b86b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013b86d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013b86e, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013b86f, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013b870, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013b871, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013b872, 0x1)   retd();                               /* ret */
FUNC_END

