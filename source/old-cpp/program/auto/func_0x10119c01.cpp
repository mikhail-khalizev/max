FUNC_BEGIN(0x10119c01, 0x114775e1ec8a7f49, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x47, 0xc1, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x5d, 0xf8, 0x83, 0xc3, 0x16, 0xba, 0xba, 0x7c, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xfd, 0xbf, 0x2, 0, 0xba, 0xc1, 0x7c, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x6c, 0xc4, 0x2, 0, 0x89, 0xc2, 0x8b, 0x45, 0xf8, 0x88, 0x50, 0x18, 0x8b, 0x5d, 0xf8, 0x83, 0xc3, 0x19, 0xba, 0xc7, 0x7c, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xd5, 0xbf, 0x2, 0, 0x8b, 0x5d, 0xf8, 0x83, 0xc3, 0x1b, 0xba, 0xd5, 0x7c, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xc2, 0xbf, 0x2, 0, 0x8b, 0x5d, 0xf8, 0x83, 0xc3, 0x8, 0xba, 0xe3, 0x7c, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xaf, 0xbf, 0x2, 0, 0x8b, 0x5d, 0xf8, 0x83, 0xc3, 0xa, 0xba, 0xe9, 0x7c, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x9c, 0xbf, 0x2, 0, 0x8b, 0x5d, 0xf8, 0x83, 0xc3, 0x1d, 0xba, 0xef, 0x7c, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x17, 0xc0, 0x2, 0, 0x8b, 0x5d, 0xf8, 0x83, 0xc3, 0x21, 0xba, 0xf6, 0x7c, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x4, 0xc0, 0x2, 0, 0x8b, 0x5d, 0xf8, 0x83, 0xc3, 0x25, 0xba, 0xfd, 0x7c, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xf1, 0xbf, 0x2, 0, 0x8b, 0x5d, 0xf8, 0x83, 0xc3, 0x29, 0xba, 0x5, 0x7d, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xde, 0xbf, 0x2, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10119c01, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10119c06, 0x5)   calld(sys_check_available_stack_size, 0x4c147); /* call 0x10165d52 */
    II(0x10119c0b, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10119c0c, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10119c0d, 0x1)   pushd(esi);                           /* push esi */
    II(0x10119c0e, 0x1)   pushd(edi);                           /* push edi */
    II(0x10119c0f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10119c10, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10119c12, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10119c18, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10119c1b, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10119c1e, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10119c21, 0x3)   add(ebx, 0x16);                       /* add ebx, 0x16 */
    II(0x10119c24, 0x5)   mov(edx, 0x101a7cba);                 /* mov edx, 0x101a7cba */ /* "length" */
    II(0x10119c29, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119c2c, 0x5)   calld(0x10145c2e, 0x2bffd);           /* call 0x10145c2e */
    II(0x10119c31, 0x5)   mov(edx, 0x101a7cc1);                 /* mov edx, 0x101a7cc1 */ /* "angle" */
    II(0x10119c36, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119c39, 0x5)   calld(0x101460aa, 0x2c46c);           /* call 0x101460aa */
    II(0x10119c3e, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10119c40, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10119c43, 0x3)   mov(memb_a32(ds, eax + 0x18), dl);    /* mov [eax+0x18], dl */
    II(0x10119c46, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10119c49, 0x3)   add(ebx, 0x19);                       /* add ebx, 0x19 */
    II(0x10119c4c, 0x5)   mov(edx, 0x101a7cc7);                 /* mov edx, 0x101a7cc7 */ /* "pixel_x_start" */
    II(0x10119c51, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119c54, 0x5)   calld(0x10145c2e, 0x2bfd5);           /* call 0x10145c2e */
    II(0x10119c59, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10119c5c, 0x3)   add(ebx, 0x1b);                       /* add ebx, 0x1b */
    II(0x10119c5f, 0x5)   mov(edx, 0x101a7cd5);                 /* mov edx, 0x101a7cd5 */ /* "pixel_y_start" */
    II(0x10119c64, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119c67, 0x5)   calld(0x10145c2e, 0x2bfc2);           /* call 0x10145c2e */
    II(0x10119c6c, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10119c6f, 0x3)   add(ebx, 0x8);                        /* add ebx, 0x8 */
    II(0x10119c72, 0x5)   mov(edx, 0x101a7ce3);                 /* mov edx, 0x101a7ce3 */ /* "x_end" */
    II(0x10119c77, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119c7a, 0x5)   calld(0x10145c2e, 0x2bfaf);           /* call 0x10145c2e */
    II(0x10119c7f, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10119c82, 0x3)   add(ebx, 0xa);                        /* add ebx, 0xa */
    II(0x10119c85, 0x5)   mov(edx, 0x101a7ce9);                 /* mov edx, 0x101a7ce9 */ /* "y_end" */
    II(0x10119c8a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119c8d, 0x5)   calld(0x10145c2e, 0x2bf9c);           /* call 0x10145c2e */
    II(0x10119c92, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10119c95, 0x3)   add(ebx, 0x1d);                       /* add ebx, 0x1d */
    II(0x10119c98, 0x5)   mov(edx, 0x101a7cef);                 /* mov edx, 0x101a7cef */ /* "x_step" */
    II(0x10119c9d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119ca0, 0x5)   calld(0x10145cbc, 0x2c017);           /* call 0x10145cbc */
    II(0x10119ca5, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10119ca8, 0x3)   add(ebx, 0x21);                       /* add ebx, 0x21 */
    II(0x10119cab, 0x5)   mov(edx, 0x101a7cf6);                 /* mov edx, 0x101a7cf6 */ /* "y_step" */
    II(0x10119cb0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119cb3, 0x5)   calld(0x10145cbc, 0x2c004);           /* call 0x10145cbc */
    II(0x10119cb8, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10119cbb, 0x3)   add(ebx, 0x25);                       /* add ebx, 0x25 */
    II(0x10119cbe, 0x5)   mov(edx, 0x101a7cfd);                 /* mov edx, 0x101a7cfd */ /* "delta_x" */
    II(0x10119cc3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119cc6, 0x5)   calld(0x10145cbc, 0x2bff1);           /* call 0x10145cbc */
    II(0x10119ccb, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10119cce, 0x3)   add(ebx, 0x29);                       /* add ebx, 0x29 */
    II(0x10119cd1, 0x5)   mov(edx, 0x101a7d05);                 /* mov edx, 0x101a7d05 */ /* "delta_y" */
    II(0x10119cd6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119cd9, 0x5)   calld(0x10145cbc, 0x2bfde);           /* call 0x10145cbc */
    II(0x10119cde, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10119ce0, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10119ce1, 0x1)   popd(edi);                            /* pop edi */
    II(0x10119ce2, 0x1)   popd(esi);                            /* pop esi */
    II(0x10119ce3, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10119ce4, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10119ce5, 0x1)   retd();                               /* ret */
FUNC_END

