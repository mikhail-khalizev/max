FUNC_BEGIN(0x10119b3f, 0x5c9a286d6df69c6a, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x9, 0xc2, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x14, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x8d, 0x25, 0x2, 0, 0x8b, 0x45, 0xf8, 0x31, 0xd2, 0x8a, 0x50, 0x18, 0x8b, 0x45, 0xfc, 0xe8, 0x9b, 0x1c, 0xfb, 0xff, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x17, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x6c, 0x25, 0x2, 0, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x19, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x5b, 0x25, 0x2, 0, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x6, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x4a, 0x25, 0x2, 0, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x8, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x39, 0x25, 0x2, 0, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x1d, 0x8b, 0x45, 0xfc, 0xe8, 0x95, 0x25, 0x2, 0, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x21, 0x8b, 0x45, 0xfc, 0xe8, 0x87, 0x25, 0x2, 0, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x25, 0x8b, 0x45, 0xfc, 0xe8, 0x79, 0x25, 0x2, 0, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x29, 0x8b, 0x45, 0xfc, 0xe8, 0x6b, 0x25, 0x2, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10119b3f, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10119b44, 0x5)   calld(sys_check_available_stack_size, 0x4c209); /* call 0x10165d52 */
    II(0x10119b49, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10119b4a, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10119b4b, 0x1)   pushd(esi);                           /* push esi */
    II(0x10119b4c, 0x1)   pushd(edi);                           /* push edi */
    II(0x10119b4d, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10119b4e, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10119b50, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10119b56, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10119b59, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10119b5c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10119b5f, 0x3)   mov(edx, memd_a32(ds, eax + 0x14));   /* mov edx, [eax+0x14] */
    II(0x10119b62, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x10119b65, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119b68, 0x5)   calld(0x1013c0fa, 0x2258d);           /* call 0x1013c0fa */
    II(0x10119b6d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10119b70, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10119b72, 0x3)   mov(dl, memb_a32(ds, eax + 0x18));    /* mov dl, [eax+0x18] */
    II(0x10119b75, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119b78, 0x5)   calld(0x100cb818, -0x4e365);          /* call 0x100cb818 */
    II(0x10119b7d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10119b80, 0x3)   mov(edx, memd_a32(ds, eax + 0x17));   /* mov edx, [eax+0x17] */
    II(0x10119b83, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x10119b86, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119b89, 0x5)   calld(0x1013c0fa, 0x2256c);           /* call 0x1013c0fa */
    II(0x10119b8e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10119b91, 0x3)   mov(edx, memd_a32(ds, eax + 0x19));   /* mov edx, [eax+0x19] */
    II(0x10119b94, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x10119b97, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119b9a, 0x5)   calld(0x1013c0fa, 0x2255b);           /* call 0x1013c0fa */
    II(0x10119b9f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10119ba2, 0x3)   mov(edx, memd_a32(ds, eax + 0x6));    /* mov edx, [eax+0x6] */
    II(0x10119ba5, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x10119ba8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119bab, 0x5)   calld(0x1013c0fa, 0x2254a);           /* call 0x1013c0fa */
    II(0x10119bb0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10119bb3, 0x3)   mov(edx, memd_a32(ds, eax + 0x8));    /* mov edx, [eax+0x8] */
    II(0x10119bb6, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x10119bb9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119bbc, 0x5)   calld(0x1013c0fa, 0x22539);           /* call 0x1013c0fa */
    II(0x10119bc1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10119bc4, 0x3)   mov(edx, memd_a32(ds, eax + 0x1d));   /* mov edx, [eax+0x1d] */
    II(0x10119bc7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119bca, 0x5)   calld(0x1013c164, 0x22595);           /* call 0x1013c164 */
    II(0x10119bcf, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10119bd2, 0x3)   mov(edx, memd_a32(ds, eax + 0x21));   /* mov edx, [eax+0x21] */
    II(0x10119bd5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119bd8, 0x5)   calld(0x1013c164, 0x22587);           /* call 0x1013c164 */
    II(0x10119bdd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10119be0, 0x3)   mov(edx, memd_a32(ds, eax + 0x25));   /* mov edx, [eax+0x25] */
    II(0x10119be3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119be6, 0x5)   calld(0x1013c164, 0x22579);           /* call 0x1013c164 */
    II(0x10119beb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10119bee, 0x3)   mov(edx, memd_a32(ds, eax + 0x29));   /* mov edx, [eax+0x29] */
    II(0x10119bf1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119bf4, 0x5)   calld(0x1013c164, 0x2256b);           /* call 0x1013c164 */
    II(0x10119bf9, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10119bfb, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10119bfc, 0x1)   popd(edi);                            /* pop edi */
    II(0x10119bfd, 0x1)   popd(esi);                            /* pop esi */
    II(0x10119bfe, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10119bff, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10119c00, 0x1)   retd();                               /* ret */
FUNC_END

