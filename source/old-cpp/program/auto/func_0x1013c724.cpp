FUNC_BEGIN(0x1013c724, 0xb9a0bf668928d4e, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x24, 0x96, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x11, 0xa4, 0xf3, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1013c724, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1013c729, 0x5)   calld(sys_check_available_stack_size, 0x29624); /* call 0x10165d52 */
    II(0x1013c72e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013c72f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013c730, 0x1)   pushd(edx);                           /* push edx */
    II(0x1013c731, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013c732, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013c733, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013c734, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013c736, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1013c73c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1013c73f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c742, 0x5)   calld(0x10076b58, -0xc5bef);          /* call 0x10076b58 */
    II(0x1013c747, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1013c74a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013c74d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013c74f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013c750, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013c751, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013c752, 0x1)   popd(edx);                            /* pop edx */
    II(0x1013c753, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013c754, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013c755, 0x1)   retd();                               /* ret */
FUNC_END

