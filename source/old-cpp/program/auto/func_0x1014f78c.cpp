FUNC_BEGIN(0x1014f78c, 0xd030b1b6d8df90b0, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xbc, 0x65, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x50, 0x6, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x26, 0x25, 0xff, 0, 0, 0, 0x69, 0xd8, 0x47, 0x2, 0, 0, 0xb8, 0x68, 0xa4, 0x1c, 0x10, 0x1, 0xd8, 0xe8, 0x5f, 0x5, 0xf9, 0xff, 0x89, 0xc2, 0x8d, 0x45, 0xf4, 0xe8, 0x29, 0x70, 0xf2, 0xff, 0x8d, 0x55, 0xf8, 0x8b, 0x45, 0xfc, 0xe8, 0x18, 0xf6, 0xff, 0xff, 0x8d, 0x45, 0xf4, 0xe8, 0x46, 0x6f, 0xf2, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x6c, 0xe8, 0x39, 0x6f, 0xf2, 0xff, 0x8a, 0x52, 0xa, 0x2a, 0x50, 0xa, 0x88, 0xd0, 0x8b, 0x55, 0xfc, 0, 0x42, 0x4d, 0x8b, 0x45, 0xfc, 0xe8, 0xbc, 0x1d, 0x1, 0, 0x8d, 0x55, 0xf4, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x6c, 0xe8, 0x65, 0x5a, 0, 0, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x6c, 0xe8, 0x5, 0x6f, 0xf2, 0xff, 0xe8, 0x84, 0xbf, 0xf7, 0xff, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0xfb, 0x1f, 0xf2, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xf8, 0xe8, 0x89, 0x6d, 0xf2, 0xff, 0xe8, 0xec, 0x1f, 0xf2, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xf8, 0xe8, 0xd6, 0x66, 0xf2, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xf4, 0xe8, 0x8c, 0x66, 0xf2, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1014f78c, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1014f791, 0x5)   calld(sys_check_available_stack_size, 0x165bc); /* call 0x10165d52 */
    II(0x1014f796, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1014f797, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1014f798, 0x1)   pushd(edx);                           /* push edx */
    II(0x1014f799, 0x1)   pushd(esi);                           /* push esi */
    II(0x1014f79a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1014f79b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1014f79c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1014f79e, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1014f7a4, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1014f7a7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014f7aa, 0x3)   mov(edx, memd_a32(ds, eax + 0x6));    /* mov edx, [eax+0x6] */
    II(0x1014f7ad, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x1014f7b0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014f7b3, 0x3)   mov(al, memb_a32(ds, eax + 0x26));    /* mov al, [eax+0x26] */
    II(0x1014f7b6, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x1014f7bb, 0x6)   imul(ebx, eax, 0x247);                /* imul ebx, eax, 0x247 */
    II(0x1014f7c1, 0x5)   mov(eax, 0x101ca468);                 /* mov eax, 0x101ca468 */
    II(0x1014f7c6, 0x2)   add(eax, ebx);                        /* add eax, ebx */
    II(0x1014f7c8, 0x5)   calld(0x100dfd2c, -0x6faa1);          /* call 0x100dfd2c */
    II(0x1014f7cd, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1014f7cf, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x1014f7d2, 0x5)   calld(0x10076800, -0xd8fd7);          /* call 0x10076800 */
    II(0x1014f7d7, 0x3)   lea(edx, ebp - 0x8);                  /* lea edx, [ebp-0x8] */
    II(0x1014f7da, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014f7dd, 0x5)   calld(0x1014edfa, -0x9e8);            /* call 0x1014edfa */
    II(0x1014f7e2, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x1014f7e5, 0x5)   calld(0x10076730, -0xd90ba);          /* call 0x10076730 */
    II(0x1014f7ea, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1014f7ec, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014f7ef, 0x3)   add(eax, 0x6c);                       /* add eax, 0x6c */
    II(0x1014f7f2, 0x5)   calld(0x10076730, -0xd90c7);          /* call 0x10076730 */
    II(0x1014f7f7, 0x3)   mov(dl, memb_a32(ds, edx + 0xa));     /* mov dl, [edx+0xa] */
    II(0x1014f7fa, 0x3)   sub(dl, memb_a32(ds, eax + 0xa));     /* sub dl, [eax+0xa] */
    II(0x1014f7fd, 0x2)   mov(al, dl);                          /* mov al, dl */
    II(0x1014f7ff, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1014f802, 0x3)   add(memb_a32(ds, edx + 0x4d), al);    /* add [edx+0x4d], al */
    II(0x1014f805, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014f808, 0x5)   calld(0x101615c9, 0x11dbc);           /* call 0x101615c9 */
    II(0x1014f80d, 0x3)   lea(edx, ebp - 0xc);                  /* lea edx, [ebp-0xc] */
    II(0x1014f810, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014f813, 0x3)   add(eax, 0x6c);                       /* add eax, 0x6c */
    II(0x1014f816, 0x5)   calld(0x10155280, 0x5a65);            /* call 0x10155280 */
    II(0x1014f81b, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x1014f820, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014f823, 0x3)   add(eax, 0x6c);                       /* add eax, 0x6c */
    II(0x1014f826, 0x5)   calld(0x10076730, -0xd90fb);          /* call 0x10076730 */
    II(0x1014f82b, 0x5)   calld(0x100cb7b4, -0x8407c);          /* call 0x100cb7b4 */
    II(0x1014f830, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x1014f835, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014f838, 0x5)   calld(0x10071838, -0xde005);          /* call 0x10071838 */
    II(0x1014f83d, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1014f83f, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x1014f842, 0x5)   calld(0x100765d0, -0xd9277);          /* call 0x100765d0 */
    II(0x1014f847, 0x5)   calld(0x10071838, -0xde014);          /* call 0x10071838 */
    II(0x1014f84c, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1014f84e, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x1014f851, 0x5)   calld(0x10075f2c, -0xd992a);          /* call 0x10075f2c */
    II(0x1014f856, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1014f858, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x1014f85b, 0x5)   calld(0x10075eec, -0xd9974);          /* call 0x10075eec */
    II(0x1014f860, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1014f862, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1014f863, 0x1)   popd(edi);                            /* pop edi */
    II(0x1014f864, 0x1)   popd(esi);                            /* pop esi */
    II(0x1014f865, 0x1)   popd(edx);                            /* pop edx */
    II(0x1014f866, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1014f867, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1014f868, 0x1)   retd();                               /* ret */
FUNC_END

