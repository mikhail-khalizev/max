FUNC_BEGIN(0x100d4fec, 0x4c72d689b34c3e8f, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x5c, 0xd, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0xc7, 0x45, 0xfc, 0xb0, 0x35, 0x1c, 0x10, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100d4fec, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100d4ff1, 0x5)   calld(sys_check_available_stack_size, 0x90d5c); /* call 0x10165d52 */
    II(0x100d4ff6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d4ff7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d4ff8, 0x1)   pushd(edx);                           /* push edx */
    II(0x100d4ff9, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d4ffa, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d4ffb, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d4ffc, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d4ffe, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100d5004, 0x7)   mov(memd_a32(ss, ebp - 0x4), 0x101c35b0); /* mov dword [ebp-0x4], 0x101c35b0 */
    II(0x100d500b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d500e, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d5010, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d5011, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d5012, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d5013, 0x1)   popd(edx);                            /* pop edx */
    II(0x100d5014, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d5015, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d5016, 0x1)   retd();                               /* ret */
FUNC_END

