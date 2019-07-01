FUNC_BEGIN(0x10164aa0, 0x2020bc148937e7a0, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xa8, 0x12, 0, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x95, 0x20, 0xf1, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10164aa0, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10164aa5, 0x5)   calld(sys_check_available_stack_size, 0x12a8); /* call 0x10165d52 */
    II(0x10164aaa, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10164aab, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10164aac, 0x1)   pushd(edx);                           /* push edx */
    II(0x10164aad, 0x1)   pushd(esi);                           /* push esi */
    II(0x10164aae, 0x1)   pushd(edi);                           /* push edi */
    II(0x10164aaf, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10164ab0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10164ab2, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10164ab8, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10164abb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10164abe, 0x5)   calld(0x10076b58, -0xedf6b);          /* call 0x10076b58 */
    II(0x10164ac3, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10164ac6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10164ac9, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10164acb, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10164acc, 0x1)   popd(edi);                            /* pop edi */
    II(0x10164acd, 0x1)   popd(esi);                            /* pop esi */
    II(0x10164ace, 0x1)   popd(edx);                            /* pop edx */
    II(0x10164acf, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10164ad0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10164ad1, 0x1)   retd();                               /* ret */
FUNC_END

