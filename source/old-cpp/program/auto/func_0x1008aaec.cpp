FUNC_BEGIN(0x1008aaec, 0x3bddcab41f4092be, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x5c, 0xb2, 0xd, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x9b, 0xfa, 0xa, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1008aaec, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1008aaf1, 0x5)   calld(sys_check_available_stack_size, 0xdb25c); /* call 0x10165d52 */
    II(0x1008aaf6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008aaf7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008aaf8, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008aaf9, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008aafa, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008aafb, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008aafd, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1008ab03, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1008ab06, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x1008ab09, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x1008ab0c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008ab0f, 0x5)   calld(0x1013a5af, 0xafa9b);           /* call 0x1013a5af */
    II(0x1008ab14, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008ab16, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008ab17, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008ab18, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008ab19, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008ab1a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008ab1b, 0x1)   retd();                               /* ret */
FUNC_END

