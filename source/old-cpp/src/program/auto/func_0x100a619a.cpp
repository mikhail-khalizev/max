FUNC_BEGIN(0x100a619a, 0xebae6837fb680a05, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xae, 0xfb, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0xa8, 0x51, 0xfe, 0xff, 0x98, 0x1, 0xc0, 0x83, 0xc0, 0x4, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100a619a, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100a619f, 0x5)   calld(sys_check_available_stack_size, 0xbfbae); /* call 0x10165d52 */
    II(0x100a61a4, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a61a5, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a61a6, 0x1)   pushd(edx);                           /* push edx */
    II(0x100a61a7, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a61a8, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a61a9, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a61aa, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a61ac, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100a61b2, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100a61b5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100a61b8, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100a61bb, 0x5)   calld(my_2_get_count, -0x1ae58);      /* call 0x1008b368 */
    II(0x100a61c0, 0x1)   cwde();                               /* cwde */
    II(0x100a61c1, 0x2)   add(eax, eax);                        /* add eax, eax */
    II(0x100a61c3, 0x3)   add(eax, 0x4);                        /* add eax, 0x4 */
    II(0x100a61c6, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100a61c9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100a61cc, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a61ce, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a61cf, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a61d0, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a61d1, 0x1)   popd(edx);                            /* pop edx */
    II(0x100a61d2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a61d3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a61d4, 0x1)   retd();                               /* ret */
FUNC_END

