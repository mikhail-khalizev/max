FUNC_BEGIN(/* sys */ 0x10167f58, 0xf15a63c293e23854, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x83, 0xec, 0x4, 0x89, 0xc6, 0x83, 0x3d, 0xbc, 0xdd, 0x1b, 0x10, 0, 0x75, 0xa, 0xb8, 0xff, 0xff, 0xff, 0xff, 0xe9, 0x67, 0, 0, 0, 0xa1, 0xd8, 0xb2, 0x1c, 0x10, 0x48, 0x89, 0x4, 0x24, 0x83, 0xf8, 0x1, 0x7c, 0x57, 0x8d, 0x2c, 0x85, 0, 0, 0, 0, 0x8b, 0x85, 0xfc, 0xb1, 0x1c, 0x10, 0x83, 0x78, 0x3c, 0, 0x74, 0x29, 0x89, 0xef, 0x31, 0xd2, 0x31, 0xdb, 0xeb, 0x13, 0x3b, 0x74, 0x3, 0x28, 0x75, 0x9, 0xe8, 0x26, 0xce, 0x1, 0, 0x89, 0xc6, 0xeb, 0x12, 0x83, 0xc3, 0x24, 0x42, 0x8b, 0x87, 0xfc, 0xb1, 0x1c, 0x10, 0x8b, 0x40, 0x3c, 0x3b, 0x50, 0x14, 0x7c, 0xdf, 0x8b, 0x85, 0xfc, 0xb1, 0x1c, 0x10, 0xf6, 0x40, 0x4, 0x10, 0x75, 0xf, 0x8b, 0xc, 0x24, 0x49, 0x83, 0xed, 0x4, 0x89, 0xc, 0x24, 0x83, 0xfd, 0x4, 0x7d, 0xb0, 0x89, 0xf0, 0x83, 0xc4, 0x4, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10167f58, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10167f59, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10167f5a, 0x1)   pushd(edx);                           /* push edx */
    II(0x10167f5b, 0x1)   pushd(esi);                           /* push esi */
    II(0x10167f5c, 0x1)   pushd(edi);                           /* push edi */
    II(0x10167f5d, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10167f5e, 0x3)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10167f61, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x10167f63, 0x7)   cmp(memd_a32(ds, 0x101bddbc), 0);     /* cmp dword [0x101bddbc], 0x0 */
    II(0x10167f6a, 0x2)   jnzd(0x10167f76, 0xa);                /* jnz 0x10167f76 */
    II(0x10167f6c, 0x5)   mov(eax, 0xffffffff);                 /* mov eax, 0xffffffff */
    II(0x10167f71, 0x5)   jmpd(0x10167fdd, 0x67);               /* jmp 0x10167fdd */
l_0x10167f76:
    II(0x10167f76, 0x5)   mov(eax, memd_a32(ds, 0x101cb2d8));   /* mov eax, [0x101cb2d8] */
    II(0x10167f7b, 0x1)   dec(eax);                             /* dec eax */
    II(0x10167f7c, 0x3)   mov(memd_a32(ss, esp), eax);          /* mov [esp], eax */
    II(0x10167f7f, 0x3)   cmp(eax, 0x1);                        /* cmp eax, 0x1 */
    II(0x10167f82, 0x2)   jld(0x10167fdb, 0x57);                /* jl 0x10167fdb */
    II(0x10167f84, 0x7)   lea(ebp, eax * 0x4 + 0);              /* lea ebp, [eax*4+0x0] */
l_0x10167f8b:
    II(0x10167f8b, 0x6)   mov(eax, memd_a32(ss, ebp + 0x101cb1fc)); /* mov eax, [ebp+0x101cb1fc] */
    II(0x10167f91, 0x4)   cmp(memd_a32(ds, eax + 0x3c), 0);     /* cmp dword [eax+0x3c], 0x0 */
    II(0x10167f95, 0x2)   jzd(0x10167fc0, 0x29);                /* jz 0x10167fc0 */
    II(0x10167f97, 0x2)   mov(edi, ebp);                        /* mov edi, ebp */
    II(0x10167f99, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10167f9b, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x10167f9d, 0x2)   jmpd(0x10167fb2, 0x13);               /* jmp 0x10167fb2 */
l_0x10167f9f:
    II(0x10167f9f, 0x4)   cmp(esi, memd_a32(ds, ebx + eax + 0x28)); /* cmp esi, [ebx+eax+0x28] */
    II(0x10167fa3, 0x2)   jnzd(0x10167fae, 0x9);                /* jnz 0x10167fae */
    II(0x10167fa5, 0x5)   calld(/* sys */ 0x10184dd0, 0x1ce26); /* call 0x10184dd0 */
    II(0x10167faa, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x10167fac, 0x2)   jmpd(0x10167fc0, 0x12);               /* jmp 0x10167fc0 */
l_0x10167fae:
    II(0x10167fae, 0x3)   add(ebx, 0x24);                       /* add ebx, 0x24 */
    II(0x10167fb1, 0x1)   inc(edx);                             /* inc edx */
l_0x10167fb2:
    II(0x10167fb2, 0x6)   mov(eax, memd_a32(ds, edi + 0x101cb1fc)); /* mov eax, [edi+0x101cb1fc] */
    II(0x10167fb8, 0x3)   mov(eax, memd_a32(ds, eax + 0x3c));   /* mov eax, [eax+0x3c] */
    II(0x10167fbb, 0x3)   cmp(edx, memd_a32(ds, eax + 0x14));   /* cmp edx, [eax+0x14] */
    II(0x10167fbe, 0x2)   jld(0x10167f9f, -0x21);               /* jl 0x10167f9f */
l_0x10167fc0:
    II(0x10167fc0, 0x6)   mov(eax, memd_a32(ss, ebp + 0x101cb1fc)); /* mov eax, [ebp+0x101cb1fc] */
    II(0x10167fc6, 0x4)   test(memb_a32(ds, eax + 0x4), 0x10);  /* test byte [eax+0x4], 0x10 */
    II(0x10167fca, 0x2)   jnzd(0x10167fdb, 0xf);                /* jnz 0x10167fdb */
    II(0x10167fcc, 0x3)   mov(ecx, memd_a32(ss, esp));          /* mov ecx, [esp] */
    II(0x10167fcf, 0x1)   dec(ecx);                             /* dec ecx */
    II(0x10167fd0, 0x3)   sub(ebp, 0x4);                        /* sub ebp, 0x4 */
    II(0x10167fd3, 0x3)   mov(memd_a32(ss, esp), ecx);          /* mov [esp], ecx */
    II(0x10167fd6, 0x3)   cmp(ebp, 0x4);                        /* cmp ebp, 0x4 */
    II(0x10167fd9, 0x2)   jged(0x10167f8b, -0x50);              /* jge 0x10167f8b */
l_0x10167fdb:
    II(0x10167fdb, 0x2)   mov(eax, esi);                        /* mov eax, esi */
l_0x10167fdd:
    II(0x10167fdd, 0x3)   add(esp, 0x4);                        /* add esp, 0x4 */
    II(0x10167fe0, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10167fe1, 0x1)   popd(edi);                            /* pop edi */
    II(0x10167fe2, 0x1)   popd(esi);                            /* pop esi */
    II(0x10167fe3, 0x1)   popd(edx);                            /* pop edx */
    II(0x10167fe4, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10167fe5, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10167fe6, 0x1)   retd();                               /* ret */
FUNC_END

