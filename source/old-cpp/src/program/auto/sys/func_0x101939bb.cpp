FUNC_BEGIN(/* sys */ 0x101939bb, 0x7594bf375fd00e2f, 0x20, ({0x53, 0x51, 0x52, 0x8b, 0xc8, 0xc1, 0xe1, 0x2, 0x8b, 0x5d, 0xf8, 0x2b, 0xd9, 0x8b, 0x55, 0xf4, 0x2b, 0xd1, 0x8b, 0xc8, 0xf3, 0xa5, 0x3, 0xf3, 0x3, 0xfa, 0x8b, 0xc8, 0xf3, 0xa5, 0x3, 0xf3, 0x3, 0xfa, 0x8b, 0xc8, 0xf3, 0xa5, 0x3, 0xf3, 0x3, 0xfa, 0x8b, 0xc8, 0xf3, 0xa5, 0x3, 0xf3, 0x3, 0xfa, 0x8b, 0xc8, 0xf3, 0xa5, 0x3, 0xf3, 0x3, 0xfa, 0x8b, 0xc8, 0xf3, 0xa5, 0x3, 0xf3, 0x3, 0xfa, 0x8b, 0xc8, 0xf3, 0xa5, 0x3, 0xf3, 0x3, 0xfa, 0x8b, 0xc8, 0xf3, 0xa5, 0x2b, 0x75, 0xf0, 0x2b, 0x7d, 0xec, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101939bb, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101939bc, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101939bd, 0x1)   pushd(edx);                           /* push edx */
    II(0x101939be, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x101939c0, 0x3)   shl(ecx, 0x2);                        /* shl ecx, 0x2 */
    II(0x101939c3, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x101939c6, 0x2)   sub(ebx, ecx);                        /* sub ebx, ecx */
    II(0x101939c8, 0x3)   mov(edx, memd_a32(ss, ebp - 0xc));    /* mov edx, [ebp-0xc] */
    II(0x101939cb, 0x2)   sub(edx, ecx);                        /* sub edx, ecx */
    II(0x101939cd, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x101939cf, 0x2)   rep_a32 movsd_a32();                  /* rep movsd */
    II(0x101939d1, 0x2)   add(esi, ebx);                        /* add esi, ebx */
    II(0x101939d3, 0x2)   add(edi, edx);                        /* add edi, edx */
    II(0x101939d5, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x101939d7, 0x2)   rep_a32 movsd_a32();                  /* rep movsd */
    II(0x101939d9, 0x2)   add(esi, ebx);                        /* add esi, ebx */
    II(0x101939db, 0x2)   add(edi, edx);                        /* add edi, edx */
    II(0x101939dd, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x101939df, 0x2)   rep_a32 movsd_a32();                  /* rep movsd */
    II(0x101939e1, 0x2)   add(esi, ebx);                        /* add esi, ebx */
    II(0x101939e3, 0x2)   add(edi, edx);                        /* add edi, edx */
    II(0x101939e5, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x101939e7, 0x2)   rep_a32 movsd_a32();                  /* rep movsd */
    II(0x101939e9, 0x2)   add(esi, ebx);                        /* add esi, ebx */
    II(0x101939eb, 0x2)   add(edi, edx);                        /* add edi, edx */
    II(0x101939ed, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x101939ef, 0x2)   rep_a32 movsd_a32();                  /* rep movsd */
    II(0x101939f1, 0x2)   add(esi, ebx);                        /* add esi, ebx */
    II(0x101939f3, 0x2)   add(edi, edx);                        /* add edi, edx */
    II(0x101939f5, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x101939f7, 0x2)   rep_a32 movsd_a32();                  /* rep movsd */
    II(0x101939f9, 0x2)   add(esi, ebx);                        /* add esi, ebx */
    II(0x101939fb, 0x2)   add(edi, edx);                        /* add edi, edx */
    II(0x101939fd, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x101939ff, 0x2)   rep_a32 movsd_a32();                  /* rep movsd */
    II(0x10193a01, 0x2)   add(esi, ebx);                        /* add esi, ebx */
    II(0x10193a03, 0x2)   add(edi, edx);                        /* add edi, edx */
    II(0x10193a05, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x10193a07, 0x2)   rep_a32 movsd_a32();                  /* rep movsd */
    II(0x10193a09, 0x3)   sub(esi, memd_a32(ss, ebp - 0x10));   /* sub esi, [ebp-0x10] */
    II(0x10193a0c, 0x3)   sub(edi, memd_a32(ss, ebp - 0x14));   /* sub edi, [ebp-0x14] */
    II(0x10193a0f, 0x1)   popd(edx);                            /* pop edx */
    II(0x10193a10, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10193a11, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10193a12, 0x1)   retd();                               /* ret */
FUNC_END

