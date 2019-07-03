FUNC_BEGIN(0x100b7a48, 0x89695eae3c92b28, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0, 0xe3, 0xa, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xc5, 0xf1, 0xfb, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b7a48, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b7a4d, 0x5)   calld(sys_check_available_stack_size, 0xae300); /* call 0x10165d52 */
    II(0x100b7a52, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b7a53, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b7a54, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b7a55, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b7a56, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b7a57, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b7a58, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b7a5a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b7a60, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100b7a63, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b7a66, 0x5)   calld(0x10076c30, -0x40e3b);          /* call 0x10076c30 */
    II(0x100b7a6b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100b7a6e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b7a71, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b7a73, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b7a74, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b7a75, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b7a76, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b7a77, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b7a78, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b7a79, 0x1)   retd();                               /* ret */
FUNC_END

