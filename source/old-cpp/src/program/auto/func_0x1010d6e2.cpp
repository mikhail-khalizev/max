FUNC_BEGIN(0x1010d6e2, 0x55f21d4cd61060df, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x66, 0x86, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xe8, 0x6a, 0x77, 0xfc, 0xff, 0x31, 0xdb, 0x88, 0xc3, 0x31, 0xd2, 0xb8, 0x2, 0, 0, 0, 0xe8, 0xee, 0x83, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1010d6e2, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1010d6e7, 0x5)   calld(sys_check_available_stack_size, 0x58666); /* call 0x10165d52 */
    II(0x1010d6ec, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1010d6ed, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1010d6ee, 0x1)   pushd(edx);                           /* push edx */
    II(0x1010d6ef, 0x1)   pushd(esi);                           /* push esi */
    II(0x1010d6f0, 0x1)   pushd(edi);                           /* push edi */
    II(0x1010d6f1, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1010d6f2, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1010d6f4, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1010d6fa, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1010d6fd, 0x5)   calld(0x100d4e6c, -0x38896);          /* call 0x100d4e6c */
    II(0x1010d702, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1010d704, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x1010d706, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1010d708, 0x5)   mov(eax, 0x2);                        /* mov eax, 0x2 */
    II(0x1010d70d, 0x5)   calld(0x10105b00, -0x7c12);           /* call 0x10105b00 */
    II(0x1010d712, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1010d714, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1010d715, 0x1)   popd(edi);                            /* pop edi */
    II(0x1010d716, 0x1)   popd(esi);                            /* pop esi */
    II(0x1010d717, 0x1)   popd(edx);                            /* pop edx */
    II(0x1010d718, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1010d719, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1010d71a, 0x1)   retd();                               /* ret */
FUNC_END

