FUNC_BEGIN(0x1013ca6e, 0xf50d1af9403424e3, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xda, 0x92, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xd9, 0x2, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013ca6e, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1013ca73, 0x5)   calld(sys_check_available_stack_size, 0x292da); /* call 0x10165d52 */
    II(0x1013ca78, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013ca79, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013ca7a, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013ca7b, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013ca7c, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013ca7d, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013ca7f, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1013ca85, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013ca88, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x1013ca8b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013ca8e, 0x5)   calld(0x1013cd6c, 0x2d9);             /* call 0x1013cd6c */
    II(0x1013ca93, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013ca96, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1013ca99, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1013ca9c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013ca9e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013ca9f, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013caa0, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013caa1, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013caa2, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013caa3, 0x1)   retd();                               /* ret */
FUNC_END

