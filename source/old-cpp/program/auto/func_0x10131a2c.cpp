FUNC_BEGIN(0x10131a2c, 0x64b6807e1642d611, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x1c, 0x43, 0x3, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0xa, 0xe8, 0x76, 0x7d, 0xf5, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10131a2c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10131a31, 0x5)   calld(sys_check_available_stack_size, 0x3431c); /* call 0x10165d52 */
    II(0x10131a36, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10131a37, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10131a38, 0x1)   pushd(edx);                           /* push edx */
    II(0x10131a39, 0x1)   pushd(esi);                           /* push esi */
    II(0x10131a3a, 0x1)   pushd(edi);                           /* push edi */
    II(0x10131a3b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10131a3c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10131a3e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10131a44, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10131a47, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10131a4a, 0x3)   add(eax, 0xa);                        /* add eax, 0xa */
    II(0x10131a4d, 0x5)   calld(my_strobj_c_str_v2, -0xa828a);  /* call 0x100897c8 */
    II(0x10131a52, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10131a55, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10131a58, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10131a5a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10131a5b, 0x1)   popd(edi);                            /* pop edi */
    II(0x10131a5c, 0x1)   popd(esi);                            /* pop esi */
    II(0x10131a5d, 0x1)   popd(edx);                            /* pop edx */
    II(0x10131a5e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10131a5f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10131a60, 0x1)   retd();                               /* ret */
FUNC_END

