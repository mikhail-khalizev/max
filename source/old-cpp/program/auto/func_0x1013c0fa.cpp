FUNC_BEGIN(0x1013c0fa, 0x21dc199d884000a7, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x4e, 0x9c, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xbb, 0x2, 0, 0, 0, 0x8d, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x2e, 0xff, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013c0fa, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1013c0ff, 0x5)   calld(sys_check_available_stack_size, 0x29c4e); /* call 0x10165d52 */
    II(0x1013c104, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013c105, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013c106, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013c107, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013c108, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013c109, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013c10b, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1013c111, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013c114, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1013c117, 0x5)   mov(ebx, 0x2);                        /* mov ebx, 0x2 */
    II(0x1013c11c, 0x3)   lea(edx, ebp - 0x4);                  /* lea edx, [ebp-0x4] */
    II(0x1013c11f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013c122, 0x5)   calld(0x1013c055, -0xd2);             /* call 0x1013c055 */
    II(0x1013c127, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013c129, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013c12a, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013c12b, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013c12c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013c12d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013c12e, 0x1)   retd();                               /* ret */
FUNC_END

