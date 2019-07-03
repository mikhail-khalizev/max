FUNC_BEGIN(0x100eacec, 0x6a0ca1f06404fc7, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x5c, 0xb0, 0x7, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x7d, 0xf8, 0x8b, 0x75, 0xfc, 0xa5, 0xa4, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100eacec, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100eacf1, 0x5)   calld(sys_check_available_stack_size, 0x7b05c); /* call 0x10165d52 */
    II(0x100eacf6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100eacf7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100eacf8, 0x1)   pushd(esi);                           /* push esi */
    II(0x100eacf9, 0x1)   pushd(edi);                           /* push edi */
    II(0x100eacfa, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100eacfb, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100eacfd, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100ead03, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100ead06, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100ead09, 0x3)   mov(edi, memd_a32(ss, ebp - 0x8));    /* mov edi, [ebp-0x8] */
    II(0x100ead0c, 0x3)   mov(esi, memd_a32(ss, ebp - 0x4));    /* mov esi, [ebp-0x4] */
    II(0x100ead0f, 0x1)   movsd_a32();                          /* movsd */
    II(0x100ead10, 0x1)   movsb_a32();                          /* movsb */
    II(0x100ead11, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ead14, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100ead17, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100ead1a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ead1c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ead1d, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ead1e, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ead1f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ead20, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ead21, 0x1)   retd();                               /* ret */
FUNC_END

