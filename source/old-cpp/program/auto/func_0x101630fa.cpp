FUNC_BEGIN(0x101630fa, 0x605c75861971b9af, 0x20, ({0x68, 0x38, 0, 0, 0, 0xe8, 0x4e, 0x2c, 0, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x20, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xfc, 0x8b, 0x45, 0xf4, 0x8b, 0x40, 0x6, 0xc1, 0xf8, 0x10, 0x6b, 0xd0, 0x33, 0xb8, 0xc0, 0x81, 0x1c, 0x10, 0x1, 0xd0, 0x89, 0x45, 0xec, 0x8b, 0x45, 0xf4, 0x66, 0x8b, 0x40, 0x8, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf4, 0xe8, 0xdb, 0x2f, 0xf1, 0xff, 0x89, 0xc2, 0x8d, 0x45, 0xe8, 0xe8, 0x61, 0x35, 0xf1, 0xff, 0x8b, 0x55, 0xf4, 0xb8, 0xb8, 0x39, 0x1c, 0x10, 0xe8, 0xfa, 0x5, 0xfa, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xe8, 0xe8, 0xf, 0x7c, 0xfd, 0xff, 0x84, 0xc0, 0x74, 0x24, 0x8d, 0x45, 0xe8, 0xe8, 0x92, 0x34, 0xf1, 0xff, 0x89, 0xc2, 0xb8, 0xb8, 0x39, 0x1c, 0x10, 0xe8, 0xd8, 0x5, 0xfa, 0xff, 0x8d, 0x45, 0xe8, 0xe8, 0xf2, 0x33, 0xf1, 0xff, 0xe8, 0x17, 0xd9, 0xfe, 0xff, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xec, 0xf6, 0, 0x10, 0x74, 0x24, 0xf, 0xbf, 0x4d, 0xfc, 0xf, 0xbf, 0x5d, 0xf8, 0xf, 0xbf, 0x55, 0xf0, 0x8b, 0x45, 0xf4, 0x8a, 0x40, 0x26, 0x30, 0xe4, 0x98, 0xe8, 0xed, 0xae, 0xf6, 0xff, 0x25, 0xff, 0, 0, 0, 0x89, 0x45, 0xe4, 0xeb, 0x46, 0xf, 0xbf, 0x55, 0xfc, 0xf, 0xbf, 0x45, 0xf8, 0xe8, 0x85, 0xb, 0xf1, 0xff, 0x25, 0xff, 0xff, 0, 0, 0x83, 0xf8, 0x8, 0x74, 0x28, 0xb8, 0x2, 0, 0, 0, 0x50, 0xf, 0xbf, 0x4d, 0xfc, 0xf, 0xbf, 0x5d, 0xf8, 0x8b, 0x45, 0xf4, 0x8a, 0x40, 0x26, 0x30, 0xe4, 0xf, 0xbf, 0xd0, 0xf, 0xbf, 0x45, 0xf0, 0xe8, 0xca, 0xd0, 0xf0, 0xff, 0x98, 0x89, 0x45, 0xe4, 0xeb, 0x7, 0xc7, 0x45, 0xe4, 0, 0, 0, 0, 0xe8, 0xef, 0x21, 0xf7, 0xff, 0x31, 0xdb, 0x88, 0xc3, 0x8b, 0x55, 0xf4, 0xb8, 0xb8, 0x39, 0x1c, 0x10, 0xe8, 0x5d, 0x2, 0xfa, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xe8, 0xe8, 0x55, 0x7b, 0xfd, 0xff, 0x84, 0xc0, 0x74, 0x1d, 0xe8, 0xcb, 0x21, 0xf7, 0xff, 0x31, 0xdb, 0x88, 0xc3, 0x8d, 0x45, 0xe8, 0xe8, 0xcf, 0x33, 0xf1, 0xff, 0x89, 0xc2, 0xb8, 0xb8, 0x39, 0x1c, 0x10, 0xe8, 0x32, 0x2, 0xfa, 0xff, 0x8b, 0x45, 0xe4, 0x89, 0x45, 0xe0, 0x31, 0xd2, 0x8d, 0x45, 0xe8, 0xe8, 0xdf, 0x2c, 0xf1, 0xff, 0xeb, 0xa, 0x31, 0xd2, 0x8d, 0x45, 0xe8, 0xe8, 0xd3, 0x2c, 0xf1, 0xff, 0x8b, 0x45, 0xe0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x101630fa, 0x5)   pushd(0x38);                          /* push dword 0x38 */
    II(0x101630ff, 0x5)   calld(sys_check_available_stack_size, 0x2c4e); /* call 0x10165d52 */
    II(0x10163104, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10163105, 0x1)   pushd(esi);                           /* push esi */
    II(0x10163106, 0x1)   pushd(edi);                           /* push edi */
    II(0x10163107, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10163108, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1016310a, 0x6)   sub(esp, 0x20);                       /* sub esp, 0x20 */
    II(0x10163110, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10163113, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x10163116, 0x3)   mov(memd_a32(ss, ebp - 0x4), ebx);    /* mov [ebp-0x4], ebx */
//    II(0x10163119, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1016311c, 0x3)   mov(eax, memd_a32(ds, eax + 0x6));    /* mov eax, [eax+0x6] */
    II(0x1016311f, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x10163122, 0x3)   imul(edx, eax, 0x33);                 /* imul edx, eax, 0x33 */
    II(0x10163125, 0x5)   mov(eax, 0x101c81c0);                 /* mov eax, 0x101c81c0 */
    II(0x1016312a, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x1016312c, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x1016312f, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10163132, 0x4)   mov(ax, memw_a32(ds, eax + 0x8));     /* mov ax, [eax+0x8] */
    II(0x10163136, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x10163139, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1016313c, 0x5)   calld(0x1007611c, -0xed025);          /* call 0x1007611c */
    II(0x10163141, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10163143, 0x3)   lea(eax, ebp - 0x18);                 /* lea eax, [ebp-0x18] */
    II(0x10163146, 0x5)   calld(0x100766ac, -0xeca9f);          /* call 0x100766ac */
    II(0x1016314b, 0x3)   mov(edx, memd_a32(ss, ebp - 0xc));    /* mov edx, [ebp-0xc] */
    II(0x1016314e, 0x5)   mov(eax, 0x101c39b8);                 /* mov eax, 0x101c39b8 */
    II(0x10163153, 0x5)   calld(0x10103752, -0x5fa06);          /* call 0x10103752 */
    II(0x10163158, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1016315a, 0x3)   lea(eax, ebp - 0x18);                 /* lea eax, [ebp-0x18] */
    II(0x1016315d, 0x5)   calld(0x1013ad71, -0x283f1);          /* call 0x1013ad71 */
    II(0x10163162, 0x2)   test(al, al);                         /* test al, al */
    II(0x10163164, 0x2)   jzd(0x1016318a, 0x24);                /* jz 0x1016318a */
    II(0x10163166, 0x3)   lea(eax, ebp - 0x18);                 /* lea eax, [ebp-0x18] */
    II(0x10163169, 0x5)   calld(0x10076600, -0xecb6e);          /* call 0x10076600 */
    II(0x1016316e, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10163170, 0x5)   mov(eax, 0x101c39b8);                 /* mov eax, 0x101c39b8 */
    II(0x10163175, 0x5)   calld(0x10103752, -0x5fa28);          /* call 0x10103752 */
    II(0x1016317a, 0x3)   lea(eax, ebp - 0x18);                 /* lea eax, [ebp-0x18] */
    II(0x1016317d, 0x5)   calld(0x10076574, -0xecc0e);          /* call 0x10076574 */
    II(0x10163182, 0x5)   calld(0x10150a9e, -0x126e9);          /* call 0x10150a9e */
    II(0x10163187, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
l_0x1016318a:
    II(0x1016318a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x1016318d, 0x3)   test(memb_a32(ds, eax), 0x10);        /* test byte [eax], 0x10 */
    II(0x10163190, 0x2)   jzd(0x101631b6, 0x24);                /* jz 0x101631b6 */
    II(0x10163192, 0x4)   movsx(ecx, memw_a32(ss, ebp - 0x4));  /* movsx ecx, word [ebp-0x4] */
    II(0x10163196, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x8));  /* movsx ebx, word [ebp-0x8] */
    II(0x1016319a, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x10)); /* movsx edx, word [ebp-0x10] */
    II(0x1016319e, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x101631a1, 0x3)   mov(al, memb_a32(ds, eax + 0x26));    /* mov al, [eax+0x26] */
    II(0x101631a4, 0x2)   xor_(ah, ah);                         /* xor ah, ah */
    II(0x101631a6, 0x1)   cwde();                               /* cwde */
    II(0x101631a7, 0x5)   calld(0x100ce099, -0x95113);          /* call 0x100ce099 */
    II(0x101631ac, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x101631b1, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
    II(0x101631b4, 0x2)   jmpd(0x101631fc, 0x46);               /* jmp 0x101631fc */
l_0x101631b6:
    II(0x101631b6, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x4));  /* movsx edx, word [ebp-0x4] */
    II(0x101631ba, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x101631be, 0x5)   calld(0x10073d48, -0xef47b);          /* call 0x10073d48 */
    II(0x101631c3, 0x5)   and_(eax, 0xffff);                    /* and eax, 0xffff */
    II(0x101631c8, 0x3)   cmp(eax, 0x8);                        /* cmp eax, 0x8 */
    II(0x101631cb, 0x2)   jzd(0x101631f5, 0x28);                /* jz 0x101631f5 */
    II(0x101631cd, 0x5)   mov(eax, 0x2);                        /* mov eax, 0x2 */
    II(0x101631d2, 0x1)   pushd(eax);                           /* push eax */
    II(0x101631d3, 0x4)   movsx(ecx, memw_a32(ss, ebp - 0x4));  /* movsx ecx, word [ebp-0x4] */
    II(0x101631d7, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x8));  /* movsx ebx, word [ebp-0x8] */
    II(0x101631db, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x101631de, 0x3)   mov(al, memb_a32(ds, eax + 0x26));    /* mov al, [eax+0x26] */
    II(0x101631e1, 0x2)   xor_(ah, ah);                         /* xor ah, ah */
    II(0x101631e3, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x101631e6, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x10)); /* movsx eax, word [ebp-0x10] */
    II(0x101631ea, 0x5)   calld(0x100702b9, -0xf2f36);          /* call 0x100702b9 */
    II(0x101631ef, 0x1)   cwde();                               /* cwde */
    II(0x101631f0, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
    II(0x101631f3, 0x2)   jmpd(0x101631fc, 0x7);                /* jmp 0x101631fc */
l_0x101631f5:
    II(0x101631f5, 0x7)   mov(memd_a32(ss, ebp - 0x1c), 0);     /* mov dword [ebp-0x1c], 0x0 */
l_0x101631fc:
    II(0x101631fc, 0x5)   calld(0x100d53f0, -0x8de11);          /* call 0x100d53f0 */
    II(0x10163201, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x10163203, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x10163205, 0x3)   mov(edx, memd_a32(ss, ebp - 0xc));    /* mov edx, [ebp-0xc] */
    II(0x10163208, 0x5)   mov(eax, 0x101c39b8);                 /* mov eax, 0x101c39b8 */
    II(0x1016320d, 0x5)   calld(0x1010346f, -0x5fda3);          /* call 0x1010346f */
    II(0x10163212, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10163214, 0x3)   lea(eax, ebp - 0x18);                 /* lea eax, [ebp-0x18] */
    II(0x10163217, 0x5)   calld(0x1013ad71, -0x284ab);          /* call 0x1013ad71 */
    II(0x1016321c, 0x2)   test(al, al);                         /* test al, al */
    II(0x1016321e, 0x2)   jzd(0x1016323d, 0x1d);                /* jz 0x1016323d */
    II(0x10163220, 0x5)   calld(0x100d53f0, -0x8de35);          /* call 0x100d53f0 */
    II(0x10163225, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x10163227, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x10163229, 0x3)   lea(eax, ebp - 0x18);                 /* lea eax, [ebp-0x18] */
    II(0x1016322c, 0x5)   calld(0x10076600, -0xecc31);          /* call 0x10076600 */
    II(0x10163231, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10163233, 0x5)   mov(eax, 0x101c39b8);                 /* mov eax, 0x101c39b8 */
    II(0x10163238, 0x5)   calld(0x1010346f, -0x5fdce);          /* call 0x1010346f */
l_0x1016323d:
    II(0x1016323d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x1c));   /* mov eax, [ebp-0x1c] */
    II(0x10163240, 0x3)   mov(memd_a32(ss, ebp - 0x20), eax);   /* mov [ebp-0x20], eax */
    II(0x10163243, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10163245, 0x3)   lea(eax, ebp - 0x18);                 /* lea eax, [ebp-0x18] */
    II(0x10163248, 0x5)   calld(0x10075f2c, -0xed321);          /* call 0x10075f2c */
    II(0x1016324d, 0x2)   jmpd(0x10163259, 0xa);                /* jmp 0x10163259 */
//  II(0x1016324f, 0xa)   /* Недостижимый код. */
l_0x10163259:
    II(0x10163259, 0x3)   mov(eax, memd_a32(ss, ebp - 0x20));   /* mov eax, [ebp-0x20] */
    II(0x1016325c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1016325e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1016325f, 0x1)   popd(edi);                            /* pop edi */
    II(0x10163260, 0x1)   popd(esi);                            /* pop esi */
    II(0x10163261, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10163262, 0x1)   retd();                               /* ret */
FUNC_END

