FUNC_BEGIN(0x100b524c, 0x2cb4915d8d9b4e3, 0x20, ({0x68, 0x30, 0, 0, 0, 0xe8, 0xfc, 0xa, 0xb, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x1c, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xec, 0x8b, 0x45, 0xec, 0x8b, 0x50, 0x2, 0x8b, 0x45, 0xec, 0xff, 0x52, 0x14, 0xf, 0xbf, 0xc8, 0x8b, 0x5d, 0xfc, 0x8b, 0x45, 0xf8, 0x8a, 0x40, 0x26, 0x30, 0xe4, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xf4, 0xe8, 0x3b, 0xd4, 0xfe, 0xff, 0x89, 0x45, 0xf4, 0x8d, 0x45, 0xf4, 0x89, 0x45, 0xe8, 0x8b, 0x45, 0xf4, 0x83, 0xc0, 0x13, 0xe8, 0x46, 0x14, 0xfc, 0xff, 0x83, 0xe8, 0x13, 0x89, 0x45, 0xf4, 0x8d, 0x45, 0xf4, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf4, 0xc7, 0x40, 0x2, 0xf4, 0x51, 0x1b, 0x10, 0x8b, 0x55, 0xf8, 0x8b, 0x45, 0xf4, 0x83, 0xc0, 0x13, 0xe8, 0x62, 0x13, 0xfc, 0xff, 0x8b, 0x45, 0xf4, 0x89, 0x45, 0xe4, 0x8b, 0x45, 0xe4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x100b524c, 0x5)   pushd(0x30);                          /* push dword 0x30 */
    II(0x100b5251, 0x5)   calld(sys_check_available_stack_size, 0xb0afc); /* call 0x10165d52 */
    II(0x100b5256, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b5257, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b5258, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b5259, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b525a, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b525c, 0x6)   sub(esp, 0x1c);                       /* sub esp, 0x1c */
    II(0x100b5262, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100b5265, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x100b5268, 0x3)   mov(memd_a32(ss, ebp - 0x4), ebx);    /* mov [ebp-0x4], ebx */
    II(0x100b526b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b526e, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
//    II(0x100b5271, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x100b5274, 0x3)   mov(edx, memd_a32(ds, eax + 0x2));    /* mov edx, [eax+0x2] */
//    II(0x100b5277, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x100b527a, 0x3)   calld_abs(memd_a32(ds, edx + 0x14));  /* call dword near [edx+0x14] */
    II(0x100b527d, 0x3)   movsx(ecx, ax);                       /* movsx ecx, ax */
    II(0x100b5280, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x4));    /* mov ebx, [ebp-0x4] */
    II(0x100b5283, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b5286, 0x3)   mov(al, memb_a32(ds, eax + 0x26));    /* mov al, [eax+0x26] */
    II(0x100b5289, 0x2)   xor_(ah, ah);                         /* xor ah, ah */
    II(0x100b528b, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x100b528e, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b5291, 0x5)   calld(0x100a26d1, -0x12bc5);          /* call 0x100a26d1 */
    II(0x100b5296, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100b5299, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x100b529c, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
    II(0x100b529f, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b52a2, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100b52a5, 0x5)   calld(my_ctor_0x101b38f8, -0x3ebba);  /* call 0x100766f0 */
    II(0x100b52aa, 0x3)   sub(eax, 0x13);                       /* sub eax, 0x13 */
    II(0x100b52ad, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100b52b0, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x100b52b3, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100b52b6, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b52b9, 0x7)   mov(memd_a32(ds, eax + 0x2), 0x101b51f4); /* mov dword [eax+0x2], 0x101b51f4 */
    II(0x100b52c0, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100b52c3, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b52c6, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100b52c9, 0x5)   calld(0x10076630, -0x3ec9e);          /* call 0x10076630 */
    II(0x100b52ce, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b52d1, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
//    II(0x100b52d4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x1c));   /* mov eax, [ebp-0x1c] */
    II(0x100b52d7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b52d9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b52da, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b52db, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b52dc, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b52dd, 0x1)   retd();                               /* ret */
FUNC_END

