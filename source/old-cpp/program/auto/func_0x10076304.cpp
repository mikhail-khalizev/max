FUNC_BEGIN(0x10076304, 0x8034ff426948d, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x44, 0xfa, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xf9, 0x7, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10076304, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10076309, 0x5)   calld(sys_check_available_stack_size, 0xefa44); /* call 0x10165d52 */
    II(0x1007630e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1007630f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10076310, 0x1)   pushd(edx);                           /* push edx */
    II(0x10076311, 0x1)   pushd(esi);                           /* push esi */
    II(0x10076312, 0x1)   pushd(edi);                           /* push edi */
    II(0x10076313, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10076314, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10076316, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1007631c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1007631f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10076322, 0x5)   calld(0x10076b20, 0x7f9);             /* call 0x10076b20 */
    II(0x10076327, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1007632a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1007632d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1007632f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10076330, 0x1)   popd(edi);                            /* pop edi */
    II(0x10076331, 0x1)   popd(esi);                            /* pop esi */
    II(0x10076332, 0x1)   popd(edx);                            /* pop edx */
    II(0x10076333, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10076334, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10076335, 0x1)   retd();                               /* ret */
FUNC_END

