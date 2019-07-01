FUNC_BEGIN(0x101194b6, 0xfce0e85f216cad7e, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x92, 0xc8, 0x4, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xb8, 0xfe, 0x52, 0x1c, 0x10, 0xe8, 0x89, 0x78, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101194b6, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x101194bb, 0x5)   calld(sys_check_available_stack_size, 0x4c892); /* call 0x10165d52 */
    II(0x101194c0, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101194c1, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101194c2, 0x1)   pushd(edx);                           /* push edx */
    II(0x101194c3, 0x1)   pushd(esi);                           /* push esi */
    II(0x101194c4, 0x1)   pushd(edi);                           /* push edi */
    II(0x101194c5, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101194c6, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101194c8, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x101194ce, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x101194d1, 0x5)   mov(eax, 0x101c52fe);                 /* mov eax, 0x101c52fe */
    II(0x101194d6, 0x5)   calld(0x10120d64, 0x7889);            /* call 0x10120d64 */
    II(0x101194db, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x101194de, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101194e1, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101194e3, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101194e4, 0x1)   popd(edi);                            /* pop edi */
    II(0x101194e5, 0x1)   popd(esi);                            /* pop esi */
    II(0x101194e6, 0x1)   popd(edx);                            /* pop edx */
    II(0x101194e7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101194e8, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101194e9, 0x1)   retd();                               /* ret */
FUNC_END

