FUNC_BEGIN(/* sys */ 0x1019b79b, 0x7ba0fe8b2cc450b, 0x20, ({0x53, 0x51, 0x56, 0x89, 0xc6, 0x89, 0xd1, 0xb8, 0x2, 0, 0, 0, 0xe8, 0x7d, 0xd, 0, 0, 0x89, 0xc3, 0x89, 0xf0, 0x89, 0xda, 0x8b, 0x4, 0x85, 0x8, 0x77, 0x1b, 0x10, 0xe8, 0x8f, 0x57, 0xfe, 0xff, 0xb8, 0xf9, 0x37, 0x1b, 0x10, 0x89, 0xda, 0xe8, 0x83, 0x57, 0xfe, 0xff, 0x89, 0xda, 0x89, 0xc8, 0xe8, 0x7a, 0x57, 0xfe, 0xff, 0xb8, 0xa, 0, 0, 0, 0x89, 0xda, 0xe8, 0x12, 0x72, 0xfd, 0xff, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1019b79b, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1019b79c, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1019b79d, 0x1)   pushd(esi);                           /* push esi */
    II(0x1019b79e, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x1019b7a0, 0x2)   mov(ecx, edx);                        /* mov ecx, edx */
    II(0x1019b7a2, 0x5)   mov(eax, 0x2);                        /* mov eax, 0x2 */
    II(0x1019b7a7, 0x5)   calld(0x1019c529, 0xd7d);             /* call 0x1019c529 */
    II(0x1019b7ac, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x1019b7ae, 0x2)   mov(eax, esi);                        /* mov eax, esi */
    II(0x1019b7b0, 0x2)   mov(edx, ebx);                        /* mov edx, ebx */
    II(0x1019b7b2, 0x7)   mov(eax, memd_a32(ds, eax * 0x4 + 0x101b7708)); /* mov eax, [eax*4+0x101b7708] */
    II(0x1019b7b9, 0x5)   calld(/* sys */ 0x10180f4d, -0x1a871); /* call 0x10180f4d */
    II(0x1019b7be, 0x5)   mov(eax, 0x101b37f9);                 /* mov eax, 0x101b37f9 */ /* " in " */
    II(0x1019b7c3, 0x2)   mov(edx, ebx);                        /* mov edx, ebx */
    II(0x1019b7c5, 0x5)   calld(/* sys */ 0x10180f4d, -0x1a87d); /* call 0x10180f4d */
    II(0x1019b7ca, 0x2)   mov(edx, ebx);                        /* mov edx, ebx */
    II(0x1019b7cc, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x1019b7ce, 0x5)   calld(/* sys */ 0x10180f4d, -0x1a886); /* call 0x10180f4d */
    II(0x1019b7d3, 0x5)   mov(eax, 0xa);                        /* mov eax, 0xa */
    II(0x1019b7d8, 0x2)   mov(edx, ebx);                        /* mov edx, ebx */
    II(0x1019b7da, 0x5)   calld(/* sys */ 0x101729f1, -0x28dee); /* call 0x101729f1 */
    II(0x1019b7df, 0x1)   popd(esi);                            /* pop esi */
    II(0x1019b7e0, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1019b7e1, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1019b7e2, 0x1)   retd();                               /* ret */
FUNC_END

