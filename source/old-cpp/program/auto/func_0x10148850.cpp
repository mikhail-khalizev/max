FUNC_BEGIN(0x10148850, 0x6b62590ed331b8aa, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xf8, 0xd4, 0x1, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x9a, 0x18, 0xff, 0xff, 0x89, 0x45, 0xf8, 0x8d, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10148850, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x10148855, 0x5)   calld(sys_check_available_stack_size, 0x1d4f8); /* call 0x10165d52 */
    II(0x1014885a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1014885b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1014885c, 0x1)   pushd(esi);                           /* push esi */
    II(0x1014885d, 0x1)   pushd(edi);                           /* push edi */
    II(0x1014885e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1014885f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10148861, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x10148867, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1014886a, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x1014886d, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x10148870, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10148873, 0x5)   calld(0x1013a112, -0xe766);           /* call 0x1013a112 */
    II(0x10148878, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1014887b, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x1014887e, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10148881, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10148884, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x10148887, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x1014888a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1014888c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1014888d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1014888e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1014888f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10148890, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10148891, 0x1)   retd();                               /* ret */
FUNC_END

