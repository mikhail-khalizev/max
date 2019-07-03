FUNC_BEGIN(0x10089ffc, 0x410935aa4fe7fc3c, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x4c, 0xbd, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0x23, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10089ffc, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1008a001, 0x5)   calld(sys_check_available_stack_size, 0xdbd4c); /* call 0x10165d52 */
    II(0x1008a006, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008a007, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008a008, 0x1)   pushd(edx);                           /* push edx */
    II(0x1008a009, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008a00a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008a00b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008a00c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008a00e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1008a014, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1008a017, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008a01a, 0x4)   mov(ax, memw_a32(ds, eax + 0x23));    /* mov ax, [eax+0x23] */
    II(0x1008a01e, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1008a021, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008a024, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008a026, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008a027, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008a028, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008a029, 0x1)   popd(edx);                            /* pop edx */
    II(0x1008a02a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008a02b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008a02c, 0x1)   retd();                               /* ret */
FUNC_END

