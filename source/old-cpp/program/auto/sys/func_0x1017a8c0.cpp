FUNC_BEGIN(/* sys */ 0x1017a8c0, 0x6523ca74dec3a1d5, 0x20, ({0x55, 0x89, 0xe5, 0x51, 0x57, 0x85, 0xc0, 0x7d, 0xd, 0xa1, 0xb4, 0x9c, 0x20, 0x10, 0x2b, 0x5, 0xd0, 0x9c, 0x20, 0x10, 0xd1, 0xe8, 0x85, 0xd2, 0x7d, 0x2b, 0xf6, 0x5, 0, 0xe2, 0x1b, 0x10, 0x4, 0x74, 0x14, 0x8b, 0x15, 0xf0, 0x9c, 0x20, 0x10, 0x8b, 0xd, 0xbc, 0x9c, 0x20, 0x10, 0x1, 0xd2, 0x29, 0xd1, 0x89, 0xca, 0xeb, 0xc, 0x8b, 0x15, 0xbc, 0x9c, 0x20, 0x10, 0x2b, 0x15, 0xf0, 0x9c, 0x20, 0x10, 0xd1, 0xea, 0x80, 0x35, 0x8, 0xe2, 0x1b, 0x10, 0x1, 0x8b, 0xd, 0x8, 0xe2, 0x1b, 0x10, 0x24, 0xfc, 0x8b, 0x3c, 0x8d, 0xc, 0xe2, 0x1b, 0x10, 0x8a, 0x2d, 0, 0xe2, 0x1b, 0x10, 0x1, 0xfa, 0xf6, 0xc5, 0x4, 0x74, 0x2, 0xd1, 0xfa, 0x8b, 0xd, 0xe0, 0x9c, 0x20, 0x10, 0x1, 0xc1, 0xa1, 0xe4, 0x9c, 0x20, 0x10, 0x1, 0xd0, 0x8b, 0x15, 0xcc, 0x9c, 0x20, 0x10, 0x85, 0xd2, 0x74, 0x41, 0x50, 0x51, 0x53, 0x31, 0xdb, 0x31, 0xd2, 0x8a, 0x1d, 0xd2, 0x9d, 0x20, 0x10, 0xa1, 0xd4, 0x9c, 0x20, 0x10, 0x8d, 0x1c, 0xdd, 0, 0, 0, 0, 0xf7, 0xf3, 0x50, 0xa1, 0xdc, 0x9c, 0x20, 0x10, 0xc1, 0xe8, 0x4, 0x31, 0xd2, 0x50, 0xa1, 0xe4, 0x9c, 0x20, 0x10, 0xf7, 0xf3, 0x50, 0xa1, 0xe0, 0x9c, 0x20, 0x10, 0xc1, 0xe8, 0x4, 0x50, 0x6a, 0, 0xe8, 0x2c, 0x93, 0x1, 0, 0xeb, 0x3d, 0x50, 0x51, 0x53, 0x31, 0xdb, 0x8a, 0x1d, 0xd2, 0x9d, 0x20, 0x10, 0xa1, 0xd4, 0x9c, 0x20, 0x10, 0x8d, 0x1c, 0xdd, 0, 0, 0, 0, 0xf7, 0xf3, 0x50, 0xa1, 0xdc, 0x9c, 0x20, 0x10, 0xc1, 0xe8, 0x3, 0x31, 0xd2, 0x50, 0xa1, 0xe4, 0x9c, 0x20, 0x10, 0xf7, 0xf3, 0x50, 0xa1, 0xe0, 0x9c, 0x20, 0x10, 0xc1, 0xe8, 0x3, 0x50, 0x6a, 0, 0xe8, 0x9a, 0x8e, 0x1, 0, 0x83, 0xc4, 0x20, 0x8d, 0x65, 0xf8, 0x5f, 0x59, 0x5d, 0xc3}))
    II(0x1017a8c0, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1017a8c1, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1017a8c3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1017a8c4, 0x1)   pushd(edi);                           /* push edi */
    II(0x1017a8c5, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1017a8c7, 0x2)   jged(0x1017a8d6, 0xd);                /* jge 0x1017a8d6 */
    II(0x1017a8c9, 0x5)   mov(eax, memd_a32(ds, 0x10209cb4));   /* mov eax, [0x10209cb4] */
    II(0x1017a8ce, 0x6)   sub(eax, memd_a32(ds, 0x10209cd0));   /* sub eax, [0x10209cd0] */
    II(0x1017a8d4, 0x2)   shr(eax, 0x1);                        /* shr eax, 1 */
l_0x1017a8d6:
    II(0x1017a8d6, 0x2)   test(edx, edx);                       /* test edx, edx */
    II(0x1017a8d8, 0x2)   jged(0x1017a905, 0x2b);               /* jge 0x1017a905 */
    II(0x1017a8da, 0x7)   test(memb_a32(ds, 0x101be200), 0x4);  /* test byte [0x101be200], 0x4 */
    II(0x1017a8e1, 0x2)   jzd(0x1017a8f7, 0x14);                /* jz 0x1017a8f7 */
    II(0x1017a8e3, 0x6)   mov(edx, memd_a32(ds, 0x10209cf0));   /* mov edx, [0x10209cf0] */
    II(0x1017a8e9, 0x6)   mov(ecx, memd_a32(ds, 0x10209cbc));   /* mov ecx, [0x10209cbc] */
    II(0x1017a8ef, 0x2)   add(edx, edx);                        /* add edx, edx */
    II(0x1017a8f1, 0x2)   sub(ecx, edx);                        /* sub ecx, edx */
    II(0x1017a8f3, 0x2)   mov(edx, ecx);                        /* mov edx, ecx */
    II(0x1017a8f5, 0x2)   jmpd(0x1017a903, 0xc);                /* jmp 0x1017a903 */
l_0x1017a8f7:
    II(0x1017a8f7, 0x6)   mov(edx, memd_a32(ds, 0x10209cbc));   /* mov edx, [0x10209cbc] */
    II(0x1017a8fd, 0x6)   sub(edx, memd_a32(ds, 0x10209cf0));   /* sub edx, [0x10209cf0] */
l_0x1017a903:
    II(0x1017a903, 0x2)   shr(edx, 0x1);                        /* shr edx, 1 */
l_0x1017a905:
    II(0x1017a905, 0x7)   xor_(memb_a32(ds, 0x101be208), 0x1);  /* xor byte [0x101be208], 0x1 */
    II(0x1017a90c, 0x6)   mov(ecx, memd_a32(ds, 0x101be208));   /* mov ecx, [0x101be208] */
    II(0x1017a912, 0x2)   and_(al, 0xfc);                       /* and al, 0xfc */
    II(0x1017a914, 0x7)   mov(edi, memd_a32(ds, ecx * 0x4 + 0x101be20c)); /* mov edi, [ecx*4+0x101be20c] */
    II(0x1017a91b, 0x6)   mov(ch, memb_a32(ds, 0x101be200));    /* mov ch, [0x101be200] */
    II(0x1017a921, 0x2)   add(edx, edi);                        /* add edx, edi */
    II(0x1017a923, 0x3)   test(ch, 0x4);                        /* test ch, 0x4 */
    II(0x1017a926, 0x2)   jzd(0x1017a92a, 0x2);                 /* jz 0x1017a92a */
    II(0x1017a928, 0x2)   sar(edx, 0x1);                        /* sar edx, 1 */
l_0x1017a92a:
    II(0x1017a92a, 0x6)   mov(ecx, memd_a32(ds, 0x10209ce0));   /* mov ecx, [0x10209ce0] */
    II(0x1017a930, 0x2)   add(ecx, eax);                        /* add ecx, eax */
    II(0x1017a932, 0x5)   mov(eax, memd_a32(ds, 0x10209ce4));   /* mov eax, [0x10209ce4] */
    II(0x1017a937, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x1017a939, 0x6)   mov(edx, memd_a32(ds, 0x10209ccc));   /* mov edx, [0x10209ccc] */
    II(0x1017a93f, 0x2)   test(edx, edx);                       /* test edx, edx */
    II(0x1017a941, 0x2)   jzd(0x1017a984, 0x41);                /* jz 0x1017a984 */
    II(0x1017a943, 0x1)   pushd(eax);                           /* push eax */
    II(0x1017a944, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1017a945, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1017a946, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1017a948, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1017a94a, 0x6)   mov(bl, memb_a32(ds, 0x10209dd2));    /* mov bl, [0x10209dd2] */
    II(0x1017a950, 0x5)   mov(eax, memd_a32(ds, 0x10209cd4));   /* mov eax, [0x10209cd4] */
    II(0x1017a955, 0x7)   lea(ebx, ebx * 0x8 + 0);              /* lea ebx, [ebx*8+0x0] */
    II(0x1017a95c, 0x2)   div(ebx);                             /* div ebx */
    II(0x1017a95e, 0x1)   pushd(eax);                           /* push eax */
    II(0x1017a95f, 0x5)   mov(eax, memd_a32(ds, 0x10209cdc));   /* mov eax, [0x10209cdc] */
    II(0x1017a964, 0x3)   shr(eax, 0x4);                        /* shr eax, 0x4 */
    II(0x1017a967, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1017a969, 0x1)   pushd(eax);                           /* push eax */
    II(0x1017a96a, 0x5)   mov(eax, memd_a32(ds, 0x10209ce4));   /* mov eax, [0x10209ce4] */
    II(0x1017a96f, 0x2)   div(ebx);                             /* div ebx */
    II(0x1017a971, 0x1)   pushd(eax);                           /* push eax */
    II(0x1017a972, 0x5)   mov(eax, memd_a32(ds, 0x10209ce0));   /* mov eax, [0x10209ce0] */
    II(0x1017a977, 0x3)   shr(eax, 0x4);                        /* shr eax, 0x4 */
    II(0x1017a97a, 0x1)   pushd(eax);                           /* push eax */
    II(0x1017a97b, 0x2)   pushd(0);                             /* push 0x0 */
    II(0x1017a97d, 0x5)   calld(/* sys */ 0x10193cae, 0x1932c); /* call 0x10193cae */
    II(0x1017a982, 0x2)   jmpd(0x1017a9c1, 0x3d);               /* jmp 0x1017a9c1 */
l_0x1017a984:
    II(0x1017a984, 0x1)   pushd(eax);                           /* push eax */
    II(0x1017a985, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1017a986, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1017a987, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1017a989, 0x6)   mov(bl, memb_a32(ds, 0x10209dd2));    /* mov bl, [0x10209dd2] */
    II(0x1017a98f, 0x5)   mov(eax, memd_a32(ds, 0x10209cd4));   /* mov eax, [0x10209cd4] */
    II(0x1017a994, 0x7)   lea(ebx, ebx * 0x8 + 0);              /* lea ebx, [ebx*8+0x0] */
    II(0x1017a99b, 0x2)   div(ebx);                             /* div ebx */
    II(0x1017a99d, 0x1)   pushd(eax);                           /* push eax */
    II(0x1017a99e, 0x5)   mov(eax, memd_a32(ds, 0x10209cdc));   /* mov eax, [0x10209cdc] */
    II(0x1017a9a3, 0x3)   shr(eax, 0x3);                        /* shr eax, 0x3 */
    II(0x1017a9a6, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1017a9a8, 0x1)   pushd(eax);                           /* push eax */
    II(0x1017a9a9, 0x5)   mov(eax, memd_a32(ds, 0x10209ce4));   /* mov eax, [0x10209ce4] */
    II(0x1017a9ae, 0x2)   div(ebx);                             /* div ebx */
    II(0x1017a9b0, 0x1)   pushd(eax);                           /* push eax */
    II(0x1017a9b1, 0x5)   mov(eax, memd_a32(ds, 0x10209ce0));   /* mov eax, [0x10209ce0] */
    II(0x1017a9b6, 0x3)   shr(eax, 0x3);                        /* shr eax, 0x3 */
    II(0x1017a9b9, 0x1)   pushd(eax);                           /* push eax */
    II(0x1017a9ba, 0x2)   pushd(0);                             /* push 0x0 */
    II(0x1017a9bc, 0x5)   calld(/* sys */ 0x1019385b, 0x18e9a); /* call 0x1019385b */
l_0x1017a9c1:
    II(0x1017a9c1, 0x3)   add(esp, 0x20);                       /* add esp, 0x20 */
    II(0x1017a9c4, 0x3)   lea(esp, ebp - 0x8);                  /* lea esp, [ebp-0x8] */
    II(0x1017a9c7, 0x1)   popd(edi);                            /* pop edi */
    II(0x1017a9c8, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1017a9c9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1017a9ca, 0x1)   retd();                               /* ret */
FUNC_END

