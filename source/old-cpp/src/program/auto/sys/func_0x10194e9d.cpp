FUNC_BEGIN(/* sys */ 0x10194e9d, 0xf415b8e141aaf9f2, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0xb8, 0x8, 0, 0, 0, 0xf, 0xb4, 0x7d, 0x10, 0xff, 0x5d, 0x8, 0x1e, 0x6, 0xc4, 0x7d, 0x18, 0xc5, 0x75, 0x10, 0x8b, 0xf2, 0xb9, 0x6a, 0, 0, 0, 0xfc, 0xf3, 0xa4, 0xc4, 0x7d, 0x18, 0x66, 0x26, 0x8c, 0x5f, 0x44, 0x66, 0x26, 0x8c, 0x5f, 0x4c, 0x66, 0x26, 0x8c, 0x5f, 0x54, 0x66, 0x26, 0x8c, 0x5f, 0x5c, 0x7, 0x1f, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x10194e9d, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10194e9e, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10194ea0, 0x1)   pushd(esi);                           /* push esi */
    II(0x10194ea1, 0x1)   pushd(edi);                           /* push edi */
    II(0x10194ea2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10194ea3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10194ea4, 0x2)   pushd(fs);                            /* push fs */
    II(0x10194ea6, 0x2)   pushd(gs);                            /* push gs */
    II(0x10194ea8, 0x1)   pushd(es);                            /* push es */
    II(0x10194ea9, 0x5)   mov(eax, 0x8);                        /* mov eax, 0x8 */
    II(0x10194eae, 0x4)   lfs(edi, ss, ebp + 0x10);             /* lfs edi, [ebp+0x10] */
    II(0x10194eb2, 0x3)   calld_a32_far_ind(ss, ebp + 0x8);     /* call dword far [ebp+0x8] */
    II(0x10194eb5, 0x1)   pushd(ds);                            /* push ds */
    II(0x10194eb6, 0x1)   pushd(es);                            /* push es */
    II(0x10194eb7, 0x3)   les(edi, ss, ebp + 0x18);             /* les edi, [ebp+0x18] */
    II(0x10194eba, 0x3)   lds(esi, ss, ebp + 0x10);             /* lds esi, [ebp+0x10] */
    II(0x10194ebd, 0x2)   mov(esi, edx);                        /* mov esi, edx */
    II(0x10194ebf, 0x5)   mov(ecx, 0x6a);                       /* mov ecx, 0x6a */
    II(0x10194ec4, 0x1)   cld();                                /* cld */
    II(0x10194ec5, 0x2)   rep_a32 movsb_a32();                  /* rep movsb */
    II(0x10194ec7, 0x3)   les(edi, ss, ebp + 0x18);             /* les edi, [ebp+0x18] */
    II(0x10194eca, 0x5)   mov(memw_a32(es, edi + 0x44), ds);    /* mov [es:edi+0x44], ds */
    II(0x10194ecf, 0x5)   mov(memw_a32(es, edi + 0x4c), ds);    /* mov [es:edi+0x4c], ds */
    II(0x10194ed4, 0x5)   mov(memw_a32(es, edi + 0x54), ds);    /* mov [es:edi+0x54], ds */
    II(0x10194ed9, 0x5)   mov(memw_a32(es, edi + 0x5c), ds);    /* mov [es:edi+0x5c], ds */
    II(0x10194ede, 0x1)   popd(es);                             /* pop es */
    II(0x10194edf, 0x1)   popd(ds);                             /* pop ds */
    II(0x10194ee0, 0x1)   popd(es);                             /* pop es */
    II(0x10194ee1, 0x2)   popd(gs);                             /* pop gs */
    II(0x10194ee3, 0x2)   popd(fs);                             /* pop fs */
    II(0x10194ee5, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10194ee6, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10194ee7, 0x1)   popd(edi);                            /* pop edi */
    II(0x10194ee8, 0x1)   popd(esi);                            /* pop esi */
    II(0x10194ee9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10194eea, 0x1)   retd();                               /* ret */
FUNC_END

