FUNC_BEGIN(0x10147fc0, 0x56246f2eab6d013b, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x88, 0xdd, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10147fc0, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10147fc5, 0x5)   calld(sys_check_available_stack_size, 0x1dd88); /* call 0x10165d52 */
    II(0x10147fca, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10147fcb, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10147fcc, 0x1)   pushd(edx);                           /* push edx */
    II(0x10147fcd, 0x1)   pushd(esi);                           /* push esi */
    II(0x10147fce, 0x1)   pushd(edi);                           /* push edi */
    II(0x10147fcf, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10147fd0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10147fd2, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10147fd8, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10147fdb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10147fde, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10147fe0, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10147fe3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10147fe6, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10147fe8, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10147fe9, 0x1)   popd(edi);                            /* pop edi */
    II(0x10147fea, 0x1)   popd(esi);                            /* pop esi */
    II(0x10147feb, 0x1)   popd(edx);                            /* pop edx */
    II(0x10147fec, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10147fed, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10147fee, 0x1)   retd();                               /* ret */
FUNC_END

