FUNC_BEGIN(0x1013a854, 0x52420a16f6737ed, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xf4, 0xb4, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf, 0xbf, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x16, 0, 0, 0, 0x83, 0xc0, 0x6, 0xe8, 0x4b, 0xc5, 0xf3, 0xff, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013a854, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1013a859, 0x5)   calld(sys_check_available_stack_size, 0x2b4f4); /* call 0x10165d52 */
    II(0x1013a85e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013a85f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013a860, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013a861, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013a862, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013a863, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013a865, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1013a86b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013a86e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1013a871, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x4));  /* movsx edx, word [ebp-0x4] */
    II(0x1013a875, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013a878, 0x5)   calld(0x1013a893, 0x16);              /* call 0x1013a893 */
    II(0x1013a87d, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x1013a880, 0x5)   calld(0x10076dd0, -0xc3ab5);          /* call 0x10076dd0 */
    II(0x1013a885, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1013a888, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1013a88b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013a88d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013a88e, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013a88f, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013a890, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013a891, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013a892, 0x1)   retd();                               /* ret */
FUNC_END

