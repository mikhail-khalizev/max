FUNC_BEGIN(0x1007b892, 0x8f31527ddc61881b, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xb6, 0xa4, 0xe, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xe8, 0x28, 0xec, 0, 0, 0x31, 0xdb, 0x88, 0xc3, 0x8b, 0x55, 0xf8, 0x83, 0xc2, 0x2d, 0x8b, 0x45, 0xfc, 0xe8, 0x3f, 0xcc, 0x3, 0, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1007b892, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1007b897, 0x5)   calld(sys_check_available_stack_size, 0xea4b6); /* call 0x10165d52 */
    II(0x1007b89c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1007b89d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1007b89e, 0x1)   pushd(esi);                           /* push esi */
    II(0x1007b89f, 0x1)   pushd(edi);                           /* push edi */
    II(0x1007b8a0, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1007b8a1, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007b8a3, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1007b8a9, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1007b8ac, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1007b8af, 0x5)   calld(0x1008a4dc, 0xec28);            /* call 0x1008a4dc */
    II(0x1007b8b4, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1007b8b6, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x1007b8b8, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1007b8bb, 0x3)   add(edx, 0x2d);                       /* add edx, 0x2d */
    II(0x1007b8be, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007b8c1, 0x5)   calld(0x100b8505, 0x3cc3f);           /* call 0x100b8505 */
    II(0x1007b8c6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007b8c9, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1007b8cb, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1007b8cc, 0x1)   popd(edi);                            /* pop edi */
    II(0x1007b8cd, 0x1)   popd(esi);                            /* pop esi */
    II(0x1007b8ce, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1007b8cf, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1007b8d0, 0x1)   retd();                               /* ret */
FUNC_END

