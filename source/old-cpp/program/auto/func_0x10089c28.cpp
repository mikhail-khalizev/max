FUNC_BEGIN(0x10089c28, 0xa19e1fc83795258, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x20, 0xc1, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xd, 0xd1, 0xfe, 0xff, 0x89, 0x45, 0xfc, 0x8d, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10089c28, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x10089c2d, 0x5)   calld(sys_check_available_stack_size, 0xdc120); /* call 0x10165d52 */
    II(0x10089c32, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10089c33, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10089c34, 0x1)   pushd(edx);                           /* push edx */
    II(0x10089c35, 0x1)   pushd(esi);                           /* push esi */
    II(0x10089c36, 0x1)   pushd(edi);                           /* push edi */
    II(0x10089c37, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10089c38, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10089c3a, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10089c40, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10089c43, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10089c46, 0x5)   calld(0x10076d58, -0x12ef3);          /* call 0x10076d58 */
    II(0x10089c4b, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10089c4e, 0x3)   lea(eax, ebp - 0x4);                  /* lea eax, [ebp-0x4] */
    II(0x10089c51, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10089c54, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10089c57, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x10089c5a, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10089c5d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10089c5f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10089c60, 0x1)   popd(edi);                            /* pop edi */
    II(0x10089c61, 0x1)   popd(esi);                            /* pop esi */
    II(0x10089c62, 0x1)   popd(edx);                            /* pop edx */
    II(0x10089c63, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10089c64, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10089c65, 0x1)   retd();                               /* ret */
FUNC_END

