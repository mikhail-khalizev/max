FUNC_BEGIN(0x10159f08, 0x2e0fe2a10a5c6fd4, 0x20, ({0x68, 0xd4, 0x1, 0, 0, 0xe8, 0x40, 0xbe, 0, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xb0, 0x1, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xe8, 0x80, 0x4d, 0xf4, 0x1, 0x8d, 0x45, 0xec, 0xe8, 0xb9, 0xc7, 0xf1, 0xff, 0x89, 0x45, 0xf0, 0x80, 0x65, 0xf4, 0xfe, 0xb8, 0x1, 0, 0, 0, 0xe8, 0x44, 0xa5, 0xf9, 0xff, 0x8b, 0x45, 0xe8, 0x80, 0x78, 0x3d, 0xb, 0x75, 0x1f, 0x8b, 0x45, 0xe8, 0xe8, 0x9, 0xa0, 0xf9, 0xff, 0x8b, 0x45, 0xe8, 0xe8, 0xf, 0x5b, 0xfa, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xec, 0xe8, 0xc1, 0xbf, 0xf1, 0xff, 0xe9, 0x12, 0x1, 0, 0, 0x8b, 0x45, 0xe8, 0x8b, 0x58, 0x1a, 0xc1, 0xfb, 0x10, 0x8b, 0x45, 0xe8, 0x8b, 0x50, 0x18, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xe8, 0x8a, 0x40, 0x26, 0x30, 0xe4, 0x98, 0xe8, 0x4c, 0xa2, 0xf1, 0xff, 0x89, 0xc2, 0x8d, 0x45, 0xec, 0xe8, 0x96, 0xc6, 0xf1, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xec, 0xe8, 0x6d, 0xd, 0xfe, 0xff, 0x84, 0xc0, 0x74, 0x28, 0xe8, 0x53, 0xa, 0xf7, 0xff, 0x25, 0xff, 0, 0, 0, 0x50, 0xe8, 0x68, 0xa, 0xf7, 0xff, 0x89, 0xc1, 0x31, 0xdb, 0xba, 0x1, 0, 0, 0, 0xb8, 0xae, 0x26, 0x1b, 0x10, 0xe8, 0x58, 0xbd, 0xfb, 0xff, 0xe9, 0xa8, 0, 0, 0, 0x8d, 0x45, 0xec, 0xe8, 0x28, 0xc6, 0xf1, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xe8, 0xe8, 0xb6, 0x9, 0xf3, 0xff, 0x8d, 0x45, 0xec, 0xe8, 0x8a, 0xc5, 0xf1, 0xff, 0xf6, 0x40, 0x12, 0x10, 0x74, 0x9, 0xc7, 0x45, 0xe4, 0x4, 0, 0, 0, 0xeb, 0x7, 0xc7, 0x45, 0xe4, 0x1, 0, 0, 0, 0x8a, 0x45, 0xe4, 0x8b, 0x55, 0xe8, 0x88, 0x42, 0x45, 0x31, 0xdb, 0xba, 0xb, 0, 0, 0, 0x8b, 0x45, 0xe8, 0xe8, 0x3b, 0x90, 0, 0, 0x8b, 0x45, 0xe8, 0xe8, 0x2d, 0x69, 0xfa, 0xff, 0x8b, 0x45, 0xe8, 0xe8, 0x90, 0x79, 0xfa, 0xff, 0x8b, 0x45, 0xe8, 0x8a, 0x40, 0x45, 0x25, 0xff, 0, 0, 0, 0x50, 0xb8, 0xd3, 0x26, 0x1b, 0x10, 0x50, 0x8d, 0x85, 0x54, 0xfe, 0xff, 0xff, 0x50, 0xe8, 0xbb, 0xbe, 0, 0, 0x83, 0xc4, 0xc, 0x8b, 0x45, 0xe8, 0x8b, 0x58, 0x1a, 0xc1, 0xfb, 0x10, 0x8b, 0x45, 0xe8, 0x8b, 0x50, 0x18, 0xc1, 0xfa, 0x10, 0x8d, 0x85, 0x50, 0xfe, 0xff, 0xff, 0xe8, 0x46, 0xca, 0xf1, 0xff, 0x8b, 0x8, 0x8b, 0x5d, 0xe8, 0x31, 0xd2, 0x8d, 0x85, 0x54, 0xfe, 0xff, 0xff, 0xe8, 0xe8, 0xba, 0xfb, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xec, 0xe8, 0xaa, 0xbe, 0xf1, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10159f08, 0x5)   pushd(0x1d4);                         /* push dword 0x1d4 */
    II(0x10159f0d, 0x5)   calld(sys_check_available_stack_size, 0xbe40); /* call 0x10165d52 */
    II(0x10159f12, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10159f13, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10159f14, 0x1)   pushd(esi);                           /* push esi */
    II(0x10159f15, 0x1)   pushd(edi);                           /* push edi */
    II(0x10159f16, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10159f17, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10159f19, 0x6)   sub(esp, 0x1b0);                      /* sub esp, 0x1b0 */
    II(0x10159f1f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10159f22, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10159f25, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10159f28, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
    II(0x10159f2b, 0x4)   or_(memb_a32(ss, ebp - 0xc), 0x1);    /* or byte [ebp-0xc], 0x1 */
    II(0x10159f2f, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10159f32, 0x5)   calld(my_ctor_0x101b38f8, -0xe3847);  /* call 0x100766f0 */
    II(0x10159f37, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x10159f3a, 0x4)   and_(memb_a32(ss, ebp - 0xc), -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
    II(0x10159f3e, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
    II(0x10159f43, 0x5)   calld(0x100f448c, -0x65abc);          /* call 0x100f448c */
    II(0x10159f48, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x10159f4b, 0x4)   cmp(memb_a32(ds, eax + 0x3d), 0xb);   /* cmp byte [eax+0x3d], 0xb */
    II(0x10159f4f, 0x2)   jnzd(0x10159f70, 0x1f);               /* jnz 0x10159f70 */
    II(0x10159f51, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x10159f54, 0x5)   calld(0x100f3f62, -0x65ff7);          /* call 0x100f3f62 */
    II(0x10159f59, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x10159f5c, 0x5)   calld(0x100ffa70, -0x5a4f1);          /* call 0x100ffa70 */
    II(0x10159f61, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10159f63, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10159f66, 0x5)   calld(0x10075f2c, -0xe403f);          /* call 0x10075f2c */
    II(0x10159f6b, 0x5)   jmpd(0x1015a082, 0x112);              /* jmp 0x1015a082 */
l_0x10159f70:
    II(0x10159f70, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x10159f73, 0x3)   mov(ebx, memd_a32(ds, eax + 0x1a));   /* mov ebx, [eax+0x1a] */
    II(0x10159f76, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x10159f79, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x10159f7c, 0x3)   mov(edx, memd_a32(ds, eax + 0x18));   /* mov edx, [eax+0x18] */
    II(0x10159f7f, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x10159f82, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x10159f85, 0x3)   mov(al, memb_a32(ds, eax + 0x26));    /* mov al, [eax+0x26] */
    II(0x10159f88, 0x2)   xor_(ah, ah);                         /* xor ah, ah */
    II(0x10159f8a, 0x1)   cwde();                               /* cwde */
    II(0x10159f8b, 0x5)   calld(0x100741dc, -0xe5db4);          /* call 0x100741dc */
    II(0x10159f90, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10159f92, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10159f95, 0x5)   calld(0x10076630, -0xe396a);          /* call 0x10076630 */
    II(0x10159f9a, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10159f9c, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10159f9f, 0x5)   calld(0x1013ad11, -0x1f293);          /* call 0x1013ad11 */
    II(0x10159fa4, 0x2)   test(al, al);                         /* test al, al */
    II(0x10159fa6, 0x2)   jzd(0x10159fd0, 0x28);                /* jz 0x10159fd0 */
    II(0x10159fa8, 0x5)   calld(0x100caa00, -0x8f5ad);          /* call 0x100caa00 */
    II(0x10159fad, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x10159fb2, 0x1)   pushd(eax);                           /* push eax */
    II(0x10159fb3, 0x5)   calld(0x100caa20, -0x8f598);          /* call 0x100caa20 */
    II(0x10159fb8, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x10159fba, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x10159fbc, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x10159fc1, 0x5)   mov(eax, 0x101b26ae);                 /* mov eax, 0x101b26ae */ /* "Unable to clear at current location." */
    II(0x10159fc6, 0x5)   calld(0x10115d23, -0x442a8);          /* call 0x10115d23 */
    II(0x10159fcb, 0x5)   jmpd(0x1015a078, 0xa8);               /* jmp 0x1015a078 */
l_0x10159fd0:
    II(0x10159fd0, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10159fd3, 0x5)   calld(0x10076600, -0xe39d8);          /* call 0x10076600 */
    II(0x10159fd8, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10159fda, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x10159fdd, 0x5)   calld(0x1008a998, -0xcf64a);          /* call 0x1008a998 */
    II(0x10159fe2, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10159fe5, 0x5)   calld(0x10076574, -0xe3a76);          /* call 0x10076574 */
    II(0x10159fea, 0x4)   test(memb_a32(ds, eax + 0x12), 0x10); /* test byte [eax+0x12], 0x10 */
    II(0x10159fee, 0x2)   jzd(0x10159ff9, 0x9);                 /* jz 0x10159ff9 */
    II(0x10159ff0, 0x7)   mov(memd_a32(ss, ebp - 0x1c), 0x4);   /* mov dword [ebp-0x1c], 0x4 */
    II(0x10159ff7, 0x2)   jmpd(0x1015a000, 0x7);                /* jmp 0x1015a000 */
l_0x10159ff9:
    II(0x10159ff9, 0x7)   mov(memd_a32(ss, ebp - 0x1c), 0x1);   /* mov dword [ebp-0x1c], 0x1 */
l_0x1015a000:
    II(0x1015a000, 0x3)   mov(al, memb_a32(ss, ebp - 0x1c));    /* mov al, [ebp-0x1c] */
    II(0x1015a003, 0x3)   mov(edx, memd_a32(ss, ebp - 0x18));   /* mov edx, [ebp-0x18] */
    II(0x1015a006, 0x3)   mov(memb_a32(ds, edx + 0x45), al);    /* mov [edx+0x45], al */
    II(0x1015a009, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1015a00b, 0x5)   mov(edx, 0xb);                        /* mov edx, 0xb */
    II(0x1015a010, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x1015a013, 0x5)   calld(0x10163053, 0x903b);            /* call 0x10163053 */
    II(0x1015a018, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x1015a01b, 0x5)   calld(0x1010094d, -0x596d3);          /* call 0x1010094d */
    II(0x1015a020, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x1015a023, 0x5)   calld(0x101019b8, -0x58670);          /* call 0x101019b8 */
    II(0x1015a028, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x1015a02b, 0x3)   mov(al, memb_a32(ds, eax + 0x45));    /* mov al, [eax+0x45] */
    II(0x1015a02e, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x1015a033, 0x1)   pushd(eax);                           /* push eax */
    II(0x1015a034, 0x5)   mov(eax, 0x101b26d3);                 /* mov eax, 0x101b26d3 */ /* "Number of turns to clear site: %i." */
    II(0x1015a039, 0x1)   pushd(eax);                           /* push eax */
    II(0x1015a03a, 0x6)   lea(eax, ebp - 0x1ac);                /* lea eax, [ebp+0xfffffe54] */
    II(0x1015a040, 0x1)   pushd(eax);                           /* push eax */
    II(0x1015a041, 0x5)   calld(sys_sprintf, 0xbebb);           /* call 0x10165f01 */
    II(0x1015a046, 0x3)   add(esp, 0xc);                        /* add esp, 0xc */
    II(0x1015a049, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x1015a04c, 0x3)   mov(ebx, memd_a32(ds, eax + 0x1a));   /* mov ebx, [eax+0x1a] */
    II(0x1015a04f, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x1015a052, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x1015a055, 0x3)   mov(edx, memd_a32(ds, eax + 0x18));   /* mov edx, [eax+0x18] */
    II(0x1015a058, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x1015a05b, 0x6)   lea(eax, ebp - 0x1b0);                /* lea eax, [ebp+0xfffffe50] */
    II(0x1015a061, 0x5)   calld(0x10076aac, -0xe35ba);          /* call 0x10076aac */
    II(0x1015a066, 0x2)   mov(ecx, memd_a32(ds, eax));          /* mov ecx, [eax] */
    II(0x1015a068, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x18));   /* mov ebx, [ebp-0x18] */
    II(0x1015a06b, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1015a06d, 0x6)   lea(eax, ebp - 0x1ac);                /* lea eax, [ebp+0xfffffe54] */
    II(0x1015a073, 0x5)   calld(0x10115b60, -0x44518);          /* call 0x10115b60 */
l_0x1015a078:
    II(0x1015a078, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1015a07a, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x1015a07d, 0x5)   calld(0x10075f2c, -0xe4156);          /* call 0x10075f2c */
l_0x1015a082:
    II(0x1015a082, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1015a084, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1015a085, 0x1)   popd(edi);                            /* pop edi */
    II(0x1015a086, 0x1)   popd(esi);                            /* pop esi */
    II(0x1015a087, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1015a088, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1015a089, 0x1)   retd();                               /* ret */
FUNC_END

