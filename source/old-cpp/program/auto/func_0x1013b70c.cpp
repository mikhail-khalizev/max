FUNC_BEGIN(0x1013b70c, 0x85afeab859f2c58d, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x3c, 0xa6, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xc7, 0, 0xf0, 0x6e, 0x1b, 0x10, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1013b70c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1013b711, 0x5)   calld(sys_check_available_stack_size, 0x2a63c); /* call 0x10165d52 */
    II(0x1013b716, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013b717, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013b718, 0x1)   pushd(edx);                           /* push edx */
    II(0x1013b719, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013b71a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013b71b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013b71c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013b71e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1013b724, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1013b727, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013b72a, 0x6)   mov(memd_a32(ds, eax), 0x101b6ef0);   /* mov dword [eax], 0x101b6ef0 */
    II(0x1013b730, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013b733, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1013b736, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013b739, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013b73b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013b73c, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013b73d, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013b73e, 0x1)   popd(edx);                            /* pop edx */
    II(0x1013b73f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013b740, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013b741, 0x1)   retd();                               /* ret */
FUNC_END

