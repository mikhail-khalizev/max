FUNC_BEGIN(0x1009c6c8, 0x39f6db3254b6b83a, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x80, 0x96, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x6d, 0xa4, 0xfd, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1009c6c8, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1009c6cd, 0x5)   calld(sys_check_available_stack_size, 0xc9680); /* call 0x10165d52 */
    II(0x1009c6d2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009c6d3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009c6d4, 0x1)   pushd(edx);                           /* push edx */
    II(0x1009c6d5, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009c6d6, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009c6d7, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009c6d8, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009c6da, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1009c6e0, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1009c6e3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009c6e6, 0x5)   calld(0x10076b58, -0x25b93);          /* call 0x10076b58 */
    II(0x1009c6eb, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1009c6ee, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009c6f1, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009c6f3, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009c6f4, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009c6f5, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009c6f6, 0x1)   popd(edx);                            /* pop edx */
    II(0x1009c6f7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009c6f8, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009c6f9, 0x1)   retd();                               /* ret */
FUNC_END

