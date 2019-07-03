FUNC_BEGIN(/* sys */ 0x10193e0e, 0x7594bf375fd00e2f, 0x20, ({0x53, 0x51, 0x52, 0x8b, 0xc8, 0xc1, 0xe1, 0x2, 0x8b, 0x5d, 0xf8, 0x2b, 0xd9, 0x8b, 0x55, 0xf4, 0x2b, 0xd1, 0x8b, 0xc8, 0xf3, 0xa5, 0x3, 0xf3, 0x3, 0xfa, 0x8b, 0xc8, 0xf3, 0xa5, 0x3, 0xf3, 0x3, 0xfa, 0x8b, 0xc8, 0xf3, 0xa5, 0x3, 0xf3, 0x3, 0xfa, 0x8b, 0xc8, 0xf3, 0xa5, 0x3, 0xf3, 0x3, 0xfa, 0x8b, 0xc8, 0xf3, 0xa5, 0x3, 0xf3, 0x3, 0xfa, 0x8b, 0xc8, 0xf3, 0xa5, 0x3, 0xf3, 0x3, 0xfa, 0x8b, 0xc8, 0xf3, 0xa5, 0x3, 0xf3, 0x3, 0xfa, 0x8b, 0xc8, 0xf3, 0xa5, 0x2b, 0x75, 0xf0, 0x2b, 0x7d, 0xec, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10193e0e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10193e0f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10193e10, 0x1)   pushd(edx);                           /* push edx */
    II(0x10193e11, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x10193e13, 0x3)   shl(ecx, 0x2);                        /* shl ecx, 0x2 */
    II(0x10193e16, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10193e19, 0x2)   sub(ebx, ecx);                        /* sub ebx, ecx */
    II(0x10193e1b, 0x3)   mov(edx, memd_a32(ss, ebp - 0xc));    /* mov edx, [ebp-0xc] */
    II(0x10193e1e, 0x2)   sub(edx, ecx);                        /* sub edx, ecx */
    II(0x10193e20, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x10193e22, 0x2)   rep_a32 movsd_a32();                  /* rep movsd */
    II(0x10193e24, 0x2)   add(esi, ebx);                        /* add esi, ebx */
    II(0x10193e26, 0x2)   add(edi, edx);                        /* add edi, edx */
    II(0x10193e28, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x10193e2a, 0x2)   rep_a32 movsd_a32();                  /* rep movsd */
    II(0x10193e2c, 0x2)   add(esi, ebx);                        /* add esi, ebx */
    II(0x10193e2e, 0x2)   add(edi, edx);                        /* add edi, edx */
    II(0x10193e30, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x10193e32, 0x2)   rep_a32 movsd_a32();                  /* rep movsd */
    II(0x10193e34, 0x2)   add(esi, ebx);                        /* add esi, ebx */
    II(0x10193e36, 0x2)   add(edi, edx);                        /* add edi, edx */
    II(0x10193e38, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x10193e3a, 0x2)   rep_a32 movsd_a32();                  /* rep movsd */
    II(0x10193e3c, 0x2)   add(esi, ebx);                        /* add esi, ebx */
    II(0x10193e3e, 0x2)   add(edi, edx);                        /* add edi, edx */
    II(0x10193e40, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x10193e42, 0x2)   rep_a32 movsd_a32();                  /* rep movsd */
    II(0x10193e44, 0x2)   add(esi, ebx);                        /* add esi, ebx */
    II(0x10193e46, 0x2)   add(edi, edx);                        /* add edi, edx */
    II(0x10193e48, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x10193e4a, 0x2)   rep_a32 movsd_a32();                  /* rep movsd */
    II(0x10193e4c, 0x2)   add(esi, ebx);                        /* add esi, ebx */
    II(0x10193e4e, 0x2)   add(edi, edx);                        /* add edi, edx */
    II(0x10193e50, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x10193e52, 0x2)   rep_a32 movsd_a32();                  /* rep movsd */
    II(0x10193e54, 0x2)   add(esi, ebx);                        /* add esi, ebx */
    II(0x10193e56, 0x2)   add(edi, edx);                        /* add edi, edx */
    II(0x10193e58, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x10193e5a, 0x2)   rep_a32 movsd_a32();                  /* rep movsd */
    II(0x10193e5c, 0x3)   sub(esi, memd_a32(ss, ebp - 0x10));   /* sub esi, [ebp-0x10] */
    II(0x10193e5f, 0x3)   sub(edi, memd_a32(ss, ebp - 0x14));   /* sub edi, [ebp-0x14] */
    II(0x10193e62, 0x1)   popd(edx);                            /* pop edx */
    II(0x10193e63, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10193e64, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10193e65, 0x1)   retd();                               /* ret */
FUNC_END

