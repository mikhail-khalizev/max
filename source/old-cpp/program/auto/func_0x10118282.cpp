FUNC_BEGIN(0x10118282, 0xf1e413a388ad9ccb, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xc6, 0xda, 0x4, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xfc, 0x89, 0x5d, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x10118282, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10118287, 0x5)   calld(sys_check_available_stack_size, 0x4dac6); /* call 0x10165d52 */
    II(0x1011828c, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011828d, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011828e, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011828f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10118290, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10118292, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10118298, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x1011829b, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1011829e, 0x3)   mov(memd_a32(ss, ebp - 0x8), ebx);    /* mov [ebp-0x8], ebx */
    II(0x101182a1, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101182a3, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101182a4, 0x1)   popd(edi);                            /* pop edi */
    II(0x101182a5, 0x1)   popd(esi);                            /* pop esi */
    II(0x101182a6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101182a7, 0x1)   retd();                               /* ret */
FUNC_END

