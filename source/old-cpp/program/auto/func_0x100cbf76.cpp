FUNC_BEGIN(0x100cbf76, 0x43b4eda57261883d, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xd2, 0x9d, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0xd8, 0xa5, 0xfa, 0xff, 0x31, 0xd2, 0x8a, 0x50, 0x4d, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0xc8, 0xa5, 0xfa, 0xff, 0xe8, 0x8b, 0xa2, 0xfa, 0xff, 0x8b, 0x40, 0x8, 0xc1, 0xf8, 0x10, 0x39, 0xc2, 0x7c, 0x9, 0xc7, 0x45, 0xf8, 0x1, 0, 0, 0, 0xeb, 0x13, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0xa5, 0xa5, 0xfa, 0xff, 0xe8, 0x59, 0x41, 0x8, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cbf76, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100cbf7b, 0x5)   calld(sys_check_available_stack_size, 0x99dd2); /* call 0x10165d52 */
    II(0x100cbf80, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cbf81, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cbf82, 0x1)   pushd(edx);                           /* push edx */
    II(0x100cbf83, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cbf84, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cbf85, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cbf86, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cbf88, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100cbf8e, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100cbf91, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cbf94, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100cbf97, 0x5)   calld(0x10076574, -0x55a28);          /* call 0x10076574 */
    II(0x100cbf9c, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100cbf9e, 0x3)   mov(dl, memb_a32(ds, eax + 0x4d));    /* mov dl, [eax+0x4d] */
    II(0x100cbfa1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cbfa4, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100cbfa7, 0x5)   calld(0x10076574, -0x55a38);          /* call 0x10076574 */
    II(0x100cbfac, 0x5)   calld(0x1007623c, -0x55d75);          /* call 0x1007623c */
    II(0x100cbfb1, 0x3)   mov(eax, memd_a32(ds, eax + 0x8));    /* mov eax, [eax+0x8] */
    II(0x100cbfb4, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100cbfb7, 0x2)   cmp(edx, eax);                        /* cmp edx, eax */
    II(0x100cbfb9, 0x2)   jld(0x100cbfc4, 0x9);                 /* jl 0x100cbfc4 */
    II(0x100cbfbb, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x1);    /* mov dword [ebp-0x8], 0x1 */
    II(0x100cbfc2, 0x2)   jmpd(0x100cbfd7, 0x13);               /* jmp 0x100cbfd7 */
l_0x100cbfc4:
    II(0x100cbfc4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cbfc7, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100cbfca, 0x5)   calld(0x10076574, -0x55a5b);          /* call 0x10076574 */
    II(0x100cbfcf, 0x5)   calld(0x1015012d, 0x84159);           /* call 0x1015012d */
    II(0x100cbfd4, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
l_0x100cbfd7:
    II(0x100cbfd7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100cbfda, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cbfdc, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cbfdd, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cbfde, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cbfdf, 0x1)   popd(edx);                            /* pop edx */
    II(0x100cbfe0, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cbfe1, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cbfe2, 0x1)   retd();                               /* ret */
FUNC_END

