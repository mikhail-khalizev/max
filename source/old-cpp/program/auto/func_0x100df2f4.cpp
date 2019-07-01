FUNC_BEGIN(0x100df2f4, 0x294173b439f8051d, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x54, 0x6a, 0x8, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x5, 0xf0, 0x2, 0, 0, 0xe8, 0x33, 0x19, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100df2f4, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100df2f9, 0x5)   calld(sys_check_available_stack_size, 0x86a54); /* call 0x10165d52 */
    II(0x100df2fe, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100df2ff, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100df300, 0x1)   pushd(esi);                           /* push esi */
    II(0x100df301, 0x1)   pushd(edi);                           /* push edi */
    II(0x100df302, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100df303, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100df305, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100df30b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100df30e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100df311, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x100df314, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100df317, 0x5)   add(eax, 0x2f0);                      /* add eax, 0x2f0 */
    II(0x100df31c, 0x5)   calld(0x100e0c54, 0x1933);            /* call 0x100e0c54 */
    II(0x100df321, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100df323, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100df324, 0x1)   popd(edi);                            /* pop edi */
    II(0x100df325, 0x1)   popd(esi);                            /* pop esi */
    II(0x100df326, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100df327, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100df328, 0x1)   retd();                               /* ret */
FUNC_END

