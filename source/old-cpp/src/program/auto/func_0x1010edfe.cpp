FUNC_BEGIN(0x1010edfe, 0x303eb5ab1f9b8f9d, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x4a, 0x6f, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x50, 0x31, 0xc9, 0xbb, 0xae, 0, 0, 0, 0xba, 0x90, 0x1, 0, 0, 0xb8, 0x2e, 0x2, 0, 0, 0xe8, 0xbe, 0xa0, 0xfd, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1010edfe, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1010ee03, 0x5)   calld(sys_check_available_stack_size, 0x56f4a); /* call 0x10165d52 */
    II(0x1010ee08, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1010ee09, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1010ee0a, 0x1)   pushd(edx);                           /* push edx */
    II(0x1010ee0b, 0x1)   pushd(esi);                           /* push esi */
    II(0x1010ee0c, 0x1)   pushd(edi);                           /* push edi */
    II(0x1010ee0d, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1010ee0e, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1010ee10, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1010ee16, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1010ee19, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010ee1c, 0x1)   pushd(eax);                           /* push eax */
    II(0x1010ee1d, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x1010ee1f, 0x5)   mov(ebx, 0xae);                       /* mov ebx, 0xae */
    II(0x1010ee24, 0x5)   mov(edx, 0x190);                      /* mov edx, 0x190 */
    II(0x1010ee29, 0x5)   mov(eax, 0x22e);                      /* mov eax, 0x22e */
    II(0x1010ee2e, 0x5)   calld(0x100e8ef1, -0x25f42);          /* call 0x100e8ef1 */
    II(0x1010ee33, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1010ee35, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1010ee36, 0x1)   popd(edi);                            /* pop edi */
    II(0x1010ee37, 0x1)   popd(esi);                            /* pop esi */
    II(0x1010ee38, 0x1)   popd(edx);                            /* pop edx */
    II(0x1010ee39, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1010ee3a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1010ee3b, 0x1)   retd();                               /* ret */
FUNC_END

