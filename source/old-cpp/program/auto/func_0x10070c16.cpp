FUNC_BEGIN(0x10070c16, 0x5d01aba8f498d5dd, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x32, 0x51, 0xf, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xf8, 0xf, 0xaf, 0x55, 0xf8, 0x8b, 0x45, 0xfc, 0xf, 0xaf, 0x45, 0xfc, 0x1, 0xc2, 0x89, 0x55, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10070c16, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10070c1b, 0x5)   calld(sys_check_available_stack_size, 0xf5132); /* call 0x10165d52 */
    II(0x10070c20, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10070c21, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10070c22, 0x1)   pushd(esi);                           /* push esi */
    II(0x10070c23, 0x1)   pushd(edi);                           /* push edi */
    II(0x10070c24, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10070c25, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10070c27, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10070c2d, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10070c30, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10070c33, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x10070c36, 0x4)   imul(edx, memd_a32(ss, ebp - 0x8));   /* imul edx, [ebp-0x8] */
    II(0x10070c3a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10070c3d, 0x4)   imul(eax, memd_a32(ss, ebp - 0x4));   /* imul eax, [ebp-0x4] */
    II(0x10070c41, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x10070c43, 0x3)   mov(memd_a32(ss, ebp - 0xc), edx);    /* mov [ebp-0xc], edx */
    II(0x10070c46, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10070c49, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10070c4b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10070c4c, 0x1)   popd(edi);                            /* pop edi */
    II(0x10070c4d, 0x1)   popd(esi);                            /* pop esi */
    II(0x10070c4e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10070c4f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10070c50, 0x1)   retd();                               /* ret */
FUNC_END

