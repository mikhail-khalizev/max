FUNC_BEGIN(0x100e0284, 0xff4e14a19460f6eb, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xc4, 0x5a, 0x8, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x4, 0xe8, 0x96, 0xff, 0xff, 0xff, 0x83, 0xe8, 0x4, 0x89, 0x45, 0xf8, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0xe8, 0x46, 0x88, 0xfa, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100e0284, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100e0289, 0x5)   calld(sys_check_available_stack_size, 0x85ac4); /* call 0x10165d52 */
    II(0x100e028e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e028f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e0290, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e0291, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e0292, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e0293, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e0295, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100e029b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100e029e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100e02a1, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100e02a3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e02a6, 0x3)   add(eax, 0x4);                        /* add eax, 0x4 */
    II(0x100e02a9, 0x5)   calld(0x100e0244, -0x6a);             /* call 0x100e0244 */
    II(0x100e02ae, 0x3)   sub(eax, 0x4);                        /* sub eax, 0x4 */
    II(0x100e02b1, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100e02b4, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100e02b6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e02b9, 0x5)   calld(0x10088b04, -0x577ba);          /* call 0x10088b04 */
    II(0x100e02be, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100e02c1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e02c4, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100e02c7, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100e02ca, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e02cc, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e02cd, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e02ce, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e02cf, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e02d0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e02d1, 0x1)   retd();                               /* ret */
FUNC_END

