FUNC_BEGIN(/* sys */ 0x10169da0, 0xc8a546a44f0cf635, 0x20, ({0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xc7, 0x89, 0xd5, 0x8b, 0x70, 0x30, 0x85, 0xf6, 0x75, 0x9, 0xeb, 0x29, 0x8b, 0x76, 0x70, 0x85, 0xf6, 0x74, 0x22, 0x83, 0x7e, 0x70, 0, 0x75, 0xf3, 0x85, 0xf6, 0x75, 0x6, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3, 0x55, 0x89, 0xfa, 0x89, 0xf0, 0x8b, 0x5e, 0x48, 0x31, 0xc9, 0xe8, 0xb8, 0xfd, 0xff, 0xff, 0x8b, 0x76, 0x6c, 0x85, 0xf6, 0x75, 0xea, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10169da0, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10169da1, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10169da2, 0x1)   pushd(esi);                           /* push esi */
    II(0x10169da3, 0x1)   pushd(edi);                           /* push edi */
    II(0x10169da4, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10169da5, 0x2)   mov(edi, eax);                        /* mov edi, eax */
    II(0x10169da7, 0x2)   mov(ebp, edx);                        /* mov ebp, edx */
    II(0x10169da9, 0x3)   mov(esi, memd_a32(ds, eax + 0x30));   /* mov esi, [eax+0x30] */
    II(0x10169dac, 0x2)   test(esi, esi);                       /* test esi, esi */
    II(0x10169dae, 0x2)   jnzd(0x10169db9, 0x9);                /* jnz 0x10169db9 */
    II(0x10169db0, 0x2)   jmpd(0x10169ddb, 0x29);               /* jmp 0x10169ddb */
l_0x10169db2:
    II(0x10169db2, 0x3)   mov(esi, memd_a32(ds, esi + 0x70));   /* mov esi, [esi+0x70] */
    II(0x10169db5, 0x2)   test(esi, esi);                       /* test esi, esi */
    II(0x10169db7, 0x2)   jzd(0x10169ddb, 0x22);                /* jz 0x10169ddb */
l_0x10169db9:
    II(0x10169db9, 0x4)   cmp(memd_a32(ds, esi + 0x70), 0);     /* cmp dword [esi+0x70], 0x0 */
    II(0x10169dbd, 0x2)   jnzd(0x10169db2, -0xd);               /* jnz 0x10169db2 */
    II(0x10169dbf, 0x2)   test(esi, esi);                       /* test esi, esi */
    II(0x10169dc1, 0x2)   jnzd(0x10169dc9, 0x6);                /* jnz 0x10169dc9 */
    II(0x10169dc3, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10169dc4, 0x1)   popd(edi);                            /* pop edi */
    II(0x10169dc5, 0x1)   popd(esi);                            /* pop esi */
    II(0x10169dc6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10169dc7, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10169dc8, 0x1)   retd();                               /* ret */
l_0x10169dc9:
    II(0x10169dc9, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10169dca, 0x2)   mov(edx, edi);                        /* mov edx, edi */
    II(0x10169dcc, 0x2)   mov(eax, esi);                        /* mov eax, esi */
    II(0x10169dce, 0x3)   mov(ebx, memd_a32(ds, esi + 0x48));   /* mov ebx, [esi+0x48] */
    II(0x10169dd1, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x10169dd3, 0x5)   calld(/* sys */ 0x10169b90, -0x248);  /* call 0x10169b90 */
    II(0x10169dd8, 0x3)   mov(esi, memd_a32(ds, esi + 0x6c));   /* mov esi, [esi+0x6c] */
l_0x10169ddb:
    II(0x10169ddb, 0x2)   test(esi, esi);                       /* test esi, esi */
    II(0x10169ddd, 0x2)   jnzd(0x10169dc9, -0x16);              /* jnz 0x10169dc9 */
    II(0x10169ddf, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10169de0, 0x1)   popd(edi);                            /* pop edi */
    II(0x10169de1, 0x1)   popd(esi);                            /* pop esi */
    II(0x10169de2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10169de3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10169de4, 0x1)   retd();                               /* ret */
FUNC_END

