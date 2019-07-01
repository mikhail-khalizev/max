FUNC_BEGIN(0x10147c80, 0x5835628d6a72d069, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xc8, 0xe0, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0xe, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10147c80, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10147c85, 0x5)   calld(sys_check_available_stack_size, 0x1e0c8); /* call 0x10165d52 */
    II(0x10147c8a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10147c8b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10147c8c, 0x1)   pushd(edx);                           /* push edx */
    II(0x10147c8d, 0x1)   pushd(esi);                           /* push esi */
    II(0x10147c8e, 0x1)   pushd(edi);                           /* push edi */
    II(0x10147c8f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10147c90, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10147c92, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10147c98, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10147c9b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10147c9e, 0x3)   add(eax, 0xe);                        /* add eax, 0xe */
    II(0x10147ca1, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10147ca4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10147ca7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10147ca9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10147caa, 0x1)   popd(edi);                            /* pop edi */
    II(0x10147cab, 0x1)   popd(esi);                            /* pop esi */
    II(0x10147cac, 0x1)   popd(edx);                            /* pop edx */
    II(0x10147cad, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10147cae, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10147caf, 0x1)   retd();                               /* ret */
FUNC_END

