FUNC_BEGIN(0x1010f5d5, 0x82d3bf8b19ede366, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x73, 0x67, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0xe8, 0xf1, 0xfe, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1010f5d5, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1010f5da, 0x5)   calld(sys_check_available_stack_size, 0x56773); /* call 0x10165d52 */
    II(0x1010f5df, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1010f5e0, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1010f5e1, 0x1)   pushd(edx);                           /* push edx */
    II(0x1010f5e2, 0x1)   pushd(esi);                           /* push esi */
    II(0x1010f5e3, 0x1)   pushd(edi);                           /* push edi */
    II(0x1010f5e4, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1010f5e5, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1010f5e7, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1010f5ed, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1010f5f0, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1010f5f2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010f5f5, 0x5)   calld(0x1010f4eb, -0x10f);            /* call 0x1010f4eb */
    II(0x1010f5fa, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1010f5fc, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1010f5fd, 0x1)   popd(edi);                            /* pop edi */
    II(0x1010f5fe, 0x1)   popd(esi);                            /* pop esi */
    II(0x1010f5ff, 0x1)   popd(edx);                            /* pop edx */
    II(0x1010f600, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1010f601, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1010f602, 0x1)   retd();                               /* ret */
FUNC_END

