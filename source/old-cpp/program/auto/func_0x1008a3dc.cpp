FUNC_BEGIN(0x1008a3dc, 0x55b9fdd980e14021, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x6c, 0xb9, 0xd, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf, 0xbf, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xb, 0x10, 0, 0, 0x83, 0xc0, 0x6, 0xe8, 0x33, 0x10, 0, 0, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1008a3dc, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1008a3e1, 0x5)   calld(sys_check_available_stack_size, 0xdb96c); /* call 0x10165d52 */
    II(0x1008a3e6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008a3e7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008a3e8, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008a3e9, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008a3ea, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008a3eb, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008a3ed, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1008a3f3, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1008a3f6, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1008a3f9, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x4));  /* movsx edx, word [ebp-0x4] */
    II(0x1008a3fd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008a400, 0x5)   calld(0x1008b410, 0x100b);            /* call 0x1008b410 */
    II(0x1008a405, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x1008a408, 0x5)   calld(0x1008b440, 0x1033);            /* call 0x1008b440 */
    II(0x1008a40d, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1008a410, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1008a413, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008a415, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008a416, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008a417, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008a418, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008a419, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008a41a, 0x1)   retd();                               /* ret */
FUNC_END

