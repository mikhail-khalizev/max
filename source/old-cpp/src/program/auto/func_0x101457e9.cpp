FUNC_BEGIN(0x101457e9, 0x16014e2b71dd6a73, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x5f, 0x5, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x72, 0x24, 0, 0, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x101457e9, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x101457ee, 0x5)   calld(sys_check_available_stack_size, 0x2055f); /* call 0x10165d52 */
    II(0x101457f3, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101457f4, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101457f5, 0x1)   pushd(esi);                           /* push esi */
    II(0x101457f6, 0x1)   pushd(edi);                           /* push edi */
    II(0x101457f7, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101457f8, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101457fa, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10145800, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10145803, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10145806, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10145809, 0x5)   calld(0x10147c80, 0x2472);            /* call 0x10147c80 */
    II(0x1014580e, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x10145811, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10145814, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10145816, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10145817, 0x1)   popd(edi);                            /* pop edi */
    II(0x10145818, 0x1)   popd(esi);                            /* pop esi */
    II(0x10145819, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1014581a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1014581b, 0x1)   retd();                               /* ret */
FUNC_END

