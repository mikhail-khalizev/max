FUNC_BEGIN(0x100b31cb, 0xe83592a843fb541f, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x7d, 0x2b, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0xc7, 0x40, 0x17, 0, 0, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0x7a, 0x33, 0xfc, 0xff, 0x66, 0x8b, 0x58, 0x1a, 0x8b, 0x45, 0xfc, 0x66, 0x89, 0x58, 0x19, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0x64, 0x33, 0xfc, 0xff, 0x66, 0x8b, 0x58, 0x1c, 0x8b, 0x45, 0xfc, 0x66, 0x89, 0x58, 0x1b, 0x8b, 0x45, 0xfc, 0x66, 0xc7, 0x40, 0x1d, 0x6, 0, 0x8b, 0x45, 0xfc, 0x66, 0xc7, 0x40, 0x1f, 0, 0, 0x8b, 0x45, 0xfc, 0xc6, 0x40, 0x22, 0x1, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0x35, 0x33, 0xfc, 0xff, 0xe8, 0xbc, 0xf4, 0x9, 0, 0x8d, 0x5d, 0xf8, 0x89, 0xc2, 0x89, 0xd8, 0xe8, 0x20, 0x7c, 0xfd, 0xff, 0xeb, 0x8, 0x8d, 0x45, 0xf8, 0xe8, 0x9e, 0x39, 0xfc, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xf8, 0xe8, 0xd, 0x7b, 0x8, 0, 0x84, 0xc0, 0x74, 0x36, 0x8d, 0x45, 0xf8, 0xe8, 0x54, 0x7b, 0xfd, 0xff, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x8b, 0x50, 0x2, 0x8b, 0x45, 0xf4, 0xff, 0x52, 0x20, 0x3c, 0x26, 0x75, 0x19, 0x8b, 0x55, 0xfc, 0xb8, 0x80, 0x31, 0x1c, 0x10, 0xe8, 0x97, 0x2b, 0xff, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xf8, 0xe8, 0x22, 0x59, 0xfd, 0xff, 0xeb, 0x2c, 0xeb, 0xb4, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0xc8, 0x32, 0xfc, 0xff, 0xe8, 0x3c, 0xf5, 0x9, 0, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0x41, 0xf6, 0xfe, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xf8, 0xe8, 0xf4, 0x58, 0xfd, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b31cb, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100b31d0, 0x5)   calld(sys_check_available_stack_size, 0xb2b7d); /* call 0x10165d52 */
    II(0x100b31d5, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b31d6, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b31d7, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b31d8, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b31d9, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b31da, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b31db, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b31dd, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100b31e3, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100b31e6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b31e9, 0x6)   mov(memw_a32(ds, eax + 0x17), 0);     /* mov word [eax+0x17], 0x0 */
    II(0x100b31ef, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b31f2, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100b31f5, 0x5)   calld(0x10076574, -0x3cc86);          /* call 0x10076574 */
    II(0x100b31fa, 0x4)   mov(bx, memw_a32(ds, eax + 0x1a));    /* mov bx, [eax+0x1a] */
    II(0x100b31fe, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b3201, 0x4)   mov(memw_a32(ds, eax + 0x19), bx);    /* mov [eax+0x19], bx */
    II(0x100b3205, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b3208, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100b320b, 0x5)   calld(0x10076574, -0x3cc9c);          /* call 0x10076574 */
    II(0x100b3210, 0x4)   mov(bx, memw_a32(ds, eax + 0x1c));    /* mov bx, [eax+0x1c] */
    II(0x100b3214, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b3217, 0x4)   mov(memw_a32(ds, eax + 0x1b), bx);    /* mov [eax+0x1b], bx */
    II(0x100b321b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b321e, 0x6)   mov(memw_a32(ds, eax + 0x1d), 0x6);   /* mov word [eax+0x1d], 0x6 */
    II(0x100b3224, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b3227, 0x6)   mov(memw_a32(ds, eax + 0x1f), 0);     /* mov word [eax+0x1f], 0x0 */
    II(0x100b322d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b3230, 0x4)   mov(memb_a32(ds, eax + 0x22), 0x1);   /* mov byte [eax+0x22], 0x1 */
    II(0x100b3234, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b3237, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100b323a, 0x5)   calld(0x10076574, -0x3cccb);          /* call 0x10076574 */
    II(0x100b323f, 0x5)   calld(0x10152700, 0x9f4bc);           /* call 0x10152700 */
    II(0x100b3244, 0x3)   lea(ebx, ebp - 0x8);                  /* lea ebx, [ebp-0x8] */
    II(0x100b3247, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x100b3249, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x100b324b, 0x5)   calld(0x1008ae70, -0x283e0);          /* call 0x1008ae70 */
    II(0x100b3250, 0x2)   jmpd(0x100b325a, 0x8);                /* jmp 0x100b325a */
l_0x100b3252:
    II(0x100b3252, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x100b3255, 0x5)   calld(0x10076bf8, -0x3c662);          /* call 0x10076bf8 */
l_0x100b325a:
    II(0x100b325a, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b325c, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x100b325f, 0x5)   calld(0x1013ad71, 0x87b0d);           /* call 0x1013ad71 */
    II(0x100b3264, 0x2)   test(al, al);                         /* test al, al */
    II(0x100b3266, 0x2)   jzd(0x100b329e, 0x36);                /* jz 0x100b329e */
    II(0x100b3268, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x100b326b, 0x5)   calld(0x1008adc4, -0x284ac);          /* call 0x1008adc4 */
    II(0x100b3270, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100b3273, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b3276, 0x3)   mov(edx, memd_a32(ds, eax + 0x2));    /* mov edx, [eax+0x2] */
//    II(0x100b3279, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b327c, 0x3)   calld_abs(memd_a32(ds, edx + 0x20));  /* call dword near [edx+0x20] */
    II(0x100b327f, 0x2)   cmp(al, 0x26);                        /* cmp al, 0x26 */
    II(0x100b3281, 0x2)   jnzd(0x100b329c, 0x19);               /* jnz 0x100b329c */
    II(0x100b3283, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100b3286, 0x5)   mov(eax, 0x101c3180);                 /* mov eax, 0x101c3180 */
    II(0x100b328b, 0x5)   calld(0x100a5e27, -0xd469);           /* call 0x100a5e27 */
    II(0x100b3290, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b3292, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x100b3295, 0x5)   calld(0x10088bbc, -0x2a6de);          /* call 0x10088bbc */
    II(0x100b329a, 0x2)   jmpd(0x100b32c8, 0x2c);               /* jmp 0x100b32c8 */
l_0x100b329c:
    II(0x100b329c, 0x2)   jmpd(0x100b3252, -0x4c);              /* jmp 0x100b3252 */
l_0x100b329e:
    II(0x100b329e, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100b32a1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b32a4, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100b32a7, 0x5)   calld(0x10076574, -0x3cd38);          /* call 0x10076574 */
    II(0x100b32ac, 0x5)   calld(0x101527ed, 0x9f53c);           /* call 0x101527ed */
    II(0x100b32b1, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x100b32b6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b32b9, 0x5)   calld(0x100a28ff, -0x109bf);          /* call 0x100a28ff */
    II(0x100b32be, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b32c0, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x100b32c3, 0x5)   calld(0x10088bbc, -0x2a70c);          /* call 0x10088bbc */
l_0x100b32c8:
    II(0x100b32c8, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b32ca, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b32cb, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b32cc, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b32cd, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b32ce, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b32cf, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b32d0, 0x1)   retd();                               /* ret */
FUNC_END

