FUNC_BEGIN(0x1013abc3, 0x890fe6176fd9b4fc, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x85, 0xb1, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x89, 0x2, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0x36, 0x2, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013abc3, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1013abc8, 0x5)   calld(sys_check_available_stack_size, 0x2b185); /* call 0x10165d52 */
    II(0x1013abcd, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013abce, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013abcf, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013abd0, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013abd1, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013abd2, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013abd4, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1013abda, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013abdd, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1013abe0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013abe3, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1013abe6, 0x2)   mov(memd_a32(ds, edx), eax);          /* mov [edx], eax */
    II(0x1013abe8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013abeb, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1013abed, 0x5)   calld(0x1013ae28, 0x236);             /* call 0x1013ae28 */
    II(0x1013abf2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013abf5, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1013abf8, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1013abfb, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013abfd, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013abfe, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013abff, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013ac00, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013ac01, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013ac02, 0x1)   retd();                               /* ret */
FUNC_END

