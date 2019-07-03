FUNC_BEGIN(0x100a90d0, 0x3982a246cb7c3c7d, 0x20, ({0x68, 0x1c, 0, 0, 0, 0xe8, 0x78, 0xcc, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0, 0, 0, 0, 0xb8, 0x80, 0x31, 0x1c, 0x10, 0xe8, 0xc1, 0xaf, 0xff, 0xff, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100a90d0, 0x5)   pushd(0x1c);                          /* push dword 0x1c */
    II(0x100a90d5, 0x5)   calld(sys_check_available_stack_size, 0xbcc78); /* call 0x10165d52 */
    II(0x100a90da, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a90db, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a90dc, 0x1)   pushd(edx);                           /* push edx */
    II(0x100a90dd, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a90de, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a90df, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a90e0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a90e2, 0x6)   sub(esp, 0);                          /* sub esp, 0x0 */
    II(0x100a90e8, 0x5)   mov(eax, 0x101c3180);                 /* mov eax, 0x101c3180 */
    II(0x100a90ed, 0x5)   calld(0x100a40b3, -0x503f);           /* call 0x100a40b3 */
    II(0x100a90f2, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a90f3, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a90f4, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a90f5, 0x1)   popd(edx);                            /* pop edx */
    II(0x100a90f6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a90f7, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a90f8, 0x1)   retd();                               /* ret */
FUNC_END

