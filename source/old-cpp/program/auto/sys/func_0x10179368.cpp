FUNC_BEGIN(/* sys */ 0x10179368, 0xf820988aa2231b88, 0x20, ({0x52, 0x89, 0xc2, 0xb4, 0x3b, 0xcd, 0x21, 0xd1, 0xd0, 0xd1, 0xc8, 0x89, 0xc2, 0x85, 0xc0, 0x7d, 0xc, 0x31, 0xc0, 0x66, 0x89, 0xd0, 0xe8, 0x34, 0x48, 0x1, 0, 0x5a, 0xc3, 0x31, 0xc0, 0x5a, 0xc3}))
    II(0x10179368, 0x1)   pushd(edx);                           /* push edx */
    II(0x10179369, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1017936b, 0x2)   mov(ah, 0x3b);                        /* mov ah, 0x3b */
    II(0x1017936d, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x1017936f, 0x2)   rcl(eax, 0x1);                        /* rcl eax, 1 */
    II(0x10179371, 0x2)   ror(eax, 0x1);                        /* ror eax, 1 */
    II(0x10179373, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10179375, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10179377, 0x2)   jged(0x10179385, 0xc);                /* jge 0x10179385 */
    II(0x10179379, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1017937b, 0x3)   mov(ax, dx);                          /* mov ax, dx */
    II(0x1017937e, 0x5)   calld(/* sys */ 0x1018dbb7, 0x14834); /* call 0x1018dbb7 */
    II(0x10179383, 0x1)   popd(edx);                            /* pop edx */
    II(0x10179384, 0x1)   retd();                               /* ret */
l_0x10179385:
    II(0x10179385, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10179387, 0x1)   popd(edx);                            /* pop edx */
    II(0x10179388, 0x1)   retd();                               /* ret */
FUNC_END

