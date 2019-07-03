FUNC_BEGIN(0x1013aa3c, 0x1341e2e0b75e4598, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xc, 0xb3, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x9, 0xc2, 0xf3, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1013aa3c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1013aa41, 0x5)   calld(sys_check_available_stack_size, 0x2b30c); /* call 0x10165d52 */
    II(0x1013aa46, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013aa47, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013aa48, 0x1)   pushd(edx);                           /* push edx */
    II(0x1013aa49, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013aa4a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013aa4b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013aa4c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013aa4e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1013aa54, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1013aa57, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013aa5a, 0x5)   calld(0x10076c68, -0xc3df7);          /* call 0x10076c68 */
    II(0x1013aa5f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1013aa62, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013aa65, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013aa67, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013aa68, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013aa69, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013aa6a, 0x1)   popd(edx);                            /* pop edx */
    II(0x1013aa6b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013aa6c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013aa6d, 0x1)   retd();                               /* ret */
FUNC_END

