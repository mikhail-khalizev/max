FUNC_BEGIN(0x10120864, 0xf2d8764293400b6b, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xe4, 0x54, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x1f, 0x9a, 0x1, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10120864, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10120869, 0x5)   calld(sys_check_available_stack_size, 0x454e4); /* call 0x10165d52 */
    II(0x1012086e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1012086f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10120870, 0x1)   pushd(esi);                           /* push esi */
    II(0x10120871, 0x1)   pushd(edi);                           /* push edi */
    II(0x10120872, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10120873, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10120875, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1012087b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1012087e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10120881, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x10120884, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10120887, 0x5)   calld(0x1013a2ab, 0x19a1f);           /* call 0x1013a2ab */
    II(0x1012088c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1012088e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1012088f, 0x1)   popd(edi);                            /* pop edi */
    II(0x10120890, 0x1)   popd(esi);                            /* pop esi */
    II(0x10120891, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10120892, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10120893, 0x1)   retd();                               /* ret */
FUNC_END

