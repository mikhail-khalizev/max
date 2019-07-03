FUNC_BEGIN(/* sys */ 0x10194d7e, 0x99e69f18e289b8d9, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0x66, 0xb8, 0, 0, 0x66, 0xb9, 0x1, 0, 0xcd, 0x31, 0x50, 0x50, 0x50, 0x50, 0x66, 0x8b, 0x5d, 0xc, 0x66, 0xb8, 0x6, 0, 0xcd, 0x31, 0x5b, 0x66, 0xb8, 0x7, 0, 0xcd, 0x31, 0x66, 0xb8, 0x8, 0, 0x5b, 0x33, 0xc9, 0xba, 0xff, 0xff, 0, 0, 0xcd, 0x31, 0x66, 0xb8, 0x9, 0, 0x5b, 0xf, 0x2, 0xcb, 0xc1, 0xe9, 0x8, 0x66, 0x81, 0xc9, 0x8, 0x40, 0xcd, 0x31, 0x5a, 0x33, 0xc0, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x10194d7e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10194d7f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10194d81, 0x1)   pushd(esi);                           /* push esi */
    II(0x10194d82, 0x1)   pushd(edi);                           /* push edi */
    II(0x10194d83, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10194d84, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10194d85, 0x2)   pushd(fs);                            /* push fs */
    II(0x10194d87, 0x2)   pushd(gs);                            /* push gs */
    II(0x10194d89, 0x1)   pushd(es);                            /* push es */
    II(0x10194d8a, 0x4)   mov(ax, 0);                           /* mov ax, 0x0 */
    II(0x10194d8e, 0x4)   mov(cx, 0x1);                         /* mov cx, 0x1 */
    II(0x10194d92, 0x2)   int_(0x31);                           /* int 0x31 */
    II(0x10194d94, 0x1)   pushd(eax);                           /* push eax */
    II(0x10194d95, 0x1)   pushd(eax);                           /* push eax */
    II(0x10194d96, 0x1)   pushd(eax);                           /* push eax */
    II(0x10194d97, 0x1)   pushd(eax);                           /* push eax */
    II(0x10194d98, 0x4)   mov(bx, memw_a32(ss, ebp + 0xc));     /* mov bx, [ebp+0xc] */
    II(0x10194d9c, 0x4)   mov(ax, 0x6);                         /* mov ax, 0x6 */
    II(0x10194da0, 0x2)   int_(0x31);                           /* int 0x31 */
    II(0x10194da2, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10194da3, 0x4)   mov(ax, 0x7);                         /* mov ax, 0x7 */
    II(0x10194da7, 0x2)   int_(0x31);                           /* int 0x31 */
    II(0x10194da9, 0x4)   mov(ax, 0x8);                         /* mov ax, 0x8 */
    II(0x10194dad, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10194dae, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x10194db0, 0x5)   mov(edx, 0xffff);                     /* mov edx, 0xffff */
    II(0x10194db5, 0x2)   int_(0x31);                           /* int 0x31 */
    II(0x10194db7, 0x4)   mov(ax, 0x9);                         /* mov ax, 0x9 */
    II(0x10194dbb, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10194dbc, 0x3)   lar(ecx, bx);                         /* lar ecx, bx */
    II(0x10194dbf, 0x3)   shr(ecx, 0x8);                        /* shr ecx, 0x8 */
    II(0x10194dc2, 0x5)   or_(cx, 0x4008);                      /* or cx, 0x4008 */
    II(0x10194dc7, 0x2)   int_(0x31);                           /* int 0x31 */
    II(0x10194dc9, 0x1)   popd(edx);                            /* pop edx */
    II(0x10194dca, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10194dcc, 0x1)   popd(es);                             /* pop es */
    II(0x10194dcd, 0x2)   popd(gs);                             /* pop gs */
    II(0x10194dcf, 0x2)   popd(fs);                             /* pop fs */
    II(0x10194dd1, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10194dd2, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10194dd3, 0x1)   popd(edi);                            /* pop edi */
    II(0x10194dd4, 0x1)   popd(esi);                            /* pop esi */
    II(0x10194dd5, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10194dd6, 0x1)   retd();                               /* ret */
FUNC_END

