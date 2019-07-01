FUNC_BEGIN(0x10089b00, 0x3886fa05f79ccb8e, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x48, 0xc2, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xd, 0xd1, 0xfe, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10089b00, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10089b05, 0x5)   calld(sys_check_available_stack_size, 0xdc248); /* call 0x10165d52 */
    II(0x10089b0a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10089b0b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10089b0c, 0x1)   pushd(edx);                           /* push edx */
    II(0x10089b0d, 0x1)   pushd(esi);                           /* push esi */
    II(0x10089b0e, 0x1)   pushd(edi);                           /* push edi */
    II(0x10089b0f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10089b10, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10089b12, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10089b18, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10089b1b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10089b1e, 0x5)   calld(0x10076c30, -0x12ef3);          /* call 0x10076c30 */
    II(0x10089b23, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10089b26, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10089b29, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10089b2b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10089b2c, 0x1)   popd(edi);                            /* pop edi */
    II(0x10089b2d, 0x1)   popd(esi);                            /* pop esi */
    II(0x10089b2e, 0x1)   popd(edx);                            /* pop edx */
    II(0x10089b2f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10089b30, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10089b31, 0x1)   retd();                               /* ret */
FUNC_END

