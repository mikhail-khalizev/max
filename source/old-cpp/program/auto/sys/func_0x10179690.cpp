FUNC_BEGIN(/* sys */ 0x10179690, 0x42b987994d7b397b, 0x20, ({0x45, 0x55, 0x89, 0xe5, 0x53, 0x51, 0x52, 0xe8, 0xa0, 0x45, 0x1, 0, 0x8d, 0x65, 0xf4, 0x5a, 0x59, 0x5b, 0x5d, 0x4d, 0xcb}))
    II(0x10179690, 0x1)   inc(ebp);                             /* inc ebp */
    II(0x10179691, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10179692, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10179694, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10179695, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10179696, 0x1)   pushd(edx);                           /* push edx */
    II(0x10179697, 0x5)   calld(/* sys */ 0x1018dc3c, 0x145a0); /* call 0x1018dc3c */
    II(0x1017969c, 0x3)   lea(esp, ebp - 0xc);                  /* lea esp, [ebp-0xc] */
    II(0x1017969f, 0x1)   popd(edx);                            /* pop edx */
    II(0x101796a0, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101796a1, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101796a2, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101796a3, 0x1)   dec(ebp);                             /* dec ebp */
    II(0x101796a4, 0x1)   retfd();                              /* retf */
FUNC_END

