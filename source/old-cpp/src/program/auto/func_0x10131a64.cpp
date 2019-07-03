FUNC_BEGIN(0x10131a64, 0xf4edcff780b78d8d, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xe4, 0x42, 0x3, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0xc, 0xe8, 0x46, 0x4b, 0xf4, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10131a64, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10131a69, 0x5)   calld(sys_check_available_stack_size, 0x342e4); /* call 0x10165d52 */
    II(0x10131a6e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10131a6f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10131a70, 0x1)   pushd(edx);                           /* push edx */
    II(0x10131a71, 0x1)   pushd(esi);                           /* push esi */
    II(0x10131a72, 0x1)   pushd(edi);                           /* push edi */
    II(0x10131a73, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10131a74, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10131a76, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10131a7c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10131a7f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10131a82, 0x3)   add(eax, 0xc);                        /* add eax, 0xc */
    II(0x10131a85, 0x5)   calld(0x100765d0, -0xbb4ba);          /* call 0x100765d0 */
    II(0x10131a8a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10131a8d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10131a90, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10131a92, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10131a93, 0x1)   popd(edi);                            /* pop edi */
    II(0x10131a94, 0x1)   popd(esi);                            /* pop esi */
    II(0x10131a95, 0x1)   popd(edx);                            /* pop edx */
    II(0x10131a96, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10131a97, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10131a98, 0x1)   retd();                               /* ret */
FUNC_END

