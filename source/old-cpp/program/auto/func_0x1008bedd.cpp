FUNC_BEGIN(0x1008bedd, 0xfdedb70632a63d65, 0x20, ({0x68, 0x68, 0, 0, 0, 0xe8, 0x6b, 0x9e, 0xd, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x44, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x1d, 0xc1, 0xf8, 0x10, 0x50, 0xb8, 0x8c, 0x3, 0x1a, 0x10, 0x50, 0x8b, 0x45, 0xfc, 0x50, 0xe8, 0xee, 0x9f, 0xd, 0, 0x83, 0xc4, 0xc, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x13, 0xe8, 0xee, 0xed, 0xa, 0, 0x84, 0xc0, 0x74, 0x12, 0xba, 0x9d, 0x3, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xfd, 0x9f, 0xd, 0, 0xe9, 0x7, 0x1, 0, 0, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x13, 0xe8, 0x30, 0xa6, 0xfe, 0xff, 0x8b, 0x50, 0x50, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x1d, 0xc1, 0xf8, 0x10, 0x39, 0xc2, 0x7c, 0x12, 0xba, 0xa9, 0x3, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xcd, 0x9f, 0xd, 0, 0xe9, 0xd7, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x13, 0xe8, 0, 0xa6, 0xfe, 0xff, 0x8b, 0x40, 0x50, 0xc1, 0xf8, 0x10, 0x50, 0xb8, 0xbc, 0x3, 0x1a, 0x10, 0x50, 0x8d, 0x45, 0xc0, 0x50, 0xe8, 0x77, 0x9f, 0xd, 0, 0x83, 0xc4, 0xc, 0x8d, 0x55, 0xc0, 0x8b, 0x45, 0xfc, 0xe8, 0x99, 0x9f, 0xd, 0, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x1b, 0xe8, 0x6c, 0xed, 0xa, 0, 0x84, 0xc0, 0x74, 0x12, 0xba, 0xcb, 0x3, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x7b, 0x9f, 0xd, 0, 0xe9, 0x85, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x13, 0xe8, 0xae, 0xa5, 0xfe, 0xff, 0x8b, 0x55, 0xf8, 0x66, 0x8b, 0x52, 0x1f, 0x66, 0x2b, 0x50, 0x52, 0x89, 0x55, 0xbc, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x1b, 0xe8, 0x95, 0xa5, 0xfe, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xbc, 0x66, 0x3b, 0x42, 0x52, 0x7e, 0x12, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x1b, 0xe8, 0x7f, 0xa5, 0xfe, 0xff, 0x66, 0x8b, 0x40, 0x52, 0x89, 0x45, 0xbc, 0xf, 0xbf, 0x45, 0xbc, 0x50, 0xb8, 0xdf, 0x3, 0x1a, 0x10, 0x50, 0x8d, 0x45, 0xc0, 0x50, 0xe8, 0xf1, 0x9e, 0xd, 0, 0x83, 0xc4, 0xc, 0x8d, 0x55, 0xc0, 0x8b, 0x45, 0xfc, 0xe8, 0x13, 0x9f, 0xd, 0, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x1b, 0xe8, 0x4b, 0xa5, 0xfe, 0xff, 0x8b, 0x50, 0x6, 0xc1, 0xfa, 0x10, 0x6b, 0xd2, 0x33, 0x8b, 0x92, 0xd7, 0x81, 0x1c, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xf1, 0x9e, 0xd, 0, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1008bedd, 0x5)   pushd(0x68);                          /* push dword 0x68 */
    II(0x1008bee2, 0x5)   calld(sys_check_available_stack_size, 0xd9e6b); /* call 0x10165d52 */
    II(0x1008bee7, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008bee8, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008bee9, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008beea, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008beeb, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008beec, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008beee, 0x6)   sub(esp, 0x44);                       /* sub esp, 0x44 */
    II(0x1008bef4, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1008bef7, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x1008befa, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008befd, 0x3)   mov(eax, memd_a32(ds, eax + 0x1d));   /* mov eax, [eax+0x1d] */
    II(0x1008bf00, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1008bf03, 0x1)   pushd(eax);                           /* push eax */
    II(0x1008bf04, 0x5)   mov(eax, 0x101a038c);                 /* mov eax, 0x101a038c */ /* "Get %i Materials" */
    II(0x1008bf09, 0x1)   pushd(eax);                           /* push eax */
    II(0x1008bf0a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008bf0d, 0x1)   pushd(eax);                           /* push eax */
    II(0x1008bf0e, 0x5)   calld(sys_sprintf, 0xd9fee);          /* call 0x10165f01 */
    II(0x1008bf13, 0x3)   add(esp, 0xc);                        /* add esp, 0xc */
    II(0x1008bf16, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1008bf18, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008bf1b, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x1008bf1e, 0x5)   calld(0x1013ad11, 0xaedee);           /* call 0x1013ad11 */
    II(0x1008bf23, 0x2)   test(al, al);                         /* test al, al */
    II(0x1008bf25, 0x2)   jzd(0x1008bf39, 0x12);                /* jz 0x1008bf39 */
    II(0x1008bf27, 0x5)   mov(edx, 0x101a039d);                 /* mov edx, 0x101a039d */ /* ": finished." */
    II(0x1008bf2c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008bf2f, 0x5)   calld(sys_strcat, 0xd9ffd);           /* call 0x10165f31 */
    II(0x1008bf34, 0x5)   jmpd(0x1008c040, 0x107);              /* jmp 0x1008c040 */
l_0x1008bf39:
    II(0x1008bf39, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008bf3c, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x1008bf3f, 0x5)   calld(0x10076574, -0x159d0);          /* call 0x10076574 */
    II(0x1008bf44, 0x3)   mov(edx, memd_a32(ds, eax + 0x50));   /* mov edx, [eax+0x50] */
    II(0x1008bf47, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x1008bf4a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008bf4d, 0x3)   mov(eax, memd_a32(ds, eax + 0x1d));   /* mov eax, [eax+0x1d] */
    II(0x1008bf50, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1008bf53, 0x2)   cmp(edx, eax);                        /* cmp edx, eax */
    II(0x1008bf55, 0x2)   jld(0x1008bf69, 0x12);                /* jl 0x1008bf69 */
    II(0x1008bf57, 0x5)   mov(edx, 0x101a03a9);                 /* mov edx, 0x101a03a9 */ /* ": already on hand." */
    II(0x1008bf5c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008bf5f, 0x5)   calld(sys_strcat, 0xd9fcd);           /* call 0x10165f31 */
    II(0x1008bf64, 0x5)   jmpd(0x1008c040, 0xd7);               /* jmp 0x1008c040 */
l_0x1008bf69:
    II(0x1008bf69, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008bf6c, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x1008bf6f, 0x5)   calld(0x10076574, -0x15a00);          /* call 0x10076574 */
    II(0x1008bf74, 0x3)   mov(eax, memd_a32(ds, eax + 0x50));   /* mov eax, [eax+0x50] */
    II(0x1008bf77, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1008bf7a, 0x1)   pushd(eax);                           /* push eax */
    II(0x1008bf7b, 0x5)   mov(eax, 0x101a03bc);                 /* mov eax, 0x101a03bc */ /* ": %i on hand, " */
    II(0x1008bf80, 0x1)   pushd(eax);                           /* push eax */
    II(0x1008bf81, 0x3)   lea(eax, ebp - 0x40);                 /* lea eax, [ebp-0x40] */
    II(0x1008bf84, 0x1)   pushd(eax);                           /* push eax */
    II(0x1008bf85, 0x5)   calld(sys_sprintf, 0xd9f77);          /* call 0x10165f01 */
    II(0x1008bf8a, 0x3)   add(esp, 0xc);                        /* add esp, 0xc */
    II(0x1008bf8d, 0x3)   lea(edx, ebp - 0x40);                 /* lea edx, [ebp-0x40] */
    II(0x1008bf90, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008bf93, 0x5)   calld(sys_strcat, 0xd9f99);           /* call 0x10165f31 */
    II(0x1008bf98, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1008bf9a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008bf9d, 0x3)   add(eax, 0x1b);                       /* add eax, 0x1b */
    II(0x1008bfa0, 0x5)   calld(0x1013ad11, 0xaed6c);           /* call 0x1013ad11 */
    II(0x1008bfa5, 0x2)   test(al, al);                         /* test al, al */
    II(0x1008bfa7, 0x2)   jzd(0x1008bfbb, 0x12);                /* jz 0x1008bfbb */
    II(0x1008bfa9, 0x5)   mov(edx, 0x101a03cb);                 /* mov edx, 0x101a03cb */ /* "waiting for source." */
    II(0x1008bfae, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008bfb1, 0x5)   calld(sys_strcat, 0xd9f7b);           /* call 0x10165f31 */
    II(0x1008bfb6, 0x5)   jmpd(0x1008c040, 0x85);               /* jmp 0x1008c040 */
l_0x1008bfbb:
    II(0x1008bfbb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008bfbe, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x1008bfc1, 0x5)   calld(0x10076574, -0x15a52);          /* call 0x10076574 */
    II(0x1008bfc6, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1008bfc9, 0x4)   mov(dx, memw_a32(ds, edx + 0x1f));    /* mov dx, [edx+0x1f] */
    II(0x1008bfcd, 0x4)   sub(dx, memw_a32(ds, eax + 0x52));    /* sub dx, [eax+0x52] */
    II(0x1008bfd1, 0x3)   mov(memd_a32(ss, ebp - 0x44), edx);   /* mov [ebp-0x44], edx */
    II(0x1008bfd4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008bfd7, 0x3)   add(eax, 0x1b);                       /* add eax, 0x1b */
    II(0x1008bfda, 0x5)   calld(0x10076574, -0x15a6b);          /* call 0x10076574 */
    II(0x1008bfdf, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1008bfe1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x44));   /* mov eax, [ebp-0x44] */
    II(0x1008bfe4, 0x4)   cmp(ax, memw_a32(ds, edx + 0x52));    /* cmp ax, [edx+0x52] */
    II(0x1008bfe8, 0x2)   jled(0x1008bffc, 0x12);               /* jle 0x1008bffc */
    II(0x1008bfea, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008bfed, 0x3)   add(eax, 0x1b);                       /* add eax, 0x1b */
    II(0x1008bff0, 0x5)   calld(0x10076574, -0x15a81);          /* call 0x10076574 */
    II(0x1008bff5, 0x4)   mov(ax, memw_a32(ds, eax + 0x52));    /* mov ax, [eax+0x52] */
    II(0x1008bff9, 0x3)   mov(memd_a32(ss, ebp - 0x44), eax);   /* mov [ebp-0x44], eax */
l_0x1008bffc:
    II(0x1008bffc, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x44)); /* movsx eax, word [ebp-0x44] */
    II(0x1008c000, 0x1)   pushd(eax);                           /* push eax */
    II(0x1008c001, 0x5)   mov(eax, 0x101a03df);                 /* mov eax, 0x101a03df */ /* "get %i from " */
    II(0x1008c006, 0x1)   pushd(eax);                           /* push eax */
    II(0x1008c007, 0x3)   lea(eax, ebp - 0x40);                 /* lea eax, [ebp-0x40] */
    II(0x1008c00a, 0x1)   pushd(eax);                           /* push eax */
    II(0x1008c00b, 0x5)   calld(sys_sprintf, 0xd9ef1);          /* call 0x10165f01 */
    II(0x1008c010, 0x3)   add(esp, 0xc);                        /* add esp, 0xc */
    II(0x1008c013, 0x3)   lea(edx, ebp - 0x40);                 /* lea edx, [ebp-0x40] */
    II(0x1008c016, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008c019, 0x5)   calld(sys_strcat, 0xd9f13);           /* call 0x10165f31 */
    II(0x1008c01e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008c021, 0x3)   add(eax, 0x1b);                       /* add eax, 0x1b */
    II(0x1008c024, 0x5)   calld(0x10076574, -0x15ab5);          /* call 0x10076574 */
    II(0x1008c029, 0x3)   mov(edx, memd_a32(ds, eax + 0x6));    /* mov edx, [eax+0x6] */
    II(0x1008c02c, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x1008c02f, 0x3)   imul(edx, edx, 0x33);                 /* imul edx, edx, 0x33 */
    II(0x1008c032, 0x6)   mov(edx, memd_a32(ds, edx + 0x101c81d7)); /* mov edx, [edx+0x101c81d7] */
    II(0x1008c038, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008c03b, 0x5)   calld(sys_strcat, 0xd9ef1);           /* call 0x10165f31 */
l_0x1008c040:
    II(0x1008c040, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008c043, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1008c046, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1008c049, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008c04b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008c04c, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008c04d, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008c04e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008c04f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008c050, 0x1)   retd();                               /* ret */
FUNC_END

