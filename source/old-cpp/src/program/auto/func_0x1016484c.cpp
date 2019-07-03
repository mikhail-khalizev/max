FUNC_BEGIN(0x1016484c, 0x9f7ca9145be1ee18, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0xc7, 0x45, 0xfc, 0x5, 0, 0, 0, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1016484c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1016484d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1016484e, 0x1)   pushd(edx);                           /* push edx */
    II(0x1016484f, 0x1)   pushd(esi);                           /* push esi */
    II(0x10164850, 0x1)   pushd(edi);                           /* push edi */
    II(0x10164851, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10164852, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10164854, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1016485a, 0x7)   mov(memd_a32(ss, ebp - 0x4), 0x5);    /* mov dword [ebp-0x4], 0x5 */
    II(0x10164861, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10164864, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10164866, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10164867, 0x1)   popd(edi);                            /* pop edi */
    II(0x10164868, 0x1)   popd(esi);                            /* pop esi */
    II(0x10164869, 0x1)   popd(edx);                            /* pop edx */
    II(0x1016486a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1016486b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1016486c, 0x1)   retd();                               /* ret */
FUNC_END

