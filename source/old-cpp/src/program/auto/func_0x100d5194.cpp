FUNC_BEGIN(0x100d5194, 0x86dcf09ea4620108, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xb4, 0xb, 0x9, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x89, 0x42, 0x24, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100d5194, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100d5199, 0x5)   calld(sys_check_available_stack_size, 0x90bb4); /* call 0x10165d52 */
    II(0x100d519e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d519f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d51a0, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d51a1, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d51a2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d51a3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d51a5, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100d51ab, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100d51ae, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100d51b1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d51b4, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100d51b7, 0x3)   mov(memd_a32(ds, edx + 0x24), eax);   /* mov [edx+0x24], eax */
    II(0x100d51ba, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d51bc, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d51bd, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d51be, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d51bf, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d51c0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d51c1, 0x1)   retd();                               /* ret */
FUNC_END

