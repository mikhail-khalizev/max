FUNC_BEGIN(0x1009c864, 0x5b80672ae0d8fc86, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xe4, 0x94, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x77, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1009c864, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1009c869, 0x5)   calld(sys_check_available_stack_size, 0xc94e4); /* call 0x10165d52 */
    II(0x1009c86e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009c86f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009c870, 0x1)   pushd(edx);                           /* push edx */
    II(0x1009c871, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009c872, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009c873, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009c874, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009c876, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1009c87c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1009c87f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009c882, 0x3)   add(eax, 0x77);                       /* add eax, 0x77 */
    II(0x1009c885, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1009c888, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009c88b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009c88d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009c88e, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009c88f, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009c890, 0x1)   popd(edx);                            /* pop edx */
    II(0x1009c891, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009c892, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009c893, 0x1)   retd();                               /* ret */
FUNC_END

