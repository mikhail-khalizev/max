FUNC_BEGIN(0x100ba098, 0xc05c7744d7a0c5e0, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xb0, 0xbc, 0xa, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x43, 0xe8, 0x42, 0xf, 0x1, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100ba098, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100ba09d, 0x5)   calld(sys_check_available_stack_size, 0xabcb0); /* call 0x10165d52 */
    II(0x100ba0a2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ba0a3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ba0a4, 0x1)   pushd(edx);                           /* push edx */
    II(0x100ba0a5, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ba0a6, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ba0a7, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ba0a8, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ba0aa, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100ba0b0, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100ba0b3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100ba0b6, 0x3)   add(eax, 0x43);                       /* add eax, 0x43 */
    II(0x100ba0b9, 0x5)   calld(0x100cb000, 0x10f42);           /* call 0x100cb000 */
    II(0x100ba0be, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100ba0c1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ba0c4, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ba0c6, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ba0c7, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ba0c8, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ba0c9, 0x1)   popd(edx);                            /* pop edx */
    II(0x100ba0ca, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ba0cb, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ba0cc, 0x1)   retd();                               /* ret */
FUNC_END

