FUNC_BEGIN(0x100d5104, 0xf31ddced5f97df6, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x44, 0xc, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100d5104, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100d5109, 0x5)   calld(sys_check_available_stack_size, 0x90c44); /* call 0x10165d52 */
    II(0x100d510e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d510f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d5110, 0x1)   pushd(edx);                           /* push edx */
    II(0x100d5111, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d5112, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d5113, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d5114, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d5116, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100d511c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100d511f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d5122, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x100d5124, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100d5127, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d512a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d512c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d512d, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d512e, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d512f, 0x1)   popd(edx);                            /* pop edx */
    II(0x100d5130, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d5131, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d5132, 0x1)   retd();                               /* ret */
FUNC_END

