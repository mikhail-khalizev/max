FUNC_BEGIN(0x10147d48, 0x9db3cd9554955329, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0, 0xe0, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10147d48, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10147d4d, 0x5)   calld(sys_check_available_stack_size, 0x1e000); /* call 0x10165d52 */
    II(0x10147d52, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10147d53, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10147d54, 0x1)   pushd(edx);                           /* push edx */
    II(0x10147d55, 0x1)   pushd(esi);                           /* push esi */
    II(0x10147d56, 0x1)   pushd(edi);                           /* push edi */
    II(0x10147d57, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10147d58, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10147d5a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10147d60, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10147d63, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10147d66, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10147d68, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10147d6b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10147d6e, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10147d70, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10147d71, 0x1)   popd(edi);                            /* pop edi */
    II(0x10147d72, 0x1)   popd(esi);                            /* pop esi */
    II(0x10147d73, 0x1)   popd(edx);                            /* pop edx */
    II(0x10147d74, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10147d75, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10147d76, 0x1)   retd();                               /* ret */
FUNC_END

