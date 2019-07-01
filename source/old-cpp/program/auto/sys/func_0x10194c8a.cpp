FUNC_BEGIN(/* sys */ 0x10194c8a, 0x720229789189e72d, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0x66, 0x8b, 0x4d, 0x8, 0x66, 0x8b, 0x5d, 0xa, 0x66, 0x8b, 0x7d, 0xc, 0x66, 0x8b, 0x75, 0xe, 0x66, 0xb8, 0, 0x6, 0xcd, 0x31, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x10194c8a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10194c8b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10194c8d, 0x1)   pushd(esi);                           /* push esi */
    II(0x10194c8e, 0x1)   pushd(edi);                           /* push edi */
    II(0x10194c8f, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10194c90, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10194c91, 0x2)   pushd(fs);                            /* push fs */
    II(0x10194c93, 0x2)   pushd(gs);                            /* push gs */
    II(0x10194c95, 0x1)   pushd(es);                            /* push es */
    II(0x10194c96, 0x4)   mov(cx, memw_a32(ss, ebp + 0x8));     /* mov cx, [ebp+0x8] */
    II(0x10194c9a, 0x4)   mov(bx, memw_a32(ss, ebp + 0xa));     /* mov bx, [ebp+0xa] */
    II(0x10194c9e, 0x4)   mov(di, memw_a32(ss, ebp + 0xc));     /* mov di, [ebp+0xc] */
    II(0x10194ca2, 0x4)   mov(si, memw_a32(ss, ebp + 0xe));     /* mov si, [ebp+0xe] */
    II(0x10194ca6, 0x4)   mov(ax, 0x600);                       /* mov ax, 0x600 */
    II(0x10194caa, 0x2)   int_(0x31);                           /* int 0x31 */
    II(0x10194cac, 0x1)   popd(es);                             /* pop es */
    II(0x10194cad, 0x2)   popd(gs);                             /* pop gs */
    II(0x10194caf, 0x2)   popd(fs);                             /* pop fs */
    II(0x10194cb1, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10194cb2, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10194cb3, 0x1)   popd(edi);                            /* pop edi */
    II(0x10194cb4, 0x1)   popd(esi);                            /* pop esi */
    II(0x10194cb5, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10194cb6, 0x1)   retd();                               /* ret */
FUNC_END

