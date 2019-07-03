FUNC_BEGIN(/* sys */ 0x101952c7, 0x4a3553489246b48c, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0x66, 0xb8, 0, 0x16, 0xcd, 0x2f, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x101952c7, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101952c8, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101952ca, 0x1)   pushd(esi);                           /* push esi */
    II(0x101952cb, 0x1)   pushd(edi);                           /* push edi */
    II(0x101952cc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101952cd, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101952ce, 0x2)   pushd(fs);                            /* push fs */
    II(0x101952d0, 0x2)   pushd(gs);                            /* push gs */
    II(0x101952d2, 0x1)   pushd(es);                            /* push es */
    II(0x101952d3, 0x4)   mov(ax, 0x1600);                      /* mov ax, 0x1600 */
    II(0x101952d7, 0x2)   int_(0x2f);                           /* int 0x2f */
    II(0x101952d9, 0x1)   popd(es);                             /* pop es */
    II(0x101952da, 0x2)   popd(gs);                             /* pop gs */
    II(0x101952dc, 0x2)   popd(fs);                             /* pop fs */
    II(0x101952de, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101952df, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101952e0, 0x1)   popd(edi);                            /* pop edi */
    II(0x101952e1, 0x1)   popd(esi);                            /* pop esi */
    II(0x101952e2, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101952e3, 0x1)   retd();                               /* ret */
FUNC_END

