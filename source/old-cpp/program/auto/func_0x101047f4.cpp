FUNC_BEGIN(0x101047f4, 0x3134a9dbb16d96d8, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x54, 0x15, 0x6, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x6, 0xe8, 0x95, 0x62, 0xf8, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x101047f4, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x101047f9, 0x5)   calld(sys_check_available_stack_size, 0x61554); /* call 0x10165d52 */
    II(0x101047fe, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101047ff, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10104800, 0x1)   pushd(esi);                           /* push esi */
    II(0x10104801, 0x1)   pushd(edi);                           /* push edi */
    II(0x10104802, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10104803, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10104805, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1010480b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1010480e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10104811, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x10104814, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10104817, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x1010481a, 0x5)   calld(0x1008aab4, -0x79d6b);          /* call 0x1008aab4 */
    II(0x1010481f, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10104821, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10104822, 0x1)   popd(edi);                            /* pop edi */
    II(0x10104823, 0x1)   popd(esi);                            /* pop esi */
    II(0x10104824, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10104825, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10104826, 0x1)   retd();                               /* ret */
FUNC_END

