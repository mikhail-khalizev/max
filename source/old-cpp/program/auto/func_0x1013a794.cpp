FUNC_BEGIN(0x1013a794, 0x29e14df800792b30, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xb4, 0xb5, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xf, 0xbf, 0, 0x6b, 0xc0, 0x12, 0x83, 0xc0, 0x4, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1013a794, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1013a799, 0x5)   calld(sys_check_available_stack_size, 0x2b5b4); /* call 0x10165d52 */
    II(0x1013a79e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013a79f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013a7a0, 0x1)   pushd(edx);                           /* push edx */
    II(0x1013a7a1, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013a7a2, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013a7a3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013a7a4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013a7a6, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1013a7ac, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1013a7af, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013a7b2, 0x3)   movsx(eax, memw_a32(ds, eax));        /* movsx eax, word [eax] */
    II(0x1013a7b5, 0x3)   imul(eax, eax, 0x12);                 /* imul eax, eax, 0x12 */
    II(0x1013a7b8, 0x3)   add(eax, 0x4);                        /* add eax, 0x4 */
    II(0x1013a7bb, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1013a7be, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013a7c1, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013a7c3, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013a7c4, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013a7c5, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013a7c6, 0x1)   popd(edx);                            /* pop edx */
    II(0x1013a7c7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013a7c8, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013a7c9, 0x1)   retd();                               /* ret */
FUNC_END

