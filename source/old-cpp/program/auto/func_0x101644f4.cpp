FUNC_BEGIN(0x101644f4, 0xbab25b050cd8a669, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x54, 0x18, 0, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x101644f4, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x101644f9, 0x5)   calld(sys_check_available_stack_size, 0x1854); /* call 0x10165d52 */
    II(0x101644fe, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101644ff, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10164500, 0x1)   pushd(esi);                           /* push esi */
    II(0x10164501, 0x1)   pushd(edi);                           /* push edi */
    II(0x10164502, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10164503, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10164505, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1016450b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1016450e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10164511, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10164514, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x10164517, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1016451a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1016451c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1016451d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1016451e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1016451f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10164520, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10164521, 0x1)   retd();                               /* ret */
FUNC_END

