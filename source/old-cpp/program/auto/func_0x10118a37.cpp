FUNC_BEGIN(0x10118a37, 0xea6e20fd8428890b, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x11, 0xd3, 0x4, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x14, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x58, 0x1a, 0xc1, 0xfb, 0x10, 0x8b, 0x45, 0xfc, 0x8b, 0x50, 0x18, 0xc1, 0xfa, 0x10, 0x8d, 0x45, 0xec, 0xe8, 0x3c, 0xe0, 0xf5, 0xff, 0x8b, 0x45, 0xfc, 0xf6, 0x40, 0x12, 0x40, 0x74, 0x6a, 0x8b, 0x45, 0xf4, 0x8b, 0x50, 0x14, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xf4, 0xf, 0xaf, 0x50, 0x25, 0x8b, 0x45, 0xf4, 0x8b, 0x40, 0x1d, 0x1, 0xd0, 0x89, 0x45, 0xf0, 0xc1, 0x7d, 0xf0, 0x10, 0x8b, 0x45, 0xf4, 0x8b, 0x40, 0x17, 0xc1, 0xf8, 0x10, 0x1, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0xc1, 0xf8, 0x6, 0x66, 0x89, 0x45, 0xec, 0x8b, 0x45, 0xf4, 0x8b, 0x50, 0x14, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xf4, 0xf, 0xaf, 0x50, 0x29, 0x8b, 0x45, 0xf4, 0x8b, 0x40, 0x21, 0x1, 0xd0, 0x89, 0x45, 0xf0, 0xc1, 0x7d, 0xf0, 0x10, 0x8b, 0x45, 0xf4, 0x8b, 0x40, 0x19, 0xc1, 0xf8, 0x10, 0x1, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0xc1, 0xf8, 0x6, 0x66, 0x89, 0x45, 0xee, 0x8d, 0x55, 0xec, 0x8b, 0x45, 0xf8, 0xe8, 0x76, 0xd3, 0xf5, 0xff, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x10118a37, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x10118a3c, 0x5)   calld(sys_check_available_stack_size, 0x4d311); /* call 0x10165d52 */
    II(0x10118a41, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10118a42, 0x1)   pushd(esi);                           /* push esi */
    II(0x10118a43, 0x1)   pushd(edi);                           /* push edi */
    II(0x10118a44, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10118a45, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10118a47, 0x6)   sub(esp, 0x14);                       /* sub esp, 0x14 */
    II(0x10118a4d, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10118a50, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x10118a53, 0x3)   mov(memd_a32(ss, ebp - 0x4), ebx);    /* mov [ebp-0x4], ebx */
    II(0x10118a56, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10118a59, 0x3)   mov(ebx, memd_a32(ds, eax + 0x1a));   /* mov ebx, [eax+0x1a] */
    II(0x10118a5c, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x10118a5f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10118a62, 0x3)   mov(edx, memd_a32(ds, eax + 0x18));   /* mov edx, [eax+0x18] */
    II(0x10118a65, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x10118a68, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10118a6b, 0x5)   calld(0x10076aac, -0xa1fc4);          /* call 0x10076aac */
    II(0x10118a70, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10118a73, 0x4)   test(memb_a32(ds, eax + 0x12), 0x40); /* test byte [eax+0x12], 0x40 */
    II(0x10118a77, 0x2)   jzd(0x10118ae3, 0x6a);                /* jz 0x10118ae3 */
    II(0x10118a79, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10118a7c, 0x3)   mov(edx, memd_a32(ds, eax + 0x14));   /* mov edx, [eax+0x14] */
    II(0x10118a7f, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x10118a82, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10118a85, 0x4)   imul(edx, memd_a32(ds, eax + 0x25));  /* imul edx, [eax+0x25] */
    II(0x10118a89, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10118a8c, 0x3)   mov(eax, memd_a32(ds, eax + 0x1d));   /* mov eax, [eax+0x1d] */
    II(0x10118a8f, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x10118a91, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x10118a94, 0x4)   sar(memd_a32(ss, ebp - 0x10), 0x10);  /* sar dword [ebp-0x10], 0x10 */
    II(0x10118a98, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10118a9b, 0x3)   mov(eax, memd_a32(ds, eax + 0x17));   /* mov eax, [eax+0x17] */
    II(0x10118a9e, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x10118aa1, 0x3)   add(memd_a32(ss, ebp - 0x10), eax);   /* add [ebp-0x10], eax */
    II(0x10118aa4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10118aa7, 0x3)   sar(eax, 0x6);                        /* sar eax, 0x6 */
    II(0x10118aaa, 0x4)   mov(memw_a32(ss, ebp - 0x14), ax);    /* mov [ebp-0x14], ax */
    II(0x10118aae, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10118ab1, 0x3)   mov(edx, memd_a32(ds, eax + 0x14));   /* mov edx, [eax+0x14] */
    II(0x10118ab4, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x10118ab7, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10118aba, 0x4)   imul(edx, memd_a32(ds, eax + 0x29));  /* imul edx, [eax+0x29] */
    II(0x10118abe, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10118ac1, 0x3)   mov(eax, memd_a32(ds, eax + 0x21));   /* mov eax, [eax+0x21] */
    II(0x10118ac4, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x10118ac6, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x10118ac9, 0x4)   sar(memd_a32(ss, ebp - 0x10), 0x10);  /* sar dword [ebp-0x10], 0x10 */
    II(0x10118acd, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10118ad0, 0x3)   mov(eax, memd_a32(ds, eax + 0x19));   /* mov eax, [eax+0x19] */
    II(0x10118ad3, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x10118ad6, 0x3)   add(memd_a32(ss, ebp - 0x10), eax);   /* add [ebp-0x10], eax */
    II(0x10118ad9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10118adc, 0x3)   sar(eax, 0x6);                        /* sar eax, 0x6 */
    II(0x10118adf, 0x4)   mov(memw_a32(ss, ebp - 0x12), ax);    /* mov [ebp-0x12], ax */
l_0x10118ae3:
    II(0x10118ae3, 0x3)   lea(edx, ebp - 0x14);                 /* lea edx, [ebp-0x14] */
    II(0x10118ae6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10118ae9, 0x5)   calld(0x10075e64, -0xa2c8a);          /* call 0x10075e64 */
    II(0x10118aee, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10118af1, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10118af3, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10118af4, 0x1)   popd(edi);                            /* pop edi */
    II(0x10118af5, 0x1)   popd(esi);                            /* pop esi */
    II(0x10118af6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10118af7, 0x1)   retd();                               /* ret */
FUNC_END

