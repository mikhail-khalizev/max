FUNC_BEGIN(0x10076204, 0xf82fdf8091836c62, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x44, 0xfb, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x70, 0xe8, 0xb6, 0x6, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10076204, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10076209, 0x5)   calld(sys_check_available_stack_size, 0xefb44); /* call 0x10165d52 */
    II(0x1007620e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1007620f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10076210, 0x1)   pushd(edx);                           /* push edx */
    II(0x10076211, 0x1)   pushd(esi);                           /* push esi */
    II(0x10076212, 0x1)   pushd(edi);                           /* push edi */
    II(0x10076213, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10076214, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10076216, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1007621c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1007621f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10076222, 0x3)   add(eax, 0x70);                       /* add eax, 0x70 */
    II(0x10076225, 0x5)   calld(0x100768e0, 0x6b6);             /* call 0x100768e0 */
    II(0x1007622a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1007622d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10076230, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10076232, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10076233, 0x1)   popd(edi);                            /* pop edi */
    II(0x10076234, 0x1)   popd(esi);                            /* pop esi */
    II(0x10076235, 0x1)   popd(edx);                            /* pop edx */
    II(0x10076236, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10076237, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10076238, 0x1)   retd();                               /* ret */
FUNC_END

