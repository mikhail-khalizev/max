FUNC_BEGIN(/* sys */ 0x101954bf, 0x97fd4074f1de824e, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xc5, 0x8b, 0x35, 0xf8, 0x1c, 0x1c, 0x10, 0x85, 0xf6, 0x74, 0x46, 0x85, 0xc0, 0x74, 0x42, 0x89, 0xc7, 0x6, 0x8c, 0xd8, 0x8e, 0xc0, 0x29, 0xc9, 0x49, 0x31, 0xc0, 0xf2, 0xae, 0xf7, 0xd1, 0x49, 0x7, 0x89, 0xcf, 0xeb, 0x26, 0x89, 0xfb, 0x89, 0xea, 0x89, 0xc8, 0xe8, 0x3b, 0x80, 0xfe, 0xff, 0x85, 0xc0, 0x75, 0x14, 0x8a, 0x4, 0x39, 0x25, 0xff, 0, 0, 0, 0x83, 0xf8, 0x3d, 0x75, 0x7, 0x8d, 0x47, 0x1, 0x1, 0xc8, 0xeb, 0xb, 0x83, 0xc6, 0x4, 0x8b, 0xe, 0x85, 0xc9, 0x75, 0xd4, 0x31, 0xc0, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101954bf, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101954c0, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101954c1, 0x1)   pushd(edx);                           /* push edx */
    II(0x101954c2, 0x1)   pushd(esi);                           /* push esi */
    II(0x101954c3, 0x1)   pushd(edi);                           /* push edi */
    II(0x101954c4, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101954c5, 0x2)   mov(ebp, eax);                        /* mov ebp, eax */
    II(0x101954c7, 0x6)   mov(esi, memd_a32(ds, 0x101c1cf8));   /* mov esi, [0x101c1cf8] */
    II(0x101954cd, 0x2)   test(esi, esi);                       /* test esi, esi */
    II(0x101954cf, 0x2)   jzd(0x10195517, 0x46);                /* jz 0x10195517 */
    II(0x101954d1, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x101954d3, 0x2)   jzd(0x10195517, 0x42);                /* jz 0x10195517 */
    II(0x101954d5, 0x2)   mov(edi, eax);                        /* mov edi, eax */
    II(0x101954d7, 0x1)   pushd(es);                            /* push es */
    II(0x101954d8, 0x2)   mov(eax, ds);                         /* mov eax, ds */
    II(0x101954da, 0x2)   mov(es, eax);                         /* mov es, eax */
    II(0x101954dc, 0x2)   sub(ecx, ecx);                        /* sub ecx, ecx */
    II(0x101954de, 0x1)   dec(ecx);                             /* dec ecx */
    II(0x101954df, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x101954e1, 0x2)   repne_a32 scasb_a32();                /* repne scasb */
    II(0x101954e3, 0x2)   not_(ecx);                            /* not ecx */
    II(0x101954e5, 0x1)   dec(ecx);                             /* dec ecx */
    II(0x101954e6, 0x1)   popd(es);                             /* pop es */
    II(0x101954e7, 0x2)   mov(edi, ecx);                        /* mov edi, ecx */
    II(0x101954e9, 0x2)   jmpd(0x10195511, 0x26);               /* jmp 0x10195511 */
l_0x101954eb:
    II(0x101954eb, 0x2)   mov(ebx, edi);                        /* mov ebx, edi */
    II(0x101954ed, 0x2)   mov(edx, ebp);                        /* mov edx, ebp */
    II(0x101954ef, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x101954f1, 0x5)   calld(/* sys */ 0x1017d531, -0x17fc5); /* call 0x1017d531 */
    II(0x101954f6, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x101954f8, 0x2)   jnzd(0x1019550e, 0x14);               /* jnz 0x1019550e */
    II(0x101954fa, 0x3)   mov(al, memb_a32(ds, ecx + edi));     /* mov al, [ecx+edi] */
    II(0x101954fd, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x10195502, 0x3)   cmp(eax, 0x3d);                       /* cmp eax, 0x3d */
    II(0x10195505, 0x2)   jnzd(0x1019550e, 0x7);                /* jnz 0x1019550e */
    II(0x10195507, 0x3)   lea(eax, edi + 0x1);                  /* lea eax, [edi+0x1] */
    II(0x1019550a, 0x2)   add(eax, ecx);                        /* add eax, ecx */
    II(0x1019550c, 0x2)   jmpd(0x10195519, 0xb);                /* jmp 0x10195519 */
l_0x1019550e:
    II(0x1019550e, 0x3)   add(esi, 0x4);                        /* add esi, 0x4 */
l_0x10195511:
    II(0x10195511, 0x2)   mov(ecx, memd_a32(ds, esi));          /* mov ecx, [esi] */
    II(0x10195513, 0x2)   test(ecx, ecx);                       /* test ecx, ecx */
    II(0x10195515, 0x2)   jnzd(0x101954eb, -0x2c);              /* jnz 0x101954eb */
l_0x10195517:
    II(0x10195517, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
l_0x10195519:
    II(0x10195519, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1019551a, 0x1)   popd(edi);                            /* pop edi */
    II(0x1019551b, 0x1)   popd(esi);                            /* pop esi */
    II(0x1019551c, 0x1)   popd(edx);                            /* pop edx */
    II(0x1019551d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1019551e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1019551f, 0x1)   retd();                               /* ret */
FUNC_END

