FUNC_BEGIN(0x100e0a20, 0x9f7ca9145be1ee18, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0xc7, 0x45, 0xfc, 0x5, 0, 0, 0, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100e0a20, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e0a21, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e0a22, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e0a23, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e0a24, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e0a25, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e0a26, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e0a28, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100e0a2e, 0x7)   mov(memd_a32(ss, ebp - 0x4), 0x5);    /* mov dword [ebp-0x4], 0x5 */
    II(0x100e0a35, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e0a38, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e0a3a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e0a3b, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e0a3c, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e0a3d, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e0a3e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e0a3f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e0a40, 0x1)   retd();                               /* ret */
FUNC_END

