FUNC_BEGIN(0x100e0ab0, 0xe2db6f0169d30326, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x98, 0x52, 0x8, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0xc7, 0x45, 0xfc, 0x2, 0x36, 0x1c, 0x10, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100e0ab0, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100e0ab5, 0x5)   calld(sys_check_available_stack_size, 0x85298); /* call 0x10165d52 */
    II(0x100e0aba, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e0abb, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e0abc, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e0abd, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e0abe, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e0abf, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e0ac0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e0ac2, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100e0ac8, 0x7)   mov(memd_a32(ss, ebp - 0x4), 0x101c3602); /* mov dword [ebp-0x4], 0x101c3602 */
    II(0x100e0acf, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e0ad2, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e0ad4, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e0ad5, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e0ad6, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e0ad7, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e0ad8, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e0ad9, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e0ada, 0x1)   retd();                               /* ret */
FUNC_END

