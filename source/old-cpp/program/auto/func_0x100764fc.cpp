FUNC_BEGIN(0x100764fc, 0xde14366c5b025700, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x4c, 0xf8, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x39, 0x8, 0, 0, 0x89, 0x45, 0xfc, 0x8d, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100764fc, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x10076501, 0x5)   calld(sys_check_available_stack_size, 0xef84c); /* call 0x10165d52 */
    II(0x10076506, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10076507, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10076508, 0x1)   pushd(edx);                           /* push edx */
    II(0x10076509, 0x1)   pushd(esi);                           /* push esi */
    II(0x1007650a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1007650b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1007650c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007650e, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10076514, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10076517, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007651a, 0x5)   calld(0x10076d58, 0x839);             /* call 0x10076d58 */
    II(0x1007651f, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10076522, 0x3)   lea(eax, ebp - 0x4);                  /* lea eax, [ebp-0x4] */
    II(0x10076525, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10076528, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007652b, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1007652e, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10076531, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10076533, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10076534, 0x1)   popd(edi);                            /* pop edi */
    II(0x10076535, 0x1)   popd(esi);                            /* pop esi */
    II(0x10076536, 0x1)   popd(edx);                            /* pop edx */
    II(0x10076537, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10076538, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10076539, 0x1)   retd();                               /* ret */
FUNC_END

