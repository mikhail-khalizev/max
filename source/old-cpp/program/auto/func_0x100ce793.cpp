FUNC_BEGIN(0x100ce793, 0x9933e5f6b202a7e4, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xb5, 0x75, 0x9, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x2, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0x89, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x4, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0x89, 0x50, 0x4, 0x8b, 0x45, 0xf8, 0x8b, 0x58, 0x2, 0xc1, 0xfb, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x6, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0x1, 0xd3, 0x89, 0x58, 0x8, 0x8b, 0x45, 0xf8, 0x8b, 0x58, 0x4, 0xc1, 0xfb, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x8, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0x1, 0xd3, 0x89, 0x58, 0xc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100ce793, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100ce798, 0x5)   calld(sys_check_available_stack_size, 0x975b5); /* call 0x10165d52 */
    II(0x100ce79d, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ce79e, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ce79f, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ce7a0, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ce7a1, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ce7a2, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ce7a4, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100ce7aa, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100ce7ad, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100ce7b0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ce7b3, 0x3)   mov(edx, memd_a32(ds, eax + 0x2));    /* mov edx, [eax+0x2] */
    II(0x100ce7b6, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100ce7b9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100ce7bc, 0x2)   mov(memd_a32(ds, eax), edx);          /* mov [eax], edx */
    II(0x100ce7be, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ce7c1, 0x3)   mov(edx, memd_a32(ds, eax + 0x4));    /* mov edx, [eax+0x4] */
    II(0x100ce7c4, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100ce7c7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100ce7ca, 0x3)   mov(memd_a32(ds, eax + 0x4), edx);    /* mov [eax+0x4], edx */
    II(0x100ce7cd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ce7d0, 0x3)   mov(ebx, memd_a32(ds, eax + 0x2));    /* mov ebx, [eax+0x2] */
    II(0x100ce7d3, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x100ce7d6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ce7d9, 0x3)   mov(edx, memd_a32(ds, eax + 0x6));    /* mov edx, [eax+0x6] */
    II(0x100ce7dc, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100ce7df, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100ce7e2, 0x2)   add(ebx, edx);                        /* add ebx, edx */
    II(0x100ce7e4, 0x3)   mov(memd_a32(ds, eax + 0x8), ebx);    /* mov [eax+0x8], ebx */
    II(0x100ce7e7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ce7ea, 0x3)   mov(ebx, memd_a32(ds, eax + 0x4));    /* mov ebx, [eax+0x4] */
    II(0x100ce7ed, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x100ce7f0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ce7f3, 0x3)   mov(edx, memd_a32(ds, eax + 0x8));    /* mov edx, [eax+0x8] */
    II(0x100ce7f6, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100ce7f9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100ce7fc, 0x2)   add(ebx, edx);                        /* add ebx, edx */
    II(0x100ce7fe, 0x3)   mov(memd_a32(ds, eax + 0xc), ebx);    /* mov [eax+0xc], ebx */
    II(0x100ce801, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ce803, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ce804, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ce805, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ce806, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ce807, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ce808, 0x1)   retd();                               /* ret */
FUNC_END

