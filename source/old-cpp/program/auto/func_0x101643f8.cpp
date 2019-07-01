FUNC_BEGIN(0x101643f8, 0x33d8286bb0a6764a, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x50, 0x19, 0, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xe8, 0x34, 0x4, 0, 0, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xfc, 0xe8, 0xd5, 0x3, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101643f8, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x101643fd, 0x5)   calld(sys_check_available_stack_size, 0x1950); /* call 0x10165d52 */
    II(0x10164402, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10164403, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10164404, 0x1)   pushd(edx);                           /* push edx */
    II(0x10164405, 0x1)   pushd(esi);                           /* push esi */
    II(0x10164406, 0x1)   pushd(edi);                           /* push edi */
    II(0x10164407, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10164408, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1016440a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10164410, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10164413, 0x5)   calld(0x1016484c, 0x434);             /* call 0x1016484c */
    II(0x10164418, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x1016441b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1016441e, 0x5)   calld(0x101647f8, 0x3d5);             /* call 0x101647f8 */
    II(0x10164423, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10164426, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10164429, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1016442b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1016442c, 0x1)   popd(edi);                            /* pop edi */
    II(0x1016442d, 0x1)   popd(esi);                            /* pop esi */
    II(0x1016442e, 0x1)   popd(edx);                            /* pop edx */
    II(0x1016442f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10164430, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10164431, 0x1)   retd();                               /* ret */
FUNC_END

