FUNC_BEGIN(0x1009a292, 0xcea1b7cb9c8a63f2, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xb6, 0xba, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0x57, 0xa, 0xa, 0, 0x88, 0x45, 0xf8, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1009a292, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1009a297, 0x5)   calld(sys_check_available_stack_size, 0xcbab6); /* call 0x10165d52 */
    II(0x1009a29c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009a29d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009a29e, 0x1)   pushd(edx);                           /* push edx */
    II(0x1009a29f, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009a2a0, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009a2a1, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009a2a2, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009a2a4, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1009a2aa, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1009a2ad, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1009a2af, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009a2b2, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x1009a2b5, 0x5)   calld(0x1013ad11, 0xa0a57);           /* call 0x1013ad11 */
    II(0x1009a2ba, 0x3)   mov(memb_a32(ss, ebp - 0x8), al);     /* mov [ebp-0x8], al */
//    II(0x1009a2bd, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x1009a2c0, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009a2c2, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009a2c3, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009a2c4, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009a2c5, 0x1)   popd(edx);                            /* pop edx */
    II(0x1009a2c6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009a2c7, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009a2c8, 0x1)   retd();                               /* ret */
FUNC_END

