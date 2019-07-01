FUNC_BEGIN(0x10147e40, 0x7142dd5cee758b1e, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x8, 0xdf, 0x1, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x47, 0x27, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10147e40, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10147e45, 0x5)   calld(sys_check_available_stack_size, 0x1df08); /* call 0x10165d52 */
    II(0x10147e4a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10147e4b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10147e4c, 0x1)   pushd(esi);                           /* push esi */
    II(0x10147e4d, 0x1)   pushd(edi);                           /* push edi */
    II(0x10147e4e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10147e4f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10147e51, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10147e57, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10147e5a, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10147e5d, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x10147e60, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10147e63, 0x5)   calld(0x1013a5af, -0xd8b9);           /* call 0x1013a5af */
    II(0x10147e68, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10147e6a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10147e6b, 0x1)   popd(edi);                            /* pop edi */
    II(0x10147e6c, 0x1)   popd(esi);                            /* pop esi */
    II(0x10147e6d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10147e6e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10147e6f, 0x1)   retd();                               /* ret */
FUNC_END

