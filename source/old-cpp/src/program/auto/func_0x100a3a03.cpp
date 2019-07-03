FUNC_BEGIN(0x100a3a03, 0x94f31bfc5bd0a18d, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x45, 0x23, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc7, 0x45, 0xf8, 0x4, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100a3a03, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100a3a08, 0x5)   calld(sys_check_available_stack_size, 0xc2345); /* call 0x10165d52 */
    II(0x100a3a0d, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a3a0e, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a3a0f, 0x1)   pushd(edx);                           /* push edx */
    II(0x100a3a10, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a3a11, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a3a12, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a3a13, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a3a15, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100a3a1b, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100a3a1e, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x4);    /* mov dword [ebp-0x8], 0x4 */
    II(0x100a3a25, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100a3a28, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a3a2a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a3a2b, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a3a2c, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a3a2d, 0x1)   popd(edx);                            /* pop edx */
    II(0x100a3a2e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a3a2f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a3a30, 0x1)   retd();                               /* ret */
FUNC_END

