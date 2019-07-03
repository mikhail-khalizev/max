FUNC_BEGIN(0x10117c3c, 0xc363441d7ab4670f, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xc, 0xe1, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x47, 0x26, 0x2, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10117c3c, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10117c41, 0x5)   calld(sys_check_available_stack_size, 0x4e10c); /* call 0x10165d52 */
    II(0x10117c46, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10117c47, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10117c48, 0x1)   pushd(esi);                           /* push esi */
    II(0x10117c49, 0x1)   pushd(edi);                           /* push edi */
    II(0x10117c4a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10117c4b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10117c4d, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10117c53, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10117c56, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10117c59, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x10117c5c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10117c5f, 0x5)   calld(0x1013a2ab, 0x22647);           /* call 0x1013a2ab */
    II(0x10117c64, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10117c66, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10117c67, 0x1)   popd(edi);                            /* pop edi */
    II(0x10117c68, 0x1)   popd(esi);                            /* pop esi */
    II(0x10117c69, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10117c6a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10117c6b, 0x1)   retd();                               /* ret */
FUNC_END

