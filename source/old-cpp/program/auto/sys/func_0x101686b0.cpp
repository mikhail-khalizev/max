FUNC_BEGIN(/* sys */ 0x101686b0, 0xaba78e402389f53f, 0x20, ({0x56, 0x57, 0x55, 0x8b, 0x6c, 0x24, 0x30, 0x89, 0xc6, 0xe8, 0xee, 0xf6, 0xff, 0xff, 0x89, 0xc7, 0x81, 0xcd, 0, 0, 0x1, 0, 0x83, 0x3d, 0xbc, 0xdd, 0x1b, 0x10, 0, 0x74, 0x4, 0x85, 0xc0, 0x75, 0xa, 0xb8, 0xff, 0xff, 0xff, 0xff, 0xe9, 0x71, 0, 0, 0, 0x83, 0x7c, 0x24, 0x24, 0, 0x75, 0x19, 0x83, 0x7c, 0x24, 0x28, 0, 0x75, 0x7, 0x83, 0x7c, 0x24, 0x2c, 0, 0x74, 0xb, 0xb8, 0xff, 0xff, 0xff, 0xff, 0x5d, 0x5f, 0x5e, 0xc2, 0x24, 0, 0x8b, 0x44, 0x24, 0x2c, 0x50, 0x8b, 0x44, 0x24, 0x2c, 0x50, 0x8b, 0x44, 0x24, 0x2c, 0x50, 0x55, 0x8b, 0x6c, 0x24, 0x30, 0x55, 0x8b, 0x44, 0x24, 0x30, 0x50, 0x8b, 0x6c, 0x24, 0x30, 0x55, 0x8b, 0x44, 0x24, 0x30, 0x50, 0x8b, 0x6c, 0x24, 0x30, 0x55, 0x89, 0xf0, 0xe8, 0x37, 0x5, 0, 0, 0x89, 0xc6, 0x85, 0xc0, 0x75, 0xb, 0xb8, 0xff, 0xff, 0xff, 0xff, 0x5d, 0x5f, 0x5e, 0xc2, 0x24, 0, 0x6a, 0, 0x89, 0xfa, 0x8b, 0x58, 0x30, 0x31, 0xc9, 0xe8, 0x44, 0x14, 0, 0, 0x8b, 0x6, 0x5d, 0x5f, 0x5e, 0xc2, 0x24, 0}))
    II(0x101686b0, 0x1)   pushd(esi);                           /* push esi */
    II(0x101686b1, 0x1)   pushd(edi);                           /* push edi */
    II(0x101686b2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101686b3, 0x4)   mov(ebp, memd_a32(ss, esp + 0x30));   /* mov ebp, [esp+0x30] */
    II(0x101686b7, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x101686b9, 0x5)   calld(/* sys */ 0x10167dac, -0x912);  /* call 0x10167dac */
    II(0x101686be, 0x2)   mov(edi, eax);                        /* mov edi, eax */
    II(0x101686c0, 0x6)   or_(ebp, 0x10000);                    /* or ebp, 0x10000 */
    II(0x101686c6, 0x7)   cmp(memd_a32(ds, 0x101bddbc), 0);     /* cmp dword [0x101bddbc], 0x0 */
    II(0x101686cd, 0x2)   jzd(0x101686d3, 0x4);                 /* jz 0x101686d3 */
    II(0x101686cf, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x101686d1, 0x2)   jnzd(0x101686dd, 0xa);                /* jnz 0x101686dd */
l_0x101686d3:
    II(0x101686d3, 0x5)   mov(eax, 0xffffffff);                 /* mov eax, 0xffffffff */
    II(0x101686d8, 0x5)   jmpd(0x1016874e, 0x71);               /* jmp 0x1016874e */
l_0x101686dd:
    II(0x101686dd, 0x5)   cmp(memd_a32(ss, esp + 0x24), 0);     /* cmp dword [esp+0x24], 0x0 */
    II(0x101686e2, 0x2)   jnzd(0x101686fd, 0x19);               /* jnz 0x101686fd */
    II(0x101686e4, 0x5)   cmp(memd_a32(ss, esp + 0x28), 0);     /* cmp dword [esp+0x28], 0x0 */
    II(0x101686e9, 0x2)   jnzd(0x101686f2, 0x7);                /* jnz 0x101686f2 */
    II(0x101686eb, 0x5)   cmp(memd_a32(ss, esp + 0x2c), 0);     /* cmp dword [esp+0x2c], 0x0 */
    II(0x101686f0, 0x2)   jzd(0x101686fd, 0xb);                 /* jz 0x101686fd */
l_0x101686f2:
    II(0x101686f2, 0x5)   mov(eax, 0xffffffff);                 /* mov eax, 0xffffffff */
    II(0x101686f7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101686f8, 0x1)   popd(edi);                            /* pop edi */
    II(0x101686f9, 0x1)   popd(esi);                            /* pop esi */
    II(0x101686fa, 0x3)   retd(0x24);                           /* ret 0x24 */
l_0x101686fd:
    II(0x101686fd, 0x4)   mov(eax, memd_a32(ss, esp + 0x2c));   /* mov eax, [esp+0x2c] */
    II(0x10168701, 0x1)   pushd(eax);                           /* push eax */
    II(0x10168702, 0x4)   mov(eax, memd_a32(ss, esp + 0x2c));   /* mov eax, [esp+0x2c] */
    II(0x10168706, 0x1)   pushd(eax);                           /* push eax */
    II(0x10168707, 0x4)   mov(eax, memd_a32(ss, esp + 0x2c));   /* mov eax, [esp+0x2c] */
    II(0x1016870b, 0x1)   pushd(eax);                           /* push eax */
    II(0x1016870c, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1016870d, 0x4)   mov(ebp, memd_a32(ss, esp + 0x30));   /* mov ebp, [esp+0x30] */
    II(0x10168711, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10168712, 0x4)   mov(eax, memd_a32(ss, esp + 0x30));   /* mov eax, [esp+0x30] */
    II(0x10168716, 0x1)   pushd(eax);                           /* push eax */
    II(0x10168717, 0x4)   mov(ebp, memd_a32(ss, esp + 0x30));   /* mov ebp, [esp+0x30] */
    II(0x1016871b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1016871c, 0x4)   mov(eax, memd_a32(ss, esp + 0x30));   /* mov eax, [esp+0x30] */
    II(0x10168720, 0x1)   pushd(eax);                           /* push eax */
    II(0x10168721, 0x4)   mov(ebp, memd_a32(ss, esp + 0x30));   /* mov ebp, [esp+0x30] */
    II(0x10168725, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10168726, 0x2)   mov(eax, esi);                        /* mov eax, esi */
    II(0x10168728, 0x5)   calld(/* sys */ 0x10168c64, 0x537);   /* call 0x10168c64 */
    II(0x1016872d, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x1016872f, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10168731, 0x2)   jnzd(0x1016873e, 0xb);                /* jnz 0x1016873e */
    II(0x10168733, 0x5)   mov(eax, 0xffffffff);                 /* mov eax, 0xffffffff */
    II(0x10168738, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10168739, 0x1)   popd(edi);                            /* pop edi */
    II(0x1016873a, 0x1)   popd(esi);                            /* pop esi */
    II(0x1016873b, 0x3)   retd(0x24);                           /* ret 0x24 */
l_0x1016873e:
    II(0x1016873e, 0x2)   pushd(0);                             /* push 0x0 */
    II(0x10168740, 0x2)   mov(edx, edi);                        /* mov edx, edi */
    II(0x10168742, 0x3)   mov(ebx, memd_a32(ds, eax + 0x30));   /* mov ebx, [eax+0x30] */
    II(0x10168745, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x10168747, 0x5)   calld(/* sys */ 0x10169b90, 0x1444);  /* call 0x10169b90 */
    II(0x1016874c, 0x2)   mov(eax, memd_a32(ds, esi));          /* mov eax, [esi] */
l_0x1016874e:
    II(0x1016874e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1016874f, 0x1)   popd(edi);                            /* pop edi */
    II(0x10168750, 0x1)   popd(esi);                            /* pop esi */
    II(0x10168751, 0x3)   retd(0x24);                           /* ret 0x24 */
FUNC_END

