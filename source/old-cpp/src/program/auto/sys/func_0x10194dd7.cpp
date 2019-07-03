FUNC_BEGIN(/* sys */ 0x10194dd7, 0xab8d69b18c7f8956, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0x8b, 0x75, 0x8, 0xc4, 0x7d, 0xc, 0xb9, 0x20, 0, 0, 0, 0x89, 0x3e, 0x66, 0x8c, 0x46, 0x4, 0x83, 0xc7, 0x6c, 0x83, 0xc6, 0x6, 0xe2, 0xf2, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x10194dd7, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10194dd8, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10194dda, 0x1)   pushd(esi);                           /* push esi */
    II(0x10194ddb, 0x1)   pushd(edi);                           /* push edi */
    II(0x10194ddc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10194ddd, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10194dde, 0x2)   pushd(fs);                            /* push fs */
    II(0x10194de0, 0x2)   pushd(gs);                            /* push gs */
    II(0x10194de2, 0x1)   pushd(es);                            /* push es */
    II(0x10194de3, 0x3)   mov(esi, memd_a32(ss, ebp + 0x8));    /* mov esi, [ebp+0x8] */
    II(0x10194de6, 0x3)   les(edi, ss, ebp + 0xc);              /* les edi, [ebp+0xc] */
    II(0x10194de9, 0x5)   mov(ecx, 0x20);                       /* mov ecx, 0x20 */
l_0x10194dee:
    II(0x10194dee, 0x2)   mov(memd_a32(ds, esi), edi);          /* mov [esi], edi */
    II(0x10194df0, 0x4)   mov(memw_a32(ds, esi + 0x4), es);     /* mov [esi+0x4], es */
    II(0x10194df4, 0x3)   add(edi, 0x6c);                       /* add edi, 0x6c */
    II(0x10194df7, 0x3)   add(esi, 0x6);                        /* add esi, 0x6 */
    II(0x10194dfa, 0x2)   loopd_a32(0x10194dee, -0xe);          /* loop 0x10194dee */
    II(0x10194dfc, 0x1)   popd(es);                             /* pop es */
    II(0x10194dfd, 0x2)   popd(gs);                             /* pop gs */
    II(0x10194dff, 0x2)   popd(fs);                             /* pop fs */
    II(0x10194e01, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10194e02, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10194e03, 0x1)   popd(edi);                            /* pop edi */
    II(0x10194e04, 0x1)   popd(esi);                            /* pop esi */
    II(0x10194e05, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10194e06, 0x1)   retd();                               /* ret */
FUNC_END

