FUNC_BEGIN(0x100a2b98, 0x8bca3c903c5e946a, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xb0, 0x31, 0xc, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xc6, 0x45, 0xf4, 0, 0x8a, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100a2b98, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100a2b9d, 0x5)   calld(sys_check_available_stack_size, 0xc31b0); /* call 0x10165d52 */
    II(0x100a2ba2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a2ba3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a2ba4, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a2ba5, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a2ba6, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a2ba7, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a2ba9, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100a2baf, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100a2bb2, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100a2bb5, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
    II(0x100a2bb9, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x100a2bbc, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a2bbe, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a2bbf, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a2bc0, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a2bc1, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a2bc2, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a2bc3, 0x1)   retd();                               /* ret */
FUNC_END

