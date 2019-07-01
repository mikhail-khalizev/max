FUNC_BEGIN(/* sys */ 0x10180fe0, 0x555443c752448744, 0x20, ({0x53, 0x51, 0x89, 0xc3, 0x89, 0xd1, 0x8c, 0xda, 0xe8, 0x77, 0x4b, 0x1, 0, 0x85, 0xc0, 0x75, 0x9, 0x89, 0xca, 0x89, 0xd8, 0xe8, 0x3, 0, 0, 0, 0x59, 0x5b, 0xc3}))
    II(0x10180fe0, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10180fe1, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10180fe2, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x10180fe4, 0x2)   mov(ecx, edx);                        /* mov ecx, edx */
    II(0x10180fe6, 0x2)   mov(edx, ds);                         /* mov edx, ds */
    II(0x10180fe8, 0x5)   calld(/* sys */ 0x10195b64, 0x14b77); /* call 0x10195b64 */
    II(0x10180fed, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10180fef, 0x2)   jnzd(0x10180ffa, 0x9);                /* jnz 0x10180ffa */
    II(0x10180ff1, 0x2)   mov(edx, ecx);                        /* mov edx, ecx */
    II(0x10180ff3, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x10180ff5, 0x5)   calld(/* sys */ 0x10180ffd, 0x3);     /* call 0x10180ffd */
l_0x10180ffa:
    II(0x10180ffa, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10180ffb, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10180ffc, 0x1)   retd();                               /* ret */
FUNC_END

