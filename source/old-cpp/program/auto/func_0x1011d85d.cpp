FUNC_BEGIN(0x1011d85d, 0xc184abac74b7a9c3, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xeb, 0x84, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x66, 0x89, 0x42, 0x11, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1011d85d, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1011d862, 0x5)   calld(sys_check_available_stack_size, 0x484eb); /* call 0x10165d52 */
    II(0x1011d867, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011d868, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011d869, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011d86a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011d86b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011d86c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011d86e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1011d874, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1011d877, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1011d87a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011d87d, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1011d880, 0x4)   mov(memw_a32(ds, edx + 0x11), ax);    /* mov [edx+0x11], ax */
    II(0x1011d884, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011d886, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011d887, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011d888, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011d889, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011d88a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011d88b, 0x1)   retd();                               /* ret */
FUNC_END

