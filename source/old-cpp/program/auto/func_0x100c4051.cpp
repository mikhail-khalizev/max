FUNC_BEGIN(0x100c4051, 0x103aa8fdbb78f20d, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xf7, 0x1c, 0xa, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xe8, 0x2a, 0x1e, 0xa, 0, 0xc1, 0xe0, 0x2, 0xc1, 0xe8, 0xf, 0x89, 0xc2, 0xe8, 0x1d, 0x1e, 0xa, 0, 0xc1, 0xe0, 0x2, 0xc1, 0xe8, 0xf, 0x83, 0xc0, 0x2, 0x83, 0xc2, 0x2, 0x1, 0xc2, 0x8b, 0x45, 0xfc, 0x66, 0x89, 0x50, 0x3, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100c4051, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100c4056, 0x5)   calld(sys_check_available_stack_size, 0xa1cf7); /* call 0x10165d52 */
    II(0x100c405b, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100c405c, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100c405d, 0x1)   pushd(edx);                           /* push edx */
    II(0x100c405e, 0x1)   pushd(esi);                           /* push esi */
    II(0x100c405f, 0x1)   pushd(edi);                           /* push edi */
    II(0x100c4060, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100c4061, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100c4063, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100c4069, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100c406c, 0x5)   calld(/* sys */ 0x10165e9b, 0xa1e2a); /* call 0x10165e9b */
    II(0x100c4071, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
    II(0x100c4074, 0x3)   shr(eax, 0xf);                        /* shr eax, 0xf */
    II(0x100c4077, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x100c4079, 0x5)   calld(/* sys */ 0x10165e9b, 0xa1e1d); /* call 0x10165e9b */
    II(0x100c407e, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
    II(0x100c4081, 0x3)   shr(eax, 0xf);                        /* shr eax, 0xf */
    II(0x100c4084, 0x3)   add(eax, 0x2);                        /* add eax, 0x2 */
    II(0x100c4087, 0x3)   add(edx, 0x2);                        /* add edx, 0x2 */
    II(0x100c408a, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x100c408c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100c408f, 0x4)   mov(memw_a32(ds, eax + 0x3), dx);     /* mov [eax+0x3], dx */
    II(0x100c4093, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100c4095, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100c4096, 0x1)   popd(edi);                            /* pop edi */
    II(0x100c4097, 0x1)   popd(esi);                            /* pop esi */
    II(0x100c4098, 0x1)   popd(edx);                            /* pop edx */
    II(0x100c4099, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100c409a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100c409b, 0x1)   retd();                               /* ret */
FUNC_END

