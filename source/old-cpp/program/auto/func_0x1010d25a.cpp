FUNC_BEGIN(0x1010d25a, 0xe446df9c252fa30d, 0x20, ({0x68, 0x34, 0, 0, 0, 0xe8, 0xee, 0x8a, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x18, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0x78, 0x18, 0, 0x74, 0x44, 0x8b, 0x45, 0xfc, 0x8b, 0x10, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x18, 0xe8, 0xde, 0xac, 0xfc, 0xff, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x18, 0x89, 0x45, 0xf0, 0x83, 0x7d, 0xf0, 0, 0x74, 0x14, 0x31, 0xd2, 0x8b, 0x45, 0xf0, 0xe8, 0x8c, 0xaa, 0xfc, 0xff, 0xe8, 0xb8, 0x8c, 0x5, 0, 0x89, 0x45, 0xec, 0xeb, 0x7, 0xc7, 0x45, 0xec, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xc7, 0x40, 0x18, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0xc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xfc, 0x83, 0x78, 0x10, 0x7, 0x75, 0x6, 0xc6, 0x45, 0xe8, 0x1, 0xeb, 0x4, 0xc6, 0x45, 0xe8, 0, 0x8a, 0x45, 0xe8, 0x88, 0x45, 0xf8, 0x80, 0x7d, 0xf8, 0, 0x74, 0x24, 0x8b, 0x55, 0xfc, 0x8b, 0x52, 0xa, 0xc1, 0xfa, 0x10, 0xbb, 0x6, 0, 0, 0, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0xf7, 0xfb, 0x6b, 0xc0, 0x6, 0x8d, 0x50, 0x6, 0x8b, 0x45, 0xfc, 0x66, 0x89, 0x50, 0xc, 0xeb, 0x22, 0x8b, 0x55, 0xfc, 0x8b, 0x52, 0xa, 0xc1, 0xfa, 0x10, 0xbb, 0x6, 0, 0, 0, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0xf7, 0xfb, 0x6b, 0xc0, 0x6, 0x8d, 0x50, 0xfa, 0x8b, 0x45, 0xfc, 0x66, 0x89, 0x50, 0xc, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0xa, 0xc1, 0xf8, 0x10, 0x85, 0xc0, 0x7d, 0x9, 0x8b, 0x45, 0xfc, 0x66, 0xc7, 0x40, 0xc, 0x12, 0, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0xa, 0xc1, 0xf8, 0x10, 0x83, 0xf8, 0x17, 0x7e, 0x9, 0x8b, 0x45, 0xfc, 0x66, 0xc7, 0x40, 0xc, 0, 0, 0xe8, 0xd1, 0xea, 0x5, 0, 0x31, 0xc9, 0x8a, 0x4d, 0xf8, 0x8b, 0x45, 0xfc, 0x8b, 0x58, 0xa, 0xc1, 0xfb, 0x10, 0xf, 0xbf, 0x55, 0xf4, 0x8b, 0x45, 0xfc, 0xe8, 0x55, 0xfc, 0xff, 0xff, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0x2, 0xf7, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0xe8, 0x13, 0xf9, 0xff, 0xff, 0xe8, 0x2d, 0xe9, 0x5, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1010d25a, 0x5)   pushd(0x34);                          /* push dword 0x34 */
    II(0x1010d25f, 0x5)   calld(sys_check_available_stack_size, 0x58aee); /* call 0x10165d52 */
    II(0x1010d264, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1010d265, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1010d266, 0x1)   pushd(edx);                           /* push edx */
    II(0x1010d267, 0x1)   pushd(esi);                           /* push esi */
    II(0x1010d268, 0x1)   pushd(edi);                           /* push edi */
    II(0x1010d269, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1010d26a, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1010d26c, 0x6)   sub(esp, 0x18);                       /* sub esp, 0x18 */
    II(0x1010d272, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1010d275, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010d278, 0x4)   cmp(memd_a32(ds, eax + 0x18), 0);     /* cmp dword [eax+0x18], 0x0 */
    II(0x1010d27c, 0x2)   jzd(0x1010d2c2, 0x44);                /* jz 0x1010d2c2 */
    II(0x1010d27e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010d281, 0x2)   mov(edx, memd_a32(ds, eax));          /* mov edx, [eax] */
//    II(0x1010d283, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010d286, 0x3)   mov(eax, memd_a32(ds, eax + 0x18));   /* mov eax, [eax+0x18] */
    II(0x1010d289, 0x5)   calld(0x100d7f6c, -0x35322);          /* call 0x100d7f6c */
    II(0x1010d28e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010d291, 0x3)   mov(eax, memd_a32(ds, eax + 0x18));   /* mov eax, [eax+0x18] */
    II(0x1010d294, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x1010d297, 0x4)   cmp(memd_a32(ss, ebp - 0x10), 0);     /* cmp dword [ebp-0x10], 0x0 */
    II(0x1010d29b, 0x2)   jzd(0x1010d2b1, 0x14);                /* jz 0x1010d2b1 */
    II(0x1010d29d, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1010d29f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x1010d2a2, 0x5)   calld(my_dtor_d3, -0x35574);          /* call 0x100d7d33 */
    II(0x1010d2a7, 0x5)   calld(sys_delete, 0x58cb8);           /* call 0x10165f64 */
    II(0x1010d2ac, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x1010d2af, 0x2)   jmpd(0x1010d2b8, 0x7);                /* jmp 0x1010d2b8 */
l_0x1010d2b1:
    II(0x1010d2b1, 0x7)   mov(memd_a32(ss, ebp - 0x14), 0);     /* mov dword [ebp-0x14], 0x0 */
l_0x1010d2b8:
    II(0x1010d2b8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010d2bb, 0x7)   mov(memd_a32(ds, eax + 0x18), 0);     /* mov dword [eax+0x18], 0x0 */
l_0x1010d2c2:
    II(0x1010d2c2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010d2c5, 0x4)   mov(ax, memw_a32(ds, eax + 0xc));     /* mov ax, [eax+0xc] */
    II(0x1010d2c9, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x1010d2cc, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010d2cf, 0x4)   cmp(memd_a32(ds, eax + 0x10), 0x7);   /* cmp dword [eax+0x10], 0x7 */
    II(0x1010d2d3, 0x2)   jnzd(0x1010d2db, 0x6);                /* jnz 0x1010d2db */
    II(0x1010d2d5, 0x4)   mov(memb_a32(ss, ebp - 0x18), 0x1);   /* mov byte [ebp-0x18], 0x1 */
    II(0x1010d2d9, 0x2)   jmpd(0x1010d2df, 0x4);                /* jmp 0x1010d2df */
l_0x1010d2db:
    II(0x1010d2db, 0x4)   mov(memb_a32(ss, ebp - 0x18), 0);     /* mov byte [ebp-0x18], 0x0 */
l_0x1010d2df:
    II(0x1010d2df, 0x3)   mov(al, memb_a32(ss, ebp - 0x18));    /* mov al, [ebp-0x18] */
    II(0x1010d2e2, 0x3)   mov(memb_a32(ss, ebp - 0x8), al);     /* mov [ebp-0x8], al */
    II(0x1010d2e5, 0x4)   cmp(memb_a32(ss, ebp - 0x8), 0);      /* cmp byte [ebp-0x8], 0x0 */
    II(0x1010d2e9, 0x2)   jzd(0x1010d30f, 0x24);                /* jz 0x1010d30f */
    II(0x1010d2eb, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1010d2ee, 0x3)   mov(edx, memd_a32(ds, edx + 0xa));    /* mov edx, [edx+0xa] */
    II(0x1010d2f1, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x1010d2f4, 0x5)   mov(ebx, 0x6);                        /* mov ebx, 0x6 */
    II(0x1010d2f9, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x1010d2fb, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x1010d2fe, 0x2)   idiv(ebx);                            /* idiv ebx */
    II(0x1010d300, 0x3)   imul(eax, eax, 0x6);                  /* imul eax, eax, 0x6 */
    II(0x1010d303, 0x3)   lea(edx, eax + 0x6);                  /* lea edx, [eax+0x6] */
    II(0x1010d306, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010d309, 0x4)   mov(memw_a32(ds, eax + 0xc), dx);     /* mov [eax+0xc], dx */
    II(0x1010d30d, 0x2)   jmpd(0x1010d331, 0x22);               /* jmp 0x1010d331 */
l_0x1010d30f:
    II(0x1010d30f, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1010d312, 0x3)   mov(edx, memd_a32(ds, edx + 0xa));    /* mov edx, [edx+0xa] */
    II(0x1010d315, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x1010d318, 0x5)   mov(ebx, 0x6);                        /* mov ebx, 0x6 */
    II(0x1010d31d, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x1010d31f, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x1010d322, 0x2)   idiv(ebx);                            /* idiv ebx */
    II(0x1010d324, 0x3)   imul(eax, eax, 0x6);                  /* imul eax, eax, 0x6 */
    II(0x1010d327, 0x3)   lea(edx, eax - 0x6);                  /* lea edx, [eax-0x6] */
    II(0x1010d32a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010d32d, 0x4)   mov(memw_a32(ds, eax + 0xc), dx);     /* mov [eax+0xc], dx */
l_0x1010d331:
    II(0x1010d331, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010d334, 0x3)   mov(eax, memd_a32(ds, eax + 0xa));    /* mov eax, [eax+0xa] */
    II(0x1010d337, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1010d33a, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1010d33c, 0x2)   jged(0x1010d347, 0x9);                /* jge 0x1010d347 */
    II(0x1010d33e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010d341, 0x6)   mov(memw_a32(ds, eax + 0xc), 0x12);   /* mov word [eax+0xc], 0x12 */
l_0x1010d347:
    II(0x1010d347, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010d34a, 0x3)   mov(eax, memd_a32(ds, eax + 0xa));    /* mov eax, [eax+0xa] */
    II(0x1010d34d, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1010d350, 0x3)   cmp(eax, 0x17);                       /* cmp eax, 0x17 */
    II(0x1010d353, 0x2)   jled(0x1010d35e, 0x9);                /* jle 0x1010d35e */
    II(0x1010d355, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010d358, 0x6)   mov(memw_a32(ds, eax + 0xc), 0);      /* mov word [eax+0xc], 0x0 */
l_0x1010d35e:
    II(0x1010d35e, 0x5)   calld(/* sys */ 0x1016be34, 0x5ead1); /* call 0x1016be34 */
    II(0x1010d363, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x1010d365, 0x3)   mov(cl, memb_a32(ss, ebp - 0x8));     /* mov cl, [ebp-0x8] */
    II(0x1010d368, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010d36b, 0x3)   mov(ebx, memd_a32(ds, eax + 0xa));    /* mov ebx, [eax+0xa] */
    II(0x1010d36e, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x1010d371, 0x4)   movsx(edx, memw_a32(ss, ebp - 0xc));  /* movsx edx, word [ebp-0xc] */
    II(0x1010d375, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010d378, 0x5)   calld(0x1010cfd2, -0x3ab);            /* call 0x1010cfd2 */
    II(0x1010d37d, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x1010d382, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010d385, 0x5)   calld(0x1010ca8c, -0x8fe);            /* call 0x1010ca8c */
    II(0x1010d38a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010d38d, 0x5)   calld(0x1010cca5, -0x6ed);            /* call 0x1010cca5 */
    II(0x1010d392, 0x5)   calld(/* sys */ 0x1016bcc4, 0x5e92d); /* call 0x1016bcc4 */
    II(0x1010d397, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1010d399, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1010d39a, 0x1)   popd(edi);                            /* pop edi */
    II(0x1010d39b, 0x1)   popd(esi);                            /* pop esi */
    II(0x1010d39c, 0x1)   popd(edx);                            /* pop edx */
    II(0x1010d39d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1010d39e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1010d39f, 0x1)   retd();                               /* ret */
FUNC_END

