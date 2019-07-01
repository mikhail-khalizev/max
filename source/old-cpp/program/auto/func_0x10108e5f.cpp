FUNC_BEGIN(0x10108e5f, 0x982a4508485e30a1, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xe9, 0xce, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xe8, 0xed, 0xbf, 0xfc, 0xff, 0x31, 0xdb, 0x88, 0xc3, 0x31, 0xd2, 0xb8, 0x1, 0, 0, 0, 0xe8, 0x71, 0xcc, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10108e5f, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10108e64, 0x5)   calld(sys_check_available_stack_size, 0x5cee9); /* call 0x10165d52 */
    II(0x10108e69, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10108e6a, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10108e6b, 0x1)   pushd(edx);                           /* push edx */
    II(0x10108e6c, 0x1)   pushd(esi);                           /* push esi */
    II(0x10108e6d, 0x1)   pushd(edi);                           /* push edi */
    II(0x10108e6e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10108e6f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10108e71, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10108e77, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10108e7a, 0x5)   calld(0x100d4e6c, -0x34013);          /* call 0x100d4e6c */
    II(0x10108e7f, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x10108e81, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x10108e83, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10108e85, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
    II(0x10108e8a, 0x5)   calld(0x10105b00, -0x338f);           /* call 0x10105b00 */
    II(0x10108e8f, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10108e91, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10108e92, 0x1)   popd(edi);                            /* pop edi */
    II(0x10108e93, 0x1)   popd(esi);                            /* pop esi */
    II(0x10108e94, 0x1)   popd(edx);                            /* pop edx */
    II(0x10108e95, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10108e96, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10108e97, 0x1)   retd();                               /* ret */
FUNC_END

