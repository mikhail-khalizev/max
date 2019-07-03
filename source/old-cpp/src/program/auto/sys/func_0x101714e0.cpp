FUNC_BEGIN(/* sys */ 0x101714e0, 0x6446eee48781b345, 0x20, ({0x53, 0x51, 0x52, 0xbb, 0xe0, 0x1, 0, 0, 0xba, 0x80, 0x2, 0, 0, 0xb8, 0x1, 0x1, 0, 0, 0x31, 0xc9, 0xe8, 0x87, 0x1, 0, 0, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101714e0, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101714e1, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101714e2, 0x1)   pushd(edx);                           /* push edx */
    II(0x101714e3, 0x5)   mov(ebx, 0x1e0);                      /* mov ebx, 0x1e0 */
    II(0x101714e8, 0x5)   mov(edx, 0x280);                      /* mov edx, 0x280 */
    II(0x101714ed, 0x5)   mov(eax, 0x101);                      /* mov eax, 0x101 */
    II(0x101714f2, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x101714f4, 0x5)   calld(/* sys */ 0x10171680, 0x187);   /* call 0x10171680 */
    II(0x101714f9, 0x1)   popd(edx);                            /* pop edx */
    II(0x101714fa, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101714fb, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101714fc, 0x1)   retd();                               /* ret */
FUNC_END

