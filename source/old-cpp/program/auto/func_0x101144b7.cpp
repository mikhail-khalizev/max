FUNC_BEGIN(0x101144b7, 0x5d6fa7bdab601709, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x91, 0x18, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xe8, 0x95, 0x9, 0xfc, 0xff, 0x31, 0xdb, 0x88, 0xc3, 0x31, 0xd2, 0xb8, 0x3, 0, 0, 0, 0xe8, 0x19, 0x16, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101144b7, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x101144bc, 0x5)   calld(sys_check_available_stack_size, 0x51891); /* call 0x10165d52 */
    II(0x101144c1, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101144c2, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101144c3, 0x1)   pushd(edx);                           /* push edx */
    II(0x101144c4, 0x1)   pushd(esi);                           /* push esi */
    II(0x101144c5, 0x1)   pushd(edi);                           /* push edi */
    II(0x101144c6, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101144c7, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101144c9, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x101144cf, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x101144d2, 0x5)   calld(0x100d4e6c, -0x3f66b);          /* call 0x100d4e6c */
    II(0x101144d7, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x101144d9, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x101144db, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x101144dd, 0x5)   mov(eax, 0x3);                        /* mov eax, 0x3 */
    II(0x101144e2, 0x5)   calld(0x10105b00, -0xe9e7);           /* call 0x10105b00 */
    II(0x101144e7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101144e9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101144ea, 0x1)   popd(edi);                            /* pop edi */
    II(0x101144eb, 0x1)   popd(esi);                            /* pop esi */
    II(0x101144ec, 0x1)   popd(edx);                            /* pop edx */
    II(0x101144ed, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101144ee, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101144ef, 0x1)   retd();                               /* ret */
FUNC_END

