FUNC_BEGIN(/* sys */ 0x101952e4, 0xb1cd5e4031643fea, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0x66, 0xb8, 0, 0x1, 0x8b, 0x5d, 0x8, 0xcd, 0x31, 0x73, 0xe, 0x90, 0x90, 0x90, 0x90, 0xb8, 0x1, 0, 0, 0, 0xeb, 0x14, 0x90, 0x90, 0x90, 0x8b, 0x75, 0xc, 0x66, 0x89, 0x16, 0x8b, 0x75, 0x10, 0x66, 0x89, 0x6, 0xb8, 0, 0, 0, 0, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x101952e4, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101952e5, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101952e7, 0x1)   pushd(esi);                           /* push esi */
    II(0x101952e8, 0x1)   pushd(edi);                           /* push edi */
    II(0x101952e9, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101952ea, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101952eb, 0x2)   pushd(fs);                            /* push fs */
    II(0x101952ed, 0x2)   pushd(gs);                            /* push gs */
    II(0x101952ef, 0x1)   pushd(es);                            /* push es */
    II(0x101952f0, 0x4)   mov(ax, 0x100);                       /* mov ax, 0x100 */
    II(0x101952f4, 0x3)   mov(ebx, memd_a32(ss, ebp + 0x8));    /* mov ebx, [ebp+0x8] */
    II(0x101952f7, 0x2)   int_(0x31);                           /* int 0x31 */
    II(0x101952f9, 0x2)   jaed(0x10195309, 0xe);                /* jae 0x10195309 */
//    II(0x101952fb, 0x1)   nop();                                /* nop */
//    II(0x101952fc, 0x1)   nop();                                /* nop */
//    II(0x101952fd, 0x1)   nop();                                /* nop */
//    II(0x101952fe, 0x1)   nop();                                /* nop */
    II(0x101952ff, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
    II(0x10195304, 0x2)   jmpd(0x1019531a, 0x14);               /* jmp 0x1019531a */
//  II(0x10195306, 0x3)   /* Недостижимый код. */
l_0x10195309:
    II(0x10195309, 0x3)   mov(esi, memd_a32(ss, ebp + 0xc));    /* mov esi, [ebp+0xc] */
    II(0x1019530c, 0x3)   mov(memw_a32(ds, esi), dx);           /* mov [esi], dx */
    II(0x1019530f, 0x3)   mov(esi, memd_a32(ss, ebp + 0x10));   /* mov esi, [ebp+0x10] */
    II(0x10195312, 0x3)   mov(memw_a32(ds, esi), ax);           /* mov [esi], ax */
    II(0x10195315, 0x5)   mov(eax, 0);                          /* mov eax, 0x0 */
l_0x1019531a:
    II(0x1019531a, 0x1)   popd(es);                             /* pop es */
    II(0x1019531b, 0x2)   popd(gs);                             /* pop gs */
    II(0x1019531d, 0x2)   popd(fs);                             /* pop fs */
    II(0x1019531f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10195320, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10195321, 0x1)   popd(edi);                            /* pop edi */
    II(0x10195322, 0x1)   popd(esi);                            /* pop esi */
    II(0x10195323, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10195324, 0x1)   retd();                               /* ret */
FUNC_END

