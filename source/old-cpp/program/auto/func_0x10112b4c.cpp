FUNC_BEGIN(0x10112b4c, 0x8dc79c971b96e1fd, 0x20, ({0x68, 0x2c, 0, 0, 0, 0xe8, 0xfc, 0x31, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x10, 0x8b, 0x45, 0xfc, 0x8b, 0x80, 0xa1, 0x5, 0, 0, 0xe8, 0xf2, 0x53, 0xfc, 0xff, 0xe8, 0x99, 0x27, 0, 0, 0x25, 0xff, 0, 0, 0, 0x50, 0xe8, 0xae, 0x27, 0, 0, 0x31, 0xc9, 0x88, 0xc1, 0xbb, 0xa2, 0, 0, 0, 0xba, 0x8c, 0x9d, 0x1b, 0x10, 0x8b, 0x45, 0xfc, 0x8b, 0, 0xe8, 0x63, 0x5e, 0xff, 0xff, 0xe8, 0x71, 0x27, 0, 0, 0x25, 0xff, 0, 0, 0, 0x50, 0xb9, 0x1, 0, 0, 0, 0xbb, 0xa2, 0, 0, 0, 0xba, 0xa0, 0x9d, 0x1b, 0x10, 0x8b, 0x45, 0xfc, 0x8b, 0, 0xe8, 0x3f, 0x5e, 0xff, 0xff, 0xbb, 0x1, 0, 0, 0, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0xe8, 0x88, 0xfc, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0x83, 0x78, 0x1a, 0, 0x74, 0x34, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x1a, 0x89, 0x45, 0xf8, 0x83, 0x7d, 0xf8, 0, 0x74, 0x14, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0xe8, 0x41, 0xb9, 0xfb, 0xff, 0xe8, 0x68, 0x33, 0x5, 0, 0x89, 0x45, 0xf4, 0xeb, 0x7, 0xc7, 0x45, 0xf4, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xc7, 0x40, 0x1a, 0, 0, 0, 0, 0xbb, 0x1, 0, 0, 0, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0x39, 0xfc, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0x80, 0xb8, 0x1f, 0x5, 0, 0, 0, 0x74, 0xd, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x1a, 0xe8, 0xc9, 0xce, 0xfb, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10112b4c, 0x5)   pushd(0x2c);                          /* push dword 0x2c */
    II(0x10112b51, 0x5)   calld(sys_check_available_stack_size, 0x531fc); /* call 0x10165d52 */
    II(0x10112b56, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10112b57, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10112b58, 0x1)   pushd(edx);                           /* push edx */
    II(0x10112b59, 0x1)   pushd(esi);                           /* push esi */
    II(0x10112b5a, 0x1)   pushd(edi);                           /* push edi */
    II(0x10112b5b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10112b5c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10112b5e, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10112b64, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10112b67, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10112b6a, 0x2)   mov(edx, memd_a32(ds, eax));          /* mov edx, [eax] */
//    II(0x10112b6c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10112b6f, 0x6)   mov(eax, memd_a32(ds, eax + 0x5a1));  /* mov eax, [eax+0x5a1] */
    II(0x10112b75, 0x5)   calld(0x100d7f6c, -0x3ac0e);          /* call 0x100d7f6c */
    II(0x10112b7a, 0x5)   calld(0x10115318, 0x2799);            /* call 0x10115318 */
    II(0x10112b7f, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x10112b84, 0x1)   pushd(eax);                           /* push eax */
    II(0x10112b85, 0x5)   calld(0x10115338, 0x27ae);            /* call 0x10115338 */
    II(0x10112b8a, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x10112b8c, 0x2)   mov(cl, al);                          /* mov cl, al */
    II(0x10112b8e, 0x5)   mov(ebx, 0xa2);                       /* mov ebx, 0xa2 */
    II(0x10112b93, 0x5)   mov(edx, 0x101b9d8c);                 /* mov edx, 0x101b9d8c */
    II(0x10112b98, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10112b9b, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10112b9d, 0x5)   calld(0x10108a05, -0xa19d);           /* call 0x10108a05 */
    II(0x10112ba2, 0x5)   calld(0x10115318, 0x2771);            /* call 0x10115318 */
    II(0x10112ba7, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x10112bac, 0x1)   pushd(eax);                           /* push eax */
    II(0x10112bad, 0x5)   mov(ecx, 0x1);                        /* mov ecx, 0x1 */
    II(0x10112bb2, 0x5)   mov(ebx, 0xa2);                       /* mov ebx, 0xa2 */
    II(0x10112bb7, 0x5)   mov(edx, 0x101b9da0);                 /* mov edx, 0x101b9da0 */
    II(0x10112bbc, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10112bbf, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10112bc1, 0x5)   calld(0x10108a05, -0xa1c1);           /* call 0x10108a05 */
    II(0x10112bc6, 0x5)   mov(ebx, 0x1);                        /* mov ebx, 0x1 */
    II(0x10112bcb, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10112bcd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10112bd0, 0x5)   calld(0x1011285d, -0x378);            /* call 0x1011285d */
    II(0x10112bd5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10112bd8, 0x4)   cmp(memd_a32(ds, eax + 0x1a), 0);     /* cmp dword [eax+0x1a], 0x0 */
    II(0x10112bdc, 0x2)   jzd(0x10112c12, 0x34);                /* jz 0x10112c12 */
    II(0x10112bde, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10112be1, 0x3)   mov(eax, memd_a32(ds, eax + 0x1a));   /* mov eax, [eax+0x1a] */
    II(0x10112be4, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10112be7, 0x4)   cmp(memd_a32(ss, ebp - 0x8), 0);      /* cmp dword [ebp-0x8], 0x0 */
    II(0x10112beb, 0x2)   jzd(0x10112c01, 0x14);                /* jz 0x10112c01 */
    II(0x10112bed, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10112bef, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10112bf2, 0x5)   calld(my_dtor_d2, -0x446bf);          /* call 0x100ce538 */
    II(0x10112bf7, 0x5)   calld(sys_delete, 0x53368);           /* call 0x10165f64 */
    II(0x10112bfc, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10112bff, 0x2)   jmpd(0x10112c08, 0x7);                /* jmp 0x10112c08 */
l_0x10112c01:
    II(0x10112c01, 0x7)   mov(memd_a32(ss, ebp - 0xc), 0);      /* mov dword [ebp-0xc], 0x0 */
l_0x10112c08:
    II(0x10112c08, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10112c0b, 0x7)   mov(memd_a32(ds, eax + 0x1a), 0);     /* mov dword [eax+0x1a], 0x0 */
l_0x10112c12:
    II(0x10112c12, 0x5)   mov(ebx, 0x1);                        /* mov ebx, 0x1 */
    II(0x10112c17, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x10112c1c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10112c1f, 0x5)   calld(0x1011285d, -0x3c7);            /* call 0x1011285d */
    II(0x10112c24, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10112c27, 0x7)   cmp(memb_a32(ds, eax + 0x51f), 0);    /* cmp byte [eax+0x51f], 0x0 */
    II(0x10112c2e, 0x2)   jzd(0x10112c3d, 0xd);                 /* jz 0x10112c3d */
    II(0x10112c30, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10112c32, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10112c35, 0x3)   mov(eax, memd_a32(ds, eax + 0x1a));   /* mov eax, [eax+0x1a] */
    II(0x10112c38, 0x5)   calld(0x100cfb06, -0x43137);          /* call 0x100cfb06 */
l_0x10112c3d:
    II(0x10112c3d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10112c3f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10112c40, 0x1)   popd(edi);                            /* pop edi */
    II(0x10112c41, 0x1)   popd(esi);                            /* pop esi */
    II(0x10112c42, 0x1)   popd(edx);                            /* pop edx */
    II(0x10112c43, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10112c44, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10112c45, 0x1)   retd();                               /* ret */
FUNC_END

