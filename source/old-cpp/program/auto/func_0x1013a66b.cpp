FUNC_BEGIN(0x1013a66b, 0x8f2e780737f57069, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xdd, 0xb6, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x87, 0xfb, 0xff, 0xff, 0x8d, 0x5d, 0xf0, 0x89, 0xc2, 0x89, 0xd8, 0xe8, 0x75, 0xc6, 0xf3, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xf0, 0xe8, 0x68, 0x6, 0, 0, 0x84, 0xc0, 0x74, 0x10, 0xc6, 0x45, 0xf4, 0, 0x31, 0xd2, 0x8d, 0x45, 0xf0, 0xe8, 0x69, 0xb7, 0xf3, 0xff, 0xeb, 0x2c, 0x8d, 0x45, 0xf0, 0xe8, 0xa3, 0xc5, 0xf3, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xf8, 0xe8, 0xe0, 0xfe, 0xff, 0xff, 0xc6, 0x45, 0xf4, 0x1, 0x31, 0xd2, 0x8d, 0x45, 0xf0, 0xe8, 0x47, 0xb7, 0xf3, 0xff, 0xeb, 0xa, 0x31, 0xd2, 0x8d, 0x45, 0xf0, 0xe8, 0x3b, 0xb7, 0xf3, 0xff, 0x8a, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013a66b, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1013a670, 0x5)   calld(sys_check_available_stack_size, 0x2b6dd); /* call 0x10165d52 */
    II(0x1013a675, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013a676, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013a677, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013a678, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013a679, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013a67a, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013a67c, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x1013a682, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013a685, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x1013a688, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x1013a68b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013a68e, 0x5)   calld(0x1013a21a, -0x479);            /* call 0x1013a21a */
    II(0x1013a693, 0x3)   lea(ebx, ebp - 0x10);                 /* lea ebx, [ebp-0x10] */
    II(0x1013a696, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1013a698, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x1013a69a, 0x5)   calld(0x10076d14, -0xc398b);          /* call 0x10076d14 */
    II(0x1013a69f, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1013a6a1, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x1013a6a4, 0x5)   calld(0x1013ad11, 0x668);             /* call 0x1013ad11 */
    II(0x1013a6a9, 0x2)   test(al, al);                         /* test al, al */
    II(0x1013a6ab, 0x2)   jzd(0x1013a6bd, 0x10);                /* jz 0x1013a6bd */
    II(0x1013a6ad, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
    II(0x1013a6b1, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1013a6b3, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x1013a6b6, 0x5)   calld(0x10075e24, -0xc4897);          /* call 0x10075e24 */
    II(0x1013a6bb, 0x2)   jmpd(0x1013a6e9, 0x2c);               /* jmp 0x1013a6e9 */
l_0x1013a6bd:
    II(0x1013a6bd, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x1013a6c0, 0x5)   calld(0x10076c68, -0xc3a5d);          /* call 0x10076c68 */
    II(0x1013a6c5, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1013a6c7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013a6ca, 0x5)   calld(0x1013a5af, -0x120);            /* call 0x1013a5af */
    II(0x1013a6cf, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0x1);    /* mov byte [ebp-0xc], 0x1 */
    II(0x1013a6d3, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1013a6d5, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x1013a6d8, 0x5)   calld(0x10075e24, -0xc48b9);          /* call 0x10075e24 */
    II(0x1013a6dd, 0x2)   jmpd(0x1013a6e9, 0xa);                /* jmp 0x1013a6e9 */
//  II(0x1013a6df, 0xa)   /* Недостижимый код. */
l_0x1013a6e9:
    II(0x1013a6e9, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x1013a6ec, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013a6ee, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013a6ef, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013a6f0, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013a6f1, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013a6f2, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013a6f3, 0x1)   retd();                               /* ret */
FUNC_END

