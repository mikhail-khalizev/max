FUNC_BEGIN(0x100d4e8c, 0x7002916ab62ed7e5, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xbc, 0xe, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100d4e8c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100d4e91, 0x5)   calld(sys_check_available_stack_size, 0x90ebc); /* call 0x10165d52 */
    II(0x100d4e96, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d4e97, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d4e98, 0x1)   pushd(edx);                           /* push edx */
    II(0x100d4e99, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d4e9a, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d4e9b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d4e9c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d4e9e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100d4ea4, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100d4ea7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d4eaa, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x100d4eac, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100d4eaf, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d4eb2, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d4eb4, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d4eb5, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d4eb6, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d4eb7, 0x1)   popd(edx);                            /* pop edx */
    II(0x100d4eb8, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d4eb9, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d4eba, 0x1)   retd();                               /* ret */
FUNC_END

