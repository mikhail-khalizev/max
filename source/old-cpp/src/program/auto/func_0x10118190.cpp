FUNC_BEGIN(0x10118190, 0xbf1b7eb162cda2fe, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xb8, 0xdb, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10118190, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10118195, 0x5)   calld(sys_check_available_stack_size, 0x4dbb8); /* call 0x10165d52 */
    II(0x1011819a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011819b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011819c, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011819d, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011819e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011819f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101181a1, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x101181a7, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x101181aa, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x101181ad, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101181af, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101181b0, 0x1)   popd(edi);                            /* pop edi */
    II(0x101181b1, 0x1)   popd(esi);                            /* pop esi */
    II(0x101181b2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101181b3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101181b4, 0x1)   retd();                               /* ret */
FUNC_END

