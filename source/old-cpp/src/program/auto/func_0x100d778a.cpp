FUNC_BEGIN(0x100d778a, 0x83e71a842e9bb813, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xbe, 0xe5, 0x8, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x66, 0x89, 0x42, 0x2b, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100d778a, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100d778f, 0x5)   calld(sys_check_available_stack_size, 0x8e5be); /* call 0x10165d52 */
    II(0x100d7794, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d7795, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d7796, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d7797, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d7798, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d7799, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d779b, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100d77a1, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100d77a4, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100d77a7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d77aa, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100d77ad, 0x4)   mov(memw_a32(ds, edx + 0x2b), ax);    /* mov [edx+0x2b], ax */
    II(0x100d77b1, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d77b3, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d77b4, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d77b5, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d77b6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d77b7, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d77b8, 0x1)   retd();                               /* ret */
FUNC_END

