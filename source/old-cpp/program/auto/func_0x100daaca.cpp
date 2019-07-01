FUNC_BEGIN(0x100daaca, 0xf3dcdcc62cf3d038, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x7e, 0xb2, 0x8, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100daaca, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100daacf, 0x5)   calld(sys_check_available_stack_size, 0x8b27e); /* call 0x10165d52 */
    II(0x100daad4, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100daad5, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100daad6, 0x1)   pushd(esi);                           /* push esi */
    II(0x100daad7, 0x1)   pushd(edi);                           /* push edi */
    II(0x100daad8, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100daad9, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100daadb, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100daae1, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100daae4, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100daae7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100daae9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100daaea, 0x1)   popd(edi);                            /* pop edi */
    II(0x100daaeb, 0x1)   popd(esi);                            /* pop esi */
    II(0x100daaec, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100daaed, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100daaee, 0x1)   retd();                               /* ret */
FUNC_END

