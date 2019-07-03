FUNC_BEGIN(0x10087c78, 0x59433b5335fd9cb0, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xd0, 0xe0, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc7, 0x45, 0xf8, 0x4, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10087c78, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10087c7d, 0x5)   calld(sys_check_available_stack_size, 0xde0d0); /* call 0x10165d52 */
    II(0x10087c82, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10087c83, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10087c84, 0x1)   pushd(edx);                           /* push edx */
    II(0x10087c85, 0x1)   pushd(esi);                           /* push esi */
    II(0x10087c86, 0x1)   pushd(edi);                           /* push edi */
    II(0x10087c87, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10087c88, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10087c8a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10087c90, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10087c93, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x4);    /* mov dword [ebp-0x8], 0x4 */
    II(0x10087c9a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10087c9d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10087c9f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10087ca0, 0x1)   popd(edi);                            /* pop edi */
    II(0x10087ca1, 0x1)   popd(esi);                            /* pop esi */
    II(0x10087ca2, 0x1)   popd(edx);                            /* pop edx */
    II(0x10087ca3, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10087ca4, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10087ca5, 0x1)   retd();                               /* ret */
FUNC_END

