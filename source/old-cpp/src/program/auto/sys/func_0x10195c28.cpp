FUNC_BEGIN(/* sys */ 0x10195c28, 0x7e310227522412cc, 0x20, ({0x53, 0x51, 0x89, 0xc3, 0x89, 0xd1, 0x85, 0xd2, 0x75, 0x5, 0x31, 0xc0, 0x59, 0x5b, 0xc3, 0x8b, 0x10, 0x8b, 0x14, 0x95, 0x1c, 0xa2, 0x20, 0x10, 0xff, 0x12, 0x89, 0xc2, 0x83, 0x3b, 0x2, 0x74, 0xa, 0x89, 0xc8, 0xc1, 0xe0, 0x3, 0x83, 0xe8, 0x8, 0x1, 0xd0, 0x59, 0x5b, 0xc3}))
    II(0x10195c28, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10195c29, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10195c2a, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x10195c2c, 0x2)   mov(ecx, edx);                        /* mov ecx, edx */
    II(0x10195c2e, 0x2)   test(edx, edx);                       /* test edx, edx */
    II(0x10195c30, 0x2)   jnzd(0x10195c37, 0x5);                /* jnz 0x10195c37 */
    II(0x10195c32, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10195c34, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10195c35, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10195c36, 0x1)   retd();                               /* ret */
l_0x10195c37:
    II(0x10195c37, 0x2)   mov(edx, memd_a32(ds, eax));          /* mov edx, [eax] */
    II(0x10195c39, 0x7)   mov(edx, memd_a32(ds, edx * 0x4 + 0x1020a21c)); /* mov edx, [edx*4+0x1020a21c] */
    II(0x10195c40, 0x2)   calld_abs(memd_a32(ds, edx));         /* call dword near [edx] */
    II(0x10195c42, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10195c44, 0x3)   cmp(memd_a32(ds, ebx), 0x2);          /* cmp dword [ebx], 0x2 */
    II(0x10195c47, 0x2)   jzd(0x10195c53, 0xa);                 /* jz 0x10195c53 */
    II(0x10195c49, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x10195c4b, 0x3)   shl(eax, 0x3);                        /* shl eax, 0x3 */
    II(0x10195c4e, 0x3)   sub(eax, 0x8);                        /* sub eax, 0x8 */
    II(0x10195c51, 0x2)   add(eax, edx);                        /* add eax, edx */
l_0x10195c53:
    II(0x10195c53, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10195c54, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10195c55, 0x1)   retd();                               /* ret */
FUNC_END

