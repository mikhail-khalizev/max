FUNC_BEGIN(0x10107903, 0xc8c4cb0e9cb339fa, 0x20, ({0x68, 0x54, 0, 0, 0, 0xe8, 0x45, 0xe4, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x38, 0, 0, 0, 0x80, 0x3d, 0x96, 0x4d, 0x1c, 0x10, 0, 0x74, 0x35, 0xc6, 0x5, 0x96, 0x4d, 0x1c, 0x10, 0, 0xbb, 0x32, 0, 0, 0, 0x31, 0xd2, 0x8d, 0x45, 0xcc, 0xe8, 0xa6, 0xe4, 0x5, 0, 0x31, 0xc0, 0x66, 0xa1, 0x94, 0x4d, 0x1c, 0x10, 0x89, 0x45, 0xe0, 0xc7, 0x45, 0xdc, 0x1, 0, 0, 0, 0x8d, 0x55, 0xcc, 0xb8, 0x7a, 0, 0, 0, 0xe8, 0x61, 0xcb, 0xfd, 0xff, 0xba, 0xc0, 0x4e, 0, 0, 0xa1, 0xac, 0x4d, 0x1c, 0x10, 0xe8, 0xe4, 0xcc, 0xfd, 0xff, 0x31, 0xc0, 0x66, 0xa1, 0xb4, 0x4d, 0x1c, 0x10, 0xe8, 0xf2, 0xca, 0xfd, 0xff, 0x80, 0x3d, 0x97, 0x4d, 0x1c, 0x10, 0, 0x74, 0x45, 0xc6, 0x45, 0xc8, 0, 0xeb, 0x6, 0x8a, 0x45, 0xc8, 0xfe, 0x45, 0xc8, 0x31, 0xc0, 0x8a, 0x45, 0xc8, 0x83, 0xf8, 0x4, 0x7d, 0x28, 0x31, 0xc0, 0x8a, 0x45, 0xc8, 0xc1, 0xe0, 0x2, 0x8b, 0x80, 0x40, 0x41, 0x1c, 0x10, 0xe8, 0x1a, 0x37, 0x6, 0, 0x31, 0xc0, 0x8a, 0x45, 0xc8, 0xc1, 0xe0, 0x2, 0x8b, 0x80, 0x50, 0x41, 0x1c, 0x10, 0xe8, 0x7, 0x37, 0x6, 0, 0xeb, 0xc8, 0xc6, 0x5, 0x97, 0x4d, 0x1c, 0x10, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10107903, 0x5)   pushd(0x54);                          /* push dword 0x54 */
    II(0x10107908, 0x5)   calld(sys_check_available_stack_size, 0x5e445); /* call 0x10165d52 */
    II(0x1010790d, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1010790e, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1010790f, 0x1)   pushd(edx);                           /* push edx */
    II(0x10107910, 0x1)   pushd(esi);                           /* push esi */
    II(0x10107911, 0x1)   pushd(edi);                           /* push edi */
    II(0x10107912, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10107913, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10107915, 0x6)   sub(esp, 0x38);                       /* sub esp, 0x38 */
    II(0x1010791b, 0x7)   cmp(memb_a32(ds, 0x101c4d96), 0);     /* cmp byte [0x101c4d96], 0x0 */
    II(0x10107922, 0x2)   jzd(0x10107959, 0x35);                /* jz 0x10107959 */
    II(0x10107924, 0x7)   mov(memb_a32(ds, 0x101c4d96), 0);     /* mov byte [0x101c4d96], 0x0 */
    II(0x1010792b, 0x5)   mov(ebx, 0x32);                       /* mov ebx, 0x32 */
    II(0x10107930, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10107932, 0x3)   lea(eax, ebp - 0x34);                 /* lea eax, [ebp-0x34] */
    II(0x10107935, 0x5)   calld(sys_memset, 0x5e4a6);           /* call 0x10165de0 */
    II(0x1010793a, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1010793c, 0x6)   mov(ax, memw_a32(ds, 0x101c4d94));    /* mov ax, [0x101c4d94] */
    II(0x10107942, 0x3)   mov(memd_a32(ss, ebp - 0x20), eax);   /* mov [ebp-0x20], eax */
    II(0x10107945, 0x7)   mov(memd_a32(ss, ebp - 0x24), 0x1);   /* mov dword [ebp-0x24], 0x1 */
    II(0x1010794c, 0x3)   lea(edx, ebp - 0x34);                 /* lea edx, [ebp-0x34] */
    II(0x1010794f, 0x5)   mov(eax, 0x7a);                       /* mov eax, 0x7a */
    II(0x10107954, 0x5)   calld(0x100e44ba, -0x2349f);          /* call 0x100e44ba */
l_0x10107959:
    II(0x10107959, 0x5)   mov(edx, 0x4ec0);                     /* mov edx, 0x4ec0 */
    II(0x1010795e, 0x5)   mov(eax, memd_a32(ds, 0x101c4dac));   /* mov eax, [0x101c4dac] */
    II(0x10107963, 0x5)   calld(0x100e464c, -0x2331c);          /* call 0x100e464c */
    II(0x10107968, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1010796a, 0x6)   mov(ax, memw_a32(ds, 0x101c4db4));    /* mov ax, [0x101c4db4] */
    II(0x10107970, 0x5)   calld(0x100e4467, -0x2350e);          /* call 0x100e4467 */
    II(0x10107975, 0x7)   cmp(memb_a32(ds, 0x101c4d97), 0);     /* cmp byte [0x101c4d97], 0x0 */
    II(0x1010797c, 0x2)   jzd(0x101079c3, 0x45);                /* jz 0x101079c3 */
    II(0x1010797e, 0x4)   mov(memb_a32(ss, ebp - 0x38), 0);     /* mov byte [ebp-0x38], 0x0 */
    II(0x10107982, 0x2)   jmpd(0x1010798a, 0x6);                /* jmp 0x1010798a */
l_0x10107984:
    II(0x10107984, 0x3)   mov(al, memb_a32(ss, ebp - 0x38));    /* mov al, [ebp-0x38] */
    II(0x10107987, 0x3)   inc(memb_a32(ss, ebp - 0x38));        /* inc byte [ebp-0x38] */
l_0x1010798a:
    II(0x1010798a, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1010798c, 0x3)   mov(al, memb_a32(ss, ebp - 0x38));    /* mov al, [ebp-0x38] */
    II(0x1010798f, 0x3)   cmp(eax, 0x4);                        /* cmp eax, 0x4 */
    II(0x10107992, 0x2)   jged(0x101079bc, 0x28);               /* jge 0x101079bc */
    II(0x10107994, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10107996, 0x3)   mov(al, memb_a32(ss, ebp - 0x38));    /* mov al, [ebp-0x38] */
    II(0x10107999, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
    II(0x1010799c, 0x6)   mov(eax, memd_a32(ds, eax + 0x101c4140)); /* mov eax, [eax+0x101c4140] */
    II(0x101079a2, 0x5)   calld(sys_free, 0x6371a);             /* call 0x1016b0c1 */
    II(0x101079a7, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x101079a9, 0x3)   mov(al, memb_a32(ss, ebp - 0x38));    /* mov al, [ebp-0x38] */
    II(0x101079ac, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
    II(0x101079af, 0x6)   mov(eax, memd_a32(ds, eax + 0x101c4150)); /* mov eax, [eax+0x101c4150] */
    II(0x101079b5, 0x5)   calld(sys_free, 0x63707);             /* call 0x1016b0c1 */
    II(0x101079ba, 0x2)   jmpd(0x10107984, -0x38);              /* jmp 0x10107984 */
l_0x101079bc:
    II(0x101079bc, 0x7)   mov(memb_a32(ds, 0x101c4d97), 0);     /* mov byte [0x101c4d97], 0x0 */
l_0x101079c3:
    II(0x101079c3, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101079c5, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101079c6, 0x1)   popd(edi);                            /* pop edi */
    II(0x101079c7, 0x1)   popd(esi);                            /* pop esi */
    II(0x101079c8, 0x1)   popd(edx);                            /* pop edx */
    II(0x101079c9, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101079ca, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101079cb, 0x1)   retd();                               /* ret */
FUNC_END

