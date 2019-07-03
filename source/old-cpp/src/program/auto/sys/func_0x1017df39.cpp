FUNC_BEGIN(/* sys */ 0x1017df39, 0xc33c7b823a4d70a6, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0, 0, 0, 0, 0xe8, 0xcd, 0x6c, 0x1, 0, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xcb}))
    II(0x1017df39, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1017df3a, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1017df3b, 0x1)   pushd(edx);                           /* push edx */
    II(0x1017df3c, 0x1)   pushd(esi);                           /* push esi */
    II(0x1017df3d, 0x1)   pushd(edi);                           /* push edi */
    II(0x1017df3e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1017df3f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1017df41, 0x6)   sub(esp, 0);                          /* sub esp, 0x0 */
    II(0x1017df47, 0x5)   calld(/* sys */ 0x10194c19, 0x16ccd); /* call 0x10194c19 */
    II(0x1017df4c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1017df4d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1017df4e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1017df4f, 0x1)   popd(edx);                            /* pop edx */
    II(0x1017df50, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1017df51, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1017df52, 0x1)   retfd();                              /* retf */
FUNC_END

