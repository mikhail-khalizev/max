FUNC_BEGIN(0x1013a4eb, 0x4742469b7140d8b5, 0x20, ({0x68, 0x34, 0, 0, 0, 0xe8, 0x5d, 0xb8, 0x2, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x20, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xfc, 0x83, 0x7d, 0xf8, 0, 0x75, 0x10, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf4, 0xe8, 0x4e, 0xfe, 0xff, 0xff, 0xe9, 0x88, 0, 0, 0, 0xb8, 0x12, 0, 0, 0, 0xe8, 0xd6, 0xb8, 0x2, 0, 0x89, 0x45, 0xec, 0x8b, 0x45, 0xec, 0x89, 0x45, 0xe8, 0x83, 0x7d, 0xe8, 0, 0x74, 0x16, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xec, 0xe8, 0x70, 0xf9, 0xff, 0xff, 0x89, 0x45, 0xe4, 0x8b, 0x45, 0xe4, 0x89, 0x45, 0xf0, 0xeb, 0x6, 0x8b, 0x45, 0xe8, 0x89, 0x45, 0xf0, 0x8b, 0x55, 0xf0, 0x8d, 0x45, 0xe0, 0xe8, 0xb4, 0xc7, 0xf3, 0xff, 0x8b, 0x45, 0xf4, 0x66, 0xff, 0, 0x8d, 0x45, 0xe0, 0xe8, 0xfa, 0xc6, 0xf3, 0xff, 0x8b, 0x5d, 0xf8, 0x89, 0xc2, 0x89, 0xd8, 0xe8, 0xcb, 0xf9, 0xff, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xe0, 0xe8, 0xb8, 0x4, 0, 0, 0x83, 0xc0, 0xa, 0xe8, 0x85, 0x7, 0, 0, 0x84, 0xc0, 0x74, 0xe, 0x8d, 0x55, 0xe0, 0x8b, 0x45, 0xf4, 0x83, 0xc0, 0x6, 0xe8, 0xd2, 0x4, 0, 0, 0x31, 0xd2, 0x8d, 0x45, 0xe0, 0xe8, 0x7c, 0xb8, 0xf3, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x1013a4eb, 0x5)   pushd(0x34);                          /* push dword 0x34 */
    II(0x1013a4f0, 0x5)   calld(sys_check_available_stack_size, 0x2b85d); /* call 0x10165d52 */
    II(0x1013a4f5, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013a4f6, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013a4f7, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013a4f8, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013a4f9, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013a4fb, 0x6)   sub(esp, 0x20);                       /* sub esp, 0x20 */
    II(0x1013a501, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x1013a504, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x1013a507, 0x3)   mov(memd_a32(ss, ebp - 0x4), ebx);    /* mov [ebp-0x4], ebx */
    II(0x1013a50a, 0x4)   cmp(memd_a32(ss, ebp - 0x8), 0);      /* cmp dword [ebp-0x8], 0x0 */
    II(0x1013a50e, 0x2)   jnzd(0x1013a520, 0x10);               /* jnz 0x1013a520 */
    II(0x1013a510, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1013a513, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1013a516, 0x5)   calld(0x1013a369, -0x1b2);            /* call 0x1013a369 */
    II(0x1013a51b, 0x5)   jmpd(0x1013a5a8, 0x88);               /* jmp 0x1013a5a8 */
l_0x1013a520:
    II(0x1013a520, 0x5)   mov(eax, 0x12);                       /* mov eax, 0x12 */
    II(0x1013a525, 0x5)   calld(sys_new, 0x2b8d6);              /* call 0x10165e00 */
    II(0x1013a52a, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
//    II(0x1013a52d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x1013a530, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
    II(0x1013a533, 0x4)   cmp(memd_a32(ss, ebp - 0x18), 0);     /* cmp dword [ebp-0x18], 0x0 */
    II(0x1013a537, 0x2)   jzd(0x1013a54f, 0x16);                /* jz 0x1013a54f */
    II(0x1013a539, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1013a53c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x1013a53f, 0x5)   calld(0x10139eb4, -0x690);            /* call 0x10139eb4 */
    II(0x1013a544, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
//    II(0x1013a547, 0x3)   mov(eax, memd_a32(ss, ebp - 0x1c));   /* mov eax, [ebp-0x1c] */
    II(0x1013a54a, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x1013a54d, 0x2)   jmpd(0x1013a555, 0x6);                /* jmp 0x1013a555 */
l_0x1013a54f:
    II(0x1013a54f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x1013a552, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
l_0x1013a555:
    II(0x1013a555, 0x3)   mov(edx, memd_a32(ss, ebp - 0x10));   /* mov edx, [ebp-0x10] */
    II(0x1013a558, 0x3)   lea(eax, ebp - 0x20);                 /* lea eax, [ebp-0x20] */
    II(0x1013a55b, 0x5)   calld(0x10076d14, -0xc384c);          /* call 0x10076d14 */
    II(0x1013a560, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1013a563, 0x3)   inc(memw_a32(ds, eax));               /* inc word [eax] */
    II(0x1013a566, 0x3)   lea(eax, ebp - 0x20);                 /* lea eax, [ebp-0x20] */
    II(0x1013a569, 0x5)   calld(0x10076c68, -0xc3906);          /* call 0x10076c68 */
    II(0x1013a56e, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x1013a571, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1013a573, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x1013a575, 0x5)   calld(0x10139f45, -0x635);            /* call 0x10139f45 */
    II(0x1013a57a, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1013a57c, 0x3)   lea(eax, ebp - 0x20);                 /* lea eax, [ebp-0x20] */
    II(0x1013a57f, 0x5)   calld(0x1013aa3c, 0x4b8);             /* call 0x1013aa3c */
    II(0x1013a584, 0x3)   add(eax, 0xa);                        /* add eax, 0xa */
    II(0x1013a587, 0x5)   calld(0x1013ad11, 0x785);             /* call 0x1013ad11 */
    II(0x1013a58c, 0x2)   test(al, al);                         /* test al, al */
    II(0x1013a58e, 0x2)   jzd(0x1013a59e, 0xe);                 /* jz 0x1013a59e */
    II(0x1013a590, 0x3)   lea(edx, ebp - 0x20);                 /* lea edx, [ebp-0x20] */
    II(0x1013a593, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1013a596, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x1013a599, 0x5)   calld(0x1013aa70, 0x4d2);             /* call 0x1013aa70 */
l_0x1013a59e:
    II(0x1013a59e, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1013a5a0, 0x3)   lea(eax, ebp - 0x20);                 /* lea eax, [ebp-0x20] */
    II(0x1013a5a3, 0x5)   calld(0x10075e24, -0xc4784);          /* call 0x10075e24 */
l_0x1013a5a8:
    II(0x1013a5a8, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013a5aa, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013a5ab, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013a5ac, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013a5ad, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013a5ae, 0x1)   retd();                               /* ret */
FUNC_END

