FUNC_BEGIN(0x00009c08, 0xebcc028808c0f1f, 0x10, ({0x66, 0x9c, 0x66, 0x9c, 0x66, 0x5a, 0x66, 0x8b, 0xca, 0x66, 0xf, 0xba, 0xfa, 0x15, 0x66, 0xf, 0xba, 0xfa, 0x12, 0x66, 0x52, 0x66, 0x9d, 0x66, 0x9c, 0x66, 0x5a, 0xb8, 0x3, 0, 0x66, 0x33, 0xd1, 0x66, 0xc1, 0xea, 0x13, 0x73, 0x13, 0x40, 0xf6, 0xc2, 0x4, 0x74, 0xd, 0x66, 0xb8, 0x1, 0, 0, 0, 0xf, 0xa2, 0x8a, 0xc4, 0x25, 0xf, 0, 0x66, 0x9d, 0xc3}))
    II(0x00009c08, 0x2)   pushfd();                             /* pushfd  */
    II(0x00009c0a, 0x2)   pushfd();                             /* pushfd  */
    II(0x00009c0c, 0x2)   popd(edx);                            /* pop edx */
    II(0x00009c0e, 0x3)   mov(ecx, edx);                        /* mov ecx, edx */
    II(0x00009c11, 0x5)   btc(edx, 0x15);                       /* btc edx, 0x15 */
    II(0x00009c16, 0x5)   btc(edx, 0x12);                       /* btc edx, 0x12 */
    II(0x00009c1b, 0x2)   pushd(edx);                           /* push edx */
    II(0x00009c1d, 0x2)   popfd();                              /* popfd  */
    II(0x00009c1f, 0x2)   pushfd();                             /* pushfd  */
    II(0x00009c21, 0x2)   popd(edx);                            /* pop edx */
    II(0x00009c23, 0x3)   mov(ax, 0x3);                         /* mov ax, 0x3 */
    II(0x00009c26, 0x3)   xor_(edx, ecx);                       /* xor edx, ecx */
    II(0x00009c29, 0x4)   shr(edx, 0x13);                       /* shr edx, 0x13 */
    II(0x00009c2d, 0x2)   jaew(0x00009c42, 0x13);               /* jae 0x9c42 */
    II(0x00009c2f, 0x1)   inc(ax);                              /* inc ax */
    II(0x00009c30, 0x3)   test(dl, 0x4);                        /* test dl, 0x4 */
    II(0x00009c33, 0x2)   jzw(0x00009c42, 0xd);                 /* jz 0x9c42 */
    II(0x00009c35, 0x6)   mov(eax, 0x1);                        /* mov eax, 0x1 */
    II(0x00009c3b, 0x2)   cpuid();                              /* cpuid  */
    II(0x00009c3d, 0x2)   mov(al, ah);                          /* mov al, ah */
    II(0x00009c3f, 0x3)   and_(ax, 0xf);                        /* and ax, 0xf */
l_0x00009c42:
    II(0x00009c42, 0x2)   popfd();                              /* popfd  */
    II(0x00009c44, 0x1)   retw();                               /* ret  */
FUNC_END

