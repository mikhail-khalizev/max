FUNC_BEGIN(0x10106a64, 0xd77cb1b6ca0d0d12, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xe4, 0xf2, 0x5, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xbb, 0x4, 0, 0, 0, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xf5, 0x4f, 0x3, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10106a64, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10106a69, 0x5)   calld(sys_check_available_stack_size, 0x5f2e4); /* call 0x10165d52 */
    II(0x10106a6e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10106a6f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10106a70, 0x1)   pushd(esi);                           /* push esi */
    II(0x10106a71, 0x1)   pushd(edi);                           /* push edi */
    II(0x10106a72, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10106a73, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10106a75, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10106a7b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10106a7e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10106a81, 0x5)   mov(ebx, 0x4);                        /* mov ebx, 0x4 */
//    II(0x10106a86, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x10106a89, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10106a8c, 0x5)   calld(0x1013ba86, 0x34ff5);           /* call 0x1013ba86 */
    II(0x10106a91, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10106a93, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10106a94, 0x1)   popd(edi);                            /* pop edi */
    II(0x10106a95, 0x1)   popd(esi);                            /* pop esi */
    II(0x10106a96, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10106a97, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10106a98, 0x1)   retd();                               /* ret */
FUNC_END

