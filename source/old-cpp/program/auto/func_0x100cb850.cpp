FUNC_BEGIN(0x100cb850, 0x6c776f4a4570483c, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xf8, 0xa4, 0x9, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x4d, 0xf4, 0x6, 0, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100cb850, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100cb855, 0x5)   calld(sys_check_available_stack_size, 0x9a4f8); /* call 0x10165d52 */
    II(0x100cb85a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cb85b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cb85c, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cb85d, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cb85e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cb85f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cb861, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100cb867, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100cb86a, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100cb86d, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x100cb870, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100cb873, 0x5)   calld(0x1013acc5, 0x6f44d);           /* call 0x1013acc5 */
    II(0x100cb878, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100cb87b, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100cb87e, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cb880, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cb881, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cb882, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cb883, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cb884, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cb885, 0x1)   retd();                               /* ret */
FUNC_END

