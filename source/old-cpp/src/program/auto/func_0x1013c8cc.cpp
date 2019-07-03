FUNC_BEGIN(0x1013c8cc, 0x659928826156c773, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x7c, 0x94, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x66, 0x89, 0x2, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013c8cc, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1013c8d1, 0x5)   calld(sys_check_available_stack_size, 0x2947c); /* call 0x10165d52 */
    II(0x1013c8d6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013c8d7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013c8d8, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013c8d9, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013c8da, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013c8db, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013c8dd, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1013c8e3, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013c8e6, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1013c8e9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c8ec, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1013c8ef, 0x3)   mov(memw_a32(ds, edx), ax);           /* mov [edx], ax */
    II(0x1013c8f2, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013c8f4, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013c8f5, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013c8f6, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013c8f7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013c8f8, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013c8f9, 0x1)   retd();                               /* ret */
FUNC_END

