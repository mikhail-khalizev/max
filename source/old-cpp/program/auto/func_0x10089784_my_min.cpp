FUNC_BEGIN(my_min, 0x293e093e288fd7b0, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xc4, 0xc5, 0xd, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x3b, 0x45, 0xfc, 0x7e, 0x8, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0xeb, 0x6, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10089784, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x10089789, 0x5)   calld(sys_check_available_stack_size, 0xdc5c4); /* call 0x10165d52 */
    II(0x1008978e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008978f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10089790, 0x1)   pushd(esi);                           /* push esi */
    II(0x10089791, 0x1)   pushd(edi);                           /* push edi */
    II(0x10089792, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10089793, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10089795, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x1008979b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1008979e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100897a1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100897a4, 0x3)   cmp(eax, memd_a32(ss, ebp - 0x4));    /* cmp eax, [ebp-0x4] */
    II(0x100897a7, 0x2)   jled(0x100897b1, 0x8);                /* jle 0x100897b1 */
    II(0x100897a9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100897ac, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100897af, 0x2)   jmpd(0x100897b7, 0x6);                /* jmp 0x100897b7 */
l_0x100897b1:
    II(0x100897b1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100897b4, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
l_0x100897b7:
    II(0x100897b7, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100897ba, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x100897bd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100897c0, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100897c2, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100897c3, 0x1)   popd(edi);                            /* pop edi */
    II(0x100897c4, 0x1)   popd(esi);                            /* pop esi */
    II(0x100897c5, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100897c6, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100897c7, 0x1)   retd();                               /* ret */
FUNC_END

