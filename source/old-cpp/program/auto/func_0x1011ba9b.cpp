FUNC_BEGIN(0x1011ba9b, 0x8841038440adc3eb, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xad, 0xa2, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xc7, 0x45, 0xf4, 0xff, 0x7f, 0, 0, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1011ba9b, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1011baa0, 0x5)   calld(sys_check_available_stack_size, 0x4a2ad); /* call 0x10165d52 */
    II(0x1011baa5, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011baa6, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011baa7, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011baa8, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011baa9, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011baaa, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011baac, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1011bab2, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1011bab5, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1011bab8, 0x7)   mov(memd_a32(ss, ebp - 0xc), 0x7fff); /* mov dword [ebp-0xc], 0x7fff */
    II(0x1011babf, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1011bac2, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011bac4, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011bac5, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011bac6, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011bac7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011bac8, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011bac9, 0x1)   retd();                               /* ret */
FUNC_END

