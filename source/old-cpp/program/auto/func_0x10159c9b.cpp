FUNC_BEGIN(0x10159c9b, 0x80cd65eabc2183ff, 0x20, ({0x68, 0x38, 0, 0, 0, 0xe8, 0xad, 0xc0, 0, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x1c, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xd8, 0x79, 0xfe, 0xff, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf8, 0x80, 0x78, 0x3d, 0x8, 0x75, 0x9, 0xc7, 0x45, 0xf0, 0x70, 0x26, 0x1b, 0x10, 0xeb, 0x7, 0xc7, 0x45, 0xf0, 0x76, 0x26, 0x1b, 0x10, 0xb8, 0xe4, 0x9b, 0x15, 0x10, 0x50, 0xb9, 0x31, 0, 0, 0, 0x8b, 0x5d, 0xf0, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0xe8, 0xdb, 0xdf, 0xff, 0xff, 0xb8, 0x4d, 0x9c, 0x15, 0x10, 0x50, 0xc7, 0x45, 0xe4, 0x32, 0, 0, 0, 0xb8, 0x7f, 0x26, 0x1b, 0x10, 0x89, 0x45, 0xe8, 0x8b, 0x45, 0xf8, 0x80, 0x78, 0x57, 0x7, 0x75, 0x6, 0xc6, 0x45, 0xec, 0x1, 0xeb, 0x4, 0xc6, 0x45, 0xec, 0, 0x31, 0xd2, 0x8a, 0x55, 0xec, 0x8b, 0x45, 0xfc, 0x8b, 0x4d, 0xe4, 0x8b, 0x5d, 0xe8, 0xe8, 0xa0, 0xdf, 0xff, 0xff, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x81, 0xee, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10159c9b, 0x5)   pushd(0x38);                          /* push dword 0x38 */
    II(0x10159ca0, 0x5)   calld(sys_check_available_stack_size, 0xc0ad); /* call 0x10165d52 */
    II(0x10159ca5, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10159ca6, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10159ca7, 0x1)   pushd(esi);                           /* push esi */
    II(0x10159ca8, 0x1)   pushd(edi);                           /* push edi */
    II(0x10159ca9, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10159caa, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10159cac, 0x6)   sub(esp, 0x1c);                       /* sub esp, 0x1c */
    II(0x10159cb2, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10159cb5, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10159cb8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10159cbb, 0x5)   calld(0x10141698, -0x18628);          /* call 0x10141698 */
    II(0x10159cc0, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10159cc3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10159cc6, 0x4)   cmp(memb_a32(ds, eax + 0x3d), 0x8);   /* cmp byte [eax+0x3d], 0x8 */
    II(0x10159cca, 0x2)   jnzd(0x10159cd5, 0x9);                /* jnz 0x10159cd5 */
    II(0x10159ccc, 0x7)   mov(memd_a32(ss, ebp - 0x10), 0x101b2670); /* mov dword [ebp-0x10], 0x101b2670 */ /* "start" */
    II(0x10159cd3, 0x2)   jmpd(0x10159cdc, 0x7);                /* jmp 0x10159cdc */
l_0x10159cd5:
    II(0x10159cd5, 0x7)   mov(memd_a32(ss, ebp - 0x10), 0x101b2676); /* mov dword [ebp-0x10], 0x101b2676 */ /* "activate" */
l_0x10159cdc:
    II(0x10159cdc, 0x5)   mov(eax, 0x10159be4);                 /* mov eax, 0x10159be4 */
    II(0x10159ce1, 0x1)   pushd(eax);                           /* push eax */
    II(0x10159ce2, 0x5)   mov(ecx, 0x31);                       /* mov ecx, 0x31 */
    II(0x10159ce7, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x10));   /* mov ebx, [ebp-0x10] */
    II(0x10159cea, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10159cec, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10159cef, 0x5)   calld(0x10157ccf, -0x2025);           /* call 0x10157ccf */
    II(0x10159cf4, 0x5)   mov(eax, 0x10159c4d);                 /* mov eax, 0x10159c4d */
    II(0x10159cf9, 0x1)   pushd(eax);                           /* push eax */
    II(0x10159cfa, 0x7)   mov(memd_a32(ss, ebp - 0x1c), 0x32);  /* mov dword [ebp-0x1c], 0x32 */
    II(0x10159d01, 0x5)   mov(eax, 0x101b267f);                 /* mov eax, 0x101b267f */ /* "load" */
    II(0x10159d06, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
    II(0x10159d09, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10159d0c, 0x4)   cmp(memb_a32(ds, eax + 0x57), 0x7);   /* cmp byte [eax+0x57], 0x7 */
    II(0x10159d10, 0x2)   jnzd(0x10159d18, 0x6);                /* jnz 0x10159d18 */
    II(0x10159d12, 0x4)   mov(memb_a32(ss, ebp - 0x14), 0x1);   /* mov byte [ebp-0x14], 0x1 */
    II(0x10159d16, 0x2)   jmpd(0x10159d1c, 0x4);                /* jmp 0x10159d1c */
l_0x10159d18:
    II(0x10159d18, 0x4)   mov(memb_a32(ss, ebp - 0x14), 0);     /* mov byte [ebp-0x14], 0x0 */
l_0x10159d1c:
    II(0x10159d1c, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10159d1e, 0x3)   mov(dl, memb_a32(ss, ebp - 0x14));    /* mov dl, [ebp-0x14] */
    II(0x10159d21, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10159d24, 0x3)   mov(ecx, memd_a32(ss, ebp - 0x1c));   /* mov ecx, [ebp-0x1c] */
    II(0x10159d27, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x18));   /* mov ebx, [ebp-0x18] */
    II(0x10159d2a, 0x5)   calld(0x10157ccf, -0x2060);           /* call 0x10157ccf */
    II(0x10159d2f, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x10159d32, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10159d35, 0x5)   calld(0x10158bbb, -0x117f);           /* call 0x10158bbb */
    II(0x10159d3a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10159d3c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10159d3d, 0x1)   popd(edi);                            /* pop edi */
    II(0x10159d3e, 0x1)   popd(esi);                            /* pop esi */
    II(0x10159d3f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10159d40, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10159d41, 0x1)   retd();                               /* ret */
FUNC_END

