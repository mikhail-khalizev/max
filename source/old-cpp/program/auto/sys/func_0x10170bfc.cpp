FUNC_BEGIN(/* sys */ 0x10170bfc, 0x984693fdacdedf24, 0x20, ({0x53, 0x51, 0x52, 0x57, 0x55, 0x89, 0xc1, 0x85, 0xc0, 0xf, 0x84, 0x7b, 0, 0, 0, 0x8b, 0x50, 0x4, 0x85, 0xd2, 0x74, 0xe, 0x89, 0xd0, 0xe8, 0x50, 0x14, 0, 0, 0xc7, 0x41, 0x4, 0, 0, 0, 0, 0x8b, 0x19, 0x85, 0xdb, 0x74, 0xe, 0x89, 0xd8, 0xff, 0x15, 0xd0, 0xe1, 0x1b, 0x10, 0xc7, 0x1, 0, 0, 0, 0, 0x83, 0x79, 0x38, 0, 0x74, 0x30, 0x8b, 0x79, 0x18, 0x31, 0xd2, 0x85, 0xff, 0x7e, 0x17, 0x31, 0xdb, 0x8b, 0x41, 0x38, 0x1, 0xd8, 0x42, 0xe8, 0x14, 0xaa, 0x1, 0, 0x8b, 0x69, 0x18, 0x83, 0xc3, 0x24, 0x39, 0xea, 0x7c, 0xeb, 0x8b, 0x41, 0x38, 0xff, 0x15, 0xd0, 0xe1, 0x1b, 0x10, 0xc7, 0x41, 0x38, 0, 0, 0, 0, 0x8d, 0x41, 0x14, 0xe8, 0xf2, 0xa9, 0x1, 0, 0x8b, 0x41, 0x8, 0x85, 0xc0, 0x74, 0xd, 0xff, 0x15, 0xd0, 0xe1, 0x1b, 0x10, 0xc7, 0x41, 0x8, 0, 0, 0, 0, 0x5d, 0x5f, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10170bfc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10170bfd, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10170bfe, 0x1)   pushd(edx);                           /* push edx */
    II(0x10170bff, 0x1)   pushd(edi);                           /* push edi */
    II(0x10170c00, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10170c01, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x10170c03, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10170c05, 0x6)   jzd(0x10170c86, 0x7b);                /* jz dword 0x10170c86 */
    II(0x10170c0b, 0x3)   mov(edx, memd_a32(ds, eax + 0x4));    /* mov edx, [eax+0x4] */
    II(0x10170c0e, 0x2)   test(edx, edx);                       /* test edx, edx */
    II(0x10170c10, 0x2)   jzd(0x10170c20, 0xe);                 /* jz 0x10170c20 */
    II(0x10170c12, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x10170c14, 0x5)   calld(sys_fclose, 0x1450);            /* call 0x10172069 */
    II(0x10170c19, 0x7)   mov(memd_a32(ds, ecx + 0x4), 0);      /* mov dword [ecx+0x4], 0x0 */
l_0x10170c20:
    II(0x10170c20, 0x2)   mov(ebx, memd_a32(ds, ecx));          /* mov ebx, [ecx] */
    II(0x10170c22, 0x2)   test(ebx, ebx);                       /* test ebx, ebx */
    II(0x10170c24, 0x2)   jzd(0x10170c34, 0xe);                 /* jz 0x10170c34 */
    II(0x10170c26, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x10170c28, 0x6)   calld_abs(memd_a32(ds, 0x101be1d0));  /* call dword near [0x101be1d0] */ /* Вызов '0x101711b4'. */
    II(0x10170c2e, 0x6)   mov(memd_a32(ds, ecx), 0);            /* mov dword [ecx], 0x0 */
l_0x10170c34:
    II(0x10170c34, 0x4)   cmp(memd_a32(ds, ecx + 0x38), 0);     /* cmp dword [ecx+0x38], 0x0 */
    II(0x10170c38, 0x2)   jzd(0x10170c6a, 0x30);                /* jz 0x10170c6a */
    II(0x10170c3a, 0x3)   mov(edi, memd_a32(ds, ecx + 0x18));   /* mov edi, [ecx+0x18] */
    II(0x10170c3d, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10170c3f, 0x2)   test(edi, edi);                       /* test edi, edi */
    II(0x10170c41, 0x2)   jled(0x10170c5a, 0x17);               /* jle 0x10170c5a */
    II(0x10170c43, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
l_0x10170c45:
    II(0x10170c45, 0x3)   mov(eax, memd_a32(ds, ecx + 0x38));   /* mov eax, [ecx+0x38] */
    II(0x10170c48, 0x2)   add(eax, ebx);                        /* add eax, ebx */
    II(0x10170c4a, 0x1)   inc(edx);                             /* inc edx */
    II(0x10170c4b, 0x5)   calld(/* sys */ 0x1018b664, 0x1aa14); /* call 0x1018b664 */
    II(0x10170c50, 0x3)   mov(ebp, memd_a32(ds, ecx + 0x18));   /* mov ebp, [ecx+0x18] */
    II(0x10170c53, 0x3)   add(ebx, 0x24);                       /* add ebx, 0x24 */
    II(0x10170c56, 0x2)   cmp(edx, ebp);                        /* cmp edx, ebp */
    II(0x10170c58, 0x2)   jld(0x10170c45, -0x15);               /* jl 0x10170c45 */
l_0x10170c5a:
    II(0x10170c5a, 0x3)   mov(eax, memd_a32(ds, ecx + 0x38));   /* mov eax, [ecx+0x38] */
    II(0x10170c5d, 0x6)   calld_abs(memd_a32(ds, 0x101be1d0));  /* call dword near [0x101be1d0] */ /* Вызов '0x101711b4'. */
    II(0x10170c63, 0x7)   mov(memd_a32(ds, ecx + 0x38), 0);     /* mov dword [ecx+0x38], 0x0 */
l_0x10170c6a:
    II(0x10170c6a, 0x3)   lea(eax, ecx + 0x14);                 /* lea eax, [ecx+0x14] */
    II(0x10170c6d, 0x5)   calld(/* sys */ 0x1018b664, 0x1a9f2); /* call 0x1018b664 */
    II(0x10170c72, 0x3)   mov(eax, memd_a32(ds, ecx + 0x8));    /* mov eax, [ecx+0x8] */
    II(0x10170c75, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10170c77, 0x2)   jzd(0x10170c86, 0xd);                 /* jz 0x10170c86 */
    II(0x10170c79, 0x6)   calld_abs(memd_a32(ds, 0x101be1d0));  /* call dword near [0x101be1d0] */ /* Вызов '0x101711b4'. */
    II(0x10170c7f, 0x7)   mov(memd_a32(ds, ecx + 0x8), 0);      /* mov dword [ecx+0x8], 0x0 */
l_0x10170c86:
    II(0x10170c86, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10170c87, 0x1)   popd(edi);                            /* pop edi */
    II(0x10170c88, 0x1)   popd(edx);                            /* pop edx */
    II(0x10170c89, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10170c8a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10170c8b, 0x1)   retd();                               /* ret */
FUNC_END

