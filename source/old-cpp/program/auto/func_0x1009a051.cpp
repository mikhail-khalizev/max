FUNC_BEGIN(0x1009a051, 0xfff2bcb818dacdd4, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xf7, 0xbc, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0x49, 0x23, 0, 0, 0xe8, 0xd0, 0xe2, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1009a051, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1009a056, 0x5)   calld(sys_check_available_stack_size, 0xcbcf7); /* call 0x10165d52 */
    II(0x1009a05b, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009a05c, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009a05d, 0x1)   pushd(edx);                           /* push edx */
    II(0x1009a05e, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009a05f, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009a060, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009a061, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009a063, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1009a069, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1009a06c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009a06f, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x1009a072, 0x5)   calld(0x1009c3c0, 0x2349);            /* call 0x1009c3c0 */
    II(0x1009a077, 0x5)   calld(0x1009834c, -0x1d30);           /* call 0x1009834c */
    II(0x1009a07c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009a07e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009a07f, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009a080, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009a081, 0x1)   popd(edx);                            /* pop edx */
    II(0x1009a082, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009a083, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009a084, 0x1)   retd();                               /* ret */
FUNC_END

