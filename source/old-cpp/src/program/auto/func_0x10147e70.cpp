FUNC_BEGIN(0x10147e70, 0x86e716fd19010b14, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xd8, 0xde, 0x1, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x13, 0x24, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10147e70, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10147e75, 0x5)   calld(sys_check_available_stack_size, 0x1ded8); /* call 0x10165d52 */
    II(0x10147e7a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10147e7b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10147e7c, 0x1)   pushd(esi);                           /* push esi */
    II(0x10147e7d, 0x1)   pushd(edi);                           /* push edi */
    II(0x10147e7e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10147e7f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10147e81, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10147e87, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10147e8a, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10147e8d, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x10147e90, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10147e93, 0x5)   calld(0x1013a2ab, -0xdbed);           /* call 0x1013a2ab */
    II(0x10147e98, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10147e9a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10147e9b, 0x1)   popd(edi);                            /* pop edi */
    II(0x10147e9c, 0x1)   popd(esi);                            /* pop esi */
    II(0x10147e9d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10147e9e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10147e9f, 0x1)   retd();                               /* ret */
FUNC_END

