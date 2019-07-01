FUNC_BEGIN(0x100eb14d, 0x2c8e4ea7850e328d, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xfb, 0xab, 0x7, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x23, 0xe8, 0x57, 0xad, 0x7, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100eb14d, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100eb152, 0x5)   calld(sys_check_available_stack_size, 0x7abfb); /* call 0x10165d52 */
    II(0x100eb157, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100eb158, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100eb159, 0x1)   pushd(esi);                           /* push esi */
    II(0x100eb15a, 0x1)   pushd(edi);                           /* push edi */
    II(0x100eb15b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100eb15c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100eb15e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100eb164, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100eb167, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100eb16a, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x100eb16d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100eb170, 0x3)   mov(eax, memd_a32(ds, eax + 0x23));   /* mov eax, [eax+0x23] */
    II(0x100eb173, 0x5)   calld(sys_strcpy, 0x7ad57);           /* call 0x10165ecf */
    II(0x100eb178, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100eb17a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100eb17b, 0x1)   popd(edi);                            /* pop edi */
    II(0x100eb17c, 0x1)   popd(esi);                            /* pop esi */
    II(0x100eb17d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100eb17e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100eb17f, 0x1)   retd();                               /* ret */
FUNC_END

