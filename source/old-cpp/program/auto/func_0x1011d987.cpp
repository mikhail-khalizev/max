FUNC_BEGIN(0x1011d987, 0xfc73b3e51a6e785f, 0x20, ({0x68, 0x48, 0, 0, 0, 0xe8, 0xc1, 0x83, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x1c, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xb8, 0x1, 0, 0, 0, 0x50, 0xa1, 0x72, 0x81, 0x1c, 0x10, 0xc1, 0xf8, 0x10, 0x50, 0x8b, 0xd, 0x70, 0x81, 0x1c, 0x10, 0xc1, 0xf9, 0x10, 0x31, 0xdb, 0x31, 0xd2, 0x8d, 0x45, 0xe8, 0xe8, 0x80, 0xd7, 0xf6, 0xff, 0xff, 0x70, 0xc, 0xff, 0x70, 0x8, 0xff, 0x70, 0x4, 0xff, 0x30, 0x8b, 0x45, 0xf8, 0xe8, 0x1d, 0x29, 0xf7, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0xc7, 0x40, 0x23, 0xbc, 0x68, 0x1b, 0x10, 0x8b, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x89, 0x42, 0x27, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xe4, 0x8b, 0x45, 0xe4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1011d987, 0x5)   pushd(0x48);                          /* push dword 0x48 */
    II(0x1011d98c, 0x5)   calld(sys_check_available_stack_size, 0x483c1); /* call 0x10165d52 */
    II(0x1011d991, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011d992, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011d993, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011d994, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011d995, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011d996, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011d998, 0x6)   sub(esp, 0x1c);                       /* sub esp, 0x1c */
    II(0x1011d99e, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1011d9a1, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1011d9a4, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
    II(0x1011d9a9, 0x1)   pushd(eax);                           /* push eax */
    II(0x1011d9aa, 0x5)   mov(eax, memd_a32(ds, 0x101c8172));   /* mov eax, [0x101c8172] */
    II(0x1011d9af, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1011d9b2, 0x1)   pushd(eax);                           /* push eax */
    II(0x1011d9b3, 0x6)   mov(ecx, memd_a32(ds, 0x101c8170));   /* mov ecx, [0x101c8170] */
    II(0x1011d9b9, 0x3)   sar(ecx, 0x10);                       /* sar ecx, 0x10 */
    II(0x1011d9bc, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1011d9be, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1011d9c0, 0x3)   lea(eax, ebp - 0x18);                 /* lea eax, [ebp-0x18] */
    II(0x1011d9c3, 0x5)   calld(0x1008b148, -0x92880);          /* call 0x1008b148 */
    II(0x1011d9c8, 0x3)   pushd(memd_a32(ds, eax + 0xc));       /* push dword [eax+0xc] */
    II(0x1011d9cb, 0x3)   pushd(memd_a32(ds, eax + 0x8));       /* push dword [eax+0x8] */
    II(0x1011d9ce, 0x3)   pushd(memd_a32(ds, eax + 0x4));       /* push dword [eax+0x4] */
    II(0x1011d9d1, 0x2)   pushd(memd_a32(ds, eax));             /* push dword [eax] */
    II(0x1011d9d3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011d9d6, 0x5)   calld(0x100902f8, -0x8d6e3);          /* call 0x100902f8 */
    II(0x1011d9db, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1011d9de, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011d9e1, 0x7)   mov(memd_a32(ds, eax + 0x23), 0x101b68bc); /* mov dword [eax+0x23], 0x101b68bc */
    II(0x1011d9e8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011d9eb, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1011d9ee, 0x3)   mov(memd_a32(ds, edx + 0x27), eax);   /* mov [edx+0x27], eax */
    II(0x1011d9f1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011d9f4, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
//    II(0x1011d9f7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x1c));   /* mov eax, [ebp-0x1c] */
    II(0x1011d9fa, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011d9fc, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011d9fd, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011d9fe, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011d9ff, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011da00, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011da01, 0x1)   retd();                               /* ret */
FUNC_END

