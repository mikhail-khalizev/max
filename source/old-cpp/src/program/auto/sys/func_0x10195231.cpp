FUNC_BEGIN(/* sys */ 0x10195231, 0x395946e84bea2db1, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0xc4, 0x35, 0xb8, 0x1a, 0x1c, 0x10, 0x8b, 0x45, 0x8, 0x8b, 0xd8, 0xd1, 0xe0, 0xc1, 0xe3, 0x2, 0x3, 0xd8, 0x8b, 0x45, 0xc, 0x26, 0x89, 0x4, 0x1e, 0x66, 0x26, 0x8c, 0x5c, 0x1e, 0x4, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x10195231, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10195232, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10195234, 0x1)   pushd(esi);                           /* push esi */
    II(0x10195235, 0x1)   pushd(edi);                           /* push edi */
    II(0x10195236, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10195237, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10195238, 0x2)   pushd(fs);                            /* push fs */
    II(0x1019523a, 0x2)   pushd(gs);                            /* push gs */
    II(0x1019523c, 0x1)   pushd(es);                            /* push es */
    II(0x1019523d, 0x6)   les(esi, ds, 0x101c1ab8);             /* les esi, [0x101c1ab8] */
    II(0x10195243, 0x3)   mov(eax, memd_a32(ss, ebp + 0x8));    /* mov eax, [ebp+0x8] */
    II(0x10195246, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x10195248, 0x2)   shl(eax, 0x1);                        /* shl eax, 1 */
    II(0x1019524a, 0x3)   shl(ebx, 0x2);                        /* shl ebx, 0x2 */
    II(0x1019524d, 0x2)   add(ebx, eax);                        /* add ebx, eax */
    II(0x1019524f, 0x3)   mov(eax, memd_a32(ss, ebp + 0xc));    /* mov eax, [ebp+0xc] */
    II(0x10195252, 0x4)   mov(memd_a32(es, esi + ebx), eax);    /* mov [es:esi+ebx], eax */
    II(0x10195256, 0x6)   mov(memw_a32(es, esi + ebx + 0x4), ds); /* mov [es:esi+ebx+0x4], ds */
    II(0x1019525c, 0x1)   popd(es);                             /* pop es */
    II(0x1019525d, 0x2)   popd(gs);                             /* pop gs */
    II(0x1019525f, 0x2)   popd(fs);                             /* pop fs */
    II(0x10195261, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10195262, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10195263, 0x1)   popd(edi);                            /* pop edi */
    II(0x10195264, 0x1)   popd(esi);                            /* pop esi */
    II(0x10195265, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10195266, 0x1)   retd();                               /* ret */
FUNC_END

