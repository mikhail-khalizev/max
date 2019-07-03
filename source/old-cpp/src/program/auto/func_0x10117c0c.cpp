FUNC_BEGIN(0x10117c0c, 0x999405e2f8665a8d, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x3c, 0xe1, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x7b, 0x29, 0x2, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10117c0c, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10117c11, 0x5)   calld(sys_check_available_stack_size, 0x4e13c); /* call 0x10165d52 */
    II(0x10117c16, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10117c17, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10117c18, 0x1)   pushd(esi);                           /* push esi */
    II(0x10117c19, 0x1)   pushd(edi);                           /* push edi */
    II(0x10117c1a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10117c1b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10117c1d, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10117c23, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10117c26, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10117c29, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x10117c2c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10117c2f, 0x5)   calld(0x1013a5af, 0x2297b);           /* call 0x1013a5af */
    II(0x10117c34, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10117c36, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10117c37, 0x1)   popd(edi);                            /* pop edi */
    II(0x10117c38, 0x1)   popd(esi);                            /* pop esi */
    II(0x10117c39, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10117c3a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10117c3b, 0x1)   retd();                               /* ret */
FUNC_END

