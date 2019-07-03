FUNC_BEGIN(0x1008a3a8, 0x8139b87109161222, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xa0, 0xb9, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0xe, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1008a3a8, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1008a3ad, 0x5)   calld(sys_check_available_stack_size, 0xdb9a0); /* call 0x10165d52 */
    II(0x1008a3b2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008a3b3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008a3b4, 0x1)   pushd(edx);                           /* push edx */
    II(0x1008a3b5, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008a3b6, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008a3b7, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008a3b8, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008a3ba, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1008a3c0, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1008a3c3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008a3c6, 0x4)   mov(ax, memw_a32(ds, eax + 0xe));     /* mov ax, [eax+0xe] */
    II(0x1008a3ca, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1008a3cd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008a3d0, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008a3d2, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008a3d3, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008a3d4, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008a3d5, 0x1)   popd(edx);                            /* pop edx */
    II(0x1008a3d6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008a3d7, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008a3d8, 0x1)   retd();                               /* ret */
FUNC_END

