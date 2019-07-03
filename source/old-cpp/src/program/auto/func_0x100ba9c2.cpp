FUNC_BEGIN(0x100ba9c2, 0xaa38db400e2caa05, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x86, 0xb3, 0xa, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x88, 0x5d, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x100ba9c2, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100ba9c7, 0x5)   calld(sys_check_available_stack_size, 0xab386); /* call 0x10165d52 */
    II(0x100ba9cc, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ba9cd, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ba9ce, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ba9cf, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ba9d0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ba9d2, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100ba9d8, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100ba9db, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x100ba9de, 0x3)   mov(memb_a32(ss, ebp - 0x4), bl);     /* mov [ebp-0x4], bl */
    II(0x100ba9e1, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ba9e3, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ba9e4, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ba9e5, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ba9e6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ba9e7, 0x1)   retd();                               /* ret */
FUNC_END

