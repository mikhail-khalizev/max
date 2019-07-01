FUNC_BEGIN(/* sys */ 0x10181002, 0xab0d512a01e188d, 0x20, ({0x53, 0x51, 0x89, 0xc3, 0x89, 0xd1, 0x8c, 0xda, 0xe8, 0x55, 0x4b, 0x1, 0, 0x85, 0xc0, 0x75, 0x9, 0x89, 0xca, 0x89, 0xd8, 0xe8, 0x79, 0xb9, 0xfe, 0xff, 0x59, 0x5b, 0xc3}))
    II(0x10181002, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10181003, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10181004, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x10181006, 0x2)   mov(ecx, edx);                        /* mov ecx, edx */
    II(0x10181008, 0x2)   mov(edx, ds);                         /* mov edx, ds */
    II(0x1018100a, 0x5)   calld(/* sys */ 0x10195b64, 0x14b55); /* call 0x10195b64 */
    II(0x1018100f, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10181011, 0x2)   jnzd(0x1018101c, 0x9);                /* jnz 0x1018101c */
    II(0x10181013, 0x2)   mov(edx, ecx);                        /* mov edx, ecx */
    II(0x10181015, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x10181017, 0x5)   calld(/* sys */ 0x1016c995, -0x14687); /* call 0x1016c995 */
l_0x1018101c:
    II(0x1018101c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1018101d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1018101e, 0x1)   retd();                               /* ret */
FUNC_END

