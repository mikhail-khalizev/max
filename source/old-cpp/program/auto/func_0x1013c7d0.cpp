FUNC_BEGIN(0x1013c7d0, 0xcde618e64d15b463, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x78, 0x95, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf, 0xbf, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x9b, 0xec, 0xf6, 0xff, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013c7d0, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1013c7d5, 0x5)   calld(sys_check_available_stack_size, 0x29578); /* call 0x10165d52 */
    II(0x1013c7da, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013c7db, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013c7dc, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013c7dd, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013c7de, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013c7df, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013c7e1, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1013c7e7, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013c7ea, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1013c7ed, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x4));  /* movsx edx, word [ebp-0x4] */
    II(0x1013c7f1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013c7f4, 0x5)   calld(0x100ab494, -0x91365);          /* call 0x100ab494 */
    II(0x1013c7f9, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1013c7fc, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1013c7ff, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013c801, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013c802, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013c803, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013c804, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013c805, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013c806, 0x1)   retd();                               /* ret */
FUNC_END

