FUNC_BEGIN(0x10117d58, 0x9717cf30496baf06, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xf0, 0xdf, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x18, 0xef, 0xf5, 0xff, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10117d58, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10117d5d, 0x5)   calld(sys_check_available_stack_size, 0x4dff0); /* call 0x10165d52 */
    II(0x10117d62, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10117d63, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10117d64, 0x1)   pushd(esi);                           /* push esi */
    II(0x10117d65, 0x1)   pushd(edi);                           /* push edi */
    II(0x10117d66, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10117d67, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10117d69, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10117d6f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10117d72, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10117d75, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x10117d78, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10117d7b, 0x5)   calld(0x10076c98, -0xa10e8);          /* call 0x10076c98 */
    II(0x10117d80, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x10117d83, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10117d86, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10117d88, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10117d89, 0x1)   popd(edi);                            /* pop edi */
    II(0x10117d8a, 0x1)   popd(esi);                            /* pop esi */
    II(0x10117d8b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10117d8c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10117d8d, 0x1)   retd();                               /* ret */
FUNC_END

