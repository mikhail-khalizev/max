FUNC_BEGIN(0x10147c48, 0xea69cde0765b716d, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0, 0xe1, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x6, 0xe8, 0x36, 0x5, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10147c48, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10147c4d, 0x5)   calld(sys_check_available_stack_size, 0x1e100); /* call 0x10165d52 */
    II(0x10147c52, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10147c53, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10147c54, 0x1)   pushd(edx);                           /* push edx */
    II(0x10147c55, 0x1)   pushd(esi);                           /* push esi */
    II(0x10147c56, 0x1)   pushd(edi);                           /* push edi */
    II(0x10147c57, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10147c58, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10147c5a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10147c60, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10147c63, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10147c66, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x10147c69, 0x5)   calld(0x101481a4, 0x536);             /* call 0x101481a4 */
    II(0x10147c6e, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10147c71, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10147c74, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10147c76, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10147c77, 0x1)   popd(edi);                            /* pop edi */
    II(0x10147c78, 0x1)   popd(esi);                            /* pop esi */
    II(0x10147c79, 0x1)   popd(edx);                            /* pop edx */
    II(0x10147c7a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10147c7b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10147c7c, 0x1)   retd();                               /* ret */
FUNC_END

