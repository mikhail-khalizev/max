FUNC_BEGIN(0x1008982c, 0x4927e21a68b2db9d, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x1c, 0xc5, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0xa, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1008982c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10089831, 0x5)   calld(sys_check_available_stack_size, 0xdc51c); /* call 0x10165d52 */
    II(0x10089836, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10089837, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10089838, 0x1)   pushd(edx);                           /* push edx */
    II(0x10089839, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008983a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008983b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008983c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008983e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10089844, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10089847, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008984a, 0x4)   mov(ax, memw_a32(ds, eax + 0xa));     /* mov ax, [eax+0xa] */
    II(0x1008984e, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10089851, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10089854, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10089856, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10089857, 0x1)   popd(edi);                            /* pop edi */
    II(0x10089858, 0x1)   popd(esi);                            /* pop esi */
    II(0x10089859, 0x1)   popd(edx);                            /* pop edx */
    II(0x1008985a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008985b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008985c, 0x1)   retd();                               /* ret */
FUNC_END

