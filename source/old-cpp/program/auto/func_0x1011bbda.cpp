FUNC_BEGIN(0x1011bbda, 0x497ad29df039f435, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x6e, 0xa1, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1011bbda, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1011bbdf, 0x5)   calld(sys_check_available_stack_size, 0x4a16e); /* call 0x10165d52 */
    II(0x1011bbe4, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011bbe5, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011bbe6, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011bbe7, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011bbe8, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011bbe9, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011bbeb, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1011bbf1, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1011bbf4, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1011bbf7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011bbf9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011bbfa, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011bbfb, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011bbfc, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011bbfd, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011bbfe, 0x1)   retd();                               /* ret */
FUNC_END

