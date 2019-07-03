FUNC_BEGIN(0x100b06a7, 0xe69c560030966bb1, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xa1, 0x56, 0xb, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0xe8, 0x8, 0, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100b06a7, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b06ac, 0x5)   calld(sys_check_available_stack_size, 0xb56a1); /* call 0x10165d52 */
    II(0x100b06b1, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b06b2, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b06b3, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b06b4, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b06b5, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b06b6, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b06b8, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100b06be, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100b06c1, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100b06c4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b06c7, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100b06ca, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b06cd, 0x5)   calld(0x100b06da, 0x8);               /* call 0x100b06da */
    II(0x100b06d2, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b06d4, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b06d5, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b06d6, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b06d7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b06d8, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b06d9, 0x1)   retd();                               /* ret */
FUNC_END

