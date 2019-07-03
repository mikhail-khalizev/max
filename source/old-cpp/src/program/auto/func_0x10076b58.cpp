FUNC_BEGIN(0x10076b58, 0xfafd90c5fc300bbc, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xf0, 0xf1, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x2, 0xe8, 0xea, 0, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10076b58, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10076b5d, 0x5)   calld(sys_check_available_stack_size, 0xef1f0); /* call 0x10165d52 */
    II(0x10076b62, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10076b63, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10076b64, 0x1)   pushd(edx);                           /* push edx */
    II(0x10076b65, 0x1)   pushd(esi);                           /* push esi */
    II(0x10076b66, 0x1)   pushd(edi);                           /* push edi */
    II(0x10076b67, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10076b68, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10076b6a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10076b70, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10076b73, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10076b76, 0x3)   add(eax, 0x2);                        /* add eax, 0x2 */
    II(0x10076b79, 0x5)   calld(0x10076c68, 0xea);              /* call 0x10076c68 */
    II(0x10076b7e, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10076b81, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10076b84, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10076b86, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10076b87, 0x1)   popd(edi);                            /* pop edi */
    II(0x10076b88, 0x1)   popd(esi);                            /* pop esi */
    II(0x10076b89, 0x1)   popd(edx);                            /* pop edx */
    II(0x10076b8a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10076b8b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10076b8c, 0x1)   retd();                               /* ret */
FUNC_END

