FUNC_BEGIN(0x100aa030, 0xa43a6192e0e604a4, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x18, 0xbd, 0xb, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf8, 0xe8, 0x64, 0x1, 0x9, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100aa030, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100aa035, 0x5)   calld(sys_check_available_stack_size, 0xbbd18); /* call 0x10165d52 */
    II(0x100aa03a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100aa03b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100aa03c, 0x1)   pushd(esi);                           /* push esi */
    II(0x100aa03d, 0x1)   pushd(edi);                           /* push edi */
    II(0x100aa03e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100aa03f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100aa041, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100aa047, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100aa04a, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100aa04d, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
//    II(0x100aa052, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100aa055, 0x5)   calld(0x1013a1be, 0x90164);           /* call 0x1013a1be */
    II(0x100aa05a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100aa05d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100aa060, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100aa063, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100aa066, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100aa068, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100aa069, 0x1)   popd(edi);                            /* pop edi */
    II(0x100aa06a, 0x1)   popd(esi);                            /* pop esi */
    II(0x100aa06b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100aa06c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100aa06d, 0x1)   retd();                               /* ret */
FUNC_END

