FUNC_BEGIN(0x10126a47, 0x47f950ed27182121, 0x20, ({0x68, 0x90, 0, 0, 0, 0xe8, 0x1, 0xf3, 0x3, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x68, 0, 0, 0, 0x89, 0x45, 0xfc, 0xf, 0xbf, 0x45, 0xfc, 0x50, 0xb8, 0xd2, 0x81, 0x1a, 0x10, 0x50, 0x8d, 0x45, 0x98, 0x50, 0xe8, 0x8b, 0xf4, 0x3, 0, 0x83, 0xc4, 0xc, 0xb8, 0x1, 0, 0, 0, 0x50, 0x31, 0xc9, 0xbb, 0x1, 0, 0, 0, 0xba, 0x2, 0, 0, 0, 0x8d, 0x45, 0x98, 0xe8, 0x90, 0xf2, 0xfe, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10126a47, 0x5)   pushd(0x90);                          /* push dword 0x90 */
    II(0x10126a4c, 0x5)   calld(sys_check_available_stack_size, 0x3f301); /* call 0x10165d52 */
    II(0x10126a51, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10126a52, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10126a53, 0x1)   pushd(edx);                           /* push edx */
    II(0x10126a54, 0x1)   pushd(esi);                           /* push esi */
    II(0x10126a55, 0x1)   pushd(edi);                           /* push edi */
    II(0x10126a56, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10126a57, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10126a59, 0x6)   sub(esp, 0x68);                       /* sub esp, 0x68 */
    II(0x10126a5f, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10126a62, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x10126a66, 0x1)   pushd(eax);                           /* push eax */
    II(0x10126a67, 0x5)   mov(eax, 0x101a81d2);                 /* mov eax, 0x101a81d2 */ /* "Unknown unit, id %i, referenced in remote packet." */
    II(0x10126a6c, 0x1)   pushd(eax);                           /* push eax */
    II(0x10126a6d, 0x3)   lea(eax, ebp - 0x68);                 /* lea eax, [ebp-0x68] */
    II(0x10126a70, 0x1)   pushd(eax);                           /* push eax */
    II(0x10126a71, 0x5)   calld(sys_sprintf, 0x3f48b);          /* call 0x10165f01 */
    II(0x10126a76, 0x3)   add(esp, 0xc);                        /* add esp, 0xc */
    II(0x10126a79, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
    II(0x10126a7e, 0x1)   pushd(eax);                           /* push eax */
    II(0x10126a7f, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x10126a81, 0x5)   mov(ebx, 0x1);                        /* mov ebx, 0x1 */
    II(0x10126a86, 0x5)   mov(edx, 0x2);                        /* mov edx, 0x2 */
    II(0x10126a8b, 0x3)   lea(eax, ebp - 0x68);                 /* lea eax, [ebp-0x68] */
    II(0x10126a8e, 0x5)   calld(0x10115d23, -0x10d70);          /* call 0x10115d23 */
    II(0x10126a93, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10126a95, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10126a96, 0x1)   popd(edi);                            /* pop edi */
    II(0x10126a97, 0x1)   popd(esi);                            /* pop esi */
    II(0x10126a98, 0x1)   popd(edx);                            /* pop edx */
    II(0x10126a99, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10126a9a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10126a9b, 0x1)   retd();                               /* ret */
FUNC_END

