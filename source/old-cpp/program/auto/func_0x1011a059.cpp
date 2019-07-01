FUNC_BEGIN(0x1011a059, 0xfee4839464996896, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xef, 0xbc, 0x4, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xb8, 0x16, 0x53, 0x1c, 0x10, 0xe8, 0xe6, 0x6c, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1011a059, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1011a05e, 0x5)   calld(sys_check_available_stack_size, 0x4bcef); /* call 0x10165d52 */
    II(0x1011a063, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011a064, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011a065, 0x1)   pushd(edx);                           /* push edx */
    II(0x1011a066, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011a067, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011a068, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011a069, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011a06b, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1011a071, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1011a074, 0x5)   mov(eax, 0x101c5316);                 /* mov eax, 0x101c5316 */
    II(0x1011a079, 0x5)   calld(0x10120d64, 0x6ce6);            /* call 0x10120d64 */
    II(0x1011a07e, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1011a081, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011a084, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011a086, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011a087, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011a088, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011a089, 0x1)   popd(edx);                            /* pop edx */
    II(0x1011a08a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011a08b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011a08c, 0x1)   retd();                               /* ret */
FUNC_END

