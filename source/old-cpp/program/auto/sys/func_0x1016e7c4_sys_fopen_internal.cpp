FUNC_BEGIN(sys_fopen_internal, 0xfb2c4535dab05df9, 0x20, ({0x53, 0x51, 0x56, 0x57, 0x55, 0x81, 0xec, 0xa4, 0, 0, 0, 0x89, 0xc5, 0x89, 0x94, 0x24, 0xa0, 0, 0, 0, 0x8b, 0x15, 0xc0, 0xe1, 0x1b, 0x10, 0x85, 0xd2, 0xf, 0x84, 0x75, 0x2, 0, 0, 0x85, 0xc0, 0xf, 0x84, 0x6d, 0x2, 0, 0, 0x83, 0xbc, 0x24, 0xa0, 0, 0, 0, 0, 0xf, 0x84, 0x5f, 0x2, 0, 0, 0x83, 0x7a, 0x3c, 0xa, 0xf, 0x8d, 0x55, 0x2, 0, 0, 0x8b, 0x94, 0x24, 0xa0, 0, 0, 0, 0xbb, 0xff, 0xff, 0xff, 0xff, 0xb9, 0x1, 0, 0, 0, 0x80, 0x3a, 0, 0x74, 0x35, 0x8a, 0x2, 0x3c, 0x62, 0x72, 0xe, 0x76, 0x1f, 0x3c, 0x72, 0x72, 0x21, 0x76, 0x12, 0x3c, 0x77, 0x74, 0x19, 0xeb, 0x19, 0x3c, 0x2b, 0x72, 0x15, 0x76, 0x11, 0x3c, 0x61, 0x74, 0xd, 0xeb, 0xd, 0xbb, 0x1, 0, 0, 0, 0xeb, 0x6, 0x31, 0xc9, 0xeb, 0x2, 0x31, 0xdb, 0x8a, 0x62, 0x1, 0x42, 0x84, 0xe4, 0x75, 0xcb, 0x83, 0xfb, 0xff, 0xf, 0x84, 0x1, 0x2, 0, 0, 0xbe, 0x1, 0, 0, 0, 0x39, 0xf1, 0xf, 0x94, 0xc0, 0x31, 0xc9, 0x88, 0xc1, 0x8a, 0x55, 0, 0x1, 0xf1, 0x80, 0xfa, 0x40, 0x75, 0x20, 0x89, 0xe7, 0x1, 0xee, 0x57, 0x8a, 0x6, 0x88, 0x7, 0x3c, 0, 0x74, 0x10, 0x8a, 0x46, 0x1, 0x83, 0xc6, 0x2, 0x88, 0x47, 0x1, 0x83, 0xc7, 0x2, 0x3c, 0, 0x75, 0xe8, 0x5f, 0x31, 0xf6, 0xa1, 0xc0, 0xe1, 0x1b, 0x10, 0x8b, 0x78, 0xc, 0x85, 0xff, 0x74, 0x3d, 0x85, 0xf6, 0x74, 0x14, 0x55, 0x57, 0x68, 0xd0, 0x2e, 0x1b, 0x10, 0x8d, 0x44, 0x24, 0xc, 0x50, 0xe8, 0x4e, 0x76, 0xff, 0xff, 0x83, 0xc4, 0x10, 0x8b, 0x94, 0x24, 0xa0, 0, 0, 0, 0x89, 0xe0, 0xe8, 0xb6, 0x3a, 0, 0, 0x85, 0xc0, 0x74, 0x13, 0x80, 0xc9, 0x4, 0x31, 0xdb, 0x31, 0xd2, 0xe8, 0x84, 0x24, 0, 0, 0x89, 0xc3, 0xe9, 0x82, 0x1, 0, 0, 0x85, 0xdb, 0xf, 0x84, 0x78, 0x1, 0, 0, 0xa1, 0xc0, 0xe1, 0x1b, 0x10, 0x83, 0x38, 0, 0xf, 0x84, 0x6a, 0x1, 0, 0, 0x85, 0xf6, 0x74, 0x17, 0x55, 0x8b, 0x70, 0x8, 0x56, 0x68, 0xd0, 0x2e, 0x1b, 0x10, 0x8d, 0x44, 0x24, 0xc, 0x50, 0xe8, 0xf8, 0x75, 0xff, 0xff, 0x83, 0xc4, 0x10, 0x89, 0xe0, 0x8d, 0x94, 0x24, 0x90, 0, 0, 0, 0xe8, 0x28, 0xaa, 0, 0, 0x89, 0xe0, 0xe8, 0x7, 0x27, 0, 0, 0x83, 0xf8, 0xff, 0xf, 0x84, 0x31, 0x1, 0, 0, 0xa1, 0xc0, 0xe1, 0x1b, 0x10, 0x8b, 0x78, 0x4, 0x85, 0xff, 0xf, 0x84, 0x21, 0x1, 0, 0, 0x8b, 0x94, 0x24, 0x94, 0, 0, 0, 0x89, 0xf8, 0x31, 0xdb, 0xe8, 0x26, 0x3b, 0, 0, 0x85, 0xc0, 0xf, 0x85, 0x9, 0x1, 0, 0, 0x83, 0xbc, 0x24, 0x90, 0, 0, 0, 0, 0x75, 0xb, 0xc7, 0x84, 0x24, 0x90, 0, 0, 0, 0x10, 0, 0, 0, 0x8b, 0x84, 0x24, 0x90, 0, 0, 0, 0x25, 0xf0, 0, 0, 0, 0x83, 0xf8, 0x20, 0x72, 0x10, 0x76, 0x72, 0x83, 0xf8, 0x40, 0xf, 0x84, 0x92, 0, 0, 0, 0xe9, 0xd3, 0, 0, 0, 0x83, 0xf8, 0x10, 0xf, 0x85, 0xca, 0, 0, 0, 0xbb, 0x1, 0, 0, 0, 0x8b, 0x84, 0x24, 0x98, 0, 0, 0, 0x89, 0x1d, 0xc4, 0xe1, 0x1b, 0x10, 0xff, 0x15, 0xc8, 0xe1, 0x1b, 0x10, 0x89, 0xc5, 0x85, 0xc0, 0xf, 0x84, 0xa8, 0, 0, 0, 0xa1, 0xc0, 0xe1, 0x1b, 0x10, 0x8b, 0x9c, 0x24, 0x9c, 0, 0, 0, 0x89, 0xea, 0x8b, 0x40, 0x4, 0x80, 0xc9, 0x18, 0xe8, 0x84, 0x95, 0x1, 0, 0x8b, 0x9c, 0x24, 0x98, 0, 0, 0, 0x89, 0xea, 0x31, 0xc0, 0xe8, 0x7c, 0x23, 0, 0, 0x89, 0xc3, 0x89, 0xd8, 0x81, 0xc4, 0xa4, 0, 0, 0, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3, 0x8b, 0x9c, 0x24, 0x98, 0, 0, 0, 0xa1, 0xc0, 0xe1, 0x1b, 0x10, 0x80, 0xc9, 0x28, 0x31, 0xd2, 0x8b, 0x40, 0x4, 0xe8, 0x53, 0x23, 0, 0, 0x89, 0xc3, 0x89, 0xd8, 0x81, 0xc4, 0xa4, 0, 0, 0, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3, 0xba, 0x1, 0, 0, 0, 0xb8, 0, 0x40, 0, 0, 0x89, 0x15, 0xc4, 0xe1, 0x1b, 0x10, 0xff, 0x15, 0xc8, 0xe1, 0x1b, 0x10, 0x85, 0xc0, 0x74, 0x2c, 0x8b, 0x35, 0xc0, 0xe1, 0x1b, 0x10, 0x8b, 0x9c, 0x24, 0x98, 0, 0, 0, 0x80, 0xc9, 0x48, 0x8b, 0x76, 0x4, 0x89, 0xc2, 0x89, 0xf0, 0xe8, 0xd, 0x23, 0, 0, 0x89, 0xc3, 0x89, 0xd8, 0x81, 0xc4, 0xa4, 0, 0, 0, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3, 0x31, 0xdb, 0x89, 0xd8, 0x81, 0xc4, 0xa4, 0, 0, 0, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1016e7c4, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1016e7c5, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1016e7c6, 0x1)   pushd(esi);                           /* push esi */
    II(0x1016e7c7, 0x1)   pushd(edi);                           /* push edi */
    II(0x1016e7c8, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1016e7c9, 0x6)   sub(esp, 0xa4);                       /* sub esp, 0xa4 */
    II(0x1016e7cf, 0x2)   mov(ebp, eax);                        /* mov ebp, eax */
    II(0x1016e7d1, 0x7)   mov(memd_a32(ss, esp + 0xa0), edx);   /* mov [esp+0xa0], edx */
    II(0x1016e7d8, 0x6)   mov(edx, memd_a32(ds, 0x101be1c0));   /* mov edx, [0x101be1c0] */
    II(0x1016e7de, 0x2)   test(edx, edx);                       /* test edx, edx */
    II(0x1016e7e0, 0x6)   jzd(0x1016ea5b, 0x275);               /* jz dword 0x1016ea5b */
    II(0x1016e7e6, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1016e7e8, 0x6)   jzd(0x1016ea5b, 0x26d);               /* jz dword 0x1016ea5b */
    II(0x1016e7ee, 0x8)   cmp(memd_a32(ss, esp + 0xa0), 0);     /* cmp dword [esp+0xa0], 0x0 */
    II(0x1016e7f6, 0x6)   jzd(0x1016ea5b, 0x25f);               /* jz dword 0x1016ea5b */
    II(0x1016e7fc, 0x4)   cmp(memd_a32(ds, edx + 0x3c), 0xa);   /* cmp dword [edx+0x3c], 0xa */
    II(0x1016e800, 0x6)   jged(0x1016ea5b, 0x255);              /* jge dword 0x1016ea5b */
    II(0x1016e806, 0x7)   mov(edx, memd_a32(ss, esp + 0xa0));   /* mov edx, [esp+0xa0] */
    II(0x1016e80d, 0x5)   mov(ebx, 0xffffffff);                 /* mov ebx, 0xffffffff */
    II(0x1016e812, 0x5)   mov(ecx, 0x1);                        /* mov ecx, 0x1 */
    II(0x1016e817, 0x3)   cmp(memb_a32(ds, edx), 0);            /* cmp byte [edx], 0x0 */
    II(0x1016e81a, 0x2)   jzd(0x1016e851, 0x35);                /* jz 0x1016e851 */
l_0x1016e81c:
    II(0x1016e81c, 0x2)   mov(al, memb_a32(ds, edx));           /* mov al, [edx] */
    II(0x1016e81e, 0x2)   cmp(al, 0x62);                        /* cmp al, 0x62 */
    II(0x1016e820, 0x2)   jbd(0x1016e830, 0xe);                 /* jb 0x1016e830 */
    II(0x1016e822, 0x2)   jbed(0x1016e843, 0x1f);               /* jbe 0x1016e843 */
    II(0x1016e824, 0x2)   cmp(al, 0x72);                        /* cmp al, 0x72 */
    II(0x1016e826, 0x2)   jbd(0x1016e849, 0x21);                /* jb 0x1016e849 */
    II(0x1016e828, 0x2)   jbed(0x1016e83c, 0x12);               /* jbe 0x1016e83c */
    II(0x1016e82a, 0x2)   cmp(al, 0x77);                        /* cmp al, 0x77 */
    II(0x1016e82c, 0x2)   jzd(0x1016e847, 0x19);                /* jz 0x1016e847 */
    II(0x1016e82e, 0x2)   jmpd(0x1016e849, 0x19);               /* jmp 0x1016e849 */
l_0x1016e830:
    II(0x1016e830, 0x2)   cmp(al, 0x2b);                        /* cmp al, 0x2b */
    II(0x1016e832, 0x2)   jbd(0x1016e849, 0x15);                /* jb 0x1016e849 */
    II(0x1016e834, 0x2)   jbed(0x1016e847, 0x11);               /* jbe 0x1016e847 */
    II(0x1016e836, 0x2)   cmp(al, 0x61);                        /* cmp al, 0x61 */
    II(0x1016e838, 0x2)   jzd(0x1016e847, 0xd);                 /* jz 0x1016e847 */
    II(0x1016e83a, 0x2)   jmpd(0x1016e849, 0xd);                /* jmp 0x1016e849 */
l_0x1016e83c:
    II(0x1016e83c, 0x5)   mov(ebx, 0x1);                        /* mov ebx, 0x1 */
    II(0x1016e841, 0x2)   jmpd(0x1016e849, 0x6);                /* jmp 0x1016e849 */
l_0x1016e843:
    II(0x1016e843, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x1016e845, 0x2)   jmpd(0x1016e849, 0x2);                /* jmp 0x1016e849 */
l_0x1016e847:
    II(0x1016e847, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
l_0x1016e849:
    II(0x1016e849, 0x3)   mov(ah, memb_a32(ds, edx + 0x1));     /* mov ah, [edx+0x1] */
    II(0x1016e84c, 0x1)   inc(edx);                             /* inc edx */
    II(0x1016e84d, 0x2)   test(ah, ah);                         /* test ah, ah */
    II(0x1016e84f, 0x2)   jnzd(0x1016e81c, -0x35);              /* jnz 0x1016e81c */
l_0x1016e851:
    II(0x1016e851, 0x3)   cmp(ebx, -0x1 /* 0xff */);            /* cmp ebx, 0xff */
    II(0x1016e854, 0x6)   jzd(0x1016ea5b, 0x201);               /* jz dword 0x1016ea5b */
    II(0x1016e85a, 0x5)   mov(esi, 0x1);                        /* mov esi, 0x1 */
    II(0x1016e85f, 0x2)   cmp(ecx, esi);                        /* cmp ecx, esi */
    II(0x1016e861, 0x3)   setz(al);                             /* setz al */
    II(0x1016e864, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x1016e866, 0x2)   mov(cl, al);                          /* mov cl, al */
    II(0x1016e868, 0x3)   mov(dl, memb_a32(ss, ebp + 0));       /* mov dl, [ebp+0x0] */
    II(0x1016e86b, 0x2)   add(ecx, esi);                        /* add ecx, esi */
    II(0x1016e86d, 0x3)   cmp(dl, 0x40);                        /* cmp dl, 0x40 */
    II(0x1016e870, 0x2)   jnzd(0x1016e892, 0x20);               /* jnz 0x1016e892 */
    II(0x1016e872, 0x2)   mov(edi, esp);                        /* mov edi, esp */
    II(0x1016e874, 0x2)   add(esi, ebp);                        /* add esi, ebp */
    II(0x1016e876, 0x1)   pushd(edi);                           /* push edi */
l_0x1016e877:
    II(0x1016e877, 0x2)   mov(al, memb_a32(ds, esi));           /* mov al, [esi] */
    II(0x1016e879, 0x2)   mov(memb_a32(ds, edi), al);           /* mov [edi], al */
    II(0x1016e87b, 0x2)   cmp(al, 0);                           /* cmp al, 0x0 */
    II(0x1016e87d, 0x2)   jzd(0x1016e88f, 0x10);                /* jz 0x1016e88f */
    II(0x1016e87f, 0x3)   mov(al, memb_a32(ds, esi + 0x1));     /* mov al, [esi+0x1] */
    II(0x1016e882, 0x3)   add(esi, 0x2);                        /* add esi, 0x2 */
    II(0x1016e885, 0x3)   mov(memb_a32(ds, edi + 0x1), al);     /* mov [edi+0x1], al */
    II(0x1016e888, 0x3)   add(edi, 0x2);                        /* add edi, 0x2 */
    II(0x1016e88b, 0x2)   cmp(al, 0);                           /* cmp al, 0x0 */
    II(0x1016e88d, 0x2)   jnzd(0x1016e877, -0x18);              /* jnz 0x1016e877 */
l_0x1016e88f:
    II(0x1016e88f, 0x1)   popd(edi);                            /* pop edi */
    II(0x1016e890, 0x2)   xor_(esi, esi);                       /* xor esi, esi */
l_0x1016e892:
    II(0x1016e892, 0x5)   mov(eax, memd_a32(ds, 0x101be1c0));   /* mov eax, [0x101be1c0] */
    II(0x1016e897, 0x3)   mov(edi, memd_a32(ds, eax + 0xc));    /* mov edi, [eax+0xc] */
    II(0x1016e89a, 0x2)   test(edi, edi);                       /* test edi, edi */
    II(0x1016e89c, 0x2)   jzd(0x1016e8db, 0x3d);                /* jz 0x1016e8db */
    II(0x1016e89e, 0x2)   test(esi, esi);                       /* test esi, esi */
    II(0x1016e8a0, 0x2)   jzd(0x1016e8b6, 0x14);                /* jz 0x1016e8b6 */
    II(0x1016e8a2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1016e8a3, 0x1)   pushd(edi);                           /* push edi */
    II(0x1016e8a4, 0x5)   pushd(0x101b2ed0);                    /* push dword 0x101b2ed0 */ /* "%s%s" */
    II(0x1016e8a9, 0x4)   lea(eax, esp + 0xc);                  /* lea eax, [esp+0xc] */
    II(0x1016e8ad, 0x1)   pushd(eax);                           /* push eax */
    II(0x1016e8ae, 0x5)   calld(sys_sprintf, -0x89b2);          /* call 0x10165f01 */
    II(0x1016e8b3, 0x3)   add(esp, 0x10);                       /* add esp, 0x10 */
l_0x1016e8b6:
    II(0x1016e8b6, 0x7)   mov(edx, memd_a32(ss, esp + 0xa0));   /* mov edx, [esp+0xa0] */
    II(0x1016e8bd, 0x2)   mov(eax, esp);                        /* mov eax, esp */
    II(0x1016e8bf, 0x5)   calld(sys_fopen, 0x3ab6);             /* call 0x1017237a */
    II(0x1016e8c4, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1016e8c6, 0x2)   jzd(0x1016e8db, 0x13);                /* jz 0x1016e8db */
    II(0x1016e8c8, 0x3)   or_(cl, 0x4);                         /* or cl, 0x4 */
    II(0x1016e8cb, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1016e8cd, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1016e8cf, 0x5)   calld(/* sys */ 0x10170d58, 0x2484);  /* call 0x10170d58 */
    II(0x1016e8d4, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x1016e8d6, 0x5)   jmpd(0x1016ea5d, 0x182);              /* jmp 0x1016ea5d */
l_0x1016e8db:
    II(0x1016e8db, 0x2)   test(ebx, ebx);                       /* test ebx, ebx */
    II(0x1016e8dd, 0x6)   jzd(0x1016ea5b, 0x178);               /* jz dword 0x1016ea5b */
    II(0x1016e8e3, 0x5)   mov(eax, memd_a32(ds, 0x101be1c0));   /* mov eax, [0x101be1c0] */
    II(0x1016e8e8, 0x3)   cmp(memd_a32(ds, eax), 0);            /* cmp dword [eax], 0x0 */
    II(0x1016e8eb, 0x6)   jzd(0x1016ea5b, 0x16a);               /* jz dword 0x1016ea5b */
    II(0x1016e8f1, 0x2)   test(esi, esi);                       /* test esi, esi */
    II(0x1016e8f3, 0x2)   jzd(0x1016e90c, 0x17);                /* jz 0x1016e90c */
    II(0x1016e8f5, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1016e8f6, 0x3)   mov(esi, memd_a32(ds, eax + 0x8));    /* mov esi, [eax+0x8] */
    II(0x1016e8f9, 0x1)   pushd(esi);                           /* push esi */
    II(0x1016e8fa, 0x5)   pushd(0x101b2ed0);                    /* push dword 0x101b2ed0 */ /* "%s%s" */
    II(0x1016e8ff, 0x4)   lea(eax, esp + 0xc);                  /* lea eax, [esp+0xc] */
    II(0x1016e903, 0x1)   pushd(eax);                           /* push eax */
    II(0x1016e904, 0x5)   calld(sys_sprintf, -0x8a08);          /* call 0x10165f01 */
    II(0x1016e909, 0x3)   add(esp, 0x10);                       /* add esp, 0x10 */
l_0x1016e90c:
    II(0x1016e90c, 0x2)   mov(eax, esp);                        /* mov eax, esp */
    II(0x1016e90e, 0x7)   lea(edx, esp + 0x90);                 /* lea edx, [esp+0x90] */
    II(0x1016e915, 0x5)   calld(/* sys */ 0x10179342, 0xaa28);  /* call 0x10179342 */
    II(0x1016e91a, 0x2)   mov(eax, esp);                        /* mov eax, esp */
    II(0x1016e91c, 0x5)   calld(/* sys */ 0x10171028, 0x2707);  /* call 0x10171028 */
    II(0x1016e921, 0x3)   cmp(eax, -0x1 /* 0xff */);            /* cmp eax, 0xff */
    II(0x1016e924, 0x6)   jzd(0x1016ea5b, 0x131);               /* jz dword 0x1016ea5b */
    II(0x1016e92a, 0x5)   mov(eax, memd_a32(ds, 0x101be1c0));   /* mov eax, [0x101be1c0] */
    II(0x1016e92f, 0x3)   mov(edi, memd_a32(ds, eax + 0x4));    /* mov edi, [eax+0x4] */
    II(0x1016e932, 0x2)   test(edi, edi);                       /* test edi, edi */
    II(0x1016e934, 0x6)   jzd(0x1016ea5b, 0x121);               /* jz dword 0x1016ea5b */
    II(0x1016e93a, 0x7)   mov(edx, memd_a32(ss, esp + 0x94));   /* mov edx, [esp+0x94] */
    II(0x1016e941, 0x2)   mov(eax, edi);                        /* mov eax, edi */
    II(0x1016e943, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1016e945, 0x5)   calld(sys_fseek, 0x3b26);             /* call 0x10172470 */
    II(0x1016e94a, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1016e94c, 0x6)   jnzd(0x1016ea5b, 0x109);              /* jnz dword 0x1016ea5b */
    II(0x1016e952, 0x8)   cmp(memd_a32(ss, esp + 0x90), 0);     /* cmp dword [esp+0x90], 0x0 */
    II(0x1016e95a, 0x2)   jnzd(0x1016e967, 0xb);                /* jnz 0x1016e967 */
    II(0x1016e95c, 0xb)   mov(memd_a32(ss, esp + 0x90), 0x10);  /* mov dword [esp+0x90], 0x10 */
l_0x1016e967:
    II(0x1016e967, 0x7)   mov(eax, memd_a32(ss, esp + 0x90));   /* mov eax, [esp+0x90] */
    II(0x1016e96e, 0x5)   and_(eax, 0xf0);                      /* and eax, 0xf0 */
    II(0x1016e973, 0x3)   cmp(eax, 0x20);                       /* cmp eax, 0x20 */
    II(0x1016e976, 0x2)   jbd(0x1016e988, 0x10);                /* jb 0x1016e988 */
    II(0x1016e978, 0x2)   jbed(0x1016e9ec, 0x72);               /* jbe 0x1016e9ec */
    II(0x1016e97a, 0x3)   cmp(eax, 0x40);                       /* cmp eax, 0x40 */
    II(0x1016e97d, 0x6)   jzd(0x1016ea15, 0x92);                /* jz dword 0x1016ea15 */
    II(0x1016e983, 0x5)   jmpd(0x1016ea5b, 0xd3);               /* jmp 0x1016ea5b */
l_0x1016e988:
    II(0x1016e988, 0x3)   cmp(eax, 0x10);                       /* cmp eax, 0x10 */
    II(0x1016e98b, 0x6)   jnzd(0x1016ea5b, 0xca);               /* jnz dword 0x1016ea5b */
    II(0x1016e991, 0x5)   mov(ebx, 0x1);                        /* mov ebx, 0x1 */
    II(0x1016e996, 0x7)   mov(eax, memd_a32(ss, esp + 0x98));   /* mov eax, [esp+0x98] */
    II(0x1016e99d, 0x6)   mov(memd_a32(ds, 0x101be1c4), ebx);   /* mov [0x101be1c4], ebx */
    II(0x1016e9a3, 0x6)   calld_abs(memd_a32(ds, 0x101be1c8));  /* call dword near [0x101be1c8] */ /* Вызов '0x101711a4'. */
    II(0x1016e9a9, 0x2)   mov(ebp, eax);                        /* mov ebp, eax */
    II(0x1016e9ab, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1016e9ad, 0x6)   jzd(0x1016ea5b, 0xa8);                /* jz dword 0x1016ea5b */
    II(0x1016e9b3, 0x5)   mov(eax, memd_a32(ds, 0x101be1c0));   /* mov eax, [0x101be1c0] */
    II(0x1016e9b8, 0x7)   mov(ebx, memd_a32(ss, esp + 0x9c));   /* mov ebx, [esp+0x9c] */
    II(0x1016e9bf, 0x2)   mov(edx, ebp);                        /* mov edx, ebp */
    II(0x1016e9c1, 0x3)   mov(eax, memd_a32(ds, eax + 0x4));    /* mov eax, [eax+0x4] */
    II(0x1016e9c4, 0x3)   or_(cl, 0x18);                        /* or cl, 0x18 */
    II(0x1016e9c7, 0x5)   calld(/* sys */ 0x10187f50, 0x19584); /* call 0x10187f50 */
    II(0x1016e9cc, 0x7)   mov(ebx, memd_a32(ss, esp + 0x98));   /* mov ebx, [esp+0x98] */
    II(0x1016e9d3, 0x2)   mov(edx, ebp);                        /* mov edx, ebp */
    II(0x1016e9d5, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1016e9d7, 0x5)   calld(/* sys */ 0x10170d58, 0x237c);  /* call 0x10170d58 */
    II(0x1016e9dc, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
//    II(0x1016e9de, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x1016e9e0, 0x6)   add(esp, 0xa4);                       /* add esp, 0xa4 */
    II(0x1016e9e6, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1016e9e7, 0x1)   popd(edi);                            /* pop edi */
    II(0x1016e9e8, 0x1)   popd(esi);                            /* pop esi */
    II(0x1016e9e9, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1016e9ea, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1016e9eb, 0x1)   retd();                               /* ret */
l_0x1016e9ec:
    II(0x1016e9ec, 0x7)   mov(ebx, memd_a32(ss, esp + 0x98));   /* mov ebx, [esp+0x98] */
    II(0x1016e9f3, 0x5)   mov(eax, memd_a32(ds, 0x101be1c0));   /* mov eax, [0x101be1c0] */
    II(0x1016e9f8, 0x3)   or_(cl, 0x28);                        /* or cl, 0x28 */
    II(0x1016e9fb, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1016e9fd, 0x3)   mov(eax, memd_a32(ds, eax + 0x4));    /* mov eax, [eax+0x4] */
    II(0x1016ea00, 0x5)   calld(/* sys */ 0x10170d58, 0x2353);  /* call 0x10170d58 */
    II(0x1016ea05, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
//    II(0x1016ea07, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x1016ea09, 0x6)   add(esp, 0xa4);                       /* add esp, 0xa4 */
    II(0x1016ea0f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1016ea10, 0x1)   popd(edi);                            /* pop edi */
    II(0x1016ea11, 0x1)   popd(esi);                            /* pop esi */
    II(0x1016ea12, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1016ea13, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1016ea14, 0x1)   retd();                               /* ret */
l_0x1016ea15:
    II(0x1016ea15, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x1016ea1a, 0x5)   mov(eax, 0x4000);                     /* mov eax, 0x4000 */
    II(0x1016ea1f, 0x6)   mov(memd_a32(ds, 0x101be1c4), edx);   /* mov [0x101be1c4], edx */
    II(0x1016ea25, 0x6)   calld_abs(memd_a32(ds, 0x101be1c8));  /* call dword near [0x101be1c8] */ /* Вызов '0x101711a4'. */
    II(0x1016ea2b, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1016ea2d, 0x2)   jzd(0x1016ea5b, 0x2c);                /* jz 0x1016ea5b */
    II(0x1016ea2f, 0x6)   mov(esi, memd_a32(ds, 0x101be1c0));   /* mov esi, [0x101be1c0] */
    II(0x1016ea35, 0x7)   mov(ebx, memd_a32(ss, esp + 0x98));   /* mov ebx, [esp+0x98] */
    II(0x1016ea3c, 0x3)   or_(cl, 0x48);                        /* or cl, 0x48 */
    II(0x1016ea3f, 0x3)   mov(esi, memd_a32(ds, esi + 0x4));    /* mov esi, [esi+0x4] */
    II(0x1016ea42, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1016ea44, 0x2)   mov(eax, esi);                        /* mov eax, esi */
    II(0x1016ea46, 0x5)   calld(/* sys */ 0x10170d58, 0x230d);  /* call 0x10170d58 */
    II(0x1016ea4b, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
//    II(0x1016ea4d, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x1016ea4f, 0x6)   add(esp, 0xa4);                       /* add esp, 0xa4 */
    II(0x1016ea55, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1016ea56, 0x1)   popd(edi);                            /* pop edi */
    II(0x1016ea57, 0x1)   popd(esi);                            /* pop esi */
    II(0x1016ea58, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1016ea59, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1016ea5a, 0x1)   retd();                               /* ret */
l_0x1016ea5b:
    II(0x1016ea5b, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
l_0x1016ea5d:
    II(0x1016ea5d, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x1016ea5f, 0x6)   add(esp, 0xa4);                       /* add esp, 0xa4 */
    II(0x1016ea65, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1016ea66, 0x1)   popd(edi);                            /* pop edi */
    II(0x1016ea67, 0x1)   popd(esi);                            /* pop esi */
    II(0x1016ea68, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1016ea69, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1016ea6a, 0x1)   retd();                               /* ret */
FUNC_END

