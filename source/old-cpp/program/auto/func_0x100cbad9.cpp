FUNC_BEGIN(0x100cbad9, 0x7c0c1117280e47d6, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x6f, 0xa2, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0x70, 0xf2, 0x6, 0, 0x84, 0xc0, 0x74, 0x1c, 0xe8, 0x46, 0xf1, 0xfb, 0xff, 0x31, 0xdb, 0x88, 0xc3, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0x58, 0xaa, 0xfa, 0xff, 0xe8, 0x41, 0x6e, 0x8, 0, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x17, 0xe8, 0x43, 0xf2, 0x6, 0, 0x84, 0xc0, 0x74, 0x1c, 0xe8, 0x19, 0xf1, 0xfb, 0xff, 0x31, 0xdb, 0x88, 0xc3, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x17, 0xe8, 0x2b, 0xaa, 0xfa, 0xff, 0xe8, 0x14, 0x6e, 0x8, 0, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0xd5, 0xaa, 0xfa, 0xff, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x17, 0xe8, 0xc8, 0xaa, 0xfa, 0xff, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0xf, 0xe8, 0x6f, 0xf4, 0xfb, 0xff, 0x8b, 0x55, 0xfc, 0xb8, 0x80, 0x31, 0x1c, 0x10, 0xe8, 0xa5, 0xa2, 0xfd, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cbad9, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100cbade, 0x5)   calld(sys_check_available_stack_size, 0x9a26f); /* call 0x10165d52 */
    II(0x100cbae3, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cbae4, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cbae5, 0x1)   pushd(edx);                           /* push edx */
    II(0x100cbae6, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cbae7, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cbae8, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cbae9, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cbaeb, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100cbaf1, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100cbaf4, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100cbaf6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cbaf9, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100cbafc, 0x5)   calld(0x1013ad71, 0x6f270);           /* call 0x1013ad71 */
    II(0x100cbb01, 0x2)   test(al, al);                         /* test al, al */
    II(0x100cbb03, 0x2)   jzd(0x100cbb21, 0x1c);                /* jz 0x100cbb21 */
    II(0x100cbb05, 0x5)   calld(0x1008ac50, -0x40eba);          /* call 0x1008ac50 */
    II(0x100cbb0a, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x100cbb0c, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x100cbb0e, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100cbb11, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cbb14, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100cbb17, 0x5)   calld(0x10076574, -0x555a8);          /* call 0x10076574 */
    II(0x100cbb1c, 0x5)   calld(0x10152962, 0x86e41);           /* call 0x10152962 */
l_0x100cbb21:
    II(0x100cbb21, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100cbb23, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cbb26, 0x3)   add(eax, 0x17);                       /* add eax, 0x17 */
    II(0x100cbb29, 0x5)   calld(0x1013ad71, 0x6f243);           /* call 0x1013ad71 */
    II(0x100cbb2e, 0x2)   test(al, al);                         /* test al, al */
    II(0x100cbb30, 0x2)   jzd(0x100cbb4e, 0x1c);                /* jz 0x100cbb4e */
    II(0x100cbb32, 0x5)   calld(0x1008ac50, -0x40ee7);          /* call 0x1008ac50 */
    II(0x100cbb37, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x100cbb39, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x100cbb3b, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100cbb3e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cbb41, 0x3)   add(eax, 0x17);                       /* add eax, 0x17 */
    II(0x100cbb44, 0x5)   calld(0x10076574, -0x555d5);          /* call 0x10076574 */
    II(0x100cbb49, 0x5)   calld(0x10152962, 0x86e14);           /* call 0x10152962 */
l_0x100cbb4e:
    II(0x100cbb4e, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100cbb50, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cbb53, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100cbb56, 0x5)   calld(0x10076630, -0x5552b);          /* call 0x10076630 */
    II(0x100cbb5b, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100cbb5d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cbb60, 0x3)   add(eax, 0x17);                       /* add eax, 0x17 */
    II(0x100cbb63, 0x5)   calld(0x10076630, -0x55538);          /* call 0x10076630 */
    II(0x100cbb68, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100cbb6a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cbb6d, 0x3)   add(eax, 0xf);                        /* add eax, 0xf */
    II(0x100cbb70, 0x5)   calld(0x1008afe4, -0x40b91);          /* call 0x1008afe4 */
    II(0x100cbb75, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100cbb78, 0x5)   mov(eax, 0x101c3180);                 /* mov eax, 0x101c3180 */
    II(0x100cbb7d, 0x5)   calld(0x100a5e27, -0x25d5b);          /* call 0x100a5e27 */
    II(0x100cbb82, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cbb84, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cbb85, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cbb86, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cbb87, 0x1)   popd(edx);                            /* pop edx */
    II(0x100cbb88, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cbb89, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cbb8a, 0x1)   retd();                               /* ret */
FUNC_END

