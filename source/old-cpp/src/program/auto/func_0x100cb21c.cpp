FUNC_BEGIN(0x100cb21c, 0x152d8bd5535be934, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x2c, 0xab, 0x9, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x67, 0xf0, 0x6, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100cb21c, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100cb221, 0x5)   calld(sys_check_available_stack_size, 0x9ab2c); /* call 0x10165d52 */
    II(0x100cb226, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cb227, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cb228, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cb229, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cb22a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cb22b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cb22d, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100cb233, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100cb236, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100cb239, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x100cb23c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100cb23f, 0x5)   calld(0x1013a2ab, 0x6f067);           /* call 0x1013a2ab */
    II(0x100cb244, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cb246, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cb247, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cb248, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cb249, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cb24a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cb24b, 0x1)   retd();                               /* ret */
FUNC_END

