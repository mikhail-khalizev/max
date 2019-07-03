FUNC_BEGIN(/* sys */ 0x1018d6b2, 0xcf3112edbdd095ad, 0x20, ({0x53, 0x51, 0x52, 0x89, 0xc1, 0x89, 0xc3, 0xb4, 0x3e, 0xcd, 0x21, 0xd1, 0xd0, 0xd1, 0xc8, 0x85, 0xc0, 0x7c, 0xf, 0x89, 0xc8, 0x31, 0xd2, 0xe8, 0x2c, 0x70, 0, 0, 0x31, 0xc0, 0x5a, 0x59, 0x5b, 0xc3, 0xb8, 0x4, 0, 0, 0, 0xe8, 0xe1, 0xfc, 0xff, 0xff, 0xb8, 0xff, 0xff, 0xff, 0xff, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1018d6b2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1018d6b3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1018d6b4, 0x1)   pushd(edx);                           /* push edx */
    II(0x1018d6b5, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x1018d6b7, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x1018d6b9, 0x2)   mov(ah, 0x3e);                        /* mov ah, 0x3e */
    II(0x1018d6bb, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x1018d6bd, 0x2)   rcl(eax, 0x1);                        /* rcl eax, 1 */
    II(0x1018d6bf, 0x2)   ror(eax, 0x1);                        /* ror eax, 1 */
    II(0x1018d6c1, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1018d6c3, 0x2)   jld(0x1018d6d4, 0xf);                 /* jl 0x1018d6d4 */
    II(0x1018d6c5, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x1018d6c7, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1018d6c9, 0x5)   calld(/* sys */ 0x101946fa, 0x702c);  /* call 0x101946fa */
    II(0x1018d6ce, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1018d6d0, 0x1)   popd(edx);                            /* pop edx */
    II(0x1018d6d1, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1018d6d2, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1018d6d3, 0x1)   retd();                               /* ret */
l_0x1018d6d4:
    II(0x1018d6d4, 0x5)   mov(eax, 0x4);                        /* mov eax, 0x4 */
    II(0x1018d6d9, 0x5)   calld(/* sys */ 0x1018d3bf, -0x31f);  /* call 0x1018d3bf */
    II(0x1018d6de, 0x5)   mov(eax, 0xffffffff);                 /* mov eax, 0xffffffff */
    II(0x1018d6e3, 0x1)   popd(edx);                            /* pop edx */
    II(0x1018d6e4, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1018d6e5, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1018d6e6, 0x1)   retd();                               /* ret */
FUNC_END

