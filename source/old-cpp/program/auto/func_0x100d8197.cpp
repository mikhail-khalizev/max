FUNC_BEGIN(0x100d8197, 0x9c80eb44925a83f2, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xb1, 0xdb, 0x8, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x2, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0x89, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x4, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0x89, 0x50, 0x4, 0x8b, 0x45, 0xf8, 0x8b, 0x58, 0x2, 0xc1, 0xfb, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x6, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0x1, 0xd3, 0x89, 0x58, 0x8, 0x8b, 0x45, 0xf8, 0x8b, 0x58, 0x4, 0xc1, 0xfb, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x8, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0x1, 0xd3, 0x89, 0x58, 0xc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100d8197, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100d819c, 0x5)   calld(sys_check_available_stack_size, 0x8dbb1); /* call 0x10165d52 */
    II(0x100d81a1, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d81a2, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d81a3, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d81a4, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d81a5, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d81a6, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d81a8, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100d81ae, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100d81b1, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100d81b4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d81b7, 0x3)   mov(edx, memd_a32(ds, eax + 0x2));    /* mov edx, [eax+0x2] */
    II(0x100d81ba, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100d81bd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d81c0, 0x2)   mov(memd_a32(ds, eax), edx);          /* mov [eax], edx */
    II(0x100d81c2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d81c5, 0x3)   mov(edx, memd_a32(ds, eax + 0x4));    /* mov edx, [eax+0x4] */
    II(0x100d81c8, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100d81cb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d81ce, 0x3)   mov(memd_a32(ds, eax + 0x4), edx);    /* mov [eax+0x4], edx */
    II(0x100d81d1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d81d4, 0x3)   mov(ebx, memd_a32(ds, eax + 0x2));    /* mov ebx, [eax+0x2] */
    II(0x100d81d7, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x100d81da, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d81dd, 0x3)   mov(edx, memd_a32(ds, eax + 0x6));    /* mov edx, [eax+0x6] */
    II(0x100d81e0, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100d81e3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d81e6, 0x2)   add(ebx, edx);                        /* add ebx, edx */
    II(0x100d81e8, 0x3)   mov(memd_a32(ds, eax + 0x8), ebx);    /* mov [eax+0x8], ebx */
    II(0x100d81eb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d81ee, 0x3)   mov(ebx, memd_a32(ds, eax + 0x4));    /* mov ebx, [eax+0x4] */
    II(0x100d81f1, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x100d81f4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d81f7, 0x3)   mov(edx, memd_a32(ds, eax + 0x8));    /* mov edx, [eax+0x8] */
    II(0x100d81fa, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100d81fd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d8200, 0x2)   add(ebx, edx);                        /* add ebx, edx */
    II(0x100d8202, 0x3)   mov(memd_a32(ds, eax + 0xc), ebx);    /* mov [eax+0xc], ebx */
    II(0x100d8205, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d8207, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d8208, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d8209, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d820a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d820b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d820c, 0x1)   retd();                               /* ret */
FUNC_END

