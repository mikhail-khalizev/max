FUNC_BEGIN(0x100a86b4, 0xfff4effd8979acf7, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x94, 0xd6, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xe8, 0xb4, 0x2b, 0, 0, 0x31, 0xd2, 0x88, 0xc2, 0x8b, 0x45, 0xfc, 0xe8, 0x1f, 0xa2, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100a86b4, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100a86b9, 0x5)   calld(sys_check_available_stack_size, 0xbd694); /* call 0x10165d52 */
    II(0x100a86be, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a86bf, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a86c0, 0x1)   pushd(edx);                           /* push edx */
    II(0x100a86c1, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a86c2, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a86c3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a86c4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a86c6, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100a86cc, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100a86cf, 0x5)   calld(0x100ab288, 0x2bb4);            /* call 0x100ab288 */
    II(0x100a86d4, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100a86d6, 0x2)   mov(dl, al);                          /* mov dl, al */
    II(0x100a86d8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100a86db, 0x5)   calld(0x100a28ff, -0x5de1);           /* call 0x100a28ff */
    II(0x100a86e0, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a86e2, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a86e3, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a86e4, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a86e5, 0x1)   popd(edx);                            /* pop edx */
    II(0x100a86e6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a86e7, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a86e8, 0x1)   retd();                               /* ret */
FUNC_END

