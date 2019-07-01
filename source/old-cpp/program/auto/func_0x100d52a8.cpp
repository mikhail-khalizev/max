FUNC_BEGIN(0x100d52a8, 0xeac82d2193ac2c17, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xba, 0x78, 0x36, 0x1c, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xb2, 0xfa, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100d52a8, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d52a9, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d52aa, 0x1)   pushd(edx);                           /* push edx */
    II(0x100d52ab, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d52ac, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d52ad, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d52ae, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d52b0, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100d52b6, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100d52b9, 0x5)   mov(edx, 0x101c3678);                 /* mov edx, 0x101c3678 */
//    II(0x100d52be, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d52c1, 0x5)   calld(0x100d4d78, -0x54e);            /* call 0x100d4d78 */
    II(0x100d52c6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d52c9, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d52cb, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d52cc, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d52cd, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d52ce, 0x1)   popd(edx);                            /* pop edx */
    II(0x100d52cf, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d52d0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d52d1, 0x1)   retd();                               /* ret */
FUNC_END

