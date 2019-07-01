FUNC_BEGIN(0x10124e17, 0xcc6a5d9680e9012e, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x31, 0xf, 0x4, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0xb8, 0x5d, 0, 0, 0, 0xe8, 0x9c, 0xff, 0xff, 0xff, 0x31, 0xc0, 0xe8, 0xd3, 0xfd, 0xff, 0xff, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10124e17, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10124e1c, 0x5)   calld(sys_check_available_stack_size, 0x40f31); /* call 0x10165d52 */
    II(0x10124e21, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10124e22, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10124e23, 0x1)   pushd(edx);                           /* push edx */
    II(0x10124e24, 0x1)   pushd(esi);                           /* push esi */
    II(0x10124e25, 0x1)   pushd(edi);                           /* push edi */
    II(0x10124e26, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10124e27, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10124e29, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10124e2f, 0x5)   mov(eax, 0x5d);                       /* mov eax, 0x5d */
    II(0x10124e34, 0x5)   calld(0x10124dd5, -0x64);             /* call 0x10124dd5 */
    II(0x10124e39, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10124e3b, 0x5)   calld(0x10124c13, -0x22d);            /* call 0x10124c13 */
    II(0x10124e40, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10124e43, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10124e46, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10124e48, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10124e49, 0x1)   popd(edi);                            /* pop edi */
    II(0x10124e4a, 0x1)   popd(esi);                            /* pop esi */
    II(0x10124e4b, 0x1)   popd(edx);                            /* pop edx */
    II(0x10124e4c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10124e4d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10124e4e, 0x1)   retd();                               /* ret */
FUNC_END

