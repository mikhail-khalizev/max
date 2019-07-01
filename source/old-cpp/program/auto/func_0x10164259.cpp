FUNC_BEGIN(0x10164259, 0xe1abe59125c2718b, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xef, 0x1a, 0, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x66, 0xff, 0x40, 0x12, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10164259, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1016425e, 0x5)   calld(sys_check_available_stack_size, 0x1aef); /* call 0x10165d52 */
    II(0x10164263, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10164264, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10164265, 0x1)   pushd(esi);                           /* push esi */
    II(0x10164266, 0x1)   pushd(edi);                           /* push edi */
    II(0x10164267, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10164268, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1016426a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10164270, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10164273, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10164276, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10164279, 0x4)   inc(memw_a32(ds, eax + 0x12));        /* inc word [eax+0x12] */
    II(0x1016427d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1016427f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10164280, 0x1)   popd(edi);                            /* pop edi */
    II(0x10164281, 0x1)   popd(esi);                            /* pop esi */
    II(0x10164282, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10164283, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10164284, 0x1)   retd();                               /* ret */
FUNC_END

