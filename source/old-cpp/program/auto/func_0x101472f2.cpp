FUNC_BEGIN(0x101472f2, 0x6e89a782a14d5ef, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x56, 0xea, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x61, 0x4b, 0xff, 0xff, 0x89, 0x45, 0xfc, 0x8d, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101472f2, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x101472f7, 0x5)   calld(sys_check_available_stack_size, 0x1ea56); /* call 0x10165d52 */
    II(0x101472fc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101472fd, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101472fe, 0x1)   pushd(edx);                           /* push edx */
    II(0x101472ff, 0x1)   pushd(esi);                           /* push esi */
    II(0x10147300, 0x1)   pushd(edi);                           /* push edi */
    II(0x10147301, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10147302, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10147304, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1014730a, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1014730d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10147310, 0x5)   calld(0x1013be76, -0xb49f);           /* call 0x1013be76 */
    II(0x10147315, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10147318, 0x3)   lea(eax, ebp - 0x4);                  /* lea eax, [ebp-0x4] */
    II(0x1014731b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1014731e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10147321, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x10147324, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10147327, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10147329, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1014732a, 0x1)   popd(edi);                            /* pop edi */
    II(0x1014732b, 0x1)   popd(esi);                            /* pop esi */
    II(0x1014732c, 0x1)   popd(edx);                            /* pop edx */
    II(0x1014732d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1014732e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1014732f, 0x1)   retd();                               /* ret */
FUNC_END

