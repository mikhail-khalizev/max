FUNC_BEGIN(0x100e0cc0, 0x24e02a7247f422a, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x88, 0x50, 0x8, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xc3, 0x95, 0x5, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100e0cc0, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100e0cc5, 0x5)   calld(sys_check_available_stack_size, 0x85088); /* call 0x10165d52 */
    II(0x100e0cca, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e0ccb, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e0ccc, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e0ccd, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e0cce, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e0ccf, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e0cd1, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100e0cd7, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100e0cda, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100e0cdd, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x100e0ce0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e0ce3, 0x5)   calld(0x1013a2ab, 0x595c3);           /* call 0x1013a2ab */
    II(0x100e0ce8, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e0cea, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e0ceb, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e0cec, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e0ced, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e0cee, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e0cef, 0x1)   retd();                               /* ret */
FUNC_END

