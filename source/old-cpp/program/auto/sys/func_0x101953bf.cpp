FUNC_BEGIN(/* sys */ 0x101953bf, 0x58b64fd50587e11d, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0xbe, 0xfc, 0x1a, 0x1c, 0x10, 0xc7, 0x46, 0x1c, 0x8, 0x81, 0, 0, 0xc7, 0x46, 0x14, 0, 0, 0, 0, 0x66, 0x8b, 0x45, 0x8, 0x66, 0x89, 0x46, 0x22, 0xc7, 0x6, 0, 0, 0, 0, 0x66, 0xb8, 0, 0x3, 0xb3, 0x4b, 0xb7, 0, 0x66, 0xb9, 0, 0, 0xbf, 0xfc, 0x1a, 0x1c, 0x10, 0x1e, 0x7, 0xcd, 0x31, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x101953bf, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101953c0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101953c2, 0x1)   pushd(esi);                           /* push esi */
    II(0x101953c3, 0x1)   pushd(edi);                           /* push edi */
    II(0x101953c4, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101953c5, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101953c6, 0x2)   pushd(fs);                            /* push fs */
    II(0x101953c8, 0x2)   pushd(gs);                            /* push gs */
    II(0x101953ca, 0x1)   pushd(es);                            /* push es */
    II(0x101953cb, 0x5)   mov(esi, 0x101c1afc);                 /* mov esi, 0x101c1afc */
    II(0x101953d0, 0x7)   mov(memd_a32(ds, esi + 0x1c), 0x8108); /* mov dword [esi+0x1c], 0x8108 */
    II(0x101953d7, 0x7)   mov(memd_a32(ds, esi + 0x14), 0);     /* mov dword [esi+0x14], 0x0 */
    II(0x101953de, 0x4)   mov(ax, memw_a32(ss, ebp + 0x8));     /* mov ax, [ebp+0x8] */
    II(0x101953e2, 0x4)   mov(memw_a32(ds, esi + 0x22), ax);    /* mov [esi+0x22], ax */
    II(0x101953e6, 0x6)   mov(memd_a32(ds, esi), 0);            /* mov dword [esi], 0x0 */
    II(0x101953ec, 0x4)   mov(ax, 0x300);                       /* mov ax, 0x300 */
    II(0x101953f0, 0x2)   mov(bl, 0x4b);                        /* mov bl, 0x4b */
    II(0x101953f2, 0x2)   mov(bh, 0);                           /* mov bh, 0x0 */
    II(0x101953f4, 0x4)   mov(cx, 0);                           /* mov cx, 0x0 */
    II(0x101953f8, 0x5)   mov(edi, 0x101c1afc);                 /* mov edi, 0x101c1afc */
    II(0x101953fd, 0x1)   pushd(ds);                            /* push ds */
    II(0x101953fe, 0x1)   popd(es);                             /* pop es */
    II(0x101953ff, 0x2)   int_(0x31);                           /* int 0x31 */
    II(0x10195401, 0x1)   popd(es);                             /* pop es */
    II(0x10195402, 0x2)   popd(gs);                             /* pop gs */
    II(0x10195404, 0x2)   popd(fs);                             /* pop fs */
    II(0x10195406, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10195407, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10195408, 0x1)   popd(edi);                            /* pop edi */
    II(0x10195409, 0x1)   popd(esi);                            /* pop esi */
    II(0x1019540a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1019540b, 0x1)   retd();                               /* ret */
FUNC_END

