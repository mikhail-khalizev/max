FUNC_BEGIN(0x1010f2cf, 0xd19f253fa121563b, 0x20, ({0x68, 0x34, 0, 0, 0, 0xe8, 0x79, 0x6a, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x18, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0x78, 0x15, 0, 0x74, 0x2a, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x15, 0x89, 0x45, 0xf4, 0x83, 0x7d, 0xf4, 0, 0x74, 0x14, 0x31, 0xd2, 0x8b, 0x45, 0xf4, 0xe8, 0xcb, 0xbd, 0xfd, 0xff, 0xe8, 0x53, 0x6c, 0x5, 0, 0x89, 0x45, 0xf0, 0xeb, 0x7, 0xc7, 0x45, 0xf0, 0, 0, 0, 0, 0xc7, 0x45, 0xf8, 0xd, 0, 0, 0, 0xff, 0x4d, 0xf8, 0x66, 0x83, 0x7d, 0xf8, 0xff, 0x74, 0x43, 0xf, 0xbf, 0x45, 0xf8, 0xc1, 0xe0, 0x2, 0x3, 0x45, 0xfc, 0x83, 0x78, 0x19, 0, 0x74, 0x31, 0xf, 0xbf, 0x45, 0xf8, 0xc1, 0xe0, 0x2, 0x3, 0x45, 0xfc, 0x8b, 0x40, 0x19, 0x89, 0x45, 0xec, 0x83, 0x7d, 0xec, 0, 0x74, 0x14, 0x31, 0xd2, 0x8b, 0x45, 0xec, 0xe8, 0xda, 0xf1, 0xfb, 0xff, 0xe8, 0x1, 0x6c, 0x5, 0, 0x89, 0x45, 0xe8, 0xeb, 0x7, 0xc7, 0x45, 0xe8, 0, 0, 0, 0, 0xeb, 0xb3, 0x8b, 0x45, 0xfc, 0xe8, 0xc4, 0xfe, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1010f2cf, 0x5)   pushd(0x34);                          /* push dword 0x34 */
    II(0x1010f2d4, 0x5)   calld(sys_check_available_stack_size, 0x56a79); /* call 0x10165d52 */
    II(0x1010f2d9, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1010f2da, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1010f2db, 0x1)   pushd(edx);                           /* push edx */
    II(0x1010f2dc, 0x1)   pushd(esi);                           /* push esi */
    II(0x1010f2dd, 0x1)   pushd(edi);                           /* push edi */
    II(0x1010f2de, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1010f2df, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1010f2e1, 0x6)   sub(esp, 0x18);                       /* sub esp, 0x18 */
    II(0x1010f2e7, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1010f2ea, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010f2ed, 0x4)   cmp(memd_a32(ds, eax + 0x15), 0);     /* cmp dword [eax+0x15], 0x0 */
    II(0x1010f2f1, 0x2)   jzd(0x1010f31d, 0x2a);                /* jz 0x1010f31d */
    II(0x1010f2f3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010f2f6, 0x3)   mov(eax, memd_a32(ds, eax + 0x15));   /* mov eax, [eax+0x15] */
    II(0x1010f2f9, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x1010f2fc, 0x4)   cmp(memd_a32(ss, ebp - 0xc), 0);      /* cmp dword [ebp-0xc], 0x0 */
    II(0x1010f300, 0x2)   jzd(0x1010f316, 0x14);                /* jz 0x1010f316 */
    II(0x1010f302, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1010f304, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1010f307, 0x5)   calld(my_dtor_d6, -0x24235);          /* call 0x100eb0d7 */
    II(0x1010f30c, 0x5)   calld(sys_delete, 0x56c53);           /* call 0x10165f64 */
    II(0x1010f311, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x1010f314, 0x2)   jmpd(0x1010f31d, 0x7);                /* jmp 0x1010f31d */
l_0x1010f316:
    II(0x1010f316, 0x7)   mov(memd_a32(ss, ebp - 0x10), 0);     /* mov dword [ebp-0x10], 0x0 */
l_0x1010f31d:
    II(0x1010f31d, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0xd);    /* mov dword [ebp-0x8], 0xd */
l_0x1010f324:
    II(0x1010f324, 0x3)   dec(memd_a32(ss, ebp - 0x8));         /* dec dword [ebp-0x8] */
    II(0x1010f327, 0x5)   cmp(memw_a32(ss, ebp - 0x8), -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xff */
    II(0x1010f32c, 0x2)   jzd(0x1010f371, 0x43);                /* jz 0x1010f371 */
    II(0x1010f32e, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x1010f332, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
    II(0x1010f335, 0x3)   add(eax, memd_a32(ss, ebp - 0x4));    /* add eax, [ebp-0x4] */
    II(0x1010f338, 0x4)   cmp(memd_a32(ds, eax + 0x19), 0);     /* cmp dword [eax+0x19], 0x0 */
    II(0x1010f33c, 0x2)   jzd(0x1010f36f, 0x31);                /* jz 0x1010f36f */
    II(0x1010f33e, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x1010f342, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
    II(0x1010f345, 0x3)   add(eax, memd_a32(ss, ebp - 0x4));    /* add eax, [ebp-0x4] */
    II(0x1010f348, 0x3)   mov(eax, memd_a32(ds, eax + 0x19));   /* mov eax, [eax+0x19] */
    II(0x1010f34b, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x1010f34e, 0x4)   cmp(memd_a32(ss, ebp - 0x14), 0);     /* cmp dword [ebp-0x14], 0x0 */
    II(0x1010f352, 0x2)   jzd(0x1010f368, 0x14);                /* jz 0x1010f368 */
    II(0x1010f354, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1010f356, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x1010f359, 0x5)   calld(my_dtor_d2, -0x40e26);          /* call 0x100ce538 */
    II(0x1010f35e, 0x5)   calld(sys_delete, 0x56c01);           /* call 0x10165f64 */
    II(0x1010f363, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
    II(0x1010f366, 0x2)   jmpd(0x1010f36f, 0x7);                /* jmp 0x1010f36f */
l_0x1010f368:
    II(0x1010f368, 0x7)   mov(memd_a32(ss, ebp - 0x18), 0);     /* mov dword [ebp-0x18], 0x0 */
l_0x1010f36f:
    II(0x1010f36f, 0x2)   jmpd(0x1010f324, -0x4d);              /* jmp 0x1010f324 */
l_0x1010f371:
    II(0x1010f371, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010f374, 0x5)   calld(0x1010f23d, -0x13c);            /* call 0x1010f23d */
    II(0x1010f379, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1010f37b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1010f37c, 0x1)   popd(edi);                            /* pop edi */
    II(0x1010f37d, 0x1)   popd(esi);                            /* pop esi */
    II(0x1010f37e, 0x1)   popd(edx);                            /* pop edx */
    II(0x1010f37f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1010f380, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1010f381, 0x1)   retd();                               /* ret */
FUNC_END

