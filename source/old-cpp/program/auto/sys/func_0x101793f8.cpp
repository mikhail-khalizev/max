FUNC_BEGIN(/* sys */ 0x101793f8, 0xd97e8326b4870342, 0x20, ({0x51, 0x89, 0xd1, 0x83, 0xfb, 0xa, 0x75, 0xa, 0x85, 0xc0, 0x7d, 0x6, 0xf7, 0xd8, 0xc6, 0x2, 0x2d, 0x42, 0xe8, 0x9f, 0xff, 0xff, 0xff, 0x89, 0xc8, 0x59, 0xc3}))
    II(0x101793f8, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101793f9, 0x2)   mov(ecx, edx);                        /* mov ecx, edx */
    II(0x101793fb, 0x3)   cmp(ebx, 0xa);                        /* cmp ebx, 0xa */
    II(0x101793fe, 0x2)   jnzd(0x1017940a, 0xa);                /* jnz 0x1017940a */
    II(0x10179400, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10179402, 0x2)   jged(0x1017940a, 0x6);                /* jge 0x1017940a */
    II(0x10179404, 0x2)   neg(eax);                             /* neg eax */
    II(0x10179406, 0x3)   mov(memb_a32(ds, edx), 0x2d);         /* mov byte [edx], 0x2d */
    II(0x10179409, 0x1)   inc(edx);                             /* inc edx */
l_0x1017940a:
    II(0x1017940a, 0x5)   calld(/* sys */ 0x101793ae, -0x61);   /* call 0x101793ae */
    II(0x1017940f, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x10179411, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10179412, 0x1)   retd();                               /* ret */
FUNC_END

