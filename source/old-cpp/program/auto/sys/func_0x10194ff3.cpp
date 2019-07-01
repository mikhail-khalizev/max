FUNC_BEGIN(/* sys */ 0x10194ff3, 0xd154cb6a8b921dd, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0xb8, 0x1, 0, 0, 0, 0xf, 0xb4, 0x7d, 0x10, 0xff, 0x5d, 0x8, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x10194ff3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10194ff4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10194ff6, 0x1)   pushd(esi);                           /* push esi */
    II(0x10194ff7, 0x1)   pushd(edi);                           /* push edi */
    II(0x10194ff8, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10194ff9, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10194ffa, 0x2)   pushd(fs);                            /* push fs */
    II(0x10194ffc, 0x2)   pushd(gs);                            /* push gs */
    II(0x10194ffe, 0x1)   pushd(es);                            /* push es */
    II(0x10194fff, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
    II(0x10195004, 0x4)   lfs(edi, ss, ebp + 0x10);             /* lfs edi, [ebp+0x10] */
    II(0x10195008, 0x3)   calld_a32_far_ind(ss, ebp + 0x8);     /* call dword far [ebp+0x8] */
    II(0x1019500b, 0x1)   popd(es);                             /* pop es */
    II(0x1019500c, 0x2)   popd(gs);                             /* pop gs */
    II(0x1019500e, 0x2)   popd(fs);                             /* pop fs */
    II(0x10195010, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10195011, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10195012, 0x1)   popd(edi);                            /* pop edi */
    II(0x10195013, 0x1)   popd(esi);                            /* pop esi */
    II(0x10195014, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10195015, 0x1)   retd();                               /* ret */
FUNC_END

