FUNC_BEGIN(0x10107757, 0xcb062a8559bbe815, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xf1, 0xe5, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0xc7, 0x45, 0xfc, 0xa4, 0x4d, 0x1c, 0x10, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10107757, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1010775c, 0x5)   calld(sys_check_available_stack_size, 0x5e5f1); /* call 0x10165d52 */
    II(0x10107761, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10107762, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10107763, 0x1)   pushd(edx);                           /* push edx */
    II(0x10107764, 0x1)   pushd(esi);                           /* push esi */
    II(0x10107765, 0x1)   pushd(edi);                           /* push edi */
    II(0x10107766, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10107767, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10107769, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1010776f, 0x7)   mov(memd_a32(ss, ebp - 0x4), 0x101c4da4); /* mov dword [ebp-0x4], 0x101c4da4 */
    II(0x10107776, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10107779, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1010777b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1010777c, 0x1)   popd(edi);                            /* pop edi */
    II(0x1010777d, 0x1)   popd(esi);                            /* pop esi */
    II(0x1010777e, 0x1)   popd(edx);                            /* pop edx */
    II(0x1010777f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10107780, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10107781, 0x1)   retd();                               /* ret */
FUNC_END

