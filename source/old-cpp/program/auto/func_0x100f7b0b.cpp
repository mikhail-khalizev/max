FUNC_BEGIN(0x100f7b0b, 0x1023391a43c196f3, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x3d, 0xe2, 0x6, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0xf6, 0x40, 0x13, 0x2, 0x75, 0x9, 0x8b, 0x45, 0xfc, 0xf6, 0x40, 0x14, 0x20, 0x75, 0x2, 0xeb, 0x9, 0x8b, 0x45, 0xfc, 0x80, 0x78, 0x3d, 0x1, 0x75, 0x2, 0xeb, 0x9, 0x8b, 0x45, 0xfc, 0x80, 0x78, 0x3d, 0x3, 0x75, 0x2, 0xeb, 0x9, 0x8b, 0x45, 0xfc, 0x80, 0x78, 0x3d, 0x9, 0x75, 0x2, 0xeb, 0x9, 0x8b, 0x45, 0xfc, 0x80, 0x78, 0x3e, 0xe, 0x75, 0x9, 0xc7, 0x45, 0xf0, 0, 0, 0, 0, 0xeb, 0x5b, 0x8b, 0x45, 0xfc, 0x66, 0x83, 0x78, 0x8, 0x41, 0x74, 0xa, 0x8b, 0x45, 0xfc, 0x66, 0x83, 0x78, 0x8, 0x48, 0x75, 0x2, 0xeb, 0xa, 0x8b, 0x45, 0xfc, 0x66, 0x83, 0x78, 0x8, 0x4e, 0x75, 0x13, 0x8b, 0x45, 0xfc, 0x66, 0x83, 0x78, 0x52, 0, 0x74, 0x9, 0xc7, 0x45, 0xf0, 0, 0, 0, 0, 0xeb, 0x28, 0xbb, 0x18, 0, 0, 0, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xa8, 0x4b, 0x6, 0, 0x89, 0x45, 0xf4, 0xba, 0x1a, 0, 0, 0, 0xf, 0xbf, 0x45, 0xf4, 0xe8, 0x24, 0x95, 0x2, 0, 0xc7, 0x45, 0xf0, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100f7b0b, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100f7b10, 0x5)   calld(sys_check_available_stack_size, 0x6e23d); /* call 0x10165d52 */
    II(0x100f7b15, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100f7b16, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100f7b17, 0x1)   pushd(esi);                           /* push esi */
    II(0x100f7b18, 0x1)   pushd(edi);                           /* push edi */
    II(0x100f7b19, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100f7b1a, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100f7b1c, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x100f7b22, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100f7b25, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100f7b28, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f7b2b, 0x4)   test(memb_a32(ds, eax + 0x13), 0x2);  /* test byte [eax+0x13], 0x2 */
    II(0x100f7b2f, 0x2)   jnzd(0x100f7b3a, 0x9);                /* jnz 0x100f7b3a */
    II(0x100f7b31, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f7b34, 0x4)   test(memb_a32(ds, eax + 0x14), 0x20); /* test byte [eax+0x14], 0x20 */
    II(0x100f7b38, 0x2)   jnzd(0x100f7b3c, 0x2);                /* jnz 0x100f7b3c */
l_0x100f7b3a:
    II(0x100f7b3a, 0x2)   jmpd(0x100f7b45, 0x9);                /* jmp 0x100f7b45 */
l_0x100f7b3c:
    II(0x100f7b3c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f7b3f, 0x4)   cmp(memb_a32(ds, eax + 0x3d), 0x1);   /* cmp byte [eax+0x3d], 0x1 */
    II(0x100f7b43, 0x2)   jnzd(0x100f7b47, 0x2);                /* jnz 0x100f7b47 */
l_0x100f7b45:
    II(0x100f7b45, 0x2)   jmpd(0x100f7b50, 0x9);                /* jmp 0x100f7b50 */
l_0x100f7b47:
    II(0x100f7b47, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f7b4a, 0x4)   cmp(memb_a32(ds, eax + 0x3d), 0x3);   /* cmp byte [eax+0x3d], 0x3 */
    II(0x100f7b4e, 0x2)   jnzd(0x100f7b52, 0x2);                /* jnz 0x100f7b52 */
l_0x100f7b50:
    II(0x100f7b50, 0x2)   jmpd(0x100f7b5b, 0x9);                /* jmp 0x100f7b5b */
l_0x100f7b52:
    II(0x100f7b52, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f7b55, 0x4)   cmp(memb_a32(ds, eax + 0x3d), 0x9);   /* cmp byte [eax+0x3d], 0x9 */
    II(0x100f7b59, 0x2)   jnzd(0x100f7b5d, 0x2);                /* jnz 0x100f7b5d */
l_0x100f7b5b:
    II(0x100f7b5b, 0x2)   jmpd(0x100f7b66, 0x9);                /* jmp 0x100f7b66 */
l_0x100f7b5d:
    II(0x100f7b5d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f7b60, 0x4)   cmp(memb_a32(ds, eax + 0x3e), 0xe);   /* cmp byte [eax+0x3e], 0xe */
    II(0x100f7b64, 0x2)   jnzd(0x100f7b6f, 0x9);                /* jnz 0x100f7b6f */
l_0x100f7b66:
    II(0x100f7b66, 0x7)   mov(memd_a32(ss, ebp - 0x10), 0);     /* mov dword [ebp-0x10], 0x0 */
    II(0x100f7b6d, 0x2)   jmpd(0x100f7bca, 0x5b);               /* jmp 0x100f7bca */
l_0x100f7b6f:
    II(0x100f7b6f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f7b72, 0x5)   cmp(memw_a32(ds, eax + 0x8), 0x41);   /* cmp word [eax+0x8], 0x41 */
    II(0x100f7b77, 0x2)   jzd(0x100f7b83, 0xa);                 /* jz 0x100f7b83 */
    II(0x100f7b79, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f7b7c, 0x5)   cmp(memw_a32(ds, eax + 0x8), 0x48);   /* cmp word [eax+0x8], 0x48 */
    II(0x100f7b81, 0x2)   jnzd(0x100f7b85, 0x2);                /* jnz 0x100f7b85 */
l_0x100f7b83:
    II(0x100f7b83, 0x2)   jmpd(0x100f7b8f, 0xa);                /* jmp 0x100f7b8f */
l_0x100f7b85:
    II(0x100f7b85, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f7b88, 0x5)   cmp(memw_a32(ds, eax + 0x8), 0x4e);   /* cmp word [eax+0x8], 0x4e */
    II(0x100f7b8d, 0x2)   jnzd(0x100f7ba2, 0x13);               /* jnz 0x100f7ba2 */
l_0x100f7b8f:
    II(0x100f7b8f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f7b92, 0x5)   cmp(memw_a32(ds, eax + 0x52), 0);     /* cmp word [eax+0x52], 0x0 */
    II(0x100f7b97, 0x2)   jzd(0x100f7ba2, 0x9);                 /* jz 0x100f7ba2 */
    II(0x100f7b99, 0x7)   mov(memd_a32(ss, ebp - 0x10), 0);     /* mov dword [ebp-0x10], 0x0 */
    II(0x100f7ba0, 0x2)   jmpd(0x100f7bca, 0x28);               /* jmp 0x100f7bca */
l_0x100f7ba2:
    II(0x100f7ba2, 0x5)   mov(ebx, 0x18);                       /* mov ebx, 0x18 */
    II(0x100f7ba7, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100f7baa, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100f7bad, 0x5)   calld(0x1015c75a, 0x64ba8);           /* call 0x1015c75a */
    II(0x100f7bb2, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100f7bb5, 0x5)   mov(edx, 0x1a);                       /* mov edx, 0x1a */
    II(0x100f7bba, 0x4)   movsx(eax, memw_a32(ss, ebp - 0xc));  /* movsx eax, word [ebp-0xc] */
    II(0x100f7bbe, 0x5)   calld(0x101210e7, 0x29524);           /* call 0x101210e7 */
    II(0x100f7bc3, 0x7)   mov(memd_a32(ss, ebp - 0x10), 0x1);   /* mov dword [ebp-0x10], 0x1 */
l_0x100f7bca:
    II(0x100f7bca, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100f7bcd, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100f7bcf, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100f7bd0, 0x1)   popd(edi);                            /* pop edi */
    II(0x100f7bd1, 0x1)   popd(esi);                            /* pop esi */
    II(0x100f7bd2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100f7bd3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100f7bd4, 0x1)   retd();                               /* ret */
FUNC_END

