FUNC_BEGIN(0x100b8244, 0xf1449ecab48911f8, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x4, 0xdb, 0xa, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x11, 0x2a, 0x8, 0, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100b8244, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b8249, 0x5)   calld(sys_check_available_stack_size, 0xadb04); /* call 0x10165d52 */
    II(0x100b824e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b824f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b8250, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b8251, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b8252, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b8253, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b8255, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100b825b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100b825e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100b8261, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x100b8264, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b8267, 0x5)   calld(0x1013ac7d, 0x82a11);           /* call 0x1013ac7d */
    II(0x100b826c, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100b826f, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b8272, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b8274, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b8275, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b8276, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b8277, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b8278, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b8279, 0x1)   retd();                               /* ret */
FUNC_END

