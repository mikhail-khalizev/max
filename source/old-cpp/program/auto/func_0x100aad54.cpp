FUNC_BEGIN(0x100aad54, 0xf5e5b0d1e78dd2df, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xf4, 0xaf, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x38, 0xf3, 0x8, 0, 0x89, 0x45, 0xfc, 0x8d, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100aad54, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100aad59, 0x5)   calld(sys_check_available_stack_size, 0xbaff4); /* call 0x10165d52 */
    II(0x100aad5e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100aad5f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100aad60, 0x1)   pushd(edx);                           /* push edx */
    II(0x100aad61, 0x1)   pushd(esi);                           /* push esi */
    II(0x100aad62, 0x1)   pushd(edi);                           /* push edi */
    II(0x100aad63, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100aad64, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100aad66, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100aad6c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100aad6f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100aad72, 0x5)   calld(0x1013a0af, 0x8f338);           /* call 0x1013a0af */
    II(0x100aad77, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100aad7a, 0x3)   lea(eax, ebp - 0x4);                  /* lea eax, [ebp-0x4] */
    II(0x100aad7d, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100aad80, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100aad83, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100aad86, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100aad89, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100aad8b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100aad8c, 0x1)   popd(edi);                            /* pop edi */
    II(0x100aad8d, 0x1)   popd(esi);                            /* pop esi */
    II(0x100aad8e, 0x1)   popd(edx);                            /* pop edx */
    II(0x100aad8f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100aad90, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100aad91, 0x1)   retd();                               /* ret */
FUNC_END

