FUNC_BEGIN(/* sys */ 0x10172096, 0x838bf0495f7b5bff, 0x20, ({0x53, 0x89, 0xc3, 0xe8, 0x7e, 0, 0, 0, 0x89, 0xc2, 0x89, 0xd8, 0xe8, 0xd5, 0xb4, 0x1, 0, 0x89, 0xd0, 0x5b, 0xc3}))
    II(0x10172096, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10172097, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x10172099, 0x5)   calld(/* sys */ 0x1017211c, 0x7e);    /* call 0x1017211c */
    II(0x1017209e, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x101720a0, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x101720a2, 0x5)   calld(/* sys */ 0x1018d57c, 0x1b4d5); /* call 0x1018d57c */
    II(0x101720a7, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x101720a9, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101720aa, 0x1)   retd();                               /* ret */
FUNC_END

