FUNC_BEGIN(0x10116536, 0x166528f5da52623a, 0x20, ({0x68, 0x44, 0, 0, 0, 0xe8, 0x12, 0xf8, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x2c, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf7, 0x45, 0xfc, 0x4, 0, 0, 0, 0x74, 0x17, 0xba, 0x1c, 0x67, 0x1b, 0x10, 0x8b, 0x45, 0xf8, 0xe8, 0x4f, 0xfa, 0x4, 0, 0xe8, 0x6a, 0xfa, 0x4, 0, 0xe9, 0x11, 0x1, 0, 0, 0x8b, 0x45, 0xf8, 0xc7, 0x40, 0x13, 0x44, 0x67, 0x1b, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x32, 0x89, 0x45, 0xec, 0x83, 0x7d, 0xec, 0, 0x74, 0x14, 0x31, 0xd2, 0x8b, 0x45, 0xec, 0xe8, 0xa2, 0x7f, 0xfb, 0xff, 0xe8, 0xc9, 0xf9, 0x4, 0, 0x89, 0x45, 0xf0, 0xeb, 0x7, 0xc7, 0x45, 0xf0, 0, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x83, 0x78, 0x45, 0, 0x74, 0x15, 0xba, 0x10, 0x5c, 0x1b, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x45, 0xe8, 0xf8, 0xf9, 0x4, 0, 0xe8, 0x13, 0xfa, 0x4, 0, 0x8b, 0x45, 0xf8, 0x83, 0x78, 0x36, 0, 0x74, 0x2a, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x36, 0x89, 0x45, 0xe4, 0x83, 0x7d, 0xe4, 0, 0x74, 0x14, 0x31, 0xd2, 0x8b, 0x45, 0xe4, 0xe8, 0x51, 0x7f, 0xfb, 0xff, 0xe8, 0x78, 0xf9, 0x4, 0, 0x89, 0x45, 0xe8, 0xeb, 0x7, 0xc7, 0x45, 0xe8, 0, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x83, 0x78, 0x3a, 0, 0x74, 0x2a, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x3a, 0x89, 0x45, 0xdc, 0x83, 0x7d, 0xdc, 0, 0x74, 0x14, 0x31, 0xd2, 0x8b, 0x45, 0xdc, 0xe8, 0x1e, 0x7f, 0xfb, 0xff, 0xe8, 0x45, 0xf9, 0x4, 0, 0x89, 0x45, 0xe0, 0xeb, 0x7, 0xc7, 0x45, 0xe0, 0, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x83, 0x78, 0x41, 0, 0x74, 0x2a, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x41, 0x89, 0x45, 0xd4, 0x83, 0x7d, 0xd4, 0, 0x74, 0x14, 0x31, 0xd2, 0x8b, 0x45, 0xd4, 0xe8, 0xe6, 0x16, 0xfc, 0xff, 0xe8, 0x12, 0xf9, 0x4, 0, 0x89, 0x45, 0xd8, 0xeb, 0x7, 0xc7, 0x45, 0xd8, 0, 0, 0, 0, 0xe8, 0xa0, 0x42, 0xfd, 0xff, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf8, 0xe8, 0x29, 0x3, 0xfc, 0xff, 0x89, 0x45, 0xf8, 0xf7, 0x45, 0xfc, 0x2, 0, 0, 0, 0x74, 0x8, 0x8b, 0x45, 0xf8, 0xe8, 0xe0, 0xf8, 0x4, 0, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10116536, 0x5)   pushd(0x44);                          /* push dword 0x44 */
    II(0x1011653b, 0x5)   calld(sys_check_available_stack_size, 0x4f812); /* call 0x10165d52 */
    II(0x10116540, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10116541, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10116542, 0x1)   pushd(esi);                           /* push esi */
    II(0x10116543, 0x1)   pushd(edi);                           /* push edi */
    II(0x10116544, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10116545, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10116547, 0x6)   sub(esp, 0x2c);                       /* sub esp, 0x2c */
    II(0x1011654d, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10116550, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10116553, 0x7)   test(memd_a32(ss, ebp - 0x4), 0x4);   /* test dword [ebp-0x4], 0x4 */
    II(0x1011655a, 0x2)   jzd(0x10116573, 0x17);                /* jz 0x10116573 */
    II(0x1011655c, 0x5)   mov(edx, 0x101b671c);                 /* mov edx, 0x101b671c */
    II(0x10116561, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10116564, 0x5)   calld(sys_call_dtor_arr, 0x4fa4f);    /* call 0x10165fb8 */
    II(0x10116569, 0x5)   calld(sys_delete_arr, 0x4fa6a);       /* call 0x10165fd8 */
    II(0x1011656e, 0x5)   jmpd(0x10116684, 0x111);              /* jmp 0x10116684 */
l_0x10116573:
    II(0x10116573, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10116576, 0x7)   mov(memd_a32(ds, eax + 0x13), 0x101b6744); /* mov dword [eax+0x13], 0x101b6744 */
    II(0x1011657d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10116580, 0x3)   mov(eax, memd_a32(ds, eax + 0x32));   /* mov eax, [eax+0x32] */
    II(0x10116583, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x10116586, 0x4)   cmp(memd_a32(ss, ebp - 0x14), 0);     /* cmp dword [ebp-0x14], 0x0 */
    II(0x1011658a, 0x2)   jzd(0x101165a0, 0x14);                /* jz 0x101165a0 */
    II(0x1011658c, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1011658e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x10116591, 0x5)   calld(my_dtor_d2, -0x4805e);          /* call 0x100ce538 */
    II(0x10116596, 0x5)   calld(sys_delete, 0x4f9c9);           /* call 0x10165f64 */
    II(0x1011659b, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x1011659e, 0x2)   jmpd(0x101165a7, 0x7);                /* jmp 0x101165a7 */
l_0x101165a0:
    II(0x101165a0, 0x7)   mov(memd_a32(ss, ebp - 0x10), 0);     /* mov dword [ebp-0x10], 0x0 */
l_0x101165a7:
    II(0x101165a7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101165aa, 0x4)   cmp(memd_a32(ds, eax + 0x45), 0);     /* cmp dword [eax+0x45], 0x0 */
    II(0x101165ae, 0x2)   jzd(0x101165c5, 0x15);                /* jz 0x101165c5 */
    II(0x101165b0, 0x5)   mov(edx, 0x101b5c10);                 /* mov edx, 0x101b5c10 */
    II(0x101165b5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101165b8, 0x3)   mov(eax, memd_a32(ds, eax + 0x45));   /* mov eax, [eax+0x45] */
    II(0x101165bb, 0x5)   calld(sys_call_dtor_arr, 0x4f9f8);    /* call 0x10165fb8 */
    II(0x101165c0, 0x5)   calld(sys_delete_arr, 0x4fa13);       /* call 0x10165fd8 */
l_0x101165c5:
    II(0x101165c5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101165c8, 0x4)   cmp(memd_a32(ds, eax + 0x36), 0);     /* cmp dword [eax+0x36], 0x0 */
    II(0x101165cc, 0x2)   jzd(0x101165f8, 0x2a);                /* jz 0x101165f8 */
    II(0x101165ce, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101165d1, 0x3)   mov(eax, memd_a32(ds, eax + 0x36));   /* mov eax, [eax+0x36] */
    II(0x101165d4, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
    II(0x101165d7, 0x4)   cmp(memd_a32(ss, ebp - 0x1c), 0);     /* cmp dword [ebp-0x1c], 0x0 */
    II(0x101165db, 0x2)   jzd(0x101165f1, 0x14);                /* jz 0x101165f1 */
    II(0x101165dd, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x101165df, 0x3)   mov(eax, memd_a32(ss, ebp - 0x1c));   /* mov eax, [ebp-0x1c] */
    II(0x101165e2, 0x5)   calld(my_dtor_d2, -0x480af);          /* call 0x100ce538 */
    II(0x101165e7, 0x5)   calld(sys_delete, 0x4f978);           /* call 0x10165f64 */
    II(0x101165ec, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
    II(0x101165ef, 0x2)   jmpd(0x101165f8, 0x7);                /* jmp 0x101165f8 */
l_0x101165f1:
    II(0x101165f1, 0x7)   mov(memd_a32(ss, ebp - 0x18), 0);     /* mov dword [ebp-0x18], 0x0 */
l_0x101165f8:
    II(0x101165f8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101165fb, 0x4)   cmp(memd_a32(ds, eax + 0x3a), 0);     /* cmp dword [eax+0x3a], 0x0 */
    II(0x101165ff, 0x2)   jzd(0x1011662b, 0x2a);                /* jz 0x1011662b */
    II(0x10116601, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10116604, 0x3)   mov(eax, memd_a32(ds, eax + 0x3a));   /* mov eax, [eax+0x3a] */
    II(0x10116607, 0x3)   mov(memd_a32(ss, ebp - 0x24), eax);   /* mov [ebp-0x24], eax */
    II(0x1011660a, 0x4)   cmp(memd_a32(ss, ebp - 0x24), 0);     /* cmp dword [ebp-0x24], 0x0 */
    II(0x1011660e, 0x2)   jzd(0x10116624, 0x14);                /* jz 0x10116624 */
    II(0x10116610, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10116612, 0x3)   mov(eax, memd_a32(ss, ebp - 0x24));   /* mov eax, [ebp-0x24] */
    II(0x10116615, 0x5)   calld(my_dtor_d2, -0x480e2);          /* call 0x100ce538 */
    II(0x1011661a, 0x5)   calld(sys_delete, 0x4f945);           /* call 0x10165f64 */
    II(0x1011661f, 0x3)   mov(memd_a32(ss, ebp - 0x20), eax);   /* mov [ebp-0x20], eax */
    II(0x10116622, 0x2)   jmpd(0x1011662b, 0x7);                /* jmp 0x1011662b */
l_0x10116624:
    II(0x10116624, 0x7)   mov(memd_a32(ss, ebp - 0x20), 0);     /* mov dword [ebp-0x20], 0x0 */
l_0x1011662b:
    II(0x1011662b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011662e, 0x4)   cmp(memd_a32(ds, eax + 0x41), 0);     /* cmp dword [eax+0x41], 0x0 */
    II(0x10116632, 0x2)   jzd(0x1011665e, 0x2a);                /* jz 0x1011665e */
    II(0x10116634, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10116637, 0x3)   mov(eax, memd_a32(ds, eax + 0x41));   /* mov eax, [eax+0x41] */
    II(0x1011663a, 0x3)   mov(memd_a32(ss, ebp - 0x2c), eax);   /* mov [ebp-0x2c], eax */
    II(0x1011663d, 0x4)   cmp(memd_a32(ss, ebp - 0x2c), 0);     /* cmp dword [ebp-0x2c], 0x0 */
    II(0x10116641, 0x2)   jzd(0x10116657, 0x14);                /* jz 0x10116657 */
    II(0x10116643, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10116645, 0x3)   mov(eax, memd_a32(ss, ebp - 0x2c));   /* mov eax, [ebp-0x2c] */
    II(0x10116648, 0x5)   calld(my_dtor_d3, -0x3e91a);          /* call 0x100d7d33 */
    II(0x1011664d, 0x5)   calld(sys_delete, 0x4f912);           /* call 0x10165f64 */
    II(0x10116652, 0x3)   mov(memd_a32(ss, ebp - 0x28), eax);   /* mov [ebp-0x28], eax */
    II(0x10116655, 0x2)   jmpd(0x1011665e, 0x7);                /* jmp 0x1011665e */
l_0x10116657:
    II(0x10116657, 0x7)   mov(memd_a32(ss, ebp - 0x28), 0);     /* mov dword [ebp-0x28], 0x0 */
l_0x1011665e:
    II(0x1011665e, 0x5)   calld(0x100ea903, -0x2bd60);          /* call 0x100ea903 */
    II(0x10116663, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x10116668, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011666b, 0x5)   calld(0x100d6999, -0x3fcd7);          /* call 0x100d6999 */
    II(0x10116670, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10116673, 0x7)   test(memd_a32(ss, ebp - 0x4), 0x2);   /* test dword [ebp-0x4], 0x2 */
    II(0x1011667a, 0x2)   jzd(0x10116684, 0x8);                 /* jz 0x10116684 */
    II(0x1011667c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011667f, 0x5)   calld(sys_delete, 0x4f8e0);           /* call 0x10165f64 */
l_0x10116684:
    II(0x10116684, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10116687, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1011668a, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1011668d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011668f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10116690, 0x1)   popd(edi);                            /* pop edi */
    II(0x10116691, 0x1)   popd(esi);                            /* pop esi */
    II(0x10116692, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10116693, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10116694, 0x1)   retd();                               /* ret */
FUNC_END

