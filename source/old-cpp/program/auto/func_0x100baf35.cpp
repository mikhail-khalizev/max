FUNC_BEGIN(0x100baf35, 0x6f13b7c59344546c, 0x20, ({0x68, 0x40, 0, 0, 0, 0xe8, 0x13, 0xae, 0xa, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x28, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x43, 0xe8, 0x33, 0xbc, 0xfb, 0xff, 0x98, 0x85, 0xc0, 0x75, 0x37, 0x8b, 0x15, 0x70, 0x81, 0x1c, 0x10, 0xc1, 0xfa, 0x10, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0x2b, 0xc2, 0xd1, 0xf8, 0x8b, 0x55, 0xf8, 0x66, 0x89, 0x42, 0x77, 0x8b, 0x15, 0x72, 0x81, 0x1c, 0x10, 0xc1, 0xfa, 0x10, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0x2b, 0xc2, 0xd1, 0xf8, 0x8b, 0x55, 0xf8, 0x66, 0x89, 0x42, 0x79, 0xe9, 0xf6, 0, 0, 0, 0xc7, 0x45, 0xf4, 0, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x43, 0xe8, 0x55, 0, 0x1, 0, 0x8d, 0x5d, 0xf0, 0x89, 0xc2, 0x89, 0xd8, 0xe8, 0xed, 0xf1, 0xfc, 0xff, 0xeb, 0x8, 0x8d, 0x45, 0xf0, 0xe8, 0x37, 0xbc, 0xfb, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xf0, 0xe8, 0xa6, 0xfd, 0x7, 0, 0x84, 0xc0, 0xf, 0x84, 0x9a, 0, 0, 0, 0x8d, 0x45, 0xf0, 0xe8, 0x1d, 0xf1, 0xfc, 0xff, 0xe8, 0x90, 0xf3, 0xfc, 0xff, 0x89, 0x45, 0xec, 0x83, 0x7d, 0xf4, 0, 0x74, 0xa, 0x8b, 0x45, 0xec, 0x66, 0x83, 0x78, 0x8, 0x28, 0x75, 0x2, 0xeb, 0xf, 0x8b, 0x45, 0xf4, 0xe8, 0x73, 0xf3, 0xfc, 0xff, 0x66, 0x83, 0x78, 0x8, 0x28, 0x74, 0x64, 0x8d, 0x55, 0xe8, 0x8d, 0x45, 0xf0, 0xe8, 0xe9, 0xf0, 0xfc, 0xff, 0xe8, 0x4f, 0xde, 0xff, 0xff, 0x89, 0xc3, 0x8b, 0x55, 0xfc, 0x8d, 0x45, 0xe4, 0xe8, 0x43, 0xae, 0xfb, 0xff, 0x89, 0xda, 0xe8, 0xa2, 0xaf, 0xfe, 0xff, 0x89, 0x45, 0xe0, 0x83, 0x7d, 0xf4, 0, 0x74, 0x1b, 0x8b, 0x45, 0xec, 0x66, 0x83, 0x78, 0x8, 0x28, 0x75, 0xf, 0x8b, 0x45, 0xf4, 0xe8, 0x2d, 0xf3, 0xfc, 0xff, 0x66, 0x83, 0x78, 0x8, 0x28, 0x75, 0x2, 0xeb, 0x2, 0xeb, 0x9, 0x8b, 0x45, 0xe0, 0x66, 0x3b, 0x45, 0xdc, 0x7d, 0x11, 0x8d, 0x45, 0xf0, 0xe8, 0xcd, 0xf0, 0xfc, 0xff, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xe0, 0x89, 0x45, 0xdc, 0xe9, 0x4c, 0xff, 0xff, 0xff, 0x8d, 0x55, 0xd8, 0x8b, 0x45, 0xf4, 0xe8, 0xeb, 0xdd, 0xff, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x77, 0xe8, 0xbf, 0xda, 0xfc, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xf0, 0xe8, 0xbd, 0xdd, 0xfc, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100baf35, 0x5)   pushd(0x40);                          /* push dword 0x40 */
    II(0x100baf3a, 0x5)   calld(sys_check_available_stack_size, 0xaae13); /* call 0x10165d52 */
    II(0x100baf3f, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100baf40, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100baf41, 0x1)   pushd(esi);                           /* push esi */
    II(0x100baf42, 0x1)   pushd(edi);                           /* push edi */
    II(0x100baf43, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100baf44, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100baf46, 0x6)   sub(esp, 0x28);                       /* sub esp, 0x28 */
    II(0x100baf4c, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100baf4f, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100baf52, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100baf55, 0x3)   add(eax, 0x43);                       /* add eax, 0x43 */
    II(0x100baf58, 0x5)   calld(0x10076b90, -0x443cd);          /* call 0x10076b90 */
    II(0x100baf5d, 0x1)   cwde();                               /* cwde */
    II(0x100baf5e, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x100baf60, 0x2)   jnzd(0x100baf99, 0x37);               /* jnz 0x100baf99 */
    II(0x100baf62, 0x6)   mov(edx, memd_a32(ds, 0x101c8170));   /* mov edx, [0x101c8170] */
    II(0x100baf68, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100baf6b, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x100baf6d, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x100baf70, 0x2)   sub(eax, edx);                        /* sub eax, edx */
    II(0x100baf72, 0x2)   sar(eax, 0x1);                        /* sar eax, 1 */
    II(0x100baf74, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100baf77, 0x4)   mov(memw_a32(ds, edx + 0x77), ax);    /* mov [edx+0x77], ax */
    II(0x100baf7b, 0x6)   mov(edx, memd_a32(ds, 0x101c8172));   /* mov edx, [0x101c8172] */
    II(0x100baf81, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100baf84, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x100baf86, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x100baf89, 0x2)   sub(eax, edx);                        /* sub eax, edx */
    II(0x100baf8b, 0x2)   sar(eax, 0x1);                        /* sar eax, 1 */
    II(0x100baf8d, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100baf90, 0x4)   mov(memw_a32(ds, edx + 0x79), ax);    /* mov [edx+0x79], ax */
    II(0x100baf94, 0x5)   jmpd(0x100bb08f, 0xf6);               /* jmp 0x100bb08f */
l_0x100baf99:
    II(0x100baf99, 0x7)   mov(memd_a32(ss, ebp - 0xc), 0);      /* mov dword [ebp-0xc], 0x0 */
    II(0x100bafa0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100bafa3, 0x3)   add(eax, 0x43);                       /* add eax, 0x43 */
    II(0x100bafa6, 0x5)   calld(0x100cb000, 0x10055);           /* call 0x100cb000 */
    II(0x100bafab, 0x3)   lea(ebx, ebp - 0x10);                 /* lea ebx, [ebp-0x10] */
    II(0x100bafae, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x100bafb0, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x100bafb2, 0x5)   calld(0x1008a1a4, -0x30e13);          /* call 0x1008a1a4 */
    II(0x100bafb7, 0x2)   jmpd(0x100bafc1, 0x8);                /* jmp 0x100bafc1 */
l_0x100bafb9:
    II(0x100bafb9, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x100bafbc, 0x5)   calld(0x10076bf8, -0x443c9);          /* call 0x10076bf8 */
l_0x100bafc1:
    II(0x100bafc1, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100bafc3, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x100bafc6, 0x5)   calld(0x1013ad71, 0x7fda6);           /* call 0x1013ad71 */
    II(0x100bafcb, 0x2)   test(al, al);                         /* test al, al */
    II(0x100bafcd, 0x6)   jzd(0x100bb06d, 0x9a);                /* jz dword 0x100bb06d */
    II(0x100bafd3, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x100bafd6, 0x5)   calld(0x1008a0f8, -0x30ee3);          /* call 0x1008a0f8 */
    II(0x100bafdb, 0x5)   calld(0x1008a370, -0x30c70);          /* call 0x1008a370 */
    II(0x100bafe0, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x100bafe3, 0x4)   cmp(memd_a32(ss, ebp - 0xc), 0);      /* cmp dword [ebp-0xc], 0x0 */
    II(0x100bafe7, 0x2)   jzd(0x100baff3, 0xa);                 /* jz 0x100baff3 */
    II(0x100bafe9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x100bafec, 0x5)   cmp(memw_a32(ds, eax + 0x8), 0x28);   /* cmp word [eax+0x8], 0x28 */
    II(0x100baff1, 0x2)   jnzd(0x100baff5, 0x2);                /* jnz 0x100baff5 */
l_0x100baff3:
    II(0x100baff3, 0x2)   jmpd(0x100bb004, 0xf);                /* jmp 0x100bb004 */
l_0x100baff5:
    II(0x100baff5, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100baff8, 0x5)   calld(0x1008a370, -0x30c8d);          /* call 0x1008a370 */
    II(0x100baffd, 0x5)   cmp(memw_a32(ds, eax + 0x8), 0x28);   /* cmp word [eax+0x8], 0x28 */
    II(0x100bb002, 0x2)   jzd(0x100bb068, 0x64);                /* jz 0x100bb068 */
l_0x100bb004:
    II(0x100bb004, 0x3)   lea(edx, ebp - 0x18);                 /* lea edx, [ebp-0x18] */
    II(0x100bb007, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x100bb00a, 0x5)   calld(0x1008a0f8, -0x30f17);          /* call 0x1008a0f8 */
    II(0x100bb00f, 0x5)   calld(0x100b8e63, -0x21b1);           /* call 0x100b8e63 */
    II(0x100bb014, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x100bb016, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100bb019, 0x3)   lea(eax, ebp - 0x1c);                 /* lea eax, [ebp-0x1c] */
    II(0x100bb01c, 0x5)   calld(0x10075e64, -0x451bd);          /* call 0x10075e64 */
    II(0x100bb021, 0x2)   mov(edx, ebx);                        /* mov edx, ebx */
    II(0x100bb023, 0x5)   calld(0x100a5fca, -0x1505e);          /* call 0x100a5fca */
    II(0x100bb028, 0x3)   mov(memd_a32(ss, ebp - 0x20), eax);   /* mov [ebp-0x20], eax */
    II(0x100bb02b, 0x4)   cmp(memd_a32(ss, ebp - 0xc), 0);      /* cmp dword [ebp-0xc], 0x0 */
    II(0x100bb02f, 0x2)   jzd(0x100bb04c, 0x1b);                /* jz 0x100bb04c */
    II(0x100bb031, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x100bb034, 0x5)   cmp(memw_a32(ds, eax + 0x8), 0x28);   /* cmp word [eax+0x8], 0x28 */
    II(0x100bb039, 0x2)   jnzd(0x100bb04a, 0xf);                /* jnz 0x100bb04a */
    II(0x100bb03b, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100bb03e, 0x5)   calld(0x1008a370, -0x30cd3);          /* call 0x1008a370 */
    II(0x100bb043, 0x5)   cmp(memw_a32(ds, eax + 0x8), 0x28);   /* cmp word [eax+0x8], 0x28 */
    II(0x100bb048, 0x2)   jnzd(0x100bb04c, 0x2);                /* jnz 0x100bb04c */
l_0x100bb04a:
    II(0x100bb04a, 0x2)   jmpd(0x100bb04e, 0x2);                /* jmp 0x100bb04e */
l_0x100bb04c:
    II(0x100bb04c, 0x2)   jmpd(0x100bb057, 0x9);                /* jmp 0x100bb057 */
l_0x100bb04e:
    II(0x100bb04e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x20));   /* mov eax, [ebp-0x20] */
    II(0x100bb051, 0x4)   cmp(ax, memw_a32(ss, ebp - 0x24));    /* cmp ax, [ebp-0x24] */
    II(0x100bb055, 0x2)   jged(0x100bb068, 0x11);               /* jge 0x100bb068 */
l_0x100bb057:
    II(0x100bb057, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x100bb05a, 0x5)   calld(0x1008a12c, -0x30f33);          /* call 0x1008a12c */
    II(0x100bb05f, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100bb062, 0x3)   mov(eax, memd_a32(ss, ebp - 0x20));   /* mov eax, [ebp-0x20] */
    II(0x100bb065, 0x3)   mov(memd_a32(ss, ebp - 0x24), eax);   /* mov [ebp-0x24], eax */
l_0x100bb068:
    II(0x100bb068, 0x5)   jmpd(0x100bafb9, -0xb4);              /* jmp 0x100bafb9 */
l_0x100bb06d:
    II(0x100bb06d, 0x3)   lea(edx, ebp - 0x28);                 /* lea edx, [ebp-0x28] */
    II(0x100bb070, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100bb073, 0x5)   calld(0x100b8e63, -0x2215);           /* call 0x100b8e63 */
    II(0x100bb078, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x100bb07a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100bb07d, 0x3)   add(eax, 0x77);                       /* add eax, 0x77 */
    II(0x100bb080, 0x5)   calld(0x10088b44, -0x32541);          /* call 0x10088b44 */
    II(0x100bb085, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100bb087, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x100bb08a, 0x5)   calld(0x10088e4c, -0x32243);          /* call 0x10088e4c */
l_0x100bb08f:
    II(0x100bb08f, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100bb091, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100bb092, 0x1)   popd(edi);                            /* pop edi */
    II(0x100bb093, 0x1)   popd(esi);                            /* pop esi */
    II(0x100bb094, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100bb095, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100bb096, 0x1)   retd();                               /* ret */
FUNC_END

