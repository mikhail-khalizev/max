FUNC_BEGIN(0x10089a74, 0xc380b61a09043f26, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xd4, 0xc2, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0x9e, 0xc8, 0xfe, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10089a74, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10089a79, 0x5)   calld(sys_check_available_stack_size, 0xdc2d4); /* call 0x10165d52 */
    II(0x10089a7e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10089a7f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10089a80, 0x1)   pushd(edx);                           /* push edx */
    II(0x10089a81, 0x1)   pushd(esi);                           /* push esi */
    II(0x10089a82, 0x1)   pushd(edi);                           /* push edi */
    II(0x10089a83, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10089a84, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10089a86, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10089a8c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10089a8f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10089a92, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x10089a95, 0x5)   calld(0x10076338, -0x13762);          /* call 0x10076338 */
    II(0x10089a9a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10089a9d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10089aa0, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10089aa2, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10089aa3, 0x1)   popd(edi);                            /* pop edi */
    II(0x10089aa4, 0x1)   popd(esi);                            /* pop esi */
    II(0x10089aa5, 0x1)   popd(edx);                            /* pop edx */
    II(0x10089aa6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10089aa7, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10089aa8, 0x1)   retd();                               /* ret */
FUNC_END

