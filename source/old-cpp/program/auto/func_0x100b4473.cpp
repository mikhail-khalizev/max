FUNC_BEGIN(0x100b4473, 0xe436cd7183a90abc, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xd5, 0x18, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0xd6, 0x68, 0x8, 0, 0x84, 0xc0, 0x74, 0x1c, 0xe8, 0xac, 0x67, 0xfd, 0xff, 0x31, 0xdb, 0x88, 0xc3, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0xbe, 0x20, 0xfc, 0xff, 0xe8, 0xa7, 0xe4, 0x9, 0, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x17, 0xe8, 0xa9, 0x68, 0x8, 0, 0x84, 0xc0, 0x74, 0x1c, 0xe8, 0x7f, 0x67, 0xfd, 0xff, 0x31, 0xdb, 0x88, 0xc3, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x17, 0xe8, 0x91, 0x20, 0xfc, 0xff, 0xe8, 0x7a, 0xe4, 0x9, 0, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0x3b, 0x21, 0xfc, 0xff, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x17, 0xe8, 0x2e, 0x21, 0xfc, 0xff, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0xf, 0xe8, 0xd5, 0x6a, 0xfd, 0xff, 0x8b, 0x55, 0xfc, 0xb8, 0x80, 0x31, 0x1c, 0x10, 0xe8, 0xb, 0x19, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b4473, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100b4478, 0x5)   calld(sys_check_available_stack_size, 0xb18d5); /* call 0x10165d52 */
    II(0x100b447d, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b447e, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b447f, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b4480, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b4481, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b4482, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b4483, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b4485, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100b448b, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100b448e, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b4490, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b4493, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100b4496, 0x5)   calld(0x1013ad71, 0x868d6);           /* call 0x1013ad71 */
    II(0x100b449b, 0x2)   test(al, al);                         /* test al, al */
    II(0x100b449d, 0x2)   jzd(0x100b44bb, 0x1c);                /* jz 0x100b44bb */
    II(0x100b449f, 0x5)   calld(0x1008ac50, -0x29854);          /* call 0x1008ac50 */
    II(0x100b44a4, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x100b44a6, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x100b44a8, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100b44ab, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b44ae, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100b44b1, 0x5)   calld(0x10076574, -0x3df42);          /* call 0x10076574 */
    II(0x100b44b6, 0x5)   calld(0x10152962, 0x9e4a7);           /* call 0x10152962 */
l_0x100b44bb:
    II(0x100b44bb, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b44bd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b44c0, 0x3)   add(eax, 0x17);                       /* add eax, 0x17 */
    II(0x100b44c3, 0x5)   calld(0x1013ad71, 0x868a9);           /* call 0x1013ad71 */
    II(0x100b44c8, 0x2)   test(al, al);                         /* test al, al */
    II(0x100b44ca, 0x2)   jzd(0x100b44e8, 0x1c);                /* jz 0x100b44e8 */
    II(0x100b44cc, 0x5)   calld(0x1008ac50, -0x29881);          /* call 0x1008ac50 */
    II(0x100b44d1, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x100b44d3, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x100b44d5, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100b44d8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b44db, 0x3)   add(eax, 0x17);                       /* add eax, 0x17 */
    II(0x100b44de, 0x5)   calld(0x10076574, -0x3df6f);          /* call 0x10076574 */
    II(0x100b44e3, 0x5)   calld(0x10152962, 0x9e47a);           /* call 0x10152962 */
l_0x100b44e8:
    II(0x100b44e8, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b44ea, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b44ed, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100b44f0, 0x5)   calld(0x10076630, -0x3dec5);          /* call 0x10076630 */
    II(0x100b44f5, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b44f7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b44fa, 0x3)   add(eax, 0x17);                       /* add eax, 0x17 */
    II(0x100b44fd, 0x5)   calld(0x10076630, -0x3ded2);          /* call 0x10076630 */
    II(0x100b4502, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b4504, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b4507, 0x3)   add(eax, 0xf);                        /* add eax, 0xf */
    II(0x100b450a, 0x5)   calld(0x1008afe4, -0x2952b);          /* call 0x1008afe4 */
    II(0x100b450f, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100b4512, 0x5)   mov(eax, 0x101c3180);                 /* mov eax, 0x101c3180 */
    II(0x100b4517, 0x5)   calld(0x100a5e27, -0xe6f5);           /* call 0x100a5e27 */
    II(0x100b451c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b451e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b451f, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b4520, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b4521, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b4522, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b4523, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b4524, 0x1)   retd();                               /* ret */
FUNC_END

