FUNC_BEGIN(0x1009a877, 0x7fbd394408b55db8, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xd1, 0xb4, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0xf, 0xe8, 0x45, 0x7, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0xe8, 0xcf, 0xfb, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1009a877, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1009a87c, 0x5)   calld(sys_check_available_stack_size, 0xcb4d1); /* call 0x10165d52 */
    II(0x1009a881, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009a882, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009a883, 0x1)   pushd(edx);                           /* push edx */
    II(0x1009a884, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009a885, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009a886, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009a887, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009a889, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1009a88f, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1009a892, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1009a894, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009a897, 0x3)   add(eax, 0xf);                        /* add eax, 0xf */
    II(0x1009a89a, 0x5)   calld(0x1008afe4, -0xf8bb);           /* call 0x1008afe4 */
    II(0x1009a89f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009a8a2, 0x5)   calld(0x1009a476, -0x431);            /* call 0x1009a476 */
    II(0x1009a8a7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009a8a9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009a8aa, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009a8ab, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009a8ac, 0x1)   popd(edx);                            /* pop edx */
    II(0x1009a8ad, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009a8ae, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009a8af, 0x1)   retd();                               /* ret */
FUNC_END

