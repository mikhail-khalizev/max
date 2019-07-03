FUNC_BEGIN(0x100cb39c, 0xd44839c9acd700bd, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xac, 0xa9, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x51, 0, 0xfc, 0xff, 0x83, 0xc0, 0x6, 0xe8, 0xcd, 0x17, 0xfd, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cb39c, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100cb3a1, 0x5)   calld(sys_check_available_stack_size, 0x9a9ac); /* call 0x10165d52 */
    II(0x100cb3a6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cb3a7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cb3a8, 0x1)   pushd(edx);                           /* push edx */
    II(0x100cb3a9, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cb3aa, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cb3ab, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cb3ac, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cb3ae, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100cb3b4, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100cb3b7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cb3ba, 0x5)   calld(0x1008b410, -0x3ffaf);          /* call 0x1008b410 */
    II(0x100cb3bf, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x100cb3c2, 0x5)   calld(0x1009cb94, -0x2e833);          /* call 0x1009cb94 */
    II(0x100cb3c7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cb3c9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cb3ca, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cb3cb, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cb3cc, 0x1)   popd(edx);                            /* pop edx */
    II(0x100cb3cd, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cb3ce, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cb3cf, 0x1)   retd();                               /* ret */
FUNC_END

