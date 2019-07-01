FUNC_BEGIN(sys_memcpy, 0xbc8bd22c742af2ab, 0x20, ({0x51, 0x56, 0x57, 0x89, 0xd9, 0x89, 0xd6, 0x89, 0xc7, 0x6, 0x8c, 0xd8, 0x8e, 0xc0, 0x57, 0x89, 0xc8, 0xc1, 0xe9, 0x2, 0xf2, 0xa5, 0x8a, 0xc8, 0x80, 0xe1, 0x3, 0xf2, 0xa4, 0x5f, 0x7, 0x89, 0xf8, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x10165e4b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10165e4c, 0x1)   pushd(esi);                           /* push esi */
    II(0x10165e4d, 0x1)   pushd(edi);                           /* push edi */
    II(0x10165e4e, 0x2)   mov(ecx, ebx);                        /* mov ecx, ebx */
    II(0x10165e50, 0x2)   mov(esi, edx);                        /* mov esi, edx */
    II(0x10165e52, 0x2)   mov(edi, eax);                        /* mov edi, eax */
    II(0x10165e54, 0x1)   pushd(es);                            /* push es */
    II(0x10165e55, 0x2)   mov(eax, ds);                         /* mov eax, ds */
    II(0x10165e57, 0x2)   mov(es, eax);                         /* mov es, eax */
    II(0x10165e59, 0x1)   pushd(edi);                           /* push edi */
    II(0x10165e5a, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x10165e5c, 0x3)   shr(ecx, 0x2);                        /* shr ecx, 0x2 */
    II(0x10165e5f, 0x2)   repne_a32 movsd_a32();                /* repne movsd */
    II(0x10165e61, 0x2)   mov(cl, al);                          /* mov cl, al */
    II(0x10165e63, 0x3)   and_(cl, 0x3);                        /* and cl, 0x3 */
    II(0x10165e66, 0x2)   repne_a32 movsb_a32();                /* repne movsb */
    II(0x10165e68, 0x1)   popd(edi);                            /* pop edi */
    II(0x10165e69, 0x1)   popd(es);                             /* pop es */
    II(0x10165e6a, 0x2)   mov(eax, edi);                        /* mov eax, edi */
    II(0x10165e6c, 0x1)   popd(edi);                            /* pop edi */
    II(0x10165e6d, 0x1)   popd(esi);                            /* pop esi */
    II(0x10165e6e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10165e6f, 0x1)   retd();                               /* ret */
FUNC_END

