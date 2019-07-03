FUNC_BEGIN(0x10099ead, 0x72a623fd41c19de6, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x9b, 0xbe, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0xed, 0x24, 0, 0, 0xe8, 0xa, 0x9e, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10099ead, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10099eb2, 0x5)   calld(sys_check_available_stack_size, 0xcbe9b); /* call 0x10165d52 */
    II(0x10099eb7, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10099eb8, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10099eb9, 0x1)   pushd(edx);                           /* push edx */
    II(0x10099eba, 0x1)   pushd(esi);                           /* push esi */
    II(0x10099ebb, 0x1)   pushd(edi);                           /* push edi */
    II(0x10099ebc, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10099ebd, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10099ebf, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10099ec5, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10099ec8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10099ecb, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x10099ece, 0x5)   calld(0x1009c3c0, 0x24ed);            /* call 0x1009c3c0 */
    II(0x10099ed3, 0x5)   calld(0x10093ce2, -0x61f6);           /* call 0x10093ce2 */
    II(0x10099ed8, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10099eda, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10099edb, 0x1)   popd(edi);                            /* pop edi */
    II(0x10099edc, 0x1)   popd(esi);                            /* pop esi */
    II(0x10099edd, 0x1)   popd(edx);                            /* pop edx */
    II(0x10099ede, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10099edf, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10099ee0, 0x1)   retd();                               /* ret */
FUNC_END

