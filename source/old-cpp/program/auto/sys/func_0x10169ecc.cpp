FUNC_BEGIN(/* sys */ 0x10169ecc, 0xd9e2dfc3b254b908, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x83, 0xec, 0x2c, 0xbd, 0xff, 0xff, 0xff, 0xff, 0xb9, 0xb, 0, 0, 0, 0x89, 0xe7, 0xbe, 0xa0, 0x9e, 0x16, 0x10, 0x31, 0xd2, 0x31, 0xdb, 0xf3, 0xa5, 0x89, 0xd0, 0xe8, 0x79, 0, 0, 0, 0x83, 0xf8, 0xff, 0x75, 0xa, 0x31, 0xc9, 0x89, 0x8b, 0xe4, 0xf6, 0x1c, 0x10, 0xeb, 0x7, 0x83, 0xfd, 0xff, 0x75, 0x2, 0x89, 0xd5, 0x42, 0x83, 0xc3, 0x14, 0x83, 0xfa, 0xa, 0x7c, 0xda, 0x83, 0xfd, 0xff, 0x75, 0x4, 0x89, 0xe8, 0xeb, 0x15, 0x89, 0xe0, 0xe8, 0xce, 0x1, 0, 0, 0x83, 0xf8, 0xff, 0x74, 0x9, 0x89, 0xe8, 0xe8, 0x1e, 0x3, 0, 0, 0x31, 0xc0, 0x83, 0xc4, 0x2c, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10169ecc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10169ecd, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10169ece, 0x1)   pushd(edx);                           /* push edx */
    II(0x10169ecf, 0x1)   pushd(esi);                           /* push esi */
    II(0x10169ed0, 0x1)   pushd(edi);                           /* push edi */
    II(0x10169ed1, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10169ed2, 0x3)   sub(esp, 0x2c);                       /* sub esp, 0x2c */
    II(0x10169ed5, 0x5)   mov(ebp, 0xffffffff);                 /* mov ebp, 0xffffffff */
    II(0x10169eda, 0x5)   mov(ecx, 0xb);                        /* mov ecx, 0xb */
    II(0x10169edf, 0x2)   mov(edi, esp);                        /* mov edi, esp */
    II(0x10169ee1, 0x5)   mov(esi, /* sys */ 0x10169ea0);       /* mov esi, 0x10169ea0 */
    II(0x10169ee6, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10169ee8, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x10169eea, 0x2)   rep_a32 movsd_a32();                  /* rep movsd */
l_0x10169eec:
    II(0x10169eec, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x10169eee, 0x5)   calld(/* sys */ 0x10169f6c, 0x79);    /* call 0x10169f6c */
    II(0x10169ef3, 0x3)   cmp(eax, -0x1 /* 0xff */);            /* cmp eax, 0xff */
    II(0x10169ef6, 0x2)   jnzd(0x10169f02, 0xa);                /* jnz 0x10169f02 */
    II(0x10169ef8, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x10169efa, 0x6)   mov(memd_a32(ds, ebx + 0x101cf6e4), ecx); /* mov [ebx+0x101cf6e4], ecx */
    II(0x10169f00, 0x2)   jmpd(0x10169f09, 0x7);                /* jmp 0x10169f09 */
l_0x10169f02:
    II(0x10169f02, 0x3)   cmp(ebp, -0x1 /* 0xff */);            /* cmp ebp, 0xff */
    II(0x10169f05, 0x2)   jnzd(0x10169f09, 0x2);                /* jnz 0x10169f09 */
    II(0x10169f07, 0x2)   mov(ebp, edx);                        /* mov ebp, edx */
l_0x10169f09:
    II(0x10169f09, 0x1)   inc(edx);                             /* inc edx */
    II(0x10169f0a, 0x3)   add(ebx, 0x14);                       /* add ebx, 0x14 */
    II(0x10169f0d, 0x3)   cmp(edx, 0xa);                        /* cmp edx, 0xa */
    II(0x10169f10, 0x2)   jld(0x10169eec, -0x26);               /* jl 0x10169eec */
    II(0x10169f12, 0x3)   cmp(ebp, -0x1 /* 0xff */);            /* cmp ebp, 0xff */
    II(0x10169f15, 0x2)   jnzd(0x10169f1b, 0x4);                /* jnz 0x10169f1b */
    II(0x10169f17, 0x2)   mov(eax, ebp);                        /* mov eax, ebp */
    II(0x10169f19, 0x2)   jmpd(0x10169f30, 0x15);               /* jmp 0x10169f30 */
l_0x10169f1b:
    II(0x10169f1b, 0x2)   mov(eax, esp);                        /* mov eax, esp */
    II(0x10169f1d, 0x5)   calld(/* sys */ 0x1016a0f0, 0x1ce);   /* call 0x1016a0f0 */
    II(0x10169f22, 0x3)   cmp(eax, -0x1 /* 0xff */);            /* cmp eax, 0xff */
    II(0x10169f25, 0x2)   jzd(0x10169f30, 0x9);                 /* jz 0x10169f30 */
    II(0x10169f27, 0x2)   mov(eax, ebp);                        /* mov eax, ebp */
    II(0x10169f29, 0x5)   calld(/* sys */ 0x1016a24c, 0x31e);   /* call 0x1016a24c */
    II(0x10169f2e, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
l_0x10169f30:
    II(0x10169f30, 0x3)   add(esp, 0x2c);                       /* add esp, 0x2c */
    II(0x10169f33, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10169f34, 0x1)   popd(edi);                            /* pop edi */
    II(0x10169f35, 0x1)   popd(esi);                            /* pop esi */
    II(0x10169f36, 0x1)   popd(edx);                            /* pop edx */
    II(0x10169f37, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10169f38, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10169f39, 0x1)   retd();                               /* ret */
FUNC_END

