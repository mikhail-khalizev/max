FUNC_BEGIN(0x1012b59c, 0xf4fa256016e29ae0, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xac, 0xa7, 0x3, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x10, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1012b59c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1012b5a1, 0x5)   calld(sys_check_available_stack_size, 0x3a7ac); /* call 0x10165d52 */
    II(0x1012b5a6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1012b5a7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1012b5a8, 0x1)   pushd(edx);                           /* push edx */
    II(0x1012b5a9, 0x1)   pushd(esi);                           /* push esi */
    II(0x1012b5aa, 0x1)   pushd(edi);                           /* push edi */
    II(0x1012b5ab, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1012b5ac, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1012b5ae, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1012b5b4, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1012b5b7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1012b5ba, 0x3)   mov(eax, memd_a32(ds, eax + 0x10));   /* mov eax, [eax+0x10] */
    II(0x1012b5bd, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1012b5c0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1012b5c3, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1012b5c5, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1012b5c6, 0x1)   popd(edi);                            /* pop edi */
    II(0x1012b5c7, 0x1)   popd(esi);                            /* pop esi */
    II(0x1012b5c8, 0x1)   popd(edx);                            /* pop edx */
    II(0x1012b5c9, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1012b5ca, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1012b5cb, 0x1)   retd();                               /* ret */
FUNC_END

