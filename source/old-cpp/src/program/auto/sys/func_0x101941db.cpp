FUNC_BEGIN(/* sys */ 0x101941db, 0x8104b2b2d1b87f4b, 0x20, ({0x55, 0x8b, 0xec, 0x55, 0x56, 0x57, 0x53, 0x8b, 0x45, 0x8, 0xcd, 0x10, 0x5b, 0x5f, 0x5e, 0x5d, 0xc9, 0xc3}))
    II(0x101941db, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101941dc, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101941de, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101941df, 0x1)   pushd(esi);                           /* push esi */
    II(0x101941e0, 0x1)   pushd(edi);                           /* push edi */
    II(0x101941e1, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101941e2, 0x3)   mov(eax, memd_a32(ss, ebp + 0x8));    /* mov eax, [ebp+0x8] */
    II(0x101941e5, 0x2)   int_(0x10);                           /* int 0x10 */
    II(0x101941e7, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101941e8, 0x1)   popd(edi);                            /* pop edi */
    II(0x101941e9, 0x1)   popd(esi);                            /* pop esi */
    II(0x101941ea, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101941eb, 0x1)   leaved();                             /* leave */
    II(0x101941ec, 0x1)   retd();                               /* ret */
FUNC_END

