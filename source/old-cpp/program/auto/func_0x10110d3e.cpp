FUNC_BEGIN(0x10110d3e, 0xe12aea500c2211a9, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xa, 0x50, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xc7, 0x40, 0x8, 0x1, 0, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10110d3e, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10110d43, 0x5)   calld(sys_check_available_stack_size, 0x5500a); /* call 0x10165d52 */
    II(0x10110d48, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10110d49, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10110d4a, 0x1)   pushd(edx);                           /* push edx */
    II(0x10110d4b, 0x1)   pushd(esi);                           /* push esi */
    II(0x10110d4c, 0x1)   pushd(edi);                           /* push edi */
    II(0x10110d4d, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10110d4e, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10110d50, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10110d56, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10110d59, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10110d5c, 0x7)   mov(memd_a32(ds, eax + 0x8), 0x1);    /* mov dword [eax+0x8], 0x1 */
    II(0x10110d63, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10110d65, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10110d66, 0x1)   popd(edi);                            /* pop edi */
    II(0x10110d67, 0x1)   popd(esi);                            /* pop esi */
    II(0x10110d68, 0x1)   popd(edx);                            /* pop edx */
    II(0x10110d69, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10110d6a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10110d6b, 0x1)   retd();                               /* ret */
FUNC_END

