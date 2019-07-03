FUNC_BEGIN(0x100a39d5, 0xf345cce0493fe24, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x73, 0x23, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc7, 0x45, 0xf8, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100a39d5, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100a39da, 0x5)   calld(sys_check_available_stack_size, 0xc2373); /* call 0x10165d52 */
    II(0x100a39df, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a39e0, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a39e1, 0x1)   pushd(edx);                           /* push edx */
    II(0x100a39e2, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a39e3, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a39e4, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a39e5, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a39e7, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100a39ed, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100a39f0, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x1);    /* mov dword [ebp-0x8], 0x1 */
    II(0x100a39f7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100a39fa, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a39fc, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a39fd, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a39fe, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a39ff, 0x1)   popd(edx);                            /* pop edx */
    II(0x100a3a00, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a3a01, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a3a02, 0x1)   retd();                               /* ret */
FUNC_END

