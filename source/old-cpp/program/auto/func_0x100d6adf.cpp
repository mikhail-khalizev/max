FUNC_BEGIN(0x100d6adf, 0x2d5ae8858282b1a7, 0x20, ({0x68, 0x4c, 0, 0, 0, 0xe8, 0x69, 0xf2, 0x8, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x28, 0, 0, 0, 0x89, 0x45, 0xf8, 0x88, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x83, 0x38, 0, 0x75, 0x9, 0xc7, 0x45, 0xf4, 0, 0, 0, 0, 0xeb, 0x19, 0xb9, 0x9a, 0, 0, 0, 0xbb, 0xd8, 0x17, 0x1a, 0x10, 0xba, 0xe2, 0x17, 0x1a, 0x10, 0x31, 0xc0, 0xe8, 0x6f, 0xf2, 0x8, 0, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf8, 0xff, 0x70, 0xc, 0x6a, 0, 0x8b, 0x45, 0xf8, 0x8b, 0x48, 0x8, 0xc1, 0xf9, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x58, 0x6, 0xc1, 0xfb, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x4, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x2, 0xc1, 0xf8, 0x10, 0xe8, 0xd, 0xfc, 0x8, 0, 0x89, 0xc2, 0x8b, 0x45, 0xf8, 0x89, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0xe, 0xc1, 0xf8, 0x10, 0x83, 0xf8, 0xff, 0x74, 0x44, 0x8d, 0x55, 0xd8, 0x8b, 0x45, 0xf8, 0xe8, 0x9a, 0xfe, 0xff, 0xff, 0xe8, 0xc0, 0xe7, 0xff, 0xff, 0x98, 0x50, 0xe8, 0xdd, 0xe7, 0xff, 0xff, 0x98, 0x50, 0x31, 0xc0, 0x8a, 0x45, 0xfc, 0x50, 0x8b, 0x45, 0xf8, 0x8a, 0x40, 0x12, 0x30, 0xe4, 0xf, 0xbf, 0xc8, 0x8b, 0x45, 0xf8, 0x8b, 0x58, 0x6, 0xc1, 0xfb, 0x10, 0x8d, 0x55, 0xd8, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0xe, 0xc1, 0xf8, 0x10, 0xe8, 0xa1, 0x20, 0x1, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100d6adf, 0x5)   pushd(0x4c);                          /* push dword 0x4c */
    II(0x100d6ae4, 0x5)   calld(sys_check_available_stack_size, 0x8f269); /* call 0x10165d52 */
    II(0x100d6ae9, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d6aea, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d6aeb, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d6aec, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d6aed, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d6aee, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d6af0, 0x6)   sub(esp, 0x28);                       /* sub esp, 0x28 */
    II(0x100d6af6, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100d6af9, 0x3)   mov(memb_a32(ss, ebp - 0x4), dl);     /* mov [ebp-0x4], dl */
    II(0x100d6afc, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d6aff, 0x3)   cmp(memd_a32(ds, eax), 0);            /* cmp dword [eax], 0x0 */
    II(0x100d6b02, 0x2)   jnzd(0x100d6b0d, 0x9);                /* jnz 0x100d6b0d */
    II(0x100d6b04, 0x7)   mov(memd_a32(ss, ebp - 0xc), 0);      /* mov dword [ebp-0xc], 0x0 */
    II(0x100d6b0b, 0x2)   jmpd(0x100d6b26, 0x19);               /* jmp 0x100d6b26 */
l_0x100d6b0d:
    II(0x100d6b0d, 0x5)   mov(ecx, 0x9a);                       /* mov ecx, 0x9a */
    II(0x100d6b12, 0x5)   mov(ebx, 0x101a17d8);                 /* mov ebx, 0x101a17d8 */ /* "commo.cpp" */
    II(0x100d6b17, 0x5)   mov(edx, 0x101a17e2);                 /* mov edx, 0x101a17e2 */ /* "window_id == 0" */
    II(0x100d6b1c, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x100d6b1e, 0x5)   calld(sys_assert, 0x8f26f);           /* call 0x10165d92 */
    II(0x100d6b23, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
l_0x100d6b26:
    II(0x100d6b26, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d6b29, 0x3)   pushd(memd_a32(ds, eax + 0xc));       /* push dword [eax+0xc] */
    II(0x100d6b2c, 0x2)   pushd(0);                             /* push 0x0 */
    II(0x100d6b2e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d6b31, 0x3)   mov(ecx, memd_a32(ds, eax + 0x8));    /* mov ecx, [eax+0x8] */
    II(0x100d6b34, 0x3)   sar(ecx, 0x10);                       /* sar ecx, 0x10 */
    II(0x100d6b37, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d6b3a, 0x3)   mov(ebx, memd_a32(ds, eax + 0x6));    /* mov ebx, [eax+0x6] */
    II(0x100d6b3d, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x100d6b40, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d6b43, 0x3)   mov(edx, memd_a32(ds, eax + 0x4));    /* mov edx, [eax+0x4] */
    II(0x100d6b46, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100d6b49, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d6b4c, 0x3)   mov(eax, memd_a32(ds, eax + 0x2));    /* mov eax, [eax+0x2] */
    II(0x100d6b4f, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100d6b52, 0x5)   calld(/* sys */ 0x10166764, 0x8fc0d); /* call 0x10166764 */
    II(0x100d6b57, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x100d6b59, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d6b5c, 0x2)   mov(memd_a32(ds, eax), edx);          /* mov [eax], edx */
    II(0x100d6b5e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d6b61, 0x3)   mov(eax, memd_a32(ds, eax + 0xe));    /* mov eax, [eax+0xe] */
    II(0x100d6b64, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100d6b67, 0x3)   cmp(eax, -0x1 /* 0xff */);            /* cmp eax, 0xff */
    II(0x100d6b6a, 0x2)   jzd(0x100d6bb0, 0x44);                /* jz 0x100d6bb0 */
    II(0x100d6b6c, 0x3)   lea(edx, ebp - 0x28);                 /* lea edx, [ebp-0x28] */
    II(0x100d6b6f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d6b72, 0x5)   calld(0x100d6a11, -0x166);            /* call 0x100d6a11 */
    II(0x100d6b77, 0x5)   calld(0x100d533c, -0x1840);           /* call 0x100d533c */
    II(0x100d6b7c, 0x1)   cwde();                               /* cwde */
    II(0x100d6b7d, 0x1)   pushd(eax);                           /* push eax */
    II(0x100d6b7e, 0x5)   calld(0x100d5360, -0x1823);           /* call 0x100d5360 */
    II(0x100d6b83, 0x1)   cwde();                               /* cwde */
    II(0x100d6b84, 0x1)   pushd(eax);                           /* push eax */
    II(0x100d6b85, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x100d6b87, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x100d6b8a, 0x1)   pushd(eax);                           /* push eax */
    II(0x100d6b8b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d6b8e, 0x3)   mov(al, memb_a32(ds, eax + 0x12));    /* mov al, [eax+0x12] */
    II(0x100d6b91, 0x2)   xor_(ah, ah);                         /* xor ah, ah */
    II(0x100d6b93, 0x3)   movsx(ecx, ax);                       /* movsx ecx, ax */
    II(0x100d6b96, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d6b99, 0x3)   mov(ebx, memd_a32(ds, eax + 0x6));    /* mov ebx, [eax+0x6] */
    II(0x100d6b9c, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x100d6b9f, 0x3)   lea(edx, ebp - 0x28);                 /* lea edx, [ebp-0x28] */
    II(0x100d6ba2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d6ba5, 0x3)   mov(eax, memd_a32(ds, eax + 0xe));    /* mov eax, [eax+0xe] */
    II(0x100d6ba8, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100d6bab, 0x5)   calld(0x100e8c51, 0x120a1);           /* call 0x100e8c51 */
l_0x100d6bb0:
    II(0x100d6bb0, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d6bb2, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d6bb3, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d6bb4, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d6bb5, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d6bb6, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d6bb7, 0x1)   retd();                               /* ret */
FUNC_END

