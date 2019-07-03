FUNC_BEGIN(0x1011fdf6, 0x317680fc98b936bd, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x52, 0x5f, 0x4, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x55, 0xfc, 0xb8, 0x6c, 0x53, 0x1c, 0x10, 0xe8, 0xfc, 0xe5, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1011fdf6, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1011fdfb, 0x5)   calld(sys_check_available_stack_size, 0x45f52); /* call 0x10165d52 */
    II(0x1011fe00, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011fe01, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011fe02, 0x1)   pushd(edx);                           /* push edx */
    II(0x1011fe03, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011fe04, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011fe05, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011fe06, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011fe08, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1011fe0e, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1011fe11, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1011fe14, 0x5)   mov(eax, 0x101c536c);                 /* mov eax, 0x101c536c */
    II(0x1011fe19, 0x5)   calld(0x1011e41a, -0x1a04);           /* call 0x1011e41a */
    II(0x1011fe1e, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011fe20, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011fe21, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011fe22, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011fe23, 0x1)   popd(edx);                            /* pop edx */
    II(0x1011fe24, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011fe25, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011fe26, 0x1)   retd();                               /* ret */
FUNC_END

