FUNC_BEGIN(0x100a9eb9, 0x7aa9ea60db1bd224, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x8f, 0xbe, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x55, 0xfc, 0xb8, 0x80, 0x31, 0x1c, 0x10, 0xe8, 0x6f, 0xa6, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100a9eb9, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100a9ebe, 0x5)   calld(sys_check_available_stack_size, 0xbbe8f); /* call 0x10165d52 */
    II(0x100a9ec3, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a9ec4, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a9ec5, 0x1)   pushd(edx);                           /* push edx */
    II(0x100a9ec6, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a9ec7, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a9ec8, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a9ec9, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a9ecb, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100a9ed1, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100a9ed4, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100a9ed7, 0x5)   mov(eax, 0x101c3180);                 /* mov eax, 0x101c3180 */
    II(0x100a9edc, 0x5)   calld(0x100a4550, -0x5991);           /* call 0x100a4550 */
    II(0x100a9ee1, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a9ee3, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a9ee4, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a9ee5, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a9ee6, 0x1)   popd(edx);                            /* pop edx */
    II(0x100a9ee7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a9ee8, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a9ee9, 0x1)   retd();                               /* ret */
FUNC_END

