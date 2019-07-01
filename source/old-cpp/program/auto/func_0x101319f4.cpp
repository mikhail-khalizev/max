FUNC_BEGIN(0x101319f4, 0xa82437842fec4743, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x54, 0x43, 0x3, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x6, 0xe8, 0xf2, 0x1, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101319f4, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x101319f9, 0x5)   calld(sys_check_available_stack_size, 0x34354); /* call 0x10165d52 */
    II(0x101319fe, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101319ff, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10131a00, 0x1)   pushd(edx);                           /* push edx */
    II(0x10131a01, 0x1)   pushd(esi);                           /* push esi */
    II(0x10131a02, 0x1)   pushd(edi);                           /* push edi */
    II(0x10131a03, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10131a04, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10131a06, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10131a0c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10131a0f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10131a12, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x10131a15, 0x5)   calld(0x10131c0c, 0x1f2);             /* call 0x10131c0c */
    II(0x10131a1a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10131a1d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10131a20, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10131a22, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10131a23, 0x1)   popd(edi);                            /* pop edi */
    II(0x10131a24, 0x1)   popd(esi);                            /* pop esi */
    II(0x10131a25, 0x1)   popd(edx);                            /* pop edx */
    II(0x10131a26, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10131a27, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10131a28, 0x1)   retd();                               /* ret */
FUNC_END

