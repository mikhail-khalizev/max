FUNC_BEGIN(0x1013dc59, 0x8f6a0778896461be, 0x20, ({0x68, 0x3c, 0, 0, 0, 0xe8, 0xef, 0x80, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x24, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xb8, 0x3a, 0, 0, 0, 0xe8, 0x5c, 0x83, 0xf3, 0xff, 0x85, 0xc0, 0x75, 0x53, 0xc6, 0x45, 0xe6, 0x2, 0x8b, 0x45, 0xfc, 0x66, 0x89, 0x45, 0xdc, 0xc7, 0x45, 0xde, 0xff, 0x7f, 0, 0, 0xc7, 0x45, 0xe2, 0xff, 0x7f, 0, 0, 0xc7, 0x45, 0xe7, 0, 0x80, 0, 0, 0xc7, 0x45, 0xeb, 0, 0, 0, 0, 0x66, 0xc7, 0x45, 0xef, 0, 0, 0x66, 0xc7, 0x45, 0xf1, 0, 0, 0x66, 0xc7, 0x45, 0xf3, 0, 0, 0xc6, 0x45, 0xf5, 0, 0x66, 0xc7, 0x45, 0xf6, 0xff, 0xff, 0x8d, 0x55, 0xdc, 0x8b, 0x45, 0xf8, 0xe8, 0xff, 0x2, 0, 0, 0xe8, 0xc7, 0x7, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013dc59, 0x5)   pushd(0x3c);                          /* push dword 0x3c */
    II(0x1013dc5e, 0x5)   calld(sys_check_available_stack_size, 0x280ef); /* call 0x10165d52 */
    II(0x1013dc63, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013dc64, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013dc65, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013dc66, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013dc67, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013dc68, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013dc6a, 0x6)   sub(esp, 0x24);                       /* sub esp, 0x24 */
    II(0x1013dc70, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013dc73, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1013dc76, 0x5)   mov(eax, 0x3a);                       /* mov eax, 0x3a */
    II(0x1013dc7b, 0x5)   calld(0x10075fdc, -0xc7ca4);          /* call 0x10075fdc */
    II(0x1013dc80, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1013dc82, 0x2)   jnzd(0x1013dcd7, 0x53);               /* jnz 0x1013dcd7 */
    II(0x1013dc84, 0x4)   mov(memb_a32(ss, ebp - 0x1a), 0x2);   /* mov byte [ebp-0x1a], 0x2 */
    II(0x1013dc88, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013dc8b, 0x4)   mov(memw_a32(ss, ebp - 0x24), ax);    /* mov [ebp-0x24], ax */
    II(0x1013dc8f, 0x7)   mov(memd_a32(ss, ebp - 0x22), 0x7fff); /* mov dword [ebp-0x22], 0x7fff */
    II(0x1013dc96, 0x7)   mov(memd_a32(ss, ebp - 0x1e), 0x7fff); /* mov dword [ebp-0x1e], 0x7fff */
    II(0x1013dc9d, 0x7)   mov(memd_a32(ss, ebp - 0x19), 0x8000); /* mov dword [ebp-0x19], 0x8000 */
    II(0x1013dca4, 0x7)   mov(memd_a32(ss, ebp - 0x15), 0);     /* mov dword [ebp-0x15], 0x0 */
    II(0x1013dcab, 0x6)   mov(memw_a32(ss, ebp - 0x11), 0);     /* mov word [ebp-0x11], 0x0 */
    II(0x1013dcb1, 0x6)   mov(memw_a32(ss, ebp - 0xf), 0);      /* mov word [ebp-0xf], 0x0 */
    II(0x1013dcb7, 0x6)   mov(memw_a32(ss, ebp - 0xd), 0);      /* mov word [ebp-0xd], 0x0 */
    II(0x1013dcbd, 0x4)   mov(memb_a32(ss, ebp - 0xb), 0);      /* mov byte [ebp-0xb], 0x0 */
    II(0x1013dcc1, 0x6)   mov(memw_a32(ss, ebp - 0xa), 0xffff); /* mov word [ebp-0xa], 0xffff */
    II(0x1013dcc7, 0x3)   lea(edx, ebp - 0x24);                 /* lea edx, [ebp-0x24] */
    II(0x1013dcca, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013dccd, 0x5)   calld(0x1013dfd1, 0x2ff);             /* call 0x1013dfd1 */
    II(0x1013dcd2, 0x5)   calld(0x1013e49e, 0x7c7);             /* call 0x1013e49e */
l_0x1013dcd7:
    II(0x1013dcd7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013dcd9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013dcda, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013dcdb, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013dcdc, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013dcdd, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013dcde, 0x1)   retd();                               /* ret */
FUNC_END

