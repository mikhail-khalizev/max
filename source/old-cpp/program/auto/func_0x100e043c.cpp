FUNC_BEGIN(0x100e043c, 0x730637b0272dd932, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xc, 0x59, 0x8, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf8, 0xe8, 0xbe, 0x59, 0xf9, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100e043c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100e0441, 0x5)   calld(sys_check_available_stack_size, 0x8590c); /* call 0x10165d52 */
    II(0x100e0446, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e0447, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e0448, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e0449, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e044a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e044b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e044d, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100e0453, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100e0456, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100e0459, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
//    II(0x100e045e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e0461, 0x5)   calld(0x10075e24, -0x6a642);          /* call 0x10075e24 */
    II(0x100e0466, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100e0469, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e046c, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100e046f, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100e0472, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e0474, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e0475, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e0476, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e0477, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e0478, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e0479, 0x1)   retd();                               /* ret */
FUNC_END

