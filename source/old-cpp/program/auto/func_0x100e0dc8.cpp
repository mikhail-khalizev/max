FUNC_BEGIN(0x100e0dc8, 0x9e1bf71ced57c158, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x80, 0x4f, 0x8, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xbb, 0x2, 0, 0, 0, 0x8d, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x60, 0xb2, 0x5, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100e0dc8, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100e0dcd, 0x5)   calld(sys_check_available_stack_size, 0x84f80); /* call 0x10165d52 */
    II(0x100e0dd2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e0dd3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e0dd4, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e0dd5, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e0dd6, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e0dd7, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e0dd9, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100e0ddf, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100e0de2, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100e0de5, 0x5)   mov(ebx, 0x2);                        /* mov ebx, 0x2 */
    II(0x100e0dea, 0x3)   lea(edx, ebp - 0x4);                  /* lea edx, [ebp-0x4] */
    II(0x100e0ded, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e0df0, 0x5)   calld(0x1013c055, 0x5b260);           /* call 0x1013c055 */
    II(0x100e0df5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e0df7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e0df8, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e0df9, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e0dfa, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e0dfb, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e0dfc, 0x1)   retd();                               /* ret */
FUNC_END

