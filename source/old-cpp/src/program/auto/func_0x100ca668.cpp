FUNC_BEGIN(0x100ca668, 0xea5e4a0c565931f3, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xe0, 0xb6, 0x9, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x7d, 0xf8, 0x8b, 0x75, 0xfc, 0x66, 0xa5, 0xa4, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100ca668, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100ca66d, 0x5)   calld(sys_check_available_stack_size, 0x9b6e0); /* call 0x10165d52 */
    II(0x100ca672, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ca673, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ca674, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ca675, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ca676, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ca677, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ca679, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100ca67f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100ca682, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100ca685, 0x3)   mov(edi, memd_a32(ss, ebp - 0x8));    /* mov edi, [ebp-0x8] */
    II(0x100ca688, 0x3)   mov(esi, memd_a32(ss, ebp - 0x4));    /* mov esi, [ebp-0x4] */
    II(0x100ca68b, 0x2)   movsw_a32();                          /* movsw */
    II(0x100ca68d, 0x1)   movsb_a32();                          /* movsb */
    II(0x100ca68e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ca691, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100ca694, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100ca697, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ca699, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ca69a, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ca69b, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ca69c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ca69d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ca69e, 0x1)   retd();                               /* ret */
FUNC_END

