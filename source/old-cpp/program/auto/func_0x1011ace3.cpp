FUNC_BEGIN(0x1011ace3, 0x54d2033856f97b27, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x65, 0xb0, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1011ace3, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1011ace8, 0x5)   calld(sys_check_available_stack_size, 0x4b065); /* call 0x10165d52 */
    II(0x1011aced, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011acee, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011acef, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011acf0, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011acf1, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011acf2, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011acf4, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1011acfa, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1011acfd, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1011ad00, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011ad02, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011ad03, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011ad04, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011ad05, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011ad06, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011ad07, 0x1)   retd();                               /* ret */
FUNC_END

