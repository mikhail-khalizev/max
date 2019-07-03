FUNC_BEGIN(/* sys */ 0x101950c7, 0xa1ca6c459d52556, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0xf, 0xb4, 0x7d, 0x10, 0xb8, 0x2, 0, 0, 0, 0x8b, 0x5d, 0x18, 0xff, 0x5d, 0x8, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x101950c7, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101950c8, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101950ca, 0x1)   pushd(esi);                           /* push esi */
    II(0x101950cb, 0x1)   pushd(edi);                           /* push edi */
    II(0x101950cc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101950cd, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101950ce, 0x2)   pushd(fs);                            /* push fs */
    II(0x101950d0, 0x2)   pushd(gs);                            /* push gs */
    II(0x101950d2, 0x1)   pushd(es);                            /* push es */
    II(0x101950d3, 0x4)   lfs(edi, ss, ebp + 0x10);             /* lfs edi, [ebp+0x10] */
    II(0x101950d7, 0x5)   mov(eax, 0x2);                        /* mov eax, 0x2 */
    II(0x101950dc, 0x3)   mov(ebx, memd_a32(ss, ebp + 0x18));   /* mov ebx, [ebp+0x18] */
    II(0x101950df, 0x3)   calld_a32_far_ind(ss, ebp + 0x8);     /* call dword far [ebp+0x8] */
    II(0x101950e2, 0x1)   popd(es);                             /* pop es */
    II(0x101950e3, 0x2)   popd(gs);                             /* pop gs */
    II(0x101950e5, 0x2)   popd(fs);                             /* pop fs */
    II(0x101950e7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101950e8, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101950e9, 0x1)   popd(edi);                            /* pop edi */
    II(0x101950ea, 0x1)   popd(esi);                            /* pop esi */
    II(0x101950eb, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101950ec, 0x1)   retd();                               /* ret */
FUNC_END

