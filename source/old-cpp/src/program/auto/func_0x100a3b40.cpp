FUNC_BEGIN(0x100a3b40, 0x579953746f5a0994, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x8, 0x22, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc7, 0x45, 0xf8, 0x2, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100a3b40, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100a3b45, 0x5)   calld(sys_check_available_stack_size, 0xc2208); /* call 0x10165d52 */
    II(0x100a3b4a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a3b4b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a3b4c, 0x1)   pushd(edx);                           /* push edx */
    II(0x100a3b4d, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a3b4e, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a3b4f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a3b50, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a3b52, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100a3b58, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100a3b5b, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x2);    /* mov dword [ebp-0x8], 0x2 */
    II(0x100a3b62, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100a3b65, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a3b67, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a3b68, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a3b69, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a3b6a, 0x1)   popd(edx);                            /* pop edx */
    II(0x100a3b6b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a3b6c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a3b6d, 0x1)   retd();                               /* ret */
FUNC_END

