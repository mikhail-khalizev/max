FUNC_BEGIN(0x100b8dfb, 0x2f7a1d863cdd65ba, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x4d, 0xcf, 0xa, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0xa, 0xe8, 0x93, 0x21, 0xfd, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b8dfb, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b8e00, 0x5)   calld(sys_check_available_stack_size, 0xacf4d); /* call 0x10165d52 */
    II(0x100b8e05, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b8e06, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b8e07, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b8e08, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b8e09, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b8e0a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b8e0b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b8e0d, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b8e13, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100b8e16, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b8e19, 0x3)   add(eax, 0xa);                        /* add eax, 0xa */
    II(0x100b8e1c, 0x5)   calld(0x1008afb4, -0x2de6d);          /* call 0x1008afb4 */
    II(0x100b8e21, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100b8e24, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b8e27, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b8e29, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b8e2a, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b8e2b, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b8e2c, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b8e2d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b8e2e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b8e2f, 0x1)   retd();                               /* ret */
FUNC_END

