FUNC_BEGIN(0x1013f25a, 0x483abb0a4477192d, 0x20, ({0x68, 0x2c, 0, 0, 0, 0xe8, 0xee, 0x6a, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x14, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x8b, 0, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf8, 0x83, 0x38, 0, 0x74, 0x2d, 0x8b, 0x45, 0xf8, 0x8b, 0, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0x8b, 0, 0x66, 0x8b, 0, 0x66, 0x3b, 0x45, 0xfc, 0x75, 0xa, 0x8b, 0x45, 0xf0, 0x8b, 0, 0x89, 0x45, 0xec, 0xeb, 0x1c, 0x8b, 0x45, 0xf0, 0x8b, 0x50, 0x4, 0x8b, 0x45, 0xf8, 0x89, 0x10, 0xeb, 0xcb, 0x8b, 0x45, 0xf4, 0x8b, 0x55, 0xf8, 0x89, 0x2, 0xc7, 0x45, 0xec, 0, 0, 0, 0, 0x8b, 0x45, 0xec, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013f25a, 0x5)   pushd(0x2c);                          /* push dword 0x2c */
    II(0x1013f25f, 0x5)   calld(sys_check_available_stack_size, 0x26aee); /* call 0x10165d52 */
    II(0x1013f264, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013f265, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013f266, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013f267, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013f268, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013f269, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013f26b, 0x6)   sub(esp, 0x14);                       /* sub esp, 0x14 */
    II(0x1013f271, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013f274, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x1013f277, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013f27a, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1013f27c, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
l_0x1013f27f:
    II(0x1013f27f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013f282, 0x3)   cmp(memd_a32(ds, eax), 0);            /* cmp dword [eax], 0x0 */
    II(0x1013f285, 0x2)   jzd(0x1013f2b4, 0x2d);                /* jz 0x1013f2b4 */
    II(0x1013f287, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013f28a, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1013f28c, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x1013f28f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x1013f292, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1013f294, 0x3)   mov(ax, memw_a32(ds, eax));           /* mov ax, [eax] */
    II(0x1013f297, 0x4)   cmp(ax, memw_a32(ss, ebp - 0x4));     /* cmp ax, [ebp-0x4] */
    II(0x1013f29b, 0x2)   jnzd(0x1013f2a7, 0xa);                /* jnz 0x1013f2a7 */
    II(0x1013f29d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x1013f2a0, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1013f2a2, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x1013f2a5, 0x2)   jmpd(0x1013f2c3, 0x1c);               /* jmp 0x1013f2c3 */
l_0x1013f2a7:
    II(0x1013f2a7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x1013f2aa, 0x3)   mov(edx, memd_a32(ds, eax + 0x4));    /* mov edx, [eax+0x4] */
    II(0x1013f2ad, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013f2b0, 0x2)   mov(memd_a32(ds, eax), edx);          /* mov [eax], edx */
    II(0x1013f2b2, 0x2)   jmpd(0x1013f27f, -0x35);              /* jmp 0x1013f27f */
l_0x1013f2b4:
    II(0x1013f2b4, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1013f2b7, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1013f2ba, 0x2)   mov(memd_a32(ds, edx), eax);          /* mov [edx], eax */
    II(0x1013f2bc, 0x7)   mov(memd_a32(ss, ebp - 0x14), 0);     /* mov dword [ebp-0x14], 0x0 */
l_0x1013f2c3:
    II(0x1013f2c3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x1013f2c6, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013f2c8, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013f2c9, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013f2ca, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013f2cb, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013f2cc, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013f2cd, 0x1)   retd();                               /* ret */
FUNC_END

