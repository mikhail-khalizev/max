FUNC_BEGIN(0x101551d4, 0x8a0653f9bfb35e5b, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x74, 0xb, 0x1, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x6d, 0x51, 0xfe, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x101551d4, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x101551d9, 0x5)   calld(sys_check_available_stack_size, 0x10b74); /* call 0x10165d52 */
    II(0x101551de, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101551df, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101551e0, 0x1)   pushd(esi);                           /* push esi */
    II(0x101551e1, 0x1)   pushd(edi);                           /* push edi */
    II(0x101551e2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101551e3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101551e5, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x101551eb, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x101551ee, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x101551f1, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x101551f4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101551f7, 0x5)   calld(0x1013a369, -0x1ae93);          /* call 0x1013a369 */
    II(0x101551fc, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101551fe, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101551ff, 0x1)   popd(edi);                            /* pop edi */
    II(0x10155200, 0x1)   popd(esi);                            /* pop esi */
    II(0x10155201, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10155202, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10155203, 0x1)   retd();                               /* ret */
FUNC_END

