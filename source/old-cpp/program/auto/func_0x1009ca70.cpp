FUNC_BEGIN(0x1009ca70, 0x9a1d87635413f38, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xd8, 0x92, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x1c, 0xd6, 0x9, 0, 0x89, 0x45, 0xfc, 0x8d, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1009ca70, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1009ca75, 0x5)   calld(sys_check_available_stack_size, 0xc92d8); /* call 0x10165d52 */
    II(0x1009ca7a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009ca7b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009ca7c, 0x1)   pushd(edx);                           /* push edx */
    II(0x1009ca7d, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009ca7e, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009ca7f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009ca80, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009ca82, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1009ca88, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1009ca8b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009ca8e, 0x5)   calld(0x1013a0af, 0x9d61c);           /* call 0x1013a0af */
    II(0x1009ca93, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1009ca96, 0x3)   lea(eax, ebp - 0x4);                  /* lea eax, [ebp-0x4] */
    II(0x1009ca99, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1009ca9c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009ca9f, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1009caa2, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1009caa5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009caa7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009caa8, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009caa9, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009caaa, 0x1)   popd(edx);                            /* pop edx */
    II(0x1009caab, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009caac, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009caad, 0x1)   retd();                               /* ret */
FUNC_END

