FUNC_BEGIN(0x100ca894, 0xf9e2680ee349aa85, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xb4, 0xb4, 0x9, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xc1, 0x3, 0x7, 0, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100ca894, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100ca899, 0x5)   calld(sys_check_available_stack_size, 0x9b4b4); /* call 0x10165d52 */
    II(0x100ca89e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ca89f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ca8a0, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ca8a1, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ca8a2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ca8a3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ca8a5, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100ca8ab, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100ca8ae, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100ca8b1, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x100ca8b4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ca8b7, 0x5)   calld(0x1013ac7d, 0x703c1);           /* call 0x1013ac7d */
    II(0x100ca8bc, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100ca8bf, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100ca8c2, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ca8c4, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ca8c5, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ca8c6, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ca8c7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ca8c8, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ca8c9, 0x1)   retd();                               /* ret */
FUNC_END

