FUNC_BEGIN(0x100a11a0, 0xe2edf5f730c795ca, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xa8, 0x4b, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100a11a0, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100a11a5, 0x5)   calld(sys_check_available_stack_size, 0xc4ba8); /* call 0x10165d52 */
    II(0x100a11aa, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a11ab, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a11ac, 0x1)   pushd(edx);                           /* push edx */
    II(0x100a11ad, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a11ae, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a11af, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a11b0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a11b2, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100a11b8, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100a11bb, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a11bd, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a11be, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a11bf, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a11c0, 0x1)   popd(edx);                            /* pop edx */
    II(0x100a11c1, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a11c2, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a11c3, 0x1)   retd();                               /* ret */
FUNC_END

