FUNC_BEGIN(0x1013a369, 0x6d813d6ef412dc9f, 0x20, ({0x68, 0x34, 0, 0, 0, 0xe8, 0xdf, 0xb9, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x1c, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xb8, 0x12, 0, 0, 0, 0xe8, 0x70, 0xba, 0x2, 0, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0x89, 0x45, 0xec, 0x83, 0x7d, 0xec, 0, 0x74, 0x16, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf0, 0xe8, 0xa, 0xfb, 0xff, 0xff, 0x89, 0x45, 0xe8, 0x8b, 0x45, 0xe8, 0x89, 0x45, 0xf4, 0xeb, 0x6, 0x8b, 0x45, 0xec, 0x89, 0x45, 0xf4, 0x8b, 0x55, 0xf4, 0x8d, 0x45, 0xe4, 0xe8, 0x4e, 0xc9, 0xf3, 0xff, 0x8b, 0x45, 0xf8, 0x66, 0xff, 0, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x2, 0xe8, 0x38, 0x9, 0, 0, 0x84, 0xc0, 0x74, 0x10, 0x8d, 0x55, 0xe4, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x6, 0xe8, 0x85, 0x6, 0, 0, 0xeb, 0x1a, 0x8d, 0x45, 0xe4, 0xe8, 0x73, 0xc8, 0xf3, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x2, 0xe8, 0x3a, 0x6, 0, 0, 0xe8, 0xb7, 0xfb, 0xff, 0xff, 0x8d, 0x55, 0xe4, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x2, 0xe8, 0x5b, 0x6, 0, 0, 0x31, 0xd2, 0x8d, 0x45, 0xe4, 0xe8, 0x5, 0xba, 0xf3, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013a369, 0x5)   pushd(0x34);                          /* push dword 0x34 */
    II(0x1013a36e, 0x5)   calld(sys_check_available_stack_size, 0x2b9df); /* call 0x10165d52 */
    II(0x1013a373, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013a374, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013a375, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013a376, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013a377, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013a378, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013a37a, 0x6)   sub(esp, 0x1c);                       /* sub esp, 0x1c */
    II(0x1013a380, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013a383, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1013a386, 0x5)   mov(eax, 0x12);                       /* mov eax, 0x12 */
    II(0x1013a38b, 0x5)   calld(sys_new, 0x2ba70);              /* call 0x10165e00 */
    II(0x1013a390, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x1013a393, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x1013a396, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x1013a399, 0x4)   cmp(memd_a32(ss, ebp - 0x14), 0);     /* cmp dword [ebp-0x14], 0x0 */
    II(0x1013a39d, 0x2)   jzd(0x1013a3b5, 0x16);                /* jz 0x1013a3b5 */
    II(0x1013a39f, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1013a3a2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x1013a3a5, 0x5)   calld(0x10139eb4, -0x4f6);            /* call 0x10139eb4 */
    II(0x1013a3aa, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
//    II(0x1013a3ad, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x1013a3b0, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x1013a3b3, 0x2)   jmpd(0x1013a3bb, 0x6);                /* jmp 0x1013a3bb */
l_0x1013a3b5:
    II(0x1013a3b5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x1013a3b8, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
l_0x1013a3bb:
    II(0x1013a3bb, 0x3)   mov(edx, memd_a32(ss, ebp - 0xc));    /* mov edx, [ebp-0xc] */
    II(0x1013a3be, 0x3)   lea(eax, ebp - 0x1c);                 /* lea eax, [ebp-0x1c] */
    II(0x1013a3c1, 0x5)   calld(0x10076d14, -0xc36b2);          /* call 0x10076d14 */
    II(0x1013a3c6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013a3c9, 0x3)   inc(memw_a32(ds, eax));               /* inc word [eax] */
    II(0x1013a3cc, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1013a3ce, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013a3d1, 0x3)   add(eax, 0x2);                        /* add eax, 0x2 */
    II(0x1013a3d4, 0x5)   calld(0x1013ad11, 0x938);             /* call 0x1013ad11 */
    II(0x1013a3d9, 0x2)   test(al, al);                         /* test al, al */
    II(0x1013a3db, 0x2)   jzd(0x1013a3ed, 0x10);                /* jz 0x1013a3ed */
    II(0x1013a3dd, 0x3)   lea(edx, ebp - 0x1c);                 /* lea edx, [ebp-0x1c] */
    II(0x1013a3e0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013a3e3, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x1013a3e6, 0x5)   calld(0x1013aa70, 0x685);             /* call 0x1013aa70 */
    II(0x1013a3eb, 0x2)   jmpd(0x1013a407, 0x1a);               /* jmp 0x1013a407 */
l_0x1013a3ed:
    II(0x1013a3ed, 0x3)   lea(eax, ebp - 0x1c);                 /* lea eax, [ebp-0x1c] */
    II(0x1013a3f0, 0x5)   calld(0x10076c68, -0xc378d);          /* call 0x10076c68 */
    II(0x1013a3f5, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1013a3f7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013a3fa, 0x3)   add(eax, 0x2);                        /* add eax, 0x2 */
    II(0x1013a3fd, 0x5)   calld(0x1013aa3c, 0x63a);             /* call 0x1013aa3c */
    II(0x1013a402, 0x5)   calld(0x10139fbe, -0x449);            /* call 0x10139fbe */
l_0x1013a407:
    II(0x1013a407, 0x3)   lea(edx, ebp - 0x1c);                 /* lea edx, [ebp-0x1c] */
    II(0x1013a40a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013a40d, 0x3)   add(eax, 0x2);                        /* add eax, 0x2 */
    II(0x1013a410, 0x5)   calld(0x1013aa70, 0x65b);             /* call 0x1013aa70 */
    II(0x1013a415, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1013a417, 0x3)   lea(eax, ebp - 0x1c);                 /* lea eax, [ebp-0x1c] */
    II(0x1013a41a, 0x5)   calld(0x10075e24, -0xc45fb);          /* call 0x10075e24 */
    II(0x1013a41f, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013a421, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013a422, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013a423, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013a424, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013a425, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013a426, 0x1)   retd();                               /* ret */
FUNC_END

