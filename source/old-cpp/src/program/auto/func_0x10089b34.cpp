FUNC_BEGIN(0x10089b34, 0xf2d67b7205da82d2, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x14, 0xc2, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xd9, 0xd0, 0xfe, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10089b34, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10089b39, 0x5)   calld(sys_check_available_stack_size, 0xdc214); /* call 0x10165d52 */
    II(0x10089b3e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10089b3f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10089b40, 0x1)   pushd(edx);                           /* push edx */
    II(0x10089b41, 0x1)   pushd(esi);                           /* push esi */
    II(0x10089b42, 0x1)   pushd(edi);                           /* push edi */
    II(0x10089b43, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10089b44, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10089b46, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10089b4c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10089b4f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10089b52, 0x5)   calld(0x10076c30, -0x12f27);          /* call 0x10076c30 */
    II(0x10089b57, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10089b5a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10089b5d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10089b5f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10089b60, 0x1)   popd(edi);                            /* pop edi */
    II(0x10089b61, 0x1)   popd(esi);                            /* pop esi */
    II(0x10089b62, 0x1)   popd(edx);                            /* pop edx */
    II(0x10089b63, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10089b64, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10089b65, 0x1)   retd();                               /* ret */
FUNC_END

