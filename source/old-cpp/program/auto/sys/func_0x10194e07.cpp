FUNC_BEGIN(/* sys */ 0x10194e07, 0x8dab1ac474c41a09, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0x33, 0xc0, 0x66, 0xb8, 0, 0x1, 0x8b, 0x5d, 0x8, 0x81, 0xc3, 0, 0x1, 0, 0, 0xcd, 0x31, 0x8b, 0x75, 0xc, 0xc1, 0xe0, 0x4, 0x89, 0x6, 0x8b, 0x75, 0x10, 0x66, 0x89, 0x16, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x10194e07, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10194e08, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10194e0a, 0x1)   pushd(esi);                           /* push esi */
    II(0x10194e0b, 0x1)   pushd(edi);                           /* push edi */
    II(0x10194e0c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10194e0d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10194e0e, 0x2)   pushd(fs);                            /* push fs */
    II(0x10194e10, 0x2)   pushd(gs);                            /* push gs */
    II(0x10194e12, 0x1)   pushd(es);                            /* push es */
    II(0x10194e13, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10194e15, 0x4)   mov(ax, 0x100);                       /* mov ax, 0x100 */
    II(0x10194e19, 0x3)   mov(ebx, memd_a32(ss, ebp + 0x8));    /* mov ebx, [ebp+0x8] */
    II(0x10194e1c, 0x6)   add(ebx, 0x100);                      /* add ebx, 0x100 */
    II(0x10194e22, 0x2)   int_(0x31);                           /* int 0x31 */
    II(0x10194e24, 0x3)   mov(esi, memd_a32(ss, ebp + 0xc));    /* mov esi, [ebp+0xc] */
    II(0x10194e27, 0x3)   shl(eax, 0x4);                        /* shl eax, 0x4 */
    II(0x10194e2a, 0x2)   mov(memd_a32(ds, esi), eax);          /* mov [esi], eax */
    II(0x10194e2c, 0x3)   mov(esi, memd_a32(ss, ebp + 0x10));   /* mov esi, [ebp+0x10] */
    II(0x10194e2f, 0x3)   mov(memw_a32(ds, esi), dx);           /* mov [esi], dx */
    II(0x10194e32, 0x1)   popd(es);                             /* pop es */
    II(0x10194e33, 0x2)   popd(gs);                             /* pop gs */
    II(0x10194e35, 0x2)   popd(fs);                             /* pop fs */
    II(0x10194e37, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10194e38, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10194e39, 0x1)   popd(edi);                            /* pop edi */
    II(0x10194e3a, 0x1)   popd(esi);                            /* pop esi */
    II(0x10194e3b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10194e3c, 0x1)   retd();                               /* ret */
FUNC_END

