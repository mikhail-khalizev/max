FUNC_BEGIN(0x100988d6, 0x424d89620a3bb93d, 0x20, ({0x68, 0x30, 0, 0, 0, 0xe8, 0x72, 0xd4, 0xc, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x11, 0xc1, 0xf8, 0x10, 0x6b, 0xc0, 0x33, 0xff, 0xb0, 0xd7, 0x81, 0x1c, 0x10, 0xb8, 0x27, 0x6, 0x1a, 0x10, 0x50, 0x8b, 0x45, 0xfc, 0x50, 0xe8, 0xed, 0xd5, 0xc, 0, 0x83, 0xc4, 0xc, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x15, 0xe8, 0x4d, 0x24, 0xa, 0, 0x84, 0xc0, 0x74, 0x16, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x15, 0xe8, 0x41, 0xdc, 0xfd, 0xff, 0xe8, 0x68, 0x40, 0, 0, 0x98, 0x83, 0xf8, 0x1, 0x7f, 0x2, 0xeb, 0xd, 0xba, 0x33, 0x6, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xe4, 0xd5, 0xc, 0, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100988d6, 0x5)   pushd(0x30);                          /* push dword 0x30 */
    II(0x100988db, 0x5)   calld(sys_check_available_stack_size, 0xcd472); /* call 0x10165d52 */
    II(0x100988e0, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100988e1, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100988e2, 0x1)   pushd(esi);                           /* push esi */
    II(0x100988e3, 0x1)   pushd(edi);                           /* push edi */
    II(0x100988e4, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100988e5, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100988e7, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100988ed, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100988f0, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100988f3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100988f6, 0x3)   mov(eax, memd_a32(ds, eax + 0x11));   /* mov eax, [eax+0x11] */
    II(0x100988f9, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100988fc, 0x3)   imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
    II(0x100988ff, 0x6)   pushd(memd_a32(ds, eax + 0x101c81d7)); /* push dword [eax+0x101c81d7] */
    II(0x10098905, 0x5)   mov(eax, 0x101a0627);                 /* mov eax, 0x101a0627 */ /* "Create a %s" */
    II(0x1009890a, 0x1)   pushd(eax);                           /* push eax */
    II(0x1009890b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009890e, 0x1)   pushd(eax);                           /* push eax */
    II(0x1009890f, 0x5)   calld(sys_sprintf, 0xcd5ed);          /* call 0x10165f01 */
    II(0x10098914, 0x3)   add(esp, 0xc);                        /* add esp, 0xc */
    II(0x10098917, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10098919, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009891c, 0x3)   add(eax, 0x15);                       /* add eax, 0x15 */
    II(0x1009891f, 0x5)   calld(0x1013ad71, 0xa244d);           /* call 0x1013ad71 */
    II(0x10098924, 0x2)   test(al, al);                         /* test al, al */
    II(0x10098926, 0x2)   jzd(0x1009893e, 0x16);                /* jz 0x1009893e */
    II(0x10098928, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009892b, 0x3)   add(eax, 0x15);                       /* add eax, 0x15 */
    II(0x1009892e, 0x5)   calld(0x10076574, -0x223bf);          /* call 0x10076574 */
    II(0x10098933, 0x5)   calld(0x1009c9a0, 0x4068);            /* call 0x1009c9a0 */
    II(0x10098938, 0x1)   cwde();                               /* cwde */
    II(0x10098939, 0x3)   cmp(eax, 0x1);                        /* cmp eax, 0x1 */
    II(0x1009893c, 0x2)   jgd(0x10098940, 0x2);                 /* jg 0x10098940 */
l_0x1009893e:
    II(0x1009893e, 0x2)   jmpd(0x1009894d, 0xd);                /* jmp 0x1009894d */
l_0x10098940:
    II(0x10098940, 0x5)   mov(edx, 0x101a0633);                 /* mov edx, 0x101a0633 */ /* " at x2 rate" */
    II(0x10098945, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10098948, 0x5)   calld(sys_strcat, 0xcd5e4);           /* call 0x10165f31 */
l_0x1009894d:
    II(0x1009894d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10098950, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x10098953, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10098956, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10098958, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10098959, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009895a, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009895b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009895c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009895d, 0x1)   retd();                               /* ret */
FUNC_END

