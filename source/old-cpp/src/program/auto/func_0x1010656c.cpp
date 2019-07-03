FUNC_BEGIN(0x1010656c, 0x8562afa3915ffaf0, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xdc, 0xf7, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xb8, 0x62, 0x7, 0, 0, 0x50, 0x8b, 0x45, 0xfc, 0x50, 0xe8, 0x2, 0xce, 0x1, 0, 0x83, 0xc4, 0x8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1010656c, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x10106571, 0x5)   calld(sys_check_available_stack_size, 0x5f7dc); /* call 0x10165d52 */
    II(0x10106576, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10106577, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10106578, 0x1)   pushd(edx);                           /* push edx */
    II(0x10106579, 0x1)   pushd(esi);                           /* push esi */
    II(0x1010657a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1010657b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1010657c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1010657e, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10106584, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10106587, 0x5)   mov(eax, 0x762);                      /* mov eax, 0x762 */
    II(0x1010658c, 0x1)   pushd(eax);                           /* push eax */
    II(0x1010658d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10106590, 0x1)   pushd(eax);                           /* push eax */
    II(0x10106591, 0x5)   calld(0x10123398, 0x1ce02);           /* call 0x10123398 */
    II(0x10106596, 0x3)   add(esp, 0x8);                        /* add esp, 0x8 */
    II(0x10106599, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1010659b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1010659c, 0x1)   popd(edi);                            /* pop edi */
    II(0x1010659d, 0x1)   popd(esi);                            /* pop esi */
    II(0x1010659e, 0x1)   popd(edx);                            /* pop edx */
    II(0x1010659f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101065a0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101065a1, 0x1)   retd();                               /* ret */
FUNC_END

