FUNC_BEGIN(/* sys */ 0x10184ed0, 0xfcfc799423133243, 0x20, ({0x53, 0x51, 0x56, 0x89, 0xd6, 0x31, 0xc9, 0x31, 0xd2, 0x85, 0xf6, 0x7e, 0x18, 0x89, 0xc3, 0x8b, 0x3, 0xff, 0x15, 0xf4, 0xdd, 0x1b, 0x10, 0x39, 0xc8, 0x7e, 0x2, 0x89, 0xc1, 0x42, 0x83, 0xc3, 0x4, 0x39, 0xf2, 0x7c, 0xea, 0x89, 0xc8, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10184ed0, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10184ed1, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10184ed2, 0x1)   pushd(esi);                           /* push esi */
    II(0x10184ed3, 0x2)   mov(esi, edx);                        /* mov esi, edx */
    II(0x10184ed5, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x10184ed7, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10184ed9, 0x2)   test(esi, esi);                       /* test esi, esi */
    II(0x10184edb, 0x2)   jled(0x10184ef5, 0x18);               /* jle 0x10184ef5 */
    II(0x10184edd, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
l_0x10184edf:
    II(0x10184edf, 0x2)   mov(eax, memd_a32(ds, ebx));          /* mov eax, [ebx] */
    II(0x10184ee1, 0x6)   calld_abs(memd_a32(ds, 0x101bddf4));  /* call dword near [0x101bddf4] */
    II(0x10184ee7, 0x2)   cmp(eax, ecx);                        /* cmp eax, ecx */
    II(0x10184ee9, 0x2)   jled(0x10184eed, 0x2);                /* jle 0x10184eed */
    II(0x10184eeb, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
l_0x10184eed:
    II(0x10184eed, 0x1)   inc(edx);                             /* inc edx */
    II(0x10184eee, 0x3)   add(ebx, 0x4);                        /* add ebx, 0x4 */
    II(0x10184ef1, 0x2)   cmp(edx, esi);                        /* cmp edx, esi */
    II(0x10184ef3, 0x2)   jld(0x10184edf, -0x16);               /* jl 0x10184edf */
l_0x10184ef5:
    II(0x10184ef5, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x10184ef7, 0x1)   popd(esi);                            /* pop esi */
    II(0x10184ef8, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10184ef9, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10184efa, 0x1)   retd();                               /* ret */
FUNC_END

