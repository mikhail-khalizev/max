FUNC_BEGIN(/* sys */ 0x1016c623, 0x59074d1197d6768a, 0x20, ({0x56, 0x57, 0x55, 0x89, 0xd7, 0x89, 0xdd, 0x89, 0xcb, 0x89, 0xea, 0x89, 0xc6, 0xe8, 0x7f, 0xb3, 0x1, 0, 0x8b, 0x45, 0, 0x5d, 0x5f, 0x5e, 0xc3}))
    II(0x1016c623, 0x1)   pushd(esi);                           /* push esi */
    II(0x1016c624, 0x1)   pushd(edi);                           /* push edi */
    II(0x1016c625, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1016c626, 0x2)   mov(edi, edx);                        /* mov edi, edx */
    II(0x1016c628, 0x2)   mov(ebp, ebx);                        /* mov ebp, ebx */
    II(0x1016c62a, 0x2)   mov(ebx, ecx);                        /* mov ebx, ecx */
    II(0x1016c62c, 0x2)   mov(edx, ebp);                        /* mov edx, ebp */
    II(0x1016c62e, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x1016c630, 0x5)   calld(/* sys */ 0x101879b4, 0x1b37f); /* call 0x101879b4 */
    II(0x1016c635, 0x3)   mov(eax, memd_a32(ss, ebp + 0));      /* mov eax, [ebp+0x0] */
    II(0x1016c638, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1016c639, 0x1)   popd(edi);                            /* pop edi */
    II(0x1016c63a, 0x1)   popd(esi);                            /* pop esi */
    II(0x1016c63b, 0x1)   retd();                               /* ret */
FUNC_END

