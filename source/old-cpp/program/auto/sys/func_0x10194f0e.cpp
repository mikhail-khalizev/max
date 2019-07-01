FUNC_BEGIN(/* sys */ 0x10194f0e, 0x6e24c08c068acf66, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0xb8, 0, 0, 0, 0, 0xf, 0xb4, 0x7d, 0x10, 0xff, 0x5d, 0x8, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x10194f0e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10194f0f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10194f11, 0x1)   pushd(esi);                           /* push esi */
    II(0x10194f12, 0x1)   pushd(edi);                           /* push edi */
    II(0x10194f13, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10194f14, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10194f15, 0x2)   pushd(fs);                            /* push fs */
    II(0x10194f17, 0x2)   pushd(gs);                            /* push gs */
    II(0x10194f19, 0x1)   pushd(es);                            /* push es */
    II(0x10194f1a, 0x5)   mov(eax, 0);                          /* mov eax, 0x0 */
    II(0x10194f1f, 0x4)   lfs(edi, ss, ebp + 0x10);             /* lfs edi, [ebp+0x10] */
    II(0x10194f23, 0x3)   calld_a32_far_ind(ss, ebp + 0x8);     /* call dword far [ebp+0x8] */
    II(0x10194f26, 0x1)   popd(es);                             /* pop es */
    II(0x10194f27, 0x2)   popd(gs);                             /* pop gs */
    II(0x10194f29, 0x2)   popd(fs);                             /* pop fs */
    II(0x10194f2b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10194f2c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10194f2d, 0x1)   popd(edi);                            /* pop edi */
    II(0x10194f2e, 0x1)   popd(esi);                            /* pop esi */
    II(0x10194f2f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10194f30, 0x1)   retd();                               /* ret */
FUNC_END

