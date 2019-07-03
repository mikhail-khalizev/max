FUNC_BEGIN(0x10106084, 0x6e9ef4b2990241d7, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xc4, 0xfc, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x50, 0xe8, 0x75, 0xd5, 0x1, 0, 0x83, 0xc4, 0x4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10106084, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10106089, 0x5)   calld(sys_check_available_stack_size, 0x5fcc4); /* call 0x10165d52 */
    II(0x1010608e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1010608f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10106090, 0x1)   pushd(edx);                           /* push edx */
    II(0x10106091, 0x1)   pushd(esi);                           /* push esi */
    II(0x10106092, 0x1)   pushd(edi);                           /* push edi */
    II(0x10106093, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10106094, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10106096, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1010609c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1010609f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101060a2, 0x1)   pushd(eax);                           /* push eax */
    II(0x101060a3, 0x5)   calld(0x1012361d, 0x1d575);           /* call 0x1012361d */
    II(0x101060a8, 0x3)   add(esp, 0x4);                        /* add esp, 0x4 */
    II(0x101060ab, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101060ad, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101060ae, 0x1)   popd(edi);                            /* pop edi */
    II(0x101060af, 0x1)   popd(esi);                            /* pop esi */
    II(0x101060b0, 0x1)   popd(edx);                            /* pop edx */
    II(0x101060b1, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101060b2, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101060b3, 0x1)   retd();                               /* ret */
FUNC_END

