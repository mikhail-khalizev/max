FUNC_BEGIN(0x101029fc, 0xab15c5c03ca9edd7, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x4c, 0x33, 0x6, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x10, 0x8b, 0x45, 0xf8, 0x89, 0x10, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x101029fc, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10102a01, 0x5)   calld(sys_check_available_stack_size, 0x6334c); /* call 0x10165d52 */
    II(0x10102a06, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10102a07, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10102a08, 0x1)   pushd(esi);                           /* push esi */
    II(0x10102a09, 0x1)   pushd(edi);                           /* push edi */
    II(0x10102a0a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10102a0b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10102a0d, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10102a13, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10102a16, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10102a19, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10102a1c, 0x2)   mov(edx, memd_a32(ds, eax));          /* mov edx, [eax] */
    II(0x10102a1e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10102a21, 0x2)   mov(memd_a32(ds, eax), edx);          /* mov [eax], edx */
    II(0x10102a23, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10102a26, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x10102a29, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10102a2c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10102a2e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10102a2f, 0x1)   popd(edi);                            /* pop edi */
    II(0x10102a30, 0x1)   popd(esi);                            /* pop esi */
    II(0x10102a31, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10102a32, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10102a33, 0x1)   retd();                               /* ret */
FUNC_END

