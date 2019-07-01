FUNC_BEGIN(0x10076338, 0x15a3f0933dc01492, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x10, 0xfa, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xfd, 0x7, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10076338, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1007633d, 0x5)   calld(sys_check_available_stack_size, 0xefa10); /* call 0x10165d52 */
    II(0x10076342, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10076343, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10076344, 0x1)   pushd(edx);                           /* push edx */
    II(0x10076345, 0x1)   pushd(esi);                           /* push esi */
    II(0x10076346, 0x1)   pushd(edi);                           /* push edi */
    II(0x10076347, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10076348, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007634a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10076350, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10076353, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10076356, 0x5)   calld(0x10076b58, 0x7fd);             /* call 0x10076b58 */
    II(0x1007635b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1007635e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10076361, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10076363, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10076364, 0x1)   popd(edi);                            /* pop edi */
    II(0x10076365, 0x1)   popd(esi);                            /* pop esi */
    II(0x10076366, 0x1)   popd(edx);                            /* pop edx */
    II(0x10076367, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10076368, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10076369, 0x1)   retd();                               /* ret */
FUNC_END

