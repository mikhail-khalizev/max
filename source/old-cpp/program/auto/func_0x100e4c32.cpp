FUNC_BEGIN(0x100e4c32, 0xc5e42160ac0c71f3, 0x20, ({0x68, 0x40, 0, 0, 0, 0xe8, 0x16, 0x11, 0x8, 0, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x2c, 0, 0, 0, 0x89, 0x45, 0xf8, 0x66, 0x89, 0x4d, 0xf4, 0x89, 0x5d, 0xf0, 0xbb, 0x1c, 0, 0, 0, 0x31, 0xd2, 0x8d, 0x45, 0xd4, 0xe8, 0x7f, 0x11, 0x8, 0, 0x66, 0xc7, 0x45, 0xd4, 0x5, 0x2, 0x8a, 0x45, 0xf8, 0x88, 0x45, 0xd8, 0x8b, 0x45, 0xf4, 0x8b, 0x5d, 0xf0, 0x89, 0xc2, 0x89, 0xd8, 0x66, 0x89, 0x55, 0xdc, 0x8b, 0x45, 0xf0, 0x89, 0x45, 0xe0, 0x8d, 0x5d, 0xd4, 0x8d, 0x55, 0xd4, 0xb8, 0x31, 0, 0, 0, 0xe8, 0x75, 0x79, 0x8, 0, 0x83, 0x7d, 0xec, 0, 0x75, 0x9, 0xc7, 0x45, 0xfc, 0, 0, 0, 0, 0xeb, 0x7, 0xc7, 0x45, 0xfc, 0x1, 0, 0, 0, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0xc3}))
    II(0x100e4c32, 0x5)   pushd(0x40);                          /* push dword 0x40 */
    II(0x100e4c37, 0x5)   calld(sys_check_available_stack_size, 0x81116); /* call 0x10165d52 */
    II(0x100e4c3c, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e4c3d, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e4c3e, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e4c3f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e4c40, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e4c42, 0x6)   sub(esp, 0x2c);                       /* sub esp, 0x2c */
    II(0x100e4c48, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100e4c4b, 0x4)   mov(memw_a32(ss, ebp - 0xc), cx);     /* mov [ebp-0xc], cx */
    II(0x100e4c4f, 0x3)   mov(memd_a32(ss, ebp - 0x10), ebx);   /* mov [ebp-0x10], ebx */
    II(0x100e4c52, 0x5)   mov(ebx, 0x1c);                       /* mov ebx, 0x1c */
    II(0x100e4c57, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100e4c59, 0x3)   lea(eax, ebp - 0x2c);                 /* lea eax, [ebp-0x2c] */
    II(0x100e4c5c, 0x5)   calld(sys_memset, 0x8117f);           /* call 0x10165de0 */
    II(0x100e4c61, 0x6)   mov(memw_a32(ss, ebp - 0x2c), 0x205); /* mov word [ebp-0x2c], 0x205 */
    II(0x100e4c67, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x100e4c6a, 0x3)   mov(memb_a32(ss, ebp - 0x28), al);    /* mov [ebp-0x28], al */
    II(0x100e4c6d, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100e4c70, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x10));   /* mov ebx, [ebp-0x10] */
    II(0x100e4c73, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x100e4c75, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x100e4c77, 0x4)   mov(memw_a32(ss, ebp - 0x24), dx);    /* mov [ebp-0x24], dx */
    II(0x100e4c7b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100e4c7e, 0x3)   mov(memd_a32(ss, ebp - 0x20), eax);   /* mov [ebp-0x20], eax */
    II(0x100e4c81, 0x3)   lea(ebx, ebp - 0x2c);                 /* lea ebx, [ebp-0x2c] */
    II(0x100e4c84, 0x3)   lea(edx, ebp - 0x2c);                 /* lea edx, [ebp-0x2c] */
    II(0x100e4c87, 0x5)   mov(eax, 0x31);                       /* mov eax, 0x31 */
    II(0x100e4c8c, 0x5)   calld(/* sys */ 0x1016c606, 0x87975); /* call 0x1016c606 */
    II(0x100e4c91, 0x4)   cmp(memd_a32(ss, ebp - 0x14), 0);     /* cmp dword [ebp-0x14], 0x0 */
    II(0x100e4c95, 0x2)   jnzd(0x100e4ca0, 0x9);                /* jnz 0x100e4ca0 */
    II(0x100e4c97, 0x7)   mov(memd_a32(ss, ebp - 0x4), 0);      /* mov dword [ebp-0x4], 0x0 */
    II(0x100e4c9e, 0x2)   jmpd(0x100e4ca7, 0x7);                /* jmp 0x100e4ca7 */
l_0x100e4ca0:
    II(0x100e4ca0, 0x7)   mov(memd_a32(ss, ebp - 0x4), 0x1);    /* mov dword [ebp-0x4], 0x1 */
l_0x100e4ca7:
    II(0x100e4ca7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e4caa, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e4cac, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e4cad, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e4cae, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e4caf, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e4cb0, 0x1)   retd();                               /* ret */
FUNC_END

