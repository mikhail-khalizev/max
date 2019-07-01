FUNC_BEGIN(0x1013168d, 0x2370f6391b6f47eb, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xbb, 0x46, 0x3, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xe8, 0xbd, 0x37, 0xfa, 0xff, 0x31, 0xdb, 0x88, 0xc3, 0x31, 0xd2, 0xb8, 0x1d, 0, 0, 0, 0xe8, 0x41, 0x44, 0xfd, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013168d, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10131692, 0x5)   calld(sys_check_available_stack_size, 0x346bb); /* call 0x10165d52 */
    II(0x10131697, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10131698, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10131699, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013169a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013169b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013169c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013169e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x101316a4, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x101316a7, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x101316aa, 0x5)   calld(0x100d4e6c, -0x5c843);          /* call 0x100d4e6c */
    II(0x101316af, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x101316b1, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x101316b3, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x101316b5, 0x5)   mov(eax, 0x1d);                       /* mov eax, 0x1d */
    II(0x101316ba, 0x5)   calld(0x10105b00, -0x2bbbf);          /* call 0x10105b00 */
    II(0x101316bf, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101316c1, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101316c2, 0x1)   popd(edi);                            /* pop edi */
    II(0x101316c3, 0x1)   popd(esi);                            /* pop esi */
    II(0x101316c4, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101316c5, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101316c6, 0x1)   retd();                               /* ret */
FUNC_END

