FUNC_BEGIN(0x100a2f9c, 0xac251a06076578b7, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xac, 0x2d, 0xc, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100a2f9c, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100a2fa1, 0x5)   calld(sys_check_available_stack_size, 0xc2dac); /* call 0x10165d52 */
    II(0x100a2fa6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a2fa7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a2fa8, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a2fa9, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a2faa, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a2fab, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a2fad, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100a2fb3, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100a2fb6, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100a2fb9, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a2fbb, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a2fbc, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a2fbd, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a2fbe, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a2fbf, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a2fc0, 0x1)   retd();                               /* ret */
FUNC_END

