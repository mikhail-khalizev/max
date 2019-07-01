FUNC_BEGIN(0x10076408, 0xd6587692f788f171, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x40, 0xf9, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x5, 0x8, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10076408, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1007640d, 0x5)   calld(sys_check_available_stack_size, 0xef940); /* call 0x10165d52 */
    II(0x10076412, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10076413, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10076414, 0x1)   pushd(edx);                           /* push edx */
    II(0x10076415, 0x1)   pushd(esi);                           /* push esi */
    II(0x10076416, 0x1)   pushd(edi);                           /* push edi */
    II(0x10076417, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10076418, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007641a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10076420, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10076423, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10076426, 0x5)   calld(0x10076c30, 0x805);             /* call 0x10076c30 */
    II(0x1007642b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1007642e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10076431, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10076433, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10076434, 0x1)   popd(edi);                            /* pop edi */
    II(0x10076435, 0x1)   popd(esi);                            /* pop esi */
    II(0x10076436, 0x1)   popd(edx);                            /* pop edx */
    II(0x10076437, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10076438, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10076439, 0x1)   retd();                               /* ret */
FUNC_END

