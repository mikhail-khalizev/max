FUNC_BEGIN(/* sys */ 0x10167d38, 0xa219cf8d51552352, 0x20, ({0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xc7, 0x89, 0xd5, 0xba, 0x1, 0, 0, 0, 0x8b, 0x1d, 0xd8, 0xb2, 0x1c, 0x10, 0x31, 0xf6, 0x89, 0x15, 0xd0, 0xb2, 0x1c, 0x10, 0x85, 0xdb, 0x7e, 0x1e, 0x31, 0xc9, 0x89, 0xeb, 0x89, 0xfa, 0x8b, 0x81, 0xfc, 0xb1, 0x1c, 0x10, 0xe8, 0x97, 0xf7, 0xff, 0xff, 0x46, 0xa1, 0xd8, 0xb2, 0x1c, 0x10, 0x83, 0xc1, 0x4, 0x39, 0xc6, 0x7c, 0xe4, 0x31, 0xd2, 0x89, 0x15, 0xd0, 0xb2, 0x1c, 0x10, 0x85, 0xed, 0x75, 0x22, 0xe8, 0xc9, 0x45, 0, 0, 0x85, 0xc0, 0x75, 0x19, 0x8b, 0x4f, 0xc, 0x8b, 0x5f, 0x8, 0x8b, 0x57, 0x4, 0x8b, 0x7, 0xe8, 0xe9, 0x43, 0, 0, 0x85, 0xc0, 0x74, 0x5, 0xe8, 0x20, 0x3f, 0, 0, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10167d38, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10167d39, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10167d3a, 0x1)   pushd(esi);                           /* push esi */
    II(0x10167d3b, 0x1)   pushd(edi);                           /* push edi */
    II(0x10167d3c, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10167d3d, 0x2)   mov(edi, eax);                        /* mov edi, eax */
    II(0x10167d3f, 0x2)   mov(ebp, edx);                        /* mov ebp, edx */
    II(0x10167d41, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x10167d46, 0x6)   mov(ebx, memd_a32(ds, 0x101cb2d8));   /* mov ebx, [0x101cb2d8] */
    II(0x10167d4c, 0x2)   xor_(esi, esi);                       /* xor esi, esi */
    II(0x10167d4e, 0x6)   mov(memd_a32(ds, 0x101cb2d0), edx);   /* mov [0x101cb2d0], edx */
    II(0x10167d54, 0x2)   test(ebx, ebx);                       /* test ebx, ebx */
    II(0x10167d56, 0x2)   jled(0x10167d76, 0x1e);               /* jle 0x10167d76 */
    II(0x10167d58, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
l_0x10167d5a:
    II(0x10167d5a, 0x2)   mov(ebx, ebp);                        /* mov ebx, ebp */
    II(0x10167d5c, 0x2)   mov(edx, edi);                        /* mov edx, edi */
    II(0x10167d5e, 0x6)   mov(eax, memd_a32(ds, ecx + 0x101cb1fc)); /* mov eax, [ecx+0x101cb1fc] */
    II(0x10167d64, 0x5)   calld(/* sys */ 0x10167500, -0x869);  /* call 0x10167500 */
    II(0x10167d69, 0x1)   inc(esi);                             /* inc esi */
    II(0x10167d6a, 0x5)   mov(eax, memd_a32(ds, 0x101cb2d8));   /* mov eax, [0x101cb2d8] */
    II(0x10167d6f, 0x3)   add(ecx, 0x4);                        /* add ecx, 0x4 */
    II(0x10167d72, 0x2)   cmp(esi, eax);                        /* cmp esi, eax */
    II(0x10167d74, 0x2)   jld(0x10167d5a, -0x1c);               /* jl 0x10167d5a */
l_0x10167d76:
    II(0x10167d76, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10167d78, 0x6)   mov(memd_a32(ds, 0x101cb2d0), edx);   /* mov [0x101cb2d0], edx */
    II(0x10167d7e, 0x2)   test(ebp, ebp);                       /* test ebp, ebp */
    II(0x10167d80, 0x2)   jnzd(0x10167da4, 0x22);               /* jnz 0x10167da4 */
    II(0x10167d82, 0x5)   calld(/* sys */ 0x1016c350, 0x45c9);  /* call 0x1016c350 */
    II(0x10167d87, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10167d89, 0x2)   jnzd(0x10167da4, 0x19);               /* jnz 0x10167da4 */
    II(0x10167d8b, 0x3)   mov(ecx, memd_a32(ds, edi + 0xc));    /* mov ecx, [edi+0xc] */
    II(0x10167d8e, 0x3)   mov(ebx, memd_a32(ds, edi + 0x8));    /* mov ebx, [edi+0x8] */
    II(0x10167d91, 0x3)   mov(edx, memd_a32(ds, edi + 0x4));    /* mov edx, [edi+0x4] */
    II(0x10167d94, 0x2)   mov(eax, memd_a32(ds, edi));          /* mov eax, [edi] */
    II(0x10167d96, 0x5)   calld(/* sys */ 0x1016c184, 0x43e9);  /* call 0x1016c184 */
    II(0x10167d9b, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10167d9d, 0x2)   jzd(0x10167da4, 0x5);                 /* jz 0x10167da4 */
    II(0x10167d9f, 0x5)   calld(/* sys */ 0x1016bcc4, 0x3f20);  /* call 0x1016bcc4 */
l_0x10167da4:
    II(0x10167da4, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10167da5, 0x1)   popd(edi);                            /* pop edi */
    II(0x10167da6, 0x1)   popd(esi);                            /* pop esi */
    II(0x10167da7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10167da8, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10167da9, 0x1)   retd();                               /* ret */
FUNC_END

