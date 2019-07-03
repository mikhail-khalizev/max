FUNC_BEGIN(0x1008a728, 0x9a2f7c3eb7a1607f, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x20, 0xb6, 0xd, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf, 0xbf, 0x45, 0xfc, 0xc1, 0xe0, 0x2, 0x89, 0xc2, 0x8b, 0x45, 0xf8, 0x8b, 0, 0x1, 0xd0, 0x8b, 0, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1008a728, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1008a72d, 0x5)   calld(sys_check_available_stack_size, 0xdb620); /* call 0x10165d52 */
    II(0x1008a732, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008a733, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008a734, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008a735, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008a736, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008a737, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008a739, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1008a73f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1008a742, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1008a745, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x1008a749, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
    II(0x1008a74c, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1008a74e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008a751, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1008a753, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x1008a755, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1008a757, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1008a75a, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1008a75d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008a75f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008a760, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008a761, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008a762, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008a763, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008a764, 0x1)   retd();                               /* ret */
FUNC_END

