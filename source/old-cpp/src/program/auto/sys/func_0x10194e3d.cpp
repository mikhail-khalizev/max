FUNC_BEGIN(/* sys */ 0x10194e3d, 0xce3011876dda599f, 0x20, ({0x66, 0x8c, 0xd8, 0x8e, 0xe8, 0x8e, 0xc0, 0x8e, 0xe0, 0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0x33, 0xc0, 0x66, 0xb8, 0x1, 0x1, 0x8b, 0x55, 0x8, 0xcd, 0x31, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x10194e3d, 0x3)   mov(ax, ds);                          /* mov ax, ds */
    II(0x10194e40, 0x2)   mov(gs, eax);                         /* mov gs, eax */
    II(0x10194e42, 0x2)   mov(es, eax);                         /* mov es, eax */
    II(0x10194e44, 0x2)   mov(fs, eax);                         /* mov fs, eax */
    II(0x10194e46, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10194e47, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10194e49, 0x1)   pushd(esi);                           /* push esi */
    II(0x10194e4a, 0x1)   pushd(edi);                           /* push edi */
    II(0x10194e4b, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10194e4c, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10194e4d, 0x2)   pushd(fs);                            /* push fs */
    II(0x10194e4f, 0x2)   pushd(gs);                            /* push gs */
    II(0x10194e51, 0x1)   pushd(es);                            /* push es */
    II(0x10194e52, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10194e54, 0x4)   mov(ax, 0x101);                       /* mov ax, 0x101 */
    II(0x10194e58, 0x3)   mov(edx, memd_a32(ss, ebp + 0x8));    /* mov edx, [ebp+0x8] */
    II(0x10194e5b, 0x2)   int_(0x31);                           /* int 0x31 */
    II(0x10194e5d, 0x1)   popd(es);                             /* pop es */
    II(0x10194e5e, 0x2)   popd(gs);                             /* pop gs */
    II(0x10194e60, 0x2)   popd(fs);                             /* pop fs */
    II(0x10194e62, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10194e63, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10194e64, 0x1)   popd(edi);                            /* pop edi */
    II(0x10194e65, 0x1)   popd(esi);                            /* pop esi */
    II(0x10194e66, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10194e67, 0x1)   retd();                               /* ret */
FUNC_END

