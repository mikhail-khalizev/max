FUNC_BEGIN(0x1009e4c0, 0x369105de828fe297, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x88, 0x78, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc6, 0x45, 0xf8, 0x2b, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1009e4c0, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1009e4c5, 0x5)   calld(sys_check_available_stack_size, 0xc7888); /* call 0x10165d52 */
    II(0x1009e4ca, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009e4cb, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009e4cc, 0x1)   pushd(edx);                           /* push edx */
    II(0x1009e4cd, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009e4ce, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009e4cf, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009e4d0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009e4d2, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1009e4d8, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1009e4db, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x2b);   /* mov byte [ebp-0x8], 0x2b */
    II(0x1009e4df, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x1009e4e2, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009e4e4, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009e4e5, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009e4e6, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009e4e7, 0x1)   popd(edx);                            /* pop edx */
    II(0x1009e4e8, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009e4e9, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009e4ea, 0x1)   retd();                               /* ret */
FUNC_END

