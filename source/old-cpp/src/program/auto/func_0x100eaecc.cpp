FUNC_BEGIN(0x100eaecc, 0x9f7ca9145be1ee18, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0xc7, 0x45, 0xfc, 0x5, 0, 0, 0, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100eaecc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100eaecd, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100eaece, 0x1)   pushd(edx);                           /* push edx */
    II(0x100eaecf, 0x1)   pushd(esi);                           /* push esi */
    II(0x100eaed0, 0x1)   pushd(edi);                           /* push edi */
    II(0x100eaed1, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100eaed2, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100eaed4, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100eaeda, 0x7)   mov(memd_a32(ss, ebp - 0x4), 0x5);    /* mov dword [ebp-0x4], 0x5 */
    II(0x100eaee1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100eaee4, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100eaee6, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100eaee7, 0x1)   popd(edi);                            /* pop edi */
    II(0x100eaee8, 0x1)   popd(esi);                            /* pop esi */
    II(0x100eaee9, 0x1)   popd(edx);                            /* pop edx */
    II(0x100eaeea, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100eaeeb, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100eaeec, 0x1)   retd();                               /* ret */
FUNC_END

