FUNC_BEGIN(0x10087d69, 0x4d69216ff47b0d25, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xdf, 0xdf, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x17, 0xe8, 0xe0, 0x2f, 0xb, 0, 0x84, 0xc0, 0x74, 0x25, 0x31, 0xdb, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x17, 0xe8, 0xcf, 0xe7, 0xfe, 0xff, 0xe8, 0xb8, 0xab, 0xc, 0, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x17, 0xe8, 0x1b, 0xe8, 0xfe, 0xff, 0xe8, 0x52, 0x37, 0x2, 0, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0xaa, 0x2f, 0xb, 0, 0x84, 0xc0, 0x74, 0x13, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0x9b, 0xe7, 0xfe, 0xff, 0xe8, 0xda, 0xa9, 0xc, 0, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0x45, 0xe8, 0xfe, 0xff, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x17, 0xe8, 0x38, 0xe8, 0xfe, 0xff, 0x8b, 0x55, 0xfc, 0xb8, 0x80, 0x31, 0x1c, 0x10, 0xe8, 0x22, 0xe0, 0x1, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10087d69, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10087d6e, 0x5)   calld(sys_check_available_stack_size, 0xddfdf); /* call 0x10165d52 */
    II(0x10087d73, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10087d74, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10087d75, 0x1)   pushd(edx);                           /* push edx */
    II(0x10087d76, 0x1)   pushd(esi);                           /* push esi */
    II(0x10087d77, 0x1)   pushd(edi);                           /* push edi */
    II(0x10087d78, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10087d79, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10087d7b, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10087d81, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10087d84, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10087d86, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10087d89, 0x3)   add(eax, 0x17);                       /* add eax, 0x17 */
    II(0x10087d8c, 0x5)   calld(0x1013ad71, 0xb2fe0);           /* call 0x1013ad71 */
    II(0x10087d91, 0x2)   test(al, al);                         /* test al, al */
    II(0x10087d93, 0x2)   jzd(0x10087dba, 0x25);                /* jz 0x10087dba */
    II(0x10087d95, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x10087d97, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x10087d9a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10087d9d, 0x3)   add(eax, 0x17);                       /* add eax, 0x17 */
    II(0x10087da0, 0x5)   calld(0x10076574, -0x11831);          /* call 0x10076574 */
    II(0x10087da5, 0x5)   calld(0x10152962, 0xcabb8);           /* call 0x10152962 */
    II(0x10087daa, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10087dad, 0x3)   add(eax, 0x17);                       /* add eax, 0x17 */
    II(0x10087db0, 0x5)   calld(0x100765d0, -0x117e5);          /* call 0x100765d0 */
    II(0x10087db5, 0x5)   calld(0x100ab50c, 0x23752);           /* call 0x100ab50c */
l_0x10087dba:
    II(0x10087dba, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10087dbc, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10087dbf, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x10087dc2, 0x5)   calld(0x1013ad71, 0xb2faa);           /* call 0x1013ad71 */
    II(0x10087dc7, 0x2)   test(al, al);                         /* test al, al */
    II(0x10087dc9, 0x2)   jzd(0x10087dde, 0x13);                /* jz 0x10087dde */
    II(0x10087dcb, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x10087dce, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10087dd1, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x10087dd4, 0x5)   calld(0x10076574, -0x11865);          /* call 0x10076574 */
    II(0x10087dd9, 0x5)   calld(0x101527b8, 0xca9da);           /* call 0x101527b8 */
l_0x10087dde:
    II(0x10087dde, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10087de0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10087de3, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x10087de6, 0x5)   calld(0x10076630, -0x117bb);          /* call 0x10076630 */
    II(0x10087deb, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10087ded, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10087df0, 0x3)   add(eax, 0x17);                       /* add eax, 0x17 */
    II(0x10087df3, 0x5)   calld(0x10076630, -0x117c8);          /* call 0x10076630 */
    II(0x10087df8, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x10087dfb, 0x5)   mov(eax, 0x101c3180);                 /* mov eax, 0x101c3180 */
    II(0x10087e00, 0x5)   calld(0x100a5e27, 0x1e022);           /* call 0x100a5e27 */
    II(0x10087e05, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10087e07, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10087e08, 0x1)   popd(edi);                            /* pop edi */
    II(0x10087e09, 0x1)   popd(esi);                            /* pop esi */
    II(0x10087e0a, 0x1)   popd(edx);                            /* pop edx */
    II(0x10087e0b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10087e0c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10087e0d, 0x1)   retd();                               /* ret */
FUNC_END

