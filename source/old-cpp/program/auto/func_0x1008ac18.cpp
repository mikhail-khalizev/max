FUNC_BEGIN(0x1008ac18, 0xc1b156ecede5c386, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x30, 0xb1, 0xd, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x85, 0, 0xb, 0, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1008ac18, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1008ac1d, 0x5)   calld(sys_check_available_stack_size, 0xdb130); /* call 0x10165d52 */
    II(0x1008ac22, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008ac23, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008ac24, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008ac25, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008ac26, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008ac27, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008ac29, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1008ac2f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1008ac32, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x1008ac35, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x1008ac38, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008ac3b, 0x5)   calld(0x1013acc5, 0xb0085);           /* call 0x1013acc5 */
    II(0x1008ac40, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1008ac43, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1008ac46, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008ac48, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008ac49, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008ac4a, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008ac4b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008ac4c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008ac4d, 0x1)   retd();                               /* ret */
FUNC_END

