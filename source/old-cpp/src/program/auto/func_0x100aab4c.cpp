FUNC_BEGIN(0x100aab4c, 0xc084546e5b94337, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xfc, 0xb1, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xc1, 0xc0, 0xfc, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100aab4c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100aab51, 0x5)   calld(sys_check_available_stack_size, 0xbb1fc); /* call 0x10165d52 */
    II(0x100aab56, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100aab57, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100aab58, 0x1)   pushd(edx);                           /* push edx */
    II(0x100aab59, 0x1)   pushd(esi);                           /* push esi */
    II(0x100aab5a, 0x1)   pushd(edi);                           /* push edi */
    II(0x100aab5b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100aab5c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100aab5e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100aab64, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100aab67, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100aab6a, 0x5)   calld(0x10076c30, -0x33f3f);          /* call 0x10076c30 */
    II(0x100aab6f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100aab72, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100aab75, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100aab77, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100aab78, 0x1)   popd(edi);                            /* pop edi */
    II(0x100aab79, 0x1)   popd(esi);                            /* pop esi */
    II(0x100aab7a, 0x1)   popd(edx);                            /* pop edx */
    II(0x100aab7b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100aab7c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100aab7d, 0x1)   retd();                               /* ret */
FUNC_END

