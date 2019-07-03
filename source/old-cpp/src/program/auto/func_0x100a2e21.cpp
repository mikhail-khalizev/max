FUNC_BEGIN(0x100a2e21, 0x8e38e414e75c5dd5, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x27, 0x2f, 0xc, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xc6, 0x45, 0xf4, 0, 0x8a, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100a2e21, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100a2e26, 0x5)   calld(sys_check_available_stack_size, 0xc2f27); /* call 0x10165d52 */
    II(0x100a2e2b, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a2e2c, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a2e2d, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a2e2e, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a2e2f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a2e30, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a2e32, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100a2e38, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100a2e3b, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100a2e3e, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
    II(0x100a2e42, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x100a2e45, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a2e47, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a2e48, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a2e49, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a2e4a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a2e4b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a2e4c, 0x1)   retd();                               /* ret */
FUNC_END

