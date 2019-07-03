FUNC_BEGIN(/* sys */ 0x1019548c, 0xfaf77b3b51216bfd, 0x20, ({0x66, 0x8c, 0xd8, 0x8e, 0xe8, 0x8e, 0xe0, 0x8e, 0xc0, 0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0x66, 0xb8, 0x1, 0, 0x66, 0x8b, 0x5d, 0x8, 0xcd, 0x31, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x1019548c, 0x3)   mov(ax, ds);                          /* mov ax, ds */
    II(0x1019548f, 0x2)   mov(gs, eax);                         /* mov gs, eax */
    II(0x10195491, 0x2)   mov(fs, eax);                         /* mov fs, eax */
    II(0x10195493, 0x2)   mov(es, eax);                         /* mov es, eax */
    II(0x10195495, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10195496, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10195498, 0x1)   pushd(esi);                           /* push esi */
    II(0x10195499, 0x1)   pushd(edi);                           /* push edi */
    II(0x1019549a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1019549b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1019549c, 0x2)   pushd(fs);                            /* push fs */
    II(0x1019549e, 0x2)   pushd(gs);                            /* push gs */
    II(0x101954a0, 0x1)   pushd(es);                            /* push es */
    II(0x101954a1, 0x4)   mov(ax, 0x1);                         /* mov ax, 0x1 */
    II(0x101954a5, 0x4)   mov(bx, memw_a32(ss, ebp + 0x8));     /* mov bx, [ebp+0x8] */
    II(0x101954a9, 0x2)   int_(0x31);                           /* int 0x31 */
    II(0x101954ab, 0x1)   popd(es);                             /* pop es */
    II(0x101954ac, 0x2)   popd(gs);                             /* pop gs */
    II(0x101954ae, 0x2)   popd(fs);                             /* pop fs */
    II(0x101954b0, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101954b1, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101954b2, 0x1)   popd(edi);                            /* pop edi */
    II(0x101954b3, 0x1)   popd(esi);                            /* pop esi */
    II(0x101954b4, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101954b5, 0x1)   retd();                               /* ret */
FUNC_END

