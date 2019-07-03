FUNC_BEGIN(0x1012b568, 0x53c198248e838b12, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xe0, 0xa7, 0x3, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0x14, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1012b568, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1012b56d, 0x5)   calld(sys_check_available_stack_size, 0x3a7e0); /* call 0x10165d52 */
    II(0x1012b572, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1012b573, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1012b574, 0x1)   pushd(edx);                           /* push edx */
    II(0x1012b575, 0x1)   pushd(esi);                           /* push esi */
    II(0x1012b576, 0x1)   pushd(edi);                           /* push edi */
    II(0x1012b577, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1012b578, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1012b57a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1012b580, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1012b583, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1012b586, 0x4)   mov(ax, memw_a32(ds, eax + 0x14));    /* mov ax, [eax+0x14] */
    II(0x1012b58a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1012b58d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1012b590, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1012b592, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1012b593, 0x1)   popd(edi);                            /* pop edi */
    II(0x1012b594, 0x1)   popd(esi);                            /* pop esi */
    II(0x1012b595, 0x1)   popd(edx);                            /* pop edx */
    II(0x1012b596, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1012b597, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1012b598, 0x1)   retd();                               /* ret */
FUNC_END

