FUNC_BEGIN(0x100ab0ac, 0xfbf31a2637dfd8ff, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x9c, 0xac, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x89, 0xba, 0xfc, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100ab0ac, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100ab0b1, 0x5)   calld(sys_check_available_stack_size, 0xbac9c); /* call 0x10165d52 */
    II(0x100ab0b6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ab0b7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ab0b8, 0x1)   pushd(edx);                           /* push edx */
    II(0x100ab0b9, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ab0ba, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ab0bb, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ab0bc, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ab0be, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100ab0c4, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100ab0c7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100ab0ca, 0x5)   calld(0x10076b58, -0x34577);          /* call 0x10076b58 */
    II(0x100ab0cf, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100ab0d2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ab0d5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ab0d7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ab0d8, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ab0d9, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ab0da, 0x1)   popd(edx);                            /* pop edx */
    II(0x100ab0db, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ab0dc, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ab0dd, 0x1)   retd();                               /* ret */
FUNC_END

