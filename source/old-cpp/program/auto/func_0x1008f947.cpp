FUNC_BEGIN(0x1008f947, 0x9c72ed6850e625d6, 0x20, ({0x68, 0x30, 0, 0, 0, 0xe8, 0x1, 0x64, 0xd, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x18, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x15, 0xe8, 0xa0, 0xb3, 0xa, 0, 0x84, 0xc0, 0x75, 0x18, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x15, 0xe8, 0xf4, 0x6b, 0xfe, 0xff, 0x66, 0x8b, 0x50, 0x8, 0x8b, 0x45, 0xfc, 0x66, 0x3b, 0x50, 0x8, 0x74, 0x2, 0xeb, 0x9, 0x8b, 0x45, 0xf8, 0x80, 0x78, 0x25, 0x9, 0x7c, 0x9, 0xc6, 0x45, 0xf4, 0, 0xe9, 0x8f, 0, 0, 0, 0x8b, 0x55, 0xf8, 0x83, 0xc2, 0x21, 0x8d, 0x45, 0xec, 0xe8, 0xb5, 0x64, 0xfe, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x15, 0xe8, 0x14, 0x6c, 0xfe, 0xff, 0xe8, 0xe0, 0x12, 0xfe, 0xff, 0x89, 0xc3, 0x8b, 0x55, 0xf8, 0x83, 0xc2, 0x21, 0x8d, 0x45, 0xf0, 0xe8, 0x93, 0x64, 0xfe, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xfc, 0xe8, 0xc6, 0x12, 0xfe, 0xff, 0x66, 0x39, 0xc3, 0x7f, 0x6, 0xc6, 0x45, 0xf4, 0, 0xeb, 0x4a, 0xe8, 0xb1, 0xad, 0xff, 0xff, 0x31, 0xdb, 0x88, 0xc3, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x15, 0xe8, 0xd6, 0x6b, 0xfe, 0xff, 0x89, 0xc2, 0xb8, 0x80, 0x31, 0x1c, 0x10, 0xe8, 0xa6, 0x59, 0x1, 0, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x15, 0xe8, 0xfe, 0xb2, 0xa, 0, 0x84, 0xc0, 0x74, 0x15, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xe8, 0x8b, 0x45, 0xe8, 0x8b, 0x58, 0x2, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xe8, 0xff, 0x53, 0x2c, 0xc6, 0x45, 0xf4, 0x1, 0x8a, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1008f947, 0x5)   pushd(0x30);                          /* push dword 0x30 */
    II(0x1008f94c, 0x5)   calld(sys_check_available_stack_size, 0xd6401); /* call 0x10165d52 */
    II(0x1008f951, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008f952, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008f953, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008f954, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008f955, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008f956, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008f958, 0x6)   sub(esp, 0x18);                       /* sub esp, 0x18 */
    II(0x1008f95e, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1008f961, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1008f964, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1008f966, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008f969, 0x3)   add(eax, 0x15);                       /* add eax, 0x15 */
    II(0x1008f96c, 0x5)   calld(0x1013ad11, 0xab3a0);           /* call 0x1013ad11 */
    II(0x1008f971, 0x2)   test(al, al);                         /* test al, al */
    II(0x1008f973, 0x2)   jnzd(0x1008f98d, 0x18);               /* jnz 0x1008f98d */
    II(0x1008f975, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008f978, 0x3)   add(eax, 0x15);                       /* add eax, 0x15 */
    II(0x1008f97b, 0x5)   calld(0x10076574, -0x1940c);          /* call 0x10076574 */
    II(0x1008f980, 0x4)   mov(dx, memw_a32(ds, eax + 0x8));     /* mov dx, [eax+0x8] */
    II(0x1008f984, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008f987, 0x4)   cmp(dx, memw_a32(ds, eax + 0x8));     /* cmp dx, [eax+0x8] */
    II(0x1008f98b, 0x2)   jzd(0x1008f98f, 0x2);                 /* jz 0x1008f98f */
l_0x1008f98d:
    II(0x1008f98d, 0x2)   jmpd(0x1008f998, 0x9);                /* jmp 0x1008f998 */
l_0x1008f98f:
    II(0x1008f98f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008f992, 0x4)   cmp(memb_a32(ds, eax + 0x25), 0x9);   /* cmp byte [eax+0x25], 0x9 */
    II(0x1008f996, 0x2)   jld(0x1008f9a1, 0x9);                 /* jl 0x1008f9a1 */
l_0x1008f998:
    II(0x1008f998, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
    II(0x1008f99c, 0x5)   jmpd(0x1008fa30, 0x8f);               /* jmp 0x1008fa30 */
l_0x1008f9a1:
    II(0x1008f9a1, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1008f9a4, 0x3)   add(edx, 0x21);                       /* add edx, 0x21 */
    II(0x1008f9a7, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x1008f9aa, 0x5)   calld(0x10075e64, -0x19b4b);          /* call 0x10075e64 */
    II(0x1008f9af, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1008f9b1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008f9b4, 0x3)   add(eax, 0x15);                       /* add eax, 0x15 */
    II(0x1008f9b7, 0x5)   calld(0x100765d0, -0x193ec);          /* call 0x100765d0 */
    II(0x1008f9bc, 0x5)   calld(0x10070ca1, -0x1ed20);          /* call 0x10070ca1 */
    II(0x1008f9c1, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x1008f9c3, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1008f9c6, 0x3)   add(edx, 0x21);                       /* add edx, 0x21 */
    II(0x1008f9c9, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x1008f9cc, 0x5)   calld(0x10075e64, -0x19b6d);          /* call 0x10075e64 */
    II(0x1008f9d1, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1008f9d3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008f9d6, 0x5)   calld(0x10070ca1, -0x1ed3a);          /* call 0x10070ca1 */
    II(0x1008f9db, 0x3)   cmp(bx, ax);                          /* cmp bx, ax */
    II(0x1008f9de, 0x2)   jgd(0x1008f9e6, 0x6);                 /* jg 0x1008f9e6 */
    II(0x1008f9e0, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
    II(0x1008f9e4, 0x2)   jmpd(0x1008fa30, 0x4a);               /* jmp 0x1008fa30 */
l_0x1008f9e6:
    II(0x1008f9e6, 0x5)   calld(0x1008a79c, -0x524f);           /* call 0x1008a79c */
    II(0x1008f9eb, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1008f9ed, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x1008f9ef, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008f9f2, 0x3)   add(eax, 0x15);                       /* add eax, 0x15 */
    II(0x1008f9f5, 0x5)   calld(0x100765d0, -0x1942a);          /* call 0x100765d0 */
    II(0x1008f9fa, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1008f9fc, 0x5)   mov(eax, 0x101c3180);                 /* mov eax, 0x101c3180 */
    II(0x1008fa01, 0x5)   calld(0x100a53ac, 0x159a6);           /* call 0x100a53ac */
    II(0x1008fa06, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1008fa08, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008fa0b, 0x3)   add(eax, 0x15);                       /* add eax, 0x15 */
    II(0x1008fa0e, 0x5)   calld(0x1013ad11, 0xab2fe);           /* call 0x1013ad11 */
    II(0x1008fa13, 0x2)   test(al, al);                         /* test al, al */
    II(0x1008fa15, 0x2)   jzd(0x1008fa2c, 0x15);                /* jz 0x1008fa2c */
    II(0x1008fa17, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008fa1a, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
//    II(0x1008fa1d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x1008fa20, 0x3)   mov(ebx, memd_a32(ds, eax + 0x2));    /* mov ebx, [eax+0x2] */
    II(0x1008fa23, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x1008fa26, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x1008fa29, 0x3)   calld_abs(memd_a32(ds, ebx + 0x2c));  /* call dword near [ebx+0x2c] */
l_0x1008fa2c:
    II(0x1008fa2c, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0x1);    /* mov byte [ebp-0xc], 0x1 */
l_0x1008fa30:
    II(0x1008fa30, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x1008fa33, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008fa35, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008fa36, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008fa37, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008fa38, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008fa39, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008fa3a, 0x1)   retd();                               /* ret */
FUNC_END

