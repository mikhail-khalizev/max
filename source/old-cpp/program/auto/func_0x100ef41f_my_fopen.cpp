FUNC_BEGIN(my_fopen, 0x5580e29f3bac0613, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x29, 0x69, 0x7, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x33, 0x2f, 0x8, 0, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100ef41f, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100ef424, 0x5)   calld(sys_check_available_stack_size, 0x76929); /* call 0x10165d52 */
    II(0x100ef429, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ef42a, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ef42b, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ef42c, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ef42d, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ef42e, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ef430, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100ef436, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100ef439, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100ef43c, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x100ef43f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ef442, 0x5)   calld(sys_fopen, 0x82f33);            /* call 0x1017237a */
    II(0x100ef447, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100ef44a, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100ef44d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ef44f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ef450, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ef451, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ef452, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ef453, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ef454, 0x1)   retd();                               /* ret */
FUNC_END

