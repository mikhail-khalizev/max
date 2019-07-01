FUNC_BEGIN(0x10106ebf, 0x7ce0747689b7c027, 0x20, ({0x68, 0x1c, 0, 0, 0, 0xe8, 0x89, 0xee, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0, 0, 0, 0, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10106ebf, 0x5)   pushd(0x1c);                          /* push dword 0x1c */
    II(0x10106ec4, 0x5)   calld(sys_check_available_stack_size, 0x5ee89); /* call 0x10165d52 */
    II(0x10106ec9, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10106eca, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10106ecb, 0x1)   pushd(edx);                           /* push edx */
    II(0x10106ecc, 0x1)   pushd(esi);                           /* push esi */
    II(0x10106ecd, 0x1)   pushd(edi);                           /* push edi */
    II(0x10106ece, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10106ecf, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10106ed1, 0x6)   sub(esp, 0);                          /* sub esp, 0x0 */
    II(0x10106ed7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10106ed8, 0x1)   popd(edi);                            /* pop edi */
    II(0x10106ed9, 0x1)   popd(esi);                            /* pop esi */
    II(0x10106eda, 0x1)   popd(edx);                            /* pop edx */
    II(0x10106edb, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10106edc, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10106edd, 0x1)   retd();                               /* ret */
FUNC_END

