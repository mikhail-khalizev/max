FUNC_BEGIN(sys_fseek, 0x392d19d6ab423c5a, 0x20, ({0x51, 0x56, 0x57, 0x89, 0xc1, 0x89, 0xd6, 0xf6, 0x40, 0xc, 0x6, 0x74, 0x5b, 0xf6, 0x41, 0xd, 0x10, 0x74, 0x26, 0x89, 0xc8, 0xe8, 0x4f, 0xb1, 0x1, 0, 0x85, 0xc0, 0x74, 0x2f, 0x85, 0xdb, 0x75, 0xe, 0x85, 0xf6, 0x7d, 0xa, 0xb8, 0x9, 0, 0, 0, 0xe8, 0x1f, 0xaf, 0x1, 0, 0xb8, 0xff, 0xff, 0xff, 0xff, 0x5f, 0x5e, 0x59, 0xc3, 0x83, 0xfb, 0x1, 0x75, 0x3, 0x2b, 0x71, 0x4, 0x8b, 0x41, 0x8, 0xc7, 0x41, 0x4, 0, 0, 0, 0, 0x89, 0x1, 0x80, 0x61, 0xc, 0xeb, 0x89, 0xf2, 0x8b, 0x41, 0x10, 0xe8, 0xcc, 0xac, 0, 0, 0x83, 0xf8, 0xff, 0xf, 0x85, 0x92, 0, 0, 0, 0x5f, 0x5e, 0x59, 0xc3, 0x83, 0xfb, 0x1, 0x72, 0x9, 0x76, 0xd, 0x83, 0xfb, 0x2, 0x74, 0x5e, 0xeb, 0xb0, 0x85, 0xdb, 0x74, 0x27, 0xeb, 0xaa, 0x89, 0xca, 0x89, 0xf0, 0x8b, 0x79, 0x4, 0xe8, 0x36, 0xff, 0xff, 0xff, 0x85, 0xc0, 0x74, 0x6a, 0x89, 0xf2, 0x8b, 0x41, 0x10, 0x29, 0xfa, 0xe8, 0x8f, 0xac, 0, 0, 0x83, 0xf8, 0xff, 0x75, 0x59, 0x5f, 0x5e, 0x59, 0xc3, 0x8b, 0x41, 0x10, 0xe8, 0x4, 0xb2, 0x1, 0, 0x8b, 0x51, 0x4, 0x89, 0xf7, 0x29, 0xd0, 0x29, 0xc7, 0x89, 0xca, 0x89, 0xf8, 0xe8, 0x3, 0xff, 0xff, 0xff, 0x85, 0xc0, 0x74, 0x37, 0x89, 0xf2, 0x8b, 0x41, 0x10, 0xe8, 0x5e, 0xac, 0, 0, 0x83, 0xf8, 0xff, 0x75, 0x28, 0x5f, 0x5e, 0x59, 0xc3, 0x8b, 0x41, 0x8, 0x8a, 0x51, 0xc, 0x89, 0x1, 0x80, 0xe2, 0xef, 0x8b, 0x41, 0x10, 0x88, 0x51, 0xc, 0x89, 0xf2, 0xc7, 0x41, 0x4, 0, 0, 0, 0, 0xe8, 0x36, 0xac, 0, 0, 0x83, 0xf8, 0xff, 0x74, 0x2, 0x31, 0xc0, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x10172470, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10172471, 0x1)   pushd(esi);                           /* push esi */
    II(0x10172472, 0x1)   pushd(edi);                           /* push edi */
    II(0x10172473, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x10172475, 0x2)   mov(esi, edx);                        /* mov esi, edx */
    II(0x10172477, 0x4)   test(memb_a32(ds, eax + 0xc), 0x6);   /* test byte [eax+0xc], 0x6 */
    II(0x1017247b, 0x2)   jzd(0x101724d8, 0x5b);                /* jz 0x101724d8 */
    II(0x1017247d, 0x4)   test(memb_a32(ds, ecx + 0xd), 0x10);  /* test byte [ecx+0xd], 0x10 */
    II(0x10172481, 0x2)   jzd(0x101724a9, 0x26);                /* jz 0x101724a9 */
    II(0x10172483, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x10172485, 0x5)   calld(/* sys */ 0x1018d5d9, 0x1b14f); /* call 0x1018d5d9 */
    II(0x1017248a, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1017248c, 0x2)   jzd(0x101724bd, 0x2f);                /* jz 0x101724bd */
    II(0x1017248e, 0x2)   test(ebx, ebx);                       /* test ebx, ebx */
    II(0x10172490, 0x2)   jnzd(0x101724a0, 0xe);                /* jnz 0x101724a0 */
    II(0x10172492, 0x2)   test(esi, esi);                       /* test esi, esi */
    II(0x10172494, 0x2)   jged(0x101724a0, 0xa);                /* jge 0x101724a0 */
l_0x10172496:
    II(0x10172496, 0x5)   mov(eax, 0x9);                        /* mov eax, 0x9 */
    II(0x1017249b, 0x5)   calld(/* sys */ 0x1018d3bf, 0x1af1f); /* call 0x1018d3bf */
l_0x101724a0:
    II(0x101724a0, 0x5)   mov(eax, 0xffffffff);                 /* mov eax, 0xffffffff */
    II(0x101724a5, 0x1)   popd(edi);                            /* pop edi */
    II(0x101724a6, 0x1)   popd(esi);                            /* pop esi */
    II(0x101724a7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101724a8, 0x1)   retd();                               /* ret */
l_0x101724a9:
    II(0x101724a9, 0x3)   cmp(ebx, 0x1);                        /* cmp ebx, 0x1 */
    II(0x101724ac, 0x2)   jnzd(0x101724b1, 0x3);                /* jnz 0x101724b1 */
    II(0x101724ae, 0x3)   sub(esi, memd_a32(ds, ecx + 0x4));    /* sub esi, [ecx+0x4] */
l_0x101724b1:
    II(0x101724b1, 0x3)   mov(eax, memd_a32(ds, ecx + 0x8));    /* mov eax, [ecx+0x8] */
    II(0x101724b4, 0x7)   mov(memd_a32(ds, ecx + 0x4), 0);      /* mov dword [ecx+0x4], 0x0 */
    II(0x101724bb, 0x2)   mov(memd_a32(ds, ecx), eax);          /* mov [ecx], eax */
l_0x101724bd:
    II(0x101724bd, 0x4)   and_(memb_a32(ds, ecx + 0xc), -0x15 /* 0xeb */); /* and byte [ecx+0xc], 0xeb */
    II(0x101724c1, 0x2)   mov(edx, esi);                        /* mov edx, esi */
    II(0x101724c3, 0x3)   mov(eax, memd_a32(ds, ecx + 0x10));   /* mov eax, [ecx+0x10] */
    II(0x101724c6, 0x5)   calld(sys_lseek, 0xaccc);             /* call 0x1017d197 */
    II(0x101724cb, 0x3)   cmp(eax, -0x1 /* 0xff */);            /* cmp eax, 0xff */
    II(0x101724ce, 0x6)   jnzd(0x10172566, 0x92);               /* jnz dword 0x10172566 */
    II(0x101724d4, 0x1)   popd(edi);                            /* pop edi */
    II(0x101724d5, 0x1)   popd(esi);                            /* pop esi */
    II(0x101724d6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101724d7, 0x1)   retd();                               /* ret */
l_0x101724d8:
    II(0x101724d8, 0x3)   cmp(ebx, 0x1);                        /* cmp ebx, 0x1 */
    II(0x101724db, 0x2)   jbd(0x101724e6, 0x9);                 /* jb 0x101724e6 */
    II(0x101724dd, 0x2)   jbed(0x101724ec, 0xd);                /* jbe 0x101724ec */
    II(0x101724df, 0x3)   cmp(ebx, 0x2);                        /* cmp ebx, 0x2 */
    II(0x101724e2, 0x2)   jzd(0x10172542, 0x5e);                /* jz 0x10172542 */
    II(0x101724e4, 0x2)   jmpd(0x10172496, -0x50);              /* jmp 0x10172496 */
l_0x101724e6:
    II(0x101724e6, 0x2)   test(ebx, ebx);                       /* test ebx, ebx */
    II(0x101724e8, 0x2)   jzd(0x10172511, 0x27);                /* jz 0x10172511 */
    II(0x101724ea, 0x2)   jmpd(0x10172496, -0x56);              /* jmp 0x10172496 */
l_0x101724ec:
    II(0x101724ec, 0x2)   mov(edx, ecx);                        /* mov edx, ecx */
    II(0x101724ee, 0x2)   mov(eax, esi);                        /* mov eax, esi */
    II(0x101724f0, 0x3)   mov(edi, memd_a32(ds, ecx + 0x4));    /* mov edi, [ecx+0x4] */
    II(0x101724f3, 0x5)   calld(/* sys */ 0x1017242e, -0xca);   /* call 0x1017242e */
    II(0x101724f8, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x101724fa, 0x2)   jzd(0x10172566, 0x6a);                /* jz 0x10172566 */
    II(0x101724fc, 0x2)   mov(edx, esi);                        /* mov edx, esi */
    II(0x101724fe, 0x3)   mov(eax, memd_a32(ds, ecx + 0x10));   /* mov eax, [ecx+0x10] */
    II(0x10172501, 0x2)   sub(edx, edi);                        /* sub edx, edi */
    II(0x10172503, 0x5)   calld(sys_lseek, 0xac8f);             /* call 0x1017d197 */
    II(0x10172508, 0x3)   cmp(eax, -0x1 /* 0xff */);            /* cmp eax, 0xff */
    II(0x1017250b, 0x2)   jnzd(0x10172566, 0x59);               /* jnz 0x10172566 */
    II(0x1017250d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1017250e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1017250f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10172510, 0x1)   retd();                               /* ret */
l_0x10172511:
    II(0x10172511, 0x3)   mov(eax, memd_a32(ds, ecx + 0x10));   /* mov eax, [ecx+0x10] */
    II(0x10172514, 0x5)   calld(/* sys */ 0x1018d71d, 0x1b204); /* call 0x1018d71d */
    II(0x10172519, 0x3)   mov(edx, memd_a32(ds, ecx + 0x4));    /* mov edx, [ecx+0x4] */
    II(0x1017251c, 0x2)   mov(edi, esi);                        /* mov edi, esi */
    II(0x1017251e, 0x2)   sub(eax, edx);                        /* sub eax, edx */
    II(0x10172520, 0x2)   sub(edi, eax);                        /* sub edi, eax */
    II(0x10172522, 0x2)   mov(edx, ecx);                        /* mov edx, ecx */
    II(0x10172524, 0x2)   mov(eax, edi);                        /* mov eax, edi */
    II(0x10172526, 0x5)   calld(/* sys */ 0x1017242e, -0xfd);   /* call 0x1017242e */
    II(0x1017252b, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1017252d, 0x2)   jzd(0x10172566, 0x37);                /* jz 0x10172566 */
    II(0x1017252f, 0x2)   mov(edx, esi);                        /* mov edx, esi */
    II(0x10172531, 0x3)   mov(eax, memd_a32(ds, ecx + 0x10));   /* mov eax, [ecx+0x10] */
    II(0x10172534, 0x5)   calld(sys_lseek, 0xac5e);             /* call 0x1017d197 */
    II(0x10172539, 0x3)   cmp(eax, -0x1 /* 0xff */);            /* cmp eax, 0xff */
    II(0x1017253c, 0x2)   jnzd(0x10172566, 0x28);               /* jnz 0x10172566 */
    II(0x1017253e, 0x1)   popd(edi);                            /* pop edi */
    II(0x1017253f, 0x1)   popd(esi);                            /* pop esi */
    II(0x10172540, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10172541, 0x1)   retd();                               /* ret */
l_0x10172542:
    II(0x10172542, 0x3)   mov(eax, memd_a32(ds, ecx + 0x8));    /* mov eax, [ecx+0x8] */
    II(0x10172545, 0x3)   mov(dl, memb_a32(ds, ecx + 0xc));     /* mov dl, [ecx+0xc] */
    II(0x10172548, 0x2)   mov(memd_a32(ds, ecx), eax);          /* mov [ecx], eax */
    II(0x1017254a, 0x3)   and_(dl, 0xef);                       /* and dl, 0xef */
    II(0x1017254d, 0x3)   mov(eax, memd_a32(ds, ecx + 0x10));   /* mov eax, [ecx+0x10] */
    II(0x10172550, 0x3)   mov(memb_a32(ds, ecx + 0xc), dl);     /* mov [ecx+0xc], dl */
    II(0x10172553, 0x2)   mov(edx, esi);                        /* mov edx, esi */
    II(0x10172555, 0x7)   mov(memd_a32(ds, ecx + 0x4), 0);      /* mov dword [ecx+0x4], 0x0 */
    II(0x1017255c, 0x5)   calld(sys_lseek, 0xac36);             /* call 0x1017d197 */
    II(0x10172561, 0x3)   cmp(eax, -0x1 /* 0xff */);            /* cmp eax, 0xff */
    II(0x10172564, 0x2)   jzd(0x10172568, 0x2);                 /* jz 0x10172568 */
l_0x10172566:
    II(0x10172566, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
l_0x10172568:
    II(0x10172568, 0x1)   popd(edi);                            /* pop edi */
    II(0x10172569, 0x1)   popd(esi);                            /* pop esi */
    II(0x1017256a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1017256b, 0x1)   retd();                               /* ret */
FUNC_END

