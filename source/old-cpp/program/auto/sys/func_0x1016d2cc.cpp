FUNC_BEGIN(/* sys */ 0x1016d2cc, 0xfe6669e49f448251, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0xb9, 0, 0x3, 0, 0, 0xbf, 0xc0, 0xde, 0x1b, 0x10, 0xbb, 0, 0x1, 0, 0, 0x89, 0xc6, 0xba, 0x1, 0, 0, 0, 0x57, 0x89, 0xc8, 0xc1, 0xe9, 0x2, 0xf2, 0xa5, 0x8a, 0xc8, 0x80, 0xe1, 0x3, 0xf2, 0xa4, 0x5f, 0xb8, 0x20, 0x4, 0x1d, 0x10, 0xe8, 0xdf, 0x8a, 0xff, 0xff, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1016d2cc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1016d2cd, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1016d2ce, 0x1)   pushd(edx);                           /* push edx */
    II(0x1016d2cf, 0x1)   pushd(esi);                           /* push esi */
    II(0x1016d2d0, 0x1)   pushd(edi);                           /* push edi */
    II(0x1016d2d1, 0x5)   mov(ecx, 0x300);                      /* mov ecx, 0x300 */
    II(0x1016d2d6, 0x5)   mov(edi, 0x101bdec0);                 /* mov edi, 0x101bdec0 */
    II(0x1016d2db, 0x5)   mov(ebx, 0x100);                      /* mov ebx, 0x100 */
    II(0x1016d2e0, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x1016d2e2, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x1016d2e7, 0x1)   pushd(edi);                           /* push edi */
    II(0x1016d2e8, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x1016d2ea, 0x3)   shr(ecx, 0x2);                        /* shr ecx, 0x2 */
    II(0x1016d2ed, 0x2)   repne_a32 movsd_a32();                /* repne movsd */
    II(0x1016d2ef, 0x2)   mov(cl, al);                          /* mov cl, al */
    II(0x1016d2f1, 0x3)   and_(cl, 0x3);                        /* and cl, 0x3 */
    II(0x1016d2f4, 0x2)   repne_a32 movsb_a32();                /* repne movsb */
    II(0x1016d2f6, 0x1)   popd(edi);                            /* pop edi */
    II(0x1016d2f7, 0x5)   mov(eax, 0x101d0420);                 /* mov eax, 0x101d0420 */
    II(0x1016d2fc, 0x5)   calld(sys_memset, -0x7521);           /* call 0x10165de0 */
    II(0x1016d301, 0x1)   popd(edi);                            /* pop edi */
    II(0x1016d302, 0x1)   popd(esi);                            /* pop esi */
    II(0x1016d303, 0x1)   popd(edx);                            /* pop edx */
    II(0x1016d304, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1016d305, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1016d306, 0x1)   retd();                               /* ret */
FUNC_END

