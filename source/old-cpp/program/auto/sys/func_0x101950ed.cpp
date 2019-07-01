FUNC_BEGIN(/* sys */ 0x101950ed, 0xe9afd22e716e71b5, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0xf, 0xb4, 0x7d, 0x10, 0xb8, 0x3, 0, 0, 0, 0x66, 0xbb, 0x8, 0, 0xff, 0x5d, 0x8, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x101950ed, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101950ee, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101950f0, 0x1)   pushd(esi);                           /* push esi */
    II(0x101950f1, 0x1)   pushd(edi);                           /* push edi */
    II(0x101950f2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101950f3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101950f4, 0x2)   pushd(fs);                            /* push fs */
    II(0x101950f6, 0x2)   pushd(gs);                            /* push gs */
    II(0x101950f8, 0x1)   pushd(es);                            /* push es */
    II(0x101950f9, 0x4)   lfs(edi, ss, ebp + 0x10);             /* lfs edi, [ebp+0x10] */
    II(0x101950fd, 0x5)   mov(eax, 0x3);                        /* mov eax, 0x3 */
    II(0x10195102, 0x4)   mov(bx, 0x8);                         /* mov bx, 0x8 */
    II(0x10195106, 0x3)   calld_a32_far_ind(ss, ebp + 0x8);     /* call dword far [ebp+0x8] */
    II(0x10195109, 0x1)   popd(es);                             /* pop es */
    II(0x1019510a, 0x2)   popd(gs);                             /* pop gs */
    II(0x1019510c, 0x2)   popd(fs);                             /* pop fs */
    II(0x1019510e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1019510f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10195110, 0x1)   popd(edi);                            /* pop edi */
    II(0x10195111, 0x1)   popd(esi);                            /* pop esi */
    II(0x10195112, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10195113, 0x1)   retd();                               /* ret */
FUNC_END

