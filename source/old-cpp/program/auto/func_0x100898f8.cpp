FUNC_BEGIN(0x100898f8, 0x25b9f0efe0a2170e, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x50, 0xc4, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x3a, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100898f8, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100898fd, 0x5)   calld(sys_check_available_stack_size, 0xdc450); /* call 0x10165d52 */
    II(0x10089902, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10089903, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10089904, 0x1)   pushd(edx);                           /* push edx */
    II(0x10089905, 0x1)   pushd(esi);                           /* push esi */
    II(0x10089906, 0x1)   pushd(edi);                           /* push edi */
    II(0x10089907, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10089908, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008990a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10089910, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10089913, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10089916, 0x3)   mov(eax, memd_a32(ds, eax + 0x3a));   /* mov eax, [eax+0x3a] */
    II(0x10089919, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1008991c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008991f, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10089921, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10089922, 0x1)   popd(edi);                            /* pop edi */
    II(0x10089923, 0x1)   popd(esi);                            /* pop esi */
    II(0x10089924, 0x1)   popd(edx);                            /* pop edx */
    II(0x10089925, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10089926, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10089927, 0x1)   retd();                               /* ret */
FUNC_END

