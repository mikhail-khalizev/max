FUNC_BEGIN(0x10101374, 0xb244e4a8edc54af5, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xd4, 0x49, 0x6, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xe8, 0x12, 0x2d, 0xff, 0xff, 0xe8, 0x28, 0xe2, 0xff, 0xff, 0x31, 0xdb, 0x8a, 0x5d, 0xfc, 0xb8, 0xbc, 0x37, 0x1c, 0x10, 0xe8, 0x58, 0x52, 0xf7, 0xff, 0x31, 0xc9, 0x8a, 0xd, 0xda, 0x37, 0x1c, 0x10, 0xf, 0xbf, 0xc9, 0x89, 0xc2, 0x89, 0xc8, 0xe8, 0x7e, 0x18, 0xf7, 0xff, 0x89, 0x45, 0xf8, 0x83, 0x7d, 0xf8, 0, 0x75, 0x10, 0x31, 0xc0, 0xa0, 0xda, 0x37, 0x1c, 0x10, 0x98, 0xe8, 0x56, 0x9, 0xff, 0xff, 0x89, 0x45, 0xf8, 0x83, 0x7d, 0xf8, 0, 0x75, 0x9, 0x31, 0xc0, 0xe8, 0x55, 0xe2, 0xff, 0xff, 0xeb, 0x3a, 0x8b, 0x45, 0xf8, 0xe8, 0x17, 0xfd, 0xff, 0xff, 0x66, 0x85, 0xc0, 0x75, 0x25, 0xe8, 0xd6, 0x16, 0, 0, 0x31, 0xc9, 0x88, 0xc1, 0x8b, 0x45, 0xf8, 0x8b, 0x58, 0x1a, 0xc1, 0xfb, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x18, 0xc1, 0xfa, 0x10, 0xb8, 0x1, 0, 0, 0, 0xe8, 0xa, 0x2, 0, 0, 0x8b, 0x45, 0xf8, 0xe8, 0x19, 0xe2, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10101374, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10101379, 0x5)   calld(sys_check_available_stack_size, 0x649d4); /* call 0x10165d52 */
    II(0x1010137e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1010137f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10101380, 0x1)   pushd(edx);                           /* push edx */
    II(0x10101381, 0x1)   pushd(esi);                           /* push esi */
    II(0x10101382, 0x1)   pushd(edi);                           /* push edi */
    II(0x10101383, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10101384, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10101386, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1010138c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1010138f, 0x5)   calld(0x100f40a6, -0xd2ee);           /* call 0x100f40a6 */
    II(0x10101394, 0x5)   calld(0x100ff5c1, -0x1dd8);           /* call 0x100ff5c1 */
    II(0x10101399, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1010139b, 0x3)   mov(bl, memb_a32(ss, ebp - 0x4));     /* mov bl, [ebp-0x4] */
    II(0x1010139e, 0x5)   mov(eax, 0x101c37bc);                 /* mov eax, 0x101c37bc */
    II(0x101013a3, 0x5)   calld(0x10076600, -0x8ada8);          /* call 0x10076600 */
    II(0x101013a8, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x101013aa, 0x6)   mov(cl, memb_a32(ds, 0x101c37da));    /* mov cl, [0x101c37da] */
    II(0x101013b0, 0x3)   movsx(ecx, cx);                       /* movsx ecx, cx */
    II(0x101013b3, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x101013b5, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x101013b7, 0x5)   calld(0x10072c3a, -0x8e782);          /* call 0x10072c3a */
    II(0x101013bc, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x101013bf, 0x4)   cmp(memd_a32(ss, ebp - 0x8), 0);      /* cmp dword [ebp-0x8], 0x0 */
    II(0x101013c3, 0x2)   jnzd(0x101013d5, 0x10);               /* jnz 0x101013d5 */
    II(0x101013c5, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x101013c7, 0x5)   mov(al, memb_a32(ds, 0x101c37da));    /* mov al, [0x101c37da] */
    II(0x101013cc, 0x1)   cwde();                               /* cwde */
    II(0x101013cd, 0x5)   calld(0x100f1d28, -0xf6aa);           /* call 0x100f1d28 */
    II(0x101013d2, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
l_0x101013d5:
    II(0x101013d5, 0x4)   cmp(memd_a32(ss, ebp - 0x8), 0);      /* cmp dword [ebp-0x8], 0x0 */
    II(0x101013d9, 0x2)   jnzd(0x101013e4, 0x9);                /* jnz 0x101013e4 */
    II(0x101013db, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x101013dd, 0x5)   calld(0x100ff637, -0x1dab);           /* call 0x100ff637 */
    II(0x101013e2, 0x2)   jmpd(0x1010141e, 0x3a);               /* jmp 0x1010141e */
l_0x101013e4:
    II(0x101013e4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101013e7, 0x5)   calld(0x10101103, -0x2e9);            /* call 0x10101103 */
    II(0x101013ec, 0x3)   test(ax, ax);                         /* test ax, ax */
    II(0x101013ef, 0x2)   jnzd(0x10101416, 0x25);               /* jnz 0x10101416 */
    II(0x101013f1, 0x5)   calld(0x10102acc, 0x16d6);            /* call 0x10102acc */
    II(0x101013f6, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x101013f8, 0x2)   mov(cl, al);                          /* mov cl, al */
    II(0x101013fa, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101013fd, 0x3)   mov(ebx, memd_a32(ds, eax + 0x1a));   /* mov ebx, [eax+0x1a] */
    II(0x10101400, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x10101403, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10101406, 0x3)   mov(edx, memd_a32(ds, eax + 0x18));   /* mov edx, [eax+0x18] */
    II(0x10101409, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x1010140c, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
    II(0x10101411, 0x5)   calld(0x10101620, 0x20a);             /* call 0x10101620 */
l_0x10101416:
    II(0x10101416, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10101419, 0x5)   calld(0x100ff637, -0x1de7);           /* call 0x100ff637 */
l_0x1010141e:
    II(0x1010141e, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10101420, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10101421, 0x1)   popd(edi);                            /* pop edi */
    II(0x10101422, 0x1)   popd(esi);                            /* pop esi */
    II(0x10101423, 0x1)   popd(edx);                            /* pop edx */
    II(0x10101424, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10101425, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10101426, 0x1)   retd();                               /* ret */
FUNC_END

