FUNC_BEGIN(0x101635d0, 0xa66025966049b387, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x78, 0x27, 0, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xb8, 0, 0xb1, 0x1c, 0x10, 0xe8, 0x6f, 0xd7, 0xfb, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101635d0, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x101635d5, 0x5)   calld(sys_check_available_stack_size, 0x2778); /* call 0x10165d52 */
    II(0x101635da, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101635db, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101635dc, 0x1)   pushd(edx);                           /* push edx */
    II(0x101635dd, 0x1)   pushd(esi);                           /* push esi */
    II(0x101635de, 0x1)   pushd(edi);                           /* push edi */
    II(0x101635df, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101635e0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101635e2, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x101635e8, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x101635eb, 0x5)   mov(eax, 0x101cb100);                 /* mov eax, 0x101cb100 */
    II(0x101635f0, 0x5)   calld(0x10120d64, -0x42891);          /* call 0x10120d64 */
    II(0x101635f5, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x101635f8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101635fb, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101635fd, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101635fe, 0x1)   popd(edi);                            /* pop edi */
    II(0x101635ff, 0x1)   popd(esi);                            /* pop esi */
    II(0x10163600, 0x1)   popd(edx);                            /* pop edx */
    II(0x10163601, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10163602, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10163603, 0x1)   retd();                               /* ret */
FUNC_END

