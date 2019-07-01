FUNC_BEGIN(0x1008a9d0, 0x6f7396c297e02f60, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x78, 0xb3, 0xd, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x89, 0x82, 0xdd, 0, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1008a9d0, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1008a9d5, 0x5)   calld(sys_check_available_stack_size, 0xdb378); /* call 0x10165d52 */
    II(0x1008a9da, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008a9db, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008a9dc, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008a9dd, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008a9de, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008a9df, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008a9e1, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1008a9e7, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1008a9ea, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1008a9ed, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008a9f0, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1008a9f3, 0x6)   mov(memd_a32(ds, edx + 0xdd), eax);   /* mov [edx+0xdd], eax */
    II(0x1008a9f9, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008a9fb, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008a9fc, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008a9fd, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008a9fe, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008a9ff, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008aa00, 0x1)   retd();                               /* ret */
FUNC_END

