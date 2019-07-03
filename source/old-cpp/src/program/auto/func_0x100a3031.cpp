FUNC_BEGIN(0x100a3031, 0x79b4d60c7486cc17, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x17, 0x2d, 0xc, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x100a3031, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100a3036, 0x5)   calld(sys_check_available_stack_size, 0xc2d17); /* call 0x10165d52 */
    II(0x100a303b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a303c, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a303d, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a303e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a303f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a3041, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100a3047, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100a304a, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x100a304d, 0x3)   mov(memd_a32(ss, ebp - 0x4), ebx);    /* mov [ebp-0x4], ebx */
    II(0x100a3050, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a3052, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a3053, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a3054, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a3055, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a3056, 0x1)   retd();                               /* ret */
FUNC_END

