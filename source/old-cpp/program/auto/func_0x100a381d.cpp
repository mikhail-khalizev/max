FUNC_BEGIN(0x100a381d, 0xdb6b70289f959d6b, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x2b, 0x25, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc7, 0x45, 0xf8, 0, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100a381d, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100a3822, 0x5)   calld(sys_check_available_stack_size, 0xc252b); /* call 0x10165d52 */
    II(0x100a3827, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a3828, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a3829, 0x1)   pushd(edx);                           /* push edx */
    II(0x100a382a, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a382b, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a382c, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a382d, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a382f, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100a3835, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100a3838, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0);      /* mov dword [ebp-0x8], 0x0 */
    II(0x100a383f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100a3842, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a3844, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a3845, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a3846, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a3847, 0x1)   popd(edx);                            /* pop edx */
    II(0x100a3848, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a3849, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a384a, 0x1)   retd();                               /* ret */
FUNC_END

