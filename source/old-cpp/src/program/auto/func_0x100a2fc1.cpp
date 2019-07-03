FUNC_BEGIN(0x100a2fc1, 0x2abbce59f6b58afe, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x87, 0x2d, 0xc, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100a2fc1, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100a2fc6, 0x5)   calld(sys_check_available_stack_size, 0xc2d87); /* call 0x10165d52 */
    II(0x100a2fcb, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a2fcc, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a2fcd, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a2fce, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a2fcf, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a2fd0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a2fd2, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100a2fd8, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100a2fdb, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100a2fde, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a2fe0, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a2fe1, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a2fe2, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a2fe3, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a2fe4, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a2fe5, 0x1)   retd();                               /* ret */
FUNC_END

