FUNC_BEGIN(0x100b58fa, 0x102420fbdf70301d, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x4e, 0x4, 0xb, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xf8, 0x83, 0xc2, 0x13, 0x8b, 0x45, 0xfc, 0xe8, 0x73, 0x14, 0xfc, 0xff, 0x84, 0xc0, 0x74, 0x1a, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x13, 0xe8, 0xfa, 0xc, 0xfc, 0xff, 0x8b, 0x55, 0xf8, 0xb8, 0x80, 0x31, 0x1c, 0x10, 0xe8, 0xe4, 0x4, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100b58fa, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100b58ff, 0x5)   calld(sys_check_available_stack_size, 0xb044e); /* call 0x10165d52 */
    II(0x100b5904, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b5905, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b5906, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b5907, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b5908, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b5909, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b590b, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b5911, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100b5914, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100b5917, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100b591a, 0x3)   add(edx, 0x13);                       /* add edx, 0x13 */
    II(0x100b591d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b5920, 0x5)   calld(0x10076d98, -0x3eb8d);          /* call 0x10076d98 */
    II(0x100b5925, 0x2)   test(al, al);                         /* test al, al */
    II(0x100b5927, 0x2)   jzd(0x100b5943, 0x1a);                /* jz 0x100b5943 */
    II(0x100b5929, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b592b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b592e, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100b5931, 0x5)   calld(0x10076630, -0x3f306);          /* call 0x10076630 */
    II(0x100b5936, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100b5939, 0x5)   mov(eax, 0x101c3180);                 /* mov eax, 0x101c3180 */
    II(0x100b593e, 0x5)   calld(0x100a5e27, -0xfb1c);           /* call 0x100a5e27 */
l_0x100b5943:
    II(0x100b5943, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b5945, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b5946, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b5947, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b5948, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b5949, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b594a, 0x1)   retd();                               /* ret */
FUNC_END

