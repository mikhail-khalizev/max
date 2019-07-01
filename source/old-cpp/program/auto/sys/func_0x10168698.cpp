FUNC_BEGIN(/* sys */ 0x10168698, 0xe7f864d0c15728d1, 0x20, ({0x51, 0x56, 0x89, 0xd6, 0xba, 0x1, 0, 0, 0, 0x89, 0xc1, 0x89, 0xf0, 0xe8, 0xc2, 0x63, 0, 0, 0x5e, 0x59, 0xc3}))
    II(0x10168698, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10168699, 0x1)   pushd(esi);                           /* push esi */
    II(0x1016869a, 0x2)   mov(esi, edx);                        /* mov esi, edx */
    II(0x1016869c, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x101686a1, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x101686a3, 0x2)   mov(eax, esi);                        /* mov eax, esi */
    II(0x101686a5, 0x5)   calld(sys_fread_internal, 0x63c2);    /* call 0x1016ea6c */
    II(0x101686aa, 0x1)   popd(esi);                            /* pop esi */
    II(0x101686ab, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101686ac, 0x1)   retd();                               /* ret */
FUNC_END

