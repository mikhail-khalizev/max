FUNC_BEGIN(0x10089cd8, 0x2b14f2ce2bd03daf, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x70, 0xc0, 0xd, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xab, 0x5, 0xb, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10089cd8, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10089cdd, 0x5)   calld(sys_check_available_stack_size, 0xdc070); /* call 0x10165d52 */
    II(0x10089ce2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10089ce3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10089ce4, 0x1)   pushd(esi);                           /* push esi */
    II(0x10089ce5, 0x1)   pushd(edi);                           /* push edi */
    II(0x10089ce6, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10089ce7, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10089ce9, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10089cef, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10089cf2, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10089cf5, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x10089cf8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10089cfb, 0x5)   calld(0x1013a2ab, 0xb05ab);           /* call 0x1013a2ab */
    II(0x10089d00, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10089d02, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10089d03, 0x1)   popd(edi);                            /* pop edi */
    II(0x10089d04, 0x1)   popd(esi);                            /* pop esi */
    II(0x10089d05, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10089d06, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10089d07, 0x1)   retd();                               /* ret */
FUNC_END

