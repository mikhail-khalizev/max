FUNC_BEGIN(0x10106acf, 0x5bc4833f8a353b1a, 0x20, ({0x68, 0x90, 0, 0, 0, 0xe8, 0x79, 0xf2, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x74, 0, 0, 0, 0xc7, 0x45, 0xf8, 0, 0, 0, 0, 0xbb, 0x1c, 0, 0, 0, 0x31, 0xd2, 0x8d, 0x45, 0xc8, 0xe8, 0xe3, 0xf2, 0x5, 0, 0xc7, 0x45, 0xc8, 0, 0x4, 0, 0, 0x8d, 0x5d, 0xc8, 0x8d, 0x55, 0xc8, 0xb8, 0x31, 0, 0, 0, 0xe8, 0xf2, 0x5a, 0x6, 0, 0x83, 0x7d, 0xe0, 0, 0x75, 0x58, 0xbb, 0x1c, 0, 0, 0, 0x31, 0xd2, 0x8d, 0x45, 0xc8, 0xe8, 0xb7, 0xf2, 0x5, 0, 0xbb, 0xc, 0, 0, 0, 0x31, 0xd2, 0x8d, 0x45, 0xbc, 0xe8, 0xa8, 0xf2, 0x5, 0, 0xc7, 0x45, 0xc8, 0, 0x5, 0, 0, 0x8c, 0xd3, 0x8d, 0x55, 0x8c, 0x89, 0xd8, 0x89, 0xd3, 0x89, 0xc2, 0x89, 0xd8, 0x66, 0x89, 0x55, 0xbc, 0x8d, 0x45, 0x8c, 0x89, 0x45, 0xdc, 0x8d, 0x4d, 0xbc, 0x8d, 0x5d, 0xc8, 0x8d, 0x55, 0xc8, 0xb8, 0x31, 0, 0, 0, 0xe8, 0xba, 0x5a, 0x6, 0, 0x8b, 0x45, 0x9c, 0xc1, 0xe0, 0xc, 0x89, 0x45, 0xf8, 0x66, 0xc7, 0x45, 0xe8, 0, 0, 0xc7, 0x45, 0xe4, 0, 0, 0, 0, 0x8d, 0x45, 0xe4, 0xe8, 0xfe, 0x25, 0x7, 0, 0x89, 0x45, 0xfc, 0x83, 0x7d, 0xfc, 0, 0x75, 0xe, 0x83, 0x7d, 0xee, 0x1, 0x75, 0x6, 0x8b, 0x45, 0xea, 0x1, 0x45, 0xf8, 0xeb, 0xe1, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10106acf, 0x5)   pushd(0x90);                          /* push dword 0x90 */
    II(0x10106ad4, 0x5)   calld(sys_check_available_stack_size, 0x5f279); /* call 0x10165d52 */
    II(0x10106ad9, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10106ada, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10106adb, 0x1)   pushd(edx);                           /* push edx */
    II(0x10106adc, 0x1)   pushd(esi);                           /* push esi */
    II(0x10106add, 0x1)   pushd(edi);                           /* push edi */
    II(0x10106ade, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10106adf, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10106ae1, 0x6)   sub(esp, 0x74);                       /* sub esp, 0x74 */
    II(0x10106ae7, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0);      /* mov dword [ebp-0x8], 0x0 */
    II(0x10106aee, 0x5)   mov(ebx, 0x1c);                       /* mov ebx, 0x1c */
    II(0x10106af3, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10106af5, 0x3)   lea(eax, ebp - 0x38);                 /* lea eax, [ebp-0x38] */
    II(0x10106af8, 0x5)   calld(sys_memset, 0x5f2e3);           /* call 0x10165de0 */
    II(0x10106afd, 0x7)   mov(memd_a32(ss, ebp - 0x38), 0x400); /* mov dword [ebp-0x38], 0x400 */
    II(0x10106b04, 0x3)   lea(ebx, ebp - 0x38);                 /* lea ebx, [ebp-0x38] */
    II(0x10106b07, 0x3)   lea(edx, ebp - 0x38);                 /* lea edx, [ebp-0x38] */
    II(0x10106b0a, 0x5)   mov(eax, 0x31);                       /* mov eax, 0x31 */
    II(0x10106b0f, 0x5)   calld(/* sys */ 0x1016c606, 0x65af2); /* call 0x1016c606 */
    II(0x10106b14, 0x4)   cmp(memd_a32(ss, ebp - 0x20), 0);     /* cmp dword [ebp-0x20], 0x0 */
    II(0x10106b18, 0x2)   jnzd(0x10106b72, 0x58);               /* jnz 0x10106b72 */
    II(0x10106b1a, 0x5)   mov(ebx, 0x1c);                       /* mov ebx, 0x1c */
    II(0x10106b1f, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10106b21, 0x3)   lea(eax, ebp - 0x38);                 /* lea eax, [ebp-0x38] */
    II(0x10106b24, 0x5)   calld(sys_memset, 0x5f2b7);           /* call 0x10165de0 */
    II(0x10106b29, 0x5)   mov(ebx, 0xc);                        /* mov ebx, 0xc */
    II(0x10106b2e, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10106b30, 0x3)   lea(eax, ebp - 0x44);                 /* lea eax, [ebp-0x44] */
    II(0x10106b33, 0x5)   calld(sys_memset, 0x5f2a8);           /* call 0x10165de0 */
    II(0x10106b38, 0x7)   mov(memd_a32(ss, ebp - 0x38), 0x500); /* mov dword [ebp-0x38], 0x500 */
    II(0x10106b3f, 0x2)   mov(ebx, ss);                         /* mov ebx, ss */
    II(0x10106b41, 0x3)   lea(edx, ebp - 0x74);                 /* lea edx, [ebp-0x74] */
    II(0x10106b44, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x10106b46, 0x2)   mov(ebx, edx);                        /* mov ebx, edx */
    II(0x10106b48, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10106b4a, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x10106b4c, 0x4)   mov(memw_a32(ss, ebp - 0x44), dx);    /* mov [ebp-0x44], dx */
    II(0x10106b50, 0x3)   lea(eax, ebp - 0x74);                 /* lea eax, [ebp-0x74] */
    II(0x10106b53, 0x3)   mov(memd_a32(ss, ebp - 0x24), eax);   /* mov [ebp-0x24], eax */
    II(0x10106b56, 0x3)   lea(ecx, ebp - 0x44);                 /* lea ecx, [ebp-0x44] */
    II(0x10106b59, 0x3)   lea(ebx, ebp - 0x38);                 /* lea ebx, [ebp-0x38] */
    II(0x10106b5c, 0x3)   lea(edx, ebp - 0x38);                 /* lea edx, [ebp-0x38] */
    II(0x10106b5f, 0x5)   mov(eax, 0x31);                       /* mov eax, 0x31 */
    II(0x10106b64, 0x5)   calld(/* sys */ 0x1016c623, 0x65aba); /* call 0x1016c623 */
    II(0x10106b69, 0x3)   mov(eax, memd_a32(ss, ebp - 0x64));   /* mov eax, [ebp-0x64] */
    II(0x10106b6c, 0x3)   shl(eax, 0xc);                        /* shl eax, 0xc */
    II(0x10106b6f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
l_0x10106b72:
    II(0x10106b72, 0x6)   mov(memw_a32(ss, ebp - 0x18), 0);     /* mov word [ebp-0x18], 0x0 */
    II(0x10106b78, 0x7)   mov(memd_a32(ss, ebp - 0x1c), 0);     /* mov dword [ebp-0x1c], 0x0 */
l_0x10106b7f:
    II(0x10106b7f, 0x3)   lea(eax, ebp - 0x1c);                 /* lea eax, [ebp-0x1c] */
    II(0x10106b82, 0x5)   calld(/* sys */ 0x10179185, 0x725fe); /* call 0x10179185 */
    II(0x10106b87, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10106b8a, 0x4)   cmp(memd_a32(ss, ebp - 0x4), 0);      /* cmp dword [ebp-0x4], 0x0 */
    II(0x10106b8e, 0x2)   jnzd(0x10106b9e, 0xe);                /* jnz 0x10106b9e */
    II(0x10106b90, 0x4)   cmp(memd_a32(ss, ebp - 0x12), 0x1);   /* cmp dword [ebp-0x12], 0x1 */
    II(0x10106b94, 0x2)   jnzd(0x10106b9c, 0x6);                /* jnz 0x10106b9c */
    II(0x10106b96, 0x3)   mov(eax, memd_a32(ss, ebp - 0x16));   /* mov eax, [ebp-0x16] */
    II(0x10106b99, 0x3)   add(memd_a32(ss, ebp - 0x8), eax);    /* add [ebp-0x8], eax */
l_0x10106b9c:
    II(0x10106b9c, 0x2)   jmpd(0x10106b7f, -0x1f);              /* jmp 0x10106b7f */
l_0x10106b9e:
    II(0x10106b9e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10106ba1, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x10106ba4, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10106ba7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10106ba9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10106baa, 0x1)   popd(edi);                            /* pop edi */
    II(0x10106bab, 0x1)   popd(esi);                            /* pop esi */
    II(0x10106bac, 0x1)   popd(edx);                            /* pop edx */
    II(0x10106bad, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10106bae, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10106baf, 0x1)   retd();                               /* ret */
FUNC_END

