FUNC_BEGIN(0x10104828, 0xa77cfae0c4dae3b6, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x20, 0x15, 0x6, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x6, 0xe8, 0xc9, 0x62, 0xf8, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10104828, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1010482d, 0x5)   calld(sys_check_available_stack_size, 0x61520); /* call 0x10165d52 */
    II(0x10104832, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10104833, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10104834, 0x1)   pushd(esi);                           /* push esi */
    II(0x10104835, 0x1)   pushd(edi);                           /* push edi */
    II(0x10104836, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10104837, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10104839, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1010483f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10104842, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10104845, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x10104848, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1010484b, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x1010484e, 0x5)   calld(0x1008ab1c, -0x79d37);          /* call 0x1008ab1c */
    II(0x10104853, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10104855, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10104856, 0x1)   popd(edi);                            /* pop edi */
    II(0x10104857, 0x1)   popd(esi);                            /* pop esi */
    II(0x10104858, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10104859, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1010485a, 0x1)   retd();                               /* ret */
FUNC_END

