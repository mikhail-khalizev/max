FUNC_BEGIN(/* sys */ 0x10194d46, 0x6ae4891c0e5227e6, 0x20, ({0x50, 0x66, 0x8c, 0xd8, 0x8e, 0xe8, 0x8e, 0xd8, 0x58, 0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0x66, 0x8b, 0x75, 0x10, 0x66, 0x8b, 0x7d, 0x12, 0x66, 0xb8, 0x2, 0x5, 0xcd, 0x31, 0x66, 0xb8, 0x1, 0, 0x66, 0x8b, 0x5d, 0xc, 0xcd, 0x31, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x10194d46, 0x1)   pushd(eax);                           /* push eax */
    II(0x10194d47, 0x3)   mov(ax, ds);                          /* mov ax, ds */
    II(0x10194d4a, 0x2)   mov(gs, eax);                         /* mov gs, eax */
    II(0x10194d4c, 0x2)   mov(ds, eax);                         /* mov ds, eax */
    II(0x10194d4e, 0x1)   popd(eax);                            /* pop eax */
    II(0x10194d4f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10194d50, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10194d52, 0x1)   pushd(esi);                           /* push esi */
    II(0x10194d53, 0x1)   pushd(edi);                           /* push edi */
    II(0x10194d54, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10194d55, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10194d56, 0x2)   pushd(fs);                            /* push fs */
    II(0x10194d58, 0x2)   pushd(gs);                            /* push gs */
    II(0x10194d5a, 0x1)   pushd(es);                            /* push es */
    II(0x10194d5b, 0x4)   mov(si, memw_a32(ss, ebp + 0x10));    /* mov si, [ebp+0x10] */
    II(0x10194d5f, 0x4)   mov(di, memw_a32(ss, ebp + 0x12));    /* mov di, [ebp+0x12] */
    II(0x10194d63, 0x4)   mov(ax, 0x502);                       /* mov ax, 0x502 */
    II(0x10194d67, 0x2)   int_(0x31);                           /* int 0x31 */
    II(0x10194d69, 0x4)   mov(ax, 0x1);                         /* mov ax, 0x1 */
    II(0x10194d6d, 0x4)   mov(bx, memw_a32(ss, ebp + 0xc));     /* mov bx, [ebp+0xc] */
    II(0x10194d71, 0x2)   int_(0x31);                           /* int 0x31 */
    II(0x10194d73, 0x1)   popd(es);                             /* pop es */
    II(0x10194d74, 0x2)   popd(gs);                             /* pop gs */
    II(0x10194d76, 0x2)   popd(fs);                             /* pop fs */
    II(0x10194d78, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10194d79, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10194d7a, 0x1)   popd(edi);                            /* pop edi */
    II(0x10194d7b, 0x1)   popd(esi);                            /* pop esi */
    II(0x10194d7c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10194d7d, 0x1)   retd();                               /* ret */
FUNC_END

