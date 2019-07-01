FUNC_BEGIN(0x1008a768, 0xb2b24dd964f8e737, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xe0, 0xb5, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x69, 0x7, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1008a768, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1008a76d, 0x5)   calld(sys_check_available_stack_size, 0xdb5e0); /* call 0x10165d52 */
    II(0x1008a772, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008a773, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008a774, 0x1)   pushd(edx);                           /* push edx */
    II(0x1008a775, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008a776, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008a777, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008a778, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008a77a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1008a780, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1008a783, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008a786, 0x5)   calld(0x1008aef4, 0x769);             /* call 0x1008aef4 */
    II(0x1008a78b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1008a78e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008a791, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008a793, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008a794, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008a795, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008a796, 0x1)   popd(edx);                            /* pop edx */
    II(0x1008a797, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008a798, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008a799, 0x1)   retd();                               /* ret */
FUNC_END

