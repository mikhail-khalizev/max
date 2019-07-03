FUNC_BEGIN(0x10145381, 0x7fa7b2905c81fc7d, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xc7, 0x9, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10145381, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10145386, 0x5)   calld(sys_check_available_stack_size, 0x209c7); /* call 0x10165d52 */
    II(0x1014538b, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1014538c, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1014538d, 0x1)   pushd(edx);                           /* push edx */
    II(0x1014538e, 0x1)   pushd(esi);                           /* push esi */
    II(0x1014538f, 0x1)   pushd(edi);                           /* push edi */
    II(0x10145390, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10145391, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10145393, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10145399, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1014539c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1014539e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1014539f, 0x1)   popd(edi);                            /* pop edi */
    II(0x101453a0, 0x1)   popd(esi);                            /* pop esi */
    II(0x101453a1, 0x1)   popd(edx);                            /* pop edx */
    II(0x101453a2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101453a3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101453a4, 0x1)   retd();                               /* ret */
FUNC_END

