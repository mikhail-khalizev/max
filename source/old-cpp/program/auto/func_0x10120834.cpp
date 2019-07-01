FUNC_BEGIN(0x10120834, 0xc47bcfb21da3a186, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x14, 0x55, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xd, 0x9b, 0x1, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10120834, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10120839, 0x5)   calld(sys_check_available_stack_size, 0x45514); /* call 0x10165d52 */
    II(0x1012083e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1012083f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10120840, 0x1)   pushd(esi);                           /* push esi */
    II(0x10120841, 0x1)   pushd(edi);                           /* push edi */
    II(0x10120842, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10120843, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10120845, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1012084b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1012084e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10120851, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x10120854, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10120857, 0x5)   calld(0x1013a369, 0x19b0d);           /* call 0x1013a369 */
    II(0x1012085c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1012085e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1012085f, 0x1)   popd(edi);                            /* pop edi */
    II(0x10120860, 0x1)   popd(esi);                            /* pop esi */
    II(0x10120861, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10120862, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10120863, 0x1)   retd();                               /* ret */
FUNC_END

