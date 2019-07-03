FUNC_BEGIN(0x100aadf0, 0x5135b5aa3fc56dee, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x58, 0xaf, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100aadf0, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100aadf5, 0x5)   calld(sys_check_available_stack_size, 0xbaf58); /* call 0x10165d52 */
    II(0x100aadfa, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100aadfb, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100aadfc, 0x1)   pushd(edx);                           /* push edx */
    II(0x100aadfd, 0x1)   pushd(esi);                           /* push esi */
    II(0x100aadfe, 0x1)   pushd(edi);                           /* push edi */
    II(0x100aadff, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100aae00, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100aae02, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100aae08, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100aae0b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100aae0e, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x100aae10, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100aae13, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100aae16, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100aae18, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100aae19, 0x1)   popd(edi);                            /* pop edi */
    II(0x100aae1a, 0x1)   popd(esi);                            /* pop esi */
    II(0x100aae1b, 0x1)   popd(edx);                            /* pop edx */
    II(0x100aae1c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100aae1d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100aae1e, 0x1)   retd();                               /* ret */
FUNC_END

