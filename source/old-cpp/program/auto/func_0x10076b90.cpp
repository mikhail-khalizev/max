FUNC_BEGIN(0x10076b90, 0xa8ab929a5f466f30, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xb8, 0xf1, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10076b90, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10076b95, 0x5)   calld(sys_check_available_stack_size, 0xef1b8); /* call 0x10165d52 */
    II(0x10076b9a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10076b9b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10076b9c, 0x1)   pushd(edx);                           /* push edx */
    II(0x10076b9d, 0x1)   pushd(esi);                           /* push esi */
    II(0x10076b9e, 0x1)   pushd(edi);                           /* push edi */
    II(0x10076b9f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10076ba0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10076ba2, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10076ba8, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10076bab, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10076bae, 0x3)   mov(ax, memw_a32(ds, eax));           /* mov ax, [eax] */
    II(0x10076bb1, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10076bb4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10076bb7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10076bb9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10076bba, 0x1)   popd(edi);                            /* pop edi */
    II(0x10076bbb, 0x1)   popd(esi);                            /* pop esi */
    II(0x10076bbc, 0x1)   popd(edx);                            /* pop edx */
    II(0x10076bbd, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10076bbe, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10076bbf, 0x1)   retd();                               /* ret */
FUNC_END

