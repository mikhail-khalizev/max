FUNC_BEGIN(0x10108905, 0xb915a5fbad96d85f, 0x20, ({0x68, 0x34, 0, 0, 0, 0xe8, 0x43, 0xd4, 0x5, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x1c, 0, 0, 0, 0x88, 0x45, 0xf8, 0x88, 0x55, 0xfc, 0x31, 0xc0, 0xa0, 0xc, 0x3d, 0x1c, 0x10, 0x83, 0xe8, 0x40, 0x89, 0x45, 0xf4, 0x8d, 0x45, 0xf0, 0xe8, 0xf9, 0x8, 0x7, 0, 0x8d, 0x55, 0xec, 0x8b, 0x45, 0xf4, 0xe8, 0x2, 0x9, 0x7, 0, 0x8d, 0x45, 0xe8, 0xe8, 0xe6, 0x8, 0x7, 0, 0x8b, 0x45, 0xe8, 0x3b, 0x45, 0xf4, 0x75, 0x28, 0xb8, 0xc, 0x3d, 0x1c, 0x10, 0xe8, 0xc, 0xa, 0x7, 0, 0x85, 0xc0, 0x75, 0x1a, 0x80, 0x7d, 0xfc, 0, 0x74, 0xb, 0x8d, 0x55, 0xec, 0x8b, 0x45, 0xf0, 0xe8, 0xd3, 0x8, 0x7, 0, 0xc7, 0x45, 0xe4, 0x1, 0, 0, 0, 0xeb, 0x2b, 0x80, 0x7d, 0xf8, 0, 0x74, 0x13, 0xba, 0x1, 0, 0, 0, 0xb8, 0x40, 0x45, 0x1a, 0x10, 0xe8, 0xa7, 0xe6, 0, 0, 0x85, 0xc0, 0x75, 0xb7, 0x8d, 0x55, 0xec, 0x8b, 0x45, 0xf0, 0xe8, 0xa6, 0x8, 0x7, 0, 0xc7, 0x45, 0xe4, 0, 0, 0, 0, 0x8b, 0x45, 0xe4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10108905, 0x5)   pushd(0x34);                          /* push dword 0x34 */
    II(0x1010890a, 0x5)   calld(sys_check_available_stack_size, 0x5d443); /* call 0x10165d52 */
    II(0x1010890f, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10108910, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10108911, 0x1)   pushd(esi);                           /* push esi */
    II(0x10108912, 0x1)   pushd(edi);                           /* push edi */
    II(0x10108913, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10108914, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10108916, 0x6)   sub(esp, 0x1c);                       /* sub esp, 0x1c */
    II(0x1010891c, 0x3)   mov(memb_a32(ss, ebp - 0x8), al);     /* mov [ebp-0x8], al */
    II(0x1010891f, 0x3)   mov(memb_a32(ss, ebp - 0x4), dl);     /* mov [ebp-0x4], dl */
    II(0x10108922, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10108924, 0x5)   mov(al, memb_a32(ds, 0x101c3d0c));    /* mov al, [0x101c3d0c] */
    II(0x10108929, 0x3)   sub(eax, 0x40);                       /* sub eax, 0x40 */
    II(0x1010892c, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x1010892f, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x10108932, 0x5)   calld(/* sys */ 0x10179230, 0x708f9); /* call 0x10179230 */
    II(0x10108937, 0x3)   lea(edx, ebp - 0x14);                 /* lea edx, [ebp-0x14] */
    II(0x1010893a, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1010893d, 0x5)   calld(/* sys */ 0x10179244, 0x70902); /* call 0x10179244 */
    II(0x10108942, 0x3)   lea(eax, ebp - 0x18);                 /* lea eax, [ebp-0x18] */
    II(0x10108945, 0x5)   calld(/* sys */ 0x10179230, 0x708e6); /* call 0x10179230 */
l_0x1010894a:
    II(0x1010894a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x1010894d, 0x3)   cmp(eax, memd_a32(ss, ebp - 0xc));    /* cmp eax, [ebp-0xc] */
    II(0x10108950, 0x2)   jnzd(0x1010897a, 0x28);               /* jnz 0x1010897a */
    II(0x10108952, 0x5)   mov(eax, 0x101c3d0c);                 /* mov eax, 0x101c3d0c */
    II(0x10108957, 0x5)   calld(/* sys */ 0x10179368, 0x70a0c); /* call 0x10179368 */
    II(0x1010895c, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1010895e, 0x2)   jnzd(0x1010897a, 0x1a);               /* jnz 0x1010897a */
    II(0x10108960, 0x4)   cmp(memb_a32(ss, ebp - 0x4), 0);      /* cmp byte [ebp-0x4], 0x0 */
    II(0x10108964, 0x2)   jzd(0x10108971, 0xb);                 /* jz 0x10108971 */
    II(0x10108966, 0x3)   lea(edx, ebp - 0x14);                 /* lea edx, [ebp-0x14] */
    II(0x10108969, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x1010896c, 0x5)   calld(/* sys */ 0x10179244, 0x708d3); /* call 0x10179244 */
l_0x10108971:
    II(0x10108971, 0x7)   mov(memd_a32(ss, ebp - 0x1c), 0x1);   /* mov dword [ebp-0x1c], 0x1 */
    II(0x10108978, 0x2)   jmpd(0x101089a5, 0x2b);               /* jmp 0x101089a5 */
l_0x1010897a:
    II(0x1010897a, 0x4)   cmp(memb_a32(ss, ebp - 0x8), 0);      /* cmp byte [ebp-0x8], 0x0 */
    II(0x1010897e, 0x2)   jzd(0x10108993, 0x13);                /* jz 0x10108993 */
    II(0x10108980, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x10108985, 0x5)   mov(eax, 0x101a4540);                 /* mov eax, 0x101a4540 */ /* "\nPlease insert the M.A.X. CD and try again.\n\n" */
    II(0x1010898a, 0x5)   calld(0x10117036, 0xe6a7);            /* call 0x10117036 */
    II(0x1010898f, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10108991, 0x2)   jnzd(0x1010894a, -0x49);              /* jnz 0x1010894a */
l_0x10108993:
    II(0x10108993, 0x3)   lea(edx, ebp - 0x14);                 /* lea edx, [ebp-0x14] */
    II(0x10108996, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10108999, 0x5)   calld(/* sys */ 0x10179244, 0x708a6); /* call 0x10179244 */
    II(0x1010899e, 0x7)   mov(memd_a32(ss, ebp - 0x1c), 0);     /* mov dword [ebp-0x1c], 0x0 */
l_0x101089a5:
    II(0x101089a5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x1c));   /* mov eax, [ebp-0x1c] */
    II(0x101089a8, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101089aa, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101089ab, 0x1)   popd(edi);                            /* pop edi */
    II(0x101089ac, 0x1)   popd(esi);                            /* pop esi */
    II(0x101089ad, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101089ae, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101089af, 0x1)   retd();                               /* ret */
FUNC_END

