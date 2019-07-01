FUNC_BEGIN(0x10104614, 0x32a09044e71fc0d9, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x34, 0x17, 0x6, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x73, 0x5f, 0x3, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10104614, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10104619, 0x5)   calld(sys_check_available_stack_size, 0x61734); /* call 0x10165d52 */
    II(0x1010461e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1010461f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10104620, 0x1)   pushd(esi);                           /* push esi */
    II(0x10104621, 0x1)   pushd(edi);                           /* push edi */
    II(0x10104622, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10104623, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10104625, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1010462b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1010462e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10104631, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x10104634, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10104637, 0x5)   calld(0x1013a5af, 0x35f73);           /* call 0x1013a5af */
    II(0x1010463c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1010463e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1010463f, 0x1)   popd(edi);                            /* pop edi */
    II(0x10104640, 0x1)   popd(esi);                            /* pop esi */
    II(0x10104641, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10104642, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10104643, 0x1)   retd();                               /* ret */
FUNC_END

