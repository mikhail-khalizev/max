FUNC_BEGIN(0x100ca200, 0x115fe66b119449e0, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x48, 0xbb, 0x9, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf8, 0xe8, 0x3a, 0xff, 0xff, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100ca200, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100ca205, 0x5)   calld(sys_check_available_stack_size, 0x9bb48); /* call 0x10165d52 */
    II(0x100ca20a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ca20b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ca20c, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ca20d, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ca20e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ca20f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ca211, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100ca217, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100ca21a, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100ca21d, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
//    II(0x100ca222, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ca225, 0x5)   calld(0x100ca164, -0xc6);             /* call 0x100ca164 */
    II(0x100ca22a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100ca22d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ca230, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100ca233, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100ca236, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ca238, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ca239, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ca23a, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ca23b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ca23c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ca23d, 0x1)   retd();                               /* ret */
FUNC_END

