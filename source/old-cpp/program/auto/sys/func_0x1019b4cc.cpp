FUNC_BEGIN(/* sys */ 0x1019b4cc, 0x84b7a208b1dd0ea, 0x20, ({0x53, 0x51, 0x89, 0xc3, 0x89, 0xd0, 0xc1, 0xe8, 0x3, 0x89, 0xc1, 0xc1, 0xe1, 0x3, 0x29, 0xca, 0x8a, 0x92, 0, 0x1d, 0x1c, 0x10, 0x22, 0x14, 0x3, 0x88, 0xd0, 0x59, 0x5b, 0xc3}))
    II(0x1019b4cc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1019b4cd, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1019b4ce, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x1019b4d0, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x1019b4d2, 0x3)   shr(eax, 0x3);                        /* shr eax, 0x3 */
    II(0x1019b4d5, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x1019b4d7, 0x3)   shl(ecx, 0x3);                        /* shl ecx, 0x3 */
    II(0x1019b4da, 0x2)   sub(edx, ecx);                        /* sub edx, ecx */
    II(0x1019b4dc, 0x6)   mov(dl, memb_a32(ds, edx + 0x101c1d00)); /* mov dl, [edx+0x101c1d00] */
    II(0x1019b4e2, 0x3)   and_(dl, memb_a32(ds, ebx + eax));    /* and dl, [ebx+eax] */
    II(0x1019b4e5, 0x2)   mov(al, dl);                          /* mov al, dl */
    II(0x1019b4e7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1019b4e8, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1019b4e9, 0x1)   retd();                               /* ret */
FUNC_END

