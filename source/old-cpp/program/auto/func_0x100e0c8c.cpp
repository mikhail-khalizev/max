FUNC_BEGIN(0x100e0c8c, 0xd8e08ff1a1bc106e, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xbc, 0x50, 0x8, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xfc, 0x8b, 0x5d, 0xfc, 0x8b, 0x55, 0xf8, 0x8b, 0x45, 0xf4, 0xe8, 0x6e, 0x97, 0x5, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x100e0c8c, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100e0c91, 0x5)   calld(sys_check_available_stack_size, 0x850bc); /* call 0x10165d52 */
    II(0x100e0c96, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e0c97, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e0c98, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e0c99, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e0c9a, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e0c9c, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100e0ca2, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100e0ca5, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x100e0ca8, 0x3)   mov(memd_a32(ss, ebp - 0x4), ebx);    /* mov [ebp-0x4], ebx */
//    II(0x100e0cab, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x4));    /* mov ebx, [ebp-0x4] */
//    II(0x100e0cae, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
//    II(0x100e0cb1, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100e0cb4, 0x5)   calld(0x1013a427, 0x5976e);           /* call 0x1013a427 */
    II(0x100e0cb9, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e0cbb, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e0cbc, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e0cbd, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e0cbe, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e0cbf, 0x1)   retd();                               /* ret */
FUNC_END

