FUNC_BEGIN(0x100cb9d5, 0xf28827d8d0723dc, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x73, 0xa3, 0x9, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x13, 0xe8, 0x74, 0xab, 0xfa, 0xff, 0xe8, 0x2d, 0x6b, 0x8, 0, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100cb9d5, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100cb9da, 0x5)   calld(sys_check_available_stack_size, 0x9a373); /* call 0x10165d52 */
    II(0x100cb9df, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cb9e0, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cb9e1, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cb9e2, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cb9e3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cb9e4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cb9e6, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100cb9ec, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100cb9ef, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100cb9f2, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x100cb9f5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100cb9f8, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100cb9fb, 0x5)   calld(0x10076574, -0x5548c);          /* call 0x10076574 */
    II(0x100cba00, 0x5)   calld(0x10152532, 0x86b2d);           /* call 0x10152532 */
    II(0x100cba05, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cba08, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100cba0b, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100cba0e, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cba10, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cba11, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cba12, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cba13, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cba14, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cba15, 0x1)   retd();                               /* ret */
FUNC_END

