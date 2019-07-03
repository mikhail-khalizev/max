FUNC_BEGIN(0x1008ab1c, 0x923743a652850624, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x2c, 0xb2, 0xd, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x67, 0xf7, 0xa, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1008ab1c, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1008ab21, 0x5)   calld(sys_check_available_stack_size, 0xdb22c); /* call 0x10165d52 */
    II(0x1008ab26, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008ab27, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008ab28, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008ab29, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008ab2a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008ab2b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008ab2d, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1008ab33, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1008ab36, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x1008ab39, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x1008ab3c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008ab3f, 0x5)   calld(0x1013a2ab, 0xaf767);           /* call 0x1013a2ab */
    II(0x1008ab44, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008ab46, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008ab47, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008ab48, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008ab49, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008ab4a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008ab4b, 0x1)   retd();                               /* ret */
FUNC_END

