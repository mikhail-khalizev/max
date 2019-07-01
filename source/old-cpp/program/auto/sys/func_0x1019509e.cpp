FUNC_BEGIN(/* sys */ 0x1019509e, 0xe4d5d4fc33a58166, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0xf, 0xb4, 0x7d, 0x10, 0xb8, 0x4, 0, 0, 0, 0x8b, 0x4d, 0x1c, 0x8b, 0x7d, 0x18, 0xff, 0x5d, 0x8, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x1019509e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1019509f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101950a1, 0x1)   pushd(esi);                           /* push esi */
    II(0x101950a2, 0x1)   pushd(edi);                           /* push edi */
    II(0x101950a3, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101950a4, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101950a5, 0x2)   pushd(fs);                            /* push fs */
    II(0x101950a7, 0x2)   pushd(gs);                            /* push gs */
    II(0x101950a9, 0x1)   pushd(es);                            /* push es */
    II(0x101950aa, 0x4)   lfs(edi, ss, ebp + 0x10);             /* lfs edi, [ebp+0x10] */
    II(0x101950ae, 0x5)   mov(eax, 0x4);                        /* mov eax, 0x4 */
    II(0x101950b3, 0x3)   mov(ecx, memd_a32(ss, ebp + 0x1c));   /* mov ecx, [ebp+0x1c] */
    II(0x101950b6, 0x3)   mov(edi, memd_a32(ss, ebp + 0x18));   /* mov edi, [ebp+0x18] */
    II(0x101950b9, 0x3)   calld_a32_far_ind(ss, ebp + 0x8);     /* call dword far [ebp+0x8] */
    II(0x101950bc, 0x1)   popd(es);                             /* pop es */
    II(0x101950bd, 0x2)   popd(gs);                             /* pop gs */
    II(0x101950bf, 0x2)   popd(fs);                             /* pop fs */
    II(0x101950c1, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101950c2, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101950c3, 0x1)   popd(edi);                            /* pop edi */
    II(0x101950c4, 0x1)   popd(esi);                            /* pop esi */
    II(0x101950c5, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101950c6, 0x1)   retd();                               /* ret */
FUNC_END

