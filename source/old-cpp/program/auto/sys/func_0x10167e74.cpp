FUNC_BEGIN(/* sys */ 0x10167e74, 0xd81896fe3394f040, 0x20, ({0x56, 0x57, 0xe8, 0x31, 0xff, 0xff, 0xff, 0x83, 0x3d, 0xbc, 0xdd, 0x1b, 0x10, 0, 0x74, 0x4, 0x85, 0xc0, 0x75, 0x8, 0xb8, 0xff, 0xff, 0xff, 0xff, 0x5f, 0x5e, 0xc3, 0x89, 0xd7, 0x8d, 0x70, 0x8, 0x31, 0xc0, 0xa5, 0xa5, 0xa5, 0xa5, 0x5f, 0x5e, 0xc3}))
    II(0x10167e74, 0x1)   pushd(esi);                           /* push esi */
    II(0x10167e75, 0x1)   pushd(edi);                           /* push edi */
    II(0x10167e76, 0x5)   calld(/* sys */ 0x10167dac, -0xcf);   /* call 0x10167dac */
    II(0x10167e7b, 0x7)   cmp(memd_a32(ds, 0x101bddbc), 0);     /* cmp dword [0x101bddbc], 0x0 */
    II(0x10167e82, 0x2)   jzd(0x10167e88, 0x4);                 /* jz 0x10167e88 */
    II(0x10167e84, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10167e86, 0x2)   jnzd(0x10167e90, 0x8);                /* jnz 0x10167e90 */
l_0x10167e88:
    II(0x10167e88, 0x5)   mov(eax, 0xffffffff);                 /* mov eax, 0xffffffff */
    II(0x10167e8d, 0x1)   popd(edi);                            /* pop edi */
    II(0x10167e8e, 0x1)   popd(esi);                            /* pop esi */
    II(0x10167e8f, 0x1)   retd();                               /* ret */
l_0x10167e90:
    II(0x10167e90, 0x2)   mov(edi, edx);                        /* mov edi, edx */
    II(0x10167e92, 0x3)   lea(esi, eax + 0x8);                  /* lea esi, [eax+0x8] */
    II(0x10167e95, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10167e97, 0x1)   movsd_a32();                          /* movsd */
    II(0x10167e98, 0x1)   movsd_a32();                          /* movsd */
    II(0x10167e99, 0x1)   movsd_a32();                          /* movsd */
    II(0x10167e9a, 0x1)   movsd_a32();                          /* movsd */
    II(0x10167e9b, 0x1)   popd(edi);                            /* pop edi */
    II(0x10167e9c, 0x1)   popd(esi);                            /* pop esi */
    II(0x10167e9d, 0x1)   retd();                               /* ret */
FUNC_END

