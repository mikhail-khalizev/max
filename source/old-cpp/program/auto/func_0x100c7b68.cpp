FUNC_BEGIN(0x100c7b68, 0x66df43564a205d08, 0x20, ({0x68, 0x48, 0, 0, 0, 0xe8, 0xe0, 0xe1, 0x9, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x20, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x88, 0x5d, 0xfc, 0xb8, 0x1, 0, 0, 0, 0x50, 0xa1, 0x72, 0x81, 0x1c, 0x10, 0xc1, 0xf8, 0x10, 0x50, 0x8b, 0xd, 0x70, 0x81, 0x1c, 0x10, 0xc1, 0xf9, 0x10, 0x31, 0xdb, 0x31, 0xd2, 0x8d, 0x45, 0xe4, 0xe8, 0x9d, 0x35, 0xfc, 0xff, 0xff, 0x70, 0xc, 0xff, 0x70, 0x8, 0xff, 0x70, 0x4, 0xff, 0x30, 0x8b, 0x45, 0xf4, 0xe8, 0x3a, 0x87, 0xfc, 0xff, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0xc7, 0x40, 0x23, 0xec, 0x58, 0x1b, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x55, 0xf4, 0x89, 0x42, 0x27, 0x8a, 0x45, 0xfc, 0x8b, 0x55, 0xf4, 0x88, 0x42, 0x2b, 0x8b, 0x45, 0xf4, 0x89, 0x45, 0xe0, 0x8b, 0x45, 0xe0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x100c7b68, 0x5)   pushd(0x48);                          /* push dword 0x48 */
    II(0x100c7b6d, 0x5)   calld(sys_check_available_stack_size, 0x9e1e0); /* call 0x10165d52 */
    II(0x100c7b72, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100c7b73, 0x1)   pushd(esi);                           /* push esi */
    II(0x100c7b74, 0x1)   pushd(edi);                           /* push edi */
    II(0x100c7b75, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100c7b76, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100c7b78, 0x6)   sub(esp, 0x20);                       /* sub esp, 0x20 */
    II(0x100c7b7e, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100c7b81, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x100c7b84, 0x3)   mov(memb_a32(ss, ebp - 0x4), bl);     /* mov [ebp-0x4], bl */
    II(0x100c7b87, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
    II(0x100c7b8c, 0x1)   pushd(eax);                           /* push eax */
    II(0x100c7b8d, 0x5)   mov(eax, memd_a32(ds, 0x101c8172));   /* mov eax, [0x101c8172] */
    II(0x100c7b92, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100c7b95, 0x1)   pushd(eax);                           /* push eax */
    II(0x100c7b96, 0x6)   mov(ecx, memd_a32(ds, 0x101c8170));   /* mov ecx, [0x101c8170] */
    II(0x100c7b9c, 0x3)   sar(ecx, 0x10);                       /* sar ecx, 0x10 */
    II(0x100c7b9f, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x100c7ba1, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100c7ba3, 0x3)   lea(eax, ebp - 0x1c);                 /* lea eax, [ebp-0x1c] */
    II(0x100c7ba6, 0x5)   calld(0x1008b148, -0x3ca63);          /* call 0x1008b148 */
    II(0x100c7bab, 0x3)   pushd(memd_a32(ds, eax + 0xc));       /* push dword [eax+0xc] */
    II(0x100c7bae, 0x3)   pushd(memd_a32(ds, eax + 0x8));       /* push dword [eax+0x8] */
    II(0x100c7bb1, 0x3)   pushd(memd_a32(ds, eax + 0x4));       /* push dword [eax+0x4] */
    II(0x100c7bb4, 0x2)   pushd(memd_a32(ds, eax));             /* push dword [eax] */
    II(0x100c7bb6, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100c7bb9, 0x5)   calld(0x100902f8, -0x378c6);          /* call 0x100902f8 */
    II(0x100c7bbe, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100c7bc1, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100c7bc4, 0x7)   mov(memd_a32(ds, eax + 0x23), 0x101b58ec); /* mov dword [eax+0x23], 0x101b58ec */
    II(0x100c7bcb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100c7bce, 0x3)   mov(edx, memd_a32(ss, ebp - 0xc));    /* mov edx, [ebp-0xc] */
    II(0x100c7bd1, 0x3)   mov(memd_a32(ds, edx + 0x27), eax);   /* mov [edx+0x27], eax */
    II(0x100c7bd4, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x100c7bd7, 0x3)   mov(edx, memd_a32(ss, ebp - 0xc));    /* mov edx, [ebp-0xc] */
    II(0x100c7bda, 0x3)   mov(memb_a32(ds, edx + 0x2b), al);    /* mov [edx+0x2b], al */
    II(0x100c7bdd, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100c7be0, 0x3)   mov(memd_a32(ss, ebp - 0x20), eax);   /* mov [ebp-0x20], eax */
//    II(0x100c7be3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x20));   /* mov eax, [ebp-0x20] */
    II(0x100c7be6, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100c7be8, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100c7be9, 0x1)   popd(edi);                            /* pop edi */
    II(0x100c7bea, 0x1)   popd(esi);                            /* pop esi */
    II(0x100c7beb, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100c7bec, 0x1)   retd();                               /* ret */
FUNC_END

