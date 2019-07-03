FUNC_BEGIN(0x100e0bfc, 0xcc5040740c6a17c7, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xba, 0xa4, 0x35, 0x1c, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x5e, 0x41, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100e0bfc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e0bfd, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e0bfe, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e0bff, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e0c00, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e0c01, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e0c02, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e0c04, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100e0c0a, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100e0c0d, 0x5)   mov(edx, 0x101c35a4);                 /* mov edx, 0x101c35a4 */
//    II(0x100e0c12, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e0c15, 0x5)   calld(0x100d4d78, -0xbea2);           /* call 0x100d4d78 */
    II(0x100e0c1a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e0c1d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e0c1f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e0c20, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e0c21, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e0c22, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e0c23, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e0c24, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e0c25, 0x1)   retd();                               /* ret */
FUNC_END

