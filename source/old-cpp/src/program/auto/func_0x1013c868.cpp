FUNC_BEGIN(0x1013c868, 0x17909676b60c4b86, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xe0, 0x94, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x66, 0x89, 0x42, 0x6, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013c868, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1013c86d, 0x5)   calld(sys_check_available_stack_size, 0x294e0); /* call 0x10165d52 */
    II(0x1013c872, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013c873, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013c874, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013c875, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013c876, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013c877, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013c879, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1013c87f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013c882, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1013c885, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c888, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1013c88b, 0x4)   mov(memw_a32(ds, edx + 0x6), ax);     /* mov [edx+0x6], ax */
    II(0x1013c88f, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013c891, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013c892, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013c893, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013c894, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013c895, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013c896, 0x1)   retd();                               /* ret */
FUNC_END

